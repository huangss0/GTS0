using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.IO;

using HssUtility.SQLserver;
using HssUtility.General;

namespace HssDARWIN.SubProjects.SPR_Report
{
    public class SPR_fileControl
    {
        private DataTable sourceDT = new DataTable();

        public SPR_fileControl()
        {
            this.sourceDT.Columns.Add("ID", typeof(int));
            this.sourceDT.Columns.Add("Action");
            this.sourceDT.Columns.Add("FileName");
            this.sourceDT.Columns.Add("CUSIP");
            this.sourceDT.Columns.Add("RecordDate", typeof(DateTime));
            this.sourceDT.Columns.Add("SecurityName");
            this.sourceDT.Columns.Add("CreateTime", typeof(DateTime));
            this.sourceDT.Columns.Add("CreateBy");
            this.sourceDT.Columns.Add("LastModifyAt", typeof(DateTime));
            this.sourceDT.Columns.Add("LastModifyBy");
            this.sourceDT.Columns.Add("LastModifyAction");
        }

        public static List<SPR_file> Get_SRP_fileList()
        {
            return SPR_fileControl.Get_SRP_fileList(HssStatus.None, true);
        }

        public static List<SPR_file> Get_SRP_fileList(HssStatus status, bool all_flag = false)
        {
            List<SPR_file> list = new List<SPR_file>();

            DB_select selt = new DB_select(SPR_file.Get_cmdTP());
            selt.IgnoreColumn("FileBinary");
            if (!all_flag)
            {
                SQL_relation rela = new SQL_relation("Status", RelationalOperator.Equals, (int)status);
                selt.SetCondition(rela);
            }

            DB_reader reader = new DB_reader(selt, Utility.Get_DRWIN_hDB());
            while (reader.Read())
            {
                SPR_file sf = new SPR_file();
                sf.Init_from_reader(reader);
                list.Add(sf);
            }
            reader.Close();

            return list;
        }

        public DataTable Get_viewDT(HssStatus status, bool all_flag = false)
        {
            this.sourceDT.Clear();

            List<SPR_file> list = SPR_fileControl.Get_SRP_fileList(status, all_flag);
            foreach (SPR_file sf in list)
            {
                DataRow row = sourceDT.Rows.Add();
                row["ID"] = sf.ID;
                if (!sf.CreateTime.IsNull_flag) row["CreateTime"] = sf.CreateTime.Value;

                if (Utility.Is_DWRIN_admin()) row["CreateBy"] = sf.CreateBy.Value;
                else row["CreateBy"] = "System";

                row["FileName"] = sf.FileName.Value;
                row["CUSIP"] = sf.CUSIP.Value;
                if (!sf.RecordDate.IsNull_flag) row["RecordDate"] = sf.RecordDate.Value;
                row["SecurityName"] = sf.SecurityName.Value;
                if (!sf.LastModifyAt.IsNull_flag) row["LastModifyAt"] = sf.LastModifyAt.Value;
                row["LastModifyBy"] = sf.LastModifyBy.Value;
                row["LastModifyAction"] = sf.LastModifyAction.Value;
            }

            return this.sourceDT;
        }

        /// <summary>
        /// used in inserting DTC Position
        /// </summary>
        public const int RecordTypeChar_index = 18;

        public static List<SPR_file> SplitRawFile(byte[] rawBytes)
        {
            List<SPR_file> sf_list = new List<SPR_file>();
            List<List<string>> tempDataList = new List<List<string>>();

            MemoryStream ms = new MemoryStream(rawBytes);
            StreamReader sr = new StreamReader(ms);

            string headerLine = null, trailerLine = null;

            string str = null;
            while ((str = sr.ReadLine()) != null)
            {
                if (headerLine == null && str.StartsWith("HDR", StringComparison.OrdinalIgnoreCase))
                {
                    headerLine = str;
                    continue;
                }
                if (trailerLine == null && str.StartsWith("TRL", StringComparison.OrdinalIgnoreCase))
                {
                    trailerLine = str;
                    foreach (List<string> strList in tempDataList) strList.Add(trailerLine);
                    break;
                }

                if (str.Length < 19) continue;

                char recordType_char = str[18];
                if (recordType_char == '1')
                {
                    List<string> strList = new List<string>();
                    if (headerLine != null) strList.Add(headerLine);
                    strList.Add(str);
                    tempDataList.Add(strList);
                }
                else
                {
                    if (tempDataList.Count < 1) continue;
                    List<string> strList = tempDataList[tempDataList.Count - 1];
                    strList.Add(str);
                }
            }

            foreach (List<string> strList in tempDataList)
            {
                SPR_file sf = new SPR_file();

                List<byte> byteList = new List<byte>();
                foreach (string line in strList)
                {
                    byte[] arr = Encoding.UTF8.GetBytes(line);
                    byteList.AddRange(arr);
                    arr = Encoding.UTF8.GetBytes(HssStr.WinNextLine);
                    byteList.AddRange(arr);
                }

                sf.FileBinary = byteList.ToArray();
                sf.Calculate();
                sf_list.Add(sf);
            }

            return sf_list;
        }
    }
}
