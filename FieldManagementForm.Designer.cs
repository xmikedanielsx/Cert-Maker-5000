namespace CertMaker5000
{
    partial class FieldManagementForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FieldManagementForm));
            FieldsDataGrid = new DataGridView();
            PDFFieldTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            AddEditFieldButton = new Button();
            CSVFieldsCombo = new ComboBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)FieldsDataGrid).BeginInit();
            SuspendLayout();
            // 
            // FieldsDataGrid
            // 
            FieldsDataGrid.AllowUserToAddRows = false;
            FieldsDataGrid.AllowUserToDeleteRows = false;
            FieldsDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            FieldsDataGrid.Location = new Point(28, 159);
            FieldsDataGrid.MultiSelect = false;
            FieldsDataGrid.Name = "FieldsDataGrid";
            FieldsDataGrid.ReadOnly = true;
            FieldsDataGrid.RowTemplate.Height = 25;
            FieldsDataGrid.Size = new Size(903, 369);
            FieldsDataGrid.TabIndex = 0;
            FieldsDataGrid.DataSourceChanged += FieldsDataGrid_DataSourceChanged;
            FieldsDataGrid.DoubleClick += FieldsDataGrid_DoubleClick;
            // 
            // PDFFieldTextBox
            // 
            PDFFieldTextBox.Location = new Point(96, 42);
            PDFFieldTextBox.Name = "PDFFieldTextBox";
            PDFFieldTextBox.Size = new Size(248, 23);
            PDFFieldTextBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 50);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 2;
            label1.Text = "PDF Field";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(371, 50);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 4;
            label2.Text = "Field Value";
            // 
            // AddEditFieldButton
            // 
            AddEditFieldButton.Location = new Point(732, 41);
            AddEditFieldButton.Name = "AddEditFieldButton";
            AddEditFieldButton.Size = new Size(75, 23);
            AddEditFieldButton.TabIndex = 5;
            AddEditFieldButton.Text = "Add";
            AddEditFieldButton.UseVisualStyleBackColor = true;
            AddEditFieldButton.Click += AddEditFieldButton_Click;
            // 
            // CSVFieldsCombo
            // 
            CSVFieldsCombo.FormattingEnabled = true;
            CSVFieldsCombo.Location = new Point(440, 42);
            CSVFieldsCombo.Name = "CSVFieldsCombo";
            CSVFieldsCombo.Size = new Size(248, 23);
            CSVFieldsCombo.TabIndex = 6;
            // 
            // label3
            // 
            label3.BackColor = SystemColors.GradientActiveCaption;
            label3.Location = new Point(28, 87);
            label3.Name = "label3";
            label3.Size = new Size(903, 69);
            label3.TabIndex = 7;
            label3.Text = resources.GetString("label3.Text");
            label3.Click += label3_Click;
            // 
            // FieldManagementForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(956, 552);
            Controls.Add(label3);
            Controls.Add(CSVFieldsCombo);
            Controls.Add(AddEditFieldButton);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(PDFFieldTextBox);
            Controls.Add(FieldsDataGrid);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FieldManagementForm";
            Text = "Field Management Form";
            FormClosing += FieldManagementForm_FormClosing;
            ((System.ComponentModel.ISupportInitialize)FieldsDataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView FieldsDataGrid;
        private TextBox PDFFieldTextBox;
        private Label label1;
        private Label label2;
        private Button AddEditFieldButton;
        public ComboBox CSVFieldsCombo;
        private Label label3;
    }
}