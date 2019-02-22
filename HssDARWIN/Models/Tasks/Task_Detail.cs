using System;
using System.Collections.Generic;
using System.Text;

using HssUtility.Forms.Attribute;

namespace HssDARWIN.Models.Tasks
{
    public class Task_Detail
    {
        /*-----------------------------Hss Entity Framework Auto Generated Code-------------------------------*/
        private static HssUtility.SQLserver.CmdTemplate DBcmd_TP = null;
        public static HssUtility.SQLserver.CmdTemplate Get_cmdTP()
        {
            if (Task_Detail.DBcmd_TP != null) return Task_Detail.DBcmd_TP;

            Task_Detail.DBcmd_TP = new HssUtility.SQLserver.CmdTemplate();
            Task_Detail.DBcmd_TP.tableName = "Task_Detail";
            Task_Detail.DBcmd_TP.schema = "Task";

            Task_Detail.DBcmd_TP.AddColumn("TaskDetailID");
            Task_Detail.DBcmd_TP.AddColumn("TaskID");
            Task_Detail.DBcmd_TP.AddColumn("TaskName");/*Optional 3*/
            Task_Detail.DBcmd_TP.AddColumn("Country");/*Optional 4*/
            Task_Detail.DBcmd_TP.AddColumn("Depositary");/*Optional 5*/
            Task_Detail.DBcmd_TP.AddColumn("Issue");/*Optional 6*/
            Task_Detail.DBcmd_TP.AddColumn("CUSIP");/*Optional 7*/
            Task_Detail.DBcmd_TP.AddColumn("RecordDate");/*Optional 8*/
            Task_Detail.DBcmd_TP.AddColumn("SourceTable");/*Optional 9*/
            Task_Detail.DBcmd_TP.AddColumn("SourceID");/*Optional 10*/
            Task_Detail.DBcmd_TP.AddColumn("StartDate");/*Optional 11*/
            Task_Detail.DBcmd_TP.AddColumn("PriorityDate");/*Optional 12*/
            Task_Detail.DBcmd_TP.AddColumn("EndDate");/*Optional 13*/
            Task_Detail.DBcmd_TP.AddColumn("Notes");/*Optional 14*/
            Task_Detail.DBcmd_TP.AddColumn("Priority");/*Optional 15*/
            Task_Detail.DBcmd_TP.AddColumn("Completed");/*Optional 16*/
            Task_Detail.DBcmd_TP.AddColumn("CreatedBy");/*Optional 17*/
            Task_Detail.DBcmd_TP.AddColumn("CreatedDateTime");/*Optional 18*/
            Task_Detail.DBcmd_TP.AddColumn("CompletedBy");/*Optional 19*/
            Task_Detail.DBcmd_TP.AddColumn("CompletedDateTime");/*Optional 20*/
            Task_Detail.DBcmd_TP.AddColumn("LastModifiedBy");/*Optional 21*/
            Task_Detail.DBcmd_TP.AddColumn("LastModifiedDateTime");/*Optional 22*/

            return Task_Detail.DBcmd_TP;
        }

        public Task_Detail() { }
        public Task_Detail(int id) { this.pk_ID = id; }

        private int pk_ID = -1; //primary key
        public int TaskDetailID { get { return this.pk_ID; } }

