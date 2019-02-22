using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;

using HssUtility.SQLserver;
using HssUtility.General;
using HssDARWIN.Models.Details;
using HssDARWIN.Models.Custodians;
using HssDARWIN.Models.Filing;
using HssDARWIN.Models.DTC_Participant;
using HssDARWIN.Models.Depositaries;

namespace HssDARWIN.Models.Dividends
{
    public partial class Dividend
    {
        /// <summary>
        /// HashSet for selected dividend detail IDs used in AutoProration
        /// </summary>
        private HashSet<int> autoProration_selected_detailID_hs = null;

        public void AutoProration_async(HashSet<int> detailID_hs)
        {
            string msg = "Auto-Proration for Dividend " + this.DividendIndex;
            if (detailID_hs != null && detailID_hs.Count > 0) msg += " for selected Details (count=" + detailID_hs.Count + ")";

            this.autoProration_selected_detailID_hs = detailID_hs;

            if (MessageBox.Show(msg + "?", "Warning!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Thread th = new Thread(this.Auto_Proration);
                th.Start();
            }
        }

        /// <summary>
        /// Auto assign CustodianID for dividend details
        /// </summary>
        public void Auto_Proration()
        {
            Dictionary<int, DividendCustodian> dc_dic = this.Get_dvdCust_dic("Custodian");
            if (!this.Check_AutoProration_dcDic(dc_dic)) return;

            List<Dividend_Detail_simpleAP> all_dd_list = this.Get_dvdDetailAP_list("At-Source");//Only Auto-Prorate "At-Source" ReclaimFeeType
            List<Dividend_Detail_simpleAP> selected_dd_list = null;//Selected [Dividend_Detail] list for Auto-Proration
            if (this.autoProration_selected_detailID_hs == null || this.autoProration_selected_detailID_hs.Count < 1) selected_dd_list = all_dd_list;
            else
            {
                selected_dd_list = new List<Dividend_Detail_simpleAP>(this.autoProration_selected_detailID_hs.Count);
                foreach (Dividend_Detail_simpleAP detail in all_dd_list)
                {
                    if (!this.autoProration_selected_detailID_hs.Contains(detail.DetailID)) continue;
                    if (Helper_hssStatus.Str_to_Status(detail.Status.Value) == HssStatus.Rejected) continue;//ignore rejected [Dividend_Detail]

                    selected_dd_list.Add(detail);
                }
            }

            if (!this.CheckFiling_ddList(selected_dd_list)) return;
            if (!this.CheckCustodian_ddList(selected_dd_list)) return;

            //sort detail_list in decending order by RecordDatePosition
            selected_dd_list.Sort((a, b) => (decimal.Compare(b.RecordDatePosition.Value, a.RecordDatePosition.Value)));

            DvdCustodian_AP_master dam = new DvdCustodian_AP_master(dc_dic);
            dam.SubCal_expectedCount(all_dd_list);
            dam.Calculate(selected_dd_list);

            int count = dam.Update_to_DB();
            if (count > 0) MessageBox.Show("Auto Proration finished (count: " + count + ")");
            else MessageBox.Show("Nothing was done for Auto-Proration");
        }

        /// <summary>
        /// Check [Dividend_Custodian] existence and if linked to filing already
        /// </summary>
        private bool Check_AutoProration_dcDic(Dictionary<int, DividendCustodian> dc_dic)
        {
            if (dc_dic == null || dc_dic.Count == 0)
            {
                MessageBox.Show("Dividend_func6 error 0: No Dividend Custodian info for dividend " + this.DividendIndex);
                return false;
            }

            return true;
        }

        /// <summary>
        /// Check if any [Dividend_Detail] has been linked to filing
        /// </summary>
        private bool CheckFiling_ddList(List<Dividend_Detail_simpleAP> detail_list)
        {
            if (detail_list == null) return false;

            int filingLinked_count = 0;
            foreach (Dividend_Detail_simpleAP dd in detail_list)
            {
                if (dd.Dividend_FilingID.Value > 0) ++filingLinked_count;
            }

            if (filingLinked_count > 0)
            {
                string msg = "There are " + filingLinked_count + " Details already linked to filing."
                    + HssStr.WinNextLine + "Continue Auto-Proration?";
                if (MessageBox.Show(msg, "Warning", MessageBoxButtons.YesNo) != DialogResult.Yes) return false;
            }

            return true;
        }

        /// <summary>
        /// Check if any [Dividend_Detail] has been assigned a custodian
        /// </summary>
        private bool CheckCustodian_ddList(List<Dividend_Detail_simpleAP> detail_list)
        {
            if (detail_list == null) return false;
            Dictionary<int, DividendCustodian> all_dvdCust_dic = this.Get_dvdCust_dic(null);

            foreach (Dividend_Detail_simpleAP dd in detail_list)
            {
                if (all_dvdCust_dic.ContainsKey(dd.CustodianID.Value))
                {
                    string msg = "DetailID " + dd.DetailID + " already have been assigned custodian."
                        + HssStr.WinNextLine + "Auto-Proration NOT performed!";
                    MessageBox.Show(msg);
                    return false;
                }
            }

            return true;
        }
    }

