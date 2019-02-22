using System;
using System.Collections.Generic;
using System.Data;

using HssUtility.SQLserver;
using HssUtility.General;
using HssUtility.Debug;
using HssDARWIN.Models.DTC_Participant;
using HssDARWIN.Models.DTC_Model;
using HssDARWIN.Models.DTC_Position;

namespace HssDARWIN.SubProjects.Business_Development
{
    public class DTC_Solicitation
    {
        public HssThreadInfo_log statusInfo = new HssThreadInfo_log();

        public List<string> country_list = new List<string>();
        public List<int> dtc_list = new List<int>();

        private List<BD_DTC_Position> dtcPos_list = new List<BD_DTC_Position>();
        private Dictionary<int, BD_Dividend> dvd_dic = new Dictionary<int, BD_Dividend>();//DividendIndex as key

        public DataTable Get_report_DT()
        {
            DateTime startAt = DateTime.Now;
            this.statusInfo.additional_info_list.Add("Reporting start at: " + startAt);

            DataTable dt = this.CreateEmpty_dt();
            HashSet<int> dvdIndex_hs = this.Create_dvdIndex_hs();

            this.dvd_dic = this.CreateDvdDic(dvdIndex_hs);
            this.Assign_Dvd_DTC(this.dvd_dic, this.dtcPos_list);

            this.Cal_ClaimShares_ADRS_SUM(this.dvd_dic);

            this.Cal_ClaimShares_ADRS_pos(this.dvd_dic);

            this.Assign_values_DT(dt, this.dvd_dic);

            return dt;
        }

        /*----------------------------------------------------------------------------------------*/

        private DataTable CreateEmpty_dt()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("DTC Position #");
            dt.Columns.Add("DTC");
            dt.Columns.Add("DTC#");
            dt.Columns.Add("Account#");
            dt.Columns.Add("DTC Model");
            dt.Columns.Add("DTC Name");
            dt.Columns.Add("Dividend Index");
            dt.Columns.Add("Country");
            dt.Columns.Add("Issue");
            dt.Columns.Add("CUSIP");

            dt.Columns.Add("ADR Record Date");
            dt.Columns.Add("ADR Pay Date");
            dt.Columns.Add("Final DIV Gross Amount");
            dt.Columns.Add("Final DIV Gross Amount(ORD)");
            dt.Columns.Add("Long Form Fee per DR");
            dt.Columns.Add("Statutory Rate");
            dt.Columns.Add("Treaty Rate");
            dt.Columns.Add("Record Date Position(ADR)");

            dt.Columns.Add("Claimed on Total ADRS");
            dt.Columns.Add("DTC FAV Position");
            dt.Columns.Add("DTC Exempt Position");
            dt.Columns.Add("Remaining Total ADRs");
            //dt.Columns.Add("Potential Refund Value");
            //dt.Columns.Add("Potential DSC");
            //dt.Columns.Add("Total Potential Refund Value");
            //dt.Columns.Add("Max Potential Refund Value");

            return dt;
        }

        private HashSet<int> Create_dvdIndex_hs()
        {
            this.statusInfo.status = "Create dvdIndex_hs from DTC_Position";

            HashSet<int> dvdIndex_hs = new HashSet<int>();
            DB_select selt = new DB_select(BD_DTC_Position.Get_cmdTP());
            DB_reader reader = new DB_reader(selt, Utility.Get_DRWIN_hDB());

            while (reader.Read())
            {
                BD_DTC_Position bdp = new BD_DTC_Position();
                bdp.Init_from_reader(reader);

                dvdIndex_hs.Add(bdp.DividendIndex);

                DTC_Participants dp = DTC_Participants_master.Get_DTC_Participants_DTCnum(bdp.DTC_Number);
                bdp.dtcParti = dp;

                this.dtcPos_list.Add(bdp);
                ++this.statusInfo.recordNum;
            }
            reader.Close();

            return dvdIndex_hs;
        }

        private Dictionary<int, BD_Dividend> CreateDvdDic(HashSet<int> dvdIndex_hs)
        {
            this.statusInfo.status = "Create Dividend Dictionary";

            Dictionary<int, BD_Dividend> dic = new Dictionary<int, BD_Dividend>();
            if (dvdIndex_hs == null) return dic;

            DB_select selt = new DB_select(BD_Dividend.Get_cmdTP());
            SQL_relation rela = new SQL_relation("DividendIndex", true, dvdIndex_hs);
            selt.SetCondition(rela);

            DB_reader reader = new DB_reader(selt, Utility.Get_DRWIN_hDB());

            while (reader.Read())
            {
                BD_Dividend dvd = new BD_Dividend();
                dvd.Init_from_reader(reader);

                dic[dvd.DividendIndex] = dvd;
                ++this.statusInfo.recordNum;
            }
            reader.Close();

            return dic;
        }

        private void Assign_Dvd_DTC(Dictionary<int, BD_Dividend> dvd_dic, List<BD_DTC_Position> dp_list)
        {
            this.statusInfo.status = "Assign DTC_Position to Dividend";
            if (dvd_dic == null || dp_list == null) return;

            foreach (BD_DTC_Position bdp in dp_list)
            {
                if (!this.dvd_dic.ContainsKey(bdp.DividendIndex)) continue;
                if (string.IsNullOrEmpty(bdp.DTC_Number)) continue;

                BD_Dividend dvd = dvd_dic[bdp.DividendIndex];
                dvd.bdp_dic[bdp.DTC_Number] = bdp;

                ++this.statusInfo.recordNum;
            }
        }

