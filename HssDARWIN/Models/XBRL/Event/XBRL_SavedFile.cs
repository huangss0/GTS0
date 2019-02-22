using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
using System.Data;

using HssUtility.Text.XML;
using HssDARWIN.Models.XBRL.Event;

namespace HssDARWIN.Models.XBRL.Event
{
    public class XBRL_SavedFile
    {
        /*-----------------------------Hss Entity Framework Auto Generated Code-------------------------------*/
        private static HssUtility.SQLserver.CmdTemplate DBcmd_TP = null;
        public static HssUtility.SQLserver.CmdTemplate Get_cmdTP()
        {
            if (XBRL_SavedFile.DBcmd_TP != null) return XBRL_SavedFile.DBcmd_TP;

            XBRL_SavedFile.DBcmd_TP = new HssUtility.SQLserver.CmdTemplate();
            XBRL_SavedFile.DBcmd_TP.tableName = "SavedFiles";
            XBRL_SavedFile.DBcmd_TP.schema = "RECEIVEFILE";

            XBRL_SavedFile.DBcmd_TP.AddColumn("id_SavedfilesRcvd");
            XBRL_SavedFile.DBcmd_TP.AddColumn("savedfile");
            XBRL_SavedFile.DBcmd_TP.AddColumn("EventType");
            XBRL_SavedFile.DBcmd_TP.AddColumn("DRWINIncomeEventID");/*Optional 4*/
            XBRL_SavedFile.DBcmd_TP.AddColumn("cusip");/*Optional 5*/
            XBRL_SavedFile.DBcmd_TP.AddColumn("ISIN");/*Optional 6*/
            XBRL_SavedFile.DBcmd_TP.AddColumn("originalFileName");/*Optional 7*/
            XBRL_SavedFile.DBcmd_TP.AddColumn("DepositaryName");/*Optional 8*/
            XBRL_SavedFile.DBcmd_TP.AddColumn("AnnouncementDate");/*Optional 9*/
            XBRL_SavedFile.DBcmd_TP.AddColumn("EventCompleteness");/*Optional 10*/
            XBRL_SavedFile.DBcmd_TP.AddColumn("UniqueUniversalEventIdentifier");/*Optional 11*/
            XBRL_SavedFile.DBcmd_TP.AddColumn("DepositoryReceiptSponsorIndicator");/*Optional 12*/
            XBRL_SavedFile.DBcmd_TP.AddColumn("PaymentDate");/*Optional 13*/
            XBRL_SavedFile.DBcmd_TP.AddColumn("RecordDate");/*Optional 14*/
            XBRL_SavedFile.DBcmd_TP.AddColumn("CountryOfIssue");/*Optional 15*/
            XBRL_SavedFile.DBcmd_TP.AddColumn("ContextRefBase");/*Optional 16*/
            XBRL_SavedFile.DBcmd_TP.AddColumn("Source");/*Optional 17*/
            XBRL_SavedFile.DBcmd_TP.AddColumn("processState");
            XBRL_SavedFile.DBcmd_TP.AddColumn("WhenProcessed");/*Optional 19*/
            XBRL_SavedFile.DBcmd_TP.AddColumn("Processedby");/*Optional 20*/
            XBRL_SavedFile.DBcmd_TP.AddColumn("flgLock");/*Optional 21*/
            XBRL_SavedFile.DBcmd_TP.AddColumn("WhenLocked_date");/*Optional 22*/
            XBRL_SavedFile.DBcmd_TP.AddColumn("LockedBy_userid");/*Optional 23*/
            XBRL_SavedFile.DBcmd_TP.AddColumn("createdby");
            XBRL_SavedFile.DBcmd_TP.AddColumn("createddate");
            XBRL_SavedFile.DBcmd_TP.AddColumn("AnnouncementIdentifier");/*Optional 26*/
            XBRL_SavedFile.DBcmd_TP.AddColumn("FirstFilerFlag");/*Optional 27*/
            XBRL_SavedFile.DBcmd_TP.AddColumn("UnderlyingSecurityIssuerCountryofIncorporation");/*Optional 28*/
            XBRL_SavedFile.DBcmd_TP.AddColumn("id_SavedFiles_CSV");/*Optional 29*/
            XBRL_SavedFile.DBcmd_TP.AddColumn("DividendIndex");/*Optional 30*/
            XBRL_SavedFile.DBcmd_TP.AddColumn("AnnouncementType");/*Optional 31*/
            XBRL_SavedFile.DBcmd_TP.AddColumn("ID_GTS_SFTP_InputSITEs");/*Optional 32*/
            XBRL_SavedFile.DBcmd_TP.AddColumn("recNum");/*Optional 33*/
            XBRL_SavedFile.DBcmd_TP.AddColumn("flgEmailSent");/*Optional 34*/
            XBRL_SavedFile.DBcmd_TP.AddColumn("EmailSentDate");/*Optional 35*/

            return XBRL_SavedFile.DBcmd_TP;
        }

        public XBRL_SavedFile() { }
        public XBRL_SavedFile(int id) { this.pk_ID = id; }

        private int pk_ID = -1; //primary key
        public int id_SavedfilesRcvd { get { return this.pk_ID; } }

