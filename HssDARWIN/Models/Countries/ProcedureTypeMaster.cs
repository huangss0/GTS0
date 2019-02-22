using System;
using System.Collections.Generic;

using HssUtility.SQLserver;

namespace HssDARWIN.Models.Countries
{
    public class ProcedureTypeMaster
    {
        private static Dictionary<string, List<Country_ProcedureTypes>> CPT_dic = new Dictionary<string, List<Country_ProcedureTypes>>(StringComparer.OrdinalIgnoreCase);
        private static DateTime lastUpdateTime = DateTime.MinValue;

        public static void Init_from_DB()
        {
            if ((DateTime.Now - ProcedureTypeMaster.lastUpdateTime).TotalHours < Utility.RefreshInterval) return;

            ProcedureTypeMaster.Reset();
            DB_select selt = new DB_select(Country_ProcedureTypes.Get_cmdTP());
            DB_reader reader = new DB_reader(selt, Utility.Get_DRWIN_hDB());
            while (reader.Read())
            {
                Country_ProcedureTypes cpt = new Country_ProcedureTypes();
                cpt.Init_from_reader(reader);

                if (!ProcedureTypeMaster.CPT_dic.ContainsKey(cpt.Country))
                {
                    List<Country_ProcedureTypes> list = new List<Country_ProcedureTypes>();
                    ProcedureTypeMaster.CPT_dic[cpt.Country] = list;
                }
                ProcedureTypeMaster.CPT_dic[cpt.Country].Add(cpt);
            }
            reader.Close();

            ProcedureTypeMaster.lastUpdateTime = DateTime.Now;
        }

        public static Country_ProcedureTypes GetCPT_country(string countryName, bool IsSponsored = true)
        {
            ProcedureTypeMaster.Init_from_DB();
            if (countryName == null) return null;

            if (ProcedureTypeMaster.CPT_dic.ContainsKey(countryName))
            {
                List<Country_ProcedureTypes> list = ProcedureTypeMaster.CPT_dic[countryName];
                if (list.Count == 1) return list[0];
                else if (list.Count > 1)
                {
                    foreach (Country_ProcedureTypes cpt in list)
                        if (cpt.IsSponsored.Value == IsSponsored) return cpt;
                }
            }

            return null;
        }

        public static void Reset()
        {
            ProcedureTypeMaster.lastUpdateTime = DateTime.MinValue;
            ProcedureTypeMaster.CPT_dic.Clear();
        }
    }
}
