namespace CertMaker5000.Screens
{
    partial class MailSettingsForm
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
            label1 = new Label();
            MainTabControl = new TabControl();
            MainTabControlSMTP = new TabPage();
            TestEmailStatusLabel = new Label();
            TestEmailButton = new Button();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            TestEmailToText = new TextBox();
            SaveSettingsButton = new Button();
            label7 = new Label();
            label6 = new Label();
            EmailSendAsText = new TextBox();
            label5 = new Label();
            EmailPassText = new TextBox();
            label4 = new Label();
            EmailUserText = new TextBox();
            UseSSLCheck = new CheckBox();
            label3 = new Label();
            label2 = new Label();
            EmailPortText = new TextBox();
            EmailServerText = new TextBox();
            MainTabControl.SuspendLayout();
            MainTabControlSMTP.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(153, 32);
            label1.TabIndex = 0;
            label1.Text = "Mail Settings";
            // 
            // MainTabControl
            // 
            MainTabControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            MainTabControl.Controls.Add(MainTabControlSMTP);
            MainTabControl.Location = new Point(12, 44);
            MainTabControl.Name = "MainTabControl";
            MainTabControl.SelectedIndex = 0;
            MainTabControl.Size = new Size(834, 435);
            MainTabControl.TabIndex = 1;
            // 
            // MainTabControlSMTP
            // 
            MainTabControlSMTP.Controls.Add(TestEmailStatusLabel);
            MainTabControlSMTP.Controls.Add(TestEmailButton);
            MainTabControlSMTP.Controls.Add(label10);
            MainTabControlSMTP.Controls.Add(label9);
            MainTabControlSMTP.Controls.Add(label8);
            MainTabControlSMTP.Controls.Add(TestEmailToText);
            MainTabControlSMTP.Controls.Add(SaveSettingsButton);
            MainTabControlSMTP.Controls.Add(label7);
            MainTabControlSMTP.Controls.Add(label6);
            MainTabControlSMTP.Controls.Add(EmailSendAsText);
            MainTabControlSMTP.Controls.Add(label5);
            MainTabControlSMTP.Controls.Add(EmailPassText);
            MainTabControlSMTP.Controls.Add(label4);
            MainTabControlSMTP.Controls.Add(EmailUserText);
            MainTabControlSMTP.Controls.Add(UseSSLCheck);
            MainTabControlSMTP.Controls.Add(label3);
            MainTabControlSMTP.Controls.Add(label2);
            MainTabControlSMTP.Controls.Add(EmailPortText);
            MainTabControlSMTP.Controls.Add(EmailServerText);
            MainTabControlSMTP.Location = new Point(4, 24);
            MainTabControlSMTP.Name = "MainTabControlSMTP";
            MainTabControlSMTP.Padding = new Padding(3);
            MainTabControlSMTP.Size = new Size(826, 407);
            MainTabControlSMTP.TabIndex = 0;
            MainTabControlSMTP.Text = "SMTP";
            MainTabControlSMTP.UseVisualStyleBackColor = true;
            // 
            // TestEmailStatusLabel
            // 
            TestEmailStatusLabel.Location = new Point(99, 370);
            TestEmailStatusLabel.Name = "TestEmailStatusLabel";
            TestEmailStatusLabel.Size = new Size(588, 15);
            TestEmailStatusLabel.TabIndex = 17;
            TestEmailStatusLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // TestEmailButton
            // 
            TestEmailButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TestEmailButton.Location = new Point(696, 348);
            TestEmailButton.Name = "TestEmailButton";
            TestEmailButton.Size = new Size(75, 23);
            TestEmailButton.TabIndex = 16;
            TestEmailButton.Text = "Test";
            TestEmailButton.UseVisualStyleBackColor = true;
            TestEmailButton.Click += TestEmailButton_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(137, 307);
            label10.Name = "label10";
            label10.Size = new Size(299, 15);
            label10.TabIndex = 15;
            label10.Text = "Please make sure you save your settings before testing. ";
            label10.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(36, 299);
            label9.Name = "label9";
            label9.Size = new Size(95, 25);
            label9.TabIndex = 2;
            label9.Text = "Test Email";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(74, 352);
            label8.Name = "label8";
            label8.Size = new Size(19, 15);
            label8.TabIndex = 14;
            label8.Text = "To";
            label8.TextAlign = ContentAlignment.MiddleRight;
            // 
            // TestEmailToText
            // 
            TestEmailToText.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TestEmailToText.Location = new Point(99, 344);
            TestEmailToText.Name = "TestEmailToText";
            TestEmailToText.Size = new Size(588, 23);
            TestEmailToText.TabIndex = 13;
            // 
            // SaveSettingsButton
            // 
            SaveSettingsButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            SaveSettingsButton.Location = new Point(696, 254);
            SaveSettingsButton.Name = "SaveSettingsButton";
            SaveSettingsButton.Size = new Size(75, 23);
            SaveSettingsButton.TabIndex = 12;
            SaveSettingsButton.Text = "Save";
            SaveSettingsButton.UseVisualStyleBackColor = true;
            SaveSettingsButton.Click += SaveSettingsButton_Click;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Location = new Point(502, 209);
            label7.Name = "label7";
            label7.Size = new Size(269, 15);
            label7.TabIndex = 11;
            label7.Text = "95% of the time this is the same as the User Name";
            label7.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(44, 186);
            label6.Name = "label6";
            label6.Size = new Size(49, 15);
            label6.TabIndex = 10;
            label6.Text = "Send As";
            label6.TextAlign = ContentAlignment.MiddleRight;
            // 
            // EmailSendAsText
            // 
            EmailSendAsText.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            EmailSendAsText.Location = new Point(99, 183);
            EmailSendAsText.Name = "EmailSendAsText";
            EmailSendAsText.Size = new Size(672, 23);
            EmailSendAsText.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(36, 138);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 8;
            label5.Text = "Password";
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // EmailPassText
            // 
            EmailPassText.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            EmailPassText.Location = new Point(99, 135);
            EmailPassText.Name = "EmailPassText";
            EmailPassText.PasswordChar = '*';
            EmailPassText.Size = new Size(672, 23);
            EmailPassText.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(63, 91);
            label4.Name = "label4";
            label4.Size = new Size(30, 15);
            label4.TabIndex = 6;
            label4.Text = "User";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // EmailUserText
            // 
            EmailUserText.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            EmailUserText.Location = new Point(99, 88);
            EmailUserText.Name = "EmailUserText";
            EmailUserText.Size = new Size(672, 23);
            EmailUserText.TabIndex = 5;
            // 
            // UseSSLCheck
            // 
            UseSSLCheck.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            UseSSLCheck.AutoSize = true;
            UseSSLCheck.CheckAlign = ContentAlignment.MiddleRight;
            UseSSLCheck.Location = new Point(705, 49);
            UseSSLCheck.Name = "UseSSLCheck";
            UseSSLCheck.Size = new Size(66, 19);
            UseSSLCheck.TabIndex = 4;
            UseSSLCheck.Text = "Use SSL";
            UseSSLCheck.UseVisualStyleBackColor = true;
            UseSSLCheck.CheckedChanged += UseSSLCheck_CheckedChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(54, 53);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 3;
            label3.Text = "Server";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(539, 50);
            label2.Name = "label2";
            label2.Size = new Size(29, 15);
            label2.TabIndex = 2;
            label2.Text = "Port";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // EmailPortText
            // 
            EmailPortText.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            EmailPortText.Location = new Point(585, 45);
            EmailPortText.Name = "EmailPortText";
            EmailPortText.Size = new Size(114, 23);
            EmailPortText.TabIndex = 1;
            EmailPortText.Text = "25";
            // 
            // EmailServerText
            // 
            EmailServerText.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            EmailServerText.Location = new Point(99, 45);
            EmailServerText.Name = "EmailServerText";
            EmailServerText.Size = new Size(402, 23);
            EmailServerText.TabIndex = 0;
            // 
            // MailSettingsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(858, 491);
            ControlBox = false;
            Controls.Add(MainTabControl);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MailSettingsForm";
            Text = "Mail_Settings";
            MainTabControl.ResumeLayout(false);
            MainTabControlSMTP.ResumeLayout(false);
            MainTabControlSMTP.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TabControl MainTabControl;
        private TabPage MainTabControlSMTP;
        private Label label3;
        private Label label2;
        private TextBox EmailPortText;
        private TextBox EmailServerText;
        private CheckBox UseSSLCheck;
        private Label label7;
        private Label label6;
        private TextBox EmailSendAsText;
        private Label label5;
        private TextBox EmailPassText;
        private Label label4;
        private TextBox EmailUserText;
        private Button TestEmailButton;
        private Label label10;
        private Label label9;
        private Label label8;
        private TextBox TestEmailToText;
        private Button SaveSettingsButton;
        private Label TestEmailStatusLabel;
    }
}