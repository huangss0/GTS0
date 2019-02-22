using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HssDARWIN.Models.Fees
{
    public class Schedule_Of_Fees_DSC
    {
        /*-----------------------------Hss Entity Framework Auto Generated Code-------------------------------*/
        private static HssUtility.SQLserver.CmdTemplate DBcmd_TP = null;
        public static HssUtility.SQLserver.CmdTemplate Get_cmdTP()
        {
            if (Schedule_Of_Fees_DSC.DBcmd_TP != null) return Schedule_Of_Fees_DSC.DBcmd_TP;

            Schedule_Of_Fees_DSC.DBcmd_TP = new HssUtility.SQLserver.CmdTemplate();
            Schedule_Of_Fees_DSC.DBcmd_TP.tableName = "Schedule_Of_Fees_DSC";
            Schedule_Of_Fees_DSC.DBcmd_TP.schema = "dbo";

            Schedule_Of_Fees_DSC.DBcmd_TP.AddColumn("FeesID");
            Schedule_Of_Fees_DSC.DBcmd_TP.AddColumn("Country");
            Schedule_Of_Fees_DSC.DBcmd_TP.AddColumn("Security_Type");/*Optional 3*/
            Schedule_Of_Fees_DSC.DBcmd_TP.AddColumn("Depositary");
            Schedule_Of_Fees_DSC.DBcmd_TP.AddColumn("ShortFormFees");/*Optional 5*/
            Schedule_Of_Fees_DSC.DBcmd_TP.AddColumn("LongFormFees");/*Optional 6*/
            Schedule_Of_Fees_DSC.DBcmd_TP.AddColumn("FavAtSourceFee");/*Optional 7*/
            Schedule_Of_Fees_DSC.DBcmd_TP.AddColumn("ExemptAtSourceFee");/*Optional 8*/
            Schedule_Of_Fees_DSC.DBcmd_TP.AddColumn("FavTransparentEntityFee");/*Optional 9*/
            Schedule_Of_Fees_DSC.DBcmd_TP.AddColumn("MinAtSourceFee");/*Optional 10*/
            Schedule_Of_Fees_DSC.DBcmd_TP.AddColumn("MinLongFormFee");/*Optional 11*/
            Schedule_Of_Fees_DSC.DBcmd_TP.AddColumn("MinQuickRefundFee");/*Optional 12*/
            Schedule_Of_Fees_DSC.DBcmd_TP.AddColumn("MinShortFormFee");/*Optional 13*/
            Schedule_Of_Fees_DSC.DBcmd_TP.AddColumn("EffectiveDate");
            Schedule_Of_Fees_DSC.DBcmd_TP.AddColumn("CreatedDate");/*Optional 15*/
            Schedule_Of_Fees_DSC.DBcmd_TP.AddColumn("ImportBy");/*Optional 16*/
            Schedule_Of_Fees_DSC.DBcmd_TP.AddColumn("Notes");/*Optional 17*/
            Schedule_Of_Fees_DSC.DBcmd_TP.AddColumn("SecurityTypeID");
            Schedule_Of_Fees_DSC.DBcmd_TP.AddColumn("IncomeEventID");/*Optional 19*/
            Schedule_Of_Fees_DSC.DBcmd_TP.AddColumn("Issue");/*Optional 20*/
            Schedule_Of_Fees_DSC.DBcmd_TP.AddColumn("CUSIP");/*Optional 21*/
            Schedule_Of_Fees_DSC.DBcmd_TP.AddColumn("AdditionalDSCFee");/*Optional 22*/

            return Schedule_Of_Fees_DSC.DBcmd_TP;
        }

        public Schedule_Of_Fees_DSC() { }
        public Schedule_Of_Fees_DSC(int id) { this.pk_ID = id; }

        private int pk_ID = -1; //primary key
        public int FeesID { get { return this.pk_ID; } }

        public readonly HssUtility.General.Attributes.String_attr Country = new HssUtility.General.Attributes.String_attr();
        public readonly HssUtility.General.Attributes.String_attr Security_Type = new HssUtility.General.Attributes.String_attr();/*Optional 3*/
        public readonly HssUtility.General.Attributes.String_attr Depositary = new HssUtility.General.Attributes.String_attr();
        public readonly HssUtility.General.Attributes.Decimal_attr ShortFormFees = new HssUtility.General.Attributes.Decimal_attr();/*Optional 5*/
        public readonly HssUtility.General.Attributes.Decimal_attr LongFormFees = new HssUtility.General.Attributes.Decimal_attr();/*Optional 6*/
        public readonly HssUtility.General.Attributes.Decimal_attr FavAtSourceFee = new HssUtility.General.Attributes.Decimal_attr();/*Optional 7*/
        public readonly HssUtility.General.Attributes.Decimal_attr ExemptAtSourceFee = new HssUtility.General.Attributes.Decimal_attr();/*Optional 8*/
        public readonly HssUtility.General.Attributes.Decimal_attr FavTransparentEntityFee = new HssUtility.General.Attributes.Decimal_attr();/*Optional 9*/
        public readonly HssUtility.General.Attributes.Decimal_attr MinAtSourceFee = new HssUtility.General.Attributes.Decimal_attr();/*Optional 10*/
        public readonly HssUtility.General.Attributes.Decimal_attr MinLongFormFee = new HssUtility.General.Attributes.Decimal_attr();/*Optional 11*/
        public readonly HssUtility.General.Attributes.Decimal_attr MinQuickRefundFee = new HssUtility.General.Attributes.Decimal_attr();/*Optional 12*/
        public readonly HssUtility.General.Attributes.Decimal_attr MinShortFormFee = new HssUtility.General.Attributes.Decimal_attr();/*Optional 13*/
        public readonly HssUtility.General.Attributes.DateTime_attr EffectiveDate = new HssUtility.General.Attributes.DateTime_attr();
        public readonly HssUtility.General.Attributes.DateTime_attr CreatedDate = new HssUtility.General.Attributes.DateTime_attr();/*Optional 15*/
        public readonly HssUtility.General.Attributes.String_attr ImportBy = new HssUtility.General.Attributes.String_attr();/*Optional 16*/
        public readonly HssUtility.General.Attributes.String_attr Notes = new HssUtility.General.Attributes.String_attr();/*Optional 17*/
        public readonly HssUtility.General.Attributes.Int_attr SecurityTypeID = new HssUtility.General.Attributes.Int_attr();
        public readonly HssUtility.General.Attributes.String_attr IncomeEventID = new HssUtility.General.Attributes.String_attr();/*Optional 19*/
        public readonly HssUtility.General.Attributes.String_attr Issue = new HssUtility.General.Attributes.String_attr();/*Optional 20*/
        public readonly HssUtility.General.Attributes.String_attr CUSIP = new HssUtility.General.Attributes.String_attr();/*Optional 21*/
        public readonly HssUtility.General.Attributes.Decimal_attr AdditionalDSCFee = new HssUtility.General.Attributes.Decimal_attr();/*Optional 22*/

        private Dictionary<string, HssUtility.General.Attributes.I_modelAttr> attr_dic = null;

        internal void Init_from_reader(HssUtility.SQLserver.DB_reader reader)
        {
            if (reader == null || reader.IsClosed) return;

            this.pk_ID = reader.GetInt("FeesID");
            reader.GetString("Country", this.Country);
            reader.GetString("Security_Type", this.Security_Type);/*Optional 3*/
            reader.GetString("Depositary", this.Depositary);
            reader.GetDecimal("ShortFormFees", this.ShortFormFees);/*Optional 5*/
            reader.GetDecimal("LongFormFees", this.LongFormFees);/*Optional 6*/
            reader.GetDecimal("FavAtSourceFee", this.FavAtSourceFee);/*Optional 7*/
            reader.GetDecimal("ExemptAtSourceFee", this.ExemptAtSourceFee);/*Optional 8*/
            reader.GetDecimal("FavTransparentEntityFee", this.FavTransparentEntityFee);/*Optional 9*/
            reader.GetDecimal("MinAtSourceFee", this.MinAtSourceFee);/*Optional 10*/
            reader.GetDecimal("MinLongFormFee", this.MinLongFormFee);/*Optional 11*/
            reader.GetDecimal("MinQuickRefundFee", this.MinQuickRefundFee);/*Optional 12*/
            reader.GetDecimal("MinShortFormFee", this.MinShortFormFee);/*Optional 13*/
            reader.GetDateTime("EffectiveDate", this.EffectiveDate);
            reader.GetDateTime("CreatedDate", this.CreatedDate);/*Optional 15*/
            reader.GetString("ImportBy", this.ImportBy);/*Optional 16*/
            reader.GetString("Notes", this.Notes);/*Optional 17*/
            reader.GetInt("SecurityTypeID", this.SecurityTypeID);
            reader.GetString("IncomeEventID", this.IncomeEventID);/*Optional 19*/
            reader.GetString("Issue", this.Issue);/*Optional 20*/
            reader.GetString("CUSIP", this.CUSIP);/*Optional 21*/
            reader.GetDecimal("AdditionalDSCFee", this.AdditionalDSCFee);/*Optional 22*/

            this.SyncWithDB();
        }

        /// <summary>
        /// Initialize object from DB
        /// </summary>
        public bool Init_from_DB()
        {
            if (this.FeesID < 0) return false;

            HssUtility.SQLserver.DB_select db_sel = new HssUtility.SQLserver.DB_select(Schedule_Of_Fees_DSC.Get_cmdTP());
            db_sel.tableName = "Schedule_Of_Fees_DSC";
            HssUtility.SQLserver.SQL_relation rela = new HssUtility.SQLserver.SQL_relation("FeesID", HssUtility.General.RelationalOperator.Equals, this.FeesID);
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
            this.attr_dic.Add("Country", this.Country);
            this.attr_dic.Add("Security_Type", this.Security_Type);/*Optional 3*/
            this.attr_dic.Add("Depositary", this.Depositary);
            this.attr_dic.Add("ShortFormFees", this.ShortFormFees);/*Optional 5*/
            this.attr_dic.Add("LongFormFees", this.LongFormFees);/*Optional 6*/
            this.attr_dic.Add("FavAtSourceFee", this.FavAtSourceFee);/*Optional 7*/
            this.attr_dic.Add("ExemptAtSourceFee", this.ExemptAtSourceFee);/*Optional 8*/
            this.attr_dic.Add("FavTransparentEntityFee", this.FavTransparentEntityFee);/*Optional 9*/
            this.attr_dic.Add("MinAtSourceFee", this.MinAtSourceFee);/*Optional 10*/
            this.attr_dic.Add("MinLongFormFee", this.MinLongFormFee);/*Optional 11*/
            this.attr_dic.Add("MinQuickRefundFee", this.MinQuickRefundFee);/*Optional 12*/
            this.attr_dic.Add("MinShortFormFee", this.MinShortFormFee);/*Optional 13*/
            this.attr_dic.Add("EffectiveDate", this.EffectiveDate);
            this.attr_dic.Add("CreatedDate", this.CreatedDate);/*Optional 15*/
            this.attr_dic.Add("ImportBy", this.ImportBy);/*Optional 16*/
            this.attr_dic.Add("Notes", this.Notes);/*Optional 17*/
            this.attr_dic.Add("SecurityTypeID", this.SecurityTypeID);
            this.attr_dic.Add("IncomeEventID", this.IncomeEventID);/*Optional 19*/
            this.attr_dic.Add("Issue", this.Issue);/*Optional 20*/
            this.attr_dic.Add("CUSIP", this.CUSIP);/*Optional 21*/
            this.attr_dic.Add("AdditionalDSCFee", this.AdditionalDSCFee);/*Optional 22*/
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
            HssUtility.SQLserver.DB_insert dbIns = new HssUtility.SQLserver.DB_insert(Schedule_Of_Fees_DSC.Get_cmdTP());

            dbIns.AddValue("Country", this.Country);
            dbIns.AddValue("Security_Type", this.Security_Type);/*Optional 3*/
            dbIns.AddValue("Depositary", this.Depositary);
            dbIns.AddValue("ShortFormFees", this.ShortFormFees);/*Optional 5*/
            dbIns.AddValue("LongFormFees", this.LongFormFees);/*Optional 6*/
            dbIns.AddValue("FavAtSourceFee", this.FavAtSourceFee);/*Optional 7*/
            dbIns.AddValue("ExemptAtSourceFee", this.ExemptAtSourceFee);/*Optional 8*/
            dbIns.AddValue("FavTransparentEntityFee", this.FavTransparentEntityFee);/*Optional 9*/
            dbIns.AddValue("MinAtSourceFee", this.MinAtSourceFee);/*Optional 10*/
            dbIns.AddValue("MinLongFormFee", this.MinLongFormFee);/*Optional 11*/
            dbIns.AddValue("MinQuickRefundFee", this.MinQuickRefundFee);/*Optional 12*/
            dbIns.AddValue("MinShortFormFee", this.MinShortFormFee);/*Optional 13*/
            dbIns.AddValue("EffectiveDate", this.EffectiveDate);
            dbIns.AddValue("CreatedDate", this.CreatedDate);/*Optional 15*/
            dbIns.AddValue("ImportBy", this.ImportBy);/*Optional 16*/
            dbIns.AddValue("Notes", this.Notes);/*Optional 17*/
            dbIns.AddValue("SecurityTypeID", this.SecurityTypeID);
            dbIns.AddValue("IncomeEventID", this.IncomeEventID);/*Optional 19*/
            dbIns.AddValue("Issue", this.Issue);/*Optional 20*/
            dbIns.AddValue("CUSIP", this.CUSIP);/*Optional 21*/
            dbIns.AddValue("AdditionalDSCFee", this.AdditionalDSCFee);/*Optional 22*/

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

            HssUtility.SQLserver.DB_update upd = new HssUtility.SQLserver.DB_update(Schedule_Of_Fees_DSC.Get_cmdTP());
            if (this.Country.ValueChanged) upd.AddValue("Country", this.Country);
            if (this.Security_Type.ValueChanged) upd.AddValue("Security_Type", this.Security_Type);/*Optional 3*/
            if (this.Depositary.ValueChanged) upd.AddValue("Depositary", this.Depositary);
            if (this.ShortFormFees.ValueChanged) upd.AddValue("ShortFormFees", this.ShortFormFees);/*Optional 5*/
            if (this.LongFormFees.ValueChanged) upd.AddValue("LongFormFees", this.LongFormFees);/*Optional 6*/
            if (this.FavAtSourceFee.ValueChanged) upd.AddValue("FavAtSourceFee", this.FavAtSourceFee);/*Optional 7*/
            if (this.ExemptAtSourceFee.ValueChanged) upd.AddValue("ExemptAtSourceFee", this.ExemptAtSourceFee);/*Optional 8*/
            if (this.FavTransparentEntityFee.ValueChanged) upd.AddValue("FavTransparentEntityFee", this.FavTransparentEntityFee);/*Optional 9*/
            if (this.MinAtSourceFee.ValueChanged) upd.AddValue("MinAtSourceFee", this.MinAtSourceFee);/*Optional 10*/
            if (this.MinLongFormFee.ValueChanged) upd.AddValue("MinLongFormFee", this.MinLongFormFee);/*Optional 11*/
            if (this.MinQuickRefundFee.ValueChanged) upd.AddValue("MinQuickRefundFee", this.MinQuickRefundFee);/*Optional 12*/
            if (this.MinShortFormFee.ValueChanged) upd.AddValue("MinShortFormFee", this.MinShortFormFee);/*Optional 13*/
            if (this.EffectiveDate.ValueChanged) upd.AddValue("EffectiveDate", this.EffectiveDate);
            if (this.CreatedDate.ValueChanged) upd.AddValue("CreatedDate", this.CreatedDate);/*Optional 15*/
            if (this.ImportBy.ValueChanged) upd.AddValue("ImportBy", this.ImportBy);/*Optional 16*/
            if (this.Notes.ValueChanged) upd.AddValue("Notes", this.Notes);/*Optional 17*/
            if (this.SecurityTypeID.ValueChanged) upd.AddValue("SecurityTypeID", this.SecurityTypeID);
            if (this.IncomeEventID.ValueChanged) upd.AddValue("IncomeEventID", this.IncomeEventID);/*Optional 19*/
            if (this.Issue.ValueChanged) upd.AddValue("Issue", this.Issue);/*Optional 20*/
            if (this.CUSIP.ValueChanged) upd.AddValue("CUSIP", this.CUSIP);/*Optional 21*/
            if (this.AdditionalDSCFee.ValueChanged) upd.AddValue("AdditionalDSCFee", this.AdditionalDSCFee);/*Optional 22*/

            HssUtility.SQLserver.SQL_relation rela = new HssUtility.SQLserver.SQL_relation("FeesID", HssUtility.General.RelationalOperator.Equals, this.pk_ID);
            upd.SetCondition(rela);

            return upd;
        }

        public Schedule_Of_Fees_DSC GetCopy()
        {
            Schedule_Of_Fees_DSC newEntity = new Schedule_Of_Fees_DSC();
            if (!this.Country.IsNull_flag) newEntity.Country.Value = this.Country.Value;
            if (!this.Security_Type.IsNull_flag) newEntity.Security_Type.Value = this.Security_Type.Value;
            if (!this.Depositary.IsNull_flag) newEntity.Depositary.Value = this.Depositary.Value;
            if (!this.ShortFormFees.IsNull_flag) newEntity.ShortFormFees.Value = this.ShortFormFees.Value;
            if (!this.LongFormFees.IsNull_flag) newEntity.LongFormFees.Value = this.LongFormFees.Value;
            if (!this.FavAtSourceFee.IsNull_flag) newEntity.FavAtSourceFee.Value = this.FavAtSourceFee.Value;
            if (!this.ExemptAtSourceFee.IsNull_flag) newEntity.ExemptAtSourceFee.Value = this.ExemptAtSourceFee.Value;
            if (!this.FavTransparentEntityFee.IsNull_flag) newEntity.FavTransparentEntityFee.Value = this.FavTransparentEntityFee.Value;
            if (!this.MinAtSourceFee.IsNull_flag) newEntity.MinAtSourceFee.Value = this.MinAtSourceFee.Value;
            if (!this.MinLongFormFee.IsNull_flag) newEntity.MinLongFormFee.Value = this.MinLongFormFee.Value;
            if (!this.MinQuickRefundFee.IsNull_flag) newEntity.MinQuickRefundFee.Value = this.MinQuickRefundFee.Value;
            if (!this.MinShortFormFee.IsNull_flag) newEntity.MinShortFormFee.Value = this.MinShortFormFee.Value;
            if (!this.EffectiveDate.IsNull_flag) newEntity.EffectiveDate.Value = this.EffectiveDate.Value;
            if (!this.CreatedDate.IsNull_flag) newEntity.CreatedDate.Value = this.CreatedDate.Value;
            if (!this.ImportBy.IsNull_flag) newEntity.ImportBy.Value = this.ImportBy.Value;
            if (!this.Notes.IsNull_flag) newEntity.Notes.Value = this.Notes.Value;
            if (!this.SecurityTypeID.IsNull_flag) newEntity.SecurityTypeID.Value = this.SecurityTypeID.Value;
            if (!this.IncomeEventID.IsNull_flag) newEntity.IncomeEventID.Value = this.IncomeEventID.Value;
            if (!this.Issue.IsNull_flag) newEntity.Issue.Value = this.Issue.Value;
            if (!this.CUSIP.IsNull_flag) newEntity.CUSIP.Value = this.CUSIP.Value;
            if (!this.AdditionalDSCFee.IsNull_flag) newEntity.AdditionalDSCFee.Value = this.AdditionalDSCFee.Value;
            return newEntity;
        }

        public string ToXML()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("<Schedule_Of_Fees_DSC>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<FeesID>").Append(this.FeesID).Append("</FeesID>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Country>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.Country.Value)).Append("</Country>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Security_Type>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.Security_Type.Value)).Append("</Security_Type>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Depositary>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.Depositary.Value)).Append("</Depositary>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<ShortFormFees>").Append(this.ShortFormFees.Value).Append("</ShortFormFees>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<LongFormFees>").Append(this.LongFormFees.Value).Append("</LongFormFees>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<FavAtSourceFee>").Append(this.FavAtSourceFee.Value).Append("</FavAtSourceFee>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<ExemptAtSourceFee>").Append(this.ExemptAtSourceFee.Value).Append("</ExemptAtSourceFee>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<FavTransparentEntityFee>").Append(this.FavTransparentEntityFee.Value).Append("</FavTransparentEntityFee>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<MinAtSourceFee>").Append(this.MinAtSourceFee.Value).Append("</MinAtSourceFee>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<MinLongFormFee>").Append(this.MinLongFormFee.Value).Append("</MinLongFormFee>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<MinQuickRefundFee>").Append(this.MinQuickRefundFee.Value).Append("</MinQuickRefundFee>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<MinShortFormFee>").Append(this.MinShortFormFee.Value).Append("</MinShortFormFee>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<EffectiveDate>").Append(this.EffectiveDate.Value).Append("</EffectiveDate>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<CreatedDate>").Append(this.CreatedDate.Value).Append("</CreatedDate>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<ImportBy>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.ImportBy.Value)).Append("</ImportBy>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Notes>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.Notes.Value)).Append("</Notes>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<SecurityTypeID>").Append(this.SecurityTypeID.Value).Append("</SecurityTypeID>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<IncomeEventID>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.IncomeEventID.Value)).Append("</IncomeEventID>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Issue>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.Issue.Value)).Append("</Issue>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<CUSIP>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.CUSIP.Value)).Append("</CUSIP>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<AdditionalDSCFee>").Append(this.AdditionalDSCFee.Value).Append("</AdditionalDSCFee>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("</Schedule_Of_Fees_DSC>").Append(HssUtility.General.HssStr.WinNextLine);
            return sb.ToString();
        }
        /*^^^^^^^^^^^^^^^^^^^^^^^^^^^^^Hss Entity Framework Auto Generated Code^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^*/
    }
}
