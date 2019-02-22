using System;
using System.Collections.Generic;
using System.Data;
using System.Threading;

using HssUtility.General;
using HssUtility.SQLserver;
using HssDARWIN.Helpers;
using HssDARWIN.Models.Securities;

namespace HssDARWIN.Models.XBRL.Event
{
    public class XBRL_SavedFile_master
    {
        public readonly DataTable sourceDT = new DataTable();

        public XBRL_SavedFile_master()
        {
            this.sourceDT.Columns.Add("id_SavedfilesRcvd", typeof(int)).Caption = "ID";
            this.sourceDT.Columns.Add(UltraGrid_helper.ActionColumnName).Caption = "Action";
            this.sourceDT.Columns.Add("UniqueUniversalEventIdentifier").Caption = "XBRL Ref #";
            this.sourceDT.Columns.Add("$Country$").Caption = "Country";
            this.sourceDT.Columns.Add("CUSIP").Caption = "CUSIP";
            this.sourceDT.Columns.Add("DepositaryName").Caption = "Depositary";
            //this.sourceDT.Columns.Add("UnderlyingSecurityIssuerCountryofIncorporation").Caption = "Security Country";
            //this.sourceDT.Columns.Add("CountryOfIssue").Caption = "Country of Issue";
            this.sourceDT.Columns.Add("AnnouncementType").Caption = "AnnounceType";
            this.sourceDT.Columns.Add("AnnouncementDate", typeof(DateTime)).Caption = "AnnounceDate";
            this.sourceDT.Columns.Add("EventCompleteness");
            this.sourceDT.Columns.Add("originalFileName").Caption = "oriFileName";
            this.sourceDT.Columns.Add("DividendIndex", typeof(int)).Caption = "DividendIndex";

            this.sourceDT.Columns.Add("CreatedBy").Caption = "Created By";
            this.sourceDT.Columns.Add("CreatedDate", typeof(DateTime)).Caption = "Created Date";
            this.sourceDT.Columns.Add("processState", typeof(int)).Caption = "processState";
            this.sourceDT.Columns.Add("Processedby").Caption = "Processedby";
            this.sourceDT.Columns.Add("WhenProcessed", typeof(DateTime)).Caption = "WhenProcessed";
        }
        
        /*------------------------------------------------------------------------------------------------------------------------*/

        private List<XBRL_SavedFile> XBRL_list = new List<XBRL_SavedFile>();
        private int currList_id = 0;
        private DB_reader curr_reader = null;
        private bool dataFinishedLoading_flag = false, threadStop_flag = true;
        private Thread listThread = null;

        public bool ViewData_match_flag
        {
            get
            {
                if (this.dataFinishedLoading_flag) return this.XBRL_list.Count == this.sourceDT.Rows.Count;
                else return false;
            }
        }
        public bool DataLoadingFinished_flag { get { return this.dataFinishedLoading_flag; } }

        /// <summary>
        /// Invoke by UserControl to retrieve data
        /// </summary>
        public void Get_viewDT_async(HssStatus status, SQL_condition extraCond)
        {
            if (this.listThread != null)
            {
                this.threadStop_flag = true;
                this.listThread.Join();
            }

            this.sourceDT.Clear();//reset values
            this.XBRL_list.Clear();
            this.currList_id = 0;
            this.threadStop_flag = false;
            this.dataFinishedLoading_flag = false;

            this.curr_reader = XBRL_SavedFile_master.Get_DB_reader(status, extraCond);//create reader for multi-threading
            this.listThread = new Thread(this.Get_XBRLlist_threadRun);
            this.listThread.Start();

            int loopCount = 0;
            while (true)
            {
                ++loopCount;
                Thread.Sleep(1);
                if (this.dataFinishedLoading_flag) break;
                if (this.XBRL_list.Count > 50) break;
            }

            //Console.WriteLine("---> XBRL_SavedFile_master info 0: loopCount = " + loopCount);
            this.Add_XBRLrows_to_DT(UltraGrid_helper.RowsLoaded_per_scroll * 2);
        }

