namespace CertMaker5000
{
    public partial class DatabaseSqliteForm : Form
    {
        public DatabaseSqliteForm()
        {
            InitializeComponent();
            this.CenterToScreen();
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

        }
    }
}
