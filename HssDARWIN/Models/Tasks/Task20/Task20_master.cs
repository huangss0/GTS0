using System;
using System.Collections.Generic;
using System.Threading;

using HssUtility.Debug;
using HssUtility.SQLserver;
using HssUtility.General;
using HssDARWIN.Models.FX_payment;
using HssDARWIN.SubProjects.Daily_Jobs;

namespace HssDARWIN.Models.Tasks.Task20
{
    public class Task20_master : I_runable
    {
        public const int TaskID_20 = 20;
        private I_hssLog errLog = new HssConsoleDebug();

        private Dictionary<int, FX_Input> fi_dic = new Dictionary<int, FX_Input>();
        private DateTime today_date = DateTime.Today;
        private DateTime startDate = new DateTime(2017, 10, 1);//starting date for 

        public void Run()
        {
            Hss_DailyJobs hdj = Hss_DailyJobs_master.GetJob_class_id("Task Manager", 20);
            if (hdj == null) return;
            if (HssDateTime.CompareDateTime_day(DateTime.Now, hdj.LastRunAt.Value) <= 0) return;
            if (!hdj.UpdateRecordLock(true)) return;

            Console.WriteLine("Task 20 start running");
            this.PerformTasks();

            hdj.UpdateRecordLock(false, true);
        }

        internal void PerformTasks()
        {
            this.fi_dic = FX_Input_master.Get_checkLocked_FI_dic();

            this.Run_TaskA(); Console.WriteLine("Task 20A Done");
            this.Run_TaskB(); Console.WriteLine("Task 20B Done");
            this.Run_TaskC(); Console.WriteLine("Task 20C Done");
            this.Run_taskD(); Console.WriteLine("Task 20D Done");
        }

        private HashSet<int> Get_currFX_ID_set(string taskName)
        {
            HashSet<int> hs = new HashSet<int>();

            CmdTemplate tp = new CmdTemplate();
            tp.schema = "Task";
            tp.tableName = "Task_Detail";
            tp.AddColumn("SourceID");

            DB_select selt = new DB_select(tp);
            SQL_relation rel0 = new SQL_relation("TaskID", RelationalOperator.Equals, Task20_master.TaskID_20);
            SQL_relation rel1 = new SQL_relation("TaskName", RelationalOperator.Equals, taskName);
            SQL_condition cond0 = new SQL_condition(rel0), cond1 = new SQL_condition(rel1);
            SQL_condition cond = new SQL_condition(cond0, ConditionalOperator.And, cond1);
            selt.SetCondition(cond);

            DB_reader reader = new DB_reader(selt, Utility.Get_DRWIN_hDB());
            while (reader.Read())
            {
                int tempInt = -1;
                string tempStr = reader.GetString("SourceID");
                if (int.TryParse(tempStr, out tempInt)) hs.Add(tempInt);
            }
            reader.Close();

            return hs;
        }

        public void Run_TaskA()
        {
            HashSet<int> fxID_hs = this.Get_currFX_ID_set("A");//current IDs in task_detail table
            Bulk_DBcmd buk_ins = new Bulk_DBcmd();

            foreach (FX_Input fi in this.fi_dic.Values)
            {
                if (fi.Locked || fi.FX_ReceivedDate.Value < this.startDate) continue;
                if (fxID_hs.Contains(fi.FX_InputID)) continue; //skip existing tasks

                int overDue_days = (this.today_date - fi.FX_ReceivedDate.Value).Days;
                if (overDue_days <= Task_Detail_20A.Overdue_days) continue;

                Task_Detail_20A t20a = new Task_Detail_20A();
                t20a.SourceID.Value = fi.FX_InputID.ToString();
                t20a.Country.Value = fi.CountryName.Value;
                t20a.Notes.Value = "Over:" + overDue_days + " days";

                buk_ins.Add_DBcmd(t20a.Get_DBinsert());
            }

            buk_ins.SaveToDB(Utility.Get_DRWIN_hDB());
        }

        public void Run_TaskB()
        {
            HashSet<int> fxID_hs = this.Get_currFX_ID_set("B");
            Bulk_DBcmd buk_ins = new Bulk_DBcmd();

            foreach (FX_Input fi in this.fi_dic.Values)
            {
                if (fi.FX_ReceivedDate.Value < this.startDate) continue;//set a cut-off date
                if (fi.Depositary_ReceivedDate.Value > fi.FX_NotificationDate.Value) continue;

                if ((this.today_date - fi.FX_NotificationDate.Value).TotalDays <= 1) continue;
                if (fxID_hs.Contains(fi.FX_InputID)) continue;

                Task_Detail_20B t20b = new Task_Detail_20B();
                t20b.SourceID.Value = fi.FX_InputID.ToString();
                t20b.Country.Value = fi.CountryName.Value;
                t20b.Notes.Value = "Today after notification date";

                buk_ins.Add_DBcmd(t20b.Get_DBinsert());
            }

            buk_ins.SaveToDB(Utility.Get_DRWIN_hDB());
        }

        public void Run_TaskC()
        {
            HashSet<int> fxID_hs = this.Get_currFX_ID_set("C");
            Bulk_DBcmd buk_ins = new Bulk_DBcmd();

            foreach (FX_Input fi in this.fi_dic.Values)
            {
                if (fi.FX_Rate.Value >= 0 || fi.Depositary_ReceivedDate.Value == Utility.MinDate) continue;
                if (fxID_hs.Contains(fi.FX_InputID)) continue;

                int overDue_days = (this.today_date - fi.Depositary_ReceivedDate.Value).Days;
                if (overDue_days <= Task_Detail_20C.Overdue_days) continue;

                Task_Detail_20C t20c = new Task_Detail_20C();
                t20c.SourceID.Value = fi.FX_InputID.ToString();
                t20c.Notes.Value = "OverDue: " + overDue_days + " days";
                t20c.Country.Value = fi.CountryName.Value;

                buk_ins.Add_DBcmd(t20c.Get_DBinsert());
            }

            buk_ins.SaveToDB(Utility.Get_DRWIN_hDB());
        }

        public void Run_taskD()
        {
            HashSet<int> fxID_hs = this.Get_currFX_ID_set("D");
            Bulk_DBcmd buk_ins = new Bulk_DBcmd();

            foreach (FX_Input fi in this.fi_dic.Values)
            {
                if (fi.FX_ReceivedDate.Value < this.startDate) continue;
                if (fxID_hs.Contains(fi.FX_InputID)) continue;

                Task_Detail_20D t20d = null;

                if (fi.PayToBrokerDate.Value == Utility.MinDate && fi.ActualCheckRequestDate.Value > Utility.MinDate)
                {
                    int overDue_days = (this.today_date - fi.ActualCheckRequestDate.Value).Days;
                    if (overDue_days > Task_Detail_20D.Overdue_days)
                    {
                        t20d = new Task_Detail_20D();
                        t20d.SourceID.Value = fi.FX_InputID.ToString();
                        t20d.Notes.Value = "Not to Broker, over: " + overDue_days + " days";
                    }
                }
                else if (fi.PayToBrokerDate.Value < fi.ActualCheckRequestDate.Value)
                {
                    t20d = new Task_Detail_20D();
                    t20d.SourceID.Value = fi.FX_InputID.ToString();
                    t20d.Notes.Value = "broker date can't before actual";
                }

                if (t20d != null)
                {
                    t20d.Country.Value = fi.CountryName.Value;
                    buk_ins.Add_DBcmd(t20d.Get_DBinsert());
                }
            }

            buk_ins.SaveToDB(Utility.Get_DRWIN_hDB());
        }
    }
}
