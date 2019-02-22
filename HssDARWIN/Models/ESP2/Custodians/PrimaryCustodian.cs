using System;
using System.Collections.Generic;
using HssDARWIN.Models.Countries;
using HssDARWIN.Models.ESP2.Events;

namespace HssDARWIN.Models.ESP2.Custodians
{
    public class PrimaryCustodian
    {
        /*-----------------------------Hss Entity Framework Auto Generated Code-------------------------------*/
        private static HssUtility.SQLserver.CmdTemplate DBcmd_TP = null;
        public static HssUtility.SQLserver.CmdTemplate Get_cmdTP()
        {
            if (PrimaryCustodian.DBcmd_TP != null) return PrimaryCustodian.DBcmd_TP;

            PrimaryCustodian.DBcmd_TP = new HssUtility.SQLserver.CmdTemplate();
            PrimaryCustodian.DBcmd_TP.tableName = "PrimaryCustodian";
            PrimaryCustodian.DBcmd_TP.schema = "dbo";

            PrimaryCustodian.DBcmd_TP.AddColumn("primary_custodian_id");
            PrimaryCustodian.DBcmd_TP.AddColumn("custodian_number");
            PrimaryCustodian.DBcmd_TP.AddColumn("name");
            PrimaryCustodian.DBcmd_TP.AddColumn("address1");/*Optional 4*/
            PrimaryCustodian.DBcmd_TP.AddColumn("address2");/*Optional 5*/
            PrimaryCustodian.DBcmd_TP.AddColumn("city");/*Optional 6*/
            PrimaryCustodian.DBcmd_TP.AddColumn("state");/*Optional 7*/
            PrimaryCustodian.DBcmd_TP.AddColumn("zip");/*Optional 8*/
            PrimaryCustodian.DBcmd_TP.AddColumn("country_code");
            PrimaryCustodian.DBcmd_TP.AddColumn("attn");/*Optional 10*/
            PrimaryCustodian.DBcmd_TP.AddColumn("phone");/*Optional 11*/
            PrimaryCustodian.DBcmd_TP.AddColumn("fax");/*Optional 12*/
            PrimaryCustodian.DBcmd_TP.AddColumn("email");/*Optional 13*/
            PrimaryCustodian.DBcmd_TP.AddColumn("event_id");
            PrimaryCustodian.DBcmd_TP.AddColumn("psafe");
            PrimaryCustodian.DBcmd_TP.AddColumn("safe_keeping_account_number");/*Optional 16*/
            PrimaryCustodian.DBcmd_TP.AddColumn("depositary_name");

            return PrimaryCustodian.DBcmd_TP;
        }

        public PrimaryCustodian() { }
        public PrimaryCustodian(int id) { this.pk_ID = id; }

        private int pk_ID = -1; //primary key
        public int primary_custodian_id { get { return this.pk_ID; } }

        public readonly HssUtility.General.Attributes.Int_attr custodian_number = new HssUtility.General.Attributes.Int_attr();
        public readonly HssUtility.General.Attributes.String_attr name = new HssUtility.General.Attributes.String_attr();
        public readonly HssUtility.General.Attributes.String_attr address1 = new HssUtility.General.Attributes.String_attr();/*Optional 4*/
        public readonly HssUtility.General.Attributes.String_attr address2 = new HssUtility.General.Attributes.String_attr();/*Optional 5*/
        public readonly HssUtility.General.Attributes.String_attr city = new HssUtility.General.Attributes.String_attr();/*Optional 6*/
        public readonly HssUtility.General.Attributes.String_attr state = new HssUtility.General.Attributes.String_attr();/*Optional 7*/
        public readonly HssUtility.General.Attributes.String_attr zip = new HssUtility.General.Attributes.String_attr();/*Optional 8*/
        public readonly HssUtility.General.Attributes.String_attr country_code = new HssUtility.General.Attributes.String_attr();
        public readonly HssUtility.General.Attributes.String_attr attn = new HssUtility.General.Attributes.String_attr();/*Optional 10*/
        public readonly HssUtility.General.Attributes.String_attr phone = new HssUtility.General.Attributes.String_attr();/*Optional 11*/
        public readonly HssUtility.General.Attributes.String_attr fax = new HssUtility.General.Attributes.String_attr();/*Optional 12*/
        public readonly HssUtility.General.Attributes.String_attr email = new HssUtility.General.Attributes.String_attr();/*Optional 13*/
        public readonly HssUtility.General.Attributes.Int_attr event_id = new HssUtility.General.Attributes.Int_attr();
        public readonly HssUtility.General.Attributes.String_attr psafe = new HssUtility.General.Attributes.String_attr();
        public readonly HssUtility.General.Attributes.String_attr safe_keeping_account_number = new HssUtility.General.Attributes.String_attr();/*Optional 16*/
        public readonly HssUtility.General.Attributes.String_attr depositary_name = new HssUtility.General.Attributes.String_attr();

        private List<HssUtility.General.Attributes.I_modelAttr> attrList = null;

