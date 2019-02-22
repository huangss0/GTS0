using System;
using System.Collections.Generic;
using System.Text;

namespace HssDARWIN.Models.XBRL.DvdXBRL
{
    public class DividendXBRL
    {
        /*-----------------------------Hss Entity Framework Auto Generated Code-------------------------------*/
        private static HssUtility.SQLserver.CmdTemplate DBcmd_TP = null;
        public static HssUtility.SQLserver.CmdTemplate Get_cmdTP()
        {
            if (DividendXBRL.DBcmd_TP != null) return DividendXBRL.DBcmd_TP;

            DividendXBRL.DBcmd_TP = new HssUtility.SQLserver.CmdTemplate();
            DividendXBRL.DBcmd_TP.tableName = "Dividend_XBRL";
            DividendXBRL.DBcmd_TP.schema = "dbo";

            DividendXBRL.DBcmd_TP.AddColumn("XBRL_ID");
            DividendXBRL.DBcmd_TP.AddColumn("DividendIndex");
            DividendXBRL.DBcmd_TP.AddColumn("Depositary");/*Optional 3*/
            DividendXBRL.DBcmd_TP.AddColumn("XBRL_ReferenceNumber");
            DividendXBRL.DBcmd_TP.AddColumn("PSAFE");/*Optional 5*/
            DividendXBRL.DBcmd_TP.AddColumn("LastModifiedDate");/*Optional 6*/
            DividendXBRL.DBcmd_TP.AddColumn("SourceType");/*Optional 7*/
            DividendXBRL.DBcmd_TP.AddColumn("LastModifiedBy");/*Optional 8*/
            DividendXBRL.DBcmd_TP.AddColumn("Announcement Identifier");/*Optional 9*/
            DividendXBRL.DBcmd_TP.AddColumn("Event Completeness");/*Optional 10*/

            return DividendXBRL.DBcmd_TP;
        }

        public DividendXBRL() { }
        public DividendXBRL(int id) { this.pk_ID = id; }

        private int pk_ID = -1; //primary key
        public int XBRL_ID { get { return this.pk_ID; } }

        public readonly HssUtility.General.Attributes.Int_attr DividendIndex = new HssUtility.General.Attributes.Int_attr();
        public readonly HssUtility.General.Attributes.String_attr Depositary = new HssUtility.General.Attributes.String_attr();/*Optional 3*/
        public readonly HssUtility.General.Attributes.String_attr XBRL_ReferenceNumber = new HssUtility.General.Attributes.String_attr();
        public readonly HssUtility.General.Attributes.String_attr PSAFE = new HssUtility.General.Attributes.String_attr();/*Optional 5*/
        public readonly HssUtility.General.Attributes.DateTime_attr LastModifiedDate = new HssUtility.General.Attributes.DateTime_attr();/*Optional 6*/
        public readonly HssUtility.General.Attributes.String_attr SourceType = new HssUtility.General.Attributes.String_attr("Dividend");/*Optional 7*/
        public readonly HssUtility.General.Attributes.String_attr LastModifiedBy = new HssUtility.General.Attributes.String_attr();/*Optional 8*/
        public readonly HssUtility.General.Attributes.String_attr Announcement_Identifier = new HssUtility.General.Attributes.String_attr();/*Optional 9*/
        public readonly HssUtility.General.Attributes.String_attr Event_Completeness = new HssUtility.General.Attributes.String_attr();/*Optional 10*/

        private Dictionary<string, HssUtility.General.Attributes.I_modelAttr> attr_dic = null;

        internal void Init_from_reader(HssUtility.SQLserver.DB_reader reader)
        {
            if (reader == null || reader.IsClosed) return;

            this.pk_ID = reader.GetInt("XBRL_ID");
            reader.GetInt("DividendIndex", this.DividendIndex);
            reader.GetString("Depositary", this.Depositary);/*Optional 3*/
            reader.GetString("XBRL_ReferenceNumber", this.XBRL_ReferenceNumber);
            reader.GetString("PSAFE", this.PSAFE);/*Optional 5*/
            reader.GetDateTime("LastModifiedDate", this.LastModifiedDate);/*Optional 6*/
            reader.GetString("SourceType", this.SourceType);/*Optional 7*/
            reader.GetString("LastModifiedBy", this.LastModifiedBy);/*Optional 8*/
            reader.GetString("Announcement Identifier", this.Announcement_Identifier);/*Optional 9*/
            reader.GetString("Event Completeness", this.Event_Completeness);/*Optional 10*/

            this.SyncWithDB();
        }

