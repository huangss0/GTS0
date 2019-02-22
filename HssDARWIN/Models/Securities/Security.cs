using System.Collections.Generic;
using System;
using System.Text;

namespace HssDARWIN.Models.Securities
{
    public class Security
    {
        /*-----------------------------Hss Entity Framework Auto Generated Code-------------------------------*/
        private static HssUtility.SQLserver.CmdTemplate DBcmd_TP = null;
        public static HssUtility.SQLserver.CmdTemplate Get_cmdTP()
        {
            if (Security.DBcmd_TP != null) return Security.DBcmd_TP;

            Security.DBcmd_TP = new HssUtility.SQLserver.CmdTemplate();
            Security.DBcmd_TP.tableName = "Securities";
            Security.DBcmd_TP.schema = "dbo";

            Security.DBcmd_TP.AddColumn("SecurityID");
            Security.DBcmd_TP.AddColumn("Name");
            Security.DBcmd_TP.AddColumn("CUSIP");/*Optional 3*/
            Security.DBcmd_TP.AddColumn("Country");
            Security.DBcmd_TP.AddColumn("TickerSymbol");/*Optional 5*/
            Security.DBcmd_TP.AddColumn("ISIN");/*Optional 6*/
            Security.DBcmd_TP.AddColumn("Sedol");/*Optional 7*/
            Security.DBcmd_TP.AddColumn("Depositary");/*Optional 8*/
            Security.DBcmd_TP.AddColumn("FirstFiler");/*Optional 9*/
            Security.DBcmd_TP.AddColumn("ClearingSystem");/*Optional 10*/
            Security.DBcmd_TP.AddColumn("SecurityType");/*Optional 11*/
            Security.DBcmd_TP.AddColumn("ModifiedDateTime");/*Optional 12*/
            Security.DBcmd_TP.AddColumn("LastModifiedBy");/*Optional 13*/
            Security.DBcmd_TP.AddColumn("EffectiveDate");
            Security.DBcmd_TP.AddColumn("ADR_RATIO_ADR");/*Optional 15*/
            Security.DBcmd_TP.AddColumn("ADR_RATIO_ORD");/*Optional 16*/
            Security.DBcmd_TP.AddColumn("DutchName");/*Optional 17*/

            return Security.DBcmd_TP;
        }

        public Security() { }
        public Security(int id) { this.pk_ID = id; }

        private int pk_ID = -1; //primary key
        public int SecurityID { get { return this.pk_ID; } }

        public readonly HssUtility.General.Attributes.String_attr Name = new HssUtility.General.Attributes.String_attr("");
        public readonly HssUtility.General.Attributes.String_attr CUSIP = new HssUtility.General.Attributes.String_attr();/*Optional 3*/
        public readonly HssUtility.General.Attributes.String_attr Country = new HssUtility.General.Attributes.String_attr("");
        public readonly HssUtility.General.Attributes.String_attr TickerSymbol = new HssUtility.General.Attributes.String_attr();/*Optional 5*/
        public readonly HssUtility.General.Attributes.String_attr ISIN = new HssUtility.General.Attributes.String_attr();/*Optional 6*/
        public readonly HssUtility.General.Attributes.String_attr Sedol = new HssUtility.General.Attributes.String_attr();/*Optional 7*/
        public readonly HssUtility.General.Attributes.String_attr Depositary = new HssUtility.General.Attributes.String_attr();/*Optional 8*/
        public readonly HssUtility.General.Attributes.String_attr FirstFiler = new HssUtility.General.Attributes.String_attr();/*Optional 9*/
        public readonly HssUtility.General.Attributes.String_attr ClearingSystem = new HssUtility.General.Attributes.String_attr();/*Optional 10*/
        public readonly HssUtility.General.Attributes.String_attr SecurityType = new HssUtility.General.Attributes.String_attr();/*Optional 11*/
        public readonly HssUtility.General.Attributes.DateTime_attr ModifiedDateTime = new HssUtility.General.Attributes.DateTime_attr();/*Optional 12*/
        public readonly HssUtility.General.Attributes.String_attr LastModifiedBy = new HssUtility.General.Attributes.String_attr();/*Optional 13*/
        public readonly HssUtility.General.Attributes.DateTime_attr EffectiveDate = new HssUtility.General.Attributes.DateTime_attr(Utility.MinDate);
        public readonly HssUtility.General.Attributes.Decimal_attr ADR_RATIO_ADR = new HssUtility.General.Attributes.Decimal_attr();/*Optional 15*/
        public readonly HssUtility.General.Attributes.Decimal_attr ADR_RATIO_ORD = new HssUtility.General.Attributes.Decimal_attr();/*Optional 16*/
        public readonly HssUtility.General.Attributes.String_attr DutchName = new HssUtility.General.Attributes.String_attr();/*Optional 17*/

