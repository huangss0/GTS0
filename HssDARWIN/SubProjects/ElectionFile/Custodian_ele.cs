using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HssUtility.General;

namespace HssDARWIN.SubProjects.ElectionFile
{
    public class Custodian_ele
    {
        public int ID = 1;
        public string CUSTODIAN_REFERENCE = "", CUSTODIAN_NAME = "";
        public Dictionary<decimal, Election_item> cust_dic = new Dictionary<decimal, Election_item>();//[WHRate] as key
        
        public string GetXML()
        {
            StringBuilder sb = new StringBuilder("<CUSTODIAN_ELECTION ID=\"" + this.ID + "\">").Append(HssStr.WinNextLine);

            sb.Append("<CUSTODIAN_REFERENCE>").Append(this.CUSTODIAN_REFERENCE).Append("</CUSTODIAN_REFERENCE>").Append(HssStr.WinNextLine);
            sb.Append("<CUSTODIAN_NAME>").Append(this.CUSTODIAN_NAME).Append("</CUSTODIAN_NAME>").Append(HssStr.WinNextLine);

            List<decimal> WHrate_list = new List<decimal>(this.cust_dic.Keys);
            WHrate_list.Sort();
            foreach (decimal key_rate in WHrate_list)
            {
                Election_item ei = this.cust_dic[key_rate];
                sb.Append(ei.GetXML());
            }

            sb.Append("</CUSTODIAN_ELECTION>");
            return sb.ToString();
        }
    }
}
