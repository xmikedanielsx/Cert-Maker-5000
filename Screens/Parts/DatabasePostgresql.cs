using Microsoft.Data.SqlClient;
using Npgsql;

namespace CertMaker5000
{
    public partial class DatabasePostgresqlForm : Form
    {
        public DatabasePostgresqlForm()
        {
            InitializeComponent();
            this.CenterToScreen();
            SetThemeSettings();
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

        public string GetConnectionString()
        {

            NpgsqlConnectionStringBuilder csb = new();
            csb.Host = SqlServerText.Text;
            csb.Port = Convert.ToInt32(SqlServerPortText.Text);
            csb.Database = SqlServerDatabaseText.Text;
            csb.Username = SqlServerUser.Text;
            csb.Password = SqlServerUser.Text;
            
            return csb.ConnectionString;

            // BRB. Checking on Son
        }

    }
}
