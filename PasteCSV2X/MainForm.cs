using NPOI.SS.UserModel;
using PasteCSV2X.CSV;
using PasteCSV2X.Properties;
using PasteCSV2X.Util;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace PasteCSV2X
{
    public partial class MainForm : Form
    {
        #region Workbook
        private void AddLog(string message)
        {
            var log = LogTextBox.Text;
            var text = message;

            if (0 < log.Length)
            {
                text = "\r\n" + text;
            }
            LogTextBox.AppendText(text);
        }

        private void Paste(IWorkbook book, List<CsvFile> list)
        {
            var ini = MyPreference.Instance;

            foreach (ISheet sheet in book)
            {
                var sheetName = sheet.SheetName;
                var info = ini.GetSheetInfo(sheetName);

                if (info == null)
                {
                    continue;
                }
                foreach (var csv in list)
                {
                    if (!Regex.IsMatch(csv.Name, info.Pattern))
                    {
                        continue;
                    }
                    AddLog($"[{sheetName}]{info.Cell}={csv.Name}");
                    sheet.Paste(info.Cell, csv.Lines);
                }
                //sheet.ProtectSheet(string.Empty);
            }
        }

        private List<CsvFile> LoadCSV(string path)
        {
            var resultList = new List<CsvFile>();
            var files = Directory.EnumerateFiles(path, "*.csv", SearchOption.AllDirectories);
            var loader = new CsvLoader();

            foreach (var name in files)
            {
                var csv = loader.LoadAll(name);

                resultList.Add(csv);
            }
            return resultList;
        }

        private void SaveBook(string xlsName, IWorkbook book)
        {
            var dir = Path.GetDirectoryName(xlsName);
            var name = Path.GetFileNameWithoutExtension(xlsName);
            var ext = Path.GetExtension(xlsName);
            var today = DateTime.Now.ToString("yyyyMMdd");
            var newName = dir + Path.DirectorySeparatorChar + name + today + '.' + ext;

            using (var stream = new FileStream(newName, FileMode.Create))
            {
                book.Write(stream);
            }
        }
        #endregion

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
            var xlsName = ExcelTextBox.Text;
            var csvList = LoadCSV(CsvTextBox.Text);

            try
            {
                var book = WorkbookFactory.Create(xlsName);

                Paste(book, csvList);
                SaveBook(xlsName, book);
            }
            catch
            {
                MessageBox.Show($"Failed.[{xlsName}]", "PasteCSV2X", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
