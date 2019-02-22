using System;
using System.Text;
using System.Collections.Generic;

using HssUtility.SQLserver;
using HssUtility.General;

namespace HssDARWIN.Models.Tasks.Task21
{
    public class Task21_secMaster
    {
        private static Dictionary<int, Task21_security> ID_dic = new Dictionary<int, Task21_security>();
        private static Dictionary<int, List<Task21_security>> secID_dic = new Dictionary<int, List<Task21_security>>();

        private static DateTime lastUpdateTime = DateTime.MinValue;

        public static void Init_from_DB()
        {
            if ((DateTime.Now - Task21_secMaster.lastUpdateTime).TotalHours < Utility.RefreshInterval) return;

            Task21_secMaster.Reset();
            DB_select selt = new DB_select(Task21_security.Get_cmdTP());
            DB_reader reader = new DB_reader(selt, Utility.Get_DRWIN_hDB());
            while (reader.Read())
            {
                Task21_security cty = new Task21_security();
                cty.Init_from_reader(reader);

                Task21_secMaster.ID_dic[cty.ID] = cty;

                if (!Task21_secMaster.secID_dic.ContainsKey(cty.SecurityID.Value))
                {
                    List<Task21_security> list = new List<Task21_security>();
                    Task21_secMaster.secID_dic[cty.SecurityID.Value] = list;
                }
                Task21_secMaster.secID_dic[cty.SecurityID.Value].Add(cty);
            }
            reader.Close();

            Task21_secMaster.lastUpdateTime = DateTime.Now;
        }

        public static void Reset()
        {
            Task21_secMaster.lastUpdateTime = DateTime.MinValue;
            Task21_secMaster.ID_dic.Clear();
            Task21_secMaster.secID_dic.Clear();
        }

        public static List<Task21_security> Get_secList(int SecurityID)
        {
            Task21_secMaster.Init_from_DB();
            if (Task21_secMaster.secID_dic.ContainsKey(SecurityID)) return Task21_secMaster.secID_dic[SecurityID];
            else return new List<Task21_security>();
        }

        public static string GetDisplayStr(int SecurityID, bool normal_only)
        {
            StringBuilder sb = new StringBuilder();
            string split_str = "; ";

            foreach (Task21_security ts in Task21_secMaster.Get_secList(SecurityID))
            {
                if (normal_only && ts.Get_status() != HssStatus.Normal) continue;
                sb.Append(ts.TaskName.Value).Append(split_str);
            }

            if (sb.Length > 0) sb.Remove(sb.Length - split_str.Length, split_str.Length); //trim end
            return sb.ToString();
        }
    }
}
