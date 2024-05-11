using DataContextLibrary;
using DataContextLibrary.DTOs;
using DataContextLibrary.Models;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace CertMaker5000.Screens
{
    public partial class EventsForm : Form
    {
        DataContext db;
        List<Event> CurrentEvents;
        bool IsEditing = false;
        Event CurrentEvent;
        int CurrentEventIndex;
        bool DataInitialLoaded = false;

        public EventsForm(DataContext db)
        {
            InitializeComponent();
            this.db = db;
            ReloadAllTheData();
        }

        private void ReloadAllTheData()
        {
            DataInitialLoaded = false;
            CurrentEvents = db.Events.ToList();
            EventsDataGrid.DataSource = CurrentEvents;
            List<string> columnstokeep = new List<string>() { "Name" };
            foreach (DataGridViewColumn column in EventsDataGrid.Columns)
            {
                column.Visible = false;
            }
            foreach (string s in columnstokeep)
            {
                EventsDataGrid.Columns[s].Visible = true;
            }


            EventsDataGrid.Refresh();
            DataInitialLoaded = true;
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            ReloadAllTheData();
        }

        private void EventsDataGrid_SelectionChanged(object sender, EventArgs e)
        {
            if (EventsDataGrid.SelectedRows.Count > 0 && DataInitialLoaded)
            {
                Event? Event = EventsDataGrid.SelectedRows[0].DataBoundItem as Event;
                if (IsEditing)
                {
                    DialogResult result = MessageBox.Show("Looks like you were editing a previous entry. Do you wan to leave that unsaved work?", "Confirm Leave UnSaved Work", MessageBoxButtons.OKCancel);
                    if (result != DialogResult.OK)
                    {
                        EventsDataGrid.SelectedRows[0].Selected = false;
                        EventsDataGrid.Rows[CurrentEventIndex].Selected = true;
                        return;
                    }
                }
                CurrentEvent = Event;
                CurrentEventIndex = EventsDataGrid.SelectedRows[0].Index;


                TitleTextBox.Text = Event.Name;
                DescriptionTextBox.Text = Event.Description;

                IsEditing = true;
            }
            else if (EventsDataGrid.Rows.Count > 0 && EventsDataGrid.SelectedRows.Count == 0 && DataInitialLoaded)
            {
                IsEditing = false;
                EventsDataGrid.Rows[0].Selected = true;
            }

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            CurrentEvent.Name = TitleTextBox.Text;
            CurrentEvent.Description = DescriptionTextBox.Text;
            CurrentEvent.Address1 = Address1TextBox.Text;
            CurrentEvent.Address2 = Address2TextBox.Text;
            CurrentEvent.City = CityTextBox.Text;
            CurrentEvent.State = StateTextBox.Text;
            CurrentEvent.Zip = !String.IsNullOrEmpty(ZipTextBox.Text) ? Convert.ToInt32(ZipTextBox.Text) : null;
            db.SaveChanges();


            IsEditing = false;
        }
    }
}
