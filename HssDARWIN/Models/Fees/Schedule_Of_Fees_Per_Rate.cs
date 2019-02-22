using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HssDARWIN.Models.Fees
{
    public class Schedule_Of_Fees_Per_Rate
    {
        /*-----------------------------Hss Entity Framework Auto Generated Code-------------------------------*/
        private static HssUtility.SQLserver.CmdTemplate DBcmd_TP = null;
        public static HssUtility.SQLserver.CmdTemplate Get_cmdTP()
        {
            if (Schedule_Of_Fees_Per_Rate.DBcmd_TP != null) return Schedule_Of_Fees_Per_Rate.DBcmd_TP;

            Schedule_Of_Fees_Per_Rate.DBcmd_TP = new HssUtility.SQLserver.CmdTemplate();
            Schedule_Of_Fees_Per_Rate.DBcmd_TP.tableName = "Schedule_Of_Fees_Per_Rate";
            Schedule_Of_Fees_Per_Rate.DBcmd_TP.schema = "dbo";

            Schedule_Of_Fees_Per_Rate.DBcmd_TP.AddColumn("Country");/*Optional 1*/
            Schedule_Of_Fees_Per_Rate.DBcmd_TP.AddColumn("Security_Type");/*Optional 2*/
            Schedule_Of_Fees_Per_Rate.DBcmd_TP.AddColumn("Depositary");
            Schedule_Of_Fees_Per_Rate.DBcmd_TP.AddColumn("WithholdingRate");/*Optional 4*/
            Schedule_Of_Fees_Per_Rate.DBcmd_TP.AddColumn("ADSC");/*Optional 5*/
            Schedule_Of_Fees_Per_Rate.DBcmd_TP.AddColumn("RateWithADSC");/*Optional 6*/
            Schedule_Of_Fees_Per_Rate.DBcmd_TP.AddColumn("EffectiveDate");/*Optional 7*/
            Schedule_Of_Fees_Per_Rate.DBcmd_TP.AddColumn("CreatedDate");/*Optional 8*/
            Schedule_Of_Fees_Per_Rate.DBcmd_TP.AddColumn("ImportBy");/*Optional 9*/

            return Schedule_Of_Fees_Per_Rate.DBcmd_TP;
        }

        public Schedule_Of_Fees_Per_Rate() { }
        public Schedule_Of_Fees_Per_Rate(string id) { this.pk_ID = id; }

        private string pk_ID; //primary key
        public string Country { get { return this.pk_ID; } }

        public readonly HssUtility.General.Attributes.String_attr Security_Type = new HssUtility.General.Attributes.String_attr();/*Optional 2*/
        public readonly HssUtility.General.Attributes.String_attr Depositary = new HssUtility.General.Attributes.String_attr();
        public readonly HssUtility.General.Attributes.Decimal_attr WithholdingRate = new HssUtility.General.Attributes.Decimal_attr();/*Optional 4*/
        public readonly HssUtility.General.Attributes.Decimal_attr ADSC = new HssUtility.General.Attributes.Decimal_attr();/*Optional 5*/
        public readonly HssUtility.General.Attributes.Decimal_attr RateWithADSC = new HssUtility.General.Attributes.Decimal_attr();/*Optional 6*/
        public readonly HssUtility.General.Attributes.DateTime_attr EffectiveDate = new HssUtility.General.Attributes.DateTime_attr();/*Optional 7*/
        public readonly HssUtility.General.Attributes.DateTime_attr CreatedDate = new HssUtility.General.Attributes.DateTime_attr();/*Optional 8*/
        public readonly HssUtility.General.Attributes.String_attr ImportBy = new HssUtility.General.Attributes.String_attr();/*Optional 9*/

        private Dictionary<string, HssUtility.General.Attributes.I_modelAttr> attr_dic = null;

        internal void Init_from_reader(HssUtility.SQLserver.DB_reader reader)
        {
            if (reader == null || reader.IsClosed) return;

            this.pk_ID = reader.GetString("Country");
            reader.GetString("Security_Type", this.Security_Type);/*Optional 2*/
            reader.GetString("Depositary", this.Depositary);
            reader.GetDecimal("WithholdingRate", this.WithholdingRate);/*Optional 4*/
            reader.GetDecimal("ADSC", this.ADSC);/*Optional 5*/
            reader.GetDecimal("RateWithADSC", this.RateWithADSC);/*Optional 6*/
            reader.GetDateTime("EffectiveDate", this.EffectiveDate);/*Optional 7*/
            reader.GetDateTime("CreatedDate", this.CreatedDate);/*Optional 8*/
            reader.GetString("ImportBy", this.ImportBy);/*Optional 9*/

            this.SyncWithDB();
        }

        /// <summary>
        /// Initialize object from DB
        /// </summary>
        public bool Init_from_DB()
        {
            if (string.IsNullOrEmpty(this.Country)) return false;

            HssUtility.SQLserver.DB_select db_sel = new HssUtility.SQLserver.DB_select(Schedule_Of_Fees_Per_Rate.Get_cmdTP());
            db_sel.tableName = "Schedule_Of_Fees_Per_Rate";
            HssUtility.SQLserver.SQL_relation rela = new HssUtility.SQLserver.SQL_relation("Country", HssUtility.General.RelationalOperator.Equals, this.Country);
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
            this.attr_dic.Add("Security_Type", this.Security_Type);/*Optional 2*/
            this.attr_dic.Add("Depositary", this.Depositary);
            this.attr_dic.Add("WithholdingRate", this.WithholdingRate);/*Optional 4*/
            this.attr_dic.Add("ADSC", this.ADSC);/*Optional 5*/
            this.attr_dic.Add("RateWithADSC", this.RateWithADSC);/*Optional 6*/
            this.attr_dic.Add("EffectiveDate", this.EffectiveDate);/*Optional 7*/
            this.attr_dic.Add("CreatedDate", this.CreatedDate);/*Optional 8*/
            this.attr_dic.Add("ImportBy", this.ImportBy);/*Optional 9*/
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
            HssUtility.SQLserver.DB_insert dbIns = new HssUtility.SQLserver.DB_insert(Schedule_Of_Fees_Per_Rate.Get_cmdTP());

            dbIns.AddValue("Security_Type", this.Security_Type);/*Optional 2*/
            dbIns.AddValue("Depositary", this.Depositary);
            dbIns.AddValue("WithholdingRate", this.WithholdingRate);/*Optional 4*/
            dbIns.AddValue("ADSC", this.ADSC);/*Optional 5*/
            dbIns.AddValue("RateWithADSC", this.RateWithADSC);/*Optional 6*/
            dbIns.AddValue("EffectiveDate", this.EffectiveDate);/*Optional 7*/
            dbIns.AddValue("CreatedDate", this.CreatedDate);/*Optional 8*/
            dbIns.AddValue("ImportBy", this.ImportBy);/*Optional 9*/

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

            HssUtility.SQLserver.DB_update upd = new HssUtility.SQLserver.DB_update(Schedule_Of_Fees_Per_Rate.Get_cmdTP());
            if (this.Security_Type.ValueChanged) upd.AddValue("Security_Type", this.Security_Type);/*Optional 2*/
            if (this.Depositary.ValueChanged) upd.AddValue("Depositary", this.Depositary);
            if (this.WithholdingRate.ValueChanged) upd.AddValue("WithholdingRate", this.WithholdingRate);/*Optional 4*/
            if (this.ADSC.ValueChanged) upd.AddValue("ADSC", this.ADSC);/*Optional 5*/
            if (this.RateWithADSC.ValueChanged) upd.AddValue("RateWithADSC", this.RateWithADSC);/*Optional 6*/
            if (this.EffectiveDate.ValueChanged) upd.AddValue("EffectiveDate", this.EffectiveDate);/*Optional 7*/
            if (this.CreatedDate.ValueChanged) upd.AddValue("CreatedDate", this.CreatedDate);/*Optional 8*/
            if (this.ImportBy.ValueChanged) upd.AddValue("ImportBy", this.ImportBy);/*Optional 9*/

            HssUtility.SQLserver.SQL_relation rela = new HssUtility.SQLserver.SQL_relation("Country", HssUtility.General.RelationalOperator.Equals, this.pk_ID);
            upd.SetCondition(rela);

            return upd;
        }

        public Schedule_Of_Fees_Per_Rate GetCopy()
        {
            Schedule_Of_Fees_Per_Rate newEntity = new Schedule_Of_Fees_Per_Rate();
            if (!this.Security_Type.IsNull_flag) newEntity.Security_Type.Value = this.Security_Type.Value;
            if (!this.Depositary.IsNull_flag) newEntity.Depositary.Value = this.Depositary.Value;
            if (!this.WithholdingRate.IsNull_flag) newEntity.WithholdingRate.Value = this.WithholdingRate.Value;
            if (!this.ADSC.IsNull_flag) newEntity.ADSC.Value = this.ADSC.Value;
            if (!this.RateWithADSC.IsNull_flag) newEntity.RateWithADSC.Value = this.RateWithADSC.Value;
            if (!this.EffectiveDate.IsNull_flag) newEntity.EffectiveDate.Value = this.EffectiveDate.Value;
            if (!this.CreatedDate.IsNull_flag) newEntity.CreatedDate.Value = this.CreatedDate.Value;
            if (!this.ImportBy.IsNull_flag) newEntity.ImportBy.Value = this.ImportBy.Value;
            return newEntity;
        }

        public string ToXML()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("<Schedule_Of_Fees_Per_Rate>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Country>").Append(this.Country).Append("</Country>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Security_Type>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.Security_Type.Value)).Append("</Security_Type>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Depositary>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.Depositary.Value)).Append("</Depositary>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<WithholdingRate>").Append(this.WithholdingRate.Value).Append("</WithholdingRate>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<ADSC>").Append(this.ADSC.Value).Append("</ADSC>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<RateWithADSC>").Append(this.RateWithADSC.Value).Append("</RateWithADSC>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<EffectiveDate>").Append(this.EffectiveDate.Value).Append("</EffectiveDate>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<CreatedDate>").Append(this.CreatedDate.Value).Append("</CreatedDate>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<ImportBy>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.ImportBy.Value)).Append("</ImportBy>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("</Schedule_Of_Fees_Per_Rate>").Append(HssUtility.General.HssStr.WinNextLine);
            return sb.ToString();
        }
        /*^^^^^^^^^^^^^^^^^^^^^^^^^^^^^Hss Entity Framework Auto Generated Code^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^*/
    }
}
