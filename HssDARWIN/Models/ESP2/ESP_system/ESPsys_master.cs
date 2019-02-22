using System;
using System.Collections.Generic;

using HssUtility.SQLserver;

namespace HssDARWIN.Models.ESP2.ESP_system
{
    public class ESPsys_master
    {
        private static Dictionary<string, ESPsys> coi_dic = new Dictionary<string, ESPsys>(StringComparer.OrdinalIgnoreCase);

        private static DateTime lastUpdateTime = DateTime.MinValue;

        public static void Init_from_DB()
        {
            if ((DateTime.Now - ESPsys_master.lastUpdateTime).TotalHours < Utility.RefreshInterval) return;

            ESPsys_master.Reset();
            DB_select selt = new DB_select(ESPsys.Get_cmdTP());

            DB_reader reader = new DB_reader(selt, Utility.Get_ESP2_hDB());
            while (reader.Read())
            {
                ESPsys esys = new ESPsys();
                esys.Init_from_reader(reader);

                ESPsys_master.coi_dic[esys.coi_code.Value] = esys;
            }
            reader.Close();

            ESPsys_master.lastUpdateTime = DateTime.Now;
        }

        public static ESPsys Get_ESPsys_coi(string coi)
        {
            ESPsys_master.Init_from_DB();
            if (coi == null) return null;

            if (ESPsys_master.coi_dic.ContainsKey(coi)) return ESPsys_master.coi_dic[coi];
            else return null;
        }

        public static void Reset()
        {
            ESPsys_master.lastUpdateTime = DateTime.MinValue;
            ESPsys_master.coi_dic.Clear();
        }
    }
}