        public byte[] savedfile = null; //XBRL byte array
        public readonly HssUtility.General.Attributes.String_attr EventType = new HssUtility.General.Attributes.String_attr("Cash Dividend");
        public readonly HssUtility.General.Attributes.String_attr DRWINIncomeEventID = new HssUtility.General.Attributes.String_attr();/*Optional 4*/
        public readonly HssUtility.General.Attributes.String_attr cusip = new HssUtility.General.Attributes.String_attr();/*Optional 5*/
        public readonly HssUtility.General.Attributes.String_attr ISIN = new HssUtility.General.Attributes.String_attr();/*Optional 6*/
        public readonly HssUtility.General.Attributes.String_attr originalFileName = new HssUtility.General.Attributes.String_attr();/*Optional 7*/
        public readonly HssUtility.General.Attributes.String_attr DepositaryName = new HssUtility.General.Attributes.String_attr();/*Optional 8*/
        public readonly HssUtility.General.Attributes.DateTime_attr AnnouncementDate = new HssUtility.General.Attributes.DateTime_attr();/*Optional 9*/
        public readonly HssUtility.General.Attributes.String_attr EventCompleteness = new HssUtility.General.Attributes.String_attr();/*Optional 10*/
        public readonly HssUtility.General.Attributes.String_attr UniqueUniversalEventIdentifier = new HssUtility.General.Attributes.String_attr();/*Optional 11*/
        public readonly HssUtility.General.Attributes.Bool_attr DepositoryReceiptSponsorIndicator = new HssUtility.General.Attributes.Bool_attr();/*Optional 12*/
        public readonly HssUtility.General.Attributes.DateTime_attr PaymentDate = new HssUtility.General.Attributes.DateTime_attr();/*Optional 13*/
        public readonly HssUtility.General.Attributes.DateTime_attr RecordDate = new HssUtility.General.Attributes.DateTime_attr();/*Optional 14*/
        public readonly HssUtility.General.Attributes.String_attr CountryOfIssue = new HssUtility.General.Attributes.String_attr();/*Optional 15*/
        public readonly HssUtility.General.Attributes.String_attr ContextRefBase = new HssUtility.General.Attributes.String_attr();/*Optional 16*/
        public readonly HssUtility.General.Attributes.String_attr Source = new HssUtility.General.Attributes.String_attr();/*Optional 17*/
        public readonly HssUtility.General.Attributes.Int_attr processState = new HssUtility.General.Attributes.Int_attr(0);
        public readonly HssUtility.General.Attributes.DateTime_attr WhenProcessed = new HssUtility.General.Attributes.DateTime_attr();/*Optional 19*/
        public readonly HssUtility.General.Attributes.String_attr Processedby = new HssUtility.General.Attributes.String_attr();/*Optional 20*/
        public readonly HssUtility.General.Attributes.Bool_attr flgLock = new HssUtility.General.Attributes.Bool_attr();/*Optional 21*/
        public readonly HssUtility.General.Attributes.DateTime_attr WhenLocked_date = new HssUtility.General.Attributes.DateTime_attr();/*Optional 22*/
        public readonly HssUtility.General.Attributes.String_attr LockedBy_userid = new HssUtility.General.Attributes.String_attr();/*Optional 23*/
        public readonly HssUtility.General.Attributes.String_attr createdby = new HssUtility.General.Attributes.String_attr(Utility.CurrentUser);
        public readonly HssUtility.General.Attributes.DateTime_attr createddate = new HssUtility.General.Attributes.DateTime_attr(DateTime.Now);
        public readonly HssUtility.General.Attributes.Int_attr AnnouncementIdentifier = new HssUtility.General.Attributes.Int_attr();/*Optional 26*/
        public readonly HssUtility.General.Attributes.Bool_attr FirstFilerFlag = new HssUtility.General.Attributes.Bool_attr();/*Optional 27*/
        public readonly HssUtility.General.Attributes.String_attr UnderlyingSecurityIssuerCountryofIncorporation = new HssUtility.General.Attributes.String_attr();/*Optional 28*/
        public readonly HssUtility.General.Attributes.Int_attr id_SavedFiles_CSV = new HssUtility.General.Attributes.Int_attr();/*Optional 29*/
        public readonly HssUtility.General.Attributes.Int_attr DividendIndex = new HssUtility.General.Attributes.Int_attr();/*Optional 30*/
        public readonly HssUtility.General.Attributes.String_attr AnnouncementType = new HssUtility.General.Attributes.String_attr();/*Optional 31*/
        public readonly HssUtility.General.Attributes.Int_attr ID_GTS_SFTP_InputSITEs = new HssUtility.General.Attributes.Int_attr();/*Optional 32*/
        public readonly HssUtility.General.Attributes.Int_attr recNum = new HssUtility.General.Attributes.Int_attr();/*Optional 33*/
        public readonly HssUtility.General.Attributes.Bool_attr flgEmailSent = new HssUtility.General.Attributes.Bool_attr();/*Optional 34*/
        public readonly HssUtility.General.Attributes.DateTime_attr EmailSentDate = new HssUtility.General.Attributes.DateTime_attr();/*Optional 35*/

        private List<HssUtility.General.Attributes.I_modelAttr> attrList = null;

