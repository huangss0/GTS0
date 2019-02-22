using System;
using System.IO;
using System.Globalization;
using System.Collections.Generic;
using System.Text;

namespace HssDARWIN.SubProjects.SPR_Report
{
    public class SPR_file
    {
        /*-----------------------------Hss Entity Framework Auto Generated Code-------------------------------*/
        private static HssUtility.SQLserver.CmdTemplate DBcmd_TP = null;
        public static HssUtility.SQLserver.CmdTemplate Get_cmdTP()
        {
            if (SPR_file.DBcmd_TP != null) return SPR_file.DBcmd_TP;

            SPR_file.DBcmd_TP = new HssUtility.SQLserver.CmdTemplate();
            SPR_file.DBcmd_TP.tableName = "DTCC_FTP_files";
            SPR_file.DBcmd_TP.schema = "Task";

            SPR_file.DBcmd_TP.AddColumn("ID");
            SPR_file.DBcmd_TP.AddColumn("FileName");/*Optional 2*/
            SPR_file.DBcmd_TP.AddColumn("CreateTime");/*Optional 3*/
            SPR_file.DBcmd_TP.AddColumn("FileBinary");/*Optional 4*/
            SPR_file.DBcmd_TP.AddColumn("CreateBy");/*Optional 5*/
            SPR_file.DBcmd_TP.AddColumn("Status");/*Optional 6*/
            SPR_file.DBcmd_TP.AddColumn("CUSIP");/*Optional 7*/
            SPR_file.DBcmd_TP.AddColumn("RecordDate");/*Optional 8*/
            SPR_file.DBcmd_TP.AddColumn("SecurityName");/*Optional 9*/
            SPR_file.DBcmd_TP.AddColumn("LastModifyAt");/*Optional 10*/
            SPR_file.DBcmd_TP.AddColumn("LastModifyBy");/*Optional 11*/
            SPR_file.DBcmd_TP.AddColumn("LastModifyAction");/*Optional 12*/

            return SPR_file.DBcmd_TP;
        }

        public SPR_file() { }
        public SPR_file(int id) { this.pk_ID = id; }

        private int pk_ID = -1; //primary key
        public int ID { get { return this.pk_ID; } }

        public readonly HssUtility.General.Attributes.String_attr FileName = new HssUtility.General.Attributes.String_attr();/*Optional 2*/
        public readonly HssUtility.General.Attributes.DateTime_attr CreateTime = new HssUtility.General.Attributes.DateTime_attr();/*Optional 3*/
        public byte[] FileBinary = null;/*Optional 4*/
        public readonly HssUtility.General.Attributes.String_attr CreateBy = new HssUtility.General.Attributes.String_attr(Utility.CurrentUser);/*Optional 5*/
        public readonly HssUtility.General.Attributes.Int_attr Status = 
            new HssUtility.General.Attributes.Int_attr((int)HssUtility.General.HssStatus.Pending);/*Optional 6*/
        public readonly HssUtility.General.Attributes.String_attr CUSIP = new HssUtility.General.Attributes.String_attr();/*Optional 7*/
        public readonly HssUtility.General.Attributes.DateTime_attr RecordDate = new HssUtility.General.Attributes.DateTime_attr();/*Optional 8*/
        public readonly HssUtility.General.Attributes.String_attr SecurityName = new HssUtility.General.Attributes.String_attr();/*Optional 9*/
        public readonly HssUtility.General.Attributes.DateTime_attr LastModifyAt = new HssUtility.General.Attributes.DateTime_attr();/*Optional 10*/
        public readonly HssUtility.General.Attributes.String_attr LastModifyBy = new HssUtility.General.Attributes.String_attr();/*Optional 11*/
        public readonly HssUtility.General.Attributes.String_attr LastModifyAction = new HssUtility.General.Attributes.String_attr();/*Optional 12*/

        private Dictionary<string, HssUtility.General.Attributes.I_modelAttr> attr_dic = null;

