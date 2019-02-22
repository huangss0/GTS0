using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HssUtility.General
{
    public enum HssStatus
    {
        None = -1,

        Pending = 0,
        Approved = 1,
        Rejected = 2,

        Normal = 3,
        Suspend = 4,

        Active = 5,
        Cancel = 6,
    }

    public class Helper_hssStatus
    {
        private static Dictionary<int, HssStatus> int_dic = null;
        private static Dictionary<string, HssStatus> str_dic = null;

        private static void Init()
        {
            if (Helper_hssStatus.int_dic == null)
            {
                Helper_hssStatus.int_dic = new Dictionary<int, HssStatus>();
                Helper_hssStatus.int_dic[0] = HssStatus.Pending;
                Helper_hssStatus.int_dic[1] = HssStatus.Approved;
                Helper_hssStatus.int_dic[2] = HssStatus.Rejected;
                Helper_hssStatus.int_dic[3] = HssStatus.Normal;
                Helper_hssStatus.int_dic[4] = HssStatus.Suspend;
                Helper_hssStatus.int_dic[5] = HssStatus.Active;
                Helper_hssStatus.int_dic[6] = HssStatus.Cancel;
            }

            if (Helper_hssStatus.str_dic == null)
            {
                Helper_hssStatus.str_dic = new Dictionary<string, HssStatus>(StringComparer.OrdinalIgnoreCase);

                Helper_hssStatus.str_dic["Pending"] = HssStatus.Pending;

                Helper_hssStatus.str_dic["Approved"] = HssStatus.Approved;
                Helper_hssStatus.str_dic["Approve"] = HssStatus.Approved;

                Helper_hssStatus.str_dic["Rejected"] = HssStatus.Rejected;
                Helper_hssStatus.str_dic["Reject"] = HssStatus.Rejected;

                Helper_hssStatus.str_dic["Active"] = HssStatus.Active;

                Helper_hssStatus.str_dic["Normal"] = HssStatus.Normal;

                Helper_hssStatus.str_dic["Suspend"] = HssStatus.Suspend;
                Helper_hssStatus.str_dic["Suspended"] = HssStatus.Suspend;

                Helper_hssStatus.str_dic["Cancel"] = HssStatus.Cancel;
                Helper_hssStatus.str_dic["Cancellation"] = HssStatus.Cancel;
            }
        }

        public static HssStatus Int_to_Status(int val)
        {
            Helper_hssStatus.Init();

            if (!Helper_hssStatus.int_dic.ContainsKey(val)) return HssStatus.None;
            else return Helper_hssStatus.int_dic[val];
        }

        public static HssStatus Str_to_Status(string s)
        {
            Helper_hssStatus.Init();

            if (string.IsNullOrEmpty(s)) return HssStatus.None;
            s = s.Trim();

            if (Helper_hssStatus.str_dic.ContainsKey(s)) return Helper_hssStatus.str_dic[s];
            else return HssStatus.None;//more work may be needed in the future
        }
    }
}
