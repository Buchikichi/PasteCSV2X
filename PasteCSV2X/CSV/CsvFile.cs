using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace PasteCSV2X.CSV
{
    public class CsvFile : IEnumerable<string[]>
    {
        #region Properties
        public string Filename { get; set; }
        public List<string[]> Lines { get; } = new List<string[]>();
        public string Name
        {
            get
            {
                return Path.GetFileName(Filename);
            }
        }
        #endregion

        #region IEnumerable
        public IEnumerator<string[]> GetEnumerator()
        {
            return Lines.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return Lines.GetEnumerator();
        }
        #endregion
    }
}
