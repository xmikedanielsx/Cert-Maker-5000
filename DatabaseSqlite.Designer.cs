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
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            BrowseDatabaseButton = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Location = new Point(34, 77);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(454, 23);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 48);
            label1.Name = "label1";
            label1.Size = new Size(104, 15);
            label1.TabIndex = 1;
            label1.Text = "Database Location";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.Location = new Point(34, 114);
            label2.Name = "label2";
            label2.Size = new Size(454, 61);
            label2.TabIndex = 2;
            label2.Text = resources.GetString("label2.Text");
            // 
            // BrowseDatabaseButton
            // 
            BrowseDatabaseButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BrowseDatabaseButton.BackColor = SystemColors.Control;
            BrowseDatabaseButton.ForeColor = SystemColors.ControlText;
            BrowseDatabaseButton.Location = new Point(494, 77);
            BrowseDatabaseButton.Name = "BrowseDatabaseButton";
            BrowseDatabaseButton.Size = new Size(27, 23);
            BrowseDatabaseButton.TabIndex = 15;
            BrowseDatabaseButton.Text = "...";
            BrowseDatabaseButton.UseVisualStyleBackColor = false;
            BrowseDatabaseButton.Click += BrowseDatabaseButton_Click;
            // 
            // DatabaseSqliteForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(601, 228);
            ControlBox = false;
            Controls.Add(BrowseDatabaseButton);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            ForeColor = Color.FromArgb(204, 204, 204);
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

        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private Button BrowseDatabaseButton;
    }
}