        private List<HssUtility.General.Attributes.I_modelAttr> attrList = null;

        internal void Init_from_reader(HssUtility.SQLserver.DB_reader reader)
        {
            if (reader == null || reader.IsClosed) return;

            this.pk_ID = reader.GetInt("SecurityID");
            reader.GetString("Name", this.Name);
            reader.GetString("CUSIP", this.CUSIP);/*Optional 3*/
            reader.GetString("Country", this.Country);
            reader.GetString("TickerSymbol", this.TickerSymbol);/*Optional 5*/
            reader.GetString("ISIN", this.ISIN);/*Optional 6*/
            reader.GetString("Sedol", this.Sedol);/*Optional 7*/
            reader.GetString("Depositary", this.Depositary);/*Optional 8*/
            reader.GetString("FirstFiler", this.FirstFiler);/*Optional 9*/
            reader.GetString("ClearingSystem", this.ClearingSystem);/*Optional 10*/
            reader.GetString("SecurityType", this.SecurityType);/*Optional 11*/
            reader.GetDateTime("ModifiedDateTime", this.ModifiedDateTime);/*Optional 12*/
            reader.GetString("LastModifiedBy", this.LastModifiedBy);/*Optional 13*/
            reader.GetDateTime("EffectiveDate", this.EffectiveDate);
            reader.GetDecimal("ADR_RATIO_ADR", this.ADR_RATIO_ADR);/*Optional 15*/
            reader.GetDecimal("ADR_RATIO_ORD", this.ADR_RATIO_ORD);/*Optional 16*/
            reader.GetString("DutchName", this.DutchName);/*Optional 17*/

            this.SyncWithDB();
        }

