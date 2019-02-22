using System;
using System.Collections.Generic;
using System.Windows.Forms;

using HssUtility.SQLserver;
using HssUtility.General;
using HssDARWIN.Models.Depositaries;
using HssDARWIN.Models.Countries;
using HssDARWIN.Models.XBRL.Event;

namespace HssDARWIN.Models.Securities
{
    public class SecurityMaster
    {
        /// <summary>
        /// CUSIP as key
        /// </summary>
        private static Dictionary<string, List<Security>> secList_dic = new Dictionary<string, List<Security>>(StringComparer.OrdinalIgnoreCase);
        private static DateTime lastUpdateTime = DateTime.MinValue;

        public static void Init_from_DB()
        {
            if ((DateTime.Now - SecurityMaster.lastUpdateTime).TotalHours < Utility.RefreshInterval) return;

            CountryMaster.Reset();
            DB_select selt = new DB_select(Security.Get_cmdTP());
            DB_reader reader = new DB_reader(selt, Utility.Get_DRWIN_hDB());
            while (reader.Read())
            {
                Security sec = new Security();
                sec.Init_from_reader(reader);
                if (sec.CUSIP.IsValueEmpty) continue;

                string cusip = sec.CUSIP.Value;
                List<Security> list = null;

                if (SecurityMaster.secList_dic.ContainsKey(cusip)) list = SecurityMaster.secList_dic[cusip];
                else
                {
                    list = new List<Security>();
                    SecurityMaster.secList_dic[cusip] = list;
                }

                list.Add(sec);
            }
            reader.Close();

            foreach(List<Security> list in SecurityMaster.secList_dic.Values)
                list.Sort((a, b) => DateTime.Compare(b.EffectiveDate.Value, a.EffectiveDate.Value));

            SecurityMaster.lastUpdateTime = DateTime.Now;
        }

        public static void Reset()
        {
            SecurityMaster.lastUpdateTime = DateTime.MinValue;
            SecurityMaster.secList_dic.Clear();
        }

        public static List<Security> Get_secList_cusip(string cusip)
        {
            SecurityMaster.Init_from_DB();
            if (string.IsNullOrEmpty(cusip)) return new List<Security>();

            if (SecurityMaster.secList_dic.ContainsKey(cusip)) return secList_dic[cusip];
            else return new List<Security>();
        }

        public static Security GetSecurity_cusip(string cusip, DateTime curr_dt)
        {
            List<Security> secList = SecurityMaster.Get_secList_cusip(cusip);
            if (secList.Count < 1) return null;
            if (secList.Count == 1) return secList[0];//if only one, return it

            foreach (Security sec in secList)
            {
                if (curr_dt < sec.EffectiveDate.Value) continue;
                else return sec;
            }

            return secList[0];//if no match based on time, give first one
        }

        /*----------------------------------------------------------------------------------------------*/

        public static string FindTicker_form(string secName, string cusip)
        {
            Attribute_Input_form tif = new Attribute_Input_form(secName, cusip);
            tif.ShowDialog();
            return tif.UserInputValue;
        }

        public static string InputAttr_FromUI(Security sec, string attrName)
        {
            Attribute_Input_form tif = new Attribute_Input_form(sec, attrName);
            tif.ShowDialog();
            return tif.UserInputValue;
        }

        /*---------------------------------------XBRL----------------------------------------------------*/
        /// <summary>
        /// Create new Security or Get existing Security from DB
        /// </summary>
        /// <param name="xbrl">XML</param>
        /// <param name="autoSaveNew_flag">If automatically save new security to DB</param>
        /// <returns></returns>
        public static Security XBRL_Create_or_Get_Security(XBRL_event_info xei, bool autoSaveNew_flag)
        {
            if (xei == null) return null;

            Security existing_sec = SecurityMaster.GetSecurity_cusip(xei.CUSIP, xei.RecordDate_ADR);
            Security xbrl_sec = SecurityMaster.CreateSecurity_fromXBRL(xei);

            if (existing_sec == null)
            {
                if (xbrl_sec == null) return null;
                else
                {
                    xbrl_sec.EffectiveDate.Value = Utility.MinDate;
                    if (autoSaveNew_flag)
                    {
                        if (xbrl_sec.Country.IsValueEmpty) xbrl_sec.Country.Value = SecurityMaster.InputAttr_FromUI(xbrl_sec, "Country");
                        if (xbrl_sec.Country.IsValueEmpty) return null;
                        else xbrl_sec.Insert_to_DB();
                    }
                    return xbrl_sec;
                }
            }
            else
            {
                if (xbrl_sec == null) return existing_sec;
                else
                {
                    if (SecurityMaster.XBRL_isSameSecurity(existing_sec, xbrl_sec)) return existing_sec;
                    else
                    {
                        xbrl_sec.EffectiveDate.Value = xei.RecordDate_ADR;
                        if (xbrl_sec.TickerSymbol.IsValueEmpty) xbrl_sec.TickerSymbol.Value = existing_sec.TickerSymbol.Value;
                        if (xbrl_sec.ISIN.IsValueEmpty) xbrl_sec.ISIN.Value = existing_sec.ISIN.Value;

                        if (autoSaveNew_flag)
                        {
                            string newSec_info = "New: " + xbrl_sec.GetInfo_str();
                            string existingSec_info = "Old: " + existing_sec.GetInfo_str();

                            MessageBox.Show("New Security is created!!" + HssStr.WinNextLine + newSec_info + HssStr.WinNextLine + existingSec_info);
                            xbrl_sec.Insert_to_DB();
                        }

                        return xbrl_sec;
                    }
                }
            }
        }

