using System;
using System.Collections.Generic;
using System.Windows.Forms;

using HssDARWIN.Models.Details;
using HssDARWIN.Models.DTC_Position;
using HssDARWIN.Models.DTC_Participant;
using HssDARWIN.Models.XBRL.DvdXBRL;
using HssDARWIN.Models.RSH;
using HssDARWIN.Models.Custodians;
using HssDARWIN.Models.Dividends;

namespace HssDARWIN.SubProjects.ElectionFile
{
    public partial class ElectionDocument
    {
        /*------------------------------------------------Attributes----------------------------------------------------------------------*/
        Dictionary<int, DividendCustodian> dvdCus_dic_all = null, dvdCus_dic_custodianType = null;

        /// <summary>
        /// Initialize name attributes
        /// </summary>
        private void Cal_initAttr_eventInfo(Dividend dvd)
        {
            this.AnnouncementIdentifier = this.dvdCust.Election_Version.Value + 1;

            List<DividendXBRL> dxList = dvd.Get_dividendXBRL_list();
            if (dxList.Count > 0)
            {
                string refNo = dxList[0].XBRL_ReferenceNumber.Value;
                foreach (DividendXBRL dx in dxList)
                {
                    if (dx.Depositary.Value.Equals(this.dvdCust.Depositary.Value, StringComparison.OrdinalIgnoreCase))
                        refNo = dx.XBRL_ReferenceNumber.Value;
                }
                this.eventInfo.UniqueUniversalEventIdentifier = refNo;
            }

            this.eventInfo.ADRBase = dvd.ADR_Ratio_ADR.Value;
            this.eventInfo.OrdinaryShare = dvd.ADR_Ratio_ORD.Value;
            this.eventInfo.SECURITY_IDENTIFIER_CUSIP = dvd.CUSIP.Value;
            this.eventInfo.ISSUER_NAME = dvd.Issue.Value;
            this.eventInfo.ADR_RECORD_DATE = dvd.RecordDate_ADR.Value;
        }

        /// <summary>
        /// Initialize all collection attributes using DTC Model Number
        /// </summary>
        private void Cal_initAttr_collections(HashSet<decimal> whr_hs, Dividend dvd)
        {
            int optNum = 0;
            foreach (decimal wh_rate in whr_hs)
            {
                Election_item item1 = new Election_item(optNum, wh_rate, "DTC_PARTICIPANT_ELECTION");
                this.DTC_participant_dic[wh_rate] = item1;

                Election_item item2 = new Election_item(optNum, wh_rate, "RSH_ELECTION");
                this.RSH_dic[wh_rate] = item2;

                Election_item item3 = new Election_item(optNum, wh_rate, "TOTAL_ELECTION");
                this.summary.totalEle_dic[wh_rate] = item3;

                ++optNum;
            }

            int cEle_ID = 0;
            foreach (KeyValuePair<int, DividendCustodian> pair in this.dvdCus_dic_custodianType)//<CUSTODIAN_DETAILS>
            {
                int custodianID = pair.Key;
                DividendCustodian dvdCust = pair.Value;
                if (!dvdCust.Depositary.Value.Equals(this.dvdCust.Depositary.Value, StringComparison.OrdinalIgnoreCase)) continue;

                Custodian_ele ce = new Custodian_ele();
                this.custodianEle_dic[custodianID] = ce;

                ce.ID = ++cEle_ID;
                ce.CUSTODIAN_NAME = dvdCust.Get_custodian_fullName();
                ce.CUSTODIAN_REFERENCE = dvdCust.Custodian_Number.Value.ToString();

                optNum = 0;
                foreach (decimal wh_rate in whr_hs)
                {
                    Election_item item1 = new Election_item(optNum, wh_rate, "CUSTODIAN_ELECTION_OPTION");
                    ce.cust_dic[wh_rate] = item1;

                    ++optNum;
                }
            }
        }
        /*^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^*/

        /*-----------------------------------------------DTC Position-----------------------------------------------------------------------*/
        private void Calculate_special_from_DTCposition(Dictionary<decimal, List<DTC_Position_Headers>> whr_map, Dividend dvd)
        {
            this.SubCal_read_DTCposition(whr_map, dvd);
            this.SubCal_final_step(dvd);
        }

