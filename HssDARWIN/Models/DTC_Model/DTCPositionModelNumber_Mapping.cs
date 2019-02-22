using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using HssDARWIN.Models.DTC_Position;
using HssUtility.General;
using HssUtility.SQLserver;

namespace HssDARWIN.Models.DTC_Model
{
    public class DTCPositionModelNumber_Mapping
    {
        /*-----------------------------Hss Entity Framework Auto Generated Code-------------------------------*/
        private static HssUtility.SQLserver.CmdTemplate DBcmd_TP = null;
        public static HssUtility.SQLserver.CmdTemplate Get_cmdTP()
        {
            if (DTCPositionModelNumber_Mapping.DBcmd_TP != null) return DTCPositionModelNumber_Mapping.DBcmd_TP;

            DTCPositionModelNumber_Mapping.DBcmd_TP = new HssUtility.SQLserver.CmdTemplate();
            DTCPositionModelNumber_Mapping.DBcmd_TP.tableName = "DTCPositionModelNumber_Mapping";
            DTCPositionModelNumber_Mapping.DBcmd_TP.schema = "dbo";

            DTCPositionModelNumber_Mapping.DBcmd_TP.AddColumn("DTCModelMappingID");
            DTCPositionModelNumber_Mapping.DBcmd_TP.AddColumn("Country");/*Optional 2*/
            DTCPositionModelNumber_Mapping.DBcmd_TP.AddColumn("Issue");/*Optional 3*/
            DTCPositionModelNumber_Mapping.DBcmd_TP.AddColumn("RecordYear");/*Optional 4*/
            DTCPositionModelNumber_Mapping.DBcmd_TP.AddColumn("IncomeEvent");/*Optional 5*/
            DTCPositionModelNumber_Mapping.DBcmd_TP.AddColumn("ModelNumber");
            DTCPositionModelNumber_Mapping.DBcmd_TP.AddColumn("ADRRecordDate");/*Optional 7*/
            DTCPositionModelNumber_Mapping.DBcmd_TP.AddColumn("ORDPayDate");/*Optional 8*/
            DTCPositionModelNumber_Mapping.DBcmd_TP.AddColumn("SecurityTypeID");/*Optional 9*/
            DTCPositionModelNumber_Mapping.DBcmd_TP.AddColumn("ADRRecordDate_End");/*Optional 10*/
            DTCPositionModelNumber_Mapping.DBcmd_TP.AddColumn("AtSourceSumFromDetails");/*Optional 11*/

            return DTCPositionModelNumber_Mapping.DBcmd_TP;
        }

        public DTCPositionModelNumber_Mapping() { }
        public DTCPositionModelNumber_Mapping(int id) { this.pk_ID = id; }

        private int pk_ID = -1; //primary key
        public int DTCModelMappingID { get { return this.pk_ID; } }

        public readonly HssUtility.General.Attributes.String_attr Country = new HssUtility.General.Attributes.String_attr();/*Optional 2*/
        public readonly HssUtility.General.Attributes.String_attr Issue = new HssUtility.General.Attributes.String_attr();/*Optional 3*/
        public readonly HssUtility.General.Attributes.Int_attr RecordYear = new HssUtility.General.Attributes.Int_attr();/*Optional 4*/
        public readonly HssUtility.General.Attributes.String_attr IncomeEvent = new HssUtility.General.Attributes.String_attr();/*Optional 5*/
        public readonly HssUtility.General.Attributes.Int_attr ModelNumber = new HssUtility.General.Attributes.Int_attr();
        public readonly HssUtility.General.Attributes.DateTime_attr ADRRecordDate = new HssUtility.General.Attributes.DateTime_attr();/*Optional 7*/
        public readonly HssUtility.General.Attributes.DateTime_attr ORDPayDate = new HssUtility.General.Attributes.DateTime_attr();/*Optional 8*/
        public readonly HssUtility.General.Attributes.Int_attr SecurityTypeID = new HssUtility.General.Attributes.Int_attr();/*Optional 9*/
        public readonly HssUtility.General.Attributes.DateTime_attr ADRRecordDate_End = new HssUtility.General.Attributes.DateTime_attr();/*Optional 10*/
        public readonly HssUtility.General.Attributes.Bool_attr AtSourceSumFromDetails = new HssUtility.General.Attributes.Bool_attr();/*Optional 11*/

