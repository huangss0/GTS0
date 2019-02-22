using System.Text;

using HssUtility.General;
using HssDARWIN.Models.Depositaries;

namespace HssDARWIN.Models.Dividends
{
    public partial class Dividend
    {
        public HssStatus GetStatus() { return Helper_hssStatus.Str_to_Status(this.Status.Value); }
        public void SetStatus(HssStatus st) { this.Status.Value = st.ToString(); }

        public string Create_dividendID(int dvdID_offset = 0)
        {
            if (dvdID_offset > 49 || dvdID_offset < 0) dvdID_offset = 0;//only support offset range 0 ~ 49 for now

            Depositary depo = null;

            int sponserID = 99;
            string depoID = "00";

            if (this.Sponsored.Value)
            {
                sponserID = 0 + dvdID_offset;
                depo = DepositaryMaster.GetDepositary_by_name(this.Depositary.Value);
            }
            else
            {
                sponserID -= dvdID_offset;
                depo = DepositaryMaster.GetDepositary_by_name(Depositaries.Depositary.Unsponsored);
            }

            if (depo != null) depoID = depo.DepositaryID.Value;

            StringBuilder dvdID_sb = new StringBuilder();
            dvdID_sb.Append(HssStr.Trim_to_size(sponserID, 2));//sponsered or not
            dvdID_sb.Append(HssStr.Trim_to_size(depoID, 2));
            dvdID_sb.Append(HssStr.Trim_to_size(this.CUSIP.Value, 9));
            dvdID_sb.Append(this.RecordDate_ADR.Value.ToString("MMddyyyy"));
            dvdID_sb.Append(HssStr.Trim_to_size(this.IncomeEventID.Value, 2, '0'));

            return dvdID_sb.ToString();
        }
    }
}
