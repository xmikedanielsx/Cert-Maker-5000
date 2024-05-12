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
            label3 = new Label();
            DatabasePasswordText = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // DatabaseLocationText
            // 
            DatabaseLocationText.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            DatabaseLocationText.Location = new Point(156, 42);
            DatabaseLocationText.Name = "DatabaseLocationText";
            DatabaseLocationText.Size = new Size(780, 23);
            DatabaseLocationText.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 46);
            label1.Name = "label1";
            label1.Size = new Size(104, 15);
            label1.TabIndex = 1;
            label1.Text = "Database Location";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.Location = new Point(27, 98);
            label2.Name = "label2";
            label2.Size = new Size(941, 105);
            label2.TabIndex = 2;
            label2.Text = resources.GetString("label2.Text");
            // 
            // BrowseDatabaseButton
            // 
            BrowseDatabaseButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BrowseDatabaseButton.BackColor = SystemColors.Control;
            BrowseDatabaseButton.ForeColor = SystemColors.ControlText;
            BrowseDatabaseButton.Location = new Point(941, 42);
            BrowseDatabaseButton.Name = "BrowseDatabaseButton";
            BrowseDatabaseButton.Size = new Size(27, 23);
            BrowseDatabaseButton.TabIndex = 15;
            BrowseDatabaseButton.Text = "...";
            BrowseDatabaseButton.UseVisualStyleBackColor = false;
            BrowseDatabaseButton.Click += BrowseDatabaseButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(82, 70);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 17;
            label3.Text = "Password";
            // 
            // DatabasePasswordText
            // 
            DatabasePasswordText.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            DatabasePasswordText.Enabled = false;
            DatabasePasswordText.Location = new Point(156, 68);
            DatabasePasswordText.Name = "DatabasePasswordText";
            DatabasePasswordText.PasswordChar = '*';
            DatabasePasswordText.Size = new Size(294, 23);
            DatabasePasswordText.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(466, 74);
            label4.Name = "label4";
            label4.Size = new Size(330, 15);
            label4.TabIndex = 18;
            label4.Text = "Note: Password Not Required.  * still working on this feature *";
            // 
            // DatabaseSqliteForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(985, 210);
            ControlBox = false;
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(DatabasePasswordText);
            Controls.Add(BrowseDatabaseButton);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(DatabaseLocationText);
            FormBorderStyle = FormBorderStyle.None;
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
        private Label label3;
        public TextBox DatabasePasswordText;
        private Label label4;
    }
}