using System;
using System.Collections.Generic;
using System.Text;

namespace HssDARWIN.Models.Dividends
{
    public class Dividend_Control_Queue
    {
        /*-----------------------------Hss Entity Framework Auto Generated Code-------------------------------*/
        private static HssUtility.SQLserver.CmdTemplate DBcmd_TP = null;
        public static HssUtility.SQLserver.CmdTemplate Get_cmdTP()
        {
            if (Dividend_Control_Queue.DBcmd_TP != null) return Dividend_Control_Queue.DBcmd_TP;

            Dividend_Control_Queue.DBcmd_TP = new HssUtility.SQLserver.CmdTemplate();
            Dividend_Control_Queue.DBcmd_TP.tableName = "Dividend_Control_Queue";
            Dividend_Control_Queue.DBcmd_TP.schema = "dbo";

            Dividend_Control_Queue.DBcmd_TP.AddColumn("Queue_ID");
            Dividend_Control_Queue.DBcmd_TP.AddColumn("DividendIndex");
            Dividend_Control_Queue.DBcmd_TP.AddColumn("TabName");
            Dividend_Control_Queue.DBcmd_TP.AddColumn("FieldName");
            Dividend_Control_Queue.DBcmd_TP.AddColumn("ColumnName");
            Dividend_Control_Queue.DBcmd_TP.AddColumn("PreviousValue");/*Optional 6*/
            Dividend_Control_Queue.DBcmd_TP.AddColumn("NewValue");/*Optional 7*/
            Dividend_Control_Queue.DBcmd_TP.AddColumn("DataType");
            Dividend_Control_Queue.DBcmd_TP.AddColumn("UserID");
            Dividend_Control_Queue.DBcmd_TP.AddColumn("QueueDateTime");
            Dividend_Control_Queue.DBcmd_TP.AddColumn("Status");
            Dividend_Control_Queue.DBcmd_TP.AddColumn("ApprovedBy");
            Dividend_Control_Queue.DBcmd_TP.AddColumn("Event");/*Optional 13*/
            Dividend_Control_Queue.DBcmd_TP.AddColumn("Active");/*Optional 14*/

            return Dividend_Control_Queue.DBcmd_TP;
        }

        public Dividend_Control_Queue() { }
        public Dividend_Control_Queue(int id) { this.pk_ID = id; }

        private int pk_ID = -1; //primary key
        public int Queue_ID { get { return this.pk_ID; } }

        public readonly HssUtility.General.Attributes.Int_attr DividendIndex = new HssUtility.General.Attributes.Int_attr();
        public readonly HssUtility.General.Attributes.String_attr TabName = new HssUtility.General.Attributes.String_attr();
        public readonly HssUtility.General.Attributes.String_attr FieldName = new HssUtility.General.Attributes.String_attr();
        public readonly HssUtility.General.Attributes.String_attr ColumnName = new HssUtility.General.Attributes.String_attr();
        public readonly HssUtility.General.Attributes.String_attr PreviousValue = new HssUtility.General.Attributes.String_attr();/*Optional 6*/
        public readonly HssUtility.General.Attributes.String_attr NewValue = new HssUtility.General.Attributes.String_attr();/*Optional 7*/
        public readonly HssUtility.General.Attributes.String_attr DataType = new HssUtility.General.Attributes.String_attr();
        public readonly HssUtility.General.Attributes.String_attr UserID = new HssUtility.General.Attributes.String_attr();
        public readonly HssUtility.General.Attributes.DateTime_attr QueueDateTime = new HssUtility.General.Attributes.DateTime_attr();
        public readonly HssUtility.General.Attributes.String_attr Status = new HssUtility.General.Attributes.String_attr();
        public readonly HssUtility.General.Attributes.String_attr ApprovedBy = new HssUtility.General.Attributes.String_attr();
        public readonly HssUtility.General.Attributes.String_attr Event = new HssUtility.General.Attributes.String_attr();/*Optional 13*/
        public readonly HssUtility.General.Attributes.Bool_attr Active = new HssUtility.General.Attributes.Bool_attr();/*Optional 14*/

        private Dictionary<string, HssUtility.General.Attributes.I_modelAttr> attr_dic = null;

