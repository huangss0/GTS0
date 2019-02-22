using System;
using System.Text;

using HssUtility.General;

namespace HssDARWIN.SubProjects.ElectionFile
{
    public class EventInfo_ele
    {
        public string UniqueUniversalEventIdentifier = "";//XBRL
        public string SECURITY_IDENTIFIER_CUSIP = "";
        public string ISSUER_NAME = "";
        public DateTime ADR_RECORD_DATE = DateTime.MinValue;

        public decimal ADRBase = -2, OrdinaryShare = -3;

        public string GetXML()
        {
            StringBuilder sb = new StringBuilder("<EVENT_INFORMATION>").Append(HssStr.WinNextLine);

            sb.Append("<UniqueUniversalEventIdentifier>").Append(this.UniqueUniversalEventIdentifier).Append("</UniqueUniversalEventIdentifier>").Append(HssStr.WinNextLine);
            sb.Append("<SECURITY_IDENTIFIER_CUSIP>").Append(this.SECURITY_IDENTIFIER_CUSIP).Append("</SECURITY_IDENTIFIER_CUSIP>").Append(HssStr.WinNextLine);
            sb.Append("<ISSUER_NAME>").Append(HssStr.ToSafeXML_str(this.ISSUER_NAME)).Append("</ISSUER_NAME>").Append(HssStr.WinNextLine);
            sb.Append("<ADR_RECORD_DATE>").Append(this.ADR_RECORD_DATE.ToString("yyyy-MM-dd")).Append("</ADR_RECORD_DATE>").Append(HssStr.WinNextLine);

            sb.Append("<RATIO>").Append(HssStr.WinNextLine);
            sb.Append("<ADRBase>").Append((int)this.ADRBase).Append("</ADRBase>").Append(HssStr.WinNextLine);
            sb.Append("<OrdinaryShare>").Append((int)this.OrdinaryShare).Append("</OrdinaryShare>").Append(HssStr.WinNextLine);
            sb.Append("</RATIO>").Append(HssStr.WinNextLine);

            sb.Append("</EVENT_INFORMATION>").Append(HssStr.WinNextLine);
            return sb.ToString();
        }
    }
}
