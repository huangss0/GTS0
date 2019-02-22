using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HssDARWIN.Models.Tasks
{
    public class ADR_Member_Country
    {
        /*-----------------------------Hss Entity Framework Auto Generated Code-------------------------------*/
        private static HssUtility.SQLserver.CmdTemplate DBcmd_TP = null;
        public static HssUtility.SQLserver.CmdTemplate Get_cmdTP()
        {
            if (ADR_Member_Country.DBcmd_TP != null) return ADR_Member_Country.DBcmd_TP;

            ADR_Member_Country.DBcmd_TP = new HssUtility.SQLserver.CmdTemplate();
            ADR_Member_Country.DBcmd_TP.tableName = "ADR_Member_Country";
            ADR_Member_Country.DBcmd_TP.schema = "dbo";

            ADR_Member_Country.DBcmd_TP.AddColumn("ID");
            ADR_Member_Country.DBcmd_TP.AddColumn("TaskOwner_SID");
            ADR_Member_Country.DBcmd_TP.AddColumn("ISO2CntryCode");

            return ADR_Member_Country.DBcmd_TP;
        }

        public ADR_Member_Country() { }
        public ADR_Member_Country(int id) { this.pk_ID = id; }

        private int pk_ID = -1; //primary key
        public int ID { get { return this.pk_ID; } }

        public readonly HssUtility.General.Attributes.String_attr TaskOwner_SID = new HssUtility.General.Attributes.String_attr();
        public readonly HssUtility.General.Attributes.String_attr ISO2CntryCode = new HssUtility.General.Attributes.String_attr();

        private List<HssUtility.General.Attributes.I_modelAttr> attrList = null;

        internal void Init_from_reader(HssUtility.SQLserver.DB_reader reader)
        {
            if (reader == null || reader.IsClosed) return;

            this.pk_ID = reader.GetInt("ID");
            reader.GetString("TaskOwner_SID", this.TaskOwner_SID);
            reader.GetString("ISO2CntryCode", this.ISO2CntryCode);

            this.SyncWithDB();
        }

        /// <summary>
        /// Initialize object from DB
        /// </summary>
        public bool Init_from_DB()
        {
            if (this.ID < 0) return false;

            HssUtility.SQLserver.DB_select db_sel = new HssUtility.SQLserver.DB_select(ADR_Member_Country.Get_cmdTP());
            db_sel.tableName = "ADR_Member_Country";
            HssUtility.SQLserver.SQL_relation rela = new HssUtility.SQLserver.SQL_relation("ID", HssUtility.General.RelationalOperator.Equals, this.ID);
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
            this.attrList.Add(this.TaskOwner_SID);
            this.attrList.Add(this.ISO2CntryCode);
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
            HssUtility.SQLserver.DB_insert dbIns = new HssUtility.SQLserver.DB_insert(ADR_Member_Country.Get_cmdTP());

            dbIns.AddValue("TaskOwner_SID", this.TaskOwner_SID.Value);
            dbIns.AddValue("ISO2CntryCode", this.ISO2CntryCode.Value);

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

            HssUtility.SQLserver.DB_update upd = new HssUtility.SQLserver.DB_update(ADR_Member_Country.Get_cmdTP());
            if (this.TaskOwner_SID.ValueChanged) upd.AddValue("TaskOwner_SID", this.TaskOwner_SID);
            if (this.ISO2CntryCode.ValueChanged) upd.AddValue("ISO2CntryCode", this.ISO2CntryCode);

            HssUtility.SQLserver.SQL_relation rela = new HssUtility.SQLserver.SQL_relation("ID", HssUtility.General.RelationalOperator.Equals, this.pk_ID);
            upd.SetCondition(rela);

            return upd;
        }

        public ADR_Member_Country GetCopy()
        {
            ADR_Member_Country newEntity = new ADR_Member_Country();
            if (!this.TaskOwner_SID.IsNull_flag) newEntity.TaskOwner_SID.Value = this.TaskOwner_SID.Value;
            if (!this.ISO2CntryCode.IsNull_flag) newEntity.ISO2CntryCode.Value = this.ISO2CntryCode.Value;
            return newEntity;
        }

        public string ToXML()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("<ADR_Member_Country>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<ID>").Append(this.ID).Append("</ID>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<TaskOwner_SID>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.TaskOwner_SID.Value)).Append("</TaskOwner_SID>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<ISO2CntryCode>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.ISO2CntryCode.Value)).Append("</ISO2CntryCode>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("</ADR_Member_Country>").Append(HssUtility.General.HssStr.WinNextLine);
            return sb.ToString();
        }
        /*^^^^^^^^^^^^^^^^^^^^^^^^^^^^^Hss Entity Framework Auto Generated Code^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^*/
    }
}
