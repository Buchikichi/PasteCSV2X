using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;

namespace PasteCSV2X.Util
{
    public abstract class Preference
    {
        #region Members
        private const string INI_FILE = "preference.ini";

        private string Filename { get; }
        #endregion

        protected string GetProfileString(string appName, string keyName, string defaultValue = "")
        {
            var buff = new StringBuilder(1024);

            GetPrivateProfileString(appName, keyName, defaultValue, buff, (uint)buff.Capacity, Filename);
            return buff.ToString();
        }

        protected int GetProfileInt(string appName, string keyName, int defaultValue = 0)
        {
            var result = defaultValue;
            var text = GetProfileString(appName, keyName);

            int.TryParse(text, out result);
            return result;
        }

        #region Initialize
        protected Preference()
        {
            var exe = Assembly.GetExecutingAssembly().Location;

            Filename = Path.GetDirectoryName(exe) + Path.DirectorySeparatorChar + INI_FILE;
        }
        #endregion

        #region Kernel32
        [DllImport("kernel32.dll")]
        private static extern uint
            GetPrivateProfileString(string lpAppName,
                string lpKeyName, string lpDefault,
                StringBuilder lpReturnedString, uint nSize,
                string lpFileName);
        #endregion
    }
}
