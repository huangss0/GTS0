using System;
using System.Collections.Generic;

using HssUtility.SQLserver;

namespace HssDARWIN.Models.EDI_synonyms
{
    public class RateMaster_edi
    {
        private static Dictionary<string, List<StatutoryRate_edi>> coi_dic = new Dictionary<string, List<StatutoryRate_edi>>(StringComparer.OrdinalIgnoreCase);
        private static DateTime lastUpdateTime = DateTime.MinValue;

        public static void Init_from_DB()
        {
            if ((DateTime.Now - RateMaster_edi.lastUpdateTime).TotalHours < Utility.RefreshInterval) return;

            RateMaster_edi.Reset();
            DB_select selt = new DB_select(StatutoryRate_edi.Get_cmdTP());

            DB_reader reader = new DB_reader(selt, Utility.Get_DRWIN_hDB());
            while (reader.Read())
            {
                StatutoryRate_edi rt = new StatutoryRate_edi();
                rt.Init_from_reader(reader);

                string key = rt.coi.Value;
                if (key == null) key = "";

                if (!RateMaster_edi.coi_dic.ContainsKey(key))
                {
                    List<StatutoryRate_edi> list = new List<StatutoryRate_edi>();
                    RateMaster_edi.coi_dic[key] = list;
                }
                RateMaster_edi.coi_dic[key].Add(rt);
            }
            reader.Close();

            RateMaster_edi.lastUpdateTime = DateTime.Now;
        }

        public static void Reset()
        {
            RateMaster_edi.lastUpdateTime = DateTime.MinValue;
            RateMaster_edi.coi_dic.Clear();
        }

        public static StatutoryRate_edi GetRate_from_country(string countryName, DateTime curr_dt)
        {
            EDI_country cty = EDIcountryMaster.Get_EDI_country(countryName);
            if (cty == null) return null;
            else return RateMaster_edi.GetRate_from_coi(cty.cntry_cd, curr_dt);
        }

        /// <summary>
        /// Get a list of StatutoryRate sort by effective date decending
        /// </summary>
        private static List<StatutoryRate_edi> GetList_from_coi(string coi)
        {
            RateMaster_edi.Init_from_DB();

            List<StatutoryRate_edi> list;
            if (coi == null) coi = "";

            if (RateMaster_edi.coi_dic.ContainsKey(coi))
            {
                list = RateMaster_edi.coi_dic[coi];
                list.Sort((a, b) => (DateTime.Compare(b.effect_dt.Value, a.effect_dt.Value)));
            }
            else list = new List<StatutoryRate_edi>();

            return list;
        }        

        private static StatutoryRate_edi GetRate_from_coi(string coi, DateTime curr_dt)
        {
            List<StatutoryRate_edi> list = RateMaster_edi.GetList_from_coi(coi);            
            foreach (StatutoryRate_edi rt in list)
            {
                if (!string.IsNullOrEmpty(rt.cor.Value)) continue;
                if (!string.IsNullOrEmpty(rt.bo_typ.Value)) continue;
                if (rt.sec_type.Value != 1) continue;//only ADR for now
                if (rt.effect_dt.Value > curr_dt) continue;

                return rt;
            }
            return null;
        }
    }
}
