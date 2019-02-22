using HssUtility.SQLserver;

namespace HssDARWIN.Models.Election
{
    public class DividendElectionOption
    {
        public static CmdTemplate DBcmd_TP = null;
        public static void Init_cmdTP()
        {
            if (DividendElectionOption.DBcmd_TP != null) return;

            DividendElectionOption.DBcmd_TP = new CmdTemplate();
            DBcmd_TP.tableName = "Dividend_Election_Option";

            DividendElectionOption.DBcmd_TP.AddColumn("Dividend_OptionID");
            DividendElectionOption.DBcmd_TP.AddColumn("DividendIndex");
            DividendElectionOption.DBcmd_TP.AddColumn("OptionNumber");
            DividendElectionOption.DBcmd_TP.AddColumn("Sender");
            DividendElectionOption.DBcmd_TP.AddColumn("OptionActionType");
        }

        public int Dividend_OptionID = -6;//Primary Key
        public int DividendIndex = -7, OptionNumber = -8;
        public string Sender = "", OptionActionType = "CASH";

        internal void Init_from_reader(DB_reader reader)
        {
            if (reader == null || reader.IsClosed) return;

            this.Dividend_OptionID = reader.GetInt("Dividend_OptionID");
            this.DividendIndex = reader.GetInt("DividendIndex");
            this.OptionNumber = reader.GetInt("OptionNumber");
            this.Sender = reader.GetString("Sender");
            this.OptionActionType = reader.GetString("OptionActionType");
        }
    }
}
