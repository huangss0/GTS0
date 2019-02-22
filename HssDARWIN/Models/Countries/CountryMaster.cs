using System;
using System.Collections.Generic;

using HssUtility.SQLserver;

namespace HssDARWIN.Models.Countries
{
    public class CountryMaster
    {
        private static Dictionary<string, Country> name_dic = new Dictionary<string, Country>(StringComparer.OrdinalIgnoreCase);
        private static Dictionary<string, Country> short_dic = new Dictionary<string, Country>(StringComparer.OrdinalIgnoreCase);
        private static Dictionary<string, string> otherShort = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);

        private static DateTime lastUpdateTime = DateTime.MinValue;

        public static void Init_from_DB()
        {
            if (CountryMaster.otherShort.Count < 1)
            {
                CountryMaster.otherShort["Russia"] = "RU";
                //more may needed in the future
            }

            if ((DateTime.Now - CountryMaster.lastUpdateTime).TotalHours < Utility.RefreshInterval) return;

            CountryMaster.Reset();
            DB_select selt = new DB_select(Country.Get_cmdTP());
            DB_reader reader = new DB_reader(selt, Utility.Get_DRWIN_hDB());
            while (reader.Read())
            {
                Country cty = new Country();
                cty.Init_from_reader(reader);

                CountryMaster.name_dic[cty.name] = cty;
                CountryMaster.short_dic[cty.cntry_cd.Value] = cty;
            }
            reader.Close();

            CountryMaster.lastUpdateTime = DateTime.Now;
        }

        public static Country GetCountry_name(string name)
        {
            CountryMaster.Init_from_DB();
            if (name == null) return null;

            if (CountryMaster.name_dic.ContainsKey(name)) return CountryMaster.name_dic[name];
            else if (CountryMaster.short_dic.ContainsKey(name)) return CountryMaster.short_dic[name];
            else if (CountryMaster.otherShort.ContainsKey(name))
            {
                string shrName = CountryMaster.otherShort[name];
                if (CountryMaster.short_dic.ContainsKey(shrName)) return CountryMaster.short_dic[shrName];
            }

            return null;
        }

        public static Country GetCountry_short(string shortName)
        {
            CountryMaster.Init_from_DB();
            if (shortName == null) return null;

            if (CountryMaster.short_dic.ContainsKey(shortName)) return CountryMaster.short_dic[shortName];
            else return null;
        }

        public static List<Country> GetAll_countryList()
        {
            CountryMaster.Init_from_DB();
            List<Country> list = new List<Country>(CountryMaster.name_dic.Values);
            list.Sort((a, b) => (string.Compare(a.name, b.name)));
            return list;
        }

        public static void Reset()
        {
            CountryMaster.lastUpdateTime = DateTime.MinValue;
            CountryMaster.name_dic.Clear();
            CountryMaster.short_dic.Clear();
            CountryMaster.otherShort.Clear();
        }
    }
}
