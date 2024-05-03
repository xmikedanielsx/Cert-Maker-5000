using CsvHelper;
using CsvHelper.Configuration;
using iTextSharp.text.pdf;
using Microsoft.VisualBasic.FileIO;
using Microsoft.WindowsAPICodePack.Dialogs;
using System.Data;
using System.Diagnostics;
using System.Globalization;
using System.Linq;

namespace CertMaker5000
{
    public partial class MainForm : Form
    {
        FieldManagementForm FieldManagementForm = new FieldManagementForm();
        bool ValidPDFFile = false;
        bool ValidCSVFile = false;
        string ValidPDFFilePath = "";
        string ValidCSVFilePath = "";
        string EmailBody = "";
        DataTable CSVDataTable = new DataTable();
        public MainForm()
        {
            InitializeComponent();
        }
        public static int CountBools(params bool[] args)
        {
            return args.Count(t => !t);
        }
        private void FieldManagerLabel_Click(object sender, EventArgs e)
        {
            FieldManagementForm.Show();
        }
        private void CheckValidation()
        {
            if (CountBools(ValidPDFFile, ValidCSVFile) == 0)
            {
                FieldManagerLabel.Visible = true;
            }
            else
            {
                FieldManagerLabel.Visible = false;
            }
        }
        private DialogResult? WarningOfResetFields(string PdfOrCsv)
        {
            if (PdfOrCsv.ToUpper() == "PDF" && FieldManagementForm.pDFFieldValues.Count > 0)
            {
                return MessageBox.Show("Please note that if you choose a different PDF. Your field mapping will be reset and you will need to redo this again.", "Data Reset Confirmation", MessageBoxButtons.OKCancel);
            }
            if (PdfOrCsv.ToUpper() == "CSV")
            {
                return MessageBox.Show("Please note that if you choose a different PDF. Your field mapping will be reset and you will need to redo this again.", "Data Reset Confirmation", MessageBoxButtons.OKCancel);
            }
            return null;
        }
        private void LoadPDFFields()
        {
            FileInfo CertFile = new FileInfo(CertTemplateTextBox.Text);
            if (!CertFile.Exists)
            {
                MessageBox.Show("Sorry your template not exist or you do not have access to it");
                return;
            }


            PdfReader pdfReader = new PdfReader(CertFile.FullName);
            AcroFields docfields = pdfReader.AcroFields;
            ICollection<string> FieldKeys = docfields.Fields.Keys;
            ValidPDFFile = ValidatePDFFile(CertFile.FullName);
            if (ValidPDFFile)
            {
                FieldManagementForm.PDFFieldValueBindingSource.Clear();
                foreach (var k in FieldKeys)
                {
                    var val = new PDFFieldValue();
                    val.Field = k;
                    FieldManagementForm.PDFFieldValueBindingSource.Add(val);
                }
            }

        }

        private bool ValidatePDFFile(string FilePath)
        {
            PdfReader pdfReader = new PdfReader(FilePath);
            AcroFields docfields = pdfReader.AcroFields;
            ICollection<string> FieldKeys = docfields.Fields.Keys;
            if (FieldKeys == null || FieldKeys.Count == 0)
            {
                MessageBox.Show("Sorry but your PDF does not have any fillable fields and therefore is not valid.");
                return false;
            }
            return true;
        }

        private void LoadPdfButton_Click(object sender, EventArgs e)
        {
            PreviewPDF();
            PreviewTabControl.SelectedTab = PDFPreviewTab;
        }