        internal void Init_from_reader(HssUtility.SQLserver.DB_reader reader)
        {
            if (reader == null || reader.IsClosed) return;

            this.pk_ID = reader.GetInt("id_SavedfilesRcvd");

            this.savedfile = reader.GetBytes("savedfile");
            reader.GetString("EventType", this.EventType);
            reader.GetString("DRWINIncomeEventID", this.DRWINIncomeEventID);/*Optional 4*/
            reader.GetString("cusip", this.cusip);/*Optional 5*/
            reader.GetString("ISIN", this.ISIN);/*Optional 6*/
            reader.GetString("originalFileName", this.originalFileName);/*Optional 7*/
            reader.GetString("DepositaryName", this.DepositaryName);/*Optional 8*/
            reader.GetDateTime("AnnouncementDate", this.AnnouncementDate);/*Optional 9*/
            reader.GetString("EventCompleteness", this.EventCompleteness);/*Optional 10*/
            reader.GetString("UniqueUniversalEventIdentifier", this.UniqueUniversalEventIdentifier);/*Optional 11*/
            reader.GetBool("DepositoryReceiptSponsorIndicator", this.DepositoryReceiptSponsorIndicator);/*Optional 12*/
            reader.GetDateTime("PaymentDate", this.PaymentDate);/*Optional 13*/
            reader.GetDateTime("RecordDate", this.RecordDate);/*Optional 14*/
            reader.GetString("CountryOfIssue", this.CountryOfIssue);/*Optional 15*/
            reader.GetString("ContextRefBase", this.ContextRefBase);/*Optional 16*/
            reader.GetString("Source", this.Source);/*Optional 17*/
            reader.GetInt("processState", this.processState);
            reader.GetDateTime("WhenProcessed", this.WhenProcessed);/*Optional 19*/
            reader.GetString("Processedby", this.Processedby);/*Optional 20*/
            reader.GetBool("flgLock", this.flgLock);/*Optional 21*/
            reader.GetDateTime("WhenLocked_date", this.WhenLocked_date);/*Optional 22*/
            reader.GetString("LockedBy_userid", this.LockedBy_userid);/*Optional 23*/
            reader.GetString("createdby", this.createdby);
            reader.GetDateTime("createddate", this.createddate);
            reader.GetInt("AnnouncementIdentifier", this.AnnouncementIdentifier);/*Optional 26*/
            reader.GetBool("FirstFilerFlag", this.FirstFilerFlag);/*Optional 27*/
            reader.GetString("UnderlyingSecurityIssuerCountryofIncorporation", this.UnderlyingSecurityIssuerCountryofIncorporation);/*Optional 28*/
            reader.GetInt("id_SavedFiles_CSV", this.id_SavedFiles_CSV);/*Optional 29*/
            reader.GetInt("DividendIndex", this.DividendIndex);/*Optional 30*/
            reader.GetString("AnnouncementType", this.AnnouncementType);/*Optional 31*/
            reader.GetInt("ID_GTS_SFTP_InputSITEs", this.ID_GTS_SFTP_InputSITEs);/*Optional 32*/
            reader.GetInt("recNum", this.recNum);/*Optional 33*/
            reader.GetBool("flgEmailSent", this.flgEmailSent);/*Optional 34*/
            reader.GetDateTime("EmailSentDate", this.EmailSentDate);/*Optional 35*/

            this.SyncWithDB();
        }