        internal void Init_from_reader(HssUtility.SQLserver.DB_reader reader)
        {
            if (reader == null || reader.IsClosed) return;

            this.pk_ID = reader.GetInt("Queue_ID");
            reader.GetInt("DividendIndex", this.DividendIndex);
            reader.GetString("TabName", this.TabName);
            reader.GetString("FieldName", this.FieldName);
            reader.GetString("ColumnName", this.ColumnName);
            reader.GetString("PreviousValue", this.PreviousValue);/*Optional 6*/
            reader.GetString("NewValue", this.NewValue);/*Optional 7*/
            reader.GetString("DataType", this.DataType);
            reader.GetString("UserID", this.UserID);
            reader.GetDateTime("QueueDateTime", this.QueueDateTime);
            reader.GetString("Status", this.Status);
            reader.GetString("ApprovedBy", this.ApprovedBy);
            reader.GetString("Event", this.Event);/*Optional 13*/
            reader.GetBool("Active", this.Active);/*Optional 14*/

            this.SyncWithDB();
        }

        /// <summary>
        /// Initialize object from DB
        /// </summary>
        public bool Init_from_DB()
        {
            if (this.Queue_ID < 0) return false;

            HssUtility.SQLserver.DB_select db_sel = new HssUtility.SQLserver.DB_select(Dividend_Control_Queue.Get_cmdTP());
            db_sel.tableName = "Dividend_Control_Queue";
            HssUtility.SQLserver.SQL_relation rela = new HssUtility.SQLserver.SQL_relation("Queue_ID", HssUtility.General.RelationalOperator.Equals, this.Queue_ID);
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
            this.attr_dic.Add("TabName", this.TabName);
            this.attr_dic.Add("FieldName", this.FieldName);
            this.attr_dic.Add("ColumnName", this.ColumnName);
            this.attr_dic.Add("PreviousValue", this.PreviousValue);/*Optional 6*/
            this.attr_dic.Add("NewValue", this.NewValue);/*Optional 7*/
            this.attr_dic.Add("DataType", this.DataType);
            this.attr_dic.Add("UserID", this.UserID);
            this.attr_dic.Add("QueueDateTime", this.QueueDateTime);
            this.attr_dic.Add("Status", this.Status);
            this.attr_dic.Add("ApprovedBy", this.ApprovedBy);
            this.attr_dic.Add("Event", this.Event);/*Optional 13*/
            this.attr_dic.Add("Active", this.Active);/*Optional 14*/
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
            HssUtility.SQLserver.DB_insert dbIns = new HssUtility.SQLserver.DB_insert(Dividend_Control_Queue.Get_cmdTP());

            dbIns.AddValue("DividendIndex", this.DividendIndex);
            dbIns.AddValue("TabName", this.TabName);
            dbIns.AddValue("FieldName", this.FieldName);
            dbIns.AddValue("ColumnName", this.ColumnName);
            dbIns.AddValue("PreviousValue", this.PreviousValue);/*Optional 6*/
            dbIns.AddValue("NewValue", this.NewValue);/*Optional 7*/
            dbIns.AddValue("DataType", this.DataType);
            dbIns.AddValue("UserID", this.UserID);
            dbIns.AddValue("QueueDateTime", this.QueueDateTime);
            dbIns.AddValue("Status", this.Status);
            dbIns.AddValue("ApprovedBy", this.ApprovedBy);
            dbIns.AddValue("Event", this.Event);/*Optional 13*/
            dbIns.AddValue("Active", this.Active);/*Optional 14*/

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

            HssUtility.SQLserver.DB_update upd = new HssUtility.SQLserver.DB_update(Dividend_Control_Queue.Get_cmdTP());
            if (this.DividendIndex.ValueChanged) upd.AddValue("DividendIndex", this.DividendIndex);
            if (this.TabName.ValueChanged) upd.AddValue("TabName", this.TabName);
            if (this.FieldName.ValueChanged) upd.AddValue("FieldName", this.FieldName);
            if (this.ColumnName.ValueChanged) upd.AddValue("ColumnName", this.ColumnName);
            if (this.PreviousValue.ValueChanged) upd.AddValue("PreviousValue", this.PreviousValue);/*Optional 6*/
            if (this.NewValue.ValueChanged) upd.AddValue("NewValue", this.NewValue);/*Optional 7*/
            if (this.DataType.ValueChanged) upd.AddValue("DataType", this.DataType);
            if (this.UserID.ValueChanged) upd.AddValue("UserID", this.UserID);
            if (this.QueueDateTime.ValueChanged) upd.AddValue("QueueDateTime", this.QueueDateTime);
            if (this.Status.ValueChanged) upd.AddValue("Status", this.Status);
            if (this.ApprovedBy.ValueChanged) upd.AddValue("ApprovedBy", this.ApprovedBy);
            if (this.Event.ValueChanged) upd.AddValue("Event", this.Event);/*Optional 13*/
            if (this.Active.ValueChanged) upd.AddValue("Active", this.Active);/*Optional 14*/

            HssUtility.SQLserver.SQL_relation rela = new HssUtility.SQLserver.SQL_relation("Queue_ID", HssUtility.General.RelationalOperator.Equals, this.pk_ID);
            upd.SetCondition(rela);

            return upd;
        }