        private List<HssUtility.General.Attributes.I_modelAttr> attrList = null;

        internal void Init_from_reader(HssUtility.SQLserver.DB_reader reader)
        {
            if (reader == null || reader.IsClosed) return;

            this.pk_ID = reader.GetInt("DTCModelMappingID");
            reader.GetString("Country", this.Country);/*Optional 2*/
            reader.GetString("Issue", this.Issue);/*Optional 3*/
            reader.GetInt("RecordYear", this.RecordYear);/*Optional 4*/
            reader.GetString("IncomeEvent", this.IncomeEvent);/*Optional 5*/
            reader.GetInt("ModelNumber", this.ModelNumber);
            reader.GetDateTime("ADRRecordDate", this.ADRRecordDate);/*Optional 7*/
            reader.GetDateTime("ORDPayDate", this.ORDPayDate);/*Optional 8*/
            reader.GetInt("SecurityTypeID", this.SecurityTypeID);/*Optional 9*/
            reader.GetDateTime("ADRRecordDate_End", this.ADRRecordDate_End);/*Optional 10*/
            reader.GetBool("AtSourceSumFromDetails", this.AtSourceSumFromDetails);/*Optional 11*/

            this.SyncWithDB();
        }

        /// <summary>
        /// Initialize object from DB
        /// </summary>
        public bool Init_from_DB()
        {
            if (this.DTCModelMappingID < 0) return false;

            HssUtility.SQLserver.DB_select db_sel = new HssUtility.SQLserver.DB_select(DTCPositionModelNumber_Mapping.Get_cmdTP());
            db_sel.tableName = "DTCPositionModelNumber_Mapping";
            HssUtility.SQLserver.SQL_relation rela = new HssUtility.SQLserver.SQL_relation("DTCModelMappingID", HssUtility.General.RelationalOperator.Equals, this.DTCModelMappingID);
            db_sel.SetCondition(rela);

            bool res_flag = false;
            HssUtility.SQLserver.DB_reader reader = new HssUtility.SQLserver.DB_reader(db_sel, Utility.Get_DRWIN_hDB());
            if (reader.Read())
            {
                this.Init_from_reader(reader);
                res_flag = true;
            }
            reader.Close();
            return res_flag;
        }

        internal void SyncWithDB()
        {
            this.Create_attrList();
            foreach (HssUtility.General.Attributes.I_modelAttr ma in this.attrList) ma.SyncWithDB();
        }

        public bool CheckValueChanges()
        {
            this.Create_attrList();
            foreach (HssUtility.General.Attributes.I_modelAttr ma in this.attrList) if (ma.ValueChanged) return true;
            return false;
        }

        private void Create_attrList()
        {
            if (this.attrList != null) return;

            this.attrList = new List<HssUtility.General.Attributes.I_modelAttr>();
            this.attrList.Add(this.Country);/*Optional 2*/
            this.attrList.Add(this.Issue);/*Optional 3*/
            this.attrList.Add(this.RecordYear);/*Optional 4*/
            this.attrList.Add(this.IncomeEvent);/*Optional 5*/
            this.attrList.Add(this.ModelNumber);
            this.attrList.Add(this.ADRRecordDate);/*Optional 7*/
            this.attrList.Add(this.ORDPayDate);/*Optional 8*/
            this.attrList.Add(this.SecurityTypeID);/*Optional 9*/
            this.attrList.Add(this.ADRRecordDate_End);/*Optional 10*/
            this.attrList.Add(this.AtSourceSumFromDetails);/*Optional 11*/
        }

        /// <summary>
        /// insert object to DB
        /// </summary>
        public bool Insert_to_DB()
        {
            HssUtility.SQLserver.DB_insert ins = this.Get_DBinsert();
            int count = ins.SaveToDB(Utility.Get_DRWIN_hDB());

            bool flag = count > 0;
            if (flag) this.SyncWithDB();

            return flag;
        }

