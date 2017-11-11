namespace PasteCSV2X.Util
{
    public class MyPreference : Preference
    {
        #region Members
        private const string INI_SHEET = "SHEET";
        public static MyPreference Instance = new MyPreference();
        #endregion

        public SheetInfo GetSheetInfo(string key)
        {
            var text = GetProfileString(INI_SHEET, key);
            var elements = text.Split('\t');

            if (elements.Length < 2)
            {
                return null;
            }
            var info = new SheetInfo()
            {
                Cell = elements[0],
                Pattern = elements[1],
            };

            return info;
        }
    }

    public class SheetInfo
    {
        public string Cell { get; set; }
        public string Pattern { get; set; }
    }
}
