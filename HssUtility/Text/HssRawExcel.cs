using System.Collections.Generic;
using System.Data;
using System.Text;
using System.IO;
using System.IO.Compression;
using System.Reflection;

using HssUtility.General;
using HssUtility.Debug;

namespace HssUtility.Text
{
    public class HssRawExcel
    {
        public const int OneTimeAmount = 9999;
        public I_hssLog hLog = new HssThreadInfo_log();

        public void Create_Excel_fromDS(DataSet ds, string fileName)
        {
            if (ds == null || ds.Tables.Count < 1) return;
            if (string.IsNullOrEmpty(fileName)) return;

            int lastID = fileName.LastIndexOf('\\');
            if (lastID < 0) return;

            string rootFolder = fileName.Substring(0, lastID + 1) + "h$$Excel\\";
            this.Sub1_Create_Excel_templateFolder(rootFolder);

            this.Create_Excel_fromDS(ds, fileName, rootFolder);
            Directory.Delete(rootFolder, true);
        }

        /// <summary>
        /// Native and faster way to export large DataSet to Excel
        /// </summary>
        /// <param name="ds"></param>
        /// <param name="fileName"></param>
        /// <param name="templateFolder"></param>
        public void Create_Excel_fromDS(DataSet ds, string fileName, string templateFolder)
        {
            if (!Directory.Exists(templateFolder)) return;

            foreach (string filePath in Directory.EnumerateFiles(templateFolder + "\\xl\\worksheets\\")) File.Delete(filePath);

            Dictionary<string, int> dic = this.Creat_Dic_fromDS(ds);
            this.Create_SharedString_fromDic(dic, templateFolder + "\\xl\\sharedStrings.xml");
            this.Create_WBrels_fromDS(ds, templateFolder + "\\xl\\_rels\\workbook.xml.rels");
            this.Create_WB_fromDS(ds, templateFolder + "\\xl\\workbook.xml");
            for (int i = 1; i <= ds.Tables.Count; ++i)
                this.Create_Sheet_fromDT(ds.Tables[i - 1], templateFolder + "\\xl\\worksheets\\sheet" + i + ".xml", dic);

            if (File.Exists(fileName)) File.Delete(fileName);
            ZipFile.CreateFromDirectory(templateFolder, fileName, CompressionLevel.Fastest, false);

            ++this.hLog.RecordNum;
        }

        /*-----------------------------------------------------------------------------------------------------------------------------------*/

        /// <summary>
        /// Create Dictionary of shared string (C# can maintain the order of keys, no list needed for now)
        /// </summary>
        private Dictionary<string, int> Creat_Dic_fromDS(DataSet ds)
        {
            Dictionary<string, int> dic = new Dictionary<string, int>();
            if (ds == null) return dic;

            foreach (DataTable dt in ds.Tables)
            {
                int colCount = dt.Columns.Count;
                foreach (DataColumn col in dt.Columns)
                {
                    string str = col.ColumnName;
                    if (string.IsNullOrEmpty(str)) continue;
                    if (dic.ContainsKey(str)) continue;

                    dic[str] = dic.Count;
                }

                foreach (DataRow row in dt.Rows)
                {
                    for (int i = 0; i < colCount; ++i)
                    {
                        string str = row[i].ToString();
                        if (string.IsNullOrEmpty(str)) continue;
                        if (dic.ContainsKey(str)) continue;

                        dic[str] = dic.Count;
                    }

                    ++this.hLog.RecordNum;
                }
            }

            return dic;
        }

        /// <summary>
        /// Create sharedStrings.xml
        /// </summary>
        private void Create_SharedString_fromDic(Dictionary<string, int> dic, string fileName)
        {
            if (string.IsNullOrEmpty(fileName) || dic == null) return;

            string header_str = "<?xml version='1.0' encoding='UTF-8' standalone='yes'?>" + HssStr.WinNextLine +
                "<sst xmlns='http://schemas.openxmlformats.org/spreadsheetml/2006/main' " +
                "count='" + dic.Count + "' uniqueCount='" + dic.Count + "'>" + HssStr.WinNextLine;

            FileStream fs = new FileStream(fileName, FileMode.Create);
            byte[] header_bts = Encoding.UTF8.GetBytes(header_str);
            fs.Write(header_bts, 0, header_bts.Length);

            StringBuilder sb = new StringBuilder();
            int count = 0;
            foreach (string s in dic.Keys)
            {
                sb.Append("<si><t>" + HssStr.ToSafeXML_str(s) + "</t></si>" + HssStr.WinNextLine);

                if (++count % HssRawExcel.OneTimeAmount == 0)
                {
                    byte[] arr = Encoding.UTF8.GetBytes(sb.ToString());
                    fs.Write(arr, 0, arr.Length);
                    sb.Clear();
                }

                ++this.hLog.RecordNum;
            }

            if (sb.Length > 0)
            {
                byte[] arr = Encoding.UTF8.GetBytes(sb.ToString());
                fs.Write(arr, 0, arr.Length);
            }

            byte[] tail_bts = Encoding.UTF8.GetBytes("</sst>");
            fs.Write(tail_bts, 0, tail_bts.Length);
            fs.Close();
        }

