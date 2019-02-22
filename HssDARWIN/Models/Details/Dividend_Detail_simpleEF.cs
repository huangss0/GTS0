using System;
using System.Collections.Generic;

using HssDARWIN.Models.Dividends;

namespace HssDARWIN.Models.Details
{
    /// <summary>
    /// Dividend_Detail for Election File
    /// </summary>
    public class Dividend_Detail_simpleEF
    {
        /*-----------------------------Hss Entity Framework Auto Generated Code-------------------------------*/
        private static HssUtility.SQLserver.CmdTemplate DBcmd_TP = null;
        public static HssUtility.SQLserver.CmdTemplate Get_cmdTP()
        {
            if (Dividend_Detail_simpleEF.DBcmd_TP != null) return Dividend_Detail_simpleEF.DBcmd_TP;

            Dividend_Detail_simpleEF.DBcmd_TP = new HssUtility.SQLserver.CmdTemplate();
            Dividend_Detail_simpleEF.DBcmd_TP.tableName = "Dividend_Detail";

            Dividend_Detail_simpleEF.DBcmd_TP.AddColumn("DetailID");
            //Dividend_Detail_simpleEF.DBcmd_TP.AddColumn("DividendIndex");
            Dividend_Detail_simpleEF.DBcmd_TP.AddColumn("DTC_Number");
            //Dividend_Detail_simpleEF.DBcmd_TP.AddColumn("Depositary");/*Optional 10*/
            Dividend_Detail_simpleEF.DBcmd_TP.AddColumn("BO_COR");/*Optional 18*/
            Dividend_Detail_simpleEF.DBcmd_TP.AddColumn("BO_EntityType");/*Optional 19*/
            Dividend_Detail_simpleEF.DBcmd_TP.AddColumn("ReclaimRate");/*Optional 22*/
            Dividend_Detail_simpleEF.DBcmd_TP.AddColumn("CustodianID");/*Optional 25*/
            Dividend_Detail_simpleEF.DBcmd_TP.AddColumn("Status");/*Optional 27*/
            Dividend_Detail_simpleEF.DBcmd_TP.AddColumn("RecordDatePosition");/*Optional 30*/
            Dividend_Detail_simpleEF.DBcmd_TP.AddColumn("ReclaimFeesType");/*Optional 41*/
            Dividend_Detail_simpleEF.DBcmd_TP.AddColumn("PaidViaDTCC");/*Optional 120*/

            return Dividend_Detail_simpleEF.DBcmd_TP;
        }

        public Dividend_Detail_simpleEF() { }
        public Dividend_Detail_simpleEF(int id) { this.pk_ID = id; }

        private int pk_ID = -1; //primary key
        public int DetailID { get { return this.pk_ID; } }

        //public readonly HssUtility.General.Attributes.Int_attr DividendIndex = new HssUtility.General.Attributes.Int_attr();
        public readonly HssUtility.General.Attributes.String_attr DTC_Number = new HssUtility.General.Attributes.String_attr();
        //public readonly HssUtility.General.Attributes.String_attr Depositary = new HssUtility.General.Attributes.String_attr();/*Optional 10*/
        public readonly HssUtility.General.Attributes.String_attr BO_COR = new HssUtility.General.Attributes.String_attr();/*Optional 18*/
        public readonly HssUtility.General.Attributes.String_attr BO_EntityType = new HssUtility.General.Attributes.String_attr();/*Optional 19*/
        public readonly HssUtility.General.Attributes.Decimal_attr ReclaimRate = new HssUtility.General.Attributes.Decimal_attr();/*Optional 22*/
        public readonly HssUtility.General.Attributes.Int_attr CustodianID = new HssUtility.General.Attributes.Int_attr();/*Optional 25*/
        public readonly HssUtility.General.Attributes.String_attr Status = new HssUtility.General.Attributes.String_attr();/*Optional 27*/
        public readonly HssUtility.General.Attributes.Decimal_attr RecordDatePosition = new HssUtility.General.Attributes.Decimal_attr(0);/*Optional 30*/
        public readonly HssUtility.General.Attributes.String_attr ReclaimFeesType = new HssUtility.General.Attributes.String_attr();/*Optional 41*/
        public readonly HssUtility.General.Attributes.Bool_attr PaidViaDTCC = new HssUtility.General.Attributes.Bool_attr();/*Optional 120*/

        private Dictionary<string, HssUtility.General.Attributes.I_modelAttr> attr_dic = null;