        public Dividend_Control_Queue GetCopy()
        {
            Dividend_Control_Queue newEntity = new Dividend_Control_Queue();
            if (!this.DividendIndex.IsNull_flag) newEntity.DividendIndex.Value = this.DividendIndex.Value;
            if (!this.TabName.IsNull_flag) newEntity.TabName.Value = this.TabName.Value;
            if (!this.FieldName.IsNull_flag) newEntity.FieldName.Value = this.FieldName.Value;
            if (!this.ColumnName.IsNull_flag) newEntity.ColumnName.Value = this.ColumnName.Value;
            if (!this.PreviousValue.IsNull_flag) newEntity.PreviousValue.Value = this.PreviousValue.Value;
            if (!this.NewValue.IsNull_flag) newEntity.NewValue.Value = this.NewValue.Value;
            if (!this.DataType.IsNull_flag) newEntity.DataType.Value = this.DataType.Value;
            if (!this.UserID.IsNull_flag) newEntity.UserID.Value = this.UserID.Value;
            if (!this.QueueDateTime.IsNull_flag) newEntity.QueueDateTime.Value = this.QueueDateTime.Value;
            if (!this.Status.IsNull_flag) newEntity.Status.Value = this.Status.Value;
            if (!this.ApprovedBy.IsNull_flag) newEntity.ApprovedBy.Value = this.ApprovedBy.Value;
            if (!this.Event.IsNull_flag) newEntity.Event.Value = this.Event.Value;
            if (!this.Active.IsNull_flag) newEntity.Active.Value = this.Active.Value;
            return newEntity;
        }

        public string ToXML()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("<Dividend_Control_Queue>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Queue_ID>").Append(this.Queue_ID).Append("</Queue_ID>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<DividendIndex>").Append(this.DividendIndex.Value).Append("</DividendIndex>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<TabName>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.TabName.Value)).Append("</TabName>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<FieldName>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.FieldName.Value)).Append("</FieldName>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<ColumnName>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.ColumnName.Value)).Append("</ColumnName>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<PreviousValue>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.PreviousValue.Value)).Append("</PreviousValue>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<NewValue>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.NewValue.Value)).Append("</NewValue>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<DataType>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.DataType.Value)).Append("</DataType>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<UserID>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.UserID.Value)).Append("</UserID>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<QueueDateTime>").Append(this.QueueDateTime.Value).Append("</QueueDateTime>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Status>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.Status.Value)).Append("</Status>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<ApprovedBy>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.ApprovedBy.Value)).Append("</ApprovedBy>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Event>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.Event.Value)).Append("</Event>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Active>").Append(this.Active.Value).Append("</Active>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("</Dividend_Control_Queue>").Append(HssUtility.General.HssStr.WinNextLine);
            return sb.ToString();
        }
        /*^^^^^^^^^^^^^^^^^^^^^^^^^^^^^Hss Entity Framework Auto Generated Code^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^*/

        public void Init_from_attr(string colName, HssUtility.General.Attributes.I_modelAttr attr)
        {
            if (attr == null) return;
            string newStrVal = attr.GetValue_in_string(0);

            this.TabName.Value = "Control";
            this.ColumnName.Value = colName;
            this.FieldName.Value = colName;

            //if(!attr.IsNull_flag) this.PreviousValue.Value =
            this.NewValue.Value = newStrVal;

            string tempTP_str = attr.GetRawValueType().ToString();
            int startIndex = tempTP_str.LastIndexOf('.');
            if (startIndex >= 0) tempTP_str = tempTP_str.Substring(startIndex + 1);
            this.DataType.Value = tempTP_str;

            this.UserID.Value = Utility.CurrentUser;
            this.QueueDateTime.Value = DateTime.Now;
            this.ApprovedBy.Value = "XBRL-" + Utility.CurrentUser;

            this.Status.Value = "Migrated";
            this.Event.Value = "Update";
            this.Active.Value = true;
        }
    }
}