        /// <summary>
        /// Create worksheets\sheet1.xml, sheet2.xml, sheet3.xml...
        /// </summary>
        private void Create_Sheet_fromDT(DataTable dt, string fileName, Dictionary<string, int> dic)
        {
            if (string.IsNullOrEmpty(fileName) || dt == null || dic == null) return;

            string header_str = "<?xml version='1.0' encoding='UTF-8' standalone='yes'?>" + HssStr.WinNextLine +
                "<worksheet xmlns='http://schemas.openxmlformats.org/spreadsheetml/2006/main'><sheetData>" + HssStr.WinNextLine;

            FileStream fs = new FileStream(fileName, FileMode.Create);
            byte[] header_bts = Encoding.UTF8.GetBytes(header_str);
            fs.Write(header_bts, 0, header_bts.Length);

            int colCount = dt.Columns.Count;

            //data columns
            StringBuilder col_sb = new StringBuilder("<row r='1'>").Append(HssStr.WinNextLine);
            for (int c = 0; c < colCount; ++c)
            {
                DataColumn col = dt.Columns[c];
                string val_str = col.ColumnName;
                if (string.IsNullOrEmpty(val_str)) continue;
                if (!dic.ContainsKey(val_str)) continue;

                int sharedStrID = dic[val_str];
                string colHeader_str = HssStr.Excel_ID_to_Title(c);

                col_sb.Append("<c r='" + colHeader_str + "1' t='s'><v>");
                col_sb.Append(sharedStrID);
                col_sb.Append("</v></c>").Append(HssStr.WinNextLine);

                ++this.hLog.RecordNum;
            }

            col_sb.Append("</row>").Append(HssStr.WinNextLine);
            byte[] col_arr = Encoding.UTF8.GetBytes(col_sb.ToString());
            fs.Write(col_arr, 0, col_arr.Length);

            //data rows
            StringBuilder row_sb = new StringBuilder();

            for (int i = 0, r = 2; i < dt.Rows.Count; ++r, ++i)
            {
                DataRow row = dt.Rows[i];
                StringBuilder sb = new StringBuilder("<row r='" + r + "'>").Append(HssStr.WinNextLine);

                for (int c = 0; c < colCount; ++c)
                {
                    string val_str = row[c].ToString();
                    if (string.IsNullOrEmpty(val_str)) continue;
                    if (!dic.ContainsKey(val_str)) continue;

                    int sharedStrID = dic[val_str];
                    string colHeader_str = HssStr.Excel_ID_to_Title(c);

                    sb.Append("<c r='" + colHeader_str + r + "' t='s'><v>");
                    sb.Append(sharedStrID);
                    sb.Append("</v></c>").Append(HssStr.WinNextLine);
                }

                sb.Append("</row>").Append(HssStr.WinNextLine);
                row_sb.Append(sb);

                if (r % HssRawExcel.OneTimeAmount == 0)
                {
                    byte[] arr = Encoding.UTF8.GetBytes(row_sb.ToString());
                    fs.Write(arr, 0, arr.Length);
                    row_sb.Clear();
                }

                ++this.hLog.RecordNum;
            }

            if (row_sb.Length > 0)
            {
                byte[] arr = Encoding.UTF8.GetBytes(row_sb.ToString());
                fs.Write(arr, 0, arr.Length);
            }

            //last part
            byte[] tail_bts = Encoding.UTF8.GetBytes("</sheetData></worksheet>");
            fs.Write(tail_bts, 0, tail_bts.Length);
            fs.Close();
        }

        /// <summary>
        /// Create workbook.xml
        /// </summary>
        private void Create_WB_fromDS(DataSet ds, string fileName)
        {
            if (string.IsNullOrEmpty(fileName) || ds == null) return;
            if (ds.Tables.Count < 1) return;

            string header_str = "<?xml version='1.0' encoding='UTF-8' standalone='yes'?>" + HssStr.WinNextLine +
                "<workbook xmlns='http://schemas.openxmlformats.org/spreadsheetml/2006/main' " + HssStr.WinNextLine +
                "xmlns:r='http://schemas.openxmlformats.org/officeDocument/2006/relationships'><sheets>" + HssStr.WinNextLine;

            FileStream fs = new FileStream(fileName, FileMode.Create);
            byte[] header_bts = Encoding.UTF8.GetBytes(header_str);
            fs.Write(header_bts, 0, header_bts.Length);

            for (int i = 1; i <= ds.Tables.Count; ++i)
            {
                DataTable dt = ds.Tables[i - 1];
                string str = "<sheet name=\"" + HssStr.ToSafeXML_str(dt.TableName) +
                    "\" sheetId='" + i + "' r:id='hssSheet" + i + "'/>" + HssStr.WinNextLine;
                byte[] arr = Encoding.UTF8.GetBytes(str);
                fs.Write(arr, 0, arr.Length);

                ++this.hLog.RecordNum;
            }

            byte[] tail_bts = Encoding.UTF8.GetBytes("</sheets></workbook>");
            fs.Write(tail_bts, 0, tail_bts.Length);
            fs.Close();
        }

