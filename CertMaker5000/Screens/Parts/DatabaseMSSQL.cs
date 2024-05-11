using DataContextLibrary;
using CertMaker5000.Screens.Interfaces;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Data.Common;

namespace CertMaker5000
{
    public partial class DatabaseMSSQLForm : Form, IGetConnectionStringUI
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
            this.BackColor = HelperClasses.GetSystemColor(HelperClasses.GetWindowsColorMode());
            this.ForeColor = HelperClasses.GetSystemFontColor(HelperClasses.GetWindowsColorMode());
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

        public DbContextOptions<DataContext> GetDbContextOptions()
        {
            return
                SqlServerDbContextOptionsExtensions
                    .UseSqlServer(new DbContextOptionsBuilder<DataContext>(), GetConnectionString())
                    .Options;
        }

        public DbContextOptionsBuilder BuildOptions(DbContextOptionsBuilder builder)
            //=> builder.UseSqlServer(GetConnectionString());
            => builder.UseSqlServer(GetConnectionString(),x => x.MigrationsAssembly("MigrationsSqlServer"));
        

        public string GetConnectionString() 
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