        private void Cal_ClaimShares_ADRS_SUM(Dictionary<int, BD_Dividend> dic)
        {
            this.statusInfo.status = "Calculate ClaimShares_ADRS_SUM";

            DB_select selt = new DB_select(BD_detailSum.Get_cmdTP());
            SQL_relation rela0 = new SQL_relation("Status", RelationalOperator.NotEqual, "REJECTED");
            SQL_relation rela1 = new SQL_relation("ReceivedDate", RelationalOperator.GreaterThan, "1900-1-1");
            SQL_condition cond0 = new SQL_condition(rela0, ConditionalOperator.And, rela1);
            SQL_relation rela2 = new SQL_relation("RecordDatePosition", RelationalOperator.GreaterThan, 0);

            selt.SetCondition(new SQL_condition(cond0, ConditionalOperator.And, rela2));

            DB_reader reader = new DB_reader(selt, Utility.Get_DRWIN_hDB());

            int count = 0;
            while (reader.Read())
            {
                BD_detailSum detail = new BD_detailSum();
                detail.Init_from_reader(reader);

                if (!dic.ContainsKey(detail.DividendIndex)) continue;

                BD_Dividend dvd = this.dvd_dic[detail.DividendIndex];
                if (!dvd.bdp_dic.ContainsKey(detail.DTC_Number)) continue;

                BD_DTC_Position bdp = dvd.bdp_dic[detail.DTC_Number];
                bdp.ClaimShares_ADRS_SUM = detail.ClaimShares_ADRS_SUM;

                ++count;
                ++this.statusInfo.recordNum;
            }
            reader.Close();

            this.statusInfo.additional_info_list.Add("Total BD_detailSum count=" + count);
        }

        private void Cal_ClaimShares_ADRS_pos(Dictionary<int, BD_Dividend> dic)
        {
            this.statusInfo.status = "Calculate ClaimShares_ADR positions";

            foreach (BD_Dividend dvd in dic.Values)
            {
                DTCPositionModelNumber_Mapping dm = DTC_model_master.GetMapping_modelNum(dvd.DTCPosition_ModelNumber);
                if (dm == null) continue;

                dm.Create_headers();
                List<DTC_Position_Headers> exempt_headerList = dm.Get_headersList("Exempt", null);
                List<DTC_Position_Headers> favorable_headerList = dm.Get_headersList("Favorable", null);
                List<DTC_Position_Headers> chargeBack_headerList = dm.Get_headersList("CHARGEBACK", "'NON-DISCLOSED");

                foreach (BD_DTC_Position bdp in dvd.bdp_dic.Values)
                {
                    bdp.ExemptPosition = bdp.GetSum_by_list(exempt_headerList);
                    bdp.FavorablePosition = bdp.GetSum_by_list(favorable_headerList);
                    bdp.ChargeBackPosition = bdp.GetSum_by_list(chargeBack_headerList);

                    bdp.RemainingTotalADRS = bdp.Total_RecDate_Position - bdp.ClaimShares_ADRS_SUM;

                    ++this.statusInfo.recordNum;
                }
            }
        }

        private DataTable Assign_values_DT(DataTable dt, Dictionary<int, BD_Dividend> dvd_dic)
        {
            this.statusInfo.status = "Assign_values_DT";

            if (dt == null || dvd_dic == null) return dt;

            foreach (BD_Dividend dvd in dvd_dic.Values)
            {
                foreach (BD_DTC_Position bdp in dvd.bdp_dic.Values)
                {
                    if (bdp.ClaimShares_ADRS_SUM <= 0) continue;

                    DataRow row = dt.Rows.Add();
                    row["DTC Position #"] = bdp.DTC_PositionID;
                    row["DTC"] = bdp.DTC_Number;
                    row["DTC#"] = bdp.DTC_Number;
                    row["DTC Model"] = dvd.DTCPosition_ModelNumber;
                    row["DTC Name"] = bdp.DTC_Name; ;
                    row["Dividend Index"] = dvd.DividendIndex;
                    row["Country"] = dvd.Country;
                    row["Issue"] = dvd.Issue;
                    row["CUSIP"] = dvd.CUSIP;

                    row["ADR Record Date"] = dvd.RecordDate_ADR.ToShortDateString();
                    row["ADR Pay Date"] = dvd.PayDate_ADR.ToShortDateString();
                    row["Final DIV Gross Amount"] = dvd.FinalDivGrossAmount_ADR;
                    row["Final DIV Gross Amount(ORD)"] = dvd.FinalDivGrossAmount_ORD;
                    row["Long Form Fee per DR"] = dvd.LongFormFee;
                    row["Statutory Rate"] = dvd.StatutoryRate;
                    row["Treaty Rate"] = 0;
                    row["Record Date Position(ADR)"] = bdp.Total_RecDate_Position;

                    row["Claimed on Total ADRS"] = bdp.ClaimShares_ADRS_SUM;
                    row["DTC FAV Position"] = bdp.FavorablePosition;
                    row["DTC Exempt Position"] = bdp.ExemptPosition;

                    row["Remaining Total ADRs"] = bdp.RemainingTotalADRS;
                    ++this.statusInfo.recordNum;
                }
            }

            return dt;
        }
    }
}
