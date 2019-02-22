using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HssDARWIN.Models.Tasks
{
    public class ADR_Group_Member
    {
        /*-----------------------------Hss Entity Framework Auto Generated Code-------------------------------*/
        private static HssUtility.SQLserver.CmdTemplate DBcmd_TP = null;
        public static HssUtility.SQLserver.CmdTemplate Get_cmdTP()
        {
            if (ADR_Group_Member.DBcmd_TP != null) return ADR_Group_Member.DBcmd_TP;

            ADR_Group_Member.DBcmd_TP = new HssUtility.SQLserver.CmdTemplate();
            ADR_Group_Member.DBcmd_TP.tableName = "ADR_Group_Member";
            ADR_Group_Member.DBcmd_TP.schema = "dbo";

            ADR_Group_Member.DBcmd_TP.AddColumn("ID");
            ADR_Group_Member.DBcmd_TP.AddColumn("GroupID");
            ADR_Group_Member.DBcmd_TP.AddColumn("OwnerSID");

            return ADR_Group_Member.DBcmd_TP;
        }

        public ADR_Group_Member() { }
        public ADR_Group_Member(int id) { this.pk_ID = id; }

        private int pk_ID = -1; //primary key
        public int ID { get { return this.pk_ID; } }

        public readonly HssUtility.General.Attributes.Int_attr GroupID = new HssUtility.General.Attributes.Int_attr();
        public readonly HssUtility.General.Attributes.String_attr OwnerSID = new HssUtility.General.Attributes.String_attr();

        private List<HssUtility.General.Attributes.I_modelAttr> attrList = null;

        internal void Init_from_reader(HssUtility.SQLserver.DB_reader reader)
        {
            if (reader == null || reader.IsClosed) return;

            this.pk_ID = reader.GetInt("ID");
            reader.GetInt("GroupID", this.GroupID);
            reader.GetString("OwnerSID", this.OwnerSID);

            this.SyncWithDB();
        }

        /// <summary>
        /// Initialize object from DB
        /// </summary>
        public bool Init_from_DB()
        {
            if (this.ID < 0) return false;

            HssUtility.SQLserver.DB_select db_sel = new HssUtility.SQLserver.DB_select(ADR_Group_Member.Get_cmdTP());
            db_sel.tableName = "ADR_Group_Member";
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
            this.attrList.Add(this.GroupID);
            this.attrList.Add(this.OwnerSID);
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
            HssUtility.SQLserver.DB_insert dbIns = new HssUtility.SQLserver.DB_insert(ADR_Group_Member.Get_cmdTP());

            dbIns.AddValue("GroupID", this.GroupID.Value);
            dbIns.AddValue("OwnerSID", this.OwnerSID.Value);

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

            HssUtility.SQLserver.DB_update upd = new HssUtility.SQLserver.DB_update(ADR_Group_Member.Get_cmdTP());
            if (this.GroupID.ValueChanged) upd.AddValue("GroupID", this.GroupID);
            if (this.OwnerSID.ValueChanged) upd.AddValue("OwnerSID", this.OwnerSID);

            HssUtility.SQLserver.SQL_relation rela = new HssUtility.SQLserver.SQL_relation("ID", HssUtility.General.RelationalOperator.Equals, this.pk_ID);
            upd.SetCondition(rela);

            return upd;
        }

        public ADR_Group_Member GetCopy()
        {
            ADR_Group_Member newEntity = new ADR_Group_Member();
            if (!this.GroupID.IsNull_flag) newEntity.GroupID.Value = this.GroupID.Value;
            if (!this.OwnerSID.IsNull_flag) newEntity.OwnerSID.Value = this.OwnerSID.Value;
            return newEntity;
        }

        public string ToXML()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("<ADR_Group_Member>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<ID>").Append(this.ID).Append("</ID>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<GroupID>").Append(this.GroupID.Value).Append("</GroupID>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<OwnerSID>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.OwnerSID.Value)).Append("</OwnerSID>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("</ADR_Group_Member>").Append(HssUtility.General.HssStr.WinNextLine);
            return sb.ToString();
        }
        /*^^^^^^^^^^^^^^^^^^^^^^^^^^^^^Hss Entity Framework Auto Generated Code^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^*/
    }
}