    /// <summary>
    /// Used for Auto-Proration(DRWIN-391)
    /// </summary>
    class DvdCustodian_AP_master
    {
        /// <summary>
        /// CustodianID as key
        /// </summary>
        private Dictionary<int, DvdCustodian_AP_count> APcount_dic = new Dictionary<int, DvdCustodian_AP_count>();

        private Dictionary<int, DividendCustodian> dvdCust_dic = new Dictionary<int, DividendCustodian>();

        public DvdCustodian_AP_master(Dictionary<int, DividendCustodian> dc_dic)
        {
            if (dc_dic == null) return;
            foreach (KeyValuePair<int, DividendCustodian> pair in dc_dic) this.dvdCust_dic[pair.Key] = pair.Value;
        }

        /// <summary>
        /// If there's a primary Custodian, only return this one
        /// </summary>
        private List<DividendCustodian> CheckPrimary(Dictionary<int, DividendCustodian> dc_dic)
        {
            List<DividendCustodian> dc_list = new List<DividendCustodian>();
            foreach (DividendCustodian dc in dc_dic.Values)
            {
                if (dc.Primary_Contact.Value)
                {
                    dc_list.Clear();
                    dc_list.Add(dc);
                    break;
                }
                else dc_list.Add(dc);
            }
            return dc_list;
        }

        public void SubCal_expectedCount(List<Dividend_Detail_simpleAP> all_dd_list)
        {
            decimal total_dvdCust_reported = 0;
            List<DividendCustodian> dc_list = this.CheckPrimary(this.dvdCust_dic);
            foreach (DividendCustodian dc in dc_list)
            {
                DvdCustodian_AP_count dac = new DvdCustodian_AP_count(dc);
                this.APcount_dic.Add(dc.CustodianID, dac);
                total_dvdCust_reported += dc.Custodian_Reported.Value;
            }

            if (total_dvdCust_reported <= 0)
            {
                MessageBox.Show("Dividend_func6 error 2: Total Custodian Report shares is " + total_dvdCust_reported);
                return;
            }

            decimal total_detailReported = 0;
            foreach (Dividend_Detail_simpleAP dd in all_dd_list) total_detailReported += dd.RecordDatePosition.Value;

            //if detail total grerater then total custodian reported, only auto-prorate custodian total
            if (total_detailReported > total_dvdCust_reported) total_detailReported = total_dvdCust_reported;

            foreach (DvdCustodian_AP_count dac in this.APcount_dic.Values)
            {
                dac.pct = dac.dvdCust.Custodian_Reported.Value / total_dvdCust_reported;
                dac.expectedCount = dac.pct * total_detailReported;
            }

            //Subtract Dividend_Details which has already been assigned CustodianID from expectedCount
            foreach (Dividend_Detail_simpleAP dd in all_dd_list)
            {
                int custID = dd.CustodianID.Value;
                if (this.APcount_dic.ContainsKey(custID)) this.APcount_dic[custID].expectedCount -= dd.RecordDatePosition.Value;
            }
        }

        /// <summary>
        /// Find current max expectedCount in APcount_dic 
        /// </summary>
        private DvdCustodian_AP_count GetHighest_dc()
        {
            DvdCustodian_AP_count res = null;
            foreach (DvdCustodian_AP_count dac in this.APcount_dic.Values)
            {
                if (res == null) res = dac;
                else if (dac.expectedCount > res.expectedCount) res = dac;
            }

            return res;
        }

        /// <summary>
        /// Find closest expectedCount in APcount_dic
        /// </summary>
        /// <param name="currPos">RecordDatePosition in [Dividend_detail]</param>
        /// <param name="depoName">Depository name (used for RSH)</param>
        private DvdCustodian_AP_count GetClosest_dc(decimal currPos, string depoName)
        {
            DvdCustodian_AP_count res = null;
            foreach (DvdCustodian_AP_count dac in this.APcount_dic.Values)
            {
                if (depoName != null)
                {
                    if (!dac.dvdCust.Depositary.Value.Equals(depoName, StringComparison.OrdinalIgnoreCase)) continue;
                }

                if (dac.expectedCount < currPos) continue;

                if (res == null) res = dac;
                else if (dac.expectedCount - currPos < res.expectedCount - currPos) res = dac;
            }

            return res;
        }

