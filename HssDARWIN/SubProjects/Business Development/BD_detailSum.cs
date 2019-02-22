using System;

using HssUtility.SQLserver;

namespace HssDARWIN.SubProjects.Business_Development
{
    public class BD_detailSum
    {
        private static CmdTemplate DBcmd_TP = null;
        public static CmdTemplate Get_cmdTP()
        {
            if (BD_detailSum.DBcmd_TP != null) return BD_detailSum.DBcmd_TP;

            BD_detailSum.DBcmd_TP = new CmdTemplate();
            BD_detailSum.DBcmd_TP.tableName = "Dividend_Detail";

            BD_detailSum.DBcmd_TP.AddColumn("DTC_Number");
            BD_detailSum.DBcmd_TP.AddColumn("DividendIndex");
            BD_detailSum.DBcmd_TP.AddColumn("RecordDatePosition", AggregateFunction.Sum, "ClaimShares_ADRS_SUM");

            return BD_detailSum.DBcmd_TP;
        }

        public string DTC_Number = null;
        public int DividendIndex = -1;
        public decimal ClaimShares_ADRS_SUM = 0;

        public void Init_from_reader(DB_reader reader)
        {
            if (reader == null || reader.IsClosed) return;

            this.DTC_Number = reader.GetString("DTC_Number");
            this.DividendIndex = reader.GetInt("DividendIndex");
            this.ClaimShares_ADRS_SUM = reader.GetDecimal("ClaimShares_ADRS_SUM");
        }
    }
}
