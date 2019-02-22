using System;
using System.Collections.Generic;

using HssUtility.General.Attributes;
using HssUtility.SQLserver;
using HssDARWIN.Models.Dividends;

namespace HssDARWIN.Models.ESP2.Events
{
    public class Event
    {
        /*-----------------------------Hss Entity Framework Auto Generated Code-------------------------------*/
        private static CmdTemplate DBcmd_TP = null;
        public static CmdTemplate Get_cmdTP()
        {
            if (Event.DBcmd_TP != null) return Event.DBcmd_TP;

            Event.DBcmd_TP = new CmdTemplate();
            Event.DBcmd_TP.tableName = "Event";

            Event.DBcmd_TP.AddColumn("event_id");
            Event.DBcmd_TP.AddColumn("dividend_index");
            Event.DBcmd_TP.AddColumn("security_id");
            Event.DBcmd_TP.AddColumn("record_date_adr");
            Event.DBcmd_TP.AddColumn("pay_date_adr");
            Event.DBcmd_TP.AddColumn("record_date_ord");
            Event.DBcmd_TP.AddColumn("pay_date_ord");
            Event.DBcmd_TP.AddColumn("deadline_at_source");
            Event.DBcmd_TP.AddColumn("deadline_quick_refund");
            Event.DBcmd_TP.AddColumn("deadline_long_form");
            Event.DBcmd_TP.AddColumn("depositary_info_id");
            Event.DBcmd_TP.AddColumn("market_statute_of_limitations");
            Event.DBcmd_TP.AddColumn("enabled");
            Event.DBcmd_TP.AddColumn("notes");
            Event.DBcmd_TP.AddColumn("last_modified_by");
            Event.DBcmd_TP.AddColumn("last_modified_at");
            Event.DBcmd_TP.AddColumn("is_active");
            Event.DBcmd_TP.AddColumn("dividend");
            Event.DBcmd_TP.AddColumn("is_exception");
            Event.DBcmd_TP.AddColumn("esp_model_id");

            return Event.DBcmd_TP;
        }

        private int pk_ID = -1;//primary key
        public int event_id { get { return this.pk_ID; } }

        public readonly Int_attr dividend_index = new Int_attr(-1);
        public readonly Int_attr security_id = new Int_attr(-1);
        public readonly DateTime_attr record_date_adr = new DateTime_attr(Utility.MinDate);
        public readonly DateTime_attr pay_date_adr = new DateTime_attr(Utility.MinDate);
        public readonly DateTime_attr record_date_ord = new DateTime_attr(Utility.MinDate);
        public readonly DateTime_attr pay_date_ord = new DateTime_attr(Utility.MinDate);
        public readonly DateTime_attr deadline_at_source = new DateTime_attr(Utility.MinDate);
        public readonly DateTime_attr deadline_quick_refund = new DateTime_attr(Utility.MinDate);
        public readonly DateTime_attr deadline_long_form = new DateTime_attr(Utility.MinDate);
        public readonly Int_attr depositary_info_id = new Int_attr(-1);
        public readonly DateTime_attr market_statute_of_limitations = new DateTime_attr(Utility.MinDate);
        public readonly Bool_attr enabled = new Bool_attr(true);
        public readonly String_attr notes = new String_attr("");
        public readonly String_attr last_modified_by = new String_attr(Utility.CurrentUser);
        public readonly DateTime_attr last_modified_at = new DateTime_attr(DateTime.Now);
        public readonly Bool_attr is_active = new Bool_attr(true);
        public readonly String_attr dividend = new String_attr("");
        public readonly Bool_attr is_exception = new Bool_attr(false);
        public readonly Int_attr esp_model_id = new Int_attr(1);

        private List<I_modelAttr> attrList = null;

        public Event() { }
        public Event(int id) { this.pk_ID = id; }

