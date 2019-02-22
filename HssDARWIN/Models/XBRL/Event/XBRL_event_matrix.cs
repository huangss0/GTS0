using System;
using System.Collections.Generic;

using HssDARWIN.Models.Dividends;
using HssDARWIN.Models.XBRL.DvdXBRL;
using HssDARWIN.Models.Depositaries;

namespace HssDARWIN.Models.XBRL.Event
{
    public class XBRL_event_matrix
    {
        public static Action ApproveXBRL_action(XBRL_event_info xei, Dividend existing_dvd)
        {
            if (xei == null) return Action.None;
            if (existing_dvd == null) return Action.Create_New_Event;

            bool diffRef_sameDepo_flag = XBRL_event_matrix.DifferentRef_from_sameDepo(xei, existing_dvd);
            if (diffRef_sameDepo_flag) return Action.Create_New_Event;

            if (xei.IsCompleteEvent_flag)
            {
                if (existing_dvd.IsCompleteEvent_flag)
                {
                    if (xei.Sponsored) return Action.Update_Existing_event;
                    else //Unsponsored XBRL
                    {
                        if (xei.IsFirstFiler) return Action.Update_Existing_event;
                        else return Action.Add_Ref_to_Current;
                    }
                }
                else //In-complete Existing Event
                {
                    return Action.Update_Existing_event;
                }
            }
            else // In-complete XBRL
            {
                if (existing_dvd.IsCompleteEvent_flag) return Action.Add_Ref_to_Current;
                else //In-complete Existing Event
                {
                    if (xei.Sponsored) return Action.Update_Existing_event;
                    else //Unsponsored XBRL
                    {
                        if (xei.IsFirstFiler) return Action.Update_Existing_event;
                        else return Action.Add_Ref_to_Current;
                    }
                }
            }
        }

        private static bool DifferentRef_from_sameDepo(XBRL_event_info xei, Dividend existing_dvd)
        {
            if (xei == null || existing_dvd == null) return false;

            List<DividendXBRL> dx_list = existing_dvd.Get_dividendXBRL_list();
            foreach (DividendXBRL dx in dx_list)
            {
                if (dx.XBRL_ReferenceNumber.IsValueEmpty || dx.Depositary.IsValueEmpty) continue;
                if (dx.XBRL_ReferenceNumber.Value.Equals(xei.XBRL_ReferenceNumber, StringComparison.OrdinalIgnoreCase)) continue;

                Depositary existingDepo = DepositaryMaster.GetDepositary_by_name(dx.Depositary.Value);
                if (existingDepo == null) continue;

                Depositary XBRLdepo = DepositaryMaster.GetDepositary_by_name(xei.depoName);
                if (XBRLdepo == null) XBRLdepo = DepositaryMaster.GetDepositary_by_name(xei.Sender);
                if (XBRLdepo == null) continue;

                if (XBRLdepo.DepositaryName.Value.Equals(existingDepo.DepositaryName.Value, StringComparison.OrdinalIgnoreCase)) return true;
            }

            return false;
        }
    }

    public enum Action
    {
        None = -1,
        Create_New_Event = 1,
        Update_Existing_event = 2,
        Add_Ref_to_Current = 3,
    }
}
