using System;
using System.Collections.Generic;
using HssDARWIN.Models.Countries;

namespace HssDARWIN.Models.ESP2.Events
{
    public class EventContactInfo
    {
        /*-----------------------------Hss Entity Framework Auto Generated Code-------------------------------*/
        private static HssUtility.SQLserver.CmdTemplate DBcmd_TP = null;
        public static HssUtility.SQLserver.CmdTemplate Get_cmdTP()
        {
            if (EventContactInfo.DBcmd_TP != null) return EventContactInfo.DBcmd_TP;

            EventContactInfo.DBcmd_TP = new HssUtility.SQLserver.CmdTemplate();
            EventContactInfo.DBcmd_TP.tableName = "EventContactInfo";
            EventContactInfo.DBcmd_TP.schema = "dbo";

            EventContactInfo.DBcmd_TP.AddColumn("event_contact_info_id");
            EventContactInfo.DBcmd_TP.AddColumn("event_id");
            EventContactInfo.DBcmd_TP.AddColumn("contact_company_name");/*Optional 3*/
            EventContactInfo.DBcmd_TP.AddColumn("contact_address1");/*Optional 4*/
            EventContactInfo.DBcmd_TP.AddColumn("contact_address2");/*Optional 5*/
            EventContactInfo.DBcmd_TP.AddColumn("contact_country_code");/*Optional 6*/
            EventContactInfo.DBcmd_TP.AddColumn("contact_attn");/*Optional 7*/
            EventContactInfo.DBcmd_TP.AddColumn("contact_phone");/*Optional 8*/
            EventContactInfo.DBcmd_TP.AddColumn("contact_fax");/*Optional 9*/
            EventContactInfo.DBcmd_TP.AddColumn("contact_email");/*Optional 10*/
            EventContactInfo.DBcmd_TP.AddColumn("contact_city");/*Optional 11*/
            EventContactInfo.DBcmd_TP.AddColumn("contact_state");/*Optional 12*/
            EventContactInfo.DBcmd_TP.AddColumn("contact_zip");/*Optional 13*/

            return EventContactInfo.DBcmd_TP;
        }

        public EventContactInfo() { }
        public EventContactInfo(int id) { this.pk_ID = id; }

        private int pk_ID = -1; //primary key
        public int event_contact_info_id { get { return this.pk_ID; } }

        public readonly HssUtility.General.Attributes.Int_attr event_id = new HssUtility.General.Attributes.Int_attr();
        public readonly HssUtility.General.Attributes.String_attr contact_company_name = new HssUtility.General.Attributes.String_attr();/*Optional 3*/
        public readonly HssUtility.General.Attributes.String_attr contact_address1 = new HssUtility.General.Attributes.String_attr();/*Optional 4*/
        public readonly HssUtility.General.Attributes.String_attr contact_address2 = new HssUtility.General.Attributes.String_attr();/*Optional 5*/
        public readonly HssUtility.General.Attributes.String_attr contact_country_code = new HssUtility.General.Attributes.String_attr();/*Optional 6*/
        public readonly HssUtility.General.Attributes.String_attr contact_attn = new HssUtility.General.Attributes.String_attr();/*Optional 7*/
        public readonly HssUtility.General.Attributes.String_attr contact_phone = new HssUtility.General.Attributes.String_attr();/*Optional 8*/
        public readonly HssUtility.General.Attributes.String_attr contact_fax = new HssUtility.General.Attributes.String_attr();/*Optional 9*/
        public readonly HssUtility.General.Attributes.String_attr contact_email = new HssUtility.General.Attributes.String_attr();/*Optional 10*/
        public readonly HssUtility.General.Attributes.String_attr contact_city = new HssUtility.General.Attributes.String_attr();/*Optional 11*/
        public readonly HssUtility.General.Attributes.String_attr contact_state = new HssUtility.General.Attributes.String_attr();/*Optional 12*/
        public readonly HssUtility.General.Attributes.String_attr contact_zip = new HssUtility.General.Attributes.String_attr();/*Optional 13*/

