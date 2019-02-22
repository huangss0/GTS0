using System;
using System.Collections.Generic;

using HssUtility.SQLserver;

namespace HssDARWIN.Models.EDI_synonyms
{
    public class EDIcountryMaster
    {
        private static Dictionary<string, EDI_country> name_dic = new Dictionary<string, EDI_country>(StringComparer.OrdinalIgnoreCase);        
        private static Dictionary<string, EDI_country> iso2_dic = new Dictionary<string, EDI_country>(StringComparer.OrdinalIgnoreCase);
        private static Dictionary<string, EDI_country> iso3_dic = new Dictionary<string, EDI_country>(StringComparer.OrdinalIgnoreCase);

        private static DateTime lastUpdateTime = DateTime.MinValue;

        public static void Init_from_DB()
        {
            if ((DateTime.Now - EDIcountryMaster.lastUpdateTime).TotalHours < Utility.RefreshInterval) return;

            EDIcountryMaster.Reset();
            DB_select selt = new DB_select(EDI_country.Get_cmdTP());

            DB_reader reader = new DB_reader(selt, Utility.Get_DRWIN_hDB());
            while (reader.Read())
            {
                EDI_country cty = new EDI_country();
                cty.Init_from_reader(reader);
                
                EDIcountryMaster.name_dic[cty.name.Value] = cty;                
                EDIcountryMaster.iso2_dic[cty.iso2_cd.Value] = cty;
                EDIcountryMaster.iso3_dic[cty.iso3_cd.Value] = cty;
            }
            reader.Close();

            EDIcountryMaster.lastUpdateTime = DateTime.Now;
        }

        public static EDI_country Get_EDI_country(string name)
        {
            EDIcountryMaster.Init_from_DB();
            if (string.IsNullOrEmpty(name)) return null;
            
            if (EDIcountryMaster.name_dic.ContainsKey(name)) return EDIcountryMaster.name_dic[name];
            if (EDIcountryMaster.iso2_dic.ContainsKey(name)) return EDIcountryMaster.iso2_dic[name];
            if (EDIcountryMaster.iso3_dic.ContainsKey(name)) return EDIcountryMaster.iso3_dic[name];

            return null;
        }

        public static void Reset()
        {
            EDIcountryMaster.lastUpdateTime = DateTime.MinValue;
            EDIcountryMaster.name_dic.Clear();
            EDIcountryMaster.iso2_dic.Clear();
            EDIcountryMaster.iso3_dic.Clear();
        }
    }
}