        private void WritePDF(string? FilePath, DataRow? row = null)
        {
            // C:\Users\Owner\Downloads\DRopCertTemplate.pdf
            // ToDo: Refactor this. not to repeakj Logic in other locations.
            FileInfo CertFile = new FileInfo(CertTemplateTextBox.Text);
            if (!CertFile.Exists)
            {
                MessageBox.Show("Sorry your template not exist or you do not have access to it");
                return;
            }
            if (FilePath == null)
            {
                string FileName = @"DRopCertTemplate.pdf";
                FilePath = Path.Combine(@"C:\Users\Owner\Downloads\", FileName);
            }
            row["PDFFilePathColumn"] = FilePath;
            //row["PhotoFilePathColumn"] = FilePath;


            using (FileStream outFile = new FileStream(FilePath, FileMode.Create))
            {
                PdfReader pdfReader = new PdfReader(CertFile.FullName);
                PdfStamper pdfStamper = new PdfStamper(pdfReader, outFile) { FormFlattening = true };
                AcroFields docfields = pdfStamper.AcroFields;
                if (row == null)
                {
                    foreach (PDFFieldValue f in FieldManagementForm.PDFFieldValueBindingSource)
                    {
                        docfields.SetField(f.Field, f.Value);
                    }
                }
                else
                {
                    foreach (PDFFieldValue f in FieldManagementForm.PDFFieldValueBindingSource)
                    {
                        if (f.Value.Contains("{{"))
                        {
                            string field = f.Value;
                            field = field.Replace("{{", "");
                            field = field.Replace("}}", "");
                            string NewFieldValue = row.Field<string>(field).ToString();
                            docfields.SetField(f.Field, NewFieldValue);
                        }
                        else
                        {
                            docfields.SetField(f.Field, f.Value);
                        }

                    }
                }


                pdfStamper.Close();
                pdfReader.Close();

                FileInfo fi = new FileInfo(FilePath);
                string ImagePath = Path.Combine(fi.Directory.FullName, Path.GetFileNameWithoutExtension(fi.Name) + ".jpg").ToString();
                row["PhotoFilePathColumn"] = ImagePath;
                byte[] pdfbytearray = File.ReadAllBytes(FilePath);
                string pdfstring = Convert.ToBase64String(pdfbytearray, 0, pdfbytearray.Length);

                PDFtoImage.Conversion.SaveJpeg(ImagePath, pdfstring);
                PDFViewerPicture.ImageLocation = ImagePath;
            }
        }

        private void WritePDFButton_Click(object sender, EventArgs e)
        {
            //WritePDF(Path.Combine(CertDropTextBox.Text, "DRopCertTemplate.pdf"));
        }

        private void OpenPDFTemplateDialogButton_Click(object sender, EventArgs e)
        {
            DialogResult? result = null;
            if (!String.IsNullOrEmpty(CertTemplateTextBox.Text))
            {
                result = WarningOfResetFields("PDF");
            }
            if (result == DialogResult.Cancel)
            {
                return;
            }

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "PDF Files|*.pdf";
            ofd.Multiselect = false;
            ofd.CheckFileExists = true;
            ofd.CheckPathExists = true;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                if (result != null && result == DialogResult.OK)
                {
                    FieldManagementForm.PDFFieldValueBindingSource.Clear();
                }
                CertTemplateTextBox.Text = ofd.FileName;
                LoadPDFFields();
            }

        }

        private void OpenCsvFileDialogButton_Click(object sender, EventArgs e)
        {
            if (!ValidPDFFile)
            {
                MessageBox.Show("Sorry, but you must first select a PDF file so we can load it's fields.");
                return;
            }
            DialogResult? result = null;
            if (!String.IsNullOrEmpty(CertTemplateTextBox.Text))
            {
                result = WarningOfResetFields("CSV");
            }

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Delimited (Comma,Tab,Pipe)|*.csv;*.txt";
            ofd.Multiselect = false;
            ofd.CheckFileExists = true;
            ofd.CheckPathExists = true;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                if (result != null && result == DialogResult.OK)
                {
                    foreach (PDFFieldValue f in FieldManagementForm.PDFFieldValueBindingSource)
                    {
                        f.Value = null!;
                    }
                }
                UserCSVFileTextBox.Text = ofd.FileName;
                ValidCSVFile = ValidateCSVFile(ofd.FileName);
                CheckValidation();
                VariablesAllowedListBox.DataSource = FieldManagementForm.PDFFieldValueBindingSource;
                VariablesAllowedListBox.DisplayMember = "Display";
                VariablesAllowedListBox.ValueMember = "Value";
            }
        }

