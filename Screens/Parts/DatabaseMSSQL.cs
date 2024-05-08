using Microsoft.Data.SqlClient;
using System.Data.Common;

namespace CertMaker5000
{
    public partial class DatabaseMSSQLForm : Form
    {
        public DatabaseMSSQLForm()
        {
            InitializeComponent();
            this.CenterToScreen();
            SetThemeSettings();
            InsideSplitContainer.Panel1Collapsed = true;
        }

        private void SetThemeSettings()
        {
            this.BackColor = HelperClasses.GetSystemColor();
            this.ForeColor = HelperClasses.GetSystemFontColor();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void WindowsAuthCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (WindowsAuthCheck.Checked == true)
            {
                InsideSplitContainer.Panel1Collapsed = true;
            }
            else
            {
                InsideSplitContainer.Panel1Collapsed = false;
            }
        }

        public string GetConnectionString ()
        {

            SqlConnectionStringBuilder csb = new();
            csb.DataSource = SqlServerText.Text;
            csb.InitialCatalog = SqlServerDatabaseText.Text;
            csb.TrustServerCertificate = true;
            if (!WindowsAuthCheck.Checked)
            {
                csb.UserID = SqlServerUser.Text;
                csb.Password = SqlServerPass.Text;
            } else
            {
                csb.IntegratedSecurity = true;
            }

            return csb.ConnectionString;
        }

    }
}