        /// <summary>
        /// Initialize object from DB
        /// </summary>
        public bool Init_from_DB()
        {
            if (this.XBRL_ID < 0) return false;

            HssUtility.SQLserver.DB_select db_sel = new HssUtility.SQLserver.DB_select(DividendXBRL.Get_cmdTP());
            db_sel.tableName = "Dividend_XBRL";
            HssUtility.SQLserver.SQL_relation rela = new HssUtility.SQLserver.SQL_relation("XBRL_ID", HssUtility.General.RelationalOperator.Equals, this.XBRL_ID);
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
            this.Create_attrDic();
            foreach (HssUtility.General.Attributes.I_modelAttr ma in this.attr_dic.Values) ma.SyncWithDB();
        }

        public bool CheckValueChanges()
        {
            this.Create_attrDic();
            foreach (HssUtility.General.Attributes.I_modelAttr ma in this.attr_dic.Values) if (ma.ValueChanged) return true;
            return false;
        }

        private void Create_attrDic()
        {
            if (this.attr_dic != null) return;

            this.attr_dic = new Dictionary<string, HssUtility.General.Attributes.I_modelAttr>(StringComparer.OrdinalIgnoreCase);
            this.attr_dic.Add("DividendIndex", this.DividendIndex);
            this.attr_dic.Add("Depositary", this.Depositary);/*Optional 3*/
            this.attr_dic.Add("XBRL_ReferenceNumber", this.XBRL_ReferenceNumber);
            this.attr_dic.Add("PSAFE", this.PSAFE);/*Optional 5*/
            this.attr_dic.Add("LastModifiedDate", this.LastModifiedDate);/*Optional 6*/
            this.attr_dic.Add("SourceType", this.SourceType);/*Optional 7*/
            this.attr_dic.Add("LastModifiedBy", this.LastModifiedBy);/*Optional 8*/
            this.attr_dic.Add("Announcement Identifier", this.Announcement_Identifier);/*Optional 9*/
            this.attr_dic.Add("Event Completeness", this.Event_Completeness);/*Optional 10*/
        }

        /// <summary>
        /// Insert object to DB
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
            HssUtility.SQLserver.DB_insert dbIns = new HssUtility.SQLserver.DB_insert(DividendXBRL.Get_cmdTP());

            dbIns.AddValue("DividendIndex", this.DividendIndex);
            dbIns.AddValue("Depositary", this.Depositary);/*Optional 3*/
            dbIns.AddValue("XBRL_ReferenceNumber", this.XBRL_ReferenceNumber);
            dbIns.AddValue("PSAFE", this.PSAFE);/*Optional 5*/
            dbIns.AddValue("LastModifiedDate", this.LastModifiedDate);/*Optional 6*/
            dbIns.AddValue("SourceType", this.SourceType);/*Optional 7*/
            dbIns.AddValue("LastModifiedBy", this.LastModifiedBy);/*Optional 8*/
            dbIns.AddValue("Announcement Identifier", this.Announcement_Identifier);/*Optional 9*/
            dbIns.AddValue("Event Completeness", this.Event_Completeness);/*Optional 10*/

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