        private void Get_XBRLlist_threadRun()
        {
            if (this.curr_reader == null) return;

            while (this.curr_reader.Read())
            {
                if (this.threadStop_flag) break;

                XBRL_SavedFile sf = new XBRL_SavedFile();
                sf.Init_from_reader(this.curr_reader);
                this.XBRL_list.Add(sf);
            }

            Thread th = new Thread(this.curr_reader.Close);
            th.Name = "Reader close thread";
            th.Start();

            this.dataFinishedLoading_flag = true;
        }

        /// <summary>
        /// Add some rows from list to DT
        /// </summary>
        /// <param name="limit">max number of rows to be added</param>
        /// <returns>how many rows added</returns>
        public int Add_XBRLrows_to_DT(int limit = UltraGrid_helper.RowsLoaded_per_scroll)
        {
            int count = 0;
            if (limit < 1) limit = UltraGrid_helper.RowsLoaded_per_scroll;

            while (this.currList_id < this.XBRL_list.Count)
            {
                XBRL_SavedFile sf = this.XBRL_list[this.currList_id];
                DataRow row = sourceDT.Rows.Add();
                row["id_SavedfilesRcvd"] = sf.id_SavedfilesRcvd;
                row["UniqueUniversalEventIdentifier"] = sf.UniqueUniversalEventIdentifier.Value;
                row["CUSIP"] = sf.cusip.Value;
                row["DepositaryName"] = sf.DepositaryName.Value;
                //row["UnderlyingSecurityIssuerCountryofIncorporation"] = sf.UnderlyingSecurityIssuerCountryofIncorporation.Value;
                //row["CountryOfIssue"] = sf.CountryOfIssue.Value;
                row["AnnouncementType"] = sf.AnnouncementType.Value;
                if (!sf.AnnouncementDate.IsNull_flag) row["AnnouncementDate"] = sf.AnnouncementDate.Value;
                row["EventCompleteness"] = sf.EventCompleteness.Value;
                row["originalFileName"] = sf.originalFileName.Value;
                if (!sf.DividendIndex.IsNull_flag) row["DividendIndex"] = sf.DividendIndex.Value;

                row["Createdby"] = sf.createdby.Value;
                if (!sf.createddate.IsNull_flag) row["CreatedDate"] = sf.createddate.Value;
                row["processState"] = sf.processState.Value;
                row["Processedby"] = sf.Processedby.Value;
                if (!sf.WhenProcessed.IsNull_flag) row["WhenProcessed"] = sf.WhenProcessed.Value;

                List<Security> sec_list = SecurityMaster.Get_secList_cusip(sf.cusip.Value);
                if (sec_list.Count > 0) row["$Country$"] = sec_list[0].Country.Value;

                ++this.currList_id;
                if (++count > limit) break;
            }

            return count;
        }

        /***********************************************Static Methods******************************************************************/

        public static List<XBRL_SavedFile> Get_XBRL_fileList(HssStatus status)
        {
            List<XBRL_SavedFile> list = new List<XBRL_SavedFile>();

            DB_reader reader = XBRL_SavedFile_master.Get_DB_reader(status, null);
            while (reader.Read())
            {
                XBRL_SavedFile sf = new XBRL_SavedFile();
                sf.Init_from_reader(reader);
                list.Add(sf);
            }
            reader.Close();

            return list;
        }

        private static DB_reader Get_DB_reader(HssStatus status, SQL_condition extraCond)
        {
            DB_select selt = new DB_select(XBRL_SavedFile.Get_cmdTP());
            selt.IgnoreColumn("savedfile");
            SQL_relation rela = null;

            if (status == HssStatus.Pending || status == HssStatus.Approved)
            {
                rela = new SQL_relation("processState", RelationalOperator.Equals, (int)status);
            }
            else
            {
                HashSet<int> hs = new HashSet<int>();
                hs.Add(0); hs.Add(1);
                rela = new SQL_relation("processState", false, hs);
            }

            SQL_condition cond = new SQL_condition(rela, ConditionalOperator.And, extraCond);
            selt.SetCondition(cond);

            DB_reader reader = new DB_reader(selt, Utility.Get_XBRL_hDB());
            return reader;
        }
    }
}