        /// <summary>
        /// Create _rels\workbook.xml.rels
        /// </summary>
        private void Create_WBrels_fromDS(DataSet ds, string fileName)
        {
            if (string.IsNullOrEmpty(fileName) || ds == null) return;

            StringBuilder header_sb = new StringBuilder("<?xml version='1.0' encoding='UTF-8' standalone='yes'?>").Append(HssStr.WinNextLine);
            header_sb.Append("<Relationships xmlns='http://schemas.openxmlformats.org/package/2006/relationships'>").Append(HssStr.WinNextLine);

            header_sb.Append("<Relationship Id='hssID1' Type='http://schemas.openxmlformats.org/officeDocument/2006/relationships/theme' ")
                .Append("Target='theme/theme1.xml'/>").Append(HssStr.WinNextLine);
            header_sb.Append("<Relationship Id='hssID2' Type='http://schemas.openxmlformats.org/officeDocument/2006/relationships/sharedStrings' ")
                .Append("Target='sharedStrings.xml'/>").Append(HssStr.WinNextLine);
            header_sb.Append("<Relationship Id='hssID3' Type='http://schemas.openxmlformats.org/officeDocument/2006/relationships/styles' ")
                .Append("Target='styles.xml'/>").Append(HssStr.WinNextLine);

            FileStream fs = new FileStream(fileName, FileMode.Create);
            byte[] header_bts = Encoding.UTF8.GetBytes(header_sb.ToString());
            fs.Write(header_bts, 0, header_bts.Length);

            for (int i = 1; i <= ds.Tables.Count; ++i)
            {
                DataTable dt = ds.Tables[i - 1];
                StringBuilder sb = new StringBuilder("<Relationship Id='hssSheet" + i + "' ");
                sb.Append("Type='http://schemas.openxmlformats.org/officeDocument/2006/relationships/worksheet' ")
                    .Append("Target='worksheets/sheet" + i + ".xml'/>").Append(HssStr.WinNextLine);

                byte[] arr = Encoding.UTF8.GetBytes(sb.ToString());
                fs.Write(arr, 0, arr.Length);

                ++this.hLog.RecordNum;
            }

            byte[] tail_bts = Encoding.UTF8.GetBytes("</Relationships>");
            fs.Write(tail_bts, 0, tail_bts.Length);
            fs.Close();
        }

        /************************************************************************************************************************************/

        public void Sub1_Create_Excel_templateFolder(string rootFolder)
        {
            string folder0 = rootFolder + "_rels\\", folder1 = rootFolder + "docProps\\", folder2 = rootFolder + "xl\\";
            string folder20 = folder2 + "_rels\\", folder21 = folder2 + "theme\\", folder22 = folder2 + "worksheets\\";

            if (!Directory.Exists(folder0)) Directory.CreateDirectory(folder0);
            if (!Directory.Exists(folder1)) Directory.CreateDirectory(folder1);
            if (!Directory.Exists(folder20)) Directory.CreateDirectory(folder20);
            if (!Directory.Exists(folder21)) Directory.CreateDirectory(folder21);
            if (!Directory.Exists(folder22)) Directory.CreateDirectory(folder22);

            Assembly asb = Assembly.GetExecutingAssembly();
            
            this.Sub2_Create_file_from_resource(folder0 + ".rels", asb.GetManifestResourceStream("HssUtility.Ref_DLLs.Resource_xml.Excel._rels.rels.xml"));
            this.Sub2_Create_file_from_resource(folder1 + "app.xml", asb.GetManifestResourceStream("HssUtility.Ref_DLLs.Resource_xml.Excel.docProps.app.xml"));
            this.Sub2_Create_file_from_resource(folder1 + "core.xml", asb.GetManifestResourceStream("HssUtility.Ref_DLLs.Resource_xml.Excel.docProps.core.xml"));
            this.Sub2_Create_file_from_resource(folder21 + "theme1.xml", asb.GetManifestResourceStream("HssUtility.Ref_DLLs.Resource_xml.Excel.xl.theme.theme1.xml"));
            this.Sub2_Create_file_from_resource(rootFolder + "[Content_Types].xml", asb.GetManifestResourceStream("HssUtility.Ref_DLLs.Resource_xml.Excel.Content_Types.xml"));
        }

        private void Sub2_Create_file_from_resource(string fileName, Stream resourceStream)
        {
            if (resourceStream == null) return;
            if (string.IsNullOrEmpty(fileName)) return;

            byte[] bts0 = new byte[resourceStream.Length];
            resourceStream.Read(bts0, 0, bts0.Length);
            resourceStream.Close();

            FileStream fs = new FileStream(fileName, FileMode.Create);
            fs.Write(bts0, 0, bts0.Length);
            fs.Close();
        }
    }
}
