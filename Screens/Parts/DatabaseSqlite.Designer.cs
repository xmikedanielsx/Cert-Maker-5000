namespace CertMaker5000
{
    partial class DatabaseSqliteForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DatabaseSqliteForm));
            DatabaseLocationText = new TextBox();
            label1 = new Label();
            label2 = new Label();
            BrowseDatabaseButton = new Button();
            SuspendLayout();
            // 
            // DatabaseLocationText
            // 
            DatabaseLocationText.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            DatabaseLocationText.Location = new Point(178, 56);
            DatabaseLocationText.Margin = new Padding(3, 4, 3, 4);
            DatabaseLocationText.Name = "DatabaseLocationText";
            DatabaseLocationText.Size = new Size(891, 27);
            DatabaseLocationText.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 61);
            label1.Name = "label1";
            label1.Size = new Size(133, 20);
            label1.TabIndex = 1;
            label1.Text = "Database Location";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.Location = new Point(31, 105);
            label2.Name = "label2";
            label2.Size = new Size(1075, 72);
            label2.TabIndex = 2;
            label2.Text = resources.GetString("label2.Text");
            // 
            // BrowseDatabaseButton
            // 
            BrowseDatabaseButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BrowseDatabaseButton.BackColor = SystemColors.Control;
            BrowseDatabaseButton.ForeColor = SystemColors.ControlText;
            BrowseDatabaseButton.Location = new Point(1075, 56);
            BrowseDatabaseButton.Margin = new Padding(3, 4, 3, 4);
            BrowseDatabaseButton.Name = "BrowseDatabaseButton";
            BrowseDatabaseButton.Size = new Size(31, 31);
            BrowseDatabaseButton.TabIndex = 15;
            BrowseDatabaseButton.Text = "...";
            BrowseDatabaseButton.UseVisualStyleBackColor = false;
            BrowseDatabaseButton.Click += BrowseDatabaseButton_Click;
            // 
            // DatabaseSqliteForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1126, 186);
            ControlBox = false;
            Controls.Add(BrowseDatabaseButton);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(DatabaseLocationText);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "DatabaseSqliteForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainStartForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public TextBox DatabaseLocationText;
        private Label label1;
        private Label label2;
        private Button BrowseDatabaseButton;
    }
}