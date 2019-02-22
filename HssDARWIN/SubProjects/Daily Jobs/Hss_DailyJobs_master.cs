using System;
using System.Collections.Generic;

using HssUtility.SQLserver;
using HssUtility.General;

namespace HssDARWIN.SubProjects.Daily_Jobs
{
    public class Hss_DailyJobs_master
    {
        public static Hss_DailyJobs GetJob_class_id(string jobClass, int jobID)
        {
            if (string.IsNullOrEmpty(jobClass)) return null;

            DB_select selt = new DB_select(Hss_DailyJobs.Get_cmdTP());
            SQL_relation rela0 = new SQL_relation("Job_Class", RelationalOperator.Equals, jobClass);
            SQL_relation rela1 = new SQL_relation("Job_ID", RelationalOperator.Equals, jobID);
            selt.SetCondition(new SQL_condition(rela0, ConditionalOperator.And, rela1));

            Hss_DailyJobs hdj = null;

            DB_reader reader = new DB_reader(selt, Utility.Get_DRWIN_hDB());
            if (reader.Read())
            {
                hdj = new Hss_DailyJobs();
                hdj.Init_from_reader(reader);
            }
            reader.Close();

            return hdj;
        }

        public static List<Hss_DailyJobs> GetAllJobs()
        {
            List<Hss_DailyJobs> list = new List<Hss_DailyJobs>();

            DB_select selt = new DB_select(Hss_DailyJobs.Get_cmdTP());
            DB_reader reader = new DB_reader(selt, Utility.Get_DRWIN_hDB());
            while (reader.Read())
            {
                Hss_DailyJobs hdj = new Hss_DailyJobs();
                hdj.Init_from_reader(reader);
                list.Add(hdj);
            }
            reader.Close();

            return list;
        }
    }
}