        /// <summary>
        /// Initialize object from DB
        /// </summary>
        public bool Init_from_DB(bool ignore_savedfile)
        {
            if (this.id_SavedfilesRcvd < 0) return false;

            HssUtility.SQLserver.DB_select db_sel = new HssUtility.SQLserver.DB_select(XBRL_SavedFile.Get_cmdTP());
            if (ignore_savedfile) db_sel.IgnoreColumn("savedfile");
            db_sel.tableName = "SavedFiles";
            HssUtility.SQLserver.SQL_relation rela = new HssUtility.SQLserver.SQL_relation("id_SavedfilesRcvd", HssUtility.General.RelationalOperator.Equals, this.id_SavedfilesRcvd);
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
            //this.attrList.Add(this.savedfile);
            this.attrList.Add(this.EventType);
            this.attrList.Add(this.DRWINIncomeEventID);/*Optional 4*/
            this.attrList.Add(this.cusip);/*Optional 5*/
            this.attrList.Add(this.ISIN);/*Optional 6*/
            this.attrList.Add(this.originalFileName);/*Optional 7*/
            this.attrList.Add(this.DepositaryName);/*Optional 8*/
            this.attrList.Add(this.AnnouncementDate);/*Optional 9*/
            this.attrList.Add(this.EventCompleteness);/*Optional 10*/
            this.attrList.Add(this.UniqueUniversalEventIdentifier);/*Optional 11*/
            this.attrList.Add(this.DepositoryReceiptSponsorIndicator);/*Optional 12*/
            this.attrList.Add(this.PaymentDate);/*Optional 13*/
            this.attrList.Add(this.RecordDate);/*Optional 14*/
            this.attrList.Add(this.CountryOfIssue);/*Optional 15*/
            this.attrList.Add(this.ContextRefBase);/*Optional 16*/
            this.attrList.Add(this.Source);/*Optional 17*/
            this.attrList.Add(this.processState);
            this.attrList.Add(this.WhenProcessed);/*Optional 19*/
            this.attrList.Add(this.Processedby);/*Optional 20*/
            this.attrList.Add(this.flgLock);/*Optional 21*/
            this.attrList.Add(this.WhenLocked_date);/*Optional 22*/
            this.attrList.Add(this.LockedBy_userid);/*Optional 23*/
            this.attrList.Add(this.createdby);
            this.attrList.Add(this.createddate);
            this.attrList.Add(this.AnnouncementIdentifier);/*Optional 26*/
            this.attrList.Add(this.FirstFilerFlag);/*Optional 27*/
            this.attrList.Add(this.UnderlyingSecurityIssuerCountryofIncorporation);/*Optional 28*/
            this.attrList.Add(this.id_SavedFiles_CSV);/*Optional 29*/
            this.attrList.Add(this.DividendIndex);/*Optional 30*/
            this.attrList.Add(this.AnnouncementType);/*Optional 31*/
            this.attrList.Add(this.ID_GTS_SFTP_InputSITEs);/*Optional 32*/
            this.attrList.Add(this.recNum);/*Optional 33*/
            this.attrList.Add(this.flgEmailSent);/*Optional 34*/
            this.attrList.Add(this.EmailSentDate);/*Optional 35*/
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
            HssUtility.SQLserver.DB_insert dbIns = new HssUtility.SQLserver.DB_insert(XBRL_SavedFile.Get_cmdTP());

            dbIns.AddValue("savedfile", this.savedfile);
            dbIns.AddValue("EventType", this.EventType.Value);
            dbIns.AddValue("DRWINIncomeEventID", this.DRWINIncomeEventID);/*Optional 4*/
            dbIns.AddValue("cusip", this.cusip);/*Optional 5*/
            dbIns.AddValue("ISIN", this.ISIN);/*Optional 6*/
            dbIns.AddValue("originalFileName", this.originalFileName);/*Optional 7*/
            dbIns.AddValue("DepositaryName", this.DepositaryName);/*Optional 8*/
            dbIns.AddValue("AnnouncementDate", this.AnnouncementDate);/*Optional 9*/
            dbIns.AddValue("EventCompleteness", this.EventCompleteness);/*Optional 10*/
            dbIns.AddValue("UniqueUniversalEventIdentifier", this.UniqueUniversalEventIdentifier);/*Optional 11*/
            dbIns.AddValue("DepositoryReceiptSponsorIndicator", this.DepositoryReceiptSponsorIndicator);/*Optional 12*/
            dbIns.AddValue("PaymentDate", this.PaymentDate);/*Optional 13*/
            dbIns.AddValue("RecordDate", this.RecordDate);/*Optional 14*/
            dbIns.AddValue("CountryOfIssue", this.CountryOfIssue);/*Optional 15*/
            dbIns.AddValue("ContextRefBase", this.ContextRefBase);/*Optional 16*/
            dbIns.AddValue("Source", this.Source);/*Optional 17*/
            dbIns.AddValue("processState", this.processState.Value);
            dbIns.AddValue("WhenProcessed", this.WhenProcessed);/*Optional 19*/
            dbIns.AddValue("Processedby", this.Processedby);/*Optional 20*/
            dbIns.AddValue("flgLock", this.flgLock);/*Optional 21*/
            dbIns.AddValue("WhenLocked_date", this.WhenLocked_date);/*Optional 22*/
            dbIns.AddValue("LockedBy_userid", this.LockedBy_userid);/*Optional 23*/
            dbIns.AddValue("createdby", this.createdby.Value);
            dbIns.AddValue("createddate", this.createddate.Value);
            dbIns.AddValue("AnnouncementIdentifier", this.AnnouncementIdentifier);/*Optional 26*/
            dbIns.AddValue("FirstFilerFlag", this.FirstFilerFlag);/*Optional 27*/
            dbIns.AddValue("UnderlyingSecurityIssuerCountryofIncorporation", this.UnderlyingSecurityIssuerCountryofIncorporation);/*Optional 28*/
            dbIns.AddValue("id_SavedFiles_CSV", this.id_SavedFiles_CSV);/*Optional 29*/
            dbIns.AddValue("DividendIndex", this.DividendIndex);/*Optional 30*/
            dbIns.AddValue("AnnouncementType", this.AnnouncementType);/*Optional 31*/
            dbIns.AddValue("ID_GTS_SFTP_InputSITEs", this.ID_GTS_SFTP_InputSITEs);/*Optional 32*/
            dbIns.AddValue("recNum", this.recNum);/*Optional 33*/
            dbIns.AddValue("flgEmailSent", this.flgEmailSent);/*Optional 34*/
            dbIns.AddValue("EmailSentDate", this.EmailSentDate);/*Optional 35*/

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

            this.Processedby.Value = Utility.CurrentUser;
            this.WhenProcessed.Value = DateTime.Now;

            HssUtility.SQLserver.DB_update upd = new HssUtility.SQLserver.DB_update(XBRL_SavedFile.Get_cmdTP());
            //if (this.savedfile.ValueChanged) upd.AddValue("savedfile", this.savedfile); //no update for binary for now
            if (this.EventType.ValueChanged) upd.AddValue("EventType", this.EventType);
            if (this.DRWINIncomeEventID.ValueChanged) upd.AddValue("DRWINIncomeEventID", this.DRWINIncomeEventID);
            if (this.cusip.ValueChanged) upd.AddValue("cusip", this.cusip);
            if (this.ISIN.ValueChanged) upd.AddValue("ISIN", this.ISIN);
            if (this.originalFileName.ValueChanged) upd.AddValue("originalFileName", this.originalFileName);
            if (this.DepositaryName.ValueChanged) upd.AddValue("DepositaryName", this.DepositaryName);
            if (this.AnnouncementDate.ValueChanged) upd.AddValue("AnnouncementDate", this.AnnouncementDate);
            if (this.EventCompleteness.ValueChanged) upd.AddValue("EventCompleteness", this.EventCompleteness);
            if (this.UniqueUniversalEventIdentifier.ValueChanged) upd.AddValue("UniqueUniversalEventIdentifier", this.UniqueUniversalEventIdentifier);
            if (this.DepositoryReceiptSponsorIndicator.ValueChanged) upd.AddValue("DepositoryReceiptSponsorIndicator", this.DepositoryReceiptSponsorIndicator);
            if (this.PaymentDate.ValueChanged) upd.AddValue("PaymentDate", this.PaymentDate);
            if (this.RecordDate.ValueChanged) upd.AddValue("RecordDate", this.RecordDate);
            if (this.CountryOfIssue.ValueChanged) upd.AddValue("CountryOfIssue", this.CountryOfIssue);
            if (this.ContextRefBase.ValueChanged) upd.AddValue("ContextRefBase", this.ContextRefBase);
            if (this.Source.ValueChanged) upd.AddValue("Source", this.Source);
            if (this.processState.ValueChanged) upd.AddValue("processState", this.processState);
            if (this.WhenProcessed.ValueChanged) upd.AddValue("WhenProcessed", this.WhenProcessed);
            if (this.Processedby.ValueChanged) upd.AddValue("Processedby", this.Processedby);
            if (this.flgLock.ValueChanged) upd.AddValue("flgLock", this.flgLock);
            if (this.WhenLocked_date.ValueChanged) upd.AddValue("WhenLocked_date", this.WhenLocked_date);
            if (this.LockedBy_userid.ValueChanged) upd.AddValue("LockedBy_userid", this.LockedBy_userid);
            if (this.createdby.ValueChanged) upd.AddValue("createdby", this.createdby);
            if (this.createddate.ValueChanged) upd.AddValue("createddate", this.createddate);
            if (this.AnnouncementIdentifier.ValueChanged) upd.AddValue("AnnouncementIdentifier", this.AnnouncementIdentifier);
            if (this.FirstFilerFlag.ValueChanged) upd.AddValue("FirstFilerFlag", this.FirstFilerFlag);
            if (this.UnderlyingSecurityIssuerCountryofIncorporation.ValueChanged) upd.AddValue("UnderlyingSecurityIssuerCountryofIncorporation", this.UnderlyingSecurityIssuerCountryofIncorporation);
            if (this.id_SavedFiles_CSV.ValueChanged) upd.AddValue("id_SavedFiles_CSV", this.id_SavedFiles_CSV);
            if (this.DividendIndex.ValueChanged) upd.AddValue("DividendIndex", this.DividendIndex);
            if (this.AnnouncementType.ValueChanged) upd.AddValue("AnnouncementType", this.AnnouncementType);
            if (this.ID_GTS_SFTP_InputSITEs.ValueChanged) upd.AddValue("ID_GTS_SFTP_InputSITEs", this.ID_GTS_SFTP_InputSITEs);
            if (this.recNum.ValueChanged) upd.AddValue("recNum", this.recNum);
            if (this.flgEmailSent.ValueChanged) upd.AddValue("flgEmailSent", this.flgEmailSent);
            if (this.EmailSentDate.ValueChanged) upd.AddValue("EmailSentDate", this.EmailSentDate);

            HssUtility.SQLserver.SQL_relation rela = new HssUtility.SQLserver.SQL_relation("id_SavedfilesRcvd", HssUtility.General.RelationalOperator.Equals, this.pk_ID);
            upd.SetCondition(rela);

            return upd;
        }

