using DataContextLibrary;
using DataContextLibrary.DTOs;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace CertMaker5000.Screens
{
    public partial class EventsForm : Form
    {
        DataContext db;

        public EventsForm(DataContext db)
        {
            InitializeComponent();
            this.db = db;
            ReloadAllTheData();
        }

        private void ReloadAllTheData()
        {
            var query = from c in db.Events
                        select new EventEventList { Name = c.Name, Description = c.Description };
            EventsDataGrid.DataSource = query.ToList();
            EventsDataGrid.Refresh();
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            ReloadAllTheData();
        }
    }
}
