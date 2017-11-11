using NPOI.SS.UserModel;
using PasteCSV2X.CSV;
using PasteCSV2X.Properties;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace PasteCSV2X
{
    public partial class MainForm : Form
    {
        private List<CsvFile> LoadCSV(string path)
        {
            var resultList = new List<CsvFile>();
            var files = Directory.EnumerateFiles(path, "*.csv", SearchOption.AllDirectories);
            var loader = new CsvLoader();

            foreach (var name in files)
            {
                var csv = loader.LoadAll(name);

                foreach (var line in csv)
                {
                    var text = string.Join(",", line);

                    Debug.WriteLine($"[{text}]");
                }
            }
            return resultList;
        }

        private void Paste(IWorkbook book, List<CsvFile> list)
        {
            foreach (ISheet sheet in book)
            {
                sheet.ProtectSheet(string.Empty);
            }
        }

        #region Events
        private void ChooseExcelButton_Click(object sender, EventArgs e)
        {
            var path = ExcelTextBox.Text;
            var dir = File.Exists(path) ? Path.GetDirectoryName(path) : Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            var dialog = new OpenFileDialog()
            {
                InitialDirectory = dir,
                Filter = "Excel(*.xls;*.xlsx)|*.xls;*.xlsx",
            };

            if (dialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            ExcelTextBox.Text = dialog.FileName;
        }

        private void ChooseCSVButton_Click(object sender, EventArgs e)
        {
            var path = CsvTextBox.Text;
            var dialog = new FolderBrowserDialog()
            {
                RootFolder = Environment.SpecialFolder.MyComputer,
                SelectedPath = path,
            };

            if (dialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            CsvTextBox.Text = dialog.SelectedPath;
        }

        private void EnforceButton_Click(object sender, EventArgs e)
        {
            var xls = ExcelTextBox.Text;
            var csvList = LoadCSV(CsvTextBox.Text);

            try
            {
                var book = WorkbookFactory.Create(xls);

                Paste(book, csvList);
                using (var stream = new FileStream(xls, FileMode.Create))
                {
                    book.Write(stream);
                }
            }
            catch
            {
                MessageBox.Show($"Failed.[{xls}]", "PasteCSV2X", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Initialize
        public MainForm()
        {
            InitializeComponent();
            ExitButton.Click += (sender, e) => Close();
            FormClosing += (sender, e) => Settings.Default.Save();
        }
        #endregion
    }
}