        internal void Init_from_reader(HssUtility.SQLserver.DB_reader reader)
        {
            if (reader == null || reader.IsClosed) return;

            this.pk_ID = reader.GetInt("DetailID");
            //reader.GetInt("DividendIndex", this.DividendIndex);
            reader.GetString("DTC_Number", this.DTC_Number);
            //reader.GetString("Depositary", this.Depositary);/*Optional 10*/
            reader.GetString("BO_COR", this.BO_COR);/*Optional 18*/
            reader.GetString("BO_EntityType", this.BO_EntityType);/*Optional 19*/
            reader.GetDecimal("ReclaimRate", this.ReclaimRate);/*Optional 22*/
            reader.GetInt("CustodianID", this.CustodianID);/*Optional 25*/
            reader.GetString("Status", this.Status);/*Optional 27*/
            reader.GetDecimal("RecordDatePosition", this.RecordDatePosition);/*Optional 30*/
            reader.GetString("ReclaimFeesType", this.ReclaimFeesType);/*Optional 41*/
            reader.GetBool("PaidViaDTCC", this.PaidViaDTCC);/*Optional 120*/

            this.SyncWithDB();
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
            //this.attr_dic.Add("DividendIndex", this.DividendIndex);
            this.attr_dic.Add("DTC_Number", this.DTC_Number);
            //this.attr_dic.Add("Depositary", this.Depositary);/*Optional 10*/
            this.attr_dic.Add("BO_COR", this.BO_COR);/*Optional 18*/
            this.attr_dic.Add("BO_EntityType", this.BO_EntityType);/*Optional 19*/
            this.attr_dic.Add("ReclaimRate", this.ReclaimRate);/*Optional 22*/
            this.attr_dic.Add("CustodianID", this.CustodianID);/*Optional 25*/
            this.attr_dic.Add("Status", this.Status);/*Optional 27*/
            this.attr_dic.Add("RecordDatePosition", this.RecordDatePosition);/*Optional 30*/            
            this.attr_dic.Add("ReclaimFeesType", this.ReclaimFeesType);/*Optional 41*/           
            this.attr_dic.Add("PaidViaDTCC", this.PaidViaDTCC);/*Optional 120*/
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
            HssUtility.SQLserver.DB_insert dbIns = new HssUtility.SQLserver.DB_insert(Dividend_Detail_full.Get_cmdTP());

            //dbIns.AddValue("DividendIndex", this.DividendIndex.Value);
            dbIns.AddValue("DTC_Number", this.DTC_Number.Value);
            //dbIns.AddValue("Depositary", this.Depositary);/*Optional 10*/
            dbIns.AddValue("BO_COR", this.BO_COR);/*Optional 18*/
            dbIns.AddValue("BO_EntityType", this.BO_EntityType);/*Optional 19*/
            dbIns.AddValue("ReclaimRate", this.ReclaimRate);/*Optional 22*/
            dbIns.AddValue("CustodianID", this.CustodianID);/*Optional 25*/
            dbIns.AddValue("Status", this.Status);/*Optional 27*/
            dbIns.AddValue("RecordDatePosition", this.RecordDatePosition);/*Optional 30*/
            dbIns.AddValue("ReclaimFeesType", this.ReclaimFeesType);/*Optional 41*/
            dbIns.AddValue("PaidViaDTCC", this.PaidViaDTCC);/*Optional 120*/

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

            HssUtility.SQLserver.DB_update upd = new HssUtility.SQLserver.DB_update(Dividend_Detail_full.Get_cmdTP());
            //if (this.DividendIndex.ValueChanged) upd.AddValue("DividendIndex", this.DividendIndex);
            if (this.DTC_Number.ValueChanged) upd.AddValue("DTC_Number", this.DTC_Number);
            //if (this.Depositary.ValueChanged) upd.AddValue("Depositary", this.Depositary);/*Optional 10*/
            if (this.BO_COR.ValueChanged) upd.AddValue("BO_COR", this.BO_COR);/*Optional 18*/
            if (this.BO_EntityType.ValueChanged) upd.AddValue("BO_EntityType", this.BO_EntityType);/*Optional 19*/
            if (this.ReclaimRate.ValueChanged) upd.AddValue("ReclaimRate", this.ReclaimRate);/*Optional 22*/
            if (this.CustodianID.ValueChanged) upd.AddValue("CustodianID", this.CustodianID);/*Optional 25*/
            if (this.Status.ValueChanged) upd.AddValue("Status", this.Status);/*Optional 27*/
            if (this.RecordDatePosition.ValueChanged) upd.AddValue("RecordDatePosition", this.RecordDatePosition);/*Optional 30*/
            if (this.ReclaimFeesType.ValueChanged) upd.AddValue("ReclaimFeesType", this.ReclaimFeesType);/*Optional 41*/
            if (this.PaidViaDTCC.ValueChanged) upd.AddValue("PaidViaDTCC", this.PaidViaDTCC);/*Optional 120*/

            HssUtility.SQLserver.SQL_relation rela = new HssUtility.SQLserver.SQL_relation("DetailID", HssUtility.General.RelationalOperator.Equals, this.pk_ID);
            upd.SetCondition(rela);

            return upd;
        }
        /*^^^^^^^^^^^^^^^^^^^^^^^^^^^^^Hss Entity Framework Auto Generated Code^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^*/

        public decimal Get_WHrate(Dividend dvd)
        {
            if (dvd == null) return -1;

            if (this.BO_COR.Value.Equals("JP", StringComparison.OrdinalIgnoreCase))
            {
                if (this.BO_EntityType.Value.Equals("IND", StringComparison.OrdinalIgnoreCase))
                {
                    if (dvd.DTCPosition_ModelNumber.Value == 59 ||
                        dvd.DTCPosition_ModelNumber.Value == 58 ||
                        dvd.DTCPosition_ModelNumber.Value == 40) return 0.20315m;
                    if (dvd.DTCPosition_ModelNumber.Value == 10) return 0.10147m;
                }
            }

            if (dvd.Country.Value.Equals("Japan", StringComparison.OrdinalIgnoreCase))
            {                
                if (this.BO_EntityType.Value.Equals("TXE", StringComparison.OrdinalIgnoreCase)) return 0.2042m;
            }            

            return dvd.StatutoryRate.Value - this.ReclaimRate.Value;
        }
    }
}
