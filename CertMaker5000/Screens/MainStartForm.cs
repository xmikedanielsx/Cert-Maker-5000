using DataContextLibrary;
using CertMaker5000.Screens.Interfaces;
using Microsoft.EntityFrameworkCore;
using CertMaker5000.Screens.Parts;
using Microsoft.Data.Sqlite;
using DataContextLibrary.Models;
using System.Runtime.CompilerServices;

namespace CertMaker5000
{
    public partial class MainStartForm : Form
    {
        public Func<DbContextOptionsBuilder, DbContextOptionsBuilder> MyDBSetupFunc;
        //List<string> DatabaseTypesSupported = new List<string>();

        DatabasesSupportedListItem DatabaseSqliteItem = new DatabasesSupportedListItem()
        {
            Name = "SqLite",
            Control = new DatabaseSqliteForm()
            {
                TopLevel = false
            }
        };
        DatabasesSupportedListItem DatabaseMSSQLItem = new DatabasesSupportedListItem()
        {
            Name = "MSSQL",
            Control = new DatabaseMSSQLForm()
            {
                TopLevel = false
            }
        };
        DatabasesSupportedListItem DatabasePostgresqlItem = new DatabasesSupportedListItem()
        {
            Name = "POSTGRESQL",
            Control = new DatabasePostgresqlForm()
            {
                TopLevel = false
            }
        };
        List<DatabasesSupportedListItem> DatabaseTypesSupported;
        //DataContext db;

        private MainStartForm()
        {
            InitializeComponent();
            BackColor = HelperClasses.GetSystemColor(HelperClasses.GetWindowsColorMode());
            ForeColor = HelperClasses.GetSystemFontColor(HelperClasses.GetWindowsColorMode());
            this.CenterToScreen();
            LoadDBTypesAsDeployed();
        }

        private void LoadDBTypesAsDeployed()
        {
            DatabaseTypeCombo.Items.Clear();
            /*
            SqLite
            Microsoft SQL Server
            PostgreSQL
            MySQL/MariaDB
            */
            DatabaseTypesSupported = new List<DatabasesSupportedListItem>(new[]
            {
                DatabaseSqliteItem,
                DatabaseMSSQLItem,
                DatabasePostgresqlItem,
            });

            DatabaseTypeCombo.DataSource = DatabaseTypesSupported;
            DatabaseTypeCombo.DisplayMember = "Name";
            DatabaseTypeCombo.ValueMember = "Name";
            DatabaseTypeCombo.Refresh();

            foreach (var item in (List<DatabasesSupportedListItem>)DatabaseTypeCombo.DataSource)
            {
                item.Control.Dock = DockStyle.Fill;
                DatabaseTypeDisplayPanel.Controls.Add(item.Control);
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DatabaseTypeCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            DatabasesSupportedListItem item = ((DatabasesSupportedListItem)DatabaseTypeCombo.SelectedItem);
            if (item != null)
            {
                CancelButton.Visible = true;
                OpenDatabaseButton.Visible = true;
                CreateDatabaseButton.Visible = true;
                foreach (var i in (List<DatabasesSupportedListItem>)DatabaseTypeCombo.DataSource)
                {
                    i.Control.Hide();
                }
                item.Control.Show();
            }
            else
            {
                return;
            }


        }

        private void OpenDatabaseButton_Click(object sender, EventArgs e)
        {
            DoDBStuff(false);
        }
        private void CreateDatabaseButton_Click(object sender, EventArgs e)
        {
            DoDBStuff(true);
        }
        
        /// <summary>
        /// This Method Either Creates or Opens a Database. 
        /// Then will Complete Migrations as needed defined in EF
        /// </summary>
        private void DoDBStuff(bool IsCreating)
        {

            var item = ((DatabasesSupportedListItem)DatabaseTypeCombo.SelectedItem);
            var itemForm = (IGetConnectionStringUI)item.Control!;
            string connstring = itemForm.GetConnectionString();

            //string connstring = item.GetConnectionString();
            MyDBSetupFunc = itemForm.BuildOptions;
            var builder = new DbContextOptionsBuilder<DataContext>();
            itemForm.BuildOptions(builder);

            using DataContext db = new DataContext(builder.Options);
            string connectionerror = "Sorry, had a problem connecting to your database or creating your database. Please make sure you have the proper permissions";
            try
            {
                //db.Database.EnsureCreated();
                if (db.Database.CanConnect())
                {
                    var currentmigrations = db.Database.GetMigrations();
                    var appliedmigrations = db.Database.GetAppliedMigrations();
                    if (currentmigrations.Count() > appliedmigrations.Count())
                    {
                        if (DialogResult.Yes == MessageBox.Show("Your database seems to be out of date? Do you want to update it now?", "Database Migration Check", MessageBoxButtons.YesNo))
                        {
                            db.Database.Migrate();
                        }
                        else
                        {
                            MessageBox.Show("Sorry, but we cannot continue to work with old database. Please select yes next time you launch the application or downgrade your application");
                        }
                    }
                }
                else
                {
                    try
                    {
                        db.Database.EnsureCreated();
                        MessageBox.Show("Database Created");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(connectionerror);
                        return;
                    }
                }
            } catch(Exception e)
            {
                MessageBox.Show(connectionerror + Environment.NewLine + e.Message);
                //throw;
            }

            db.Dispose();

            this.DialogResult = DialogResult.OK;
            this.Close();

        }

        internal static Func<DbContextOptionsBuilder, DbContextOptionsBuilder> DialogForDatabaseConfig()
        {
            var form = new MainStartForm();
            DialogResult result;
            try
            {
               result = form.ShowDialog();
            } 
            catch (Exception ex) {
                throw;
            }
            if(result != DialogResult.OK)
            {
                Application.Exit();
            }
            
            return form.MyDBSetupFunc;

        }
    }

    
}
