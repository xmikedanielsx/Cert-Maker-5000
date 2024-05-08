using System.Collections.Generic;

namespace CertMaker5000
{
    public partial class MainStartForm : Form
    {

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
        List<DatabasesSupportedListItem> DatabaseTypesSupported;

        public MainStartForm()
        {
            InitializeComponent();
            BackColor = HelperClasses.GetSystemColor();
            ForeColor = HelperClasses.GetSystemFontColor();
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
            // SQLite
            if(DatabaseTypeCombo.SelectedItem == DatabaseSqliteItem)
            {

            }
            // MSSQL
            if (DatabaseTypeCombo.SelectedItem == DatabaseMSSQLItem)
            {

            }
        }

    }

    class DatabasesSupportedListItem
    {
        public DatabasesSupportedListItem()
        {
            this.Name = string.Empty;
        }
        public string Name { get; set; }
        public Control? Control { get; set; }
    }
}