        internal void Init_from_reader(HssUtility.SQLserver.DB_reader reader)
        {
            if (reader == null || reader.IsClosed) return;

            this.pk_ID = reader.GetInt("primary_custodian_id");
            reader.GetInt("custodian_number", this.custodian_number);
            reader.GetString("name", this.name);
            reader.GetString("address1", this.address1);/*Optional 4*/
            reader.GetString("address2", this.address2);/*Optional 5*/
            reader.GetString("city", this.city);/*Optional 6*/
            reader.GetString("state", this.state);/*Optional 7*/
            reader.GetString("zip", this.zip);/*Optional 8*/
            reader.GetString("country_code", this.country_code);
            reader.GetString("attn", this.attn);/*Optional 10*/
            reader.GetString("phone", this.phone);/*Optional 11*/
            reader.GetString("fax", this.fax);/*Optional 12*/
            reader.GetString("email", this.email);/*Optional 13*/
            reader.GetInt("event_id", this.event_id);
            reader.GetString("psafe", this.psafe);
            reader.GetString("safe_keeping_account_number", this.safe_keeping_account_number);/*Optional 16*/
            reader.GetString("depositary_name", this.depositary_name);

            this.SyncWithDB();
        }

        /// <summary>
        /// Initialize object from DB
        /// </summary>
        public bool Init_from_DB()
        {
            if (this.primary_custodian_id < 0) return false;

            HssUtility.SQLserver.DB_select db_sel = new HssUtility.SQLserver.DB_select(PrimaryCustodian.Get_cmdTP());
            db_sel.tableName = "PrimaryCustodian";
            HssUtility.SQLserver.SQL_relation rela = new HssUtility.SQLserver.SQL_relation("primary_custodian_id", HssUtility.General.RelationalOperator.Equals, this.primary_custodian_id);
            db_sel.SetCondition(rela);

            bool res_flag = false;
            HssUtility.SQLserver.DB_reader reader = new HssUtility.SQLserver.DB_reader(db_sel, Utility.Get_ESP2_hDB());
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
            this.attrList.Add(this.custodian_number);
            this.attrList.Add(this.name);
            this.attrList.Add(this.address1);/*Optional 4*/
            this.attrList.Add(this.address2);/*Optional 5*/
            this.attrList.Add(this.city);/*Optional 6*/
            this.attrList.Add(this.state);/*Optional 7*/
            this.attrList.Add(this.zip);/*Optional 8*/
            this.attrList.Add(this.country_code);
            this.attrList.Add(this.attn);/*Optional 10*/
            this.attrList.Add(this.phone);/*Optional 11*/
            this.attrList.Add(this.fax);/*Optional 12*/
            this.attrList.Add(this.email);/*Optional 13*/
            this.attrList.Add(this.event_id);
            this.attrList.Add(this.psafe);
            this.attrList.Add(this.safe_keeping_account_number);/*Optional 16*/
            this.attrList.Add(this.depositary_name);
        }

        /// <summary>
        /// insert object to DB
        /// </summary>
        public bool Insert_to_DB()
        {
            HssUtility.SQLserver.DB_insert ins = this.Get_DBinsert();
            int count = ins.SaveToDB(Utility.Get_ESP2_hDB());

            bool flag = count > 0;
            if (flag) this.SyncWithDB();

            return flag;
        }

        internal HssUtility.SQLserver.DB_insert Get_DBinsert()
        {
            HssUtility.SQLserver.DB_insert dbIns = new HssUtility.SQLserver.DB_insert(PrimaryCustodian.Get_cmdTP());

            dbIns.AddValue("custodian_number", this.custodian_number.Value);
            dbIns.AddValue("name", this.name.Value);
            dbIns.AddValue("address1", this.address1);/*Optional 4*/
            dbIns.AddValue("address2", this.address2);/*Optional 5*/
            dbIns.AddValue("city", this.city);/*Optional 6*/
            dbIns.AddValue("state", this.state);/*Optional 7*/
            dbIns.AddValue("zip", this.zip);/*Optional 8*/
            dbIns.AddValue("country_code", this.country_code.Value);
            dbIns.AddValue("attn", this.attn);/*Optional 10*/
            dbIns.AddValue("phone", this.phone);/*Optional 11*/
            dbIns.AddValue("fax", this.fax);/*Optional 12*/
            dbIns.AddValue("email", this.email);/*Optional 13*/
            dbIns.AddValue("event_id", this.event_id.Value);
            dbIns.AddValue("psafe", this.psafe.Value);
            dbIns.AddValue("safe_keeping_account_number", this.safe_keeping_account_number);/*Optional 16*/
            dbIns.AddValue("depositary_name", this.depositary_name.Value);

            return dbIns;
        }

        /// <summary>
        /// Save updates to DB
        /// </summary>
        public bool Update_to_DB()
        {
            HssUtility.SQLserver.DB_update upd = this.Get_DBupdate();
            if (upd == null) return false;

            int count = upd.SaveToDB(Utility.Get_ESP2_hDB());
            bool flag = count > 0;
            if (flag) this.SyncWithDB();

            return flag;
        }

