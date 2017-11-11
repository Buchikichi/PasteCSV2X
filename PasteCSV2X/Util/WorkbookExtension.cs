using NPOI.SS.UserModel;
using NPOI.SS.Util;
using System.Collections.Generic;

namespace PasteCSV2X.Util
{
    public static class WorkbookExtension
    {
        /// <summary>
        /// シートに値を貼り付ける.
        /// </summary>
        /// <param name="sheet">シート</param>
        /// <param name="cellReference">セル</param>
        /// <param name="lines">値</param>
        public static void Paste(this ISheet sheet, string cellReference, List<string[]> lines)
        {
            var reference = new CellReference(cellReference);
            var rowNum = reference.Row;
            var colStart = reference.Col;

            foreach (var csv in lines)
            {
                var row = sheet.GetRow(rowNum);

                row.Paste(colStart, csv);
                rowNum++;
            }
        }

        /// <summary>
        /// ROWに値を貼り付ける.
        /// </summary>
        /// <param name="row">行</param>
        /// <param name="colStart">開始カラム</param>
        /// <param name="values">値</param>
        public static void Paste(this IRow row, int colStart, params string[] values)
        {
            var colNum = colStart;

            foreach (var cellValue in values)
            {
                var cell = row.GetCell(colNum);

                if (!string.IsNullOrWhiteSpace(cellValue))
                {
                    cell.SetCellValue(cellValue);
                }
                colNum++;
            }
        }
    }
}
