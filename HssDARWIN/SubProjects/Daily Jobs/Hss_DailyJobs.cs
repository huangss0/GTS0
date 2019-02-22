using System;
using System.Collections.Generic;
using System.Text;

using HssUtility.Forms.Attribute;

namespace HssDARWIN.SubProjects.Daily_Jobs
{
    public class Hss_DailyJobs
    {
        /*-----------------------------Hss Entity Framework Auto Generated Code-------------------------------*/
        private static HssUtility.SQLserver.CmdTemplate DBcmd_TP = null;
        public static HssUtility.SQLserver.CmdTemplate Get_cmdTP()
        {
            if (Hss_DailyJobs.DBcmd_TP != null) return Hss_DailyJobs.DBcmd_TP;

            Hss_DailyJobs.DBcmd_TP = new HssUtility.SQLserver.CmdTemplate();
            Hss_DailyJobs.DBcmd_TP.tableName = "Hss_DailyJobs";
            Hss_DailyJobs.DBcmd_TP.schema = "Task";

            Hss_DailyJobs.DBcmd_TP.AddColumn("ID");
            Hss_DailyJobs.DBcmd_TP.AddColumn("Job_Class");/*Optional 2*/
            Hss_DailyJobs.DBcmd_TP.AddColumn("Job_ID");/*Optional 3*/
            Hss_DailyJobs.DBcmd_TP.AddColumn("LastRunAt");/*Optional 4*/
            Hss_DailyJobs.DBcmd_TP.AddColumn("LastRunBy");/*Optional 5*/
            Hss_DailyJobs.DBcmd_TP.AddColumn("Locked");/*Optional 6*/
            Hss_DailyJobs.DBcmd_TP.AddColumn("Notes");/*Optional 7*/
            Hss_DailyJobs.DBcmd_TP.AddColumn("LastLockAt");/*Optional 8*/
            Hss_DailyJobs.DBcmd_TP.AddColumn("LastLockBy");/*Optional 9*/

            return Hss_DailyJobs.DBcmd_TP;
        }

        public Hss_DailyJobs() { }
        public Hss_DailyJobs(int id) { this.pk_ID = id; }

        private int pk_ID = -1; //primary key
        public int ID { get { return this.pk_ID; } }

        public readonly HssUtility.General.Attributes.String_attr Job_Class = new HssUtility.General.Attributes.String_attr();/*Optional 2*/
        public readonly HssUtility.General.Attributes.Int_attr Job_ID = new HssUtility.General.Attributes.Int_attr();/*Optional 3*/
        public readonly HssUtility.General.Attributes.DateTime_attr LastRunAt = new HssUtility.General.Attributes.DateTime_attr();/*Optional 4*/
        public readonly HssUtility.General.Attributes.String_attr LastRunBy = new HssUtility.General.Attributes.String_attr();/*Optional 5*/
        public readonly HssUtility.General.Attributes.Bool_attr Locked = new HssUtility.General.Attributes.Bool_attr();/*Optional 6*/
        public readonly HssUtility.General.Attributes.String_attr Notes = new HssUtility.General.Attributes.String_attr();/*Optional 7*/
        public readonly HssUtility.General.Attributes.DateTime_attr LastLockAt = new HssUtility.General.Attributes.DateTime_attr();/*Optional 8*/
        public readonly HssUtility.General.Attributes.String_attr LastLockBy = new HssUtility.General.Attributes.String_attr();/*Optional 9*/

        private Dictionary<string, HssUtility.General.Attributes.I_modelAttr> attr_dic = null;

        internal void Init_from_reader(HssUtility.SQLserver.DB_reader reader)
        {
            if (reader == null || reader.IsClosed) return;

            this.pk_ID = reader.GetInt("ID");
            reader.GetString("Job_Class", this.Job_Class);/*Optional 2*/
            reader.GetInt("Job_ID", this.Job_ID);/*Optional 3*/
            reader.GetDateTime("LastRunAt", this.LastRunAt);/*Optional 4*/
            reader.GetString("LastRunBy", this.LastRunBy);/*Optional 5*/
            reader.GetBool("Locked", this.Locked);/*Optional 6*/
            reader.GetString("Notes", this.Notes);/*Optional 7*/
            reader.GetDateTime("LastLockAt", this.LastLockAt);/*Optional 8*/
            reader.GetString("LastLockBy", this.LastLockBy);/*Optional 9*/

            this.SyncWithDB();
        }

