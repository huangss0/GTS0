using System.Text;
using System.Collections.Generic;

using HssUtility.General;

namespace HssDARWIN.SubProjects.ElectionFile
{
    public class Summary_ele
    {
        public Dictionary<decimal, Election_item> totalEle_dic = new Dictionary<decimal, Election_item>();//[WHRate] as key
        public decimal PRE_RELEASE_TOTAL = 0, WORKING_SUPPLY_TOTAL = 0;

        //public decimal DTC_participant_total = 0, RSH_total = 0;

        public string GetXML()
        {
            StringBuilder sb = new StringBuilder("<SUMMARY>").Append(HssStr.WinNextLine);

            sb.Append("<TOTAL_ELECTION_INFORMATION>").Append(HssStr.WinNextLine);
            List<decimal> WHrate_list = new List<decimal>(this.totalEle_dic.Keys);
            WHrate_list.Sort();
            foreach (decimal key_rate in WHrate_list)
            {
                Election_item ei = this.totalEle_dic[key_rate];
                sb.Append(ei.GetXML());
            }
            sb.Append("</TOTAL_ELECTION_INFORMATION>").Append(HssStr.WinNextLine);

            sb.Append("<PRE_RELEASE_TOTAL>").Append((int)this.PRE_RELEASE_TOTAL).Append("</PRE_RELEASE_TOTAL>").Append(HssStr.WinNextLine);
            sb.Append("<WORKING_SUPPLY_TOTAL>").Append((int)this.WORKING_SUPPLY_TOTAL).Append("</WORKING_SUPPLY_TOTAL>").Append(HssStr.WinNextLine);

            sb.Append("</SUMMARY>").Append(HssStr.WinNextLine);
            return sb.ToString();
        }
    }
}