        internal void Init_from_reader(HssUtility.SQLserver.DB_reader reader)
        {
            if (reader == null || reader.IsClosed) return;

            this.pk_ID = reader.GetInt("ID");
            reader.GetString("FileName", this.FileName);/*Optional 2*/
            reader.GetDateTime("CreateTime", this.CreateTime);/*Optional 3*/
            this.FileBinary = reader.GetBytes("FileBinary");/*Optional 4*/
            reader.GetString("CreateBy", this.CreateBy);/*Optional 5*/
            reader.GetInt("Status", this.Status);/*Optional 6*/
            reader.GetString("CUSIP", this.CUSIP);/*Optional 7*/
            reader.GetDateTime("RecordDate", this.RecordDate);/*Optional 8*/
            reader.GetString("SecurityName", this.SecurityName);/*Optional 9*/
            reader.GetDateTime("LastModifyAt", this.LastModifyAt);/*Optional 10*/
            reader.GetString("LastModifyBy", this.LastModifyBy);/*Optional 11*/
            reader.GetString("LastModifyAction", this.LastModifyAction);/*Optional 12*/

            this.SyncWithDB();
        }

        /// <summary>
        /// Initialize object from DB
        /// </summary>
        public bool Init_from_DB()
        {
            if (this.ID < 0) return false;

            HssUtility.SQLserver.DB_select db_sel = new HssUtility.SQLserver.DB_select(SPR_file.Get_cmdTP());
            db_sel.tableName = "DTCC_FTP_files";
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
            this.attr_dic.Add("FileName", this.FileName);/*Optional 2*/
            this.attr_dic.Add("CreateTime", this.CreateTime);/*Optional 3*/
            this.attr_dic.Add("CreateBy", this.CreateBy);/*Optional 5*/
            this.attr_dic.Add("Status", this.Status);/*Optional 6*/
            this.attr_dic.Add("CUSIP", this.CUSIP);/*Optional 7*/
            this.attr_dic.Add("RecordDate", this.RecordDate);/*Optional 8*/
            this.attr_dic.Add("SecurityName", this.SecurityName);/*Optional 9*/
            this.attr_dic.Add("LastModifyAt", this.LastModifyAt);/*Optional 10*/
            this.attr_dic.Add("LastModifyBy", this.LastModifyBy);/*Optional 11*/
            this.attr_dic.Add("LastModifyAction", this.LastModifyAction);/*Optional 12*/
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
            HssUtility.SQLserver.DB_insert dbIns = new HssUtility.SQLserver.DB_insert(SPR_file.Get_cmdTP());

            dbIns.AddValue("FileName", this.FileName);/*Optional 2*/
            dbIns.AddValue("CreateTime", this.CreateTime);/*Optional 3*/
            dbIns.AddValue("FileBinary", this.FileBinary);/*Optional 4*/
            dbIns.AddValue("CreateBy", this.CreateBy);/*Optional 5*/
            dbIns.AddValue("Status", this.Status);/*Optional 6*/
            dbIns.AddValue("CUSIP", this.CUSIP);/*Optional 7*/
            dbIns.AddValue("RecordDate", this.RecordDate);/*Optional 8*/
            dbIns.AddValue("SecurityName", this.SecurityName);/*Optional 9*/
            dbIns.AddValue("LastModifyAt", this.LastModifyAt);/*Optional 10*/
            dbIns.AddValue("LastModifyBy", this.LastModifyBy);/*Optional 11*/
            dbIns.AddValue("LastModifyAction", this.LastModifyAction);/*Optional 12*/

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
                this.LastModifyAt.Value = DateTime.Now;
                this.LastModifyBy.Value = Utility.CurrentUser;
            }

            HssUtility.SQLserver.DB_update upd = new HssUtility.SQLserver.DB_update(SPR_file.Get_cmdTP());
            if (this.FileName.ValueChanged) upd.AddValue("FileName", this.FileName);/*Optional 2*/
            if (this.CreateTime.ValueChanged) upd.AddValue("CreateTime", this.CreateTime);/*Optional 3*/
            if (this.CreateBy.ValueChanged) upd.AddValue("CreateBy", this.CreateBy);/*Optional 5*/
            if (this.Status.ValueChanged) upd.AddValue("Status", this.Status);/*Optional 6*/
            if (this.CUSIP.ValueChanged) upd.AddValue("CUSIP", this.CUSIP);/*Optional 7*/
            if (this.RecordDate.ValueChanged) upd.AddValue("RecordDate", this.RecordDate);/*Optional 8*/
            if (this.SecurityName.ValueChanged) upd.AddValue("SecurityName", this.SecurityName);/*Optional 9*/
            if (this.LastModifyAt.ValueChanged) upd.AddValue("LastModifyAt", this.LastModifyAt);/*Optional 10*/
            if (this.LastModifyBy.ValueChanged) upd.AddValue("LastModifyBy", this.LastModifyBy);/*Optional 11*/
            if (this.LastModifyAction.ValueChanged) upd.AddValue("LastModifyAction", this.LastModifyAction);/*Optional 12*/