        internal void Init_from_reader(DB_reader reader)
        {
            if (reader == null || reader.IsClosed) return;

            this.pk_ID = reader.GetInt("event_id");
            this.dividend_index.Value = reader.GetInt("dividend_index");
            this.security_id.Value = reader.GetInt("security_id");
            this.record_date_adr.Value = reader.GetDateTime("record_date_adr");
            this.pay_date_adr.Value = reader.GetDateTime("pay_date_adr");
            this.record_date_ord.Value = reader.GetDateTime("record_date_ord");
            this.pay_date_ord.Value = reader.GetDateTime("pay_date_ord");
            this.deadline_at_source.Value = reader.GetDateTime("deadline_at_source");
            this.deadline_quick_refund.Value = reader.GetDateTime("deadline_quick_refund");
            this.deadline_long_form.Value = reader.GetDateTime("deadline_long_form");
            this.depositary_info_id.Value = reader.GetInt("depositary_info_id");
            this.market_statute_of_limitations.Value = reader.GetDateTime("market_statute_of_limitations");
            this.enabled.Value = reader.GetBool("enabled");
            this.notes.Value = reader.GetString("notes");
            this.last_modified_by.Value = reader.GetString("last_modified_by");
            this.last_modified_at.Value = reader.GetDateTime("last_modified_at");
            this.is_active.Value = reader.GetBool("is_active");
            this.dividend.Value = reader.GetString("dividend");
            this.is_exception.Value = reader.GetBool("is_exception");
            this.esp_model_id.Value = reader.GetInt("esp_model_id");

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
            DB_insert dbIns = new DB_insert(Event.Get_cmdTP());
            dbIns.AddValue("dividend_index", this.dividend_index.Value);
            dbIns.AddValue("security_id", this.security_id.Value);
            dbIns.AddValue("record_date_adr", this.record_date_adr.Value);
            dbIns.AddValue("pay_date_adr", this.pay_date_adr.Value);
            dbIns.AddValue("record_date_ord", this.record_date_ord.Value);
            dbIns.AddValue("pay_date_ord", this.pay_date_ord.Value);
            dbIns.AddValue("deadline_at_source", this.deadline_at_source.Value);
            dbIns.AddValue("deadline_quick_refund", this.deadline_quick_refund.Value);
            dbIns.AddValue("deadline_long_form", this.deadline_long_form.Value);
            dbIns.AddValue("depositary_info_id", this.depositary_info_id.Value);
            dbIns.AddValue("market_statute_of_limitations", this.market_statute_of_limitations.Value);
            dbIns.AddValue("enabled", this.enabled.Value);
            dbIns.AddValue("notes", this.notes.Value);
            dbIns.AddValue("last_modified_by", this.last_modified_by.Value);
            dbIns.AddValue("last_modified_at", this.last_modified_at.Value);
            dbIns.AddValue("is_active", this.is_active.Value);
            dbIns.AddValue("dividend", this.dividend.Value);
            dbIns.AddValue("is_exception", this.is_exception.Value);
            dbIns.AddValue("esp_model_id", this.esp_model_id.Value);

            return dbIns;
        }

        internal void SyncWithDB()
        {
            if (this.attrList == null)
            {
                this.attrList = new List<I_modelAttr>();
                this.attrList.Add(this.dividend_index);
                this.attrList.Add(this.security_id);
                this.attrList.Add(this.record_date_adr);
                this.attrList.Add(this.pay_date_adr);
                this.attrList.Add(this.record_date_ord);
                this.attrList.Add(this.pay_date_ord);
                this.attrList.Add(this.deadline_at_source);
                this.attrList.Add(this.deadline_quick_refund);
                this.attrList.Add(this.deadline_long_form);
                this.attrList.Add(this.depositary_info_id);
                this.attrList.Add(this.market_statute_of_limitations);
                this.attrList.Add(this.enabled);
                this.attrList.Add(this.notes);
                this.attrList.Add(this.last_modified_by);
                this.attrList.Add(this.is_active);
                this.attrList.Add(this.dividend);
                this.attrList.Add(this.is_exception);
                this.attrList.Add(this.esp_model_id);
            }

            foreach (I_modelAttr ma in this.attrList) ma.SyncWithDB();
        }
        /*^^^^^^^^^^^^^^^^^^^^^^^^^^^^^Hss Entity Framework Auto Generated Code^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^*/

        public void Init_from_Dividend(Dividend dvd)
        {
            if (dvd == null) return;

            this.dividend_index.Value = dvd.DividendIndex;
            this.record_date_adr.Value = dvd.RecordDate_ADR.Value;
            this.pay_date_adr.Value = dvd.PayDate_ADR.Value;
            this.record_date_ord.Value = dvd.RecordDate_ORD.Value;
            this.pay_date_ord.Value = dvd.PayDate_ORD.Value;
            this.dividend.Value = dvd.ToXML_ESP2();

            /*************************Mock up values for Igor***************************************/
            DateTime dt_now = DateTime.Now;
            Random rd = new Random();
            this.deadline_quick_refund.Value = dt_now.AddDays(rd.Next(60));
            this.deadline_long_form.Value = dt_now.AddDays(rd.Next(60));
            this.deadline_at_source.Value = dt_now.AddDays(rd.Next(60));
            /*^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^*/

            this.esp_model_id.Value = 1;//hard code for now
        }
    }
}
