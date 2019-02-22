using System;
using System.Collections.Generic;

using HssUtility.SQLserver;

namespace HssDARWIN.SubProjects.Business_Development
{
    public class BD_Dividend
    {
        private static CmdTemplate DBcmd_TP = null;
        public static CmdTemplate Get_cmdTP()
        {
            if (BD_Dividend.DBcmd_TP != null) return BD_Dividend.DBcmd_TP;

            BD_Dividend.DBcmd_TP = new CmdTemplate();
            BD_Dividend.DBcmd_TP.tableName = "Dividend_Control_Approved";

            BD_Dividend.DBcmd_TP.AddColumn("DividendIndex");
            BD_Dividend.DBcmd_TP.AddColumn("Issue");
            BD_Dividend.DBcmd_TP.AddColumn("Country");
            BD_Dividend.DBcmd_TP.AddColumn("CUSIP");
            BD_Dividend.DBcmd_TP.AddColumn("DTCPosition_ModelNumber");

            BD_Dividend.DBcmd_TP.AddColumn("RecordDate_ADR");
            BD_Dividend.DBcmd_TP.AddColumn("PayDate_ADR");
            BD_Dividend.DBcmd_TP.AddColumn("PayDate_ORD");

            BD_Dividend.DBcmd_TP.AddColumn("FinalDivGrossAmount_ORD");
            BD_Dividend.DBcmd_TP.AddColumn("FinalDivGrossAmount_ADR");
            BD_Dividend.DBcmd_TP.AddColumn("LongFormFee");
            BD_Dividend.DBcmd_TP.AddColumn("StatutoryRate");

            return BD_Dividend.DBcmd_TP;
        }

        public int DividendIndex = -1;
        public string Issue = null;
        public string Country = null;
        public string CUSIP = null;
        public int DTCPosition_ModelNumber = 0;

        public DateTime RecordDate_ADR, PayDate_ADR, PayDate_ORD;
        public decimal FinalDivGrossAmount_ORD = 0;
        public decimal FinalDivGrossAmount_ADR = 0;
        public decimal LongFormFee = 0;
        public decimal StatutoryRate = 0;

        //DTC_number as key
        public Dictionary<string, BD_DTC_Position> bdp_dic = new Dictionary<string, BD_DTC_Position>(StringComparer.OrdinalIgnoreCase);

        public void Init_from_reader(DB_reader reader)
        {
            if (reader == null || reader.IsClosed) return;

            this.DividendIndex = reader.GetInt("DividendIndex");
            this.Issue = reader.GetString("Issue");
            this.Country = reader.GetString("Country");
            this.CUSIP = reader.GetString("CUSIP");
            this.DTCPosition_ModelNumber = reader.GetInt("DTCPosition_ModelNumber");

            this.RecordDate_ADR = reader.GetDateTime("RecordDate_ADR", Utility.MinDate);
            this.PayDate_ADR = reader.GetDateTime("PayDate_ADR", Utility.MinDate);
            this.PayDate_ORD = reader.GetDateTime("PayDate_ORD", Utility.MinDate);

            this.FinalDivGrossAmount_ORD = reader.GetDecimal("FinalDivGrossAmount_ORD");
            this.FinalDivGrossAmount_ADR = reader.GetDecimal("FinalDivGrossAmount_ADR");
            this.LongFormFee = reader.GetDecimal("LongFormFee");
            this.StatutoryRate = reader.GetDecimal("StatutoryRate");
        }
    }
}