        public void Calculate(List<Dividend_Detail_simpleAP> selected_dd_list)
        {
            if (selected_dd_list == null || this.APcount_dic.Count == 0) return;

            //Assign CustodianID for RSH first
            foreach (Dividend_Detail_simpleAP detail in selected_dd_list)
            {
                string DTCnum = detail.DTC_Number.Value;
                DTC_Participants dtcPart = DTC_Participants_master.Get_DTC_Participants_DTCnum(DTCnum);
                if (dtcPart == null || dtcPart.Type.IsValueEmpty) continue;
                if (!dtcPart.Type.Value.Equals("RSH", StringComparison.OrdinalIgnoreCase)) continue;

                DvdCustodian_AP_count dcAP = this.GetClosest_dc(detail.RecordDatePosition.Value, dtcPart.Depositary.Value);
                if (dcAP == null) continue;

                DividendCustodian dvdCust = dcAP.dvdCust;
                detail.CustodianID.Value = dvdCust.CustodianID;
                dcAP.expectedCount -= detail.RecordDatePosition.Value;
                dcAP.dd_list.Add(detail);

                //foreach (int custID in this.APcount_dic.Keys)
                //{
                //    DividendCustodian dvdCust = this.dvdCust_dic[custID];
                //    if (dvdCust.Depositary.Value.Equals(dtcPart.Depositary.Value, StringComparison.OrdinalIgnoreCase))//Try to match Depositary with [Dividend_Custodian]
                //    {
                //        DvdCustodian_AP_count dcAP = this.APcount_dic[custID];
                //        if (dcAP.expectedCount >= detail.RecordDatePosition.Value)
                //        {
                //            detail.CustodianID.Value = dvdCust.CustodianID;
                //            dcAP.expectedCount -= detail.RecordDatePosition.Value;
                //            dcAP.dd_list.Add(detail);
                //        }
                //        break;
                //    }
                //}
            }

            //Assign CustodianID for non-RSH
            foreach (Dividend_Detail_simpleAP detail in selected_dd_list)
            {
                string DTCnum = detail.DTC_Number.Value;
                if (DTCnum != null && DTCnum.StartsWith("RSH", StringComparison.OrdinalIgnoreCase)) continue;

                DvdCustodian_AP_count dcAP = this.GetHighest_dc();
                if (dcAP.expectedCount < detail.RecordDatePosition.Value) continue;

                DividendCustodian dvdCust = dcAP.dvdCust;
                detail.CustodianID.Value = dvdCust.CustodianID;
                dcAP.expectedCount -= detail.RecordDatePosition.Value;
                dcAP.dd_list.Add(detail);
            }
        }

        public int Update_to_DB()
        {
            int count = 0;
            if (Utility.Is_DWRIN_admin()) Helper_SQLserver.AllTrigers("Dividend_Detail", false, Utility.Get_DRWIN_hDB());
            foreach (DvdCustodian_AP_count dcAP in this.APcount_dic.Values) count += dcAP.Update_to_DB();
            if (Utility.Is_DWRIN_admin()) Helper_SQLserver.AllTrigers("Dividend_Detail", true, Utility.Get_DRWIN_hDB());
            return count;
        }
    }

    /// <summary>
    /// Used for Auto-Proration(DRWIN-391)
    /// </summary>
    class DvdCustodian_AP_count
    {
        public decimal expectedCount = 0, pct = 0;
        public DividendCustodian dvdCust = null;
        public List<Dividend_Detail_simpleAP> dd_list = new List<Dividend_Detail_simpleAP>();

        public DvdCustodian_AP_count(DividendCustodian dc)
        {
            this.dvdCust = dc;
        }

        public int Update_to_DB()
        {
            if (dvdCust == null) return -1;
            int count = 0, oneTimeAmount = Bulk_DBcmd.BatchAmount;

            DB_update upd = new DB_update(Dividend_Detail_simpleAP.Get_cmdTP());
            upd.AddValue("CustodianID", this.dvdCust.CustodianID);

            List<int> detailID_list = new List<int>(oneTimeAmount);
            foreach (Dividend_Detail_simpleAP dd in this.dd_list)
            {
                detailID_list.Add(dd.DetailID);

                if (detailID_list.Count >= oneTimeAmount)
                {
                    upd.SetCondition(new SQL_relation("DetailID", true, detailID_list));
                    count += upd.SaveToDB(Utility.Get_DRWIN_hDB());
                    detailID_list.Clear();
                }
            }

            if (detailID_list.Count > 0)
            {
                upd.SetCondition(new SQL_relation("DetailID", true, detailID_list));
                count += upd.SaveToDB(Utility.Get_DRWIN_hDB());
            }

            return count;
        }
    }
}