        public XBRL_SavedFile GetCopy()
        {
            XBRL_SavedFile newEntity = new XBRL_SavedFile();
            //if (!this.savedfile.IsNull_flag) newEntity.savedfile.Value = this.savedfile.Value;
            if (!this.EventType.IsNull_flag) newEntity.EventType.Value = this.EventType.Value;
            if (!this.DRWINIncomeEventID.IsNull_flag) newEntity.DRWINIncomeEventID.Value = this.DRWINIncomeEventID.Value;
            if (!this.cusip.IsNull_flag) newEntity.cusip.Value = this.cusip.Value;
            if (!this.ISIN.IsNull_flag) newEntity.ISIN.Value = this.ISIN.Value;
            if (!this.originalFileName.IsNull_flag) newEntity.originalFileName.Value = this.originalFileName.Value;
            if (!this.DepositaryName.IsNull_flag) newEntity.DepositaryName.Value = this.DepositaryName.Value;
            if (!this.AnnouncementDate.IsNull_flag) newEntity.AnnouncementDate.Value = this.AnnouncementDate.Value;
            if (!this.EventCompleteness.IsNull_flag) newEntity.EventCompleteness.Value = this.EventCompleteness.Value;
            if (!this.UniqueUniversalEventIdentifier.IsNull_flag) newEntity.UniqueUniversalEventIdentifier.Value = this.UniqueUniversalEventIdentifier.Value;
            if (!this.DepositoryReceiptSponsorIndicator.IsNull_flag) newEntity.DepositoryReceiptSponsorIndicator.Value = this.DepositoryReceiptSponsorIndicator.Value;
            if (!this.PaymentDate.IsNull_flag) newEntity.PaymentDate.Value = this.PaymentDate.Value;
            if (!this.RecordDate.IsNull_flag) newEntity.RecordDate.Value = this.RecordDate.Value;
            if (!this.CountryOfIssue.IsNull_flag) newEntity.CountryOfIssue.Value = this.CountryOfIssue.Value;
            if (!this.ContextRefBase.IsNull_flag) newEntity.ContextRefBase.Value = this.ContextRefBase.Value;
            if (!this.Source.IsNull_flag) newEntity.Source.Value = this.Source.Value;
            if (!this.processState.IsNull_flag) newEntity.processState.Value = this.processState.Value;
            if (!this.WhenProcessed.IsNull_flag) newEntity.WhenProcessed.Value = this.WhenProcessed.Value;
            if (!this.Processedby.IsNull_flag) newEntity.Processedby.Value = this.Processedby.Value;
            if (!this.flgLock.IsNull_flag) newEntity.flgLock.Value = this.flgLock.Value;
            if (!this.WhenLocked_date.IsNull_flag) newEntity.WhenLocked_date.Value = this.WhenLocked_date.Value;
            if (!this.LockedBy_userid.IsNull_flag) newEntity.LockedBy_userid.Value = this.LockedBy_userid.Value;
            if (!this.createdby.IsNull_flag) newEntity.createdby.Value = this.createdby.Value;
            if (!this.createddate.IsNull_flag) newEntity.createddate.Value = this.createddate.Value;
            if (!this.AnnouncementIdentifier.IsNull_flag) newEntity.AnnouncementIdentifier.Value = this.AnnouncementIdentifier.Value;
            if (!this.FirstFilerFlag.IsNull_flag) newEntity.FirstFilerFlag.Value = this.FirstFilerFlag.Value;
            if (!this.UnderlyingSecurityIssuerCountryofIncorporation.IsNull_flag) newEntity.UnderlyingSecurityIssuerCountryofIncorporation.Value = this.UnderlyingSecurityIssuerCountryofIncorporation.Value;
            if (!this.id_SavedFiles_CSV.IsNull_flag) newEntity.id_SavedFiles_CSV.Value = this.id_SavedFiles_CSV.Value;
            if (!this.DividendIndex.IsNull_flag) newEntity.DividendIndex.Value = this.DividendIndex.Value;
            if (!this.AnnouncementType.IsNull_flag) newEntity.AnnouncementType.Value = this.AnnouncementType.Value;
            if (!this.ID_GTS_SFTP_InputSITEs.IsNull_flag) newEntity.ID_GTS_SFTP_InputSITEs.Value = this.ID_GTS_SFTP_InputSITEs.Value;
            if (!this.recNum.IsNull_flag) newEntity.recNum.Value = this.recNum.Value;
            if (!this.flgEmailSent.IsNull_flag) newEntity.flgEmailSent.Value = this.flgEmailSent.Value;
            if (!this.EmailSentDate.IsNull_flag) newEntity.EmailSentDate.Value = this.EmailSentDate.Value;
            return newEntity;
        }

