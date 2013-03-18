namespace SqlLoaderEditor
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label continueLoadLabel;
            System.Windows.Forms.Label loadMethodLabel;
            System.Windows.Forms.Label partitionNameLabel;
            System.Windows.Forms.Label skipLabel;
            System.Windows.Forms.Label tableNameLabel;
            System.Windows.Forms.Label whenClauseLabel;
            System.Windows.Forms.Label enclosedByLabel;
            System.Windows.Forms.Label terminatedByLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.isDelimitedCheckBox = new System.Windows.Forms.CheckBox();
            this.controlFileSpecificationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.whenClauseTextBox = new System.Windows.Forms.TextBox();
            this.continueLoadCheckBox = new System.Windows.Forms.CheckBox();
            this.loadMethodComboBox = new System.Windows.Forms.ComboBox();
            this.partitionNameTextBox = new System.Windows.Forms.TextBox();
            this.skipNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.tableNameTextBox = new System.Windows.Forms.TextBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.fileModelDataGridView = new System.Windows.Forms.DataGridView();
            this.fileModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.terminatedByTextBox = new System.Windows.Forms.TextBox();
            this.terminationAndEnclosureSpecificationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.enclosedByTextBox = new System.Windows.Forms.TextBox();
            this.delimitedFieldDataGridView = new System.Windows.Forms.DataGridView();
            this.delimitedFieldSpecificationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.fixedSizeFieldDataGridView = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.fixedSizeFieldSpecificationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            continueLoadLabel = new System.Windows.Forms.Label();
            loadMethodLabel = new System.Windows.Forms.Label();
            partitionNameLabel = new System.Windows.Forms.Label();
            skipLabel = new System.Windows.Forms.Label();
            tableNameLabel = new System.Windows.Forms.Label();
            whenClauseLabel = new System.Windows.Forms.Label();
            enclosedByLabel = new System.Windows.Forms.Label();
            terminatedByLabel = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.controlFileSpecificationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skipNumericUpDown)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileModelDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileModelBindingSource)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.terminationAndEnclosureSpecificationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.delimitedFieldDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.delimitedFieldSpecificationBindingSource)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fixedSizeFieldDataGridView)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fixedSizeFieldSpecificationBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // continueLoadLabel
            // 
            continueLoadLabel.AutoSize = true;
            continueLoadLabel.Location = new System.Drawing.Point(10, 11);
            continueLoadLabel.Name = "continueLoadLabel";
            continueLoadLabel.Size = new System.Drawing.Size(0, 13);
            continueLoadLabel.TabIndex = 0;
            // 
            // loadMethodLabel
            // 
            loadMethodLabel.AutoSize = true;
            loadMethodLabel.Location = new System.Drawing.Point(13, 69);
            loadMethodLabel.Name = "loadMethodLabel";
            loadMethodLabel.Size = new System.Drawing.Size(73, 13);
            loadMethodLabel.TabIndex = 2;
            loadMethodLabel.Text = "Load Method:";
            // 
            // partitionNameLabel
            // 
            partitionNameLabel.AutoSize = true;
            partitionNameLabel.Location = new System.Drawing.Point(7, 148);
            partitionNameLabel.Name = "partitionNameLabel";
            partitionNameLabel.Size = new System.Drawing.Size(79, 13);
            partitionNameLabel.TabIndex = 4;
            partitionNameLabel.Text = "Partition Name:";
            // 
            // skipLabel
            // 
            skipLabel.AutoSize = true;
            skipLabel.Location = new System.Drawing.Point(55, 93);
            skipLabel.Name = "skipLabel";
            skipLabel.Size = new System.Drawing.Size(31, 13);
            skipLabel.TabIndex = 6;
            skipLabel.Text = "Skip:";
            // 
            // tableNameLabel
            // 
            tableNameLabel.AutoSize = true;
            tableNameLabel.Location = new System.Drawing.Point(18, 122);
            tableNameLabel.Name = "tableNameLabel";
            tableNameLabel.Size = new System.Drawing.Size(68, 13);
            tableNameLabel.TabIndex = 8;
            tableNameLabel.Text = "Table Name:";
            // 
            // whenClauseLabel
            // 
            whenClauseLabel.AutoSize = true;
            whenClauseLabel.Location = new System.Drawing.Point(12, 174);
            whenClauseLabel.Name = "whenClauseLabel";
            whenClauseLabel.Size = new System.Drawing.Size(74, 13);
            whenClauseLabel.TabIndex = 10;
            whenClauseLabel.Text = "When Clause:";
            // 
            // enclosedByLabel
            // 
            enclosedByLabel.AutoSize = true;
            enclosedByLabel.Location = new System.Drawing.Point(14, 32);
            enclosedByLabel.Name = "enclosedByLabel";
            enclosedByLabel.Size = new System.Drawing.Size(69, 13);
            enclosedByLabel.TabIndex = 4;
            enclosedByLabel.Text = "Enclosed By:";
            // 
            // terminatedByLabel
            // 
            terminatedByLabel.AutoSize = true;
            terminatedByLabel.Location = new System.Drawing.Point(5, 6);
            terminatedByLabel.Name = "terminatedByLabel";
            terminatedByLabel.Size = new System.Drawing.Size(78, 13);
            terminatedByLabel.TabIndex = 6;
            terminatedByLabel.Text = "Terminated By:";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(815, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(59, 22);
            this.toolStripButton1.Text = "Build File";
            this.toolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.toolStripButton1.ToolTipText = "Build File";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 25);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(815, 308);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Controls.Add(this.isDelimitedCheckBox);
            this.tabPage1.Controls.Add(whenClauseLabel);
            this.tabPage1.Controls.Add(this.whenClauseTextBox);
            this.tabPage1.Controls.Add(continueLoadLabel);
            this.tabPage1.Controls.Add(this.continueLoadCheckBox);
            this.tabPage1.Controls.Add(loadMethodLabel);
            this.tabPage1.Controls.Add(this.loadMethodComboBox);
            this.tabPage1.Controls.Add(partitionNameLabel);
            this.tabPage1.Controls.Add(this.partitionNameTextBox);
            this.tabPage1.Controls.Add(skipLabel);
            this.tabPage1.Controls.Add(this.skipNumericUpDown);
            this.tabPage1.Controls.Add(tableNameLabel);
            this.tabPage1.Controls.Add(this.tableNameTextBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(807, 282);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Main";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // isDelimitedCheckBox
            // 
            this.isDelimitedCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.controlFileSpecificationBindingSource, "IsDelimited", true));
            this.isDelimitedCheckBox.Location = new System.Drawing.Point(92, 6);
            this.isDelimitedCheckBox.Name = "isDelimitedCheckBox";
            this.isDelimitedCheckBox.Size = new System.Drawing.Size(104, 24);
            this.isDelimitedCheckBox.TabIndex = 0;
            this.isDelimitedCheckBox.Text = "Is Delimited?";
            this.isDelimitedCheckBox.UseVisualStyleBackColor = true;
            this.isDelimitedCheckBox.CheckedChanged += new System.EventHandler(this.isDelimitedCheckBox_CheckedChanged);
            // 
            // controlFileSpecificationBindingSource
            // 
            this.controlFileSpecificationBindingSource.DataSource = typeof(SqlLoaderEditor.Core.ControlFileSpecification);
            // 
            // whenClauseTextBox
            // 
            this.whenClauseTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.controlFileSpecificationBindingSource, "WhenClause", true));
            this.whenClauseTextBox.Location = new System.Drawing.Point(92, 171);
            this.whenClauseTextBox.Multiline = true;
            this.whenClauseTextBox.Name = "whenClauseTextBox";
            this.whenClauseTextBox.Size = new System.Drawing.Size(461, 99);
            this.whenClauseTextBox.TabIndex = 6;
            // 
            // continueLoadCheckBox
            // 
            this.continueLoadCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.controlFileSpecificationBindingSource, "ContinueLoad", true));
            this.continueLoadCheckBox.Location = new System.Drawing.Point(92, 36);
            this.continueLoadCheckBox.Name = "continueLoadCheckBox";
            this.continueLoadCheckBox.Size = new System.Drawing.Size(121, 24);
            this.continueLoadCheckBox.TabIndex = 1;
            this.continueLoadCheckBox.Text = "Continue load?";
            this.continueLoadCheckBox.UseVisualStyleBackColor = true;
            // 
            // loadMethodComboBox
            // 
            this.loadMethodComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.controlFileSpecificationBindingSource, "LoadMethod", true));
            this.loadMethodComboBox.FormattingEnabled = true;
            this.loadMethodComboBox.Location = new System.Drawing.Point(92, 66);
            this.loadMethodComboBox.Name = "loadMethodComboBox";
            this.loadMethodComboBox.Size = new System.Drawing.Size(226, 21);
            this.loadMethodComboBox.TabIndex = 2;
            // 
            // partitionNameTextBox
            // 
            this.partitionNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.controlFileSpecificationBindingSource, "PartitionName", true));
            this.partitionNameTextBox.Location = new System.Drawing.Point(92, 145);
            this.partitionNameTextBox.Name = "partitionNameTextBox";
            this.partitionNameTextBox.Size = new System.Drawing.Size(226, 20);
            this.partitionNameTextBox.TabIndex = 5;
            // 
            // skipNumericUpDown
            // 
            this.skipNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.controlFileSpecificationBindingSource, "Skip", true));
            this.skipNumericUpDown.Location = new System.Drawing.Point(92, 93);
            this.skipNumericUpDown.Name = "skipNumericUpDown";
            this.skipNumericUpDown.Size = new System.Drawing.Size(226, 20);
            this.skipNumericUpDown.TabIndex = 3;
            // 
            // tableNameTextBox
            // 
            this.tableNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.controlFileSpecificationBindingSource, "TableName", true));
            this.tableNameTextBox.Location = new System.Drawing.Point(92, 119);
            this.tableNameTextBox.Name = "tableNameTextBox";
            this.tableNameTextBox.Size = new System.Drawing.Size(226, 20);
            this.tableNameTextBox.TabIndex = 4;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.fileModelDataGridView);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(807, 282);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Data Files";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // fileModelDataGridView
            // 
            this.fileModelDataGridView.AutoGenerateColumns = false;
            this.fileModelDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.fileModelDataGridView.DataSource = this.fileModelBindingSource;
            this.fileModelDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fileModelDataGridView.Location = new System.Drawing.Point(3, 3);
            this.fileModelDataGridView.Name = "fileModelDataGridView";
            this.fileModelDataGridView.Size = new System.Drawing.Size(801, 276);
            this.fileModelDataGridView.TabIndex = 0;
            // 
            // fileModelBindingSource
            // 
            this.fileModelBindingSource.DataSource = typeof(SqlLoaderEditor.Core.DataFileSpecification);
            // 
            // tabPage2
            // 
            this.tabPage2.AutoScroll = true;
            this.tabPage2.Controls.Add(this.splitContainer1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(807, 282);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Delimited";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(enclosedByLabel);
            this.splitContainer1.Panel1.Controls.Add(terminatedByLabel);
            this.splitContainer1.Panel1.Controls.Add(this.terminatedByTextBox);
            this.splitContainer1.Panel1.Controls.Add(this.enclosedByTextBox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.delimitedFieldDataGridView);
            this.splitContainer1.Size = new System.Drawing.Size(801, 276);
            this.splitContainer1.SplitterDistance = 57;
            this.splitContainer1.TabIndex = 5;
            // 
            // terminatedByTextBox
            // 
            this.terminatedByTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.terminationAndEnclosureSpecificationBindingSource, "TerminatedBy", true));
            this.terminatedByTextBox.Location = new System.Drawing.Point(89, 3);
            this.terminatedByTextBox.MaxLength = 1;
            this.terminatedByTextBox.Name = "terminatedByTextBox";
            this.terminatedByTextBox.Size = new System.Drawing.Size(32, 20);
            this.terminatedByTextBox.TabIndex = 7;
            // 
            // terminationAndEnclosureSpecificationBindingSource
            // 
            this.terminationAndEnclosureSpecificationBindingSource.DataSource = typeof(SqlLoaderEditor.Core.TerminationAndEnclosureSpecification);
            // 
            // enclosedByTextBox
            // 
            this.enclosedByTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.terminationAndEnclosureSpecificationBindingSource, "EnclosedBy", true));
            this.enclosedByTextBox.Location = new System.Drawing.Point(89, 29);
            this.enclosedByTextBox.MaxLength = 1;
            this.enclosedByTextBox.Name = "enclosedByTextBox";
            this.enclosedByTextBox.Size = new System.Drawing.Size(32, 20);
            this.enclosedByTextBox.TabIndex = 5;
            // 
            // delimitedFieldDataGridView
            // 
            this.delimitedFieldDataGridView.AutoGenerateColumns = false;
            this.delimitedFieldDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.delimitedFieldDataGridView.DataSource = this.delimitedFieldSpecificationBindingSource;
            this.delimitedFieldDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.delimitedFieldDataGridView.Location = new System.Drawing.Point(0, 0);
            this.delimitedFieldDataGridView.Name = "delimitedFieldDataGridView";
            this.delimitedFieldDataGridView.Size = new System.Drawing.Size(801, 215);
            this.delimitedFieldDataGridView.TabIndex = 1;
            // 
            // delimitedFieldSpecificationBindingSource
            // 
            this.delimitedFieldSpecificationBindingSource.DataSource = typeof(SqlLoaderEditor.Models.FieldModel);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.fixedSizeFieldDataGridView);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(761, 282);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Fixed Size";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // fixedSizeFieldDataGridView
            // 
            this.fixedSizeFieldDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.fixedSizeFieldDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fixedSizeFieldDataGridView.Location = new System.Drawing.Point(3, 3);
            this.fixedSizeFieldDataGridView.Name = "fixedSizeFieldDataGridView";
            this.fixedSizeFieldDataGridView.Size = new System.Drawing.Size(755, 276);
            this.fixedSizeFieldDataGridView.TabIndex = 1;
            this.fixedSizeFieldDataGridView.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridView1_RowsAdded);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.textBox1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(761, 282);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Result";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(3, 3);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(755, 276);
            this.textBox1.TabIndex = 3;
            // 
            // fixedSizeFieldSpecificationBindingSource
            // 
            this.fixedSizeFieldSpecificationBindingSource.DataSource = typeof(SqlLoaderEditor.Models.FixedSizeFieldModel);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 333);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "MainForm";
            this.Text = "SQL*Loader File Builder";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.controlFileSpecificationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skipNumericUpDown)).EndInit();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fileModelDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileModelBindingSource)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.terminationAndEnclosureSpecificationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.delimitedFieldDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.delimitedFieldSpecificationBindingSource)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fixedSizeFieldDataGridView)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fixedSizeFieldSpecificationBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.BindingSource fixedSizeFieldSpecificationBindingSource;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.BindingSource controlFileSpecificationBindingSource;
        private System.Windows.Forms.CheckBox continueLoadCheckBox;
        private System.Windows.Forms.ComboBox loadMethodComboBox;
        private System.Windows.Forms.TextBox partitionNameTextBox;
        private System.Windows.Forms.NumericUpDown skipNumericUpDown;
        private System.Windows.Forms.TextBox tableNameTextBox;
        private System.Windows.Forms.TextBox whenClauseTextBox;
        private System.Windows.Forms.BindingSource terminationAndEnclosureSpecificationBindingSource;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView fixedSizeFieldDataGridView;
        private System.Windows.Forms.BindingSource delimitedFieldSpecificationBindingSource;
        private System.Windows.Forms.CheckBox isDelimitedCheckBox;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox terminatedByTextBox;
        private System.Windows.Forms.TextBox enclosedByTextBox;
        private System.Windows.Forms.DataGridView delimitedFieldDataGridView;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.DataGridView fileModelDataGridView;
        private System.Windows.Forms.BindingSource fileModelBindingSource;
    }
}

