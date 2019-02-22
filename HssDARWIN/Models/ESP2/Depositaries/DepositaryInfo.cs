using System;
using System.Collections.Generic;

using HssUtility.General.Attributes;
using HssUtility.SQLserver;


namespace HssDARWIN.Models.ESP2.Depositaries
{
    public class DepositaryInfo
    {
        private static CmdTemplate DBcmd_TP = null;
        public static CmdTemplate Get_cmdTP()
        {
            if (DepositaryInfo.DBcmd_TP != null) return DepositaryInfo.DBcmd_TP;

            DepositaryInfo.DBcmd_TP = new CmdTemplate();
            DepositaryInfo.DBcmd_TP.tableName = "DepositaryInfo";

            DepositaryInfo.DBcmd_TP.AddColumn("depositary_info_id");
            DepositaryInfo.DBcmd_TP.AddColumn("depositary_name");
            DepositaryInfo.DBcmd_TP.AddColumn("depositary_address1");
            DepositaryInfo.DBcmd_TP.AddColumn("depositary_address2");
            DepositaryInfo.DBcmd_TP.AddColumn("phone");
            DepositaryInfo.DBcmd_TP.AddColumn("fax");
            DepositaryInfo.DBcmd_TP.AddColumn("international_phone");
            DepositaryInfo.DBcmd_TP.AddColumn("depositary_full_name");
            DepositaryInfo.DBcmd_TP.AddColumn("depositary_index");
            DepositaryInfo.DBcmd_TP.AddColumn("active");
            DepositaryInfo.DBcmd_TP.AddColumn("stamp_name");

            return DepositaryInfo.DBcmd_TP;
        }

        private int pk_ID = -1;//primary key
        public int depositary_info_id { get { return this.pk_ID; } }

        public readonly String_attr depositary_name = new String_attr("");
        public readonly String_attr depositary_address1 = new String_attr("");
        public readonly String_attr depositary_address2 = new String_attr("");
        public readonly String_attr phone = new String_attr("");
        public readonly String_attr fax = new String_attr("");
        public readonly String_attr international_phone = new String_attr("");
        public readonly String_attr depositary_full_name = new String_attr("");
        public readonly Int_attr depositary_index = new Int_attr(-1);
        public readonly Bool_attr active = new Bool_attr(true);
        public readonly String_attr stamp_name = new String_attr("");

        private List<I_modelAttr> attrList = null;

        internal void Init_from_reader(DB_reader reader)
        {
            if (reader == null || reader.IsClosed) return;

            this.pk_ID = reader.GetInt("depositary_info_id");
            this.depositary_name.Value = reader.GetString("depositary_name");
            this.depositary_address1.Value = reader.GetString("depositary_address1");
            this.depositary_address2.Value = reader.GetString("depositary_address2");
            this.phone.Value = reader.GetString("phone");
            this.fax.Value = reader.GetString("fax");
            this.international_phone.Value = reader.GetString("international_phone");
            this.depositary_full_name.Value = reader.GetString("depositary_full_name");
            this.depositary_index.Value = reader.GetInt("depositary_index");
            this.active.Value = reader.GetBool("active");
            this.stamp_name.Value = reader.GetString("stamp_name");

            this.SyncWithDB();
        }

        internal void Init_from_DRWIN_depo(Models.Depositaries.Depositary depo)
        {
            if (depo == null) return;

            this.depositary_name.Value = depo.ESP_DepositaryName.Value;

            if (depo.Depositary_Address1.IsValueEmpty) this.depositary_address1.Value = "ONE NEW YORK PLAZA";
            else this.depositary_address1.Value = depo.Depositary_Address1.Value;

            if (depo.Depositary_Address2.IsValueEmpty) this.depositary_address2.Value = "34TH FLOOR";
            else this.depositary_address2.Value = depo.Depositary_Address2.Value;
            
            this.phone.Value = depo.Depositary_Phone.Value;
            this.fax.Value = depo.ESP_Fax.Value;
            this.depositary_index.Value = depo.DepositaryIndex.Value;
            this.international_phone.Value = depo.Depositary_Phone.Value;
            this.depositary_full_name.Value = depo.ESP_DepositaryFullName.Value;
        }

        public bool Insert_to_DB()
        {
            DB_insert ins = this.Get_DBinsert();
            int count = ins.SaveToDB(Utility.Get_ESP2_hDB());
            return count > 0;
        }

        internal DB_insert Get_DBinsert()
        {
            DB_insert dbIns = new DB_insert(DepositaryInfo.Get_cmdTP());
            dbIns.AddValue("depositary_name", this.depositary_name.Value);
            dbIns.AddValue("depositary_address1", this.depositary_address1.Value);
            dbIns.AddValue("depositary_address2", this.depositary_address2.Value);
            dbIns.AddValue("phone", this.phone.Value);
            dbIns.AddValue("fax", this.fax.Value);
            dbIns.AddValue("international_phone", this.international_phone.Value);
            dbIns.AddValue("depositary_full_name", this.depositary_full_name.Value);
            dbIns.AddValue("depositary_index", this.depositary_index.Value);
            dbIns.AddValue("active", this.active.Value);
            dbIns.AddValue("stamp_name", this.stamp_name.Value);

            return dbIns;
        }

        internal bool Value_haveChanges()
        {
            this.Create_attrList();
            foreach (I_modelAttr ma in this.attrList)
            {
                if (ma.ValueChanged) return true;
            }

            return false;
        }

        internal void SyncWithDB()
        {
            this.Create_attrList();
            foreach (I_modelAttr ma in this.attrList) ma.SyncWithDB();
        }

        private void Create_attrList()
        {
            if (this.attrList == null)
            {
                this.attrList = new List<I_modelAttr>();
                this.attrList.Add(this.depositary_name);
                this.attrList.Add(this.depositary_address1);
                this.attrList.Add(this.depositary_address2);
                this.attrList.Add(this.phone);
                this.attrList.Add(this.fax);
                this.attrList.Add(this.international_phone);
                this.attrList.Add(this.depositary_full_name);
                this.attrList.Add(this.depositary_index);
                this.attrList.Add(this.active);
                this.attrList.Add(this.stamp_name);
            }
        }
    }
}
