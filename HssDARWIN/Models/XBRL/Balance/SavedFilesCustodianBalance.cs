using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HssDARWIN.Models.XBRL.Balance
{
    public class SavedFilesCustodianBalance
    {
        /*-----------------------------Hss Entity Framework Auto Generated Code-------------------------------*/
        private static HssUtility.SQLserver.CmdTemplate DBcmd_TP = null;
        public static HssUtility.SQLserver.CmdTemplate Get_cmdTP()
        {
            if (SavedFilesCustodianBalance.DBcmd_TP != null) return SavedFilesCustodianBalance.DBcmd_TP;

            SavedFilesCustodianBalance.DBcmd_TP = new HssUtility.SQLserver.CmdTemplate();
            SavedFilesCustodianBalance.DBcmd_TP.tableName = "SavedFilesCustodianBalance";
            SavedFilesCustodianBalance.DBcmd_TP.schema = "RECEIVEFILE";

            SavedFilesCustodianBalance.DBcmd_TP.AddColumn("id_SavedFilesCustodianBalance");
            SavedFilesCustodianBalance.DBcmd_TP.AddColumn("originalFileName");/*Optional 2*/
            SavedFilesCustodianBalance.DBcmd_TP.AddColumn("SavedFiles_XML_CB");
            SavedFilesCustodianBalance.DBcmd_TP.AddColumn("AnnouncementName");
            SavedFilesCustodianBalance.DBcmd_TP.AddColumn("AnnouncementSender");
            SavedFilesCustodianBalance.DBcmd_TP.AddColumn("AnnouncementIdentifier");
            SavedFilesCustodianBalance.DBcmd_TP.AddColumn("AnnouncementDate");
            SavedFilesCustodianBalance.DBcmd_TP.AddColumn("UniqueUniversalEventIdentifier");
            SavedFilesCustodianBalance.DBcmd_TP.AddColumn("SECURITY_IDENTIFIER_CUSIP");
            SavedFilesCustodianBalance.DBcmd_TP.AddColumn("ISSUER_NAME");
            SavedFilesCustodianBalance.DBcmd_TP.AddColumn("ADR_RECORD_DATE");
            SavedFilesCustodianBalance.DBcmd_TP.AddColumn("ADRBase");/*Optional 12*/
            SavedFilesCustodianBalance.DBcmd_TP.AddColumn("OrdinaryShare");/*Optional 13*/
            SavedFilesCustodianBalance.DBcmd_TP.AddColumn("source");
            SavedFilesCustodianBalance.DBcmd_TP.AddColumn("processState");
            SavedFilesCustodianBalance.DBcmd_TP.AddColumn("WhenProcessed");/*Optional 16*/
            SavedFilesCustodianBalance.DBcmd_TP.AddColumn("Processedby");/*Optional 17*/
            SavedFilesCustodianBalance.DBcmd_TP.AddColumn("flgLock");/*Optional 18*/
            SavedFilesCustodianBalance.DBcmd_TP.AddColumn("WhenLocked_date");/*Optional 19*/
            SavedFilesCustodianBalance.DBcmd_TP.AddColumn("LockedBy_userid");/*Optional 20*/
            SavedFilesCustodianBalance.DBcmd_TP.AddColumn("createdby");
            SavedFilesCustodianBalance.DBcmd_TP.AddColumn("createddate");
            SavedFilesCustodianBalance.DBcmd_TP.AddColumn("ID_GTS_SFTP_InputSITEs");/*Optional 23*/

            return SavedFilesCustodianBalance.DBcmd_TP;
        }

        public SavedFilesCustodianBalance() { }
        public SavedFilesCustodianBalance(int id) { this.pk_ID = id; }

        private int pk_ID = -1; //primary key
        public int id_SavedFilesCustodianBalance { get { return this.pk_ID; } }

        public readonly HssUtility.General.Attributes.String_attr originalFileName = new HssUtility.General.Attributes.String_attr();/*Optional 2*/
        public byte[] SavedFiles_XML_CB = null;
        public readonly HssUtility.General.Attributes.String_attr AnnouncementName = new HssUtility.General.Attributes.String_attr();
        public readonly HssUtility.General.Attributes.String_attr AnnouncementSender = new HssUtility.General.Attributes.String_attr();
        public readonly HssUtility.General.Attributes.String_attr AnnouncementIdentifier = new HssUtility.General.Attributes.String_attr();
        public readonly HssUtility.General.Attributes.String_attr AnnouncementDate = new HssUtility.General.Attributes.String_attr();
        public readonly HssUtility.General.Attributes.String_attr UniqueUniversalEventIdentifier = new HssUtility.General.Attributes.String_attr();
        public readonly HssUtility.General.Attributes.String_attr SECURITY_IDENTIFIER_CUSIP = new HssUtility.General.Attributes.String_attr();
        public readonly HssUtility.General.Attributes.String_attr ISSUER_NAME = new HssUtility.General.Attributes.String_attr();
        public readonly HssUtility.General.Attributes.String_attr ADR_RECORD_DATE = new HssUtility.General.Attributes.String_attr();
        public readonly HssUtility.General.Attributes.String_attr ADRBase = new HssUtility.General.Attributes.String_attr();/*Optional 12*/
        public readonly HssUtility.General.Attributes.String_attr OrdinaryShare = new HssUtility.General.Attributes.String_attr();/*Optional 13*/
        public readonly HssUtility.General.Attributes.String_attr source = new HssUtility.General.Attributes.String_attr();
        public readonly HssUtility.General.Attributes.Int_attr processState = new HssUtility.General.Attributes.Int_attr();
        public readonly HssUtility.General.Attributes.DateTime_attr WhenProcessed = new HssUtility.General.Attributes.DateTime_attr();/*Optional 16*/
        public readonly HssUtility.General.Attributes.String_attr Processedby = new HssUtility.General.Attributes.String_attr();/*Optional 17*/
        public readonly HssUtility.General.Attributes.Bool_attr flgLock = new HssUtility.General.Attributes.Bool_attr();/*Optional 18*/
        public readonly HssUtility.General.Attributes.DateTime_attr WhenLocked_date = new HssUtility.General.Attributes.DateTime_attr();/*Optional 19*/
        public readonly HssUtility.General.Attributes.String_attr LockedBy_userid = new HssUtility.General.Attributes.String_attr();/*Optional 20*/
        public readonly HssUtility.General.Attributes.String_attr createdby = new HssUtility.General.Attributes.String_attr();
        public readonly HssUtility.General.Attributes.DateTime_attr createddate = new HssUtility.General.Attributes.DateTime_attr();
        public readonly HssUtility.General.Attributes.Int_attr ID_GTS_SFTP_InputSITEs = new HssUtility.General.Attributes.Int_attr();/*Optional 23*/

        private List<HssUtility.General.Attributes.I_modelAttr> attrList = null;

        internal void Init_from_reader(HssUtility.SQLserver.DB_reader reader)
        {
            if (reader == null || reader.IsClosed) return;

            this.pk_ID = reader.GetInt("id_SavedFilesCustodianBalance");
            reader.GetString("originalFileName", this.originalFileName);/*Optional 2*/
            this.SavedFiles_XML_CB = reader.GetBytes("SavedFiles_XML_CB");
            reader.GetString("AnnouncementName", this.AnnouncementName);
            reader.GetString("AnnouncementSender", this.AnnouncementSender);
            reader.GetString("AnnouncementIdentifier", this.AnnouncementIdentifier);
            reader.GetString("AnnouncementDate", this.AnnouncementDate);
            reader.GetString("UniqueUniversalEventIdentifier", this.UniqueUniversalEventIdentifier);
            reader.GetString("SECURITY_IDENTIFIER_CUSIP", this.SECURITY_IDENTIFIER_CUSIP);
            reader.GetString("ISSUER_NAME", this.ISSUER_NAME);
            reader.GetString("ADR_RECORD_DATE", this.ADR_RECORD_DATE);
            reader.GetString("ADRBase", this.ADRBase);/*Optional 12*/
            reader.GetString("OrdinaryShare", this.OrdinaryShare);/*Optional 13*/
            reader.GetString("source", this.source);
            reader.GetInt("processState", this.processState);
            reader.GetDateTime("WhenProcessed", this.WhenProcessed);/*Optional 16*/
            reader.GetString("Processedby", this.Processedby);/*Optional 17*/
            reader.GetBool("flgLock", this.flgLock);/*Optional 18*/
            reader.GetDateTime("WhenLocked_date", this.WhenLocked_date);/*Optional 19*/
            reader.GetString("LockedBy_userid", this.LockedBy_userid);/*Optional 20*/
            reader.GetString("createdby", this.createdby);
            reader.GetDateTime("createddate", this.createddate);
            reader.GetInt("ID_GTS_SFTP_InputSITEs", this.ID_GTS_SFTP_InputSITEs);/*Optional 23*/

            this.SyncWithDB();
        }

        /// <summary>
        /// Initialize object from DB
        /// </summary>
        public bool Init_from_DB()
        {
            if (this.id_SavedFilesCustodianBalance < 0) return false;

            HssUtility.SQLserver.DB_select db_sel = new HssUtility.SQLserver.DB_select(SavedFilesCustodianBalance.Get_cmdTP());
            db_sel.tableName = "SavedFilesCustodianBalance";
            HssUtility.SQLserver.SQL_relation rela = new HssUtility.SQLserver.SQL_relation("id_SavedFilesCustodianBalance", HssUtility.General.RelationalOperator.Equals, this.id_SavedFilesCustodianBalance);
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
            this.attrList.Add(this.originalFileName);/*Optional 2*/
            //this.attrList.Add(this.SavedFiles_XML_CB);
            this.attrList.Add(this.AnnouncementName);
            this.attrList.Add(this.AnnouncementSender);
            this.attrList.Add(this.AnnouncementIdentifier);
            this.attrList.Add(this.AnnouncementDate);
            this.attrList.Add(this.UniqueUniversalEventIdentifier);
            this.attrList.Add(this.SECURITY_IDENTIFIER_CUSIP);
            this.attrList.Add(this.ISSUER_NAME);
            this.attrList.Add(this.ADR_RECORD_DATE);
            this.attrList.Add(this.ADRBase);/*Optional 12*/
            this.attrList.Add(this.OrdinaryShare);/*Optional 13*/
            this.attrList.Add(this.source);
            this.attrList.Add(this.processState);
            this.attrList.Add(this.WhenProcessed);/*Optional 16*/
            this.attrList.Add(this.Processedby);/*Optional 17*/
            this.attrList.Add(this.flgLock);/*Optional 18*/
            this.attrList.Add(this.WhenLocked_date);/*Optional 19*/
            this.attrList.Add(this.LockedBy_userid);/*Optional 20*/
            this.attrList.Add(this.createdby);
            this.attrList.Add(this.createddate);
            this.attrList.Add(this.ID_GTS_SFTP_InputSITEs);/*Optional 23*/
        }

        /// <summary>
        /// insert object to DB
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
            HssUtility.SQLserver.DB_insert dbIns = new HssUtility.SQLserver.DB_insert(SavedFilesCustodianBalance.Get_cmdTP());

            dbIns.AddValue("originalFileName", this.originalFileName);/*Optional 2*/
            dbIns.AddValue("SavedFiles_XML_CB", this.SavedFiles_XML_CB);
            dbIns.AddValue("AnnouncementName", this.AnnouncementName.Value);
            dbIns.AddValue("AnnouncementSender", this.AnnouncementSender.Value);
            dbIns.AddValue("AnnouncementIdentifier", this.AnnouncementIdentifier.Value);
            dbIns.AddValue("AnnouncementDate", this.AnnouncementDate.Value);
            dbIns.AddValue("UniqueUniversalEventIdentifier", this.UniqueUniversalEventIdentifier.Value);
            dbIns.AddValue("SECURITY_IDENTIFIER_CUSIP", this.SECURITY_IDENTIFIER_CUSIP.Value);
            dbIns.AddValue("ISSUER_NAME", this.ISSUER_NAME.Value);
            dbIns.AddValue("ADR_RECORD_DATE", this.ADR_RECORD_DATE.Value);
            dbIns.AddValue("ADRBase", this.ADRBase);/*Optional 12*/
            dbIns.AddValue("OrdinaryShare", this.OrdinaryShare);/*Optional 13*/
            dbIns.AddValue("source", this.source.Value);
            dbIns.AddValue("processState", this.processState.Value);
            dbIns.AddValue("WhenProcessed", this.WhenProcessed);/*Optional 16*/
            dbIns.AddValue("Processedby", this.Processedby);/*Optional 17*/
            dbIns.AddValue("flgLock", this.flgLock);/*Optional 18*/
            dbIns.AddValue("WhenLocked_date", this.WhenLocked_date);/*Optional 19*/
            dbIns.AddValue("LockedBy_userid", this.LockedBy_userid);/*Optional 20*/
            dbIns.AddValue("createdby", this.createdby.Value);
            dbIns.AddValue("createddate", this.createddate.Value);
            dbIns.AddValue("ID_GTS_SFTP_InputSITEs", this.ID_GTS_SFTP_InputSITEs);/*Optional 23*/

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

            HssUtility.SQLserver.DB_update upd = new HssUtility.SQLserver.DB_update(SavedFilesCustodianBalance.Get_cmdTP());
            if (this.originalFileName.ValueChanged) upd.AddValue("originalFileName", this.originalFileName);
            //if (this.SavedFiles_XML_CB.ValueChanged) upd.AddValue("SavedFiles_XML_CB", this.SavedFiles_XML_CB);
            if (this.AnnouncementName.ValueChanged) upd.AddValue("AnnouncementName", this.AnnouncementName);
            if (this.AnnouncementSender.ValueChanged) upd.AddValue("AnnouncementSender", this.AnnouncementSender);
            if (this.AnnouncementIdentifier.ValueChanged) upd.AddValue("AnnouncementIdentifier", this.AnnouncementIdentifier);
            if (this.AnnouncementDate.ValueChanged) upd.AddValue("AnnouncementDate", this.AnnouncementDate);
            if (this.UniqueUniversalEventIdentifier.ValueChanged) upd.AddValue("UniqueUniversalEventIdentifier", this.UniqueUniversalEventIdentifier);
            if (this.SECURITY_IDENTIFIER_CUSIP.ValueChanged) upd.AddValue("SECURITY_IDENTIFIER_CUSIP", this.SECURITY_IDENTIFIER_CUSIP);
            if (this.ISSUER_NAME.ValueChanged) upd.AddValue("ISSUER_NAME", this.ISSUER_NAME);
            if (this.ADR_RECORD_DATE.ValueChanged) upd.AddValue("ADR_RECORD_DATE", this.ADR_RECORD_DATE);
            if (this.ADRBase.ValueChanged) upd.AddValue("ADRBase", this.ADRBase);
            if (this.OrdinaryShare.ValueChanged) upd.AddValue("OrdinaryShare", this.OrdinaryShare);
            if (this.source.ValueChanged) upd.AddValue("source", this.source);
            if (this.processState.ValueChanged) upd.AddValue("processState", this.processState);
            if (this.WhenProcessed.ValueChanged) upd.AddValue("WhenProcessed", this.WhenProcessed);
            if (this.Processedby.ValueChanged) upd.AddValue("Processedby", this.Processedby);
            if (this.flgLock.ValueChanged) upd.AddValue("flgLock", this.flgLock);
            if (this.WhenLocked_date.ValueChanged) upd.AddValue("WhenLocked_date", this.WhenLocked_date);
            if (this.LockedBy_userid.ValueChanged) upd.AddValue("LockedBy_userid", this.LockedBy_userid);
            if (this.createdby.ValueChanged) upd.AddValue("createdby", this.createdby);
            if (this.createddate.ValueChanged) upd.AddValue("createddate", this.createddate);
            if (this.ID_GTS_SFTP_InputSITEs.ValueChanged) upd.AddValue("ID_GTS_SFTP_InputSITEs", this.ID_GTS_SFTP_InputSITEs);

            HssUtility.SQLserver.SQL_relation rela = new HssUtility.SQLserver.SQL_relation("id_SavedFilesCustodianBalance", HssUtility.General.RelationalOperator.Equals, this.pk_ID);
            upd.SetCondition(rela);

            return upd;
        }

        public SavedFilesCustodianBalance GetCopy()
        {
            SavedFilesCustodianBalance newEntity = new SavedFilesCustodianBalance();
            if (!this.originalFileName.IsNull_flag) newEntity.originalFileName.Value = this.originalFileName.Value;
            //if (!this.SavedFiles_XML_CB.IsNull_flag) newEntity.SavedFiles_XML_CB.Value = this.SavedFiles_XML_CB.Value;
            if (!this.AnnouncementName.IsNull_flag) newEntity.AnnouncementName.Value = this.AnnouncementName.Value;
            if (!this.AnnouncementSender.IsNull_flag) newEntity.AnnouncementSender.Value = this.AnnouncementSender.Value;
            if (!this.AnnouncementIdentifier.IsNull_flag) newEntity.AnnouncementIdentifier.Value = this.AnnouncementIdentifier.Value;
            if (!this.AnnouncementDate.IsNull_flag) newEntity.AnnouncementDate.Value = this.AnnouncementDate.Value;
            if (!this.UniqueUniversalEventIdentifier.IsNull_flag) newEntity.UniqueUniversalEventIdentifier.Value = this.UniqueUniversalEventIdentifier.Value;
            if (!this.SECURITY_IDENTIFIER_CUSIP.IsNull_flag) newEntity.SECURITY_IDENTIFIER_CUSIP.Value = this.SECURITY_IDENTIFIER_CUSIP.Value;
            if (!this.ISSUER_NAME.IsNull_flag) newEntity.ISSUER_NAME.Value = this.ISSUER_NAME.Value;
            if (!this.ADR_RECORD_DATE.IsNull_flag) newEntity.ADR_RECORD_DATE.Value = this.ADR_RECORD_DATE.Value;
            if (!this.ADRBase.IsNull_flag) newEntity.ADRBase.Value = this.ADRBase.Value;
            if (!this.OrdinaryShare.IsNull_flag) newEntity.OrdinaryShare.Value = this.OrdinaryShare.Value;
            if (!this.source.IsNull_flag) newEntity.source.Value = this.source.Value;
            if (!this.processState.IsNull_flag) newEntity.processState.Value = this.processState.Value;
            if (!this.WhenProcessed.IsNull_flag) newEntity.WhenProcessed.Value = this.WhenProcessed.Value;
            if (!this.Processedby.IsNull_flag) newEntity.Processedby.Value = this.Processedby.Value;
            if (!this.flgLock.IsNull_flag) newEntity.flgLock.Value = this.flgLock.Value;
            if (!this.WhenLocked_date.IsNull_flag) newEntity.WhenLocked_date.Value = this.WhenLocked_date.Value;
            if (!this.LockedBy_userid.IsNull_flag) newEntity.LockedBy_userid.Value = this.LockedBy_userid.Value;
            if (!this.createdby.IsNull_flag) newEntity.createdby.Value = this.createdby.Value;
            if (!this.createddate.IsNull_flag) newEntity.createddate.Value = this.createddate.Value;
            if (!this.ID_GTS_SFTP_InputSITEs.IsNull_flag) newEntity.ID_GTS_SFTP_InputSITEs.Value = this.ID_GTS_SFTP_InputSITEs.Value;
            return newEntity;
        }

        public string ToXML()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("<SavedFilesCustodianBalance>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<id_SavedFilesCustodianBalance>").Append(this.id_SavedFilesCustodianBalance).Append("</id_SavedFilesCustodianBalance>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<originalFileName>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.originalFileName.Value)).Append("</originalFileName>").Append(HssUtility.General.HssStr.WinNextLine);
            //sb.Append("<SavedFiles_XML_CB>").Append(this.SavedFiles_XML_CB.Value).Append("</SavedFiles_XML_CB>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<AnnouncementName>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.AnnouncementName.Value)).Append("</AnnouncementName>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<AnnouncementSender>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.AnnouncementSender.Value)).Append("</AnnouncementSender>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<AnnouncementIdentifier>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.AnnouncementIdentifier.Value)).Append("</AnnouncementIdentifier>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<AnnouncementDate>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.AnnouncementDate.Value)).Append("</AnnouncementDate>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<UniqueUniversalEventIdentifier>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.UniqueUniversalEventIdentifier.Value)).Append("</UniqueUniversalEventIdentifier>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<SECURITY_IDENTIFIER_CUSIP>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.SECURITY_IDENTIFIER_CUSIP.Value)).Append("</SECURITY_IDENTIFIER_CUSIP>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<ISSUER_NAME>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.ISSUER_NAME.Value)).Append("</ISSUER_NAME>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<ADR_RECORD_DATE>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.ADR_RECORD_DATE.Value)).Append("</ADR_RECORD_DATE>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<ADRBase>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.ADRBase.Value)).Append("</ADRBase>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<OrdinaryShare>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.OrdinaryShare.Value)).Append("</OrdinaryShare>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<source>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.source.Value)).Append("</source>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<processState>").Append(this.processState.Value).Append("</processState>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<WhenProcessed>").Append(this.WhenProcessed.Value).Append("</WhenProcessed>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Processedby>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.Processedby.Value)).Append("</Processedby>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<flgLock>").Append(this.flgLock.Value).Append("</flgLock>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<WhenLocked_date>").Append(this.WhenLocked_date.Value).Append("</WhenLocked_date>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<LockedBy_userid>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.LockedBy_userid.Value)).Append("</LockedBy_userid>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<createdby>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.createdby.Value)).Append("</createdby>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<createddate>").Append(this.createddate.Value).Append("</createddate>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<ID_GTS_SFTP_InputSITEs>").Append(this.ID_GTS_SFTP_InputSITEs.Value).Append("</ID_GTS_SFTP_InputSITEs>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("</SavedFilesCustodianBalance>").Append(HssUtility.General.HssStr.WinNextLine);
            return sb.ToString();
        }
        /*^^^^^^^^^^^^^^^^^^^^^^^^^^^^^Hss Entity Framework Auto Generated Code^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^*/
    }
}
