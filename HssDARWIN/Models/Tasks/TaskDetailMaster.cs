using System;
using System.Collections.Generic;

using HssUtility.SQLserver;
using HssUtility.General;

namespace HssDARWIN.Models.Tasks
{
    public class TaskDetailMaster
    {
        public static List<Task_Detail> GetTaskDetail_list(int taskID, string sourceID, string taskName)
        {
            List<Task_Detail> list = new List<Task_Detail>();

            DB_select db_sel = new DB_select(Task_Detail.Get_cmdTP());

            SQL_relation rela0 = new SQL_relation("TaskID", RelationalOperator.Equals, taskID);
            SQL_relation rela1 = new SQL_relation("sourceID", RelationalOperator.Equals, sourceID);
            SQL_condition cond = new SQL_condition(rela0, ConditionalOperator.And, rela1);

            if (taskName != null)
            {
                SQL_relation rela2 = new SQL_relation("TaskName", RelationalOperator.Equals, taskName);
                cond = new SQL_condition(cond, ConditionalOperator.And, rela2);
            }
            db_sel.SetCondition(cond);

            DB_reader reader = new DB_reader(db_sel, Utility.Get_DRWIN_hDB());
            while (reader.Read())
            {
                Task_Detail dp = new Task_Detail();
                dp.Init_from_reader(reader);
                list.Add(dp);
            }
            reader.Close();

            return list;
        }

        public static int SetTaskCompleteness(int taskID, int sourceID, string taskName, bool completed)
        {
            return TaskDetailMaster.SetTaskCompleteness(taskID, sourceID.ToString(), taskName, completed);
        }
        public static int SetTaskCompleteness(int taskID, string sourceID, string taskName, bool completed)
        {
            List<Task_Detail> list = TaskDetailMaster.GetTaskDetail_list(taskID, sourceID, taskName);
            Bulk_DBcmd bk_cmd = new Bulk_DBcmd();
            foreach (Task_Detail td in list)
            {
                td.Completed.Value = true;
                bk_cmd.Add_DBcmd(td.Get_DBupdate());
            }

            int count = bk_cmd.SaveToDB(Utility.Get_DRWIN_hDB());
            return count;
        }

        /// <summary>
        /// Get DB_reader for retrieving Task_Detail info
        /// </summary>
        /// <param name="completed_option">0 for Uncompleted, 1 for Completed, other values for all</param>
        /// <param name="extraCond">Extra Condition</param>
        public static DB_reader Get_DB_reader(int completed_option, SQL_condition extraCond)
        {
            DB_select selt = new DB_select(Task_Detail.Get_cmdTP());
            SQL_relation rela = null;

            if (completed_option == 0) rela = new SQL_relation("Completed", RelationalOperator.Equals, false);            
            else if (completed_option ==1) rela = new SQL_relation("Completed", RelationalOperator.Equals, true);            

            SQL_condition cond = new SQL_condition(rela, ConditionalOperator.And, extraCond);
            selt.SetCondition(cond);

            DB_reader reader = new DB_reader(selt, Utility.Get_DRWIN_hDB());
            return reader;
        }
    }
}