        /// <summary>
        /// Initialize object from DB
        /// </summary>
        public bool Init_from_DB()
        {
            if (this.SecurityID < 0) return false;

            HssUtility.SQLserver.DB_select db_sel = new HssUtility.SQLserver.DB_select(Security.Get_cmdTP());
            db_sel.tableName = "Securities";
            HssUtility.SQLserver.SQL_relation rela = new HssUtility.SQLserver.SQL_relation("SecurityID", HssUtility.General.RelationalOperator.Equals, this.SecurityID);
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
            this.attrList.Add(this.Name);
            this.attrList.Add(this.CUSIP);/*Optional 3*/
            this.attrList.Add(this.Country);
            this.attrList.Add(this.TickerSymbol);/*Optional 5*/
            this.attrList.Add(this.ISIN);/*Optional 6*/
            this.attrList.Add(this.Sedol);/*Optional 7*/
            this.attrList.Add(this.Depositary);/*Optional 8*/
            this.attrList.Add(this.FirstFiler);/*Optional 9*/
            this.attrList.Add(this.ClearingSystem);/*Optional 10*/
            this.attrList.Add(this.SecurityType);/*Optional 11*/
            this.attrList.Add(this.ModifiedDateTime);/*Optional 12*/
            this.attrList.Add(this.LastModifiedBy);/*Optional 13*/
            this.attrList.Add(this.EffectiveDate);
            this.attrList.Add(this.ADR_RATIO_ADR);/*Optional 15*/
            this.attrList.Add(this.ADR_RATIO_ORD);/*Optional 16*/
            this.attrList.Add(this.DutchName);/*Optional 17*/
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
            HssUtility.SQLserver.DB_insert dbIns = new HssUtility.SQLserver.DB_insert(Security.Get_cmdTP());

            dbIns.AddValue("Name", this.Name.Value);
            dbIns.AddValue("CUSIP", this.CUSIP);/*Optional 3*/
            dbIns.AddValue("Country", this.Country.Value);
            dbIns.AddValue("TickerSymbol", this.TickerSymbol);/*Optional 5*/
            dbIns.AddValue("ISIN", this.ISIN);/*Optional 6*/
            dbIns.AddValue("Sedol", this.Sedol);/*Optional 7*/
            dbIns.AddValue("Depositary", this.Depositary);/*Optional 8*/
            dbIns.AddValue("FirstFiler", this.FirstFiler);/*Optional 9*/
            dbIns.AddValue("ClearingSystem", this.ClearingSystem);/*Optional 10*/
            dbIns.AddValue("SecurityType", this.SecurityType);/*Optional 11*/
            dbIns.AddValue("ModifiedDateTime", this.ModifiedDateTime);/*Optional 12*/
            dbIns.AddValue("LastModifiedBy", this.LastModifiedBy);/*Optional 13*/
            dbIns.AddValue("EffectiveDate", this.EffectiveDate.Value);
            dbIns.AddValue("ADR_RATIO_ADR", this.ADR_RATIO_ADR);/*Optional 15*/
            dbIns.AddValue("ADR_RATIO_ORD", this.ADR_RATIO_ORD);/*Optional 16*/
            dbIns.AddValue("DutchName", this.DutchName);/*Optional 17*/

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

            HssUtility.SQLserver.DB_update upd = new HssUtility.SQLserver.DB_update(Security.Get_cmdTP());
            if (this.Name.ValueChanged) upd.AddValue("Name", this.Name);
            if (this.CUSIP.ValueChanged) upd.AddValue("CUSIP", this.CUSIP);
            if (this.Country.ValueChanged) upd.AddValue("Country", this.Country);
            if (this.TickerSymbol.ValueChanged) upd.AddValue("TickerSymbol", this.TickerSymbol);
            if (this.ISIN.ValueChanged) upd.AddValue("ISIN", this.ISIN);
            if (this.Sedol.ValueChanged) upd.AddValue("Sedol", this.Sedol);
            if (this.Depositary.ValueChanged) upd.AddValue("Depositary", this.Depositary);
            if (this.FirstFiler.ValueChanged) upd.AddValue("FirstFiler", this.FirstFiler);
            if (this.ClearingSystem.ValueChanged) upd.AddValue("ClearingSystem", this.ClearingSystem);
            if (this.SecurityType.ValueChanged) upd.AddValue("SecurityType", this.SecurityType);
            if (this.ModifiedDateTime.ValueChanged) upd.AddValue("ModifiedDateTime", this.ModifiedDateTime);
            if (this.LastModifiedBy.ValueChanged) upd.AddValue("LastModifiedBy", this.LastModifiedBy);
            if (this.EffectiveDate.ValueChanged) upd.AddValue("EffectiveDate", this.EffectiveDate);
            if (this.ADR_RATIO_ADR.ValueChanged) upd.AddValue("ADR_RATIO_ADR", this.ADR_RATIO_ADR);
            if (this.ADR_RATIO_ORD.ValueChanged) upd.AddValue("ADR_RATIO_ORD", this.ADR_RATIO_ORD);
            if (this.DutchName.ValueChanged) upd.AddValue("DutchName", this.DutchName);

            HssUtility.SQLserver.SQL_relation rela = new HssUtility.SQLserver.SQL_relation("SecurityID", HssUtility.General.RelationalOperator.Equals, this.pk_ID);
            upd.SetCondition(rela);

            return upd;
        }

