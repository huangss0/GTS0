using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HssDARWIN.Models.Fees
{
    public class Dividend_Schedule_Of_Fees_DSC
    {
        /*-----------------------------Hss Entity Framework Auto Generated Code-------------------------------*/
        private static HssUtility.SQLserver.CmdTemplate DBcmd_TP = null;
        public static HssUtility.SQLserver.CmdTemplate Get_cmdTP()
        {
            if (Dividend_Schedule_Of_Fees_DSC.DBcmd_TP != null) return Dividend_Schedule_Of_Fees_DSC.DBcmd_TP;

            Dividend_Schedule_Of_Fees_DSC.DBcmd_TP = new HssUtility.SQLserver.CmdTemplate();
            Dividend_Schedule_Of_Fees_DSC.DBcmd_TP.tableName = "Dividend_Schedule_Of_Fees_DSC";
            Dividend_Schedule_Of_Fees_DSC.DBcmd_TP.schema = "dbo";

            Dividend_Schedule_Of_Fees_DSC.DBcmd_TP.AddColumn("Dividend_FeeID");
            Dividend_Schedule_Of_Fees_DSC.DBcmd_TP.AddColumn("DividendIndex");
            Dividend_Schedule_Of_Fees_DSC.DBcmd_TP.AddColumn("WHRate");
            Dividend_Schedule_Of_Fees_DSC.DBcmd_TP.AddColumn("LongFormFees");
            Dividend_Schedule_Of_Fees_DSC.DBcmd_TP.AddColumn("MinLongFormFee");
            Dividend_Schedule_Of_Fees_DSC.DBcmd_TP.AddColumn("Fee_Max");
            Dividend_Schedule_Of_Fees_DSC.DBcmd_TP.AddColumn("Fee_Consularization");
            Dividend_Schedule_Of_Fees_DSC.DBcmd_TP.AddColumn("FavAtSourceFee");
            Dividend_Schedule_Of_Fees_DSC.DBcmd_TP.AddColumn("MinAtSourceFee");
            Dividend_Schedule_Of_Fees_DSC.DBcmd_TP.AddColumn("ExemptAtSourceFee");
            Dividend_Schedule_Of_Fees_DSC.DBcmd_TP.AddColumn("ShortFormFees");
            Dividend_Schedule_Of_Fees_DSC.DBcmd_TP.AddColumn("Fee_AtSource");
            Dividend_Schedule_Of_Fees_DSC.DBcmd_TP.AddColumn("MinQuickRefundFee");
            Dividend_Schedule_Of_Fees_DSC.DBcmd_TP.AddColumn("FavTransparentEntityFee");
            Dividend_Schedule_Of_Fees_DSC.DBcmd_TP.AddColumn("MinShortFormFee");
            Dividend_Schedule_Of_Fees_DSC.DBcmd_TP.AddColumn("Fee_QuickRefund");
            Dividend_Schedule_Of_Fees_DSC.DBcmd_TP.AddColumn("LastModifiedBy");/*Optional 17*/
            Dividend_Schedule_Of_Fees_DSC.DBcmd_TP.AddColumn("ModifiedDateTime");/*Optional 18*/
            Dividend_Schedule_Of_Fees_DSC.DBcmd_TP.AddColumn("AdditionalDSCFee");/*Optional 19*/
            Dividend_Schedule_Of_Fees_DSC.DBcmd_TP.AddColumn("Source_FeeID");/*Optional 20*/
            Dividend_Schedule_Of_Fees_DSC.DBcmd_TP.AddColumn("AdditionalDSCFee1");/*Optional 21*/
            Dividend_Schedule_Of_Fees_DSC.DBcmd_TP.AddColumn("AtSourceModifiedBy");/*Optional 22*/

            return Dividend_Schedule_Of_Fees_DSC.DBcmd_TP;
        }

        public Dividend_Schedule_Of_Fees_DSC() { }
        public Dividend_Schedule_Of_Fees_DSC(int id) { this.pk_ID = id; }

        private int pk_ID = -1; //primary key
        public int Dividend_FeeID { get { return this.pk_ID; } }

        public readonly HssUtility.General.Attributes.Int_attr DividendIndex = new HssUtility.General.Attributes.Int_attr();
        public readonly HssUtility.General.Attributes.Decimal_attr WHRate = new HssUtility.General.Attributes.Decimal_attr(0);
        public readonly HssUtility.General.Attributes.Decimal_attr LongFormFees = new HssUtility.General.Attributes.Decimal_attr(0);
        public readonly HssUtility.General.Attributes.Decimal_attr MinLongFormFee = new HssUtility.General.Attributes.Decimal_attr(0);
        public readonly HssUtility.General.Attributes.Decimal_attr Fee_Max = new HssUtility.General.Attributes.Decimal_attr(0);
        public readonly HssUtility.General.Attributes.Decimal_attr Fee_Consularization = new HssUtility.General.Attributes.Decimal_attr(0);
        public readonly HssUtility.General.Attributes.Decimal_attr FavAtSourceFee = new HssUtility.General.Attributes.Decimal_attr(0);
        public readonly HssUtility.General.Attributes.Decimal_attr MinAtSourceFee = new HssUtility.General.Attributes.Decimal_attr(0);
        public readonly HssUtility.General.Attributes.Decimal_attr ExemptAtSourceFee = new HssUtility.General.Attributes.Decimal_attr(0);
        public readonly HssUtility.General.Attributes.Decimal_attr ShortFormFees = new HssUtility.General.Attributes.Decimal_attr(0);
        public readonly HssUtility.General.Attributes.Decimal_attr Fee_AtSource = new HssUtility.General.Attributes.Decimal_attr(0);
        public readonly HssUtility.General.Attributes.Decimal_attr MinQuickRefundFee = new HssUtility.General.Attributes.Decimal_attr(0);
        public readonly HssUtility.General.Attributes.Decimal_attr FavTransparentEntityFee = new HssUtility.General.Attributes.Decimal_attr(0);
        public readonly HssUtility.General.Attributes.Decimal_attr MinShortFormFee = new HssUtility.General.Attributes.Decimal_attr(0);
        public readonly HssUtility.General.Attributes.Decimal_attr Fee_QuickRefund = new HssUtility.General.Attributes.Decimal_attr(0);
        public readonly HssUtility.General.Attributes.String_attr LastModifiedBy = new HssUtility.General.Attributes.String_attr();/*Optional 17*/
        public readonly HssUtility.General.Attributes.DateTime_attr ModifiedDateTime = new HssUtility.General.Attributes.DateTime_attr();/*Optional 18*/
        public readonly HssUtility.General.Attributes.Decimal_attr AdditionalDSCFee = new HssUtility.General.Attributes.Decimal_attr(0);/*Optional 19*/
        public readonly HssUtility.General.Attributes.Int_attr Source_FeeID = new HssUtility.General.Attributes.Int_attr();/*Optional 20*/
        public readonly HssUtility.General.Attributes.Decimal_attr AdditionalDSCFee1 = new HssUtility.General.Attributes.Decimal_attr(0);/*Optional 21*/
        public readonly HssUtility.General.Attributes.String_attr AtSourceModifiedBy = new HssUtility.General.Attributes.String_attr();/*Optional 22*/

        private Dictionary<string, HssUtility.General.Attributes.I_modelAttr> attr_dic = null;

        internal void Init_from_reader(HssUtility.SQLserver.DB_reader reader)
        {
            if (reader == null || reader.IsClosed) return;

            this.pk_ID = reader.GetInt("Dividend_FeeID");
            reader.GetInt("DividendIndex", this.DividendIndex);
            reader.GetDecimal("WHRate", this.WHRate);
            reader.GetDecimal("LongFormFees", this.LongFormFees);
            reader.GetDecimal("MinLongFormFee", this.MinLongFormFee);
            reader.GetDecimal("Fee_Max", this.Fee_Max);
            reader.GetDecimal("Fee_Consularization", this.Fee_Consularization);
            reader.GetDecimal("FavAtSourceFee", this.FavAtSourceFee);
            reader.GetDecimal("MinAtSourceFee", this.MinAtSourceFee);
            reader.GetDecimal("ExemptAtSourceFee", this.ExemptAtSourceFee);
            reader.GetDecimal("ShortFormFees", this.ShortFormFees);
            reader.GetDecimal("Fee_AtSource", this.Fee_AtSource);
            reader.GetDecimal("MinQuickRefundFee", this.MinQuickRefundFee);
            reader.GetDecimal("FavTransparentEntityFee", this.FavTransparentEntityFee);
            reader.GetDecimal("MinShortFormFee", this.MinShortFormFee);
            reader.GetDecimal("Fee_QuickRefund", this.Fee_QuickRefund);
            reader.GetString("LastModifiedBy", this.LastModifiedBy);/*Optional 17*/
            reader.GetDateTime("ModifiedDateTime", this.ModifiedDateTime);/*Optional 18*/
            reader.GetDecimal("AdditionalDSCFee", this.AdditionalDSCFee);/*Optional 19*/
            reader.GetInt("Source_FeeID", this.Source_FeeID);/*Optional 20*/
            reader.GetDecimal("AdditionalDSCFee1", this.AdditionalDSCFee1);/*Optional 21*/
            reader.GetString("AtSourceModifiedBy", this.AtSourceModifiedBy);/*Optional 22*/

            this.SyncWithDB();
        }

        /// <summary>
        /// Initialize object from DB
        /// </summary>
        public bool Init_from_DB()
        {
            if (this.Dividend_FeeID < 0) return false;

            HssUtility.SQLserver.DB_select db_sel = new HssUtility.SQLserver.DB_select(Dividend_Schedule_Of_Fees_DSC.Get_cmdTP());
            db_sel.tableName = "Dividend_Schedule_Of_Fees_DSC";
            HssUtility.SQLserver.SQL_relation rela = new HssUtility.SQLserver.SQL_relation("Dividend_FeeID", HssUtility.General.RelationalOperator.Equals, this.Dividend_FeeID);
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
            this.attr_dic.Add("WHRate", this.WHRate);
            this.attr_dic.Add("LongFormFees", this.LongFormFees);
            this.attr_dic.Add("MinLongFormFee", this.MinLongFormFee);
            this.attr_dic.Add("Fee_Max", this.Fee_Max);
            this.attr_dic.Add("Fee_Consularization", this.Fee_Consularization);
            this.attr_dic.Add("FavAtSourceFee", this.FavAtSourceFee);
            this.attr_dic.Add("MinAtSourceFee", this.MinAtSourceFee);
            this.attr_dic.Add("ExemptAtSourceFee", this.ExemptAtSourceFee);
            this.attr_dic.Add("ShortFormFees", this.ShortFormFees);
            this.attr_dic.Add("Fee_AtSource", this.Fee_AtSource);
            this.attr_dic.Add("MinQuickRefundFee", this.MinQuickRefundFee);
            this.attr_dic.Add("FavTransparentEntityFee", this.FavTransparentEntityFee);
            this.attr_dic.Add("MinShortFormFee", this.MinShortFormFee);
            this.attr_dic.Add("Fee_QuickRefund", this.Fee_QuickRefund);
            this.attr_dic.Add("LastModifiedBy", this.LastModifiedBy);/*Optional 17*/
            this.attr_dic.Add("ModifiedDateTime", this.ModifiedDateTime);/*Optional 18*/
            this.attr_dic.Add("AdditionalDSCFee", this.AdditionalDSCFee);/*Optional 19*/
            this.attr_dic.Add("Source_FeeID", this.Source_FeeID);/*Optional 20*/
            this.attr_dic.Add("AdditionalDSCFee1", this.AdditionalDSCFee1);/*Optional 21*/
            this.attr_dic.Add("AtSourceModifiedBy", this.AtSourceModifiedBy);/*Optional 22*/
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
            HssUtility.SQLserver.DB_insert dbIns = new HssUtility.SQLserver.DB_insert(Dividend_Schedule_Of_Fees_DSC.Get_cmdTP());

            dbIns.AddValue("DividendIndex", this.DividendIndex);
            dbIns.AddValue("WHRate", this.WHRate);
            dbIns.AddValue("LongFormFees", this.LongFormFees);
            dbIns.AddValue("MinLongFormFee", this.MinLongFormFee);
            dbIns.AddValue("Fee_Max", this.Fee_Max);
            dbIns.AddValue("Fee_Consularization", this.Fee_Consularization);
            dbIns.AddValue("FavAtSourceFee", this.FavAtSourceFee);
            dbIns.AddValue("MinAtSourceFee", this.MinAtSourceFee);
            dbIns.AddValue("ExemptAtSourceFee", this.ExemptAtSourceFee);
            dbIns.AddValue("ShortFormFees", this.ShortFormFees);
            dbIns.AddValue("Fee_AtSource", this.Fee_AtSource);
            dbIns.AddValue("MinQuickRefundFee", this.MinQuickRefundFee);
            dbIns.AddValue("FavTransparentEntityFee", this.FavTransparentEntityFee);
            dbIns.AddValue("MinShortFormFee", this.MinShortFormFee);
            dbIns.AddValue("Fee_QuickRefund", this.Fee_QuickRefund);
            dbIns.AddValue("LastModifiedBy", this.LastModifiedBy);/*Optional 17*/
            dbIns.AddValue("ModifiedDateTime", this.ModifiedDateTime);/*Optional 18*/
            dbIns.AddValue("AdditionalDSCFee", this.AdditionalDSCFee);/*Optional 19*/
            dbIns.AddValue("Source_FeeID", this.Source_FeeID);/*Optional 20*/
            dbIns.AddValue("AdditionalDSCFee1", this.AdditionalDSCFee1);/*Optional 21*/
            dbIns.AddValue("AtSourceModifiedBy", this.AtSourceModifiedBy);/*Optional 22*/

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

            HssUtility.SQLserver.DB_update upd = new HssUtility.SQLserver.DB_update(Dividend_Schedule_Of_Fees_DSC.Get_cmdTP());
            if (this.DividendIndex.ValueChanged) upd.AddValue("DividendIndex", this.DividendIndex);
            if (this.WHRate.ValueChanged) upd.AddValue("WHRate", this.WHRate);
            if (this.LongFormFees.ValueChanged) upd.AddValue("LongFormFees", this.LongFormFees);
            if (this.MinLongFormFee.ValueChanged) upd.AddValue("MinLongFormFee", this.MinLongFormFee);
            if (this.Fee_Max.ValueChanged) upd.AddValue("Fee_Max", this.Fee_Max);
            if (this.Fee_Consularization.ValueChanged) upd.AddValue("Fee_Consularization", this.Fee_Consularization);
            if (this.FavAtSourceFee.ValueChanged) upd.AddValue("FavAtSourceFee", this.FavAtSourceFee);
            if (this.MinAtSourceFee.ValueChanged) upd.AddValue("MinAtSourceFee", this.MinAtSourceFee);
            if (this.ExemptAtSourceFee.ValueChanged) upd.AddValue("ExemptAtSourceFee", this.ExemptAtSourceFee);
            if (this.ShortFormFees.ValueChanged) upd.AddValue("ShortFormFees", this.ShortFormFees);
            if (this.Fee_AtSource.ValueChanged) upd.AddValue("Fee_AtSource", this.Fee_AtSource);
            if (this.MinQuickRefundFee.ValueChanged) upd.AddValue("MinQuickRefundFee", this.MinQuickRefundFee);
            if (this.FavTransparentEntityFee.ValueChanged) upd.AddValue("FavTransparentEntityFee", this.FavTransparentEntityFee);
            if (this.MinShortFormFee.ValueChanged) upd.AddValue("MinShortFormFee", this.MinShortFormFee);
            if (this.Fee_QuickRefund.ValueChanged) upd.AddValue("Fee_QuickRefund", this.Fee_QuickRefund);
            if (this.LastModifiedBy.ValueChanged) upd.AddValue("LastModifiedBy", this.LastModifiedBy);/*Optional 17*/
            if (this.ModifiedDateTime.ValueChanged) upd.AddValue("ModifiedDateTime", this.ModifiedDateTime);/*Optional 18*/
            if (this.AdditionalDSCFee.ValueChanged) upd.AddValue("AdditionalDSCFee", this.AdditionalDSCFee);/*Optional 19*/
            if (this.Source_FeeID.ValueChanged) upd.AddValue("Source_FeeID", this.Source_FeeID);/*Optional 20*/
            if (this.AdditionalDSCFee1.ValueChanged) upd.AddValue("AdditionalDSCFee1", this.AdditionalDSCFee1);/*Optional 21*/
            if (this.AtSourceModifiedBy.ValueChanged) upd.AddValue("AtSourceModifiedBy", this.AtSourceModifiedBy);/*Optional 22*/

            HssUtility.SQLserver.SQL_relation rela = new HssUtility.SQLserver.SQL_relation("Dividend_FeeID", HssUtility.General.RelationalOperator.Equals, this.pk_ID);
            upd.SetCondition(rela);

            return upd;
        }

        public Dividend_Schedule_Of_Fees_DSC GetCopy()
        {
            Dividend_Schedule_Of_Fees_DSC newEntity = new Dividend_Schedule_Of_Fees_DSC();
            if (!this.DividendIndex.IsNull_flag) newEntity.DividendIndex.Value = this.DividendIndex.Value;
            if (!this.WHRate.IsNull_flag) newEntity.WHRate.Value = this.WHRate.Value;
            if (!this.LongFormFees.IsNull_flag) newEntity.LongFormFees.Value = this.LongFormFees.Value;
            if (!this.MinLongFormFee.IsNull_flag) newEntity.MinLongFormFee.Value = this.MinLongFormFee.Value;
            if (!this.Fee_Max.IsNull_flag) newEntity.Fee_Max.Value = this.Fee_Max.Value;
            if (!this.Fee_Consularization.IsNull_flag) newEntity.Fee_Consularization.Value = this.Fee_Consularization.Value;
            if (!this.FavAtSourceFee.IsNull_flag) newEntity.FavAtSourceFee.Value = this.FavAtSourceFee.Value;
            if (!this.MinAtSourceFee.IsNull_flag) newEntity.MinAtSourceFee.Value = this.MinAtSourceFee.Value;
            if (!this.ExemptAtSourceFee.IsNull_flag) newEntity.ExemptAtSourceFee.Value = this.ExemptAtSourceFee.Value;
            if (!this.ShortFormFees.IsNull_flag) newEntity.ShortFormFees.Value = this.ShortFormFees.Value;
            if (!this.Fee_AtSource.IsNull_flag) newEntity.Fee_AtSource.Value = this.Fee_AtSource.Value;
            if (!this.MinQuickRefundFee.IsNull_flag) newEntity.MinQuickRefundFee.Value = this.MinQuickRefundFee.Value;
            if (!this.FavTransparentEntityFee.IsNull_flag) newEntity.FavTransparentEntityFee.Value = this.FavTransparentEntityFee.Value;
            if (!this.MinShortFormFee.IsNull_flag) newEntity.MinShortFormFee.Value = this.MinShortFormFee.Value;
            if (!this.Fee_QuickRefund.IsNull_flag) newEntity.Fee_QuickRefund.Value = this.Fee_QuickRefund.Value;
            if (!this.LastModifiedBy.IsNull_flag) newEntity.LastModifiedBy.Value = this.LastModifiedBy.Value;
            if (!this.ModifiedDateTime.IsNull_flag) newEntity.ModifiedDateTime.Value = this.ModifiedDateTime.Value;
            if (!this.AdditionalDSCFee.IsNull_flag) newEntity.AdditionalDSCFee.Value = this.AdditionalDSCFee.Value;
            if (!this.Source_FeeID.IsNull_flag) newEntity.Source_FeeID.Value = this.Source_FeeID.Value;
            if (!this.AdditionalDSCFee1.IsNull_flag) newEntity.AdditionalDSCFee1.Value = this.AdditionalDSCFee1.Value;
            if (!this.AtSourceModifiedBy.IsNull_flag) newEntity.AtSourceModifiedBy.Value = this.AtSourceModifiedBy.Value;
            return newEntity;
        }

        public string ToXML()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("<Dividend_Schedule_Of_Fees_DSC>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Dividend_FeeID>").Append(this.Dividend_FeeID).Append("</Dividend_FeeID>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<DividendIndex>").Append(this.DividendIndex.Value).Append("</DividendIndex>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<WHRate>").Append(this.WHRate.Value).Append("</WHRate>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<LongFormFees>").Append(this.LongFormFees.Value).Append("</LongFormFees>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<MinLongFormFee>").Append(this.MinLongFormFee.Value).Append("</MinLongFormFee>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Fee_Max>").Append(this.Fee_Max.Value).Append("</Fee_Max>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Fee_Consularization>").Append(this.Fee_Consularization.Value).Append("</Fee_Consularization>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<FavAtSourceFee>").Append(this.FavAtSourceFee.Value).Append("</FavAtSourceFee>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<MinAtSourceFee>").Append(this.MinAtSourceFee.Value).Append("</MinAtSourceFee>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<ExemptAtSourceFee>").Append(this.ExemptAtSourceFee.Value).Append("</ExemptAtSourceFee>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<ShortFormFees>").Append(this.ShortFormFees.Value).Append("</ShortFormFees>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Fee_AtSource>").Append(this.Fee_AtSource.Value).Append("</Fee_AtSource>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<MinQuickRefundFee>").Append(this.MinQuickRefundFee.Value).Append("</MinQuickRefundFee>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<FavTransparentEntityFee>").Append(this.FavTransparentEntityFee.Value).Append("</FavTransparentEntityFee>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<MinShortFormFee>").Append(this.MinShortFormFee.Value).Append("</MinShortFormFee>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Fee_QuickRefund>").Append(this.Fee_QuickRefund.Value).Append("</Fee_QuickRefund>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<LastModifiedBy>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.LastModifiedBy.Value)).Append("</LastModifiedBy>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<ModifiedDateTime>").Append(this.ModifiedDateTime.Value).Append("</ModifiedDateTime>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<AdditionalDSCFee>").Append(this.AdditionalDSCFee.Value).Append("</AdditionalDSCFee>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Source_FeeID>").Append(this.Source_FeeID.Value).Append("</Source_FeeID>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<AdditionalDSCFee1>").Append(this.AdditionalDSCFee1.Value).Append("</AdditionalDSCFee1>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<AtSourceModifiedBy>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.AtSourceModifiedBy.Value)).Append("</AtSourceModifiedBy>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("</Dividend_Schedule_Of_Fees_DSC>").Append(HssUtility.General.HssStr.WinNextLine);
            return sb.ToString();
        }
        /*^^^^^^^^^^^^^^^^^^^^^^^^^^^^^Hss Entity Framework Auto Generated Code^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^*/
    }
}