        internal HssUtility.SQLserver.DB_insert Get_DBinsert()
        {
            HssUtility.SQLserver.DB_insert dbIns = new HssUtility.SQLserver.DB_insert(DTCPositionModelNumber_Mapping.Get_cmdTP());

            dbIns.AddValue("Country", this.Country);/*Optional 2*/
            dbIns.AddValue("Issue", this.Issue);/*Optional 3*/
            dbIns.AddValue("RecordYear", this.RecordYear);/*Optional 4*/
            dbIns.AddValue("IncomeEvent", this.IncomeEvent);/*Optional 5*/
            dbIns.AddValue("ModelNumber", this.ModelNumber.Value);
            dbIns.AddValue("ADRRecordDate", this.ADRRecordDate);/*Optional 7*/
            dbIns.AddValue("ORDPayDate", this.ORDPayDate);/*Optional 8*/
            dbIns.AddValue("SecurityTypeID", this.SecurityTypeID);/*Optional 9*/
            dbIns.AddValue("ADRRecordDate_End", this.ADRRecordDate_End);/*Optional 10*/
            dbIns.AddValue("AtSourceSumFromDetails", this.AtSourceSumFromDetails);/*Optional 11*/

            return dbIns;
        }

        /// <summary>
        /// Save updates to DB
        /// </summary>
        public bool Update_to_DB()
        {
            HssUtility.SQLserver.DB_update upd = this.Get_DBupdate();
            if (upd == null) return false;

            int count = upd.SaveToDB(Utility.Get_DRWIN_hDB());
            bool flag = count > 0;
            if (flag) this.SyncWithDB();

            return flag;
        }

        internal HssUtility.SQLserver.DB_update Get_DBupdate()
        {
            if (!this.CheckValueChanges()) return null;

            HssUtility.SQLserver.DB_update upd = new HssUtility.SQLserver.DB_update(DTCPositionModelNumber_Mapping.Get_cmdTP());
            if (this.Country.ValueChanged) upd.AddValue("Country", this.Country);
            if (this.Issue.ValueChanged) upd.AddValue("Issue", this.Issue);
            if (this.RecordYear.ValueChanged) upd.AddValue("RecordYear", this.RecordYear);
            if (this.IncomeEvent.ValueChanged) upd.AddValue("IncomeEvent", this.IncomeEvent);
            if (this.ModelNumber.ValueChanged) upd.AddValue("ModelNumber", this.ModelNumber);
            if (this.ADRRecordDate.ValueChanged) upd.AddValue("ADRRecordDate", this.ADRRecordDate);
            if (this.ORDPayDate.ValueChanged) upd.AddValue("ORDPayDate", this.ORDPayDate);
            if (this.SecurityTypeID.ValueChanged) upd.AddValue("SecurityTypeID", this.SecurityTypeID);
            if (this.ADRRecordDate_End.ValueChanged) upd.AddValue("ADRRecordDate_End", this.ADRRecordDate_End);
            if (this.AtSourceSumFromDetails.ValueChanged) upd.AddValue("AtSourceSumFromDetails", this.AtSourceSumFromDetails);

            HssUtility.SQLserver.SQL_relation rela = new HssUtility.SQLserver.SQL_relation("DTCModelMappingID", HssUtility.General.RelationalOperator.Equals, this.pk_ID);
            upd.SetCondition(rela);

            return upd;
        }

        public DTCPositionModelNumber_Mapping GetCopy()
        {
            DTCPositionModelNumber_Mapping newEntity = new DTCPositionModelNumber_Mapping();
            if (!this.Country.IsNull_flag) newEntity.Country.Value = this.Country.Value;
            if (!this.Issue.IsNull_flag) newEntity.Issue.Value = this.Issue.Value;
            if (!this.RecordYear.IsNull_flag) newEntity.RecordYear.Value = this.RecordYear.Value;
            if (!this.IncomeEvent.IsNull_flag) newEntity.IncomeEvent.Value = this.IncomeEvent.Value;
            if (!this.ModelNumber.IsNull_flag) newEntity.ModelNumber.Value = this.ModelNumber.Value;
            if (!this.ADRRecordDate.IsNull_flag) newEntity.ADRRecordDate.Value = this.ADRRecordDate.Value;
            if (!this.ORDPayDate.IsNull_flag) newEntity.ORDPayDate.Value = this.ORDPayDate.Value;
            if (!this.SecurityTypeID.IsNull_flag) newEntity.SecurityTypeID.Value = this.SecurityTypeID.Value;
            if (!this.ADRRecordDate_End.IsNull_flag) newEntity.ADRRecordDate_End.Value = this.ADRRecordDate_End.Value;
            if (!this.AtSourceSumFromDetails.IsNull_flag) newEntity.AtSourceSumFromDetails.Value = this.AtSourceSumFromDetails.Value;
            return newEntity;
        }