        private bool ValidateCSVFile(string FilePath)
        {

            IEnumerable<string> lines = File.ReadLines(FilePath).Take(10).ToList();
            char? delim = DetectDelimiter(lines);
            List<string> ErrorList = new List<string>();
            if (delim != null)
            {

                // ToDo: This needs work. As this delimits the file. But it does not delimit per row.
                using (var parser = new TextFieldParser(FilePath))
                {
                    parser.TextFieldType = FieldType.Delimited;
                    parser.SetDelimiters(delim.ToString());

                    string[] line;

                    while (!parser.EndOfData)
                    {
                        try
                        {
                            line = parser.ReadFields();
                        }
                        catch (MalformedLineException ex)
                        {
                            ErrorList.Add(ex.Message);
                        }
                    }
                }
                // Use CSV Helper . Get DataTable
                var config = new CsvConfiguration(CultureInfo.InvariantCulture)
                {
                    Delimiter = delim.ToString(),
                };
                using (var reader = new StreamReader(FilePath))

                using (var csv = new CsvReader(reader, config))
                {
                    using (var dr = new CsvDataReader(csv))
                    {
                        var dt = new DataTable();
                        dt.Load(dr);
                        DataColumn PDFFilePathColumn = new()
                        {
                            DataType = typeof(String),
                            ColumnName = "PDFFilePathColumn",
                            DefaultValue = string.Empty
                        };
                        DataColumn PhotoFilePathColumn = new()
                        {
                            DataType = typeof(String),
                            ColumnName = "PhotoFilePathColumn",
                            DefaultValue = string.Empty
                        };
                        dt.Columns.Add(PDFFilePathColumn);
                        dt.Columns.Add(PhotoFilePathColumn);
                        CSVDataTable = dt;
                        UserListBox.DisplayMember = "";
                        UserListBox.ValueMember = "";
                        bool ContainsEmail = false;
                        bool ContainsName = false;
                        List<string> UserListColumnNames = new List<string>();
                        List<string> UserListColumnEmailNames = new();
                        List<string> UserListColumnNameNames = new();
                        FieldManagementForm.CSVFieldsBindingSource.Clear();
                        foreach (DataColumn c in CSVDataTable.Columns)
                        {
                            FieldManagementForm.CSVFieldsBindingSource.Add("{{" + c.ColumnName + "}}");
                            if (c.ColumnName.ToUpper().Contains("EMAIL") || c.ColumnName.ToUpper().Contains("E-MAIL"))
                            {
                                ContainsEmail = true;
                                UserListColumnNames.Add(c.ColumnName);
                                UserListColumnEmailNames.Add(c.ColumnName);
                            }

                            if (c.ColumnName.ToUpper().Contains("NAME"))
                            {
                                ContainsName = true;
                                UserListColumnNames.Add(c.ColumnName);
                                UserListColumnNameNames.Add(c.ColumnName);
                            }

                        }

                        UserListBox.DataSource = dt;

                        if (ContainsEmail)
                        {
                            UserListBox.DisplayMember = UserListColumnEmailNames.FirstOrDefault();
                            UserListBox.ValueMember = UserListColumnEmailNames.FirstOrDefault();
                        }
                        else if (ContainsName)
                        {
                            UserListBox.DisplayMember = UserListColumnNameNames.FirstOrDefault();
                            UserListBox.ValueMember = UserListColumnNameNames.FirstOrDefault();
                        }

                        else
                        {
                            UserListBox.DisplayMember = CSVDataTable.Columns[0].ColumnName;
                            UserListBox.ValueMember = CSVDataTable.Columns[0].ColumnName;
                        }



                        FieldManagementForm.CSVFieldsCombo.Refresh();




                    }
                }
                if (ErrorList.Count > 0)
                {
                    string ErrorMessage = ""
                            + "Sorry, your Delimited File is not valid" + Environment.NewLine
                            + $"We detected your delimiter as {(delim == '\t' ? "{tab}" : delim.ToString())}" + Environment.NewLine
                            + $"We then we tried parse your file with this delimiter and was not able to successfully parse it." + Environment.NewLine
                            + $"Please check your file and make sure it's a valid delimited file." + Environment.NewLine
                            + $"The errors we were able to find are listed below:" + Environment.NewLine
                         ;
                    foreach (string s in ErrorList)
                    {
                        ErrorMessage += (s + Environment.NewLine);
                    }
                    MessageBox.Show(ErrorMessage);

                    return false;
                }

            }
            else
            {
                MessageBox.Show("Sorry, could not detect the delimiter of the file you provided or your file is not a proper delimited file");
                return false;
            }
            return true;

        }

        private void OpenCertDropDialogButton_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog cofd = new CommonOpenFileDialog();
            cofd.IsFolderPicker = true;
            if (cofd.ShowDialog() == CommonFileDialogResult.Ok)
            {
                CertDropTextBox.Text = cofd.FileName;
            }
        }

        //public string DetectDelimiter(IEnumerable<string> lines, IEnumerable<char> delimiters)
        public char? DetectDelimiter(IEnumerable<string> lines)
        {
            List<char> delimiters = new List<char>();
            char[] delims = { ',', '\t', '|' };
            delimiters.AddRange(delims);

            Dictionary<char, int> delimFrequency = new Dictionary<char, int>();

            // Setup our frequency tracker for given delimiters
            delimiters.ToList().ForEach(curDelim =>
              delimFrequency.Add(curDelim, 0)
            );

            // Get a total sum of all occurrences of each delimiter in the given lines
            delimFrequency.ToList().ForEach(curDelim =>
              delimFrequency[curDelim.Key] = lines.Sum(line => line.Count(p => p == curDelim.Key))
            );

            // Find delimiters that have a frequency evenly divisible by the number of lines
            // (correct & consistent usage) and order them by largest frequency
            var possibleDelimiters = delimFrequency
                              .Where(f => f.Value > 0 && f.Value % lines.Count() == 0)
                              .OrderByDescending(f => f.Value)
                              .ToList();

            // If more than one possible delimiter found, return the most used one
            if (possibleDelimiters.Any())
            {
                return possibleDelimiters.First().Key.ToString().First();
            }
            else
            {
                return null;
            }

        }

        private void PreviewPDF()
        {
            var row = ((DataRowView)UserListBox.SelectedItem).Row;
            string FilePath = Path.Combine(CertDropTextBox.Text, CSVDataTable.Rows.IndexOf(row).ToString().PadLeft(10, '0') + " " + UserListBox.SelectedValue.ToString() + ".pdf");
            WritePDF(FilePath, row);
        }

        private void UserListBox_DoubleClick(object sender, EventArgs e)
        {
            PreviewPDF();
        }
    }
}