        public readonly HssUtility.General.Attributes.Int_attr TaskID = new HssUtility.General.Attributes.Int_attr();
        public readonly HssUtility.General.Attributes.String_attr TaskName = new HssUtility.General.Attributes.String_attr();/*Optional 3*/
        public readonly HssUtility.General.Attributes.String_attr Country = new HssUtility.General.Attributes.String_attr();/*Optional 4*/
        public readonly HssUtility.General.Attributes.String_attr Depositary = new HssUtility.General.Attributes.String_attr();/*Optional 5*/
        public readonly HssUtility.General.Attributes.String_attr Issue = new HssUtility.General.Attributes.String_attr();/*Optional 6*/
        public readonly HssUtility.General.Attributes.String_attr CUSIP = new HssUtility.General.Attributes.String_attr();/*Optional 7*/
        public readonly HssUtility.General.Attributes.DateTime_attr RecordDate = new HssUtility.General.Attributes.DateTime_attr();/*Optional 8*/
        public readonly HssUtility.General.Attributes.String_attr SourceTable = new HssUtility.General.Attributes.String_attr();/*Optional 9*/
        public readonly HssUtility.General.Attributes.String_attr SourceID = new HssUtility.General.Attributes.String_attr();/*Optional 10*/
        public readonly HssUtility.General.Attributes.DateTime_attr StartDate = new HssUtility.General.Attributes.DateTime_attr();/*Optional 11*/
        public readonly HssUtility.General.Attributes.DateTime_attr PriorityDate = new HssUtility.General.Attributes.DateTime_attr();/*Optional 12*/
        public readonly HssUtility.General.Attributes.DateTime_attr EndDate = new HssUtility.General.Attributes.DateTime_attr();/*Optional 13*/
        public readonly HssUtility.General.Attributes.String_attr Notes = new HssUtility.General.Attributes.String_attr();/*Optional 14*/
        public readonly HssUtility.General.Attributes.Int_attr Priority = new HssUtility.General.Attributes.Int_attr();/*Optional 15*/
        public readonly HssUtility.General.Attributes.Bool_attr Completed = new HssUtility.General.Attributes.Bool_attr(false);/*Optional 16*/
        public readonly HssUtility.General.Attributes.String_attr CreatedBy = new HssUtility.General.Attributes.String_attr();/*Optional 17*/
        public readonly HssUtility.General.Attributes.DateTime_attr CreatedDateTime = new HssUtility.General.Attributes.DateTime_attr();/*Optional 18*/
        public readonly HssUtility.General.Attributes.String_attr CompletedBy = new HssUtility.General.Attributes.String_attr();/*Optional 19*/
        public readonly HssUtility.General.Attributes.DateTime_attr CompletedDateTime = new HssUtility.General.Attributes.DateTime_attr();/*Optional 20*/
        public readonly HssUtility.General.Attributes.String_attr LastModifiedBy = new HssUtility.General.Attributes.String_attr();/*Optional 21*/
        public readonly HssUtility.General.Attributes.DateTime_attr LastModifiedDateTime = new HssUtility.General.Attributes.DateTime_attr();/*Optional 22*/

        private List<HssUtility.General.Attributes.I_modelAttr> attrList = null;

        internal void Init_from_reader(HssUtility.SQLserver.DB_reader reader)
        {
            if (reader == null || reader.IsClosed) return;

            this.pk_ID = reader.GetInt("TaskDetailID");
            reader.GetInt("TaskID", this.TaskID);
            reader.GetString("TaskName", this.TaskName);/*Optional 3*/
            reader.GetString("Country", this.Country);/*Optional 4*/
            reader.GetString("Depositary", this.Depositary);/*Optional 5*/
            reader.GetString("Issue", this.Issue);/*Optional 6*/
            reader.GetString("CUSIP", this.CUSIP);/*Optional 7*/
            reader.GetDateTime("RecordDate", this.RecordDate);/*Optional 8*/
            reader.GetString("SourceTable", this.SourceTable);/*Optional 9*/
            reader.GetString("SourceID", this.SourceID);/*Optional 10*/
            reader.GetDateTime("StartDate", this.StartDate);/*Optional 11*/
            reader.GetDateTime("PriorityDate", this.PriorityDate);/*Optional 12*/
            reader.GetDateTime("EndDate", this.EndDate);/*Optional 13*/
            reader.GetString("Notes", this.Notes);/*Optional 14*/
            reader.GetInt("Priority", this.Priority);/*Optional 15*/
            reader.GetBool("Completed", this.Completed);/*Optional 16*/
            reader.GetString("CreatedBy", this.CreatedBy);/*Optional 17*/
            reader.GetDateTime("CreatedDateTime", this.CreatedDateTime);/*Optional 18*/
            reader.GetString("CompletedBy", this.CompletedBy);/*Optional 19*/
            reader.GetDateTime("CompletedDateTime", this.CompletedDateTime);/*Optional 20*/
            reader.GetString("LastModifiedBy", this.LastModifiedBy);/*Optional 21*/
            reader.GetDateTime("LastModifiedDateTime", this.LastModifiedDateTime);/*Optional 22*/

            this.SyncWithDB();
        }

