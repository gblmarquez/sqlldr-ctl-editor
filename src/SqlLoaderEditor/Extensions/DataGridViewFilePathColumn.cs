using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace SqlLoaderEditor.Extensions
{
    /// <summary>
    /// Hosts a collection of DataGridViewTextBoxCell cells.
    /// </summary>
    public class DataGridViewFilePathColumn : DataGridViewColumn
    {
        private bool showBrowseButton;
        [Browsable(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [DefaultValue(false)]
        [Category("Appearance")]
        [Description("Show a button in each cell for browsing for files.")]
        public bool ShowBrowseButton
        {
            get { return showBrowseButton; }
            set
            {

                showBrowseButton = value;
            }
        }

        private bool useOpenFileDialogOnButtonClick;
        [Browsable(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [DefaultValue(false)]
        [Category("Behavior")]
        [Description("OpenFileDialog is dispalyed and on success the contents of the Cell is replaced with the new file path.")]
        public bool UseOpenFileDialogOnButtonClick
        {
            get { return useOpenFileDialogOnButtonClick; }
            set
            {
                useOpenFileDialogOnButtonClick = value;
            }
        }
        public DataGridViewFilePathColumn()
            : base(new DataGridViewFilePathCell())
        {
            this.CellTemplate = new DataGridViewFilePathCell();
        }
        public override DataGridViewCell CellTemplate
        {
            get
            {
                return base.CellTemplate;
            }
            set
            {
                if (null != value &&
                    !value.GetType().IsAssignableFrom(typeof(DataGridViewFilePathCell)))
                {
                    throw new InvalidCastException("must be a DataGridViewFilePathCell");
                }
                base.CellTemplate = value;
            }
        }
    }

    /// <summary>
    /// Displays editable text information in a DataGridView control. Uses
    /// PathEllipsis formatting if the column is smaller than the width of a
    /// displayed filesystem path.
    /// </summary>
    public class DataGridViewFilePathCell : DataGridViewTextBoxCell
    {
        Button browseButton;
        Dictionary<Color, SolidBrush> brushes = new Dictionary<Color, SolidBrush>();
        protected virtual SolidBrush GetCachedBrush(Color color)
        {
            if (this.brushes.ContainsKey(color))
                return this.brushes[color];
            SolidBrush brush = new SolidBrush(color);
            this.brushes.Add(color, brush);
            return brush;
        }

        protected virtual Button GetBrowseButton(bool wireOpenFileDialog)
        {
            if (null == browseButton)
            {
                browseButton = new Button();
                browseButton.Text = "…";
                browseButton.Click += new EventHandler(browseButton_Click); //yes, really two event handlers!
                if (wireOpenFileDialog)
                    browseButton.Click += new EventHandler(delegate(object sender, EventArgs e)
                    {
                        if (this.RowIndex >= 0)
                        {
                            using (OpenFileDialog ofd = new OpenFileDialog())
                            {
                                if (System.IO.File.Exists((string)this.Value))
                                    ofd.InitialDirectory = System.IO.Path.GetDirectoryName((string)this.Value);
                                if (ofd.ShowDialog() == DialogResult.OK)
                                {
                                    this.Value = ofd.FileName;
                                }
                            }
                        }
                    });
            }
            return browseButton;
        }

        protected virtual bool RightToLeftInternal
        {
            get
            {
                return this.DataGridView.RightToLeft == RightToLeft.Yes;
            }
        }
        protected override void Paint(Graphics graphics, Rectangle clipBounds, Rectangle cellBounds, int rowIndex, DataGridViewElementStates cellState, object value, object formattedValue, string errorText, DataGridViewCellStyle cellStyle, DataGridViewAdvancedBorderStyle advancedBorderStyle, DataGridViewPaintParts paintParts)
        {
            if (cellStyle == null)
            {
                throw new ArgumentNullException("cellStyle");
            }
            this.PaintPrivate(graphics, clipBounds, cellBounds, rowIndex, cellState, formattedValue, errorText, cellStyle, advancedBorderStyle, paintParts);
        }

        protected Rectangle PaintPrivate(Graphics graphics, Rectangle clipBounds, Rectangle cellBounds, int rowIndex, DataGridViewElementStates cellState, object formattedValue, string errorText, DataGridViewCellStyle cellStyle, DataGridViewAdvancedBorderStyle advancedBorderStyle, DataGridViewPaintParts paintParts)
        {
            //System.Diagnostics.Debug.WriteLine(string.Format("Painting Cell row {0} for rowindex {2} with rectangle {1}", this.RowIndex, cellBounds, rowIndex));
            SolidBrush cachedBrush;
            Rectangle empty = Rectangle.Empty;
            if (PaintBorder(paintParts))
            {
                this.PaintBorder(graphics, clipBounds, cellBounds, cellStyle, advancedBorderStyle);
            }
            Rectangle rectangle2 = this.BorderWidths(advancedBorderStyle);
            Rectangle borderedCellRectangle = cellBounds;
            borderedCellRectangle.Offset(rectangle2.X, rectangle2.Y);
            borderedCellRectangle.Width -= rectangle2.Right;
            borderedCellRectangle.Height -= rectangle2.Bottom;
            Point currentCellAddress = base.DataGridView.CurrentCellAddress;
            bool isFirstCell = (currentCellAddress.X == base.ColumnIndex) && (currentCellAddress.Y == rowIndex);
            bool flagisFirstCellAndNotEditing = isFirstCell && (base.DataGridView.EditingControl != null);
            bool thisCellIsSelected = (cellState & DataGridViewElementStates.Selected) != DataGridViewElementStates.None;
            if ((PaintSelectionBackground(paintParts) && thisCellIsSelected) && !flagisFirstCellAndNotEditing)
            {
                cachedBrush = GetCachedBrush(cellStyle.SelectionBackColor);
            }
            else
            {
                cachedBrush = GetCachedBrush(cellStyle.BackColor);
            }
            if (((PaintBackground(paintParts)) && ((cachedBrush.Color.A == 0xff) && (borderedCellRectangle.Width > 0))) && (borderedCellRectangle.Height > 0))
            {
                graphics.FillRectangle(cachedBrush, borderedCellRectangle);
            }
            if (cellStyle.Padding != Padding.Empty)
            {
                if (RightToLeftInternal)
                {
                    borderedCellRectangle.Offset(cellStyle.Padding.Right, cellStyle.Padding.Top);
                }
                else
                {
                    borderedCellRectangle.Offset(cellStyle.Padding.Left, cellStyle.Padding.Top);
                }
                borderedCellRectangle.Width -= cellStyle.Padding.Horizontal;
                borderedCellRectangle.Height -= cellStyle.Padding.Vertical;
            }
            if (((isFirstCell) && (!flagisFirstCellAndNotEditing && PaintFocus(paintParts))) && ((ShowFocusCues && base.DataGridView.Focused) && ((borderedCellRectangle.Width > 0) && (borderedCellRectangle.Height > 0))))
            {
                ControlPaint.DrawFocusRectangle(graphics, borderedCellRectangle, Color.Empty, cachedBrush.Color);
            }
            Rectangle cellValueBounds = borderedCellRectangle;
            string text = formattedValue as string;
            if ((text != null) && (!flagisFirstCellAndNotEditing))
            {
                int y = (cellStyle.WrapMode == DataGridViewTriState.True) ? 1 : 2;
                borderedCellRectangle.Offset(0, y);
                borderedCellRectangle.Width = borderedCellRectangle.Width;
                borderedCellRectangle.Height -= y + 1;
                if ((borderedCellRectangle.Width > 0) && (borderedCellRectangle.Height > 0))
                {
                    TextFormatFlags flags = //DataGridViewUtilities.ComputeTextFormatFlagsForCellStyleAlignment(base.DataGridView.RightToLeftInternal, cellStyle.Alignment, cellStyle.WrapMode);
                        TextFormatFlags.PathEllipsis;

                    if (PaintContentForeground(paintParts))
                    {
                        if ((flags & TextFormatFlags.SingleLine) != TextFormatFlags.GlyphOverhangPadding)
                        {
                            flags |= TextFormatFlags.EndEllipsis;
                        }
                        DataGridViewFilePathColumn filePathColumn = (DataGridViewFilePathColumn)this.DataGridView.Columns[ColumnIndex];
                        if (true && filePathColumn.ShowBrowseButton)
                        {
                            if (this.RowIndex >= 0)
                            {
                                Button browseButton = GetBrowseButton(filePathColumn.UseOpenFileDialogOnButtonClick);
                                bool changed = false;
                                if ((browseButton.Width != Math.Max(10, borderedCellRectangle.Width / 4)) && (browseButton.Width != 20))
                                {
                                    System.Diagnostics.Trace.WriteLine(string.Format("browseButton Width was incorrect:{0} for given rectangle:{1}", browseButton.Width, borderedCellRectangle));
                                    browseButton.Width = Math.Max(10, borderedCellRectangle.Width / 4);
                                    browseButton.Width = Math.Min(browseButton.Width, 20);
                                    changed = true;
                                }
                                if (browseButton.Height != (borderedCellRectangle.Height - 2))
                                {
                                    System.Diagnostics.Trace.WriteLine(string.Format("browseButton Height was incorrect:{0} for given rectangle:{1}", browseButton.Height, borderedCellRectangle));
                                    browseButton.Height = borderedCellRectangle.Height + 2;
                                    changed = true;
                                }
                                Point loc = new Point();
                                loc.X = borderedCellRectangle.X + borderedCellRectangle.Width - browseButton.Width;
                                loc.Y = borderedCellRectangle.Y - 2;
                                if (browseButton.Location != loc)
                                {
                                    System.Diagnostics.Trace.WriteLine(string.Format("browseButton location was incorrect:{0} for given rectangle:{1} with loc: {2}", browseButton.Location, borderedCellRectangle, loc));
                                    browseButton.Location = loc;
                                    changed = true;
                                }
                                if (changed)
                                    browseButton.Invalidate();
                                if (!this.DataGridView.Controls.Contains(browseButton))
                                    this.DataGridView.Controls.Add(browseButton);
                                borderedCellRectangle.Width -= browseButton.Width;
                            }
                        }
                        TextRenderer.DrawText(graphics, text, cellStyle.Font, borderedCellRectangle, thisCellIsSelected ? cellStyle.SelectionForeColor : cellStyle.ForeColor, flags);
                    }

                }
            }
            if ((base.DataGridView.ShowCellErrors) && PaintErrorIcon(paintParts))
            {
                PaintErrorIcon(graphics, cellStyle, rowIndex, cellBounds, cellValueBounds, errorText);
            }
            return empty;
        }


        void browseButton_Click(object sender, EventArgs e)
        {
            this.RaiseCellClick(new DataGridViewCellEventArgs(this.ColumnIndex, this.RowIndex));
        }

        protected virtual Rectangle ComputeErrorIconBounds(Rectangle cellValueBounds)
        {
            if ((cellValueBounds.Width >= 20) && (cellValueBounds.Height >= 0x13))
            {
                return new Rectangle(RightToLeftInternal ? (cellValueBounds.Left + 4) : ((cellValueBounds.Right - 4) - 12), cellValueBounds.Y + ((cellValueBounds.Height - 11) / 2), 12, 11);
            }
            return Rectangle.Empty;
        }

        protected virtual void PaintErrorIcon(Graphics graphics, DataGridViewCellStyle cellStyle, int rowIndex, Rectangle cellBounds, Rectangle cellValueBounds, string errorText)
        {
            if ((!string.IsNullOrEmpty(errorText) && (cellValueBounds.Width >= 20)) && (cellValueBounds.Height >= 0x13))
            {
                Rectangle iconBounds = this.GetErrorIconBounds(graphics, cellStyle, rowIndex);
                if ((iconBounds.Width >= 4) && (iconBounds.Height >= 11))
                {
                    iconBounds.X += cellBounds.X;
                    iconBounds.Y += cellBounds.Y;
                    PaintErrorIcon(graphics, iconBounds);
                }
            }
        }

        protected static void PaintErrorIcon(Graphics graphics, Rectangle iconBounds)
        {
            Bitmap errorBitmap = new Bitmap(typeof(DataGridViewCell), "DataGridViewRow.error.bmp");
            errorBitmap.MakeTransparent();
            if (errorBitmap != null)
            {
                lock (errorBitmap)
                {
                    graphics.DrawImage(errorBitmap, iconBounds, 0, 0, 12, 11, GraphicsUnit.Pixel);
                }
            }
        }

        protected static bool PaintErrorIcon(DataGridViewPaintParts paintParts)
        {
            return ((paintParts & DataGridViewPaintParts.ErrorIcon) != DataGridViewPaintParts.None);
        }
        protected static bool PaintFocus(DataGridViewPaintParts paintParts)
        {
            return ((paintParts & DataGridViewPaintParts.Focus) != DataGridViewPaintParts.None);
        }
        protected static bool PaintBackground(DataGridViewPaintParts paintParts)
        {
            return ((paintParts & DataGridViewPaintParts.Background) != DataGridViewPaintParts.None);
        }
        protected static bool PaintBorder(DataGridViewPaintParts paintParts)
        {
            return ((paintParts & DataGridViewPaintParts.Border) != DataGridViewPaintParts.None);
        }
        protected static bool PaintContentBackground(DataGridViewPaintParts paintParts)
        {
            return ((paintParts & DataGridViewPaintParts.ContentBackground) != DataGridViewPaintParts.None);
        }
        protected static bool PaintContentForeground(DataGridViewPaintParts paintParts)
        {
            return ((paintParts & DataGridViewPaintParts.ContentForeground) != DataGridViewPaintParts.None);
        }
        protected static bool PaintSelectionBackground(DataGridViewPaintParts paintParts)
        {
            return ((paintParts & DataGridViewPaintParts.SelectionBackground) != DataGridViewPaintParts.None);
        }

        public bool ShowFocusCues
        {
            get { return true; }
        }

        protected bool ApplyVisualStylesToHeaders
        {
            get
            {
                if (Application.RenderWithVisualStyles)
                {
                    return this.DataGridView.EnableHeadersVisualStyles;
                }
                return false;
            }
        }

        public DataGridViewFilePathCell()
            : base()
        {
        }
    }
}
