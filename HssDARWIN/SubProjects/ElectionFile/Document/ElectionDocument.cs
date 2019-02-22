using System;
using System.Collections.Generic;
using System.Text;

using HssDARWIN.Models.Dividends;
using HssDARWIN.Models.Custodians;
using HssDARWIN.Models.DTC_Model;
using HssDARWIN.Models.DTC_Position;
using HssUtility.General;

namespace HssDARWIN.SubProjects.ElectionFile
{
    public partial class ElectionDocument
    {
        public readonly string AnnouncementName = "ElectionSheet", AnnouncementSender = "GlobeTax";
        public int AnnouncementIdentifier = 0;
        public DateTime AnnouncementDate = DateTime.Now;

        public readonly EventInfo_ele eventInfo = new EventInfo_ele();
        public Dictionary<decimal, Election_item> DTC_participant_dic = new Dictionary<decimal, Election_item>();//[WHRate] as key
        public Dictionary<decimal, Election_item> RSH_dic = new Dictionary<decimal, Election_item>();//[WHRate] as key
        public Dictionary<int, Custodian_ele> custodianEle_dic = new Dictionary<int, Custodian_ele>();//[CustodianID] int "Dividend_Custodian" table as key
        public Summary_ele summary = new Summary_ele();

        /// <summary>
        /// Default Dividend_Custodian for this election file. (Numbers only in the depository of this Dividend_Custodian)
        /// </summary>
        private DividendCustodian dvdCust = null;

        /*--------------------------------------------------------------------------------------------------------------------------*/

        public void Calculate(int custodianID)
        {
            this.dvdCust = new DividendCustodian(custodianID);
            if (!this.dvdCust.Init_from_DB()) return;

            Dividend dvd = new Dividend(this.dvdCust.DividendIndex.Value);
            if (!dvd.Init_from_DB(DividendTable_option.Dividend_Control_Approved)) return;

            this.dvdCus_dic_all = dvd.Get_dvdCust_dic(null);
            this.dvdCus_dic_custodianType = dvd.Get_dvdCust_dic("Custodian");

            //Get WithHolding Rate Set
            DTCPositionModelNumber_Mapping posMod = dvd.Get_DTCpos_model();
            if (posMod == null) return;

            Dictionary<decimal, List<DTC_Position_Headers>> whr_map = posMod.Get_WHRcol_mapping();
            HashSet<decimal> WHrate_hs = new HashSet<decimal>();
            foreach (decimal whr in whr_map.Keys) WHrate_hs.Add(whr);

            this.Cal_initAttr_eventInfo(dvd);//Init name attributes
            this.Cal_initAttr_collections(WHrate_hs, dvd);//Init all levels based on WithHolding Rate

            //Special 4 Countries
            HashSet<string> country_hs = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
            country_hs.Add("Finland"); country_hs.Add("Ireland");
            country_hs.Add("Norway"); country_hs.Add("France");

            if (country_hs.Contains(dvd.Country.Value)) this.Calculate_special_from_DTCposition(whr_map, dvd);
            else this.Calculate_commen_from_Detail(WHrate_hs, dvd);
        }

        public string GetXML()
        {
            StringBuilder sb = new StringBuilder("<?xml version=\"1.0\" encoding=\"UTF-8\"?>").Append(HssStr.WinNextLine);
            sb.Append("<ElectionDocument xmlns:myObj=\"urn:myObj\">").Append(HssStr.WinNextLine);
            sb.Append("<AnnouncementName>").Append(this.AnnouncementName).Append("</AnnouncementName>").Append(HssStr.WinNextLine);
            sb.Append("<AnnouncementSender>").Append(this.AnnouncementSender).Append("</AnnouncementSender>").Append(HssStr.WinNextLine);
            sb.Append("<AnnouncementIdentifier>").Append(this.AnnouncementIdentifier).Append("</AnnouncementIdentifier>").Append(HssStr.WinNextLine);
            sb.Append("<AnnouncementDate>").Append(this.AnnouncementDate.ToString("yyyy-MM-ddThh:mm:ss")).Append("</AnnouncementDate>").Append(HssStr.WinNextLine);

            sb.Append(this.eventInfo.GetXML());

            sb.Append("<DTC_PARTICIPANT_Election_INFORMATION>").Append(HssStr.WinNextLine);
            List<decimal> DTC_WHrate_list = new List<decimal>(this.DTC_participant_dic.Keys);
            DTC_WHrate_list.Sort();
            foreach (decimal key_rate in DTC_WHrate_list)
            {
                Election_item ei = this.DTC_participant_dic[key_rate];
                sb.Append(ei.GetXML());
            }
            sb.Append("</DTC_PARTICIPANT_Election_INFORMATION>").Append(HssStr.WinNextLine);

            sb.Append("<RSH_Election_INFORMATION>").Append(HssStr.WinNextLine);
            List<decimal> RSH_WHrate_list = new List<decimal>(this.RSH_dic.Keys);
            RSH_WHrate_list.Sort();
            foreach (decimal key_rate in RSH_WHrate_list)
            {
                Election_item ei = this.RSH_dic[key_rate];
                sb.Append(ei.GetXML());
            }
            sb.Append("</RSH_Election_INFORMATION>").Append(HssStr.WinNextLine);

            sb.Append("<CUSTODIAN_DETAILS>").Append(HssStr.WinNextLine);
            foreach (Custodian_ele ce in this.custodianEle_dic.Values) sb.Append(ce.GetXML());
            sb.Append("</CUSTODIAN_DETAILS>").Append(HssStr.WinNextLine);

            sb.Append(summary.GetXML());

            sb.Append("</ElectionDocument>").Append(HssStr.WinNextLine);
            return sb.ToString();
        }
    }
}