        /// <summary>
        /// Initialize object from DB
        /// </summary>
        public bool Init_from_DB()
        {
            if (this.ID < 0) return false;

            HssUtility.SQLserver.DB_select db_sel = new HssUtility.SQLserver.DB_select(Hss_DailyJobs.Get_cmdTP());
            db_sel.tableName = "Hss_DailyJobs";
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
            this.attr_dic.Add("Job_Class", this.Job_Class);/*Optional 2*/
            this.attr_dic.Add("Job_ID", this.Job_ID);/*Optional 3*/
            this.attr_dic.Add("LastRunAt", this.LastRunAt);/*Optional 4*/
            this.attr_dic.Add("LastRunBy", this.LastRunBy);/*Optional 5*/
            this.attr_dic.Add("Locked", this.Locked);/*Optional 6*/
            this.attr_dic.Add("Notes", this.Notes);/*Optional 7*/
            this.attr_dic.Add("LastLockAt", this.LastLockAt);/*Optional 8*/
            this.attr_dic.Add("LastLockBy", this.LastLockBy);/*Optional 9*/
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
            HssUtility.SQLserver.DB_insert dbIns = new HssUtility.SQLserver.DB_insert(Hss_DailyJobs.Get_cmdTP());

            dbIns.AddValue("Job_Class", this.Job_Class);/*Optional 2*/
            dbIns.AddValue("Job_ID", this.Job_ID);/*Optional 3*/
            dbIns.AddValue("LastRunAt", this.LastRunAt);/*Optional 4*/
            dbIns.AddValue("LastRunBy", this.LastRunBy);/*Optional 5*/
            dbIns.AddValue("Locked", this.Locked);/*Optional 6*/
            dbIns.AddValue("Notes", this.Notes);/*Optional 7*/
            dbIns.AddValue("LastLockAt", this.LastLockAt);/*Optional 8*/
            dbIns.AddValue("LastLockBy", this.LastLockBy);/*Optional 9*/

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

            HssUtility.SQLserver.DB_update upd = new HssUtility.SQLserver.DB_update(Hss_DailyJobs.Get_cmdTP());
            if (this.Job_Class.ValueChanged) upd.AddValue("Job_Class", this.Job_Class);/*Optional 2*/
            if (this.Job_ID.ValueChanged) upd.AddValue("Job_ID", this.Job_ID);/*Optional 3*/
            if (this.LastRunAt.ValueChanged) upd.AddValue("LastRunAt", this.LastRunAt);/*Optional 4*/
            if (this.LastRunBy.ValueChanged) upd.AddValue("LastRunBy", this.LastRunBy);/*Optional 5*/
            if (this.Locked.ValueChanged) upd.AddValue("Locked", this.Locked);/*Optional 6*/
            if (this.Notes.ValueChanged) upd.AddValue("Notes", this.Notes);/*Optional 7*/
            if (this.LastLockAt.ValueChanged) upd.AddValue("LastLockAt", this.LastLockAt);/*Optional 8*/
            if (this.LastLockBy.ValueChanged) upd.AddValue("LastLockBy", this.LastLockBy);/*Optional 9*/

            HssUtility.SQLserver.SQL_relation rela = new HssUtility.SQLserver.SQL_relation("ID", HssUtility.General.RelationalOperator.Equals, this.pk_ID);
            upd.SetCondition(rela);

            return upd;
        }

        public Hss_DailyJobs GetCopy()
        {
            Hss_DailyJobs newEntity = new Hss_DailyJobs();
            if (!this.Job_Class.IsNull_flag) newEntity.Job_Class.Value = this.Job_Class.Value;
            if (!this.Job_ID.IsNull_flag) newEntity.Job_ID.Value = this.Job_ID.Value;
            if (!this.LastRunAt.IsNull_flag) newEntity.LastRunAt.Value = this.LastRunAt.Value;
            if (!this.LastRunBy.IsNull_flag) newEntity.LastRunBy.Value = this.LastRunBy.Value;
            if (!this.Locked.IsNull_flag) newEntity.Locked.Value = this.Locked.Value;
            if (!this.Notes.IsNull_flag) newEntity.Notes.Value = this.Notes.Value;
            if (!this.LastLockAt.IsNull_flag) newEntity.LastLockAt.Value = this.LastLockAt.Value;
            if (!this.LastLockBy.IsNull_flag) newEntity.LastLockBy.Value = this.LastLockBy.Value;
            return newEntity;
        }