        private void SubCal_read_DTCposition(Dictionary<decimal, List<DTC_Position_Headers>> whr_map, Dividend dvd)
        {
            List<Dividend_DTC_Position> pos_list = dvd.Get_DTCposition_list();

            ParticipantMaster pc = new ParticipantMaster();
            pc.Init_from_dtcPosList(pos_list);

            foreach (Dividend_DTC_Position pos in pos_list)
            {
                bool isRSH_flag = false;
                Participant pt = pc.GetParticipant(pos.DTC_Number.Value);
                if (pt != null) isRSH_flag = pt.DCT_Number.StartsWith("RSH", StringComparison.OrdinalIgnoreCase);

                int custodianID = pos.CustodianID.Value;
                if (!this.dvdCus_dic_custodianType.ContainsKey(custodianID)) continue;

                DividendCustodian pos_dvdCust = this.dvdCus_dic_custodianType[custodianID];//check against selected Depository
                if (!pos_dvdCust.Depositary.Value.Equals(this.dvdCust.Depositary.Value, StringComparison.OrdinalIgnoreCase)) continue;

                foreach (KeyValuePair<decimal, List<DTC_Position_Headers>> pair in whr_map)
                {
                    decimal WH_rate = pair.Key, ADR_shares = 0;
                    foreach (DTC_Position_Headers dph in pair.Value) ADR_shares += pos.GetRateValues(dph.Table_Column.Value);

                    if (isRSH_flag) this.RSH_dic[WH_rate].ADRQuantity += ADR_shares;
                    else this.DTC_participant_dic[WH_rate].ADRQuantity += ADR_shares;

                    this.custodianEle_dic[custodianID].cust_dic[WH_rate].ADRQuantity += ADR_shares;
                    this.summary.totalEle_dic[WH_rate].ADRQuantity += ADR_shares;
                }
            }
        }
        /*^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^*/

        /*-----------------------------------------------Dividend Detail--------------------------------------------------------------------*/
        private void Calculate_commen_from_Detail(HashSet<decimal> WHrate_hs, Dividend dvd)
        {
            if (dvd == null || WHrate_hs == null) return;

            this.SubCal_read_detail(WHrate_hs, dvd);//initialize values from [Dividend_Detail]
            this.SubCal_read_RSH(WHrate_hs, dvd);//initialize values from [RSH_Log]
            this.SubCal_final_step(dvd);
        }

        /// <summary>
        /// initialize dictionary values from [Dividend_Detail]
        /// </summary>
        private void SubCal_read_detail(HashSet<decimal> WHrate_hs, Dividend dvd)
        {
            List<Dividend_Detail_simpleEF> dd_list = dvd.Get_dvdDetail_list(null);
            foreach (Dividend_Detail_simpleEF detail in dd_list)
            {
                if (!this.Check_DD_forEle(detail, dvd)) continue;

                decimal dd_WHRate = detail.Get_WHrate(dvd) * 100;//convert to percentage
                if (!WHrate_hs.Contains(dd_WHRate)) continue;

                decimal ADR_shares = detail.RecordDatePosition.Value;

                if (!detail.DTC_Number.Value.StartsWith("RSH", StringComparison.OrdinalIgnoreCase)) this.DTC_participant_dic[dd_WHRate].ADRQuantity += ADR_shares;
                this.summary.totalEle_dic[dd_WHRate].ADRQuantity += ADR_shares;
                this.custodianEle_dic[detail.CustodianID.Value].cust_dic[dd_WHRate].ADRQuantity += ADR_shares;
            }
        }

        private void SubCal_read_RSH(HashSet<decimal> WHrate_hs, Dividend dvd)
        {
            List<RSH_log> rshList = dvd.Get_RSH_list();

            foreach (RSH_log rl in rshList)
            {
                decimal rsh_WHRate = -1;
                string GT_findings = rl.GlobeTax_Findings.Value;

                if (!decimal.TryParse(GT_findings, out rsh_WHRate)) continue;
                else rsh_WHRate = rsh_WHRate * 100;//convert to percentage

                if (!WHrate_hs.Contains(rsh_WHRate)) continue;

                this.RSH_dic[rsh_WHRate].ADRQuantity += rl.Shares.Value;
            }
        }

        /// <summary>
        /// Check if DividendDetail is OK for counting in Election File
        /// </summary>
        private bool Check_DD_forEle(Dividend_Detail_simpleEF dd, Dividend dvd)
        {
            if (dd.Status.Value.StartsWith("Reject", StringComparison.OrdinalIgnoreCase)) return false;

            if (!dvd.Sponsored.Value)//for Unsponsored events only
            {
                int custID = dd.CustodianID.Value;
                if (!this.dvdCus_dic_all.ContainsKey(custID)) return false;
                else
                {
                    DividendCustodian dc = this.dvdCus_dic_all[custID];
                    if (!dc.Depositary.Value.Equals(this.dvdCust.Depositary.Value, StringComparison.OrdinalIgnoreCase)) return false;
                }
            }

            if (dd.ReclaimFeesType.Value.Equals("At-Source", StringComparison.OrdinalIgnoreCase)) return true;
            else if (dd.ReclaimFeesType.Value.Equals("Quick-Refund", StringComparison.OrdinalIgnoreCase)) return dd.PaidViaDTCC.Value;
            else return false;
        }
        /*^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^*/