        private static Security CreateSecurity_fromXBRL(XBRL_event_info xei)
        {
            if (xei == null) return null;

            if (string.IsNullOrEmpty(xei.CUSIP))
            {
                Console.WriteLine("SecurityMaster error 0: no CUSIP in XBRL");
                return null;
            }
            if (xei.ADR_Ratio_ADR == 0 || xei.ADR_Ratio_ORD == 0)
            {
                Console.WriteLine("SecurityMaster error 1: ratio incorrect in XBRL");
                return null;
            }

            Country cty = CountryMaster.GetCountry_name(xei.ISO2CntryCode);

            Depositary depo = DepositaryMaster.GetDepositary_by_name(xei.depoName);
            if (depo == null) depo = DepositaryMaster.GetDepositary_by_name(xei.Sender);
            if (depo == null)
            {
                Console.WriteLine("SecurityMaster error 2: no depository info in XBRL");
                return null;
            }

            Security xbrl_sec = new Security();
            xbrl_sec.Name.Value = xei.Issue.ToUpper();
            xbrl_sec.CUSIP.Value = xei.CUSIP;
            xbrl_sec.ClearingSystem.Value = "DTCC";
            xbrl_sec.SecurityType.Value = "ADR";
            xbrl_sec.ADR_RATIO_ADR.Value = xei.ADR_Ratio_ADR;
            xbrl_sec.ADR_RATIO_ORD.Value = xei.ADR_Ratio_ORD;
            if (cty != null) xbrl_sec.Country.Value = cty.name;            

            if (xei.Sponsored)
            {
                xbrl_sec.Depositary.Value = depo.DepositaryName.Value;
            }
            else //Un-sponsored event
            {
                if (xei.IsFirstFiler)
                {
                    xbrl_sec.Depositary.Value = Depositary.Unsponsored;
                    xbrl_sec.FirstFiler.Value = depo.DepositaryShortName.Value;
                }
                else
                {
                    Console.WriteLine("SecurityMaster info 0: Unsponsored event and this depo is not first filer, return null");
                    return null;
                }
            }

            xbrl_sec.LastModifiedBy.Value = Utility.CurrentUser;
            xbrl_sec.ModifiedDateTime.Value = DateTime.Now;

            return xbrl_sec;
        }

        private static bool XBRL_isSameSecurity(Security sec0, Security sec1)
        {
            if (sec0 == null || sec1 == null) return false;

            if (!sec0.CUSIP.GetValue_in_string(1).Equals(sec1.CUSIP.GetValue_in_string(1), StringComparison.OrdinalIgnoreCase)) return false;
            if (!sec0.Depositary.GetValue_in_string(1).Equals(sec1.Depositary.GetValue_in_string(1), StringComparison.OrdinalIgnoreCase)) return false;
            if (!sec0.FirstFiler.GetValue_in_string(1).Equals(sec1.FirstFiler.GetValue_in_string(1), StringComparison.OrdinalIgnoreCase)) return false;

            if (sec0.ADR_RATIO_ADR.Value != sec1.ADR_RATIO_ADR.Value) return false;
            if (sec0.ADR_RATIO_ORD.Value != sec1.ADR_RATIO_ORD.Value) return false;

            if (!sec0.SecurityType.GetValue_in_string(1).Equals(sec1.SecurityType.GetValue_in_string(1), StringComparison.OrdinalIgnoreCase)) return false;
            if (!sec0.ClearingSystem.GetValue_in_string(1).Equals(sec1.ClearingSystem.GetValue_in_string(1), StringComparison.OrdinalIgnoreCase)) return false;

            return true;
        }
        /*^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^*/
    }
}
