using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading;

using HssUtility.SQLserver;
using HssUtility.General;
using HssDARWIN.Helpers;

namespace HssDARWIN.Models.Tasks
{
    public class TaskForm_viewControl
    {
        public readonly DataTable sourceDT = new DataTable();

        public TaskForm_viewControl()
        {
            this.sourceDT.Columns.Add(UltraGrid_helper.SelectColumnName, typeof(bool)).Caption = "select";
            this.sourceDT.Columns.Add("TaskDetailID", typeof(int));
            this.sourceDT.Columns.Add("TaskID", typeof(int));
            this.sourceDT.Columns.Add("TaskName");
            this.sourceDT.Columns.Add("SourceTable");
            this.sourceDT.Columns.Add("SourceID");
            this.sourceDT.Columns.Add("Country");
            this.sourceDT.Columns.Add("CreatedBy");
            this.sourceDT.Columns.Add("CreatedDateTime", typeof(DateTime));
            this.sourceDT.Columns.Add("Completed");
            this.sourceDT.Columns.Add("Notes");
        }

        private List<Task_Detail> taskDetail_list = new List<Task_Detail>();
        private int currList_id = 0;
        private DB_reader curr_reader = null;
        private volatile bool dataFinishedLoading_flag = false, threadStop_flag = true;
        private Thread listThread = null;

        public bool ViewData_match_flag
        {
            get
            {
                if (this.dataFinishedLoading_flag) return this.taskDetail_list.Count == this.sourceDT.Rows.Count;
                else return false;
            }
        }
        public bool DataLoadingFinished_flag { get { return this.dataFinishedLoading_flag; } }

        /// <summary>
        /// Invoke by UserControl to retrieve data
        /// </summary>
        public void Get_viewDT_async(int completed_option, SQL_condition extraCond)
        {
            if (this.listThread != null)
            {
                this.threadStop_flag = true;
                this.listThread.Join();
            }

            this.sourceDT.Clear();//reset values
            this.taskDetail_list.Clear();
            this.currList_id = 0;
            this.threadStop_flag = false;
            this.dataFinishedLoading_flag = false;

            this.curr_reader = TaskDetailMaster.Get_DB_reader(completed_option, extraCond);//create reader for multi-threading
            this.listThread = new Thread(this.Get_TDlist_threadRun);
            this.listThread.Start();

            int loopCount = 0;
            while (true)
            {
                ++loopCount;
                Thread.Sleep(1);
                if (this.dataFinishedLoading_flag) break;
                if (this.taskDetail_list.Count > 50) break;
            }

            if (Utility.Is_DWRIN_admin()) Console.WriteLine("---> TaskForm_viewControl info 0: loopCount = " + loopCount);
            this.Add_TDrows_to_DT(UltraGrid_helper.RowsLoaded_per_scroll * 2);
        }

        private void Get_TDlist_threadRun()
        {
            if (this.curr_reader == null) return;

            while (this.curr_reader.Read())
            {
                if (this.threadStop_flag) break;

                Task_Detail td = new Task_Detail();
                td.Init_from_reader(this.curr_reader);
                this.taskDetail_list.Add(td);
            }

            Thread th = new Thread(this.curr_reader.Close);
            th.Name = "DB Reader thread " + DateTime.Now.ToString();
            th.Start();

            this.dataFinishedLoading_flag = true;
        }

        /// <summary>
        /// Add some rows from list to DT
        /// </summary>
        /// <param name="limit">max number of rows to be added</param>
        /// <returns>how many rows added</returns>
        public int Add_TDrows_to_DT(int limit = UltraGrid_helper.RowsLoaded_per_scroll)
        {
            int count = 0;
            if (limit < 1) limit = UltraGrid_helper.RowsLoaded_per_scroll;

            while (this.currList_id < this.taskDetail_list.Count)
            {
                Task_Detail td = this.taskDetail_list[this.currList_id];
                DataRow row = sourceDT.Rows.Add();
                row[UltraGrid_helper.SelectColumnName] = false;
                row["TaskDetailID"] = td.TaskDetailID;
                row["TaskID"] = td.TaskID.Value;
                row["TaskName"] = td.TaskName.Value;
                row["SourceTable"] = td.SourceTable.Value;
                row["SourceID"] = td.SourceID.Value;
                row["Country"] = td.Country.Value;
                row["CreatedBy"] = td.CreatedBy.Value;
                if (!td.CreatedDateTime.IsNull_flag) row["CreatedDateTime"] = td.CreatedDateTime.Value;
                row["Completed"] = td.Completed.Value;
                row["Notes"] = td.Notes.Value;

                ++this.currList_id;
                if (++count >= limit) break;
            }

            return count;
        }

        /*-----------------------------------------------------------------------------------------------------*/

        private Dictionary<string, HashSet<string>> columnUniqueValues_dic = new Dictionary<string, HashSet<string>>();

    }
}
