namespace CertMaker5000
{
    partial class DatabaseMSSQLForm
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
            SqlServerText = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SqlServerDatabaseText = new TextBox();
            OutsideSplitContainer = new SplitContainer();
            WindowsAuthCheck = new CheckBox();
            InsideSplitContainer = new SplitContainer();
            SqlServerUser = new TextBox();
            label4 = new Label();
            SqlServerPass = new TextBox();
            label3 = new Label();
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
            // SqlServerText
            // 
            SqlServerText.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            SqlServerText.Location = new Point(110, 4);
            SqlServerText.Margin = new Padding(3, 4, 3, 4);
            SqlServerText.Name = "SqlServerText";
            SqlServerText.Size = new Size(783, 27);
            SqlServerText.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 8);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 1;
            label1.Text = "SQL Server";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 15);
            label2.Name = "label2";
            label2.Size = new Size(102, 20);
            label2.TabIndex = 3;
            label2.Text = "SQL Database";
            // 
            // SqlServerDatabase
            // 
            SqlServerDatabaseText.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            SqlServerDatabaseText.Location = new Point(110, 11);
            SqlServerDatabaseText.Margin = new Padding(3, 4, 3, 4);
            SqlServerDatabaseText.Name = "SqlServerDatabase";
            SqlServerDatabaseText.Size = new Size(783, 27);
            SqlServerDatabaseText.TabIndex = 2;
            // 
            // OutsideSplitContainer
            // 
            OutsideSplitContainer.Location = new Point(14, 48);
            OutsideSplitContainer.Margin = new Padding(3, 4, 3, 4);
            OutsideSplitContainer.Name = "OutsideSplitContainer";
            OutsideSplitContainer.Orientation = Orientation.Horizontal;
            // 
            // OutsideSplitContainer.Panel1
            // 
            OutsideSplitContainer.Panel1.Controls.Add(WindowsAuthCheck);
            OutsideSplitContainer.Panel1.Controls.Add(SqlServerText);
            OutsideSplitContainer.Panel1.Controls.Add(label1);
            // 
            // OutsideSplitContainer.Panel2
            // 
            OutsideSplitContainer.Panel2.Controls.Add(InsideSplitContainer);
            OutsideSplitContainer.Size = new Size(923, 200);
            OutsideSplitContainer.SplitterDistance = 73;
            OutsideSplitContainer.SplitterWidth = 5;
            OutsideSplitContainer.TabIndex = 4;
            // 
            // WindowsAuthCheck
            // 
            WindowsAuthCheck.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            WindowsAuthCheck.AutoSize = true;
            WindowsAuthCheck.Checked = true;
            WindowsAuthCheck.CheckState = CheckState.Checked;
            WindowsAuthCheck.Location = new Point(110, 39);
            WindowsAuthCheck.Margin = new Padding(3, 4, 3, 4);
            WindowsAuthCheck.Name = "WindowsAuthCheck";
            WindowsAuthCheck.Size = new Size(127, 24);
            WindowsAuthCheck.TabIndex = 2;
            WindowsAuthCheck.Text = "Windows Auth";
            WindowsAuthCheck.UseVisualStyleBackColor = true;
            WindowsAuthCheck.CheckedChanged += WindowsAuthCheck_CheckedChanged;
            // 
            // InsideSplitContainer
            // 
            InsideSplitContainer.Dock = DockStyle.Fill;
            InsideSplitContainer.Location = new Point(0, 0);
            InsideSplitContainer.Margin = new Padding(3, 4, 3, 4);
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
            InsideSplitContainer.Size = new Size(923, 122);
            InsideSplitContainer.SplitterDistance = 49;
            InsideSplitContainer.SplitterWidth = 5;
            InsideSplitContainer.TabIndex = 5;
            // 
            // SqlServerUser
            // 
            SqlServerUser.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            SqlServerUser.Location = new Point(110, 8);
            SqlServerUser.Margin = new Padding(3, 4, 3, 4);
            SqlServerUser.Name = "SqlServerUser";
            SqlServerUser.Size = new Size(315, 27);
            SqlServerUser.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 19);
            label4.Name = "label4";
            label4.Size = new Size(68, 20);
            label4.TabIndex = 6;
            label4.Text = "SQL User";
            // 
            // SqlServerPass
            // 
            SqlServerPass.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            SqlServerPass.Location = new Point(539, 8);
            SqlServerPass.Margin = new Padding(3, 4, 3, 4);
            SqlServerPass.Name = "SqlServerPass";
            SqlServerPass.Size = new Size(354, 27);
            SqlServerPass.TabIndex = 3;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(471, 19);
            label3.Name = "label3";
            label3.Size = new Size(66, 20);
            label3.TabIndex = 4;
            label3.Text = "SQL Pass";
            // 
            // DatabaseMSSQLForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(951, 281);
            ControlBox = false;
            Controls.Add(OutsideSplitContainer);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "DatabaseMSSQLForm";
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

        private TextBox SqlServerText;
        private Label label1;
        private Label label2;
        private TextBox SqlServerDatabaseText;
        private SplitContainer OutsideSplitContainer;
        private SplitContainer InsideSplitContainer;
        private CheckBox WindowsAuthCheck;
        private TextBox SqlServerPass;
        private Label label3;
        private TextBox SqlServerUser;
        private Label label4;
    }
}