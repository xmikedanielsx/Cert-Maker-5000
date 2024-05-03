using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CertMaker5000
{
    public partial class FieldManagementForm : Form
    {
        public List<PDFFieldValue> pDFFieldValues = new List<PDFFieldValue>();
        public List<string> CSVFields = new List<string>();
        public BindingSource CSVFieldsBindingSource;
        public BindingSource PDFFieldValueBindingSource;
        PDFFieldValue EditRow;
        bool IsEditing = false;
        public FieldManagementForm()
        {
            InitializeComponent();
            PDFFieldValueBindingSource = new BindingSource { DataSource = pDFFieldValues };
            CSVFieldsBindingSource = new BindingSource { DataSource = CSVFields };
            FieldsDataGrid.DataSource = PDFFieldValueBindingSource;
            CSVFieldsCombo.DataSource = CSVFieldsBindingSource;
        }

        private void FieldsDataGrid_DoubleClick(object sender, EventArgs e)
        {
            if (FieldsDataGrid.SelectedRows.Count > 0)
            {

                EditRow = (PDFFieldValue)FieldsDataGrid.SelectedRows[0].DataBoundItem;
                PDFFieldTextBox.Text = EditRow.Field;
                CSVFieldsCombo.Text = EditRow.Value;

                IsEditing = true;
                AddEditButtonTextChange();
            }
        }
        private void AddEditButtonTextChange()
        {
            AddEditFieldButton.Text = IsEditing ? "Save" : "Add";
        }

        private void FieldManagementForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private void AddEditFieldButton_Click(object sender, EventArgs e)
        {
            // Validation Step

            // Is PDF Field Text Box Empty?
            if (String.IsNullOrEmpty(PDFFieldTextBox.Text))
            {
                MessageBox.Show($"You must provide text in the {Environment.NewLine}PDF Field TextBox");
                return;
            }

            // Is PDF Field Value Text Box Empty?
            if (String.IsNullOrEmpty(CSVFieldsCombo.Text))
            {
                MessageBox.Show($"You must provide text in the {Environment.NewLine}PDF Field Value TextBox");
                return;
            }

            // ToDo: .. Add Validation that the field Exists in the PDF as a fillable field

            PDFFieldValue row;
            if (IsEditing) // Editing a Row
            {
                row = EditRow;

            }
            else // Adding a Row
            {
                row = new PDFFieldValue();
                PDFFieldValueBindingSource.Add(row);

            }
            row.Field = PDFFieldTextBox.Text;
            row.Value = CSVFieldsCombo.Text;
            FieldsDataGrid.Refresh();
            IsEditing = false;
            ClearForm();
            AddEditButtonTextChange();

        }

        private void ClearForm()
        {
            PDFFieldTextBox.Text = String.Empty;
            CSVFieldsCombo.Text = String.Empty;
        }

        private void FieldsDataGrid_DataSourceChanged(object sender, EventArgs e)
        {
            FieldsDataGrid.Columns["Display"].Visible = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }

    public class PDFFieldValue
    {
        public PDFFieldValue()
        {
            Field = String.Empty;
            Value = String.Empty;
        }
        public string Field { get; set; }
        public string Value { get; set; }
        public string Display { get { return Field + "( " + Value + " )"; } }
    }
}
