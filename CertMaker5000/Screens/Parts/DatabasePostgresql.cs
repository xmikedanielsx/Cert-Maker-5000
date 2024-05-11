using DataContextLibrary;
using CertMaker5000.Screens.Interfaces;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Npgsql;

namespace CertMaker5000
{
    public partial class DatabasePostgresqlForm : Form, IGetConnectionStringUI
    {
        public DatabasePostgresqlForm()
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
                NpgsqlDbContextOptionsBuilderExtensions
                    .UseNpgsql(new DbContextOptionsBuilder<DataContext>(), GetConnectionString())
                    .Options;
        }
        public DbContextOptionsBuilder BuildOptions(DbContextOptionsBuilder builder)
            //=> builder.UseNpgsql(GetConnectionString());
            => builder.UseNpgsql(GetConnectionString(),x => x.MigrationsAssembly("MigrationsPostgresql"));


        public string GetConnectionString()
        {

            NpgsqlConnectionStringBuilder csb = new();
            csb.Host = SqlServerText.Text;
            csb.Port = Convert.ToInt32(SqlServerPortText.Text);
            csb.Database = SqlServerDatabaseText.Text;
            csb.Username = SqlServerUser.Text;
            csb.Password = SqlServerPass.Text;
            
            return csb.ConnectionString;

        }

    }
}