        /// <summary>
        /// Initialize object from DB
        /// </summary>
        public bool Init_from_DB()
        {
            if (this.TaskDetailID < 0) return false;

            HssUtility.SQLserver.DB_select db_sel = new HssUtility.SQLserver.DB_select(Task_Detail.Get_cmdTP());
            db_sel.tableName = "Task_Detail";
            HssUtility.SQLserver.SQL_relation rela = new HssUtility.SQLserver.SQL_relation("TaskDetailID", HssUtility.General.RelationalOperator.Equals, this.TaskDetailID);
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
            this.attrList.Add(this.TaskID);
            this.attrList.Add(this.TaskName);/*Optional 3*/
            this.attrList.Add(this.Country);/*Optional 4*/
            this.attrList.Add(this.Depositary);/*Optional 5*/
            this.attrList.Add(this.Issue);/*Optional 6*/
            this.attrList.Add(this.CUSIP);/*Optional 7*/
            this.attrList.Add(this.RecordDate);/*Optional 8*/
            this.attrList.Add(this.SourceTable);/*Optional 9*/
            this.attrList.Add(this.SourceID);/*Optional 10*/
            this.attrList.Add(this.StartDate);/*Optional 11*/
            this.attrList.Add(this.PriorityDate);/*Optional 12*/
            this.attrList.Add(this.EndDate);/*Optional 13*/
            this.attrList.Add(this.Notes);/*Optional 14*/
            this.attrList.Add(this.Priority);/*Optional 15*/
            this.attrList.Add(this.Completed);/*Optional 16*/
            this.attrList.Add(this.CreatedBy);/*Optional 17*/
            this.attrList.Add(this.CreatedDateTime);/*Optional 18*/
            this.attrList.Add(this.CompletedBy);/*Optional 19*/
            this.attrList.Add(this.CompletedDateTime);/*Optional 20*/
            this.attrList.Add(this.LastModifiedBy);/*Optional 21*/
            this.attrList.Add(this.LastModifiedDateTime);/*Optional 22*/
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
            this.LastModifiedBy.Value = Utility.CurrentUser;
            this.LastModifiedDateTime.Value = DateTime.Now;
            this.CreatedBy.Value = Utility.CurrentUser;
            this.CreatedDateTime.Value = DateTime.Now;

            HssUtility.SQLserver.DB_insert dbIns = new HssUtility.SQLserver.DB_insert(Task_Detail.Get_cmdTP());
            dbIns.AddValue("TaskID", this.TaskID.Value);
            dbIns.AddValue("TaskName", this.TaskName);/*Optional 3*/
            dbIns.AddValue("Country", this.Country);/*Optional 4*/
            dbIns.AddValue("Depositary", this.Depositary);/*Optional 5*/
            dbIns.AddValue("Issue", this.Issue);/*Optional 6*/
            dbIns.AddValue("CUSIP", this.CUSIP);/*Optional 7*/
            dbIns.AddValue("RecordDate", this.RecordDate);/*Optional 8*/
            dbIns.AddValue("SourceTable", this.SourceTable);/*Optional 9*/
            dbIns.AddValue("SourceID", this.SourceID);/*Optional 10*/
            dbIns.AddValue("StartDate", this.StartDate);/*Optional 11*/
            dbIns.AddValue("PriorityDate", this.PriorityDate);/*Optional 12*/
            dbIns.AddValue("EndDate", this.EndDate);/*Optional 13*/
            dbIns.AddValue("Notes", this.Notes);/*Optional 14*/
            dbIns.AddValue("Priority", this.Priority);/*Optional 15*/
            dbIns.AddValue("Completed", this.Completed);/*Optional 16*/
            dbIns.AddValue("CreatedBy", this.CreatedBy);/*Optional 17*/
            dbIns.AddValue("CreatedDateTime", this.CreatedDateTime);/*Optional 18*/
            dbIns.AddValue("CompletedBy", this.CompletedBy);/*Optional 19*/
            dbIns.AddValue("CompletedDateTime", this.CompletedDateTime);/*Optional 20*/
            dbIns.AddValue("LastModifiedBy", this.LastModifiedBy);/*Optional 21*/
            dbIns.AddValue("LastModifiedDateTime", this.LastModifiedDateTime);/*Optional 22*/
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
            else
            {
                this.LastModifiedBy.Value = Utility.CurrentUser;
                this.LastModifiedDateTime.Value = DateTime.Now;
            }

            HssUtility.SQLserver.DB_update upd = new HssUtility.SQLserver.DB_update(Task_Detail.Get_cmdTP());
            if (this.TaskID.ValueChanged) upd.AddValue("TaskID", this.TaskID);
            if (this.TaskName.ValueChanged) upd.AddValue("TaskName", this.TaskName);
            if (this.Country.ValueChanged) upd.AddValue("Country", this.Country);
            if (this.Depositary.ValueChanged) upd.AddValue("Depositary", this.Depositary);
            if (this.Issue.ValueChanged) upd.AddValue("Issue", this.Issue);
            if (this.CUSIP.ValueChanged) upd.AddValue("CUSIP", this.CUSIP);
            if (this.RecordDate.ValueChanged) upd.AddValue("RecordDate", this.RecordDate);
            if (this.SourceTable.ValueChanged) upd.AddValue("SourceTable", this.SourceTable);
            if (this.SourceID.ValueChanged) upd.AddValue("SourceID", this.SourceID);
            if (this.StartDate.ValueChanged) upd.AddValue("StartDate", this.StartDate);
            if (this.PriorityDate.ValueChanged) upd.AddValue("PriorityDate", this.PriorityDate);
            if (this.EndDate.ValueChanged) upd.AddValue("EndDate", this.EndDate);
            if (this.Notes.ValueChanged) upd.AddValue("Notes", this.Notes);
            if (this.Priority.ValueChanged) upd.AddValue("Priority", this.Priority);
            if (this.Completed.ValueChanged) upd.AddValue("Completed", this.Completed);
            if (this.CreatedBy.ValueChanged) upd.AddValue("CreatedBy", this.CreatedBy);
            if (this.CreatedDateTime.ValueChanged) upd.AddValue("CreatedDateTime", this.CreatedDateTime);
            if (this.CompletedBy.ValueChanged) upd.AddValue("CompletedBy", this.CompletedBy);
            if (this.CompletedDateTime.ValueChanged) upd.AddValue("CompletedDateTime", this.CompletedDateTime);
            if (this.LastModifiedBy.ValueChanged) upd.AddValue("LastModifiedBy", this.LastModifiedBy);
            if (this.LastModifiedDateTime.ValueChanged) upd.AddValue("LastModifiedDateTime", this.LastModifiedDateTime);

            HssUtility.SQLserver.SQL_relation rela = new HssUtility.SQLserver.SQL_relation("TaskDetailID", HssUtility.General.RelationalOperator.Equals, this.pk_ID);
            upd.SetCondition(rela);

            return upd;
        }