        public string ToXML()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("<XBRL_SavedFile>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<id_SavedfilesRcvd>").Append(this.id_SavedfilesRcvd).Append("</id_SavedfilesRcvd>").Append(HssUtility.General.HssStr.WinNextLine);
            //sb.Append("<savedfile>").Append(this.savedfile.Value).Append("</savedfile>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<EventType>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.EventType.Value)).Append("</EventType>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<DRWINIncomeEventID>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.DRWINIncomeEventID.Value)).Append("</DRWINIncomeEventID>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<cusip>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.cusip.Value)).Append("</cusip>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<ISIN>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.ISIN.Value)).Append("</ISIN>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<originalFileName>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.originalFileName.Value)).Append("</originalFileName>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<DepositaryName>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.DepositaryName.Value)).Append("</DepositaryName>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<AnnouncementDate>").Append(this.AnnouncementDate.Value).Append("</AnnouncementDate>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<EventCompleteness>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.EventCompleteness.Value)).Append("</EventCompleteness>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<UniqueUniversalEventIdentifier>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.UniqueUniversalEventIdentifier.Value)).Append("</UniqueUniversalEventIdentifier>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<DepositoryReceiptSponsorIndicator>").Append(this.DepositoryReceiptSponsorIndicator.Value).Append("</DepositoryReceiptSponsorIndicator>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<PaymentDate>").Append(this.PaymentDate.Value).Append("</PaymentDate>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<RecordDate>").Append(this.RecordDate.Value).Append("</RecordDate>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<CountryOfIssue>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.CountryOfIssue.Value)).Append("</CountryOfIssue>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<ContextRefBase>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.ContextRefBase.Value)).Append("</ContextRefBase>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Source>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.Source.Value)).Append("</Source>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<processState>").Append(this.processState.Value).Append("</processState>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<WhenProcessed>").Append(this.WhenProcessed.Value).Append("</WhenProcessed>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Processedby>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.Processedby.Value)).Append("</Processedby>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<flgLock>").Append(this.flgLock.Value).Append("</flgLock>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<WhenLocked_date>").Append(this.WhenLocked_date.Value).Append("</WhenLocked_date>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<LockedBy_userid>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.LockedBy_userid.Value)).Append("</LockedBy_userid>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<createdby>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.createdby.Value)).Append("</createdby>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<createddate>").Append(this.createddate.Value).Append("</createddate>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<AnnouncementIdentifier>").Append(this.AnnouncementIdentifier.Value).Append("</AnnouncementIdentifier>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<FirstFilerFlag>").Append(this.FirstFilerFlag.Value).Append("</FirstFilerFlag>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<UnderlyingSecurityIssuerCountryofIncorporation>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.UnderlyingSecurityIssuerCountryofIncorporation.Value)).Append("</UnderlyingSecurityIssuerCountryofIncorporation>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<id_SavedFiles_CSV>").Append(this.id_SavedFiles_CSV.Value).Append("</id_SavedFiles_CSV>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<DividendIndex>").Append(this.DividendIndex.Value).Append("</DividendIndex>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<AnnouncementType>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.AnnouncementType.Value)).Append("</AnnouncementType>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<ID_GTS_SFTP_InputSITEs>").Append(this.ID_GTS_SFTP_InputSITEs.Value).Append("</ID_GTS_SFTP_InputSITEs>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<recNum>").Append(this.recNum.Value).Append("</recNum>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<flgEmailSent>").Append(this.flgEmailSent.Value).Append("</flgEmailSent>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<EmailSentDate>").Append(this.EmailSentDate.Value).Append("</EmailSentDate>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("</XBRL_SavedFile>").Append(HssUtility.General.HssStr.WinNextLine);
            return sb.ToString();
        }
        /*^^^^^^^^^^^^^^^^^^^^^^^^^^^^^Hss Entity Framework Auto Generated Code^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^*/

