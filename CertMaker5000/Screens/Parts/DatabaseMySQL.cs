using DataContextLibrary;
using CertMaker5000.Screens.Interfaces;
using Microsoft.EntityFrameworkCore;
using MySql.Data.MySqlClient;

namespace CertMaker5000
{
    public partial class DatabaseMySQLForm : Form, IGetConnectionStringUI
    {
        public DatabaseMySQLForm()
        {
            InitializeComponent();
            this.CenterToScreen();
            SetThemeSettings();
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

        public DbContextOptions<DataContext> GetDbContextOptions()
        {
            return 
                MySQLDbContextOptionsExtensions
                    .UseMySQL(new DbContextOptionsBuilder<DataContext>(), GetConnectionString())
                    .Options;
        }
        public DbContextOptionsBuilder BuildOptions(DbContextOptionsBuilder builder)
            => builder.UseMySQL(GetConnectionString(),x => x.MigrationsAssembly("MigrationsMySQL"));


        public string GetConnectionString()
        {

            MySqlConnectionStringBuilder csb = new();
            csb.Server = SqlServerText.Text;
            csb.Port = Convert.ToUInt32(SqlServerPortText.Text);
            csb.Database = SqlServerDatabaseText.Text;
            csb.UserID = SqlServerUser.Text;
            csb.Password = SqlServerPass.Text;
            
            return csb.ConnectionString;

        }

    }
}
