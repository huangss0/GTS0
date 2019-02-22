using System;
using System.Collections.Generic;

using HssUtility.SQLserver;

namespace HssDARWIN.Models.DTC_Participant
{
    public class DTC_Participants_master
    {
        private static Dictionary<int, DTC_Participants> ID_dic = new Dictionary<int, DTC_Participants>();
        private static Dictionary<string, DTC_Participants> DTCnum_dic = new Dictionary<string, DTC_Participants>(StringComparer.OrdinalIgnoreCase);

        private static DateTime lastUpdateTime = DateTime.MinValue;

        public static void Init_from_DB()
        {
            if ((DateTime.Now - DTC_Participants_master.lastUpdateTime).TotalHours < Utility.RefreshInterval) return;

            DTC_Participants_master.Reset();
            DB_select selt = new DB_select(DTC_Participants.Get_cmdTP());
            DB_reader reader = new DB_reader(selt, Utility.Get_DRWIN_hDB());
            while (reader.Read())
            {
                DTC_Participants dp = new DTC_Participants();
                dp.Init_from_reader(reader);

                DTC_Participants_master.ID_dic[dp.DTC] = dp;
                DTC_Participants_master.DTCnum_dic[dp.DTC_Number.Value] = dp;
            }
            reader.Close();

            DTC_Participants_master.lastUpdateTime = DateTime.Now;
        }

        public static DTC_Participants Get_DTC_Participants_DTCnum(string DTCnum)
        {
            DTC_Participants_master.Init_from_DB();
            if (DTCnum == null) return null;

            if (DTC_Participants_master.DTCnum_dic.ContainsKey(DTCnum)) return DTC_Participants_master.DTCnum_dic[DTCnum];
            else return null;
        }

        public static int Insert_DTC_Participants(List<DTC_Participants> dp_list)
        {
            if (dp_list == null) return -1;

            Bulk_DBcmd bk_cmd = new Bulk_DBcmd();
            foreach (DTC_Participants dp in dp_list)
            {
                if (dp == null) continue;
                bk_cmd.Add_DBcmd(dp.Get_DBinsert());
            }

            int count = bk_cmd.SaveToDB(Utility.Get_DRWIN_hDB());
            if (count > 0) DTC_Participants_master.Reset();

            return count;
        }

        public static void Reset()
        {
            DTC_Participants_master.ID_dic.Clear();
            DTC_Participants_master.DTCnum_dic.Clear();
            DTC_Participants_master.lastUpdateTime = DateTime.MinValue;
        }
    }
}