        public Hss_XML_obj XBRLobj
        {
            get
            {
                Hss_XML_reader xr = new Hss_XML_reader();
                Hss_XML_obj xbrl = xr.Read(this.savedfile);
                return xbrl;
            }
        }

        public void Init_from_info(XBRL_event_info xei)
        {
            if (string.IsNullOrEmpty(xei.depoName)) this.DepositaryName.Value = xei.Sender;
            else this.DepositaryName.Value = xei.depoName;

            this.cusip.Value = xei.CUSIP;
            this.DepositoryReceiptSponsorIndicator.Value = xei.Sponsored;
            this.UnderlyingSecurityIssuerCountryofIncorporation.Value = xei.ISO2CntryCode;
            this.RecordDate.Value = xei.RecordDate_ADR;
            this.UniqueUniversalEventIdentifier.Value = xei.XBRL_ReferenceNumber;
            this.AnnouncementDate.Value = xei.AnnouncementDate;
            this.AnnouncementType.Value = xei.AnnouncementType;
            this.EventCompleteness.Value = xei.EventCompleteness;
        }

        /// <summary>
        /// Get all info from XBRL into a dataSet to show on Grid
        /// </summary>
        public DataSet Get_XBRLinfo_DS()
        {
            DataSet ds = new DataSet();
            DataTable main_dt = this.Get_main_DT();
            ds.Tables.Add(main_dt);

            XBRL_event_info xei = new XBRL_event_info(this.XBRLobj);

            DataTable field_dt = this.Get_field_DT(xei);
            ds.Tables.Add(field_dt);
            DataTable fee_dt = this.Get_fee_DT(xei);
            ds.Tables.Add(fee_dt);

            ds.Relations.Add(main_dt.Columns["ID"], field_dt.Columns["ID"]);
            ds.Relations.Add(main_dt.Columns["ID"], fee_dt.Columns["ID"]);

            return ds;
        }

        private DataTable Get_main_DT()
        {
            DataTable main_dt = new DataTable("Main");
            main_dt.Columns.Add("ID", typeof(int));
            main_dt.Columns.Add("UniqueUniversalEventIdentifier").Caption = "XBRL Ref #";
            main_dt.Columns.Add("CUSIP");
            main_dt.Columns.Add("DepositaryName").Caption = "Depositary";
            main_dt.Columns.Add("AnnouncementDate", typeof(DateTime));

            DataRow row = main_dt.Rows.Add();
            row["ID"] = this.id_SavedfilesRcvd;
            row["UniqueUniversalEventIdentifier"] = this.UniqueUniversalEventIdentifier.Value;
            row["CUSIP"] = this.cusip.Value;
            row["DepositaryName"] = this.DepositaryName.Value;
            row["AnnouncementDate"] = this.AnnouncementDate.Value;

            return main_dt;
        }