        private void SubCal_final_step(Dividend dvd)
        {
            this.SubCal_diff_from_dvdCust(dvd);//unfavorable values
            this.SubCal_ORD(dvd);//calculate ORD values based on ratio
            this.SubCal_PR_WS(dvd);//Pre-release and Working-supply in summary
        }

        /// <summary>
        /// Calculate the difference between sum of values in [Dividend_Detail] and [Dividend_Custodian]
        /// </summary>
        private void SubCal_diff_from_dvdCust(Dividend dvd)
        {
            if (dvd == null) return;

            Dictionary<int, decimal> diff_dic = new Dictionary<int, decimal>();//[Custodian_Number] as key

            foreach (DividendCustodian dc in this.dvdCus_dic_custodianType.Values)//get total from [Dividend_Custodian]
            {
                if (!dc.Depositary.Value.Equals(this.dvdCust.Depositary.Value, StringComparison.OrdinalIgnoreCase)) continue;
                diff_dic[dc.CustodianID] = dc.Custodian_Reported.Value;
            }

            decimal statutoryRate = dvd.StatutoryRate.Value * 100;//convert to percentage
            foreach (KeyValuePair<int, Custodian_ele> pair in this.custodianEle_dic)
            {
                Custodian_ele cele = pair.Value;
                int custodianID = pair.Key;
                decimal sum = 0;

                foreach (Election_item ele in cele.cust_dic.Values) sum += ele.ADRQuantity;//sum of detail
                diff_dic[custodianID] -= sum; //find differrence from detail

                if (cele.cust_dic.ContainsKey(statutoryRate))
                {
                    decimal unfavour_shares = diff_dic[custodianID];
                    if (unfavour_shares < 0)
                        MessageBox.Show("ElectionDocument Info 0: Details' RecordDatePosition total greater than Custodian(" + custodianID + ") Reported");
                    else cele.cust_dic[statutoryRate].ADRQuantity += unfavour_shares;
                }
            }

            decimal diff_custodianReported = 0;
            foreach (decimal diff in diff_dic.Values) diff_custodianReported += diff;
            if (this.DTC_participant_dic.ContainsKey(statutoryRate)) this.DTC_participant_dic[statutoryRate].ADRQuantity += diff_custodianReported;
            if (this.summary.totalEle_dic.ContainsKey(statutoryRate)) this.summary.totalEle_dic[statutoryRate].ADRQuantity += diff_custodianReported;
        }

        /// <summary>
        /// Calculate ORD values based on ADR ratio
        /// </summary>
        private void SubCal_ORD(Dividend dvd)
        {
            if (dvd == null) return;
            if (dvd.ADR_Ratio_ADR.Value == 0) return;

            decimal ratio = dvd.ADR_Ratio_ORD.Value / dvd.ADR_Ratio_ADR.Value;

            foreach (Election_item ele in this.DTC_participant_dic.Values) ele.ORDQuantity = ele.ADRQuantity * ratio;
            foreach (Election_item ele in this.RSH_dic.Values) ele.ORDQuantity = ele.ADRQuantity * ratio;
            foreach (Election_item ele in this.summary.totalEle_dic.Values) ele.ORDQuantity = ele.ADRQuantity * ratio;

            foreach (Custodian_ele cele in this.custodianEle_dic.Values)
                foreach (Election_item ele in cele.cust_dic.Values) ele.ORDQuantity = ele.ADRQuantity * ratio;
        }

        /// <summary>
        /// Calculate values for Pre-release and Working-supply in summary
        /// </summary>
        private void SubCal_PR_WS(Dividend dvd)
        {
            if (dvd == null) return;

            foreach (DividendCustodian dc in this.dvdCus_dic_all.Values)
            {
                if (!dc.Depositary.Value.Equals(this.dvdCust.Depositary.Value, StringComparison.OrdinalIgnoreCase)) continue;

                if (dc.Custodian_Type.Value.StartsWith("Pre-Release", StringComparison.OrdinalIgnoreCase))
                    this.summary.PRE_RELEASE_TOTAL += dc.Custodian_Reported.Value;
                else if (dc.Custodian_Type.Value.StartsWith("Working Supply", StringComparison.OrdinalIgnoreCase))
                    this.summary.WORKING_SUPPLY_TOTAL += dc.Custodian_Reported.Value;
            }
        }
    }
}
