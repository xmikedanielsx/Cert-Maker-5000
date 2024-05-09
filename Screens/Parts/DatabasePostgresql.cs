using CertMaker5000.Data;
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
            this.BackColor = HelperClasses.GetSystemColor();
            this.ForeColor = HelperClasses.GetSystemFontColor();
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
            => builder.UseNpgsql(GetConnectionString());


        public string GetConnectionString()
        {

            NpgsqlConnectionStringBuilder csb = new();
            csb.Host = SqlServerText.Text;
            csb.Port = Convert.ToInt32(SqlServerPortText.Text);
            csb.Database = SqlServerDatabaseText.Text;
            csb.Username = SqlServerUser.Text;
            csb.Password = SqlServerUser.Text;
            
            return csb.ConnectionString;

        }

    }
}
