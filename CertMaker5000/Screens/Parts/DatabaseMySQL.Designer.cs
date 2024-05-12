namespace CertMaker5000
{
    partial class DatabaseMySQLForm
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
            OutsideSplitContainer = new SplitContainer();
            SqlServerPortText = new TextBox();
            label5 = new Label();
            SqlServerText = new TextBox();
            label1 = new Label();
            InsideSplitContainer = new SplitContainer();
            SqlServerUser = new TextBox();
            label4 = new Label();
            SqlServerPass = new TextBox();
            label3 = new Label();
            SqlServerDatabaseText = new TextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)OutsideSplitContainer).BeginInit();
            OutsideSplitContainer.Panel1.SuspendLayout();
            OutsideSplitContainer.Panel2.SuspendLayout();
            OutsideSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)InsideSplitContainer).BeginInit();
            InsideSplitContainer.Panel1.SuspendLayout();
            InsideSplitContainer.Panel2.SuspendLayout();
            InsideSplitContainer.SuspendLayout();
            SuspendLayout();
            // 
            // OutsideSplitContainer
            // 
            OutsideSplitContainer.Location = new Point(10, 10);
            OutsideSplitContainer.Name = "OutsideSplitContainer";
            OutsideSplitContainer.Orientation = Orientation.Horizontal;
            // 
            // OutsideSplitContainer.Panel1
            // 
            OutsideSplitContainer.Panel1.Controls.Add(SqlServerPortText);
            OutsideSplitContainer.Panel1.Controls.Add(label5);
            OutsideSplitContainer.Panel1.Controls.Add(SqlServerText);
            OutsideSplitContainer.Panel1.Controls.Add(label1);
            // 
            // OutsideSplitContainer.Panel2
            // 
            OutsideSplitContainer.Panel2.Controls.Add(InsideSplitContainer);
            OutsideSplitContainer.Size = new Size(808, 150);
            OutsideSplitContainer.SplitterDistance = 37;
            OutsideSplitContainer.TabIndex = 5;
            // 
            // SqlServerPortText
            // 
            SqlServerPortText.Location = new Point(606, 8);
            SqlServerPortText.Name = "SqlServerPortText";
            SqlServerPortText.Size = new Size(182, 23);
            SqlServerPortText.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(561, 10);
            label5.Name = "label5";
            label5.Size = new Size(29, 15);
            label5.TabIndex = 3;
            label5.Text = "Port";
            // 
            // SqlServerText
            // 
            SqlServerText.Location = new Point(84, 8);
            SqlServerText.Name = "SqlServerText";
            SqlServerText.Size = new Size(442, 23);
            SqlServerText.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 8);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 1;
            label1.Text = "Server";
            // 
            // InsideSplitContainer
            // 
            InsideSplitContainer.Dock = DockStyle.Fill;
            InsideSplitContainer.Location = new Point(0, 0);
            InsideSplitContainer.Name = "InsideSplitContainer";
            InsideSplitContainer.Orientation = Orientation.Horizontal;
            // 
            // InsideSplitContainer.Panel1
            // 
            InsideSplitContainer.Panel1.Controls.Add(SqlServerUser);
            InsideSplitContainer.Panel1.Controls.Add(label4);
            InsideSplitContainer.Panel1.Controls.Add(SqlServerPass);
            InsideSplitContainer.Panel1.Controls.Add(label3);
            // 
            // InsideSplitContainer.Panel2
            // 
            InsideSplitContainer.Panel2.Controls.Add(SqlServerDatabaseText);
            InsideSplitContainer.Panel2.Controls.Add(label2);
            InsideSplitContainer.Size = new Size(808, 109);
            InsideSplitContainer.SplitterDistance = 43;
            InsideSplitContainer.TabIndex = 5;
            // 
            // SqlServerUser
            // 
            SqlServerUser.Location = new Point(92, 9);
            SqlServerUser.Name = "SqlServerUser";
            SqlServerUser.Size = new Size(311, 23);
            SqlServerUser.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 14);
            label4.Name = "label4";
            label4.Size = new Size(30, 15);
            label4.TabIndex = 6;
            label4.Text = "User";
            // 
            // SqlServerPass
            // 
            SqlServerPass.Location = new Point(479, 9);
            SqlServerPass.Name = "SqlServerPass";
            SqlServerPass.PasswordChar = '*';
            SqlServerPass.Size = new Size(310, 23);
            SqlServerPass.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(434, 11);
            label3.Name = "label3";
            label3.Size = new Size(30, 15);
            label3.TabIndex = 4;
            label3.Text = "Pass";
            // 
            // SqlServerDatabaseText
            // 
            SqlServerDatabaseText.Location = new Point(96, 8);
            SqlServerDatabaseText.Name = "SqlServerDatabaseText";
            SqlServerDatabaseText.Size = new Size(693, 23);
            SqlServerDatabaseText.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 11);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 3;
            label2.Text = "Database";
            // 
            // DatabaseMySQLForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(853, 187);
            ControlBox = false;
            Controls.Add(OutsideSplitContainer);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "DatabaseMySQLForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainStartForm";
            TopMost = true;
            OutsideSplitContainer.Panel1.ResumeLayout(false);
            OutsideSplitContainer.Panel1.PerformLayout();
            OutsideSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)OutsideSplitContainer).EndInit();
            OutsideSplitContainer.ResumeLayout(false);
            InsideSplitContainer.Panel1.ResumeLayout(false);
            InsideSplitContainer.Panel1.PerformLayout();
            InsideSplitContainer.Panel2.ResumeLayout(false);
            InsideSplitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)InsideSplitContainer).EndInit();
            InsideSplitContainer.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer OutsideSplitContainer;
        private TextBox SqlServerText;
        private Label label1;
        private SplitContainer InsideSplitContainer;
        private TextBox SqlServerUser;
        private Label label4;
        private TextBox SqlServerPass;
        private Label label3;
        private TextBox SqlServerDatabaseText;
        private Label label2;
        private TextBox SqlServerPortText;
        private Label label5;
    }
}