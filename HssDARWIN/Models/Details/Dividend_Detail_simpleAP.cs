using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HssDARWIN.Models.Details
{
    /// <summary>
    /// Dividend_Detail for Auto-Proration
    /// </summary>
    public class Dividend_Detail_simpleAP
    {
        /*-----------------------------Hss Entity Framework Auto Generated Code-------------------------------*/
        private static HssUtility.SQLserver.CmdTemplate DBcmd_TP = null;
        public static HssUtility.SQLserver.CmdTemplate Get_cmdTP()
        {
            if (Dividend_Detail_simpleAP.DBcmd_TP != null) return Dividend_Detail_simpleAP.DBcmd_TP;

            Dividend_Detail_simpleAP.DBcmd_TP = new HssUtility.SQLserver.CmdTemplate();
            Dividend_Detail_simpleAP.DBcmd_TP.tableName = "Dividend_Detail";

            Dividend_Detail_simpleAP.DBcmd_TP.AddColumn("DetailID");
            Dividend_Detail_simpleAP.DBcmd_TP.AddColumn("DTC_Number");
            Dividend_Detail_simpleAP.DBcmd_TP.AddColumn("CustodianID");/*Optional 25*/
            Dividend_Detail_simpleAP.DBcmd_TP.AddColumn("Status");/*Optional 27*/
            Dividend_Detail_simpleAP.DBcmd_TP.AddColumn("RecordDatePosition");/*Optional 30*/
            Dividend_Detail_simpleAP.DBcmd_TP.AddColumn("Dividend_FilingID");/*Optional 37*/

            return Dividend_Detail_simpleAP.DBcmd_TP;
        }

        public Dividend_Detail_simpleAP() { }
        public Dividend_Detail_simpleAP(int id) { this.pk_ID = id; }

        private int pk_ID = -1; //primary key
        public int DetailID { get { return this.pk_ID; } }
        
        public readonly HssUtility.General.Attributes.String_attr DTC_Number = new HssUtility.General.Attributes.String_attr();
        public readonly HssUtility.General.Attributes.Int_attr CustodianID = new HssUtility.General.Attributes.Int_attr();/*Optional 25*/
        public readonly HssUtility.General.Attributes.String_attr Status = new HssUtility.General.Attributes.String_attr();/*Optional 27*/
        public readonly HssUtility.General.Attributes.Decimal_attr RecordDatePosition = new HssUtility.General.Attributes.Decimal_attr(0);/*Optional 30*/
        public readonly HssUtility.General.Attributes.Int_attr Dividend_FilingID = new HssUtility.General.Attributes.Int_attr();/*Optional 37*/

        private Dictionary<string, HssUtility.General.Attributes.I_modelAttr> attr_dic = null;

        internal void Init_from_reader(HssUtility.SQLserver.DB_reader reader)
        {
            if (reader == null || reader.IsClosed) return;

            this.pk_ID = reader.GetInt("DetailID");
            reader.GetString("DTC_Number", this.DTC_Number);
            reader.GetInt("CustodianID", this.CustodianID);/*Optional 25*/
            reader.GetString("Status", this.Status);/*Optional 27*/
            reader.GetDecimal("RecordDatePosition", this.RecordDatePosition);/*Optional 30*/
            reader.GetInt("Dividend_FilingID", this.Dividend_FilingID);/*Optional 37*/

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
            this.attr_dic.Add("DTC_Number", this.DTC_Number);
            this.attr_dic.Add("Status", this.Status);/*Optional 27*/
            this.attr_dic.Add("RecordDatePosition", this.RecordDatePosition);/*Optional 30*/
            this.attr_dic.Add("Dividend_FilingID", this.Dividend_FilingID);/*Optional 37*/
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
            
            dbIns.AddValue("DTC_Number", this.DTC_Number.Value);
            dbIns.AddValue("Status", this.Status);/*Optional 27*/
            dbIns.AddValue("RecordDatePosition", this.RecordDatePosition);/*Optional 30*/
            dbIns.AddValue("Dividend_FilingID", this.Dividend_FilingID);/*Optional 37*/

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
            if (this.DTC_Number.ValueChanged) upd.AddValue("DTC_Number", this.DTC_Number);
            if (this.CustodianID.ValueChanged) upd.AddValue("CustodianID", this.CustodianID);/*Optional 25*/
            if (this.Status.ValueChanged) upd.AddValue("Status", this.Status);/*Optional 27*/
            if (this.RecordDatePosition.ValueChanged) upd.AddValue("RecordDatePosition", this.RecordDatePosition);/*Optional 30*/
            if (this.Dividend_FilingID.ValueChanged) upd.AddValue("Dividend_FilingID", this.Dividend_FilingID);/*Optional 37*/

            HssUtility.SQLserver.SQL_relation rela = new HssUtility.SQLserver.SQL_relation("DetailID", HssUtility.General.RelationalOperator.Equals, this.pk_ID);
            upd.SetCondition(rela);

            return upd;
        }
        /*^^^^^^^^^^^^^^^^^^^^^^^^^^^^^Hss Entity Framework Auto Generated Code^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^*/
    }
}