        public HssUtility.Forms.Attribute.Models_viewForm GetEditForm()
        {
            HssUtility.Forms.Attribute.Models_viewForm mvf = new HssUtility.Forms.Attribute.Models_viewForm();
            mvf.Text = "Security";
            mvf.Set_pk_label("SecurityID:" + this.SecurityID);
            if (this.SecurityID < 1) mvf.CloseOnSave_flag = true;

            mvf.Add_Control(new HssUtility.Forms.Attribute.StrAttr_UserControl("Name", this.Name));
            mvf.Add_Control(new HssUtility.Forms.Attribute.StrAttr_UserControl("CUSIP", this.CUSIP));/*Optional 3*/
            mvf.Add_Control(new HssUtility.Forms.Attribute.StrAttr_UserControl("Country", this.Country));
            mvf.Add_Control(new HssUtility.Forms.Attribute.StrAttr_UserControl("TickerSymbol", this.TickerSymbol));/*Optional 5*/
            mvf.Add_Control(new HssUtility.Forms.Attribute.StrAttr_UserControl("ISIN", this.ISIN));/*Optional 6*/
            mvf.Add_Control(new HssUtility.Forms.Attribute.StrAttr_UserControl("Sedol", this.Sedol));/*Optional 7*/
            mvf.Add_Control(new HssUtility.Forms.Attribute.StrAttr_UserControl("Depositary", this.Depositary));/*Optional 8*/
            mvf.Add_Control(new HssUtility.Forms.Attribute.StrAttr_UserControl("FirstFiler", this.FirstFiler));/*Optional 9*/
            mvf.Add_Control(new HssUtility.Forms.Attribute.StrAttr_UserControl("ClearingSystem", this.ClearingSystem));/*Optional 10*/
            mvf.Add_Control(new HssUtility.Forms.Attribute.StrAttr_UserControl("SecurityType", this.SecurityType));/*Optional 11*/
            mvf.Add_Control(new HssUtility.Forms.Attribute.DateTimeAttr_UserControl("ModifiedDateTime", this.ModifiedDateTime));/*Optional 12*/
            mvf.Add_Control(new HssUtility.Forms.Attribute.StrAttr_UserControl("LastModifiedBy", this.LastModifiedBy));/*Optional 13*/
            mvf.Add_Control(new HssUtility.Forms.Attribute.DateTimeAttr_UserControl("EffectiveDate", this.EffectiveDate));
            mvf.Add_Control(new HssUtility.Forms.Attribute.StrAttr_UserControl("ADR_RATIO_ADR", this.ADR_RATIO_ADR));/*Optional 15*/
            mvf.Add_Control(new HssUtility.Forms.Attribute.StrAttr_UserControl("ADR_RATIO_ORD", this.ADR_RATIO_ORD));/*Optional 16*/
            mvf.Add_Control(new HssUtility.Forms.Attribute.StrAttr_UserControl("DutchName", this.DutchName));/*Optional 17*/
            mvf.SaveModel_func = delegate { return this.Save_to_DB(); };
            return mvf;
        }

        public bool Save_to_DB()
        {
            bool dataSaved_flag = false;
            if (this.pk_ID > 0) dataSaved_flag = this.Update_to_DB();
            else dataSaved_flag = this.Insert_to_DB();            
            return dataSaved_flag;
        }
        /*^^^^^^^^^^^^^^^^^^^^^^^^^^^^^Hss Entity Framework Auto Generated Code^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^*/

        public bool Sponsored_flag
        {
            get
            {
                if (this.Depositary.IsValueEmpty) return true;
                return this.Depositary.Value.Equals(Depositaries.Depositary.Unsponsored, StringComparison.OrdinalIgnoreCase);
            }
        }

        public string GetInfo_str()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(this.CUSIP.Value).Append(',');
            sb.Append(this.Depositary.Value).Append(',');
            sb.Append(this.FirstFiler.Value).Append(',');
            sb.Append(this.ADR_RATIO_ADR.Value).Append(':').Append(this.ADR_RATIO_ORD.Value);
            return sb.ToString();
        }
    }
}
