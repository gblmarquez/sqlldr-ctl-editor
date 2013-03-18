using SqlLoaderEditor.Core;
using SqlLoaderEditor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SqlLoaderEditor
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            this.delimitedFieldDataGridView.AutoGenerateColumns = false;
            this.fixedSizeFieldDataGridView.AutoGenerateColumns = false;
            this.fileModelDataGridView.AutoGenerateColumns = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.fixedSizeFieldSpecificationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fixedSizeFieldSpecificationBindingSource.DataSource = typeof(FixedSizeFieldModel);

            this.delimitedFieldSpecificationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.delimitedFieldSpecificationBindingSource.DataSource = typeof(FieldModel);

            this.fileModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fileModelBindingSource.DataSource = typeof(DataFileSpecification);

            SetupFixedGridView();
            SetupDelimitedGridView();
            SetupFileGridView();

            this.loadMethodComboBox.DataSource = Enum.GetValues(typeof(LoadMethods));
            this.controlFileSpecificationBindingSource.AddNew();
            this.terminationAndEnclosureSpecificationBindingSource.AddNew();

            this.isDelimitedCheckBox.Checked = true;
            this.isDelimitedCheckBox.Checked = false;
        }

        private void SetupFileGridView()
        {
            this.fileModelDataGridView.AutoGenerateColumns = false;
            this.fileModelDataGridView.DataSource = fileModelBindingSource;

            var inFileColumn = new SqlLoaderEditor.Extensions.DataGridViewFilePathColumn();
            inFileColumn.DataPropertyName = "InFile";
            inFileColumn.HeaderText = "In File";
            inFileColumn.Name = "InFile";
            inFileColumn.UseOpenFileDialogOnButtonClick = true;
            inFileColumn.ShowBrowseButton = true;
            inFileColumn.MinimumWidth = 200;

            var badFileColumn = new SqlLoaderEditor.Extensions.DataGridViewFilePathColumn();
            badFileColumn.DataPropertyName = "BadFile";
            badFileColumn.HeaderText = "Bad File (Optional)";
            badFileColumn.Name = "BadFile";
            badFileColumn.UseOpenFileDialogOnButtonClick = true;
            badFileColumn.ShowBrowseButton = true;
            badFileColumn.MinimumWidth = 200;

            var discardFileColumn = new SqlLoaderEditor.Extensions.DataGridViewFilePathColumn();
            discardFileColumn.DataPropertyName = "DiscardFile";
            discardFileColumn.HeaderText = "Discard File (Optional)";
            discardFileColumn.Name = "DiscardFile";
            discardFileColumn.UseOpenFileDialogOnButtonClick = true;
            discardFileColumn.ShowBrowseButton = true;
            discardFileColumn.MinimumWidth = 200;

            this.fileModelDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { inFileColumn, badFileColumn, discardFileColumn });
        }

        private IEnumerable<DataGridViewColumn> SetupBaseField()
        {
            var nameColumn = new DataGridViewTextBoxColumn();
            nameColumn.DataPropertyName = "Name";
            nameColumn.HeaderText = "Name";
            nameColumn.Name = "Name";
            nameColumn.MinimumWidth = 150;
            yield return nameColumn;

            var dataTypeColumn = new DataGridViewComboBoxColumn();
            dataTypeColumn.DataSource = Enum.GetValues(typeof(DataTypes));
            dataTypeColumn.ValueType = typeof(DataTypes);
            dataTypeColumn.DataPropertyName = "DataType";
            dataTypeColumn.HeaderText = "Data Type";
            dataTypeColumn.Name = "DataType";
            yield return dataTypeColumn;

            var isExternalColumn = new DataGridViewCheckBoxColumn();
            isExternalColumn.DataPropertyName = "DataTypeIsExternal";
            isExternalColumn.HeaderText = "Is Readable Character Number?";
            isExternalColumn.Name = "DataTypeIsExternal";
            yield return isExternalColumn;

            var isFiller = new DataGridViewCheckBoxColumn();
            isFiller.DataPropertyName = "IsFiller";
            isFiller.HeaderText = "Skip this field?";
            isFiller.Name = "IsFiller";
            yield return isFiller;

            var operatorsColumn = new DataGridViewTextBoxColumn();
            operatorsColumn.DataPropertyName = "Operators";
            operatorsColumn.HeaderText = "Operators";
            operatorsColumn.Name = "Operators";
            operatorsColumn.MinimumWidth = 150;
            yield return operatorsColumn;
        }

        private void SetupDelimitedGridView()
        {
            this.delimitedFieldDataGridView.AutoGenerateColumns = false;
            this.delimitedFieldDataGridView.DataSource = delimitedFieldSpecificationBindingSource;

            this.delimitedFieldDataGridView.AutoGenerateColumns = false;
            this.delimitedFieldDataGridView.DataSource = delimitedFieldSpecificationBindingSource;

            foreach (var cl in this.SetupBaseField())
            {
                this.delimitedFieldDataGridView.Columns.Add(cl);
            }
        }

        private void SetupFixedGridView()
        {
            this.fixedSizeFieldDataGridView.AutoGenerateColumns = false;
            this.fixedSizeFieldDataGridView.DataSource = fixedSizeFieldSpecificationBindingSource;

            var posistionStartDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            posistionStartDataGridViewTextBoxColumn.DataPropertyName = "PositionStart";
            posistionStartDataGridViewTextBoxColumn.HeaderText = "Position Start";
            posistionStartDataGridViewTextBoxColumn.Name = "positionStartDataGridViewTextBoxColumn";
            posistionStartDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            posistionStartDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.False;
            posistionStartDataGridViewTextBoxColumn.Width = 50;

            var posistionEndDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            posistionEndDataGridViewTextBoxColumn.DataPropertyName = "PositionEnd";
            posistionEndDataGridViewTextBoxColumn.HeaderText = "Position End";
            posistionEndDataGridViewTextBoxColumn.Name = "positionEndDataGridViewTextBoxColumn";
            posistionEndDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.False;
            posistionEndDataGridViewTextBoxColumn.Width = 50;

            var lenghtColumn = new DataGridViewTextBoxColumn();
            lenghtColumn.DataPropertyName = "Length";
            lenghtColumn.HeaderText = "Length";
            lenghtColumn.Name = "lenghtDataGridViewTextBoxColumn";
            lenghtColumn.Resizable = DataGridViewTriState.False;
            lenghtColumn.Width = 50;

            var columns = new List<DataGridViewColumn>(this.SetupBaseField());
            columns.Insert(1, posistionStartDataGridViewTextBoxColumn);
            columns.Insert(2, lenghtColumn);
            columns.Insert(3, posistionEndDataGridViewTextBoxColumn);

            foreach (var cl in columns)
            {
                this.fixedSizeFieldDataGridView.Columns.Add(cl);
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            var ctl = (ControlFileSpecification)this.controlFileSpecificationBindingSource.List.OfType<ControlFileSpecification>().FirstOrDefault();
            var term = (TerminationAndEnclosureSpecification)this.terminationAndEnclosureSpecificationBindingSource.List.OfType<TerminationAndEnclosureSpecification>().FirstOrDefault();

            // collect all data files and add them to the ControlFileSpecification.
            var dataFiles = this.fileModelBindingSource.List.OfType<DataFileSpecification>();
            foreach (var item in dataFiles)
            {
                ctl.DataFiles.Add(item);
            }

            var builder = new FileBuilder()
                              .SetControlFile(ctl)
                              .SetTerminationAndEnclosure(term);
            if (ctl.IsDelimited)
            {
                var items = this.delimitedFieldSpecificationBindingSource.List.OfType<FieldModel>();
                foreach (var item in items)
                {
                    if (string.IsNullOrWhiteSpace(item.Name))
                        continue;
                    builder.AddField(item);
                }
            }
            else
            {
                var fixeditems = this.fixedSizeFieldSpecificationBindingSource.List.OfType<FixedSizeFieldModel>();
                foreach (var item in fixeditems)
                {
                    if (string.IsNullOrWhiteSpace(item.Name))
                        continue;
                    builder.AddField(item);
                }
            }

            this.textBox1.Text = builder.Build();
        }

        private void dataGridView1_RowLeave(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (e.RowIndex > 1)
            {
                var lastItem = (FixedSizeFieldModel)this.fixedSizeFieldSpecificationBindingSource.List[e.RowIndex - 2];
                ((FixedSizeFieldModel)this.fixedSizeFieldSpecificationBindingSource.List[e.RowIndex - 1]).PositionStart = lastItem.PositionEnd + 1;
            }
        }

        private void isDelimitedCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            this.tabControl1.TabPages.Remove(this.tabPage2);
            this.tabControl1.TabPages.Remove(this.tabPage4);

            if (this.isDelimitedCheckBox.Checked)
            {
                this.tabControl1.TabPages.Insert(2, this.tabPage2);
            }
            else
            {
                this.tabControl1.TabPages.Insert(2, this.tabPage4);
            }
        }
    }
}