            HssUtility.SQLserver.SQL_relation rela = new HssUtility.SQLserver.SQL_relation("ID", HssUtility.General.RelationalOperator.Equals, this.pk_ID);
            upd.SetCondition(rela);

            return upd;
        }

        public SPR_file GetCopy()
        {
            SPR_file newEntity = new SPR_file();
            if (!this.FileName.IsNull_flag) newEntity.FileName.Value = this.FileName.Value;
            if (!this.CreateTime.IsNull_flag) newEntity.CreateTime.Value = this.CreateTime.Value;
            if (!this.CreateBy.IsNull_flag) newEntity.CreateBy.Value = this.CreateBy.Value;
            if (!this.Status.IsNull_flag) newEntity.Status.Value = this.Status.Value;
            if (!this.CUSIP.IsNull_flag) newEntity.CUSIP.Value = this.CUSIP.Value;
            if (!this.RecordDate.IsNull_flag) newEntity.RecordDate.Value = this.RecordDate.Value;
            if (!this.SecurityName.IsNull_flag) newEntity.SecurityName.Value = this.SecurityName.Value;
            if (!this.LastModifyAt.IsNull_flag) newEntity.LastModifyAt.Value = this.LastModifyAt.Value;
            if (!this.LastModifyBy.IsNull_flag) newEntity.LastModifyBy.Value = this.LastModifyBy.Value;
            if (!this.LastModifyAction.IsNull_flag) newEntity.LastModifyAction.Value = this.LastModifyAction.Value;
            return newEntity;
        }

        public string ToXML()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("<SPR_file>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<ID>").Append(this.ID).Append("</ID>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<FileName>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.FileName.Value)).Append("</FileName>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<CreateTime>").Append(this.CreateTime.Value).Append("</CreateTime>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<CreateBy>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.CreateBy.Value)).Append("</CreateBy>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Status>").Append(this.Status.Value).Append("</Status>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<CUSIP>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.CUSIP.Value)).Append("</CUSIP>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<RecordDate>").Append(this.RecordDate.Value).Append("</RecordDate>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<SecurityName>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.SecurityName.Value)).Append("</SecurityName>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<LastModifyAt>").Append(this.LastModifyAt.Value).Append("</LastModifyAt>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<LastModifyBy>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.LastModifyBy.Value)).Append("</LastModifyBy>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<LastModifyAction>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.LastModifyAction.Value)).Append("</LastModifyAction>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("</SPR_file>").Append(HssUtility.General.HssStr.WinNextLine);
            return sb.ToString();
        }
        /*^^^^^^^^^^^^^^^^^^^^^^^^^^^^^Hss Entity Framework Auto Generated Code^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^*/

        public HssUtility.General.HssStatus GetStatus() { return HssUtility.General.Helper_hssStatus.Int_to_Status(this.Status.Value); }
        public void SetStatus(HssUtility.General.HssStatus st) { this.Status.Value = (int)st; }

        public void Calculate()
        {
            if (this.FileBinary == null) return;

            MemoryStream ms = new MemoryStream(this.FileBinary);
            StreamReader sr = new StreamReader(ms);

            string firstLine = sr.ReadLine(), secondLine = sr.ReadLine();
            if (secondLine == null || secondLine.Length < 25) return;

            string recordDate_str = secondLine.Substring(19, 6);
            this.RecordDate.Value = DateTime.ParseExact(recordDate_str, "yyMMdd", CultureInfo.InvariantCulture);
            this.SecurityName.Value = secondLine.Substring(25).Trim();
            this.CUSIP.Value = secondLine.Substring(9, 9);
        }
    }
}
