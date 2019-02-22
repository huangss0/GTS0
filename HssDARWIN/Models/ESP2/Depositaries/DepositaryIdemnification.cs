using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using HssDARWIN.Models.Depositaries;

namespace HssDARWIN.Models.ESP2.Depositaries
{
    public class DepositaryIdemnification
    {
        /*Hss Entity Framework Auto Generated Code*/
        private static HssUtility.SQLserver.CmdTemplate DBcmd_TP = null;
        public static HssUtility.SQLserver.CmdTemplate Get_cmdTP()
        {
            if (DepositaryIdemnification.DBcmd_TP != null) return DepositaryIdemnification.DBcmd_TP;

            DepositaryIdemnification.DBcmd_TP = new HssUtility.SQLserver.CmdTemplate();
            DepositaryIdemnification.DBcmd_TP.tableName = "DepositaryIdemnification";
            DepositaryIdemnification.DBcmd_TP.schema = "dbo";

            DepositaryIdemnification.DBcmd_TP.AddColumn("depositary_idemnification_id");
            DepositaryIdemnification.DBcmd_TP.AddColumn("depositary_info_id");
            DepositaryIdemnification.DBcmd_TP.AddColumn("language_id");
            DepositaryIdemnification.DBcmd_TP.AddColumn("idemnification");
            DepositaryIdemnification.DBcmd_TP.AddColumn("idemnification2");
            DepositaryIdemnification.DBcmd_TP.AddColumn("idemnification_di");
            DepositaryIdemnification.DBcmd_TP.AddColumn("idemnification2_di");
            DepositaryIdemnification.DBcmd_TP.AddColumn("idemnification_russia");/*Optional 8*/

            return DepositaryIdemnification.DBcmd_TP;
        }

        public DepositaryIdemnification() { }
        public DepositaryIdemnification(int id) { this.pk_ID = id; }

        private int pk_ID = -1; //primary key
        public int depositary_idemnification_id { get { return this.pk_ID; } }

        public readonly HssUtility.General.Attributes.Int_attr depositary_info_id = new HssUtility.General.Attributes.Int_attr(-1);
        public readonly HssUtility.General.Attributes.Int_attr language_id = new HssUtility.General.Attributes.Int_attr(1);
        public readonly HssUtility.General.Attributes.String_attr idemnification = new HssUtility.General.Attributes.String_attr("");
        public readonly HssUtility.General.Attributes.String_attr idemnification2 = new HssUtility.General.Attributes.String_attr("");
        public readonly HssUtility.General.Attributes.String_attr idemnification_di = new HssUtility.General.Attributes.String_attr("");
        public readonly HssUtility.General.Attributes.String_attr idemnification2_di = new HssUtility.General.Attributes.String_attr("");
        public readonly HssUtility.General.Attributes.String_attr idemnification_russia = new HssUtility.General.Attributes.String_attr("");/*Optional 8*/

        private List<HssUtility.General.Attributes.I_modelAttr> attrList = null;

        internal void Init_from_reader(HssUtility.SQLserver.DB_reader reader)
        {
            if (reader == null || reader.IsClosed) return;

            this.pk_ID = reader.GetInt("depositary_idemnification_id");
            this.depositary_info_id.Value = reader.GetInt("depositary_info_id");
            this.language_id.Value = reader.GetInt("language_id");
            this.idemnification.Value = reader.GetString("idemnification");
            this.idemnification2.Value = reader.GetString("idemnification2");
            this.idemnification_di.Value = reader.GetString("idemnification_di");
            this.idemnification2_di.Value = reader.GetString("idemnification2_di");
            this.idemnification_russia.Value = reader.GetString("idemnification_russia");/*Optional 8*/

            this.SyncWithDB();
        }

        public bool Init_from_DB()
        {
            if (this.depositary_idemnification_id < 0) return false;

            HssUtility.SQLserver.DB_select db_sel = new HssUtility.SQLserver.DB_select(DepositaryIdemnification.Get_cmdTP());
            db_sel.tableName = "DepositaryIdemnification";
            HssUtility.SQLserver.SQL_relation rela = new HssUtility.SQLserver.SQL_relation("depositary_idemnification_id", HssUtility.General.RelationalOperator.Equals, this.depositary_idemnification_id);
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
            this.attrList.Add(this.depositary_info_id);
            this.attrList.Add(this.language_id);
            this.attrList.Add(this.idemnification);
            this.attrList.Add(this.idemnification2);
            this.attrList.Add(this.idemnification_di);
            this.attrList.Add(this.idemnification2_di);
            this.attrList.Add(this.idemnification_russia);/*Optional 8*/
        }

        public bool Insert_to_DB()
        {
            HssUtility.SQLserver.DB_insert ins = this.Get_DBinsert();
            int count = ins.SaveToDB(Utility.Get_ESP2_hDB());
            return count > 0;
        }

        internal HssUtility.SQLserver.DB_insert Get_DBinsert()
        {
            HssUtility.SQLserver.DB_insert dbIns = new HssUtility.SQLserver.DB_insert(DepositaryIdemnification.Get_cmdTP());
            dbIns.AddValue("depositary_info_id", this.depositary_info_id.Value);
            dbIns.AddValue("language_id", this.language_id.Value);
            dbIns.AddValue("idemnification", this.idemnification.Value);
            dbIns.AddValue("idemnification2", this.idemnification2.Value);
            dbIns.AddValue("idemnification_di", this.idemnification_di.Value);
            dbIns.AddValue("idemnification2_di", this.idemnification2_di.Value);
            dbIns.AddValue("idemnification_russia", this.idemnification_russia.Value);/*Optional 8*/
            return dbIns;
        }
        /*^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^*/

        public void Init_from_DRWIN_depo(Depositary depo)
        {
            if (depo == null) return;

            this.idemnification.Value = depo.ESP_Idemnification.Value;
            this.idemnification2.Value = depo.ESP_Idemnification2.Value;
            this.idemnification_di.Value = depo.ESP_Idemnification_DI.Value;
            this.idemnification2_di.Value = depo.ESP_Idemnification2_DI.Value;
            this.idemnification_russia.Value = depo.ESP_Idemnification_RUSSIA.Value;
        }
    }
}
