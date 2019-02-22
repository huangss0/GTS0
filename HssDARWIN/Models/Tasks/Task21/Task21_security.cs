using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HssDARWIN.Models.Tasks.Task21
{
    public class Task21_security
    {
        /*-----------------------------Hss Entity Framework Auto Generated Code-------------------------------*/
        private static HssUtility.SQLserver.CmdTemplate DBcmd_TP = null;
        public static HssUtility.SQLserver.CmdTemplate Get_cmdTP()
        {
            if (Task21_security.DBcmd_TP != null) return Task21_security.DBcmd_TP;

            Task21_security.DBcmd_TP = new HssUtility.SQLserver.CmdTemplate();
            Task21_security.DBcmd_TP.tableName = "Task_21";
            Task21_security.DBcmd_TP.schema = "Task";

            Task21_security.DBcmd_TP.AddColumn("ID");
            Task21_security.DBcmd_TP.AddColumn("SecurityID");/*Optional 2*/
            Task21_security.DBcmd_TP.AddColumn("TaskName");/*Optional 3*/
            Task21_security.DBcmd_TP.AddColumn("Status");/*Optional 4*/
            Task21_security.DBcmd_TP.AddColumn("ValueStr");/*Optional 5*/
            Task21_security.DBcmd_TP.AddColumn("CreateBy");/*Optional 6*/
            Task21_security.DBcmd_TP.AddColumn("CreateDate");/*Optional 7*/

            return Task21_security.DBcmd_TP;
        }

        public Task21_security() { }
        public Task21_security(int id) { this.pk_ID = id; }
 
        private int pk_ID = -1; //primary key
        public int ID { get { return this.pk_ID; } }

        public readonly HssUtility.General.Attributes.Int_attr SecurityID = new HssUtility.General.Attributes.Int_attr();/*Optional 2*/
        public readonly HssUtility.General.Attributes.String_attr TaskName = new HssUtility.General.Attributes.String_attr();/*Optional 3*/
        public readonly HssUtility.General.Attributes.String_attr Status = new HssUtility.General.Attributes.String_attr();/*Optional 4*/
        public readonly HssUtility.General.Attributes.String_attr ValueStr = new HssUtility.General.Attributes.String_attr();/*Optional 5*/
        public readonly HssUtility.General.Attributes.String_attr CreateBy = new HssUtility.General.Attributes.String_attr(Utility.CurrentUser);/*Optional 6*/
        public readonly HssUtility.General.Attributes.DateTime_attr CreateDate = new HssUtility.General.Attributes.DateTime_attr();/*Optional 7*/

        private List<HssUtility.General.Attributes.I_modelAttr> attrList = null;

        internal void Init_from_reader(HssUtility.SQLserver.DB_reader reader)
        {
            if (reader == null || reader.IsClosed) return;

            this.pk_ID = reader.GetInt("ID");
            reader.GetInt("SecurityID", this.SecurityID);/*Optional 2*/
            reader.GetString("TaskName", this.TaskName);/*Optional 3*/
            reader.GetString("Status", this.Status);/*Optional 4*/
            reader.GetString("ValueStr", this.ValueStr);/*Optional 5*/
            reader.GetString("CreateBy", this.CreateBy);/*Optional 6*/
            reader.GetDateTime("CreateDate", this.CreateDate);/*Optional 7*/

            this.SyncWithDB();
        }

        /// <summary>
        /// Initialize object from DB
        /// </summary>
        public bool Init_from_DB()
        {
            if (this.ID < 0) return false;

            HssUtility.SQLserver.DB_select db_sel = new HssUtility.SQLserver.DB_select(Task21_security.Get_cmdTP());
            db_sel.tableName = "Task_21";
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
            this.attrList.Add(this.SecurityID);/*Optional 2*/
            this.attrList.Add(this.TaskName);/*Optional 3*/
            this.attrList.Add(this.Status);/*Optional 4*/
            this.attrList.Add(this.ValueStr);/*Optional 5*/
            this.attrList.Add(this.CreateBy);/*Optional 6*/
            this.attrList.Add(this.CreateDate);/*Optional 7*/
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
            HssUtility.SQLserver.DB_insert dbIns = new HssUtility.SQLserver.DB_insert(Task21_security.Get_cmdTP());

            dbIns.AddValue("SecurityID", this.SecurityID);/*Optional 2*/
            dbIns.AddValue("TaskName", this.TaskName);/*Optional 3*/
            dbIns.AddValue("Status", this.Status);/*Optional 4*/
            dbIns.AddValue("ValueStr", this.ValueStr);/*Optional 5*/
            dbIns.AddValue("CreateBy", this.CreateBy);/*Optional 6*/
            dbIns.AddValue("CreateDate", this.CreateDate);/*Optional 7*/

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

            HssUtility.SQLserver.DB_update upd = new HssUtility.SQLserver.DB_update(Task21_security.Get_cmdTP());
            if (this.SecurityID.ValueChanged) upd.AddValue("SecurityID", this.SecurityID);
            if (this.TaskName.ValueChanged) upd.AddValue("TaskName", this.TaskName);
            if (this.Status.ValueChanged) upd.AddValue("Status", this.Status);
            if (this.ValueStr.ValueChanged) upd.AddValue("ValueStr", this.ValueStr);
            if (this.CreateBy.ValueChanged) upd.AddValue("CreateBy", this.CreateBy);
            if (this.CreateDate.ValueChanged) upd.AddValue("CreateDate", this.CreateDate);

            HssUtility.SQLserver.SQL_relation rela = new HssUtility.SQLserver.SQL_relation("ID", HssUtility.General.RelationalOperator.Equals, this.pk_ID);
            upd.SetCondition(rela);

            return upd;
        }

        public Task21_security GetCopy()
        {
            Task21_security newEntity = new Task21_security();
            if (!this.SecurityID.IsNull_flag) newEntity.SecurityID.Value = this.SecurityID.Value;
            if (!this.TaskName.IsNull_flag) newEntity.TaskName.Value = this.TaskName.Value;
            if (!this.Status.IsNull_flag) newEntity.Status.Value = this.Status.Value;
            if (!this.ValueStr.IsNull_flag) newEntity.ValueStr.Value = this.ValueStr.Value;
            if (!this.CreateBy.IsNull_flag) newEntity.CreateBy.Value = this.CreateBy.Value;
            if (!this.CreateDate.IsNull_flag) newEntity.CreateDate.Value = this.CreateDate.Value;
            return newEntity;
        }

        public string ToXML()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("<Task_21_security>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<ID>").Append(this.ID).Append("</ID>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<SecurityID>").Append(this.SecurityID.Value).Append("</SecurityID>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<TaskName>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.TaskName.Value)).Append("</TaskName>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Status>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.Status.Value)).Append("</Status>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<ValueStr>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.ValueStr.Value)).Append("</ValueStr>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<CreateBy>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.CreateBy.Value)).Append("</CreateBy>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<CreateDate>").Append(this.CreateDate.Value).Append("</CreateDate>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("</Task_21_security>").Append(HssUtility.General.HssStr.WinNextLine);
            return sb.ToString();
        }
        /*^^^^^^^^^^^^^^^^^^^^^^^^^^^^^Hss Entity Framework Auto Generated Code^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^*/

        public HssUtility.General.HssStatus Get_status()
        {
            return HssUtility.General.Helper_hssStatus.Str_to_Status(this.Status.Value);
        }

        public void Set_status( HssUtility.General.HssStatus st)
        {
            this.Status.Value = st.ToString();
        }

        public bool Delete_from_DB()
        {
            if (this.ID < 0) return false;

            HssUtility.SQLserver.DB_delete del = new HssUtility.SQLserver.DB_delete();
            del.schema = "Task";
            del.tableName = "Task_21";
            HssUtility.SQLserver.SQL_relation rela = new HssUtility.SQLserver.SQL_relation("ID",HssUtility.General. RelationalOperator.Equals, this.ID);
            del.SetCondition(rela);

            int count = del.SaveToDB(Utility.Get_DRWIN_hDB());
            return count > 0;
        }
    }
}
