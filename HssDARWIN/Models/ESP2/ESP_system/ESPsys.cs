using System.Collections.Generic;
using HssUtility.General.Attributes;
using HssUtility.SQLserver;

namespace HssDARWIN.Models.ESP2.ESP_system
{
    public class ESPsys
    {
        private static CmdTemplate DBcmd_TP = null;
        public static CmdTemplate Get_cmdTP()
        {
            if (ESPsys.DBcmd_TP != null) return ESPsys.DBcmd_TP;

            ESPsys.DBcmd_TP = new CmdTemplate();
            ESPsys.DBcmd_TP.tableName = "ESPSystem";

            ESPsys.DBcmd_TP.AddColumn("esp_system_id");
            ESPsys.DBcmd_TP.AddColumn("coi_code");
            ESPsys.DBcmd_TP.AddColumn("clearing_system_id");
            ESPsys.DBcmd_TP.AddColumn("security_type_id");
            ESPsys.DBcmd_TP.AddColumn("event_restriction_id");

            return ESPsys.DBcmd_TP;
        }

        private int pk_ID = -1;//primary key
        public int esp_system_id { get { return this.pk_ID; } }

        public readonly String_attr coi_code = new String_attr("");
        public readonly Int_attr clearing_system_id = new Int_attr(1);
        public readonly Int_attr security_type_id = new Int_attr(1);
        public readonly Int_attr event_restriction_id = new Int_attr(1);

        private List<I_modelAttr> attrList = null;

        internal void Init_from_reader(DB_reader reader)
        {
            if (reader == null || reader.IsClosed) return;

            this.pk_ID = reader.GetInt("esp_system_id");
            this.coi_code.Value = reader.GetString("coi_code");
            this.clearing_system_id.Value = reader.GetInt("clearing_system_id");
            this.security_type_id.Value = reader.GetInt("security_type_id");
            this.event_restriction_id.Value = reader.GetInt("event_restriction_id");

            this.SyncWithDB();
        }

        public bool Insert_to_DB()
        {
            DB_insert ins = this.Get_DBinsert();
            int count = ins.SaveToDB(Utility.Get_ESP2_hDB());
            return count > 0;
        }

        internal DB_insert Get_DBinsert()
        {
            DB_insert dbIns = new DB_insert(ESPsys.Get_cmdTP());
            dbIns.AddValue("coi_code", this.coi_code.Value);
            dbIns.AddValue("clearing_system_id", this.clearing_system_id.Value);
            dbIns.AddValue("security_type_id", this.security_type_id.Value);
            dbIns.AddValue("event_restriction_id", this.event_restriction_id.Value);

            return dbIns;
        }

        internal void SyncWithDB()
        {
            if (this.attrList == null)
            {
                this.attrList = new List<I_modelAttr>();
                this.attrList.Add(this.coi_code);
                this.attrList.Add(this.clearing_system_id);
                this.attrList.Add(this.security_type_id);
                this.attrList.Add(this.event_restriction_id);
            }

            foreach (I_modelAttr ma in this.attrList) ma.SyncWithDB();
        }
    }
}
