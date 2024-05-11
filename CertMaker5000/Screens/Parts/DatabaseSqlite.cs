using DataContextLibrary;
using CertMaker5000.Screens.Interfaces;
using Microsoft.Data.SqlClient;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;

namespace CertMaker5000
{
    public partial class DatabaseSqliteForm : Form, IGetConnectionStringUI
    {
        public DatabaseSqliteForm()
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

        private void BrowseDatabaseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "SqLite Databases|*.sqlite";
            ofd.Multiselect = false;
            ofd.CheckFileExists = false;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                DatabaseLocationText.Text = ofd.FileName;
            }
        }

        public DbContextOptions<DataContext> GetDbContextOptions()
        {
            return
                SqliteDbContextOptionsBuilderExtensions
                    .UseSqlite(new DbContextOptionsBuilder<DataContext>(), GetConnectionString())
                    .Options;
        }
        public DbContextOptionsBuilder BuildOptions(DbContextOptionsBuilder builder)
            //=> builder.UseSqlite(GetConnectionString())
            => builder.UseSqlite(GetConnectionString(), x => x.MigrationsAssembly("MigrationsSqLite"));


        public string GetConnectionString()
        {
            SqliteConnectionStringBuilder csb = new();

            csb.DataSource = DatabaseLocationText.Text;
            if (!String.IsNullOrEmpty(DatabasePasswordText.Text))
            {
                csb.Password = DatabasePasswordText.Text;
            }
            // ToDo: Store pass in registry here. (Encrypted/Decrypt Method)

            return csb.ConnectionString;
        }
    }
}
