using System;
using System.Collections.Generic;

using HssUtility.SQLserver;
using HssUtility.General;

namespace HssDARWIN.Models.Fees
{
    public class DSC_master
    {
        public static Schedule_Of_Fees_DSC GetDSC_from_CDS(string country, string depositary, DateTime curr_dt, int secTypeID)
        {
            List<Schedule_Of_Fees_DSC> list = DSC_master.GetList_from_CD(country, depositary);
            Schedule_Of_Fees_DSC temp_sf = null;

            foreach (Schedule_Of_Fees_DSC sf in list)
            {
                if (sf.SecurityTypeID.Value != secTypeID) continue;
                temp_sf = sf;

                if (curr_dt >= sf.EffectiveDate.Value) return sf;
            }

            return temp_sf;
        }

        public static List<Schedule_Of_Fees_DSC> GetList_from_CD(string country, string depositary)
        {
            List<Schedule_Of_Fees_DSC> list = new List<Schedule_Of_Fees_DSC>();
            if (string.IsNullOrEmpty(country) || string.IsNullOrEmpty(depositary)) return list;

            DB_select selt = new DB_select(Schedule_Of_Fees_DSC.Get_cmdTP());
            SQL_relation rela1 = new SQL_relation("Country", RelationalOperator.Equals, country);
            SQL_relation rela2 = new SQL_relation("Depositary", RelationalOperator.Equals, depositary);
            SQL_condition cond = new SQL_condition(new SQL_condition(rela1), ConditionalOperator.And, new SQL_condition(rela2));
            selt.SetCondition(cond);

            DB_reader reader = new DB_reader(selt, Utility.Get_DRWIN_hDB());
            while (reader.Read())
            {
                Schedule_Of_Fees_DSC sof = new Schedule_Of_Fees_DSC();
                sof.Init_from_reader(reader);
                list.Add(sof);
            }
            reader.Close();

            list.Sort((a, b) => DateTime.Compare(b.EffectiveDate.Value, a.EffectiveDate.Value));
            return list;
        }

        /*---------------------------------------------------------------------------------------------------------------------------*/

        private static List<Schedule_Of_Fees_Per_Rate> sfpr_list = new List<Schedule_Of_Fees_Per_Rate>();
        private static DateTime lastUpdateTime = DateTime.MinValue;

        public static void Init_from_DB()
        {
            if ((DateTime.Now - DSC_master.lastUpdateTime).TotalHours < Utility.RefreshInterval) return;

            DSC_master.Reset();
            DB_select selt = new DB_select(Schedule_Of_Fees_Per_Rate.Get_cmdTP());

            DB_reader reader = new DB_reader(selt, Utility.Get_DRWIN_hDB());
            while (reader.Read())
            {
                Schedule_Of_Fees_Per_Rate sfpr = new Schedule_Of_Fees_Per_Rate();
                sfpr.Init_from_reader(reader);
                DSC_master.sfpr_list.Add(sfpr);
            }
            reader.Close();

            DSC_master.sfpr_list.Sort((a, b) => DateTime.Compare(b.EffectiveDate.Value, a.EffectiveDate.Value));
            DSC_master.lastUpdateTime = DateTime.Now;
        }

        /// <summary>
        /// Get Japan ADSC_fee & AtSourceFee
        /// </summary>
        /// <returns>Withholding Rate as key</returns>
        public static Dictionary<decimal, Schedule_Of_Fees_Per_Rate> Get_SFPR_dic(string countryName, string depoName, DateTime currDT)
        {
            DSC_master.Init_from_DB();

            Dictionary<decimal, Schedule_Of_Fees_Per_Rate> dic = new Dictionary<decimal, Schedule_Of_Fees_Per_Rate>();
            if (!countryName.Equals("Japan", StringComparison.OrdinalIgnoreCase)) return dic;

            foreach (Schedule_Of_Fees_Per_Rate sfpr in DSC_master.sfpr_list)
            {
                if (!sfpr.Depositary.Value.Equals(depoName, StringComparison.OrdinalIgnoreCase)) continue;
                if (sfpr.EffectiveDate.Value > currDT) continue;

                decimal key = sfpr.WithholdingRate.Value;
                if (!dic.ContainsKey(key)) dic[key] = sfpr;
            }

            return dic;
        }

        public static void Reset()
        {
            DSC_master.lastUpdateTime = DateTime.MinValue;
            DSC_master.sfpr_list.Clear();
        }
    }
}
