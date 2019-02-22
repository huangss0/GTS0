using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HssDARWIN.Models.RSH
{
    public class RSH_log
    {
        /*-----------------------------Hss Entity Framework Auto Generated Code-------------------------------*/
        private static HssUtility.SQLserver.CmdTemplate DBcmd_TP = null;
        public static HssUtility.SQLserver.CmdTemplate Get_cmdTP()
        {
            if (RSH_log.DBcmd_TP != null) return RSH_log.DBcmd_TP;

            RSH_log.DBcmd_TP = new HssUtility.SQLserver.CmdTemplate();
            RSH_log.DBcmd_TP.tableName = "RSHLog";
            RSH_log.DBcmd_TP.schema = "dbo";

            RSH_log.DBcmd_TP.AddColumn("RSHID");
            RSH_log.DBcmd_TP.AddColumn("DividendIndex");
            RSH_log.DBcmd_TP.AddColumn("DTC");
            RSH_log.DBcmd_TP.AddColumn("Depositary");
            RSH_log.DBcmd_TP.AddColumn("AccountNumber");/*Optional 5*/
            RSH_log.DBcmd_TP.AddColumn("TIN");/*Optional 6*/
            RSH_log.DBcmd_TP.AddColumn("Shares");/*Optional 7*/
            RSH_log.DBcmd_TP.AddColumn("RegisteredName");/*Optional 8*/
            RSH_log.DBcmd_TP.AddColumn("Address");/*Optional 9*/
            RSH_log.DBcmd_TP.AddColumn("CountryCode");/*Optional 10*/
            RSH_log.DBcmd_TP.AddColumn("TaxStatus");/*Optional 11*/
            RSH_log.DBcmd_TP.AddColumn("ForeignTaxWH");/*Optional 12*/
            RSH_log.DBcmd_TP.AddColumn("CUSIP");/*Optional 13*/
            RSH_log.DBcmd_TP.AddColumn("IssueNumber");/*Optional 14*/
            RSH_log.DBcmd_TP.AddColumn("CitizenshipCode");/*Optional 15*/
            RSH_log.DBcmd_TP.AddColumn("OwnerCode");/*Optional 16*/
            RSH_log.DBcmd_TP.AddColumn("ZipCode");/*Optional 17*/
            RSH_log.DBcmd_TP.AddColumn("State");/*Optional 18*/
            RSH_log.DBcmd_TP.AddColumn("CityName");/*Optional 19*/
            RSH_log.DBcmd_TP.AddColumn("Agent");/*Optional 20*/
            RSH_log.DBcmd_TP.AddColumn("LOC");/*Optional 21*/
            RSH_log.DBcmd_TP.AddColumn("RecordDate");/*Optional 22*/
            RSH_log.DBcmd_TP.AddColumn("Comp_Num");/*Optional 23*/
            RSH_log.DBcmd_TP.AddColumn("Class_CD");/*Optional 24*/
            RSH_log.DBcmd_TP.AddColumn("Tax_CD");/*Optional 25*/
            RSH_log.DBcmd_TP.AddColumn("Shares2");/*Optional 26*/
            RSH_log.DBcmd_TP.AddColumn("GlobeTax");/*Optional 27*/
            RSH_log.DBcmd_TP.AddColumn("Dividend_Intention");/*Optional 28*/
            RSH_log.DBcmd_TP.AddColumn("Holder_On_Date");/*Optional 29*/
            RSH_log.DBcmd_TP.AddColumn("Tin_Status_1");/*Optional 30*/
            RSH_log.DBcmd_TP.AddColumn("Tin_Status_Source");/*Optional 31*/
            RSH_log.DBcmd_TP.AddColumn("Tin_Exp_Date_1");/*Optional 32*/
            RSH_log.DBcmd_TP.AddColumn("Tin_B_Count");/*Optional 33*/
            RSH_log.DBcmd_TP.AddColumn("Holder_Type_Code");/*Optional 34*/
            RSH_log.DBcmd_TP.AddColumn("Last_Contact_Date");/*Optional 35*/
            RSH_log.DBcmd_TP.AddColumn("Last_Contact_Type");/*Optional 36*/
            RSH_log.DBcmd_TP.AddColumn("GlobeTax_Findings");/*Optional 37*/

            return RSH_log.DBcmd_TP;
        }

        public RSH_log() { }
        public RSH_log(int id) { this.pk_ID = id; }

        private int pk_ID = -1; //primary key
        public int RSHID { get { return this.pk_ID; } }

        public readonly HssUtility.General.Attributes.Int_attr DividendIndex = new HssUtility.General.Attributes.Int_attr();
        public readonly HssUtility.General.Attributes.Int_attr DTC = new HssUtility.General.Attributes.Int_attr();
        public readonly HssUtility.General.Attributes.String_attr Depositary = new HssUtility.General.Attributes.String_attr();
        public readonly HssUtility.General.Attributes.String_attr AccountNumber = new HssUtility.General.Attributes.String_attr();/*Optional 5*/
        public readonly HssUtility.General.Attributes.String_attr TIN = new HssUtility.General.Attributes.String_attr();/*Optional 6*/
        public readonly HssUtility.General.Attributes.Decimal_attr Shares = new HssUtility.General.Attributes.Decimal_attr(0);/*Optional 7*/
        public readonly HssUtility.General.Attributes.String_attr RegisteredName = new HssUtility.General.Attributes.String_attr();/*Optional 8*/
        public readonly HssUtility.General.Attributes.String_attr Address = new HssUtility.General.Attributes.String_attr();/*Optional 9*/
        public readonly HssUtility.General.Attributes.String_attr CountryCode = new HssUtility.General.Attributes.String_attr();/*Optional 10*/
        public readonly HssUtility.General.Attributes.String_attr TaxStatus = new HssUtility.General.Attributes.String_attr();/*Optional 11*/
        public readonly HssUtility.General.Attributes.Decimal_attr ForeignTaxWH = new HssUtility.General.Attributes.Decimal_attr();/*Optional 12*/
        public readonly HssUtility.General.Attributes.String_attr CUSIP = new HssUtility.General.Attributes.String_attr();/*Optional 13*/
        public readonly HssUtility.General.Attributes.String_attr IssueNumber = new HssUtility.General.Attributes.String_attr();/*Optional 14*/
        public readonly HssUtility.General.Attributes.String_attr CitizenshipCode = new HssUtility.General.Attributes.String_attr();/*Optional 15*/
        public readonly HssUtility.General.Attributes.String_attr OwnerCode = new HssUtility.General.Attributes.String_attr();/*Optional 16*/
        public readonly HssUtility.General.Attributes.String_attr ZipCode = new HssUtility.General.Attributes.String_attr();/*Optional 17*/
        public readonly HssUtility.General.Attributes.String_attr State = new HssUtility.General.Attributes.String_attr();/*Optional 18*/
        public readonly HssUtility.General.Attributes.String_attr CityName = new HssUtility.General.Attributes.String_attr();/*Optional 19*/
        public readonly HssUtility.General.Attributes.String_attr Agent = new HssUtility.General.Attributes.String_attr();/*Optional 20*/
        public readonly HssUtility.General.Attributes.Int_attr LOC = new HssUtility.General.Attributes.Int_attr();/*Optional 21*/
        public readonly HssUtility.General.Attributes.DateTime_attr RecordDate = new HssUtility.General.Attributes.DateTime_attr();/*Optional 22*/
        public readonly HssUtility.General.Attributes.String_attr Comp_Num = new HssUtility.General.Attributes.String_attr();/*Optional 23*/
        public readonly HssUtility.General.Attributes.String_attr Class_CD = new HssUtility.General.Attributes.String_attr();/*Optional 24*/
        public readonly HssUtility.General.Attributes.String_attr Tax_CD = new HssUtility.General.Attributes.String_attr();/*Optional 25*/
        public readonly HssUtility.General.Attributes.Decimal_attr Shares2 = new HssUtility.General.Attributes.Decimal_attr();/*Optional 26*/
        public readonly HssUtility.General.Attributes.String_attr GlobeTax = new HssUtility.General.Attributes.String_attr();/*Optional 27*/
        public readonly HssUtility.General.Attributes.String_attr Dividend_Intention = new HssUtility.General.Attributes.String_attr();/*Optional 28*/
        public readonly HssUtility.General.Attributes.DateTime_attr Holder_On_Date = new HssUtility.General.Attributes.DateTime_attr();/*Optional 29*/
        public readonly HssUtility.General.Attributes.String_attr Tin_Status_1 = new HssUtility.General.Attributes.String_attr();/*Optional 30*/
        public readonly HssUtility.General.Attributes.String_attr Tin_Status_Source = new HssUtility.General.Attributes.String_attr();/*Optional 31*/
        public readonly HssUtility.General.Attributes.DateTime_attr Tin_Exp_Date_1 = new HssUtility.General.Attributes.DateTime_attr();/*Optional 32*/
        public readonly HssUtility.General.Attributes.Int_attr Tin_B_Count = new HssUtility.General.Attributes.Int_attr();/*Optional 33*/
        public readonly HssUtility.General.Attributes.String_attr Holder_Type_Code = new HssUtility.General.Attributes.String_attr();/*Optional 34*/
        public readonly HssUtility.General.Attributes.DateTime_attr Last_Contact_Date = new HssUtility.General.Attributes.DateTime_attr();/*Optional 35*/
        public readonly HssUtility.General.Attributes.String_attr Last_Contact_Type = new HssUtility.General.Attributes.String_attr();/*Optional 36*/
        public readonly HssUtility.General.Attributes.String_attr GlobeTax_Findings = new HssUtility.General.Attributes.String_attr();/*Optional 37*/

        private Dictionary<string, HssUtility.General.Attributes.I_modelAttr> attr_dic = null;

        internal void Init_from_reader(HssUtility.SQLserver.DB_reader reader)
        {
            if (reader == null || reader.IsClosed) return;

            this.pk_ID = reader.GetInt("RSHID");
            reader.GetInt("DividendIndex", this.DividendIndex);
            reader.GetInt("DTC", this.DTC);
            reader.GetString("Depositary", this.Depositary);
            reader.GetString("AccountNumber", this.AccountNumber);/*Optional 5*/
            reader.GetString("TIN", this.TIN);/*Optional 6*/
            reader.GetDecimal("Shares", this.Shares);/*Optional 7*/
            reader.GetString("RegisteredName", this.RegisteredName);/*Optional 8*/
            reader.GetString("Address", this.Address);/*Optional 9*/
            reader.GetString("CountryCode", this.CountryCode);/*Optional 10*/
            reader.GetString("TaxStatus", this.TaxStatus);/*Optional 11*/
            reader.GetDecimal("ForeignTaxWH", this.ForeignTaxWH);/*Optional 12*/
            reader.GetString("CUSIP", this.CUSIP);/*Optional 13*/
            reader.GetString("IssueNumber", this.IssueNumber);/*Optional 14*/
            reader.GetString("CitizenshipCode", this.CitizenshipCode);/*Optional 15*/
            reader.GetString("OwnerCode", this.OwnerCode);/*Optional 16*/
            reader.GetString("ZipCode", this.ZipCode);/*Optional 17*/
            reader.GetString("State", this.State);/*Optional 18*/
            reader.GetString("CityName", this.CityName);/*Optional 19*/
            reader.GetString("Agent", this.Agent);/*Optional 20*/
            reader.GetInt("LOC", this.LOC);/*Optional 21*/
            reader.GetDateTime("RecordDate", this.RecordDate);/*Optional 22*/
            reader.GetString("Comp_Num", this.Comp_Num);/*Optional 23*/
            reader.GetString("Class_CD", this.Class_CD);/*Optional 24*/
            reader.GetString("Tax_CD", this.Tax_CD);/*Optional 25*/
            reader.GetDecimal("Shares2", this.Shares2);/*Optional 26*/
            reader.GetString("GlobeTax", this.GlobeTax);/*Optional 27*/
            reader.GetString("Dividend_Intention", this.Dividend_Intention);/*Optional 28*/
            reader.GetDateTime("Holder_On_Date", this.Holder_On_Date);/*Optional 29*/
            reader.GetString("Tin_Status_1", this.Tin_Status_1);/*Optional 30*/
            reader.GetString("Tin_Status_Source", this.Tin_Status_Source);/*Optional 31*/
            reader.GetDateTime("Tin_Exp_Date_1", this.Tin_Exp_Date_1);/*Optional 32*/
            reader.GetInt("Tin_B_Count", this.Tin_B_Count);/*Optional 33*/
            reader.GetString("Holder_Type_Code", this.Holder_Type_Code);/*Optional 34*/
            reader.GetDateTime("Last_Contact_Date", this.Last_Contact_Date);/*Optional 35*/
            reader.GetString("Last_Contact_Type", this.Last_Contact_Type);/*Optional 36*/
            reader.GetString("GlobeTax_Findings", this.GlobeTax_Findings);/*Optional 37*/

            this.SyncWithDB();
        }

        /// <summary>
        /// Initialize object from DB
        /// </summary>
        public bool Init_from_DB()
        {
            if (this.RSHID < 0) return false;

            HssUtility.SQLserver.DB_select db_sel = new HssUtility.SQLserver.DB_select(RSH_log.Get_cmdTP());
            db_sel.tableName = "RSHLog";
            HssUtility.SQLserver.SQL_relation rela = new HssUtility.SQLserver.SQL_relation("RSHID", HssUtility.General.RelationalOperator.Equals, this.RSHID);
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
            this.attr_dic.Add("DTC", this.DTC);
            this.attr_dic.Add("Depositary", this.Depositary);
            this.attr_dic.Add("AccountNumber", this.AccountNumber);/*Optional 5*/
            this.attr_dic.Add("TIN", this.TIN);/*Optional 6*/
            this.attr_dic.Add("Shares", this.Shares);/*Optional 7*/
            this.attr_dic.Add("RegisteredName", this.RegisteredName);/*Optional 8*/
            this.attr_dic.Add("Address", this.Address);/*Optional 9*/
            this.attr_dic.Add("CountryCode", this.CountryCode);/*Optional 10*/
            this.attr_dic.Add("TaxStatus", this.TaxStatus);/*Optional 11*/
            this.attr_dic.Add("ForeignTaxWH", this.ForeignTaxWH);/*Optional 12*/
            this.attr_dic.Add("CUSIP", this.CUSIP);/*Optional 13*/
            this.attr_dic.Add("IssueNumber", this.IssueNumber);/*Optional 14*/
            this.attr_dic.Add("CitizenshipCode", this.CitizenshipCode);/*Optional 15*/
            this.attr_dic.Add("OwnerCode", this.OwnerCode);/*Optional 16*/
            this.attr_dic.Add("ZipCode", this.ZipCode);/*Optional 17*/
            this.attr_dic.Add("State", this.State);/*Optional 18*/
            this.attr_dic.Add("CityName", this.CityName);/*Optional 19*/
            this.attr_dic.Add("Agent", this.Agent);/*Optional 20*/
            this.attr_dic.Add("LOC", this.LOC);/*Optional 21*/
            this.attr_dic.Add("RecordDate", this.RecordDate);/*Optional 22*/
            this.attr_dic.Add("Comp_Num", this.Comp_Num);/*Optional 23*/
            this.attr_dic.Add("Class_CD", this.Class_CD);/*Optional 24*/
            this.attr_dic.Add("Tax_CD", this.Tax_CD);/*Optional 25*/
            this.attr_dic.Add("Shares2", this.Shares2);/*Optional 26*/
            this.attr_dic.Add("GlobeTax", this.GlobeTax);/*Optional 27*/
            this.attr_dic.Add("Dividend_Intention", this.Dividend_Intention);/*Optional 28*/
            this.attr_dic.Add("Holder_On_Date", this.Holder_On_Date);/*Optional 29*/
            this.attr_dic.Add("Tin_Status_1", this.Tin_Status_1);/*Optional 30*/
            this.attr_dic.Add("Tin_Status_Source", this.Tin_Status_Source);/*Optional 31*/
            this.attr_dic.Add("Tin_Exp_Date_1", this.Tin_Exp_Date_1);/*Optional 32*/
            this.attr_dic.Add("Tin_B_Count", this.Tin_B_Count);/*Optional 33*/
            this.attr_dic.Add("Holder_Type_Code", this.Holder_Type_Code);/*Optional 34*/
            this.attr_dic.Add("Last_Contact_Date", this.Last_Contact_Date);/*Optional 35*/
            this.attr_dic.Add("Last_Contact_Type", this.Last_Contact_Type);/*Optional 36*/
            this.attr_dic.Add("GlobeTax_Findings", this.GlobeTax_Findings);/*Optional 37*/
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
            HssUtility.SQLserver.DB_insert dbIns = new HssUtility.SQLserver.DB_insert(RSH_log.Get_cmdTP());

            dbIns.AddValue("DividendIndex", this.DividendIndex);
            dbIns.AddValue("DTC", this.DTC);
            dbIns.AddValue("Depositary", this.Depositary);
            dbIns.AddValue("AccountNumber", this.AccountNumber);/*Optional 5*/
            dbIns.AddValue("TIN", this.TIN);/*Optional 6*/
            dbIns.AddValue("Shares", this.Shares);/*Optional 7*/
            dbIns.AddValue("RegisteredName", this.RegisteredName);/*Optional 8*/
            dbIns.AddValue("Address", this.Address);/*Optional 9*/
            dbIns.AddValue("CountryCode", this.CountryCode);/*Optional 10*/
            dbIns.AddValue("TaxStatus", this.TaxStatus);/*Optional 11*/
            dbIns.AddValue("ForeignTaxWH", this.ForeignTaxWH);/*Optional 12*/
            dbIns.AddValue("CUSIP", this.CUSIP);/*Optional 13*/
            dbIns.AddValue("IssueNumber", this.IssueNumber);/*Optional 14*/
            dbIns.AddValue("CitizenshipCode", this.CitizenshipCode);/*Optional 15*/
            dbIns.AddValue("OwnerCode", this.OwnerCode);/*Optional 16*/
            dbIns.AddValue("ZipCode", this.ZipCode);/*Optional 17*/
            dbIns.AddValue("State", this.State);/*Optional 18*/
            dbIns.AddValue("CityName", this.CityName);/*Optional 19*/
            dbIns.AddValue("Agent", this.Agent);/*Optional 20*/
            dbIns.AddValue("LOC", this.LOC);/*Optional 21*/
            dbIns.AddValue("RecordDate", this.RecordDate);/*Optional 22*/
            dbIns.AddValue("Comp_Num", this.Comp_Num);/*Optional 23*/
            dbIns.AddValue("Class_CD", this.Class_CD);/*Optional 24*/
            dbIns.AddValue("Tax_CD", this.Tax_CD);/*Optional 25*/
            dbIns.AddValue("Shares2", this.Shares2);/*Optional 26*/
            dbIns.AddValue("GlobeTax", this.GlobeTax);/*Optional 27*/
            dbIns.AddValue("Dividend_Intention", this.Dividend_Intention);/*Optional 28*/
            dbIns.AddValue("Holder_On_Date", this.Holder_On_Date);/*Optional 29*/
            dbIns.AddValue("Tin_Status_1", this.Tin_Status_1);/*Optional 30*/
            dbIns.AddValue("Tin_Status_Source", this.Tin_Status_Source);/*Optional 31*/
            dbIns.AddValue("Tin_Exp_Date_1", this.Tin_Exp_Date_1);/*Optional 32*/
            dbIns.AddValue("Tin_B_Count", this.Tin_B_Count);/*Optional 33*/
            dbIns.AddValue("Holder_Type_Code", this.Holder_Type_Code);/*Optional 34*/
            dbIns.AddValue("Last_Contact_Date", this.Last_Contact_Date);/*Optional 35*/
            dbIns.AddValue("Last_Contact_Type", this.Last_Contact_Type);/*Optional 36*/
            dbIns.AddValue("GlobeTax_Findings", this.GlobeTax_Findings);/*Optional 37*/

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

            HssUtility.SQLserver.DB_update upd = new HssUtility.SQLserver.DB_update(RSH_log.Get_cmdTP());
            if (this.DividendIndex.ValueChanged) upd.AddValue("DividendIndex", this.DividendIndex);
            if (this.DTC.ValueChanged) upd.AddValue("DTC", this.DTC);
            if (this.Depositary.ValueChanged) upd.AddValue("Depositary", this.Depositary);
            if (this.AccountNumber.ValueChanged) upd.AddValue("AccountNumber", this.AccountNumber);/*Optional 5*/
            if (this.TIN.ValueChanged) upd.AddValue("TIN", this.TIN);/*Optional 6*/
            if (this.Shares.ValueChanged) upd.AddValue("Shares", this.Shares);/*Optional 7*/
            if (this.RegisteredName.ValueChanged) upd.AddValue("RegisteredName", this.RegisteredName);/*Optional 8*/
            if (this.Address.ValueChanged) upd.AddValue("Address", this.Address);/*Optional 9*/
            if (this.CountryCode.ValueChanged) upd.AddValue("CountryCode", this.CountryCode);/*Optional 10*/
            if (this.TaxStatus.ValueChanged) upd.AddValue("TaxStatus", this.TaxStatus);/*Optional 11*/
            if (this.ForeignTaxWH.ValueChanged) upd.AddValue("ForeignTaxWH", this.ForeignTaxWH);/*Optional 12*/
            if (this.CUSIP.ValueChanged) upd.AddValue("CUSIP", this.CUSIP);/*Optional 13*/
            if (this.IssueNumber.ValueChanged) upd.AddValue("IssueNumber", this.IssueNumber);/*Optional 14*/
            if (this.CitizenshipCode.ValueChanged) upd.AddValue("CitizenshipCode", this.CitizenshipCode);/*Optional 15*/
            if (this.OwnerCode.ValueChanged) upd.AddValue("OwnerCode", this.OwnerCode);/*Optional 16*/
            if (this.ZipCode.ValueChanged) upd.AddValue("ZipCode", this.ZipCode);/*Optional 17*/
            if (this.State.ValueChanged) upd.AddValue("State", this.State);/*Optional 18*/
            if (this.CityName.ValueChanged) upd.AddValue("CityName", this.CityName);/*Optional 19*/
            if (this.Agent.ValueChanged) upd.AddValue("Agent", this.Agent);/*Optional 20*/
            if (this.LOC.ValueChanged) upd.AddValue("LOC", this.LOC);/*Optional 21*/
            if (this.RecordDate.ValueChanged) upd.AddValue("RecordDate", this.RecordDate);/*Optional 22*/
            if (this.Comp_Num.ValueChanged) upd.AddValue("Comp_Num", this.Comp_Num);/*Optional 23*/
            if (this.Class_CD.ValueChanged) upd.AddValue("Class_CD", this.Class_CD);/*Optional 24*/
            if (this.Tax_CD.ValueChanged) upd.AddValue("Tax_CD", this.Tax_CD);/*Optional 25*/
            if (this.Shares2.ValueChanged) upd.AddValue("Shares2", this.Shares2);/*Optional 26*/
            if (this.GlobeTax.ValueChanged) upd.AddValue("GlobeTax", this.GlobeTax);/*Optional 27*/
            if (this.Dividend_Intention.ValueChanged) upd.AddValue("Dividend_Intention", this.Dividend_Intention);/*Optional 28*/
            if (this.Holder_On_Date.ValueChanged) upd.AddValue("Holder_On_Date", this.Holder_On_Date);/*Optional 29*/
            if (this.Tin_Status_1.ValueChanged) upd.AddValue("Tin_Status_1", this.Tin_Status_1);/*Optional 30*/
            if (this.Tin_Status_Source.ValueChanged) upd.AddValue("Tin_Status_Source", this.Tin_Status_Source);/*Optional 31*/
            if (this.Tin_Exp_Date_1.ValueChanged) upd.AddValue("Tin_Exp_Date_1", this.Tin_Exp_Date_1);/*Optional 32*/
            if (this.Tin_B_Count.ValueChanged) upd.AddValue("Tin_B_Count", this.Tin_B_Count);/*Optional 33*/
            if (this.Holder_Type_Code.ValueChanged) upd.AddValue("Holder_Type_Code", this.Holder_Type_Code);/*Optional 34*/
            if (this.Last_Contact_Date.ValueChanged) upd.AddValue("Last_Contact_Date", this.Last_Contact_Date);/*Optional 35*/
            if (this.Last_Contact_Type.ValueChanged) upd.AddValue("Last_Contact_Type", this.Last_Contact_Type);/*Optional 36*/
            if (this.GlobeTax_Findings.ValueChanged) upd.AddValue("GlobeTax_Findings", this.GlobeTax_Findings);/*Optional 37*/

            HssUtility.SQLserver.SQL_relation rela = new HssUtility.SQLserver.SQL_relation("RSHID", HssUtility.General.RelationalOperator.Equals, this.pk_ID);
            upd.SetCondition(rela);

            return upd;
        }

        public RSH_log GetCopy()
        {
            RSH_log newEntity = new RSH_log();
            if (!this.DividendIndex.IsNull_flag) newEntity.DividendIndex.Value = this.DividendIndex.Value;
            if (!this.DTC.IsNull_flag) newEntity.DTC.Value = this.DTC.Value;
            if (!this.Depositary.IsNull_flag) newEntity.Depositary.Value = this.Depositary.Value;
            if (!this.AccountNumber.IsNull_flag) newEntity.AccountNumber.Value = this.AccountNumber.Value;
            if (!this.TIN.IsNull_flag) newEntity.TIN.Value = this.TIN.Value;
            if (!this.Shares.IsNull_flag) newEntity.Shares.Value = this.Shares.Value;
            if (!this.RegisteredName.IsNull_flag) newEntity.RegisteredName.Value = this.RegisteredName.Value;
            if (!this.Address.IsNull_flag) newEntity.Address.Value = this.Address.Value;
            if (!this.CountryCode.IsNull_flag) newEntity.CountryCode.Value = this.CountryCode.Value;
            if (!this.TaxStatus.IsNull_flag) newEntity.TaxStatus.Value = this.TaxStatus.Value;
            if (!this.ForeignTaxWH.IsNull_flag) newEntity.ForeignTaxWH.Value = this.ForeignTaxWH.Value;
            if (!this.CUSIP.IsNull_flag) newEntity.CUSIP.Value = this.CUSIP.Value;
            if (!this.IssueNumber.IsNull_flag) newEntity.IssueNumber.Value = this.IssueNumber.Value;
            if (!this.CitizenshipCode.IsNull_flag) newEntity.CitizenshipCode.Value = this.CitizenshipCode.Value;
            if (!this.OwnerCode.IsNull_flag) newEntity.OwnerCode.Value = this.OwnerCode.Value;
            if (!this.ZipCode.IsNull_flag) newEntity.ZipCode.Value = this.ZipCode.Value;
            if (!this.State.IsNull_flag) newEntity.State.Value = this.State.Value;
            if (!this.CityName.IsNull_flag) newEntity.CityName.Value = this.CityName.Value;
            if (!this.Agent.IsNull_flag) newEntity.Agent.Value = this.Agent.Value;
            if (!this.LOC.IsNull_flag) newEntity.LOC.Value = this.LOC.Value;
            if (!this.RecordDate.IsNull_flag) newEntity.RecordDate.Value = this.RecordDate.Value;
            if (!this.Comp_Num.IsNull_flag) newEntity.Comp_Num.Value = this.Comp_Num.Value;
            if (!this.Class_CD.IsNull_flag) newEntity.Class_CD.Value = this.Class_CD.Value;
            if (!this.Tax_CD.IsNull_flag) newEntity.Tax_CD.Value = this.Tax_CD.Value;
            if (!this.Shares2.IsNull_flag) newEntity.Shares2.Value = this.Shares2.Value;
            if (!this.GlobeTax.IsNull_flag) newEntity.GlobeTax.Value = this.GlobeTax.Value;
            if (!this.Dividend_Intention.IsNull_flag) newEntity.Dividend_Intention.Value = this.Dividend_Intention.Value;
            if (!this.Holder_On_Date.IsNull_flag) newEntity.Holder_On_Date.Value = this.Holder_On_Date.Value;
            if (!this.Tin_Status_1.IsNull_flag) newEntity.Tin_Status_1.Value = this.Tin_Status_1.Value;
            if (!this.Tin_Status_Source.IsNull_flag) newEntity.Tin_Status_Source.Value = this.Tin_Status_Source.Value;
            if (!this.Tin_Exp_Date_1.IsNull_flag) newEntity.Tin_Exp_Date_1.Value = this.Tin_Exp_Date_1.Value;
            if (!this.Tin_B_Count.IsNull_flag) newEntity.Tin_B_Count.Value = this.Tin_B_Count.Value;
            if (!this.Holder_Type_Code.IsNull_flag) newEntity.Holder_Type_Code.Value = this.Holder_Type_Code.Value;
            if (!this.Last_Contact_Date.IsNull_flag) newEntity.Last_Contact_Date.Value = this.Last_Contact_Date.Value;
            if (!this.Last_Contact_Type.IsNull_flag) newEntity.Last_Contact_Type.Value = this.Last_Contact_Type.Value;
            if (!this.GlobeTax_Findings.IsNull_flag) newEntity.GlobeTax_Findings.Value = this.GlobeTax_Findings.Value;
            return newEntity;
        }

        public string ToXML()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("<RSH_log>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<RSHID>").Append(this.RSHID).Append("</RSHID>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<DividendIndex>").Append(this.DividendIndex.Value).Append("</DividendIndex>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<DTC>").Append(this.DTC.Value).Append("</DTC>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Depositary>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.Depositary.Value)).Append("</Depositary>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<AccountNumber>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.AccountNumber.Value)).Append("</AccountNumber>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<TIN>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.TIN.Value)).Append("</TIN>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Shares>").Append(this.Shares.Value).Append("</Shares>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<RegisteredName>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.RegisteredName.Value)).Append("</RegisteredName>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Address>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.Address.Value)).Append("</Address>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<CountryCode>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.CountryCode.Value)).Append("</CountryCode>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<TaxStatus>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.TaxStatus.Value)).Append("</TaxStatus>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<ForeignTaxWH>").Append(this.ForeignTaxWH.Value).Append("</ForeignTaxWH>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<CUSIP>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.CUSIP.Value)).Append("</CUSIP>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<IssueNumber>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.IssueNumber.Value)).Append("</IssueNumber>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<CitizenshipCode>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.CitizenshipCode.Value)).Append("</CitizenshipCode>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<OwnerCode>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.OwnerCode.Value)).Append("</OwnerCode>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<ZipCode>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.ZipCode.Value)).Append("</ZipCode>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<State>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.State.Value)).Append("</State>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<CityName>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.CityName.Value)).Append("</CityName>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Agent>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.Agent.Value)).Append("</Agent>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<LOC>").Append(this.LOC.Value).Append("</LOC>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<RecordDate>").Append(this.RecordDate.Value).Append("</RecordDate>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Comp_Num>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.Comp_Num.Value)).Append("</Comp_Num>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Class_CD>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.Class_CD.Value)).Append("</Class_CD>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Tax_CD>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.Tax_CD.Value)).Append("</Tax_CD>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Shares2>").Append(this.Shares2.Value).Append("</Shares2>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<GlobeTax>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.GlobeTax.Value)).Append("</GlobeTax>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Dividend_Intention>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.Dividend_Intention.Value)).Append("</Dividend_Intention>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Holder_On_Date>").Append(this.Holder_On_Date.Value).Append("</Holder_On_Date>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Tin_Status_1>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.Tin_Status_1.Value)).Append("</Tin_Status_1>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Tin_Status_Source>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.Tin_Status_Source.Value)).Append("</Tin_Status_Source>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Tin_Exp_Date_1>").Append(this.Tin_Exp_Date_1.Value).Append("</Tin_Exp_Date_1>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Tin_B_Count>").Append(this.Tin_B_Count.Value).Append("</Tin_B_Count>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Holder_Type_Code>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.Holder_Type_Code.Value)).Append("</Holder_Type_Code>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Last_Contact_Date>").Append(this.Last_Contact_Date.Value).Append("</Last_Contact_Date>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Last_Contact_Type>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.Last_Contact_Type.Value)).Append("</Last_Contact_Type>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<GlobeTax_Findings>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.GlobeTax_Findings.Value)).Append("</GlobeTax_Findings>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("</RSH_log>").Append(HssUtility.General.HssStr.WinNextLine);
            return sb.ToString();
        }
        /*^^^^^^^^^^^^^^^^^^^^^^^^^^^^^Hss Entity Framework Auto Generated Code^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^*/
    }
}
