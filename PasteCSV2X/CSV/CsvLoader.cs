using Microsoft.VisualBasic.FileIO;
using System.Text;

namespace PasteCSV2X.CSV
{
    public class CsvLoader
    {
        public CsvFile LoadAll(string path)
        {
            var result = new CsvFile()
            {
                Filename = path,
            };

            using (var parser = new TextFieldParser(path, Encoding.GetEncoding("Shift_JIS"))
            {
                TextFieldType = FieldType.Delimited,
                Delimiters = new string[] { "," },
                HasFieldsEnclosedInQuotes = true,
                TrimWhiteSpace = true,
            })
            {
                while (!parser.EndOfData)
                {
                    var line = parser.ReadFields();

                    result.Lines.Add(line);
                }
            }
            return result;
        }
    }
}
