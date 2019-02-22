using System;
using System.Collections.Generic;

using HssUtility.SQLserver;

namespace HssDARWIN.Models.Custodians
{
    public class CustodianMaster
    {
        private static Dictionary<int, Custodian> num_dic = new Dictionary<int, Custodian>();
        private static Dictionary<string, Custodian> full_dic = new Dictionary<string, Custodian>(StringComparer.OrdinalIgnoreCase);
        private static Dictionary<string, Custodian> short_dic = new Dictionary<string, Custodian>(StringComparer.OrdinalIgnoreCase);

        private static DateTime lastUpdateTime = DateTime.MinValue;

        public static void Init_from_DB()
        {
            if ((DateTime.Now - CustodianMaster.lastUpdateTime).TotalHours < Utility.RefreshInterval) return;

            CustodianMaster.Reset();
            DB_select selt = new DB_select(Custodian.Get_cmdTP());
            DB_reader reader = new DB_reader(selt, Utility.Get_DRWIN_hDB());
            while (reader.Read())
            {
                Custodian cust = new Custodian();
                cust.Init_from_reader(reader);

                CustodianMaster.num_dic[cust.Custodian_Number] = cust;
                CustodianMaster.full_dic[cust.Custodian_FullName.Value] = cust;
                CustodianMaster.short_dic[cust.Custodian_ShortName.Value] = cust;
            }
            reader.Close();

            CustodianMaster.lastUpdateTime = DateTime.Now;
        }

        public static Custodian GetCustodian_num(int num)
        {
            CustodianMaster.Init_from_DB();

            if (CustodianMaster.num_dic.ContainsKey(num)) return CustodianMaster.num_dic[num];
            else return null;
        }

        public static Custodian GetCustodian_name(string name)
        {
            CustodianMaster.Init_from_DB();
            if (name == null) return null;

            if (CustodianMaster.full_dic.ContainsKey(name)) return CustodianMaster.full_dic[name];
            else if (CustodianMaster.short_dic.ContainsKey(name)) return CustodianMaster.short_dic[name];
            else return null;//more work needed to check alies
        }

        public static void Reset()
        {
            CustodianMaster.lastUpdateTime = DateTime.MinValue;
            CustodianMaster.num_dic.Clear();
            CustodianMaster.short_dic.Clear();
            CustodianMaster.full_dic.Clear();
        }
    }
}
