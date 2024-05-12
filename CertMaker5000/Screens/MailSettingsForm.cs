using DataContextLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MailKit.Net.Smtp;
using MimeKit;
using MailKit.Security;

namespace CertMaker5000.Screens
{
    public partial class MailSettingsForm : Form
    {
        DataContext db;
        public string EmailServer;
        public int EmailPort;
        public bool EmailUseSSL;
        public string EmailUser;
        public string EmailPass;
        public string EmailSendAs;
        public MailSettingsForm(DataContext db)
        {
            InitializeComponent();
            this.db = db;
        }

        private void SaveTextToVariables()
        {
            EmailServer = EmailServerText.Text;
            EmailPort = String.IsNullOrEmpty(EmailPortText.Text) ? 25 : Convert.ToInt32(EmailPortText.Text);
            EmailUseSSL = UseSSLCheck.Checked;
            EmailUser = EmailUserText.Text;
            EmailPass = EmailPassText.Text;
            EmailSendAs = EmailSendAsText.Text;
        }

        private async void SaveSettingsButton_Click(object sender, EventArgs e)
        {
            SaveTextToVariables();

        }

        private void UseSSLCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (UseSSLCheck.Checked && (EmailPortText.Text.Contains("25") || !EmailPortText.Text.Contains("465")))
            {
                EmailPortText.Text = "587";
            }
            else if (!UseSSLCheck.Checked && (!EmailPortText.Text.Contains("25") || EmailPortText.Text.Contains("465") || EmailPortText.Text.Contains("587")))
            {
                EmailPortText.Text = "25";
            }
        }

        private void TestEmailButton_Click(object sender, EventArgs e)
        {
            try
            {
                SaveTextToVariables();
                SmtpClient client = new();
                if (EmailUseSSL && EmailPort == 587)
                {
                    client.Connect(EmailServer, EmailPort, SecureSocketOptions.StartTls);
                }
                else
                {
                    client.Connect(EmailServer, EmailPort, EmailUseSSL);
                }

                client.Authenticate(EmailUser, EmailPass);
                var Body = new BodyBuilder()
                {
                    TextBody = "New Test Email"
                };

                var email = new MimeMessage()
                {
                    From = { new MailboxAddress("Cert Maker 5000", EmailSendAs) },
                    To = { new MailboxAddress("to", TestEmailToText.Text) },
                    Subject = "Test Subject",
                    Body = Body.ToMessageBody()

                };
                TestEmailStatusLabel.Text = "Sending Test E-Mail Now";
                try
                {
                    client.Send(email);

                }
                catch (Exception ee)
                {

                    TestEmailStatusLabel.ForeColor = Color.Red;
                    TestEmailStatusLabel.Text = ee.Message;
                }
                TestEmailStatusLabel.ForeColor = Color.Green;
                TestEmailStatusLabel.Text = "Test E-Mail Succesfully Sent";
                if (client.IsConnected)
                {
                    client.Disconnect(true);
                }
                client.Dispose();


            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