        public Task_Detail GetCopy()
        {
            Task_Detail newEntity = new Task_Detail();
            if (!this.TaskID.IsNull_flag) newEntity.TaskID.Value = this.TaskID.Value;
            if (!this.TaskName.IsNull_flag) newEntity.TaskName.Value = this.TaskName.Value;
            if (!this.Country.IsNull_flag) newEntity.Country.Value = this.Country.Value;
            if (!this.Depositary.IsNull_flag) newEntity.Depositary.Value = this.Depositary.Value;
            if (!this.Issue.IsNull_flag) newEntity.Issue.Value = this.Issue.Value;
            if (!this.CUSIP.IsNull_flag) newEntity.CUSIP.Value = this.CUSIP.Value;
            if (!this.RecordDate.IsNull_flag) newEntity.RecordDate.Value = this.RecordDate.Value;
            if (!this.SourceTable.IsNull_flag) newEntity.SourceTable.Value = this.SourceTable.Value;
            if (!this.SourceID.IsNull_flag) newEntity.SourceID.Value = this.SourceID.Value;
            if (!this.StartDate.IsNull_flag) newEntity.StartDate.Value = this.StartDate.Value;
            if (!this.PriorityDate.IsNull_flag) newEntity.PriorityDate.Value = this.PriorityDate.Value;
            if (!this.EndDate.IsNull_flag) newEntity.EndDate.Value = this.EndDate.Value;
            if (!this.Notes.IsNull_flag) newEntity.Notes.Value = this.Notes.Value;
            if (!this.Priority.IsNull_flag) newEntity.Priority.Value = this.Priority.Value;
            if (!this.Completed.IsNull_flag) newEntity.Completed.Value = this.Completed.Value;
            if (!this.CreatedBy.IsNull_flag) newEntity.CreatedBy.Value = this.CreatedBy.Value;
            if (!this.CreatedDateTime.IsNull_flag) newEntity.CreatedDateTime.Value = this.CreatedDateTime.Value;
            if (!this.CompletedBy.IsNull_flag) newEntity.CompletedBy.Value = this.CompletedBy.Value;
            if (!this.CompletedDateTime.IsNull_flag) newEntity.CompletedDateTime.Value = this.CompletedDateTime.Value;
            if (!this.LastModifiedBy.IsNull_flag) newEntity.LastModifiedBy.Value = this.LastModifiedBy.Value;
            if (!this.LastModifiedDateTime.IsNull_flag) newEntity.LastModifiedDateTime.Value = this.LastModifiedDateTime.Value;
            return newEntity;
        }

