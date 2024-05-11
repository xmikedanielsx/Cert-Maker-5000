using CertMaker5000.Screens.Parts;
using Org.BouncyCastle.Asn1.Crmf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CertMaker5000.Screens
{
    public partial class MainForm : Form
    {
        List<InitialColorsListItem> InitialColorsList = new();
        Color BackgroundColor;
        Color ForegroundColor;
        bool DarkTheme = HelperClasses.GetWindowsColorMode();
        List<Form> CurrentOpenForms = new List<Form>();
        EventsForm EventsForm = new EventsForm() { TopLevel = false };
        List<string> ThemeList = new() { "Light", "Dark" };

        public MainForm()
        {
            BackgroundColor = HelperClasses.GetSystemColor(DarkTheme);
            ForegroundColor = HelperClasses.GetSystemFontColor(DarkTheme);
            
            InitializeComponent();
            
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