        public string ToXML()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("<DTCPositionModelNumber_Mapping>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<DTCModelMappingID>").Append(this.DTCModelMappingID).Append("</DTCModelMappingID>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Country>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.Country.Value)).Append("</Country>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Issue>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.Issue.Value)).Append("</Issue>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<RecordYear>").Append(this.RecordYear.Value).Append("</RecordYear>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<IncomeEvent>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.IncomeEvent.Value)).Append("</IncomeEvent>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<ModelNumber>").Append(this.ModelNumber.Value).Append("</ModelNumber>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<ADRRecordDate>").Append(this.ADRRecordDate.Value).Append("</ADRRecordDate>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<ORDPayDate>").Append(this.ORDPayDate.Value).Append("</ORDPayDate>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<SecurityTypeID>").Append(this.SecurityTypeID.Value).Append("</SecurityTypeID>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<ADRRecordDate_End>").Append(this.ADRRecordDate_End.Value).Append("</ADRRecordDate_End>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<AtSourceSumFromDetails>").Append(this.AtSourceSumFromDetails.Value).Append("</AtSourceSumFromDetails>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("</DTCPositionModelNumber_Mapping>").Append(HssUtility.General.HssStr.WinNextLine);
            return sb.ToString();
        }
        /*^^^^^^^^^^^^^^^^^^^^^^^^^^^^^Hss Entity Framework Auto Generated Code^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^*/

        private List<DTC_Position_Headers> all_headers_list = new List<DTC_Position_Headers>();
        public void Create_headers()
        {
            DB_select selt = new DB_select(DTC_Position_Headers.Get_cmdTP());
            SQL_relation rela = new SQL_relation("ModelNumber", RelationalOperator.Equals, this.ModelNumber.Value);
            selt.SetCondition(rela);
            this.all_headers_list.Clear();

            DB_reader reader = new DB_reader(selt, Utility.Get_DRWIN_hDB());
            while (reader.Read())
            {
                DTC_Position_Headers dph = new DTC_Position_Headers();
                dph.Init_from_reader(reader);
                dph.Calculate();
                this.all_headers_list.Add(dph);
            }
            reader.Close();
        }

        /// <summary>
        /// Map header_hs values to Rate_Position_1,2,3... in "Dividend_DTC_Position" table
        /// Using [SortOrder] as reference to get the value
        /// </summary>
        /// <param name="header_hs">column header names in dataTable from excel</param>
        /// <returns>Dictionary with [Table_Column] index as key</returns>
        public Dictionary<int, List<string>> Get_colHeader_mapping(HashSet<string> header_hs)
        {
            Dictionary<int, List<string>> mapping = new Dictionary<int, List<string>>();
            if (header_hs == null) return mapping;

            //Rate_Position_1,2,3 as key
            Dictionary<int, DTC_Position_Headers> dic = new Dictionary<int, DTC_Position_Headers>();
            foreach (DTC_Position_Headers mi in this.all_headers_list) dic[mi.TableCol_index] = mi;

            List<DTC_Position_Headers> distinct_TC_list = new List<DTC_Position_Headers>();//we may have duplicate [Table_Column] in [DTC_Position_Headers]
            foreach (DTC_Position_Headers mi in dic.Values) distinct_TC_list.Add(mi);
            distinct_TC_list.Sort((m1, m2) => (m1.SortOrder.Value - m2.SortOrder.Value));//excel file is created based on sort order

            string header_keyWord = "Option";
            foreach (string header in header_hs)
            {
                List<string> word_list = HssStr.Str_to_wordList(header);
                if (word_list.Count < 2) continue;
                if (!word_list[0].Equals(header_keyWord, StringComparison.OrdinalIgnoreCase)) continue;

                int index = -1;
                if (!int.TryParse(word_list[1], out index)) continue;

                if (index <= 0 || index > distinct_TC_list.Count) continue;
                else --index;

                int keyVal = distinct_TC_list[index].TableCol_index;
                if (mapping.ContainsKey(keyVal)) mapping[keyVal].Add(header);
                else
                {
                    List<string> tempList = new List<string>();
                    tempList.Add(header);
                    mapping[keyVal] = tempList;
                }
            }

            return mapping;
        }