        private List<HssUtility.General.Attributes.I_modelAttr> attrList = null;

        internal void Init_from_reader(HssUtility.SQLserver.DB_reader reader)
        {
            if (reader == null || reader.IsClosed) return;

            this.pk_ID = reader.GetInt("event_contact_info_id");
            reader.GetInt("event_id", this.event_id);
            reader.GetString("contact_company_name", this.contact_company_name);/*Optional 3*/
            reader.GetString("contact_address1", this.contact_address1);/*Optional 4*/
            reader.GetString("contact_address2", this.contact_address2);/*Optional 5*/
            reader.GetString("contact_country_code", this.contact_country_code);/*Optional 6*/
            reader.GetString("contact_attn", this.contact_attn);/*Optional 7*/
            reader.GetString("contact_phone", this.contact_phone);/*Optional 8*/
            reader.GetString("contact_fax", this.contact_fax);/*Optional 9*/
            reader.GetString("contact_email", this.contact_email);/*Optional 10*/
            reader.GetString("contact_city", this.contact_city);/*Optional 11*/
            reader.GetString("contact_state", this.contact_state);/*Optional 12*/
            reader.GetString("contact_zip", this.contact_zip);/*Optional 13*/

            this.SyncWithDB();
        }

        /// <summary>
        /// Initialize object from DB
        /// </summary>
        public bool Init_from_DB()
        {
            if (this.event_contact_info_id < 0) return false;

            HssUtility.SQLserver.DB_select db_sel = new HssUtility.SQLserver.DB_select(EventContactInfo.Get_cmdTP());
            db_sel.tableName = "EventContactInfo";
            HssUtility.SQLserver.SQL_relation rela = new HssUtility.SQLserver.SQL_relation("event_contact_info_id", HssUtility.General.RelationalOperator.Equals, this.event_contact_info_id);
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
            this.attrList.Add(this.event_id);
            this.attrList.Add(this.contact_company_name);/*Optional 3*/
            this.attrList.Add(this.contact_address1);/*Optional 4*/
            this.attrList.Add(this.contact_address2);/*Optional 5*/
            this.attrList.Add(this.contact_country_code);/*Optional 6*/
            this.attrList.Add(this.contact_attn);/*Optional 7*/
            this.attrList.Add(this.contact_phone);/*Optional 8*/
            this.attrList.Add(this.contact_fax);/*Optional 9*/
            this.attrList.Add(this.contact_email);/*Optional 10*/
            this.attrList.Add(this.contact_city);/*Optional 11*/
            this.attrList.Add(this.contact_state);/*Optional 12*/
            this.attrList.Add(this.contact_zip);/*Optional 13*/
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
            HssUtility.SQLserver.DB_insert dbIns = new HssUtility.SQLserver.DB_insert(EventContactInfo.Get_cmdTP());

            dbIns.AddValue("event_id", this.event_id.Value);
            dbIns.AddValue("contact_company_name", this.contact_company_name);/*Optional 3*/
            dbIns.AddValue("contact_address1", this.contact_address1);/*Optional 4*/
            dbIns.AddValue("contact_address2", this.contact_address2);/*Optional 5*/
            dbIns.AddValue("contact_country_code", this.contact_country_code);/*Optional 6*/
            dbIns.AddValue("contact_attn", this.contact_attn);/*Optional 7*/
            dbIns.AddValue("contact_phone", this.contact_phone);/*Optional 8*/
            dbIns.AddValue("contact_fax", this.contact_fax);/*Optional 9*/
            dbIns.AddValue("contact_email", this.contact_email);/*Optional 10*/
            dbIns.AddValue("contact_city", this.contact_city);/*Optional 11*/
            dbIns.AddValue("contact_state", this.contact_state);/*Optional 12*/
            dbIns.AddValue("contact_zip", this.contact_zip);/*Optional 13*/

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

            HssUtility.SQLserver.DB_update upd = new HssUtility.SQLserver.DB_update(EventContactInfo.Get_cmdTP());
            if (this.event_id.ValueChanged) upd.AddValue("event_id", this.event_id);
            if (this.contact_company_name.ValueChanged) upd.AddValue("contact_company_name", this.contact_company_name);
            if (this.contact_address1.ValueChanged) upd.AddValue("contact_address1", this.contact_address1);
            if (this.contact_address2.ValueChanged) upd.AddValue("contact_address2", this.contact_address2);
            if (this.contact_country_code.ValueChanged) upd.AddValue("contact_country_code", this.contact_country_code);
            if (this.contact_attn.ValueChanged) upd.AddValue("contact_attn", this.contact_attn);
            if (this.contact_phone.ValueChanged) upd.AddValue("contact_phone", this.contact_phone);
            if (this.contact_fax.ValueChanged) upd.AddValue("contact_fax", this.contact_fax);
            if (this.contact_email.ValueChanged) upd.AddValue("contact_email", this.contact_email);
            if (this.contact_city.ValueChanged) upd.AddValue("contact_city", this.contact_city);
            if (this.contact_state.ValueChanged) upd.AddValue("contact_state", this.contact_state);
            if (this.contact_zip.ValueChanged) upd.AddValue("contact_zip", this.contact_zip);

            HssUtility.SQLserver.SQL_relation rela = new HssUtility.SQLserver.SQL_relation("event_contact_info_id", HssUtility.General.RelationalOperator.Equals, this.pk_ID);
            upd.SetCondition(rela);

            return upd;
        }

