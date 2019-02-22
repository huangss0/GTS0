using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using HssUtility.SQLserver;

namespace HssDARWIN.Models.Depositaries
{
    public class DepositaryMaster
    {
        private static Dictionary<string, Depositary> depoID_dic = new Dictionary<string, Depositary>(StringComparer.OrdinalIgnoreCase);
        private static Dictionary<string, Depositary> shortName_dic = new Dictionary<string, Depositary>(StringComparer.OrdinalIgnoreCase);
        private static Dictionary<string, Depositary> depoName_dic = new Dictionary<string, Depositary>(StringComparer.OrdinalIgnoreCase);

        private static DateTime lastUpdateTime = DateTime.MinValue;

        public static void Init_from_DB()
        {
            if ((DateTime.Now - DepositaryMaster.lastUpdateTime).TotalHours < Utility.RefreshInterval) return;

            DepositaryMaster.Reset();
            DB_select selt = new DB_select(Depositary.Get_cmdTP());

            DB_reader reader = new DB_reader(selt, Utility.Get_DRWIN_hDB());
            while (reader.Read())
            {
                Depositary depo = new Depositary();
                depo.Init_from_reader(reader);

                DepositaryMaster.depoID_dic[depo.DepositaryID.Value] = depo;
                DepositaryMaster.shortName_dic[depo.DepositaryShortName.Value] = depo;

                if (DepositaryMaster.depoName_dic.ContainsKey(depo.DepositaryName.Value)) //handle "unsponsered"
                {
                    Depositary existing_depo = DepositaryMaster.depoName_dic[depo.DepositaryName.Value];
                    if (depo.DepositaryIndex.Value < 0) continue;

                    if (existing_depo.DepositaryIndex.Value < 0) DepositaryMaster.depoName_dic[depo.DepositaryName.Value] = depo;
                    else if (depo.DepositaryIndex.Value < existing_depo.DepositaryIndex.Value) DepositaryMaster.depoName_dic[depo.DepositaryName.Value] = depo;
                    else continue;
                }
                else DepositaryMaster.depoName_dic[depo.DepositaryName.Value] = depo;
            }
            reader.Close();

            DepositaryMaster.lastUpdateTime = DateTime.Now;
        }

        public static Depositary GetDepositary_by_name(string name)
        {
            DepositaryMaster.Init_from_DB();
            if (name == null) return null;

            if (DepositaryMaster.depoName_dic.ContainsKey(name)) return DepositaryMaster.depoName_dic[name];
            else if (DepositaryMaster.shortName_dic.ContainsKey(name)) return DepositaryMaster.shortName_dic[name];
            else if (name.StartsWith("JPMorgan", StringComparison.OrdinalIgnoreCase)) return DepositaryMaster.depoName_dic["JPMORGAN CHASE"];
            else return null;
        }

        public static void Reset()
        {
            DepositaryMaster.lastUpdateTime = DateTime.MinValue;
            DepositaryMaster.depoID_dic.Clear();
            DepositaryMaster.shortName_dic.Clear();
            DepositaryMaster.depoName_dic.Clear();
        }
    }
}