        /// <summary>
        /// Map WithHolding rate to a list of Model_item
        /// </summary>
        /// <returns>Dictionary with [WHRate] as key</returns>
        public Dictionary<decimal, List<DTC_Position_Headers>> Get_WHRcol_mapping()
        {
            Dictionary<decimal, List<DTC_Position_Headers>> mapping = new Dictionary<decimal, List<DTC_Position_Headers>>();

            foreach (DTC_Position_Headers mi in this.all_headers_list)
            {
                if (mi.WHRate.IsNull_flag) continue;

                if (mapping.ContainsKey(mi.WHRate.Value)) mapping[mi.WHRate.Value].Add(mi);
                else
                {
                    List<DTC_Position_Headers> list = new List<DTC_Position_Headers>();
                    list.Add(mi);
                    mapping[mi.WHRate.Value] = list;
                }
            }

            return mapping;
        }

        public bool CheckIssueMatch(string secName)
        {
            if (string.IsNullOrEmpty(this.Issue.Value)) return true;
            if (string.IsNullOrEmpty(secName)) return false;

            secName = secName.ToUpper();
            string[] arr = this.Issue.Value.Split(',');
            foreach (string s in arr)
            {
                if (this.ExpressionMatch(s, secName)) return true;
            }

            return false;
        }

        /// <summary>
        /// Get a list of DTC_Position_Headers that match category and discloseType 
        /// </summary>
        /// <param name="category">Empty value means all</param>
        /// <param name="discloseType">Empty value means all</param>
        public List<DTC_Position_Headers> Get_headersList(string category, string discloseType)
        {
            List<DTC_Position_Headers> list = new List<DTC_Position_Headers>();

            foreach (DTC_Position_Headers dph in this.all_headers_list)
            {
                if (!string.IsNullOrEmpty(category) && !dph.Category.Value.Equals(category, StringComparison.OrdinalIgnoreCase)) continue;
                if (!string.IsNullOrEmpty(discloseType) && !dph.DiscloseType.Value.Equals(discloseType, StringComparison.OrdinalIgnoreCase)) continue;
                list.Add(dph);
            }

            return list;
        }

        /***********************************Internal Use**************************************************/
        /// <summary>
        /// Check if whole population set contains all sample string set
        /// Useless for now
        /// </summary>
        private bool CheckContains(HashSet<string> sample_hs, HashSet<string> whole_hs)
        {
            if (whole_hs == null)
            {
                if (sample_hs == null) return true;
                else return false;
            }
            else if (sample_hs == null) return false;

            foreach (string s in sample_hs)
            {
                if (!whole_hs.Contains(s)) return false;
            }

            return true;
        }

        public bool ExpressionMatch(string exp, string value)
        {
            if (exp == null) return value == null;
            if (value == null) return false;

            return this.ExpressionMatch(exp, 0, value, 0);
        }

        private bool ExpressionMatch(string exp, int pt_e, string value, int pt_v)
        {
            if (pt_e >= exp.Length) return pt_v >= value.Length;

            char ec = exp[pt_e];
            if (ec == '%')
            {
                for (int i = pt_v; i <= value.Length; ++i)
                {
                    if (this.ExpressionMatch(exp, pt_e + 1, value, i)) return true;
                }
            }
            else
            {
                if (pt_v >= value.Length) return false;

                if (ec == value[pt_v]) return this.ExpressionMatch(exp, pt_e + 1, value, pt_v + 1);
                else return false;
            }

            return false;
        }
    }
}
