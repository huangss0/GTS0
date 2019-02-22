using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using HssUtility.SQLserver;

namespace HssDARWIN.Models.DTC_Model
{
    public class DTC_model_master
    {
        private static Dictionary<int, DTCPositionModelNumber_Mapping> mapping_dic = new Dictionary<int, DTCPositionModelNumber_Mapping>();
        private static Dictionary<string, List<DTCPositionModelNumber_Mapping>> country_dic = new Dictionary<string, List<DTCPositionModelNumber_Mapping>>(StringComparer.OrdinalIgnoreCase);
        private static DateTime lastUpdateTime = DateTime.MinValue;

        public static void Init_from_DB()
        {
            if ((DateTime.Now - DTC_model_master.lastUpdateTime).TotalHours < Utility.RefreshInterval) return;

            DTC_model_master.Reset();
            DB_select selt = new DB_select(DTCPositionModelNumber_Mapping.Get_cmdTP());

            DB_reader reader = new DB_reader(selt, Utility.Get_DRWIN_hDB());
            while (reader.Read())
            {
                DTCPositionModelNumber_Mapping dm = new DTCPositionModelNumber_Mapping();
                dm.Init_from_reader(reader);

                DTC_model_master.mapping_dic[dm.ModelNumber.Value] = dm;

                if (!DTC_model_master.country_dic.ContainsKey(dm.Country.Value))
                {
                    List<DTCPositionModelNumber_Mapping> list = new List<DTCPositionModelNumber_Mapping>();
                    DTC_model_master.country_dic[dm.Country.Value] = list;
                }
                DTC_model_master.country_dic[dm.Country.Value].Add(dm);
            }
            reader.Close();

            DTC_model_master.lastUpdateTime = DateTime.Now;
        }

        public static DTCPositionModelNumber_Mapping GetMapping_modelNum(int model_num)
        {
            DTC_model_master.Init_from_DB();
            if (DTC_model_master.mapping_dic.ContainsKey(model_num)) return DTC_model_master.mapping_dic[model_num];
            else return null;
        }

        public static DTCPositionModelNumber_Mapping GetMapping_country(string countryName, string secName, DateTime curr_dt, int secTypeID)
        {
            DTC_model_master.Init_from_DB();
            if (string.IsNullOrEmpty(countryName)) return null;
            if (!DTC_model_master.country_dic.ContainsKey(countryName)) return null;

            List<DTCPositionModelNumber_Mapping> list = DTC_model_master.country_dic[countryName];
            int i = 0, j = list.Count - 1;
            while (i < j)//put the mapping with issue in front, quick sort
            {
                while (i < j && !string.IsNullOrEmpty(list[i].Issue.Value)) ++i;
                while (i < j && string.IsNullOrEmpty(list[j].Issue.Value)) --j;

                DTCPositionModelNumber_Mapping temp = list[i];
                list[i] = list[j];
                list[j] = temp;
            }            

            foreach (DTCPositionModelNumber_Mapping dm in list)
            {
                if (curr_dt < dm.ADRRecordDate.Value) continue;
                if (curr_dt > dm.ADRRecordDate_End.Value) continue;
                if (dm.SecurityTypeID.Value != secTypeID) continue;

                if (dm.CheckIssueMatch(secName)) return dm;
            }

            return null;
        }

        public static void Reset()
        {
            DTC_model_master.lastUpdateTime = DateTime.MinValue;
            DTC_model_master.mapping_dic.Clear();
            DTC_model_master.country_dic.Clear();
        }
    }
}
