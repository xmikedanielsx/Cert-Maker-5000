using DataContextLibrary;
using CertMaker5000.Screens.Interfaces;
using Microsoft.EntityFrameworkCore;
using CertMaker5000.Screens.Parts;
using System.Runtime.CompilerServices;

namespace CertMaker5000
{
    public partial class MainStartForm : Form
    {
        public Func<DbContextOptionsBuilder, DbContextOptionsBuilder> MyDBSetupFunc;
        bool exitprogram = false;
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
        private static Random random = new Random();
        string RandomKey = RandomString(64);
        DirectoryInfo AppFolder = Directory.CreateDirectory(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "CertMaker5000"));
        FileInfo SettingsFile;
        FileInfo SecretFile;

        private MainStartForm()
        {
            InitializeComponent();
            BackColor = HelperClasses.GetSystemColor(HelperClasses.GetWindowsColorMode());
            ForeColor = HelperClasses.GetSystemFontColor(HelperClasses.GetWindowsColorMode());
            this.CenterToScreen();
            LoadDBTypesAsDeployed();

            SettingsAndStuff();
        }

        private void SettingsAndStuff()
        {
            string SettingsFilePath = Path.Combine(AppFolder.FullName, ".settings");
            string SecretFilePath = Path.Combine(AppFolder.FullName, ".id");
            if (!File.Exists(SettingsFilePath))
                File.AppendAllText(SettingsFilePath, String.Empty);
            if (!File.Exists(SecretFilePath))
                File.AppendAllText(SecretFilePath, String.Empty);
            SettingsFile = new FileInfo(SettingsFilePath);
            SecretFile = new FileInfo(SecretFilePath);
            if (TotalLines(SecretFilePath) == 0)
            {
                File.AppendAllText(SecretFile.FullName, RandomKey);
            }
        }

        int TotalLines(string filePath)
        {
            using (StreamReader r = new StreamReader(filePath))
            {
                int i = 0;
                while (r.ReadLine() != null) { i++; }
                return i;
            }
        }

        public static string RandomString(int length)
        {
            const string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
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
            ExitProgram();
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
                    //if (!IsCreating)
                    //{
                    //    db.Database.Migrate();
                    //}

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
                            ExitProgram();
                        }
                    }
                }
                else
                {
                    try
                    {
                        //db.Database.EnsureCreated();
                        db.Database.Migrate();
                        MessageBox.Show("Database Created");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(connectionerror);
                        ExitProgram();
                        
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

        private void ExitProgram()
        {
            this.MyDBSetupFunc = null;
            Application.Exit();
        }

        internal static Func<DbContextOptionsBuilder, DbContextOptionsBuilder> DialogForDatabaseConfig()
        {
            var form = new MainStartForm();

            try
            {
                form.ShowDialog();
            } 
            catch (Exception ex) {
                Application.Exit();
            }
            
            return form.MyDBSetupFunc;

        }
    }

    
}