        public string ToXML()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("<Task_Detail>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<TaskDetailID>").Append(this.TaskDetailID).Append("</TaskDetailID>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<TaskID>").Append(this.TaskID.Value).Append("</TaskID>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<TaskName>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.TaskName.Value)).Append("</TaskName>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Country>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.Country.Value)).Append("</Country>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Depositary>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.Depositary.Value)).Append("</Depositary>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Issue>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.Issue.Value)).Append("</Issue>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<CUSIP>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.CUSIP.Value)).Append("</CUSIP>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<RecordDate>").Append(this.RecordDate.Value).Append("</RecordDate>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<SourceTable>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.SourceTable.Value)).Append("</SourceTable>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<SourceID>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.SourceID.Value)).Append("</SourceID>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<StartDate>").Append(this.StartDate.Value).Append("</StartDate>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<PriorityDate>").Append(this.PriorityDate.Value).Append("</PriorityDate>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<EndDate>").Append(this.EndDate.Value).Append("</EndDate>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Notes>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.Notes.Value)).Append("</Notes>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Priority>").Append(this.Priority.Value).Append("</Priority>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Completed>").Append(this.Completed.Value).Append("</Completed>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<CreatedBy>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.CreatedBy.Value)).Append("</CreatedBy>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<CreatedDateTime>").Append(this.CreatedDateTime.Value).Append("</CreatedDateTime>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<CompletedBy>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.CompletedBy.Value)).Append("</CompletedBy>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<CompletedDateTime>").Append(this.CompletedDateTime.Value).Append("</CompletedDateTime>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<LastModifiedBy>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.LastModifiedBy.Value)).Append("</LastModifiedBy>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<LastModifiedDateTime>").Append(this.LastModifiedDateTime.Value).Append("</LastModifiedDateTime>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("</Task_Detail>").Append(HssUtility.General.HssStr.WinNextLine);
            return sb.ToString();
        }
        /*^^^^^^^^^^^^^^^^^^^^^^^^^^^^^Hss Entity Framework Auto Generated Code^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^*/

        public Models_viewForm GetEditForm()
        {
            Models_viewForm mvf = new Models_viewForm();
            mvf.Text = "Task_Detail";
            mvf.Set_pk_label("TaskDetailID: " + this.TaskDetailID);

            bool readOnly_flag = (this.TaskID.Value != 17);

            mvf.Add_Control(new StrAttr_UserControl("TaskName", this.TaskName, readOnly_flag));
            mvf.Add_Control(new StrAttr_UserControl("Country", this.Country, readOnly_flag));
            mvf.Add_Control(new StrAttr_UserControl("Depositary", this.Depositary, readOnly_flag));
            mvf.Add_Control(new StrAttr_UserControl("Issue", this.Issue, readOnly_flag));
            mvf.Add_Control(new StrAttr_UserControl("CUSIP", this.CUSIP, readOnly_flag));
            mvf.Add_Control(new DateTimeAttr_UserControl("RecordDate", this.RecordDate, readOnly_flag));
            mvf.Add_Control(new StrAttr_UserControl("SourceTable", this.SourceTable, readOnly_flag));
            mvf.Add_Control(new StrAttr_UserControl("SourceID", this.SourceID, readOnly_flag));
            mvf.Add_Control(new DateTimeAttr_UserControl("StartDate", this.StartDate));
            mvf.Add_Control(new DateTimeAttr_UserControl("PriorityDate", this.PriorityDate, readOnly_flag));
            mvf.Add_Control(new DateTimeAttr_UserControl("EndDate", this.EndDate));
            mvf.Add_Control(new StrAttr_UserControl("Notes", this.Notes));
            mvf.Add_Control(new StrAttr_UserControl("Priority", this.Priority, readOnly_flag));
            mvf.Add_Control(new BoolAttr_UserControl("Completed", this.Completed));
            mvf.Add_Control(new StrAttr_UserControl("CreatedBy", this.CreatedBy, true));
            mvf.Add_Control(new DateTimeAttr_UserControl("CreatedDateTime", this.CreatedDateTime, true));
            mvf.Add_Control(new StrAttr_UserControl("CompletedBy", this.CompletedBy, true));
            mvf.Add_Control(new DateTimeAttr_UserControl("CompletedDateTime", this.CompletedDateTime, true));
            mvf.Add_Control(new StrAttr_UserControl("LastModifiedBy", this.LastModifiedBy, true));
            mvf.Add_Control(new DateTimeAttr_UserControl("LastModifiedDateTime", this.LastModifiedDateTime, true));

            mvf.SaveModel_func = this.Save_to_DB;
            return mvf;
        }

        public bool Save_to_DB()
        {
            if (this.Completed.ValueChanged && this.Completed.Value == true)
            {
                this.CompletedBy.Value = Utility.CurrentUser;
                this.CompletedDateTime.Value = DateTime.Now;
            }

            if (this.pk_ID > 0) return this.Update_to_DB();
            else return this.Insert_to_DB();
        }
    }
}