        public EventContactInfo GetCopy()
        {
            EventContactInfo newEntity = new EventContactInfo();
            if (!this.event_id.IsNull_flag) newEntity.event_id.Value = this.event_id.Value;
            if (!this.contact_company_name.IsNull_flag) newEntity.contact_company_name.Value = this.contact_company_name.Value;
            if (!this.contact_address1.IsNull_flag) newEntity.contact_address1.Value = this.contact_address1.Value;
            if (!this.contact_address2.IsNull_flag) newEntity.contact_address2.Value = this.contact_address2.Value;
            if (!this.contact_country_code.IsNull_flag) newEntity.contact_country_code.Value = this.contact_country_code.Value;
            if (!this.contact_attn.IsNull_flag) newEntity.contact_attn.Value = this.contact_attn.Value;
            if (!this.contact_phone.IsNull_flag) newEntity.contact_phone.Value = this.contact_phone.Value;
            if (!this.contact_fax.IsNull_flag) newEntity.contact_fax.Value = this.contact_fax.Value;
            if (!this.contact_email.IsNull_flag) newEntity.contact_email.Value = this.contact_email.Value;
            if (!this.contact_city.IsNull_flag) newEntity.contact_city.Value = this.contact_city.Value;
            if (!this.contact_state.IsNull_flag) newEntity.contact_state.Value = this.contact_state.Value;
            if (!this.contact_zip.IsNull_flag) newEntity.contact_zip.Value = this.contact_zip.Value;
            return newEntity;
        }
        /*^^^^^^^^^^^^^^^^^^^^^^^^^^^^^Hss Entity Framework Auto Generated Code^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^*/

        internal void Init_from_DRWIN_dvdCust(Models.Custodians.DividendCustodian dvdCust, Country cty, Event eve)
        {
            if (dvdCust == null || cty == null || eve == null) return;

            this.event_id.Value = eve.event_id;
            this.contact_company_name.Init_from_attr(dvdCust.Custodian);
            this.contact_address1.Init_from_attr(dvdCust.Address1);
            this.contact_address2.Init_from_attr(dvdCust.Address2);
            this.contact_country_code.Value = cty.cntry_cd.Value;
            this.contact_phone.Init_from_attr(dvdCust.Phone);
            this.contact_email.Init_from_attr(dvdCust.Email);
            this.contact_fax.Init_from_attr(dvdCust.Fax);
            this.contact_city.Init_from_attr(dvdCust.City);
            this.contact_state.Init_from_attr(dvdCust.State);
            this.contact_zip.Init_from_attr(dvdCust.Zip);
        } 
    }
}
