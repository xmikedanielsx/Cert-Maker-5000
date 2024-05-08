namespace CertMaker5000
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            CertTemplateTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            UserCSVFileTextBox = new TextBox();
            OpenPDFTemplateDialogButton = new Button();
            OpenCsvFileDialogButton = new Button();
            OpenCertDropDialogButton = new Button();
            label3 = new Label();
            CertDropTextBox = new TextBox();
            FieldManagerLabel = new Label();
            LoadPdfButton = new Button();
            UserListBox = new ListBox();
            PDFViewerPicture = new PictureBox();
            PreviewEmailButton = new Button();
            PreviewTabControl = new TabControl();
            PDFPreviewTab = new TabPage();
            EmailBodyTab = new TabPage();
            VariablesAllowedListBox = new ListBox();
            HTMLBodyPreviewTextBox = new TextBox();
            HTMLBodyEditTextBox = new TextBox();
            GenerateNowButton = new Button();
            GenerateAndEmailButton = new Button();
            label4 = new Label();
            ThemeCombo = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)PDFViewerPicture).BeginInit();
            PreviewTabControl.SuspendLayout();
            PDFPreviewTab.SuspendLayout();
            EmailBodyTab.SuspendLayout();
            SuspendLayout();
            // 
            // CertTemplateTextBox
            // 
            CertTemplateTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CertTemplateTextBox.Location = new Point(131, 57);
            CertTemplateTextBox.Name = "CertTemplateTextBox";
            CertTemplateTextBox.Size = new Size(818, 23);
            CertTemplateTextBox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 65);
            label1.Name = "label1";
            label1.Size = new Size(80, 15);
            label1.TabIndex = 1;
            label1.Text = "Cert Template";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 104);
            label2.Name = "label2";
            label2.Size = new Size(75, 15);
            label2.TabIndex = 3;
            label2.Text = "User CSV File";
            // 
            // UserCSVFileTextBox
            // 
            UserCSVFileTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            UserCSVFileTextBox.Location = new Point(131, 96);
            UserCSVFileTextBox.Name = "UserCSVFileTextBox";
            UserCSVFileTextBox.Size = new Size(818, 23);
            UserCSVFileTextBox.TabIndex = 2;
            // 
            // OpenPDFTemplateDialogButton
            // 
            OpenPDFTemplateDialogButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            OpenPDFTemplateDialogButton.Location = new Point(955, 53);
            OpenPDFTemplateDialogButton.Name = "OpenPDFTemplateDialogButton";
            OpenPDFTemplateDialogButton.Size = new Size(32, 23);
            OpenPDFTemplateDialogButton.TabIndex = 4;
            OpenPDFTemplateDialogButton.Text = "...";
            OpenPDFTemplateDialogButton.UseVisualStyleBackColor = true;
            OpenPDFTemplateDialogButton.Click += OpenPDFTemplateDialogButton_Click;
            // 
            // OpenCsvFileDialogButton
            // 
            OpenCsvFileDialogButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            OpenCsvFileDialogButton.Location = new Point(955, 91);
            OpenCsvFileDialogButton.Name = "OpenCsvFileDialogButton";
            OpenCsvFileDialogButton.Size = new Size(32, 23);
            OpenCsvFileDialogButton.TabIndex = 5;
            OpenCsvFileDialogButton.Text = "...";
            OpenCsvFileDialogButton.UseVisualStyleBackColor = true;
            OpenCsvFileDialogButton.Click += OpenCsvFileDialogButton_Click;
            // 
            // OpenCertDropDialogButton
            // 
            OpenCertDropDialogButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            OpenCertDropDialogButton.Location = new Point(955, 147);
            OpenCertDropDialogButton.Name = "OpenCertDropDialogButton";
            OpenCertDropDialogButton.Size = new Size(32, 23);
            OpenCertDropDialogButton.TabIndex = 8;
            OpenCertDropDialogButton.Text = "...";
            OpenCertDropDialogButton.UseVisualStyleBackColor = true;
            OpenCertDropDialogButton.Click += OpenCertDropDialogButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 155);
            label3.Name = "label3";
            label3.Size = new Size(107, 15);
            label3.TabIndex = 7;
            label3.Text = "Cert Drop Location";
            // 
            // CertDropTextBox
            // 
            CertDropTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CertDropTextBox.Location = new Point(131, 152);
            CertDropTextBox.Name = "CertDropTextBox";
            CertDropTextBox.Size = new Size(818, 23);
            CertDropTextBox.TabIndex = 6;
            // 
            // FieldManagerLabel
            // 
            FieldManagerLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            FieldManagerLabel.AutoSize = true;
            FieldManagerLabel.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point);
            FieldManagerLabel.ForeColor = Color.Blue;
            FieldManagerLabel.Location = new Point(867, 124);
            FieldManagerLabel.Name = "FieldManagerLabel";
            FieldManagerLabel.Size = new Size(82, 15);
            FieldManagerLabel.TabIndex = 9;
            FieldManagerLabel.Text = "Field Manager";
            FieldManagerLabel.Visible = false;
            FieldManagerLabel.Click += FieldManagerLabel_Click;
            // 
            // LoadPdfButton
            // 
            LoadPdfButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            LoadPdfButton.Location = new Point(892, 187);
            LoadPdfButton.Name = "LoadPdfButton";
            LoadPdfButton.Size = new Size(93, 23);
            LoadPdfButton.TabIndex = 10;
            LoadPdfButton.Text = "Preview PDF";
            LoadPdfButton.UseVisualStyleBackColor = true;
            LoadPdfButton.Visible = false;
            LoadPdfButton.Click += LoadPdfButton_Click;
            // 
            // UserListBox
            // 
            UserListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            UserListBox.FormattingEnabled = true;
            UserListBox.ItemHeight = 15;
            UserListBox.Location = new Point(993, 63);
            UserListBox.Name = "UserListBox";
            UserListBox.Size = new Size(334, 664);
            UserListBox.TabIndex = 12;
            UserListBox.DoubleClick += UserListBox_DoubleClick;
            // 
            // PDFViewerPicture
            // 
            PDFViewerPicture.Dock = DockStyle.Fill;
            PDFViewerPicture.Location = new Point(3, 3);
            PDFViewerPicture.Name = "PDFViewerPicture";
            PDFViewerPicture.Size = new Size(955, 505);
            PDFViewerPicture.SizeMode = PictureBoxSizeMode.Zoom;
            PDFViewerPicture.TabIndex = 13;
            PDFViewerPicture.TabStop = false;
            // 
            // PreviewEmailButton
            // 
            PreviewEmailButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            PreviewEmailButton.Location = new Point(765, 187);
            PreviewEmailButton.Name = "PreviewEmailButton";
            PreviewEmailButton.Size = new Size(93, 23);
            PreviewEmailButton.TabIndex = 14;
            PreviewEmailButton.Text = "Preview Email";
            PreviewEmailButton.UseVisualStyleBackColor = true;
            PreviewEmailButton.Visible = false;
            // 
            // PreviewTabControl
            // 
            PreviewTabControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PreviewTabControl.Controls.Add(PDFPreviewTab);
            PreviewTabControl.Controls.Add(EmailBodyTab);
            PreviewTabControl.Location = new Point(18, 188);
            PreviewTabControl.Name = "PreviewTabControl";
            PreviewTabControl.SelectedIndex = 0;
            PreviewTabControl.Size = new Size(969, 539);
            PreviewTabControl.TabIndex = 16;
            PreviewTabControl.DrawItem += ControlTabColor;
            // 
            // PDFPreviewTab
            // 
            PDFPreviewTab.Controls.Add(PDFViewerPicture);
            PDFPreviewTab.Location = new Point(4, 24);
            PDFPreviewTab.Name = "PDFPreviewTab";
            PDFPreviewTab.Padding = new Padding(3);
            PDFPreviewTab.Size = new Size(961, 511);
            PDFPreviewTab.TabIndex = 0;
            PDFPreviewTab.Text = "PDF Preview";
            PDFPreviewTab.UseVisualStyleBackColor = true;
            // 
            // EmailBodyTab
            // 
            EmailBodyTab.Controls.Add(VariablesAllowedListBox);
            EmailBodyTab.Controls.Add(HTMLBodyPreviewTextBox);
            EmailBodyTab.Controls.Add(HTMLBodyEditTextBox);
            EmailBodyTab.Location = new Point(4, 24);
            EmailBodyTab.Name = "EmailBodyTab";
            EmailBodyTab.Padding = new Padding(3);
            EmailBodyTab.Size = new Size(961, 511);
            EmailBodyTab.TabIndex = 1;
            EmailBodyTab.Text = "E-Mail Body";
            EmailBodyTab.UseVisualStyleBackColor = true;
            // 
            // VariablesAllowedListBox
            // 
            VariablesAllowedListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            VariablesAllowedListBox.FormattingEnabled = true;
            VariablesAllowedListBox.ItemHeight = 15;
            VariablesAllowedListBox.Location = new Point(3, 6);
            VariablesAllowedListBox.Name = "VariablesAllowedListBox";
            VariablesAllowedListBox.Size = new Size(214, 499);
            VariablesAllowedListBox.TabIndex = 17;
            VariablesAllowedListBox.DoubleClick += VariablesAllowedListBox_DoubleClick;
            // 
            // HTMLBodyPreviewTextBox
            // 
            HTMLBodyPreviewTextBox.Location = new Point(226, 261);
            HTMLBodyPreviewTextBox.Multiline = true;
            HTMLBodyPreviewTextBox.Name = "HTMLBodyPreviewTextBox";
            HTMLBodyPreviewTextBox.ReadOnly = true;
            HTMLBodyPreviewTextBox.Size = new Size(729, 244);
            HTMLBodyPreviewTextBox.TabIndex = 1;
            // 
            // HTMLBodyEditTextBox
            // 
            HTMLBodyEditTextBox.Location = new Point(226, 6);
            HTMLBodyEditTextBox.Multiline = true;
            HTMLBodyEditTextBox.Name = "HTMLBodyEditTextBox";
            HTMLBodyEditTextBox.Size = new Size(729, 249);
            HTMLBodyEditTextBox.TabIndex = 0;
            HTMLBodyEditTextBox.TextChanged += HTMLBodyEditTextBox_TextChanged;
            // 
            // GenerateNowButton
            // 
            GenerateNowButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            GenerateNowButton.Location = new Point(993, 34);
            GenerateNowButton.Name = "GenerateNowButton";
            GenerateNowButton.Size = new Size(121, 23);
            GenerateNowButton.TabIndex = 17;
            GenerateNowButton.Text = "Generate Now";
            GenerateNowButton.UseVisualStyleBackColor = true;
            GenerateNowButton.Visible = false;
            GenerateNowButton.Click += GenerateNowButton_Click;
            // 
            // GenerateAndEmailButton
            // 
            GenerateAndEmailButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            GenerateAndEmailButton.Location = new Point(1166, 38);
            GenerateAndEmailButton.Name = "GenerateAndEmailButton";
            GenerateAndEmailButton.Size = new Size(161, 23);
            GenerateAndEmailButton.TabIndex = 18;
            GenerateAndEmailButton.Text = "Generate and Email";
            GenerateAndEmailButton.UseVisualStyleBackColor = true;
            GenerateAndEmailButton.Visible = false;
            GenerateAndEmailButton.Click += GenerateAndEmailButton_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(818, 15);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 19;
            label4.Text = "Theme";
            // 
            // ThemeCombo
            // 
            ThemeCombo.FormattingEnabled = true;
            ThemeCombo.Location = new Point(867, 12);
            ThemeCombo.Name = "ThemeCombo";
            ThemeCombo.Size = new Size(120, 23);
            ThemeCombo.TabIndex = 20;
            ThemeCombo.SelectedIndexChanged += ThemeCombo_SelectedIndexChanged;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1339, 739);
            Controls.Add(ThemeCombo);
            Controls.Add(label4);
            Controls.Add(GenerateAndEmailButton);
            Controls.Add(GenerateNowButton);
            Controls.Add(PreviewEmailButton);
            Controls.Add(LoadPdfButton);
            Controls.Add(PreviewTabControl);
            Controls.Add(UserListBox);
            Controls.Add(FieldManagerLabel);
            Controls.Add(OpenCertDropDialogButton);
            Controls.Add(label3);
            Controls.Add(CertDropTextBox);
            Controls.Add(OpenCsvFileDialogButton);
            Controls.Add(OpenPDFTemplateDialogButton);
            Controls.Add(label2);
            Controls.Add(UserCSVFileTextBox);
            Controls.Add(label1);
            Controls.Add(CertTemplateTextBox);
            Name = "MainForm";
            Text = "Cert Maker 5000";
            ((System.ComponentModel.ISupportInitialize)PDFViewerPicture).EndInit();
            PreviewTabControl.ResumeLayout(false);
            PDFPreviewTab.ResumeLayout(false);
            EmailBodyTab.ResumeLayout(false);
            EmailBodyTab.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox CertTemplateTextBox;
        private Label label1;
        private Label label2;
        private TextBox UserCSVFileTextBox;
        private Button OpenPDFTemplateDialogButton;
        private Button OpenCsvFileDialogButton;
        private Button OpenCertDropDialogButton;
        private Label label3;
        private TextBox CertDropTextBox;
        private Label FieldManagerLabel;
        private Button LoadPdfButton;
        private ListBox UserListBox;
        private PictureBox PDFViewerPicture;
        private Button PreviewEmailButton;
        private TabControl PreviewTabControl;
        private TabPage PDFPreviewTab;
        private TabPage EmailBodyTab;
        private TextBox HTMLBodyPreviewTextBox;
        private TextBox HTMLBodyEditTextBox;
        private ListBox VariablesAllowedListBox;
        private Button GenerateNowButton;
        private Button GenerateAndEmailButton;
        private Label label4;
        private ComboBox ThemeCombo;
    }
}