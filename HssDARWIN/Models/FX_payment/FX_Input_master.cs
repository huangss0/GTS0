using System;
using System.Collections.Generic;

using HssUtility.SQLserver;
using HssDARWIN.Models.Tasks;

namespace HssDARWIN.Models.FX_payment
{
    public class FX_Input_master
    {
        private static Dictionary<int, FX_Input> fi_dic = new Dictionary<int, FX_Input>();

        private static DateTime lastUpdateTime = DateTime.MinValue;

        public static void Init_from_DB()
        {
            if ((DateTime.Now - FX_Input_master.lastUpdateTime).TotalHours < Utility.RefreshInterval) return;

            FX_Input_master.Reset();
            DB_select selt = new DB_select(FX_Input.Get_cmdTP());
            DB_reader reader = new DB_reader(selt, Utility.Get_DRWIN_hDB());
            while (reader.Read())
            {
                FX_Input fxi = new FX_Input();
                fxi.Init_from_reader(reader);
                FX_Input_master.fi_dic[fxi.FX_InputID] = fxi;
            }
            reader.Close();

            FX_Input_master.lastUpdateTime = DateTime.Now;
        }

        public static FX_Input Get_FXinput_ID(int FX_InputID)
        {
            FX_Input_master.Init_from_DB();
            if (FX_Input_master.fi_dic.ContainsKey(FX_InputID)) return FX_Input_master.fi_dic[FX_InputID];
            else return null;
        }

        public static void Reset()
        {
            FX_Input_master.lastUpdateTime = DateTime.MinValue;
            FX_Input_master.fi_dic.Clear();
        }

        public static Dictionary<int, FX_Input> Get_checkLocked_FI_dic()
        {
            FX_Input_master.Init_from_DB();
            Dictionary<int, FX_Input> checked_dic = new Dictionary<int, FX_Input>();
            foreach (KeyValuePair<int, FX_Input> pair in FX_Input_master.fi_dic) checked_dic[pair.Key] = pair.Value;

            //we have less unlocked dividend payment than locked ones
            List<Dividend_Payment> unlock_payment_list = DividendPaymentMaster.GetAll_payment_list(0);
            foreach (Dividend_Payment dp in unlock_payment_list)
            {
                int fxID = dp.FX_InputID.Value;
                if (checked_dic.ContainsKey(fxID)) checked_dic[fxID].SetLockFlag(false);
            }

            return checked_dic;
        }

        public static void RecheckLocked_and_clearTask20A(int FX_InputID)
        {
            FX_Input fxi = FX_Input_master.Get_FXinput_ID(FX_InputID);
            if (fxi == null) return;
            if (fxi.RecheckLocked()) TaskDetailMaster.SetTaskCompleteness(20, fxi.FX_InputID.ToString(), "A", true);
        }
    }
}
