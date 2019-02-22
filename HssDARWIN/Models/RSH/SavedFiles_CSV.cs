using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HssDARWIN.Models.RSH
{
    public class SavedFiles_CSV
    {
        /*-----------------------------Hss Entity Framework Auto Generated Code-------------------------------*/
        private static HssUtility.SQLserver.CmdTemplate DBcmd_TP = null;
        public static HssUtility.SQLserver.CmdTemplate Get_cmdTP()
        {
            if (SavedFiles_CSV.DBcmd_TP != null) return SavedFiles_CSV.DBcmd_TP;

            SavedFiles_CSV.DBcmd_TP = new HssUtility.SQLserver.CmdTemplate();
            SavedFiles_CSV.DBcmd_TP.tableName = "SavedFiles_CSV";
            SavedFiles_CSV.DBcmd_TP.schema = "RSH";

            SavedFiles_CSV.DBcmd_TP.AddColumn("id_SavedFiles_CSV");
            SavedFiles_CSV.DBcmd_TP.AddColumn("originalFileName");/*Optional 2*/
            SavedFiles_CSV.DBcmd_TP.AddColumn("SavedFiles_CSV");
            SavedFiles_CSV.DBcmd_TP.AddColumn("FileCreationDate");/*Optional 4*/
            SavedFiles_CSV.DBcmd_TP.AddColumn("FTP_Source");/*Optional 5*/
            SavedFiles_CSV.DBcmd_TP.AddColumn("Status");/*Optional 6*/
            SavedFiles_CSV.DBcmd_TP.AddColumn("DividendIndex");/*Optional 7*/
            SavedFiles_CSV.DBcmd_TP.AddColumn("Depositary");/*Optional 8*/
            SavedFiles_CSV.DBcmd_TP.AddColumn("DTC");/*Optional 9*/
            SavedFiles_CSV.DBcmd_TP.AddColumn("ProcessTime");/*Optional 10*/
            SavedFiles_CSV.DBcmd_TP.AddColumn("ProcessedBy");/*Optional 11*/
            SavedFiles_CSV.DBcmd_TP.AddColumn("cpuFileName");/*Optional 12*/
            SavedFiles_CSV.DBcmd_TP.AddColumn("cpuSavedFiles_CSV");/*Optional 13*/
            SavedFiles_CSV.DBcmd_TP.AddColumn("cpuStatus");/*Optional 14*/
            SavedFiles_CSV.DBcmd_TP.AddColumn("cpuProcessTime");/*Optional 15*/
            SavedFiles_CSV.DBcmd_TP.AddColumn("cpuProcessedBy");/*Optional 16*/
            SavedFiles_CSV.DBcmd_TP.AddColumn("OriginalSchema");/*Optional 17*/
            SavedFiles_CSV.DBcmd_TP.AddColumn("OriginalData");/*Optional 18*/
            SavedFiles_CSV.DBcmd_TP.AddColumn("RecordDate");/*Optional 19*/
            SavedFiles_CSV.DBcmd_TP.AddColumn("Sender");/*Optional 20*/
            SavedFiles_CSV.DBcmd_TP.AddColumn("CUSIP");/*Optional 21*/

            return SavedFiles_CSV.DBcmd_TP;
        }

        public SavedFiles_CSV() { }
        public SavedFiles_CSV(int id) { this.pk_ID = id; }

        private int pk_ID = -1; //primary key
        public int id_SavedFiles_CSV { get { return this.pk_ID; } }

        public readonly HssUtility.General.Attributes.String_attr originalFileName = new HssUtility.General.Attributes.String_attr();/*Optional 2*/
        public byte[] savedfile_csv = null; //Amstock byte array
        public readonly HssUtility.General.Attributes.DateTime_attr FileCreationDate = new HssUtility.General.Attributes.DateTime_attr();/*Optional 4*/
        public readonly HssUtility.General.Attributes.String_attr FTP_Source = new HssUtility.General.Attributes.String_attr();/*Optional 5*/
        public readonly HssUtility.General.Attributes.String_attr Status = new HssUtility.General.Attributes.String_attr();/*Optional 6*/
        public readonly HssUtility.General.Attributes.String_attr DividendIndex = new HssUtility.General.Attributes.String_attr();/*Optional 7*/
        public readonly HssUtility.General.Attributes.String_attr Depositary = new HssUtility.General.Attributes.String_attr();/*Optional 8*/
        public readonly HssUtility.General.Attributes.Int_attr DTC = new HssUtility.General.Attributes.Int_attr();/*Optional 9*/
        public readonly HssUtility.General.Attributes.DateTime_attr ProcessTime = new HssUtility.General.Attributes.DateTime_attr();/*Optional 10*/
        public readonly HssUtility.General.Attributes.String_attr ProcessedBy = new HssUtility.General.Attributes.String_attr();/*Optional 11*/
        public readonly HssUtility.General.Attributes.String_attr cpuFileName = new HssUtility.General.Attributes.String_attr();/*Optional 12*/
        public byte[] cpu_savedfile_csv = null; //Computer share byte array                                                                                                                   /*Optional 13*/
        public readonly HssUtility.General.Attributes.String_attr cpuStatus = new HssUtility.General.Attributes.String_attr();/*Optional 14*/
        public readonly HssUtility.General.Attributes.DateTime_attr cpuProcessTime = new HssUtility.General.Attributes.DateTime_attr();/*Optional 15*/
        public readonly HssUtility.General.Attributes.String_attr cpuProcessedBy = new HssUtility.General.Attributes.String_attr();/*Optional 16*/
        public readonly HssUtility.General.Attributes.String_attr OriginalSchema = new HssUtility.General.Attributes.String_attr();/*Optional 17*/
        public readonly HssUtility.General.Attributes.String_attr OriginalData = new HssUtility.General.Attributes.String_attr();/*Optional 18*/
        public readonly HssUtility.General.Attributes.DateTime_attr RecordDate = new HssUtility.General.Attributes.DateTime_attr();/*Optional 19*/
        public readonly HssUtility.General.Attributes.String_attr Sender = new HssUtility.General.Attributes.String_attr();/*Optional 20*/
        public readonly HssUtility.General.Attributes.String_attr CUSIP = new HssUtility.General.Attributes.String_attr();/*Optional 21*/

        private Dictionary<string, HssUtility.General.Attributes.I_modelAttr> attr_dic = null;

        internal void Init_from_reader(HssUtility.SQLserver.DB_reader reader)
        {
            if (reader == null || reader.IsClosed) return;

            this.pk_ID = reader.GetInt("id_SavedFiles_CSV");
            reader.GetString("originalFileName", this.originalFileName);/*Optional 2*/
            this.savedfile_csv = reader.GetBytes("SavedFiles_CSV");
            reader.GetDateTime("FileCreationDate", this.FileCreationDate);/*Optional 4*/
            reader.GetString("FTP_Source", this.FTP_Source);/*Optional 5*/
            reader.GetString("Status", this.Status);/*Optional 6*/
            reader.GetString("DividendIndex", this.DividendIndex);/*Optional 7*/
            reader.GetString("Depositary", this.Depositary);/*Optional 8*/
            reader.GetInt("DTC", this.DTC);/*Optional 9*/
            reader.GetDateTime("ProcessTime", this.ProcessTime);/*Optional 10*/
            reader.GetString("ProcessedBy", this.ProcessedBy);/*Optional 11*/
            reader.GetString("cpuFileName", this.cpuFileName);/*Optional 12*/
            this.cpu_savedfile_csv = reader.GetBytes("cpuSavedFiles_CSV");/*Optional 13*/
            reader.GetString("cpuStatus", this.cpuStatus);/*Optional 14*/
            reader.GetDateTime("cpuProcessTime", this.cpuProcessTime);/*Optional 15*/
            reader.GetString("cpuProcessedBy", this.cpuProcessedBy);/*Optional 16*/
            reader.GetString("OriginalSchema", this.OriginalSchema);/*Optional 17*/
            reader.GetString("OriginalData", this.OriginalData);/*Optional 18*/
            reader.GetDateTime("RecordDate", this.RecordDate);/*Optional 19*/
            reader.GetString("Sender", this.Sender);/*Optional 20*/
            reader.GetString("CUSIP", this.CUSIP);/*Optional 21*/

            this.SyncWithDB();
        }

        /// <summary>
        /// Initialize object from DB
        /// </summary>
        public bool Init_from_DB(bool ignore_binary, bool ignore_SchemaData)
        {
            if (this.id_SavedFiles_CSV < 0) return false;

            HssUtility.SQLserver.DB_select db_sel = new HssUtility.SQLserver.DB_select(SavedFiles_CSV.Get_cmdTP());
            db_sel.tableName = "SavedFiles_CSV";
            if (ignore_binary)
            {
                db_sel.IgnoreColumn("SavedFiles_CSV");
                db_sel.IgnoreColumn("cpuSavedFiles_CSV");
            }
            if (ignore_SchemaData)
            { 
                db_sel.IgnoreColumn("OriginalSchema");
                db_sel.IgnoreColumn("OriginalData");
            }

            HssUtility.SQLserver.SQL_relation rela = new HssUtility.SQLserver.SQL_relation("id_SavedFiles_CSV", HssUtility.General.RelationalOperator.Equals, this.id_SavedFiles_CSV);
            db_sel.SetCondition(rela);

            bool res_flag = false;
            HssUtility.SQLserver.DB_reader reader = new HssUtility.SQLserver.DB_reader(db_sel, Utility.Get_XBRL_hDB());
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
            this.attr_dic.Add("originalFileName", this.originalFileName);/*Optional 2*/
            //this.attr_dic.Add("SavedFiles_CSV", this.SavedFiles_CSV);
            this.attr_dic.Add("FileCreationDate", this.FileCreationDate);/*Optional 4*/
            this.attr_dic.Add("FTP_Source", this.FTP_Source);/*Optional 5*/
            this.attr_dic.Add("Status", this.Status);/*Optional 6*/
            this.attr_dic.Add("DividendIndex", this.DividendIndex);/*Optional 7*/
            this.attr_dic.Add("Depositary", this.Depositary);/*Optional 8*/
            this.attr_dic.Add("DTC", this.DTC);/*Optional 9*/
            this.attr_dic.Add("ProcessTime", this.ProcessTime);/*Optional 10*/
            this.attr_dic.Add("ProcessedBy", this.ProcessedBy);/*Optional 11*/
            this.attr_dic.Add("cpuFileName", this.cpuFileName);/*Optional 12*/
            //this.attr_dic.Add("cpuSavedFiles_CSV", this.cpuSavedFiles_CSV);/*Optional 13*/
            this.attr_dic.Add("cpuStatus", this.cpuStatus);/*Optional 14*/
            this.attr_dic.Add("cpuProcessTime", this.cpuProcessTime);/*Optional 15*/
            this.attr_dic.Add("cpuProcessedBy", this.cpuProcessedBy);/*Optional 16*/
            this.attr_dic.Add("OriginalSchema", this.OriginalSchema);/*Optional 17*/
            this.attr_dic.Add("OriginalData", this.OriginalData);/*Optional 18*/
            this.attr_dic.Add("RecordDate", this.RecordDate);/*Optional 19*/
            this.attr_dic.Add("Sender", this.Sender);/*Optional 20*/
            this.attr_dic.Add("CUSIP", this.CUSIP);/*Optional 21*/
        }

        /// <summary>
        /// Insert object to DB
        /// </summary>
        public bool Insert_to_DB()
        {
            HssUtility.SQLserver.DB_insert ins = this.Get_DBinsert();
            int count = ins.SaveToDB(Utility.Get_XBRL_hDB());

            bool flag = count > 0;
            if (flag) this.SyncWithDB();

            return flag;
        }

        internal HssUtility.SQLserver.DB_insert Get_DBinsert()
        {
            HssUtility.SQLserver.DB_insert dbIns = new HssUtility.SQLserver.DB_insert(SavedFiles_CSV.Get_cmdTP());

            dbIns.AddValue("originalFileName", this.originalFileName);/*Optional 2*/
            dbIns.AddValue("SavedFiles_CSV", this.savedfile_csv);
            dbIns.AddValue("FileCreationDate", this.FileCreationDate);/*Optional 4*/
            dbIns.AddValue("FTP_Source", this.FTP_Source);/*Optional 5*/
            dbIns.AddValue("Status", this.Status);/*Optional 6*/
            dbIns.AddValue("DividendIndex", this.DividendIndex);/*Optional 7*/
            dbIns.AddValue("Depositary", this.Depositary);/*Optional 8*/
            dbIns.AddValue("DTC", this.DTC);/*Optional 9*/
            dbIns.AddValue("ProcessTime", this.ProcessTime);/*Optional 10*/
            dbIns.AddValue("ProcessedBy", this.ProcessedBy);/*Optional 11*/
            dbIns.AddValue("cpuFileName", this.cpuFileName);/*Optional 12*/
            dbIns.AddValue("cpuSavedFiles_CSV", this.cpu_savedfile_csv);/*Optional 13*/
            dbIns.AddValue("cpuStatus", this.cpuStatus);/*Optional 14*/
            dbIns.AddValue("cpuProcessTime", this.cpuProcessTime);/*Optional 15*/
            dbIns.AddValue("cpuProcessedBy", this.cpuProcessedBy);/*Optional 16*/
            dbIns.AddValue("OriginalSchema", this.OriginalSchema);/*Optional 17*/
            dbIns.AddValue("OriginalData", this.OriginalData);/*Optional 18*/
            dbIns.AddValue("RecordDate", this.RecordDate);/*Optional 19*/
            dbIns.AddValue("Sender", this.Sender);/*Optional 20*/
            dbIns.AddValue("CUSIP", this.CUSIP);/*Optional 21*/

            return dbIns;
        }

        /// <summary>
        /// Save updates to DB
        /// </summary>
        public bool Update_to_DB()
        {
            HssUtility.SQLserver.DB_update upd = this.Get_DBupdate();
            if (upd == null) return false;

            int count = upd.SaveToDB(Utility.Get_XBRL_hDB());
            bool flag = count > 0;
            if (flag) this.SyncWithDB();

            return flag;
        }

        internal HssUtility.SQLserver.DB_update Get_DBupdate()
        {
            if (!this.CheckValueChanges()) return null;

            HssUtility.SQLserver.DB_update upd = new HssUtility.SQLserver.DB_update(SavedFiles_CSV.Get_cmdTP());
            if (this.originalFileName.ValueChanged) upd.AddValue("originalFileName", this.originalFileName);/*Optional 2*/
            //if (this.SavedFiles_CSV.ValueChanged) upd.AddValue("SavedFiles_CSV", this.SavedFiles_CSV);//no update for binary for now
            if (this.FileCreationDate.ValueChanged) upd.AddValue("FileCreationDate", this.FileCreationDate);/*Optional 4*/
            if (this.FTP_Source.ValueChanged) upd.AddValue("FTP_Source", this.FTP_Source);/*Optional 5*/
            if (this.Status.ValueChanged) upd.AddValue("Status", this.Status);/*Optional 6*/
            if (this.DividendIndex.ValueChanged) upd.AddValue("DividendIndex", this.DividendIndex);/*Optional 7*/
            if (this.Depositary.ValueChanged) upd.AddValue("Depositary", this.Depositary);/*Optional 8*/
            if (this.DTC.ValueChanged) upd.AddValue("DTC", this.DTC);/*Optional 9*/
            if (this.ProcessTime.ValueChanged) upd.AddValue("ProcessTime", this.ProcessTime);/*Optional 10*/
            if (this.ProcessedBy.ValueChanged) upd.AddValue("ProcessedBy", this.ProcessedBy);/*Optional 11*/
            if (this.cpuFileName.ValueChanged) upd.AddValue("cpuFileName", this.cpuFileName);/*Optional 12*/
            //if (this.cpuSavedFiles_CSV.ValueChanged) upd.AddValue("cpuSavedFiles_CSV", this.cpuSavedFiles_CSV);//no update for binary for now
            if (this.cpuStatus.ValueChanged) upd.AddValue("cpuStatus", this.cpuStatus);/*Optional 14*/
            if (this.cpuProcessTime.ValueChanged) upd.AddValue("cpuProcessTime", this.cpuProcessTime);/*Optional 15*/
            if (this.cpuProcessedBy.ValueChanged) upd.AddValue("cpuProcessedBy", this.cpuProcessedBy);/*Optional 16*/
            if (this.OriginalSchema.ValueChanged) upd.AddValue("OriginalSchema", this.OriginalSchema);/*Optional 17*/
            if (this.OriginalData.ValueChanged) upd.AddValue("OriginalData", this.OriginalData);/*Optional 18*/
            if (this.RecordDate.ValueChanged) upd.AddValue("RecordDate", this.RecordDate);/*Optional 19*/
            if (this.Sender.ValueChanged) upd.AddValue("Sender", this.Sender);/*Optional 20*/
            if (this.CUSIP.ValueChanged) upd.AddValue("CUSIP", this.CUSIP);/*Optional 21*/

            HssUtility.SQLserver.SQL_relation rela = new HssUtility.SQLserver.SQL_relation("id_SavedFiles_CSV", HssUtility.General.RelationalOperator.Equals, this.pk_ID);
            upd.SetCondition(rela);

            return upd;
        }

        public SavedFiles_CSV GetCopy()
        {
            SavedFiles_CSV newEntity = new SavedFiles_CSV();
            if (!this.originalFileName.IsNull_flag) newEntity.originalFileName.Value = this.originalFileName.Value;
            //if (!this.SavedFiles_CSV.IsNull_flag) newEntity.SavedFiles_CSV.Value = this.SavedFiles_CSV.Value;
            if (!this.FileCreationDate.IsNull_flag) newEntity.FileCreationDate.Value = this.FileCreationDate.Value;
            if (!this.FTP_Source.IsNull_flag) newEntity.FTP_Source.Value = this.FTP_Source.Value;
            if (!this.Status.IsNull_flag) newEntity.Status.Value = this.Status.Value;
            if (!this.DividendIndex.IsNull_flag) newEntity.DividendIndex.Value = this.DividendIndex.Value;
            if (!this.Depositary.IsNull_flag) newEntity.Depositary.Value = this.Depositary.Value;
            if (!this.DTC.IsNull_flag) newEntity.DTC.Value = this.DTC.Value;
            if (!this.ProcessTime.IsNull_flag) newEntity.ProcessTime.Value = this.ProcessTime.Value;
            if (!this.ProcessedBy.IsNull_flag) newEntity.ProcessedBy.Value = this.ProcessedBy.Value;
            if (!this.cpuFileName.IsNull_flag) newEntity.cpuFileName.Value = this.cpuFileName.Value;
            //if (!this.cpuSavedFiles_CSV.IsNull_flag) newEntity.cpuSavedFiles_CSV.Value = this.cpuSavedFiles_CSV.Value;
            if (!this.cpuStatus.IsNull_flag) newEntity.cpuStatus.Value = this.cpuStatus.Value;
            if (!this.cpuProcessTime.IsNull_flag) newEntity.cpuProcessTime.Value = this.cpuProcessTime.Value;
            if (!this.cpuProcessedBy.IsNull_flag) newEntity.cpuProcessedBy.Value = this.cpuProcessedBy.Value;
            if (!this.OriginalSchema.IsNull_flag) newEntity.OriginalSchema.Value = this.OriginalSchema.Value;
            if (!this.OriginalData.IsNull_flag) newEntity.OriginalData.Value = this.OriginalData.Value;
            if (!this.RecordDate.IsNull_flag) newEntity.RecordDate.Value = this.RecordDate.Value;
            if (!this.Sender.IsNull_flag) newEntity.Sender.Value = this.Sender.Value;
            if (!this.CUSIP.IsNull_flag) newEntity.CUSIP.Value = this.CUSIP.Value;
            return newEntity;
        }

        public string ToXML()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("<SavedFiles_CSV>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<id_SavedFiles_CSV>").Append(this.id_SavedFiles_CSV).Append("</id_SavedFiles_CSV>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<originalFileName>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.originalFileName.Value)).Append("</originalFileName>").Append(HssUtility.General.HssStr.WinNextLine);
            //sb.Append("<SavedFiles_CSV>").Append(this.SavedFiles_CSV.Value).Append("</SavedFiles_CSV>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<FileCreationDate>").Append(this.FileCreationDate.Value).Append("</FileCreationDate>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<FTP_Source>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.FTP_Source.Value)).Append("</FTP_Source>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Status>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.Status.Value)).Append("</Status>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<DividendIndex>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.DividendIndex.Value)).Append("</DividendIndex>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Depositary>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.Depositary.Value)).Append("</Depositary>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<DTC>").Append(this.DTC.Value).Append("</DTC>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<ProcessTime>").Append(this.ProcessTime.Value).Append("</ProcessTime>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<ProcessedBy>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.ProcessedBy.Value)).Append("</ProcessedBy>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<cpuFileName>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.cpuFileName.Value)).Append("</cpuFileName>").Append(HssUtility.General.HssStr.WinNextLine);
            //sb.Append("<cpuSavedFiles_CSV>").Append(this.cpuSavedFiles_CSV.Value).Append("</cpuSavedFiles_CSV>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<cpuStatus>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.cpuStatus.Value)).Append("</cpuStatus>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<cpuProcessTime>").Append(this.cpuProcessTime.Value).Append("</cpuProcessTime>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<cpuProcessedBy>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.cpuProcessedBy.Value)).Append("</cpuProcessedBy>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<OriginalSchema>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.OriginalSchema.Value)).Append("</OriginalSchema>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<OriginalData>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.OriginalData.Value)).Append("</OriginalData>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<RecordDate>").Append(this.RecordDate.Value).Append("</RecordDate>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Sender>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.Sender.Value)).Append("</Sender>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<CUSIP>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.CUSIP.Value)).Append("</CUSIP>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("</SavedFiles_CSV>").Append(HssUtility.General.HssStr.WinNextLine);
            return sb.ToString();
        }

        public HssUtility.Forms.Attribute.Models_viewForm GetEditForm()
        {
            HssUtility.Forms.Attribute.Models_viewForm mvf = new HssUtility.Forms.Attribute.Models_viewForm();
            mvf.Text = "SavedFiles_CSV";
            mvf.Set_pk_label("id_SavedFiles_CSV:" + this.id_SavedFiles_CSV);
            mvf.Add_Control(new HssUtility.Forms.Attribute.StrAttr_UserControl("originalFileName", this.originalFileName));/*Optional 2*/

            mvf.Add_Control(new HssUtility.Forms.Attribute.DateTimeAttr_UserControl("FileCreationDate", this.FileCreationDate));/*Optional 4*/
            mvf.Add_Control(new HssUtility.Forms.Attribute.StrAttr_UserControl("FTP_Source", this.FTP_Source));/*Optional 5*/
            mvf.Add_Control(new HssUtility.Forms.Attribute.StrAttr_UserControl("Status", this.Status));/*Optional 6*/
            mvf.Add_Control(new HssUtility.Forms.Attribute.StrAttr_UserControl("DividendIndex", this.DividendIndex));/*Optional 7*/
            mvf.Add_Control(new HssUtility.Forms.Attribute.StrAttr_UserControl("Depositary", this.Depositary));/*Optional 8*/
            mvf.Add_Control(new HssUtility.Forms.Attribute.StrAttr_UserControl("DTC", this.DTC));/*Optional 9*/
            mvf.Add_Control(new HssUtility.Forms.Attribute.DateTimeAttr_UserControl("ProcessTime", this.ProcessTime));/*Optional 10*/
            mvf.Add_Control(new HssUtility.Forms.Attribute.StrAttr_UserControl("ProcessedBy", this.ProcessedBy));/*Optional 11*/
            mvf.Add_Control(new HssUtility.Forms.Attribute.StrAttr_UserControl("cpuFileName", this.cpuFileName));/*Optional 12*/
                                                                                                                 /*Optional 13*/
            mvf.Add_Control(new HssUtility.Forms.Attribute.StrAttr_UserControl("cpuStatus", this.cpuStatus));/*Optional 14*/
            mvf.Add_Control(new HssUtility.Forms.Attribute.DateTimeAttr_UserControl("cpuProcessTime", this.cpuProcessTime));/*Optional 15*/
            mvf.Add_Control(new HssUtility.Forms.Attribute.StrAttr_UserControl("cpuProcessedBy", this.cpuProcessedBy));/*Optional 16*/
            mvf.Add_Control(new HssUtility.Forms.Attribute.StrAttr_UserControl("OriginalSchema", this.OriginalSchema));/*Optional 17*/
            mvf.Add_Control(new HssUtility.Forms.Attribute.StrAttr_UserControl("OriginalData", this.OriginalData));/*Optional 18*/
            mvf.Add_Control(new HssUtility.Forms.Attribute.DateTimeAttr_UserControl("RecordDate", this.RecordDate));/*Optional 19*/
            mvf.Add_Control(new HssUtility.Forms.Attribute.StrAttr_UserControl("Sender", this.Sender));/*Optional 20*/
            mvf.Add_Control(new HssUtility.Forms.Attribute.StrAttr_UserControl("CUSIP", this.CUSIP));/*Optional 21*/
            mvf.SaveModel_func = delegate { return this.Save_to_DB(); };
            return mvf;
        }

        public bool Save_to_DB()
        {
            bool dataSaved_flag = false;
            if (this.pk_ID > 0) dataSaved_flag = this.Update_to_DB();
            else dataSaved_flag = this.Insert_to_DB();
            return dataSaved_flag;
        }
        /*^^^^^^^^^^^^^^^^^^^^^^^^^^^^^Hss Entity Framework Auto Generated Code^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^*/

        public void Save_to_file(string path)
        {

        }
    }
}
