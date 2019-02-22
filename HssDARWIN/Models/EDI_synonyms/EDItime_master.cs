using System;
using System.Collections.Generic;

using HssUtility.SQLserver;

namespace HssDARWIN.Models.EDI_synonyms
{
    public class EDItime_master
    {
        private static Dictionary<string, List<EDI_times>> ccd_dic = new Dictionary<string, List<EDI_times>>(StringComparer.OrdinalIgnoreCase);

        private static DateTime lastUpdateTime = DateTime.MinValue;

        public static void Init_from_DB()
        {
            if ((DateTime.Now - EDItime_master.lastUpdateTime).TotalHours < Utility.RefreshInterval) return;

            EDItime_master.Reset();
            DB_select selt = new DB_select(EDI_times.Get_cmdTP());

            DB_reader reader = new DB_reader(selt, Utility.Get_DRWIN_hDB());
            while (reader.Read())
            {
                EDI_times et = new EDI_times();
                et.Init_from_reader(reader);

                if (!EDItime_master.ccd_dic.ContainsKey(et.cntry_cd.Value))
                {
                    List<EDI_times> et_list = new List<EDI_times>();
                    EDItime_master.ccd_dic[et.cntry_cd.Value] = et_list;
                }

                EDItime_master.ccd_dic[et.cntry_cd.Value].Add(et);
            }
            reader.Close();

            EDItime_master.lastUpdateTime = DateTime.Now;
        }

        public static EDI_times GetRate_from_country(string countryName, DateTime curr_dt)
        {
            EDI_country cty = EDIcountryMaster.Get_EDI_country(countryName);
            if (cty == null) return null;
            else return EDItime_master.GetTimes_from_ccd(cty.cntry_cd, curr_dt);
        }

        /// <summary>
        /// Get a list of StatutoryRate sort by effective date decending
        /// </summary>
        private static List<EDI_times> GetList_from_ccd(string cntry_cd)
        {
            EDItime_master.Init_from_DB();

            List<EDI_times> list;
            if (cntry_cd == null) cntry_cd = "";

            if (EDItime_master.ccd_dic.ContainsKey(cntry_cd))
            {
                list = EDItime_master.ccd_dic[cntry_cd];
                list.Sort((a, b) => (DateTime.Compare(b.effect_dt.Value, a.effect_dt.Value)));
            }
            else list = new List<EDI_times>();

            return list;
        }

        private static EDI_times GetTimes_from_ccd(string cntry_cd, DateTime curr_dt)
        {
            List<EDI_times> list = EDItime_master.GetList_from_ccd(cntry_cd);
            foreach (EDI_times et in list)
            {
                if (et.sec_type.Value != 1) continue;//only ADR for now
                if (et.effect_dt.Value > curr_dt) continue;
                if (!et.bo_cor.IsValueEmpty) continue;//ignore BO country for now

                return et;
            }
            return null;
        }

        public static void Reset()
        {
            EDItime_master.lastUpdateTime = DateTime.MinValue;
            EDItime_master.ccd_dic.Clear();
        }
    }
}