            HssUtility.SQLserver.DB_update upd = new HssUtility.SQLserver.DB_update(DividendXBRL.Get_cmdTP());
            if (this.DividendIndex.ValueChanged) upd.AddValue("DividendIndex", this.DividendIndex);
            if (this.Depositary.ValueChanged) upd.AddValue("Depositary", this.Depositary);/*Optional 3*/
            if (this.XBRL_ReferenceNumber.ValueChanged) upd.AddValue("XBRL_ReferenceNumber", this.XBRL_ReferenceNumber);
            if (this.PSAFE.ValueChanged) upd.AddValue("PSAFE", this.PSAFE);/*Optional 5*/
            if (this.LastModifiedDate.ValueChanged) upd.AddValue("LastModifiedDate", this.LastModifiedDate);/*Optional 6*/
            if (this.SourceType.ValueChanged) upd.AddValue("SourceType", this.SourceType);/*Optional 7*/
            if (this.LastModifiedBy.ValueChanged) upd.AddValue("LastModifiedBy", this.LastModifiedBy);/*Optional 8*/
            if (this.Announcement_Identifier.ValueChanged) upd.AddValue("Announcement Identifier", this.Announcement_Identifier);/*Optional 9*/
            if (this.Event_Completeness.ValueChanged) upd.AddValue("Event Completeness", this.Event_Completeness);/*Optional 10*/

            HssUtility.SQLserver.SQL_relation rela = new HssUtility.SQLserver.SQL_relation("XBRL_ID", HssUtility.General.RelationalOperator.Equals, this.pk_ID);
            upd.SetCondition(rela);

            return upd;
        }

        public DividendXBRL GetCopy()
        {
            DividendXBRL newEntity = new DividendXBRL();
            if (!this.DividendIndex.IsNull_flag) newEntity.DividendIndex.Value = this.DividendIndex.Value;
            if (!this.Depositary.IsNull_flag) newEntity.Depositary.Value = this.Depositary.Value;
            if (!this.XBRL_ReferenceNumber.IsNull_flag) newEntity.XBRL_ReferenceNumber.Value = this.XBRL_ReferenceNumber.Value;
            if (!this.PSAFE.IsNull_flag) newEntity.PSAFE.Value = this.PSAFE.Value;
            if (!this.LastModifiedDate.IsNull_flag) newEntity.LastModifiedDate.Value = this.LastModifiedDate.Value;
            if (!this.SourceType.IsNull_flag) newEntity.SourceType.Value = this.SourceType.Value;
            if (!this.LastModifiedBy.IsNull_flag) newEntity.LastModifiedBy.Value = this.LastModifiedBy.Value;
            if (!this.Announcement_Identifier.IsNull_flag) newEntity.Announcement_Identifier.Value = this.Announcement_Identifier.Value;
            if (!this.Event_Completeness.IsNull_flag) newEntity.Event_Completeness.Value = this.Event_Completeness.Value;
            return newEntity;
        }

        public string ToXML()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("<DividendXBRL>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<XBRL_ID>").Append(this.XBRL_ID).Append("</XBRL_ID>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<DividendIndex>").Append(this.DividendIndex.Value).Append("</DividendIndex>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Depositary>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.Depositary.Value)).Append("</Depositary>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<XBRL_ReferenceNumber>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.XBRL_ReferenceNumber.Value)).Append("</XBRL_ReferenceNumber>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<PSAFE>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.PSAFE.Value)).Append("</PSAFE>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<LastModifiedDate>").Append(this.LastModifiedDate.Value).Append("</LastModifiedDate>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<SourceType>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.SourceType.Value)).Append("</SourceType>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<LastModifiedBy>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.LastModifiedBy.Value)).Append("</LastModifiedBy>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Announcement Identifier>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.Announcement_Identifier.Value)).Append("</Announcement Identifier>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Event Completeness>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.Event_Completeness.Value)).Append("</Event Completeness>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("</DividendXBRL>").Append(HssUtility.General.HssStr.WinNextLine);
            return sb.ToString();
        }
        /*^^^^^^^^^^^^^^^^^^^^^^^^^^^^^Hss Entity Framework Auto Generated Code^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^*/

        public bool IsCompleteEvent_flag
        {
            get
            {
                if (this.Event_Completeness.IsValueEmpty) return false;
                return this.Event_Completeness.Value.StartsWith("Complete", StringComparison.OrdinalIgnoreCase);
            }
        }
    }
}
