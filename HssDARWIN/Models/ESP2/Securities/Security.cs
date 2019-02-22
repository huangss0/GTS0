using System;
using System.Collections.Generic;

using HssUtility.General.Attributes;
using HssUtility.SQLserver;
using HssDARWIN.Models.Countries;
using HssDARWIN.Models.ESP2.ESP_system;

namespace HssDARWIN.Models.ESP2.Securities
{
    public class Security
    {
        private static CmdTemplate DBcmd_TP = null;
        public static CmdTemplate Get_cmdTP()
        {
            if (Security.DBcmd_TP != null) return Security.DBcmd_TP;

            Security.DBcmd_TP = new CmdTemplate();
            Security.DBcmd_TP.tableName = "Security";

            Security.DBcmd_TP.AddColumn("security_id");
            Security.DBcmd_TP.AddColumn("security_name");
            Security.DBcmd_TP.AddColumn("esp_system_id");
            Security.DBcmd_TP.AddColumn("cusip");
            Security.DBcmd_TP.AddColumn("isin");
            Security.DBcmd_TP.AddColumn("sedol");

            return Security.DBcmd_TP;
        }

        private int pk_ID = -1;//primary key
        public int security_id { get { return this.pk_ID; } }

        public readonly String_attr security_name = new String_attr("");
        public readonly Int_attr esp_system_id = new Int_attr(-1);
        public readonly String_attr cusip = new String_attr("");
        public readonly String_attr isin = new String_attr("");
        public readonly String_attr sedol = new String_attr("");

        private List<I_modelAttr> attrList = null;

        internal void Init_from_reader(DB_reader reader)
        {
            if (reader == null || reader.IsClosed) return;

            this.pk_ID = reader.GetInt("security_id");
            this.security_name.Value = reader.GetString("security_name");
            this.esp_system_id.Value = reader.GetInt("esp_system_id");
            this.cusip.Value = reader.GetString("cusip");
            this.isin.Value = reader.GetString("isin");
            this.sedol.Value = reader.GetString("sedol");

            this.SyncWithDB();
        }

        internal void Init_from_DRWIN_sec(Models.Securities.Security dr_sec)
        {
            if (dr_sec == null) return;

            this.security_name.Value = dr_sec.Name.Value;
            this.cusip.Value = dr_sec.CUSIP.Value;
            this.isin.Value = dr_sec.ISIN.Value;
            this.sedol.Value = dr_sec.Sedol.Value;

            Country cty = CountryMaster.GetCountry_name(dr_sec.Country.Value);
            if (cty != null)
            {
                ESPsys esys = ESPsys_master.Get_ESPsys_coi(cty.cntry_cd.Value);
                if (esys != null) this.esp_system_id.Value = esys.esp_system_id;
                else this.esp_system_id.Value = 11;// 11 is for italy
            }
        }

        public bool Insert_to_DB()
        {
            DB_insert ins = this.Get_DBinsert();
            int count = ins.SaveToDB(Utility.Get_ESP2_hDB());
            return count > 0;
        }

        internal DB_insert Get_DBinsert()
        {
            DB_insert dbIns = new DB_insert(Security.Get_cmdTP());
            dbIns.AddValue("security_name", this.security_name.Value);
            dbIns.AddValue("esp_system_id", this.esp_system_id.Value);
            dbIns.AddValue("cusip", this.cusip.Value);
            dbIns.AddValue("isin", this.isin.Value);
            dbIns.AddValue("sedol", this.sedol.Value);

            return dbIns;
        }

        internal void SyncWithDB()
        {
            if (this.attrList == null)
            {
                this.attrList = new List<I_modelAttr>();
                this.attrList.Add(this.security_name);
                this.attrList.Add(this.esp_system_id);
                this.attrList.Add(this.cusip);
                this.attrList.Add(this.isin);
                this.attrList.Add(this.sedol);
            }

            foreach (I_modelAttr ma in this.attrList) ma.SyncWithDB();
        }
    }
}
