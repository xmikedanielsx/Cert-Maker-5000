using CertMaker5000.Screens.Parts;
using DataContextLibrary;

namespace CertMaker5000.Screens
{
    public partial class MainForm : Form
    {
        List<InitialColorsListItem> InitialColorsList = new();
        Color BackgroundColor;
        Color ForegroundColor;
        bool DarkTheme = HelperClasses.GetWindowsColorMode();
        List<Form> CurrentOpenForms = new List<Form>();
        EventsForm EventsForm;
        List<string> ThemeList = new() { "Light", "Dark" };
        DataContext db;
        public MainForm(DataContext db)
        {
            BackgroundColor = HelperClasses.GetSystemColor(DarkTheme);
            ForegroundColor = HelperClasses.GetSystemFontColor(DarkTheme);
            
            InitializeComponent();
            this.db = db;
            
            this.EventsForm = new EventsForm(db) { TopLevel = false };
            
            AddFormsToList();
            
            HideAllTabsOnTabControl(MainTabControl);
            EventsForm.Dock = DockStyle.Fill;
            ChangeFormInPanel(EventsForm);
            ThemeCombo.ComboBox.DataSource = ThemeList;
            ThemeCombo.SelectedIndex = 0;
        }
        private void HideAllTabsOnTabControl(TabControl theTabControl)
        {
            theTabControl.Appearance = TabAppearance.FlatButtons;
            theTabControl.ItemSize = new Size(0, 1);
            theTabControl.SizeMode = TabSizeMode.Fixed;
        }

        private void AddFormsToList()
        {
            CurrentOpenForms.Add(EventsForm);
        }

        private void ThemeCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(ThemeCombo.Text == string.Empty)
            {
                return;
            }
            if (ThemeCombo.Text == "Light")
            {
                DarkTheme = false;
            } else if (ThemeCombo.Text == "Dark")
            {
                DarkTheme = true;
            }
            //HelperClasses.SetControlColor(this,DarkTheme);
            //SetThemeColors(this);
            this.SetTheme(DarkTheme);
        }

        private void ChangeFormInPanel(Form form)
        {
            MainTabControl.TabPages.Clear();

            TabPage p = new TabPage();
            p.Controls.Add(form);

            MainTabControl.TabPages.Add(p);
            form.Show();
        }

        private void eventsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EventsForm.Dock = DockStyle.Fill;
            ChangeFormInPanel(EventsForm);
        }
    }

    
    
}
