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
            SqlServerText = new TextBox();
            label1 = new Label();
            InsideSplitContainer = new SplitContainer();
            SqlServerUser = new TextBox();
            label4 = new Label();
            SqlServerPass = new TextBox();
            label3 = new Label();
            SqlServerDatabaseText = new TextBox();
            label2 = new Label();
            SqlServerPortText = new TextBox();
            label5 = new Label();
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
            OutsideSplitContainer.Location = new Point(12, 13);
            OutsideSplitContainer.Margin = new Padding(3, 4, 3, 4);
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
            OutsideSplitContainer.Size = new Size(923, 200);
            OutsideSplitContainer.SplitterWidth = 5;
            OutsideSplitContainer.TabIndex = 5;
            // 
            // SqlServerText
            // 
            SqlServerText.Location = new Point(96, 11);
            SqlServerText.Margin = new Padding(3, 4, 3, 4);
            SqlServerText.Name = "SqlServerText";
            SqlServerText.Size = new Size(504, 27);
            SqlServerText.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 11);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 1;
            label1.Text = "Server";
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
            InsideSplitContainer.Size = new Size(923, 145);
            InsideSplitContainer.SplitterDistance = 58;
            InsideSplitContainer.SplitterWidth = 5;
            InsideSplitContainer.TabIndex = 5;
            // 
            // SqlServerUser
            // 
            SqlServerUser.Location = new Point(105, 12);
            SqlServerUser.Margin = new Padding(3, 4, 3, 4);
            SqlServerUser.Name = "SqlServerUser";
            SqlServerUser.Size = new Size(355, 27);
            SqlServerUser.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 19);
            label4.Name = "label4";
            label4.Size = new Size(38, 20);
            label4.TabIndex = 6;
            label4.Text = "User";
            // 
            // SqlServerPass
            // 
            SqlServerPass.Location = new Point(547, 12);
            SqlServerPass.Margin = new Padding(3, 4, 3, 4);
            SqlServerPass.Name = "SqlServerPass";
            SqlServerPass.Size = new Size(354, 27);
            SqlServerPass.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(496, 15);
            label3.Name = "label3";
            label3.Size = new Size(36, 20);
            label3.TabIndex = 4;
            label3.Text = "Pass";
            // 
            // SqlServerDatabaseText
            // 
            SqlServerDatabaseText.Location = new Point(110, 11);
            SqlServerDatabaseText.Margin = new Padding(3, 4, 3, 4);
            SqlServerDatabaseText.Name = "SqlServerDatabaseText";
            SqlServerDatabaseText.Size = new Size(791, 27);
            SqlServerDatabaseText.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 15);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 3;
            label2.Text = "Database";
            // 
            // SqlServerPortText
            // 
            SqlServerPortText.Location = new Point(693, 11);
            SqlServerPortText.Margin = new Padding(3, 4, 3, 4);
            SqlServerPortText.Name = "SqlServerPortText";
            SqlServerPortText.Size = new Size(208, 27);
            SqlServerPortText.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(641, 14);
            label5.Name = "label5";
            label5.Size = new Size(35, 20);
            label5.TabIndex = 3;
            label5.Text = "Port";
            // 
            // DatabasePostgresqlForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(975, 249);
            ControlBox = false;
            Controls.Add(OutsideSplitContainer);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "DatabasePostgresqlForm";
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