        internal HssUtility.SQLserver.DB_update Get_DBupdate()
        {
            if (!this.CheckValueChanges()) return null;

            HssUtility.SQLserver.DB_update upd = new HssUtility.SQLserver.DB_update(PrimaryCustodian.Get_cmdTP());
            if (this.custodian_number.ValueChanged) upd.AddValue("custodian_number", this.custodian_number);
            if (this.name.ValueChanged) upd.AddValue("name", this.name);
            if (this.address1.ValueChanged) upd.AddValue("address1", this.address1);
            if (this.address2.ValueChanged) upd.AddValue("address2", this.address2);
            if (this.city.ValueChanged) upd.AddValue("city", this.city);
            if (this.state.ValueChanged) upd.AddValue("state", this.state);
            if (this.zip.ValueChanged) upd.AddValue("zip", this.zip);
            if (this.country_code.ValueChanged) upd.AddValue("country_code", this.country_code);
            if (this.attn.ValueChanged) upd.AddValue("attn", this.attn);
            if (this.phone.ValueChanged) upd.AddValue("phone", this.phone);
            if (this.fax.ValueChanged) upd.AddValue("fax", this.fax);
            if (this.email.ValueChanged) upd.AddValue("email", this.email);
            if (this.event_id.ValueChanged) upd.AddValue("event_id", this.event_id);
            if (this.psafe.ValueChanged) upd.AddValue("psafe", this.psafe);
            if (this.safe_keeping_account_number.ValueChanged) upd.AddValue("safe_keeping_account_number", this.safe_keeping_account_number);
            if (this.depositary_name.ValueChanged) upd.AddValue("depositary_name", this.depositary_name);

            HssUtility.SQLserver.SQL_relation rela = new HssUtility.SQLserver.SQL_relation("primary_custodian_id", HssUtility.General.RelationalOperator.Equals, this.pk_ID);
            upd.SetCondition(rela);

            return upd;
        }

        public PrimaryCustodian GetCopy()
        {
            PrimaryCustodian newEntity = new PrimaryCustodian();
            if (!this.custodian_number.IsNull_flag) newEntity.custodian_number.Value = this.custodian_number.Value;
            if (!this.name.IsNull_flag) newEntity.name.Value = this.name.Value;
            if (!this.address1.IsNull_flag) newEntity.address1.Value = this.address1.Value;
            if (!this.address2.IsNull_flag) newEntity.address2.Value = this.address2.Value;
            if (!this.city.IsNull_flag) newEntity.city.Value = this.city.Value;
            if (!this.state.IsNull_flag) newEntity.state.Value = this.state.Value;
            if (!this.zip.IsNull_flag) newEntity.zip.Value = this.zip.Value;
            if (!this.country_code.IsNull_flag) newEntity.country_code.Value = this.country_code.Value;
            if (!this.attn.IsNull_flag) newEntity.attn.Value = this.attn.Value;
            if (!this.phone.IsNull_flag) newEntity.phone.Value = this.phone.Value;
            if (!this.fax.IsNull_flag) newEntity.fax.Value = this.fax.Value;
            if (!this.email.IsNull_flag) newEntity.email.Value = this.email.Value;
            if (!this.event_id.IsNull_flag) newEntity.event_id.Value = this.event_id.Value;
            if (!this.psafe.IsNull_flag) newEntity.psafe.Value = this.psafe.Value;
            if (!this.safe_keeping_account_number.IsNull_flag) newEntity.safe_keeping_account_number.Value = this.safe_keeping_account_number.Value;
            if (!this.depositary_name.IsNull_flag) newEntity.depositary_name.Value = this.depositary_name.Value;
            return newEntity;
        }
        /*^^^^^^^^^^^^^^^^^^^^^^^^^^^^^Hss Entity Framework Auto Generated Code^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^*/

        internal void Init_from_DRWIN_dvdCust(Models.Custodians.DividendCustodian dvdCust, Country cty, Event eve)
        {
            if (dvdCust == null || cty == null || eve == null) return;

            this.custodian_number.Init_from_attr(dvdCust.Custodian_Number);
            this.name.Init_from_attr(dvdCust.Custodian);
            this.address1.Init_from_attr(dvdCust.Address1);
            this.address2.Init_from_attr(dvdCust.Address2);
            this.city.Init_from_attr(dvdCust.City);
            this.state.Init_from_attr(dvdCust.State);
            this.zip.Init_from_attr(dvdCust.Zip);

            this.country_code.Value = cty.cntry_cd.Value;
            this.phone.Init_from_attr(dvdCust.Phone);
            this.fax.Init_from_attr(dvdCust.Fax);
            this.email.Init_from_attr(dvdCust.Email);

            this.event_id.Value = eve.event_id;
            this.psafe.Init_from_attr(dvdCust.PSAFE);
            this.safe_keeping_account_number.Init_from_attr(dvdCust.SafeKeeping_AccountNum);
            this.depositary_name.Init_from_attr(dvdCust.Depositary);
        }
    }
}
