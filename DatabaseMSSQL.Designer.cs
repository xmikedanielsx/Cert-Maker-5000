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
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            OutsideSplitContainer = new SplitContainer();
            WindowsAuthCheck = new CheckBox();
            InsideSplitContainer = new SplitContainer();
            textBox4 = new TextBox();
            label4 = new Label();
            textBox3 = new TextBox();
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
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Location = new Point(110, 4);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(783, 27);
            textBox1.TabIndex = 0;
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
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox2.Location = new Point(110, 11);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(783, 27);
            textBox2.TabIndex = 2;
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
            OutsideSplitContainer.Panel1.Controls.Add(textBox1);
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
            InsideSplitContainer.Panel1.Controls.Add(textBox4);
            InsideSplitContainer.Panel1.Controls.Add(label4);
            InsideSplitContainer.Panel1.Controls.Add(textBox3);
            InsideSplitContainer.Panel1.Controls.Add(label3);
            // 
            // InsideSplitContainer.Panel2
            // 
            InsideSplitContainer.Panel2.Controls.Add(textBox2);
            InsideSplitContainer.Panel2.Controls.Add(label2);
            InsideSplitContainer.Size = new Size(923, 122);
            InsideSplitContainer.SplitterDistance = 49;
            InsideSplitContainer.SplitterWidth = 5;
            InsideSplitContainer.TabIndex = 5;
            // 
            // textBox4
            // 
            textBox4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox4.Location = new Point(110, 8);
            textBox4.Margin = new Padding(3, 4, 3, 4);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(315, 27);
            textBox4.TabIndex = 5;
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
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBox3.Location = new Point(539, 8);
            textBox3.Margin = new Padding(3, 4, 3, 4);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(354, 27);
            textBox3.TabIndex = 3;
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

        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private TextBox textBox2;
        private SplitContainer OutsideSplitContainer;
        private SplitContainer InsideSplitContainer;
        private CheckBox WindowsAuthCheck;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox4;
        private Label label4;
    }
}