        public string ToXML()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("<Hss_DailyJobs>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<ID>").Append(this.ID).Append("</ID>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Job_Class>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.Job_Class.Value)).Append("</Job_Class>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Job_ID>").Append(this.Job_ID.Value).Append("</Job_ID>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<LastRunAt>").Append(this.LastRunAt.Value).Append("</LastRunAt>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<LastRunBy>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.LastRunBy.Value)).Append("</LastRunBy>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Locked>").Append(this.Locked.Value).Append("</Locked>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Notes>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.Notes.Value)).Append("</Notes>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<LastLockAt>").Append(this.LastLockAt.Value).Append("</LastLockAt>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<LastLockBy>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.LastLockBy.Value)).Append("</LastLockBy>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("</Hss_DailyJobs>").Append(HssUtility.General.HssStr.WinNextLine);
            return sb.ToString();
        }
        /*^^^^^^^^^^^^^^^^^^^^^^^^^^^^^Hss Entity Framework Auto Generated Code^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^*/

        /// <summary>
        /// Lock or Unlock an record
        /// </summary>
        /// <param name="lock_flag">lock or unlock flag</param>
        /// <param name="success_flag">when unlock, indicate if it's successful</param>
        public bool UpdateRecordLock(bool lock_flag, bool success_flag = false)
        {
            HssUtility.SQLserver.DB_update upd = new HssUtility.SQLserver.DB_update(Hss_DailyJobs.Get_cmdTP());

            if (lock_flag)
            {
                upd.AddValue("LastLockAt", DateTime.Now);
                upd.AddValue("LastLockBy", Utility.CurrentUser);
            }
            else
            {
                if (success_flag)
                {
                    upd.AddValue("LastRunAt", DateTime.Now);
                    upd.AddValue("LastRunBy", Utility.CurrentUser);
                }
            }

            upd.AddValue("Locked", lock_flag);//set lock value

            HssUtility.SQLserver.SQL_relation rela0 = new HssUtility.SQLserver.SQL_relation("ID", HssUtility.General.RelationalOperator.Equals, this.pk_ID);
            HssUtility.SQLserver.SQL_relation rela1 = new HssUtility.SQLserver.SQL_relation("Locked", HssUtility.General.RelationalOperator.Equals, !lock_flag);
            HssUtility.SQLserver.SQL_condition cond = new HssUtility.SQLserver.SQL_condition(rela0, HssUtility.General.ConditionalOperator.And, rela1);
            upd.SetCondition(cond);

            int count = upd.SaveToDB(Utility.Get_DRWIN_hDB());
            bool flag = count > 0;

            return flag;
        }

        public Models_viewForm GetEditForm()
        {
            Models_viewForm mvf = new Models_viewForm();
            mvf.Text = "Hss_DailyJobs";
            mvf.Set_pk_label("ID: " + this.ID);

            mvf.Add_Control(new StrAttr_UserControl("Job_Class", this.Job_Class, true));
            mvf.Add_Control(new StrAttr_UserControl("Job_ID", this.Job_ID, true));
            mvf.Add_Control(new DateTimeAttr_UserControl("LastRunAt", this.LastRunAt));
            mvf.Add_Control(new StrAttr_UserControl("LastRunBy", this.LastRunBy));
            mvf.Add_Control(new BoolAttr_UserControl("Locked", this.Locked));            
            mvf.Add_Control(new StrAttr_UserControl("Notes", this.Notes));
            mvf.Add_Control(new DateTimeAttr_UserControl("LastLockAt", this.LastLockAt));
            mvf.Add_Control(new StrAttr_UserControl("LastLockBy", this.LastLockBy));

            mvf.SaveModel_func = this.Update_to_DB;
            return mvf;
        }
    }
}