        private DataTable Get_field_DT(XBRL_event_info xei)
        {
            DataTable field_dt = new DataTable("Fields");
            field_dt.Columns.Add("ID", typeof(int));
            field_dt.Columns.Add("XBRL Element");
            field_dt.Columns.Add("DRWIN Field Name");
            field_dt.Columns.Add("Value");

            if (xei == null) return field_dt;
            int id = this.id_SavedfilesRcvd;

            field_dt.Rows.Add(id, "UnderlyingSecurityIssuerCountryofIncorporation", "ISO2CntryCode", xei.ISO2CntryCode);
            field_dt.Rows.Add(id, "InstrumentIdentifier", "CUSIP", xei.CUSIP);
            field_dt.Rows.Add(id, "InstrumentIdentifier", "ISIN", xei.ISIN);
            field_dt.Rows.Add(id, "DepositoryReceiptSponsorIndicator", "Sponsored", xei.Sponsored);
            field_dt.Rows.Add(id, "PaymentDate", "PayDate_ADR", xei.PayDate_ADR);
            field_dt.Rows.Add(id, "OrdExDividendDate", "ExDate", xei.ExDate);
            field_dt.Rows.Add(id, "OrdPaymentDate", "PayDate_ORD", xei.PayDate_ORD);
            field_dt.Rows.Add(id, "RecordDate", "RecordDate_ADR", xei.RecordDate_ADR);
            field_dt.Rows.Add(id, "OrdRecordDate", "RecordDate_ORD", xei.RecordDate_ORD);
            field_dt.Rows.Add(id, "ADRBase", "ADR_Ratio_ADR", xei.ADR_Ratio_ADR);
            field_dt.Rows.Add(id, "OrdinaryShare", "ADR_Ratio_ORD", xei.ADR_Ratio_ORD);
            field_dt.Rows.Add(id, "ForeignExchangeConversionRateForADRPayment", "FXrate_foreign_to_US", xei.FXrate_foreign_to_US);
            field_dt.Rows.Add(id, "ForeignExchangeConversionRateForADRPayment", "FXrate_US_to_foreign", xei.FXrate_US_to_foreign);
            field_dt.Rows.Add(id, "EventCompleteness", "EventCompleteness", xei.EventCompleteness);
            field_dt.Rows.Add(id, "WithholdingTaxPercentage", "StatutoryRate", xei.StatutoryRate);
            field_dt.Rows.Add(id, "OrdinaryGrossDividendPayoutRate", "DivGrossAmount_ORD", xei.DivGrossAmount_ORD);
            field_dt.Rows.Add(id, "TradingSymbol", "TickerSymbol", xei.TickerSymbol);
            field_dt.Rows.Add(id, "SecurityDescription", "Issue", xei.Issue);
            field_dt.Rows.Add(id, "OrdinaryGrossDividendPayoutRate", "PaidCurrency_ORD", xei.PaidCurrency_ORD);
            field_dt.Rows.Add(id, "FirstFilerFlag", "IsFirstFiler", xei.IsFirstFiler);
            field_dt.Rows.Add(id, "DepositaryName", "depoName", xei.depoName);
            field_dt.Rows.Add(id, "EventType", "EventType", xei.EventType);
            field_dt.Rows.Add(id, "identifier", "Sender", xei.Sender);
            field_dt.Rows.Add(id, "UniqueUniversalEventIdentifier", "XBRL_ReferenceNumber", xei.XBRL_ReferenceNumber);
            field_dt.Rows.Add(id, "AnnouncementType", "AnnouncementType", xei.AnnouncementType);
            field_dt.Rows.Add(id, "AnnouncementIdentifier", "AnnouncementIdentifier", xei.AnnouncementIdentifier);
            field_dt.Rows.Add(id, "AnnouncementDate", "AnnouncementDate", xei.AnnouncementDate);
            field_dt.Rows.Add(id, "EventCompleteness", "EventCompleteness", xei.EventCompleteness);

            return field_dt;
        }

        private DataTable Get_fee_DT(XBRL_event_info xei)
        {
            DataTable fee_dt = new DataTable("Fee");
            fee_dt.Columns.Add("ID", typeof(int));
            fee_dt.Columns.Add("WithholdingTaxPercentage");
            fee_dt.Columns.Add("PayoutAmount");
            fee_dt.Columns.Add("TaxAmountWithheldFromPayout");
            fee_dt.Columns.Add("TaxReliefFee");
            fee_dt.Columns.Add("FeeRate");
            fee_dt.Columns.Add("DepositaryServiceFee");
            fee_dt.Columns.Add("PayoutAmountNetOfTax");

            if (xei == null) return fee_dt;

            foreach (FeeInfo fi in xei.fee_list)
            {
                DataRow row = fee_dt.Rows.Add();
                row["ID"] = this.id_SavedfilesRcvd;
                row["WithholdingTaxPercentage"] = fi.WithholdingTaxPercentage;
                row["PayoutAmount"] = fi.PayoutAmount;
                row["TaxAmountWithheldFromPayout"] = fi.TaxAmountWithheldFromPayout;
                row["TaxReliefFee"] = fi.TaxReliefFee;
                row["FeeRate"] = fi.FeeRate;
                row["DepositaryServiceFee"] = fi.DepositaryServiceFee;
                row["PayoutAmountNetOfTax"] = fi.PayoutAmountNetOfTax;
            }

            return fee_dt;
        }
    }
}
