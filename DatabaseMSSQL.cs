namespace CertMaker5000
{
    public partial class DatabaseMSSQLForm : Form
    {
        public DatabaseMSSQLForm()
        {
            InitializeComponent();
            this.CenterToScreen();
            SetThemeSettings();
            InsideSplitContainer.Panel1Collapsed = true;
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

        private void WindowsAuthCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (WindowsAuthCheck.Checked == true)
            {
                InsideSplitContainer.Panel1Collapsed = true;
            }
            else
            {
                InsideSplitContainer.Panel1Collapsed = false;
            }
        }

    }
}
