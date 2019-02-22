using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.IO.Compression;
using System.Text;

using ClosedXML.Excel;

namespace HssUtility.General
{
    public class HssExcel
    {
        public const int HeaderDetectRange = 16;

        public static DataSet Excel_to_DS(string filePath)
        {
            DataSet ds = new DataSet();
            XLWorkbook workBook = null;

            try { workBook = new XLWorkbook(filePath); }
            catch (Exception ex)
            {
                Console.WriteLine("HssExcel error 0: " + ex.ToString());
                return ds;
            }

            foreach (IXLWorksheet sheet in workBook.Worksheets)
            {
                DataTable dt = HssExcel.Sheet_to_DT(sheet);
                ds.Tables.Add(dt);
            }

            return ds;
        }

        public static DataTable Sheet_to_DT(IXLWorksheet sheet)
        {
            if (sheet == null) return null;

            DataTable dt = new DataTable(sheet.Name);
            int headerRowID = HssExcel.GetHeaderRowID(sheet);
            //Console.WriteLine(sheet.Name + " header: " + headerRowID);
            if (headerRowID < 0) return dt;

            int rowID = 0, col_count = 0;
            List<string> colName_list = null;

            foreach (IXLRow xl_row in sheet.Rows())
            {
                if (rowID > headerRowID)
                {
                    DataRow dt_row = dt.Rows.Add();
                    for (int i = 0; i < col_count; ++i) dt_row[i] = xl_row.Cell(i + 1).Value;
                }
                else if (rowID == headerRowID)
                {
                    colName_list = HssExcel.GetNames_from_cells(xl_row.Cells());
                    col_count = colName_list.Count;
                    foreach (string s in colName_list) dt.Columns.Add(s);
                }

                ++rowID;
            }

            return dt;
        }

        public static int GetHeaderRowID(IXLWorksheet sheet)
        {
            int headerRow_id = -1;
            if (sheet == null) return headerRow_id;

            int rowID = 0, max_textCount = 0;
            string temp_str = null;

            foreach (IXLRow row in sheet.Rows())
            {
                int text_count = 0;
                foreach (IXLCell cell in row.Cells())
                {
                    if (cell.DataType == XLDataType.Text)
                    {
                        temp_str = cell.Value.ToString();
                        if (!string.IsNullOrEmpty(temp_str)) ++text_count;
                    }
                }

                if (text_count > max_textCount)
                {
                    max_textCount = text_count;
                    headerRow_id = rowID;
                }

                if (++rowID > HssExcel.HeaderDetectRange) break;
            }

            return headerRow_id;
        }

        public const string DupNameSpliter0 = " (";
        public const string DupNameSpliter1 = ")";

        public static List<string> GetNames_from_cells(IXLCells cells)
        {
            if (cells == null) return null;

            HashSet<string> hs = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
            List<string> nameList = new List<string>();

            foreach (IXLCell cell in cells)
            {
                string val_str = cell.Value.ToString();
                if (hs.Contains(val_str))
                {
                    int temp_int = 1;
                    string temp_str = val_str + HssExcel.DupNameSpliter0 + temp_int + HssExcel.DupNameSpliter1;
                    while (hs.Contains(temp_str))
                    {
                        ++temp_int;
                        temp_str = val_str + HssExcel.DupNameSpliter0 + temp_int + HssExcel.DupNameSpliter1;
                    }

                    hs.Add(temp_str);
                    nameList.Add(temp_str);
                }
                else
                {
                    hs.Add(val_str);
                    nameList.Add(val_str);
                }
            }

            return nameList;
        }

        public static bool DS_to_Excel(string xlsxpath, DataSet ds)
        {
            if (ds == null || ds.Tables.Count < 1) return false;
            for (int i = 0; i < ds.Tables.Count; ++i)
            {
                DataTable dt = ds.Tables[i];
                if (string.IsNullOrEmpty(dt.TableName)) dt.TableName = "Table" + i;
            }

            XLWorkbook workBook = new XLWorkbook();
            workBook.AddWorksheet(ds);
            workBook.SaveAs(xlsxpath);

            return true;
        }

        public static bool DT_to_Excel(string xlsxpath, DataTable dt)
        {
            if (dt == null) return false;
            if (string.IsNullOrEmpty(dt.TableName)) dt.TableName = "Table0";

            XLWorkbook workBook = new XLWorkbook();
            workBook.AddWorksheet(dt);
            workBook.SaveAs(xlsxpath);

            return true;
        }

    }
}
