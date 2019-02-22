using System;
using System.Collections.Generic;
using HssUtility.SQLserver;

namespace HssDARWIN.Models.ESP2.Depositaries
{
    public class DepositaryInfoMaster
    {
        private static List<DepositaryInfo> depo_list = new List<DepositaryInfo>();

        private static DateTime lastUpdateTime = DateTime.MinValue;

        public static void Init_from_DB()
        {
            if ((DateTime.Now - DepositaryInfoMaster.lastUpdateTime).TotalHours < Utility.RefreshInterval) return;

            DepositaryInfoMaster.Reset();
            DB_select selt = new DB_select(DepositaryInfo.Get_cmdTP());

            DB_reader reader = new DB_reader(selt, Utility.Get_ESP2_hDB());
            while (reader.Read())
            {
                DepositaryInfo depo = new DepositaryInfo();
                depo.Init_from_reader(reader);

                DepositaryInfoMaster.depo_list.Add(depo);
            }
            reader.Close();

            DepositaryInfoMaster.lastUpdateTime = DateTime.Now;
        }

        public static DepositaryInfo GetDepo_by_name(string name)
        {
            DepositaryInfoMaster.Init_from_DB();
            if (string.IsNullOrEmpty(name)) return null;

            foreach (DepositaryInfo depo in DepositaryInfoMaster.depo_list)
            {
                if (depo.depositary_name.Value.StartsWith(name, StringComparison.OrdinalIgnoreCase))
                    return depo;
            }

            return null;
        }

        public static void Reset()
        {
            DepositaryInfoMaster.lastUpdateTime = DateTime.MinValue;
            DepositaryInfoMaster.depo_list.Clear();
        }
    }
}
