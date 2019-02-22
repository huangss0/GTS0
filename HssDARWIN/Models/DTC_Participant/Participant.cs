using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HssUtility.SQLserver;

namespace HssDARWIN.Models.DTC_Participant
{
    public class Participant
    {
        public int DTC { get { return this.curr_DCT; } }//Primary Key
        private int curr_DCT = -1;
        public string DCT_Number = "", Company_Name = "", Type = "";

        public static CmdTemplate DBcmd_TP = null;
        public static void Init_cmdTP()
        {
            if (Participant.DBcmd_TP != null) return;

            Participant.DBcmd_TP = new CmdTemplate();
            Participant.DBcmd_TP.tableName = "DTC_Participants";

            Participant.DBcmd_TP.AddColumn("DTC");
            Participant.DBcmd_TP.AddColumn("DTC_Number");
            Participant.DBcmd_TP.AddColumn("Company_Name");
            Participant.DBcmd_TP.AddColumn("Type");
        }

        internal void Init_from_reader(DB_reader reader)
        {
            if (reader == null || reader.IsClosed) return;

            this.curr_DCT = reader.GetInt("DTC");
            this.DCT_Number = reader.GetString("DTC_Number");
            this.Company_Name = reader.GetString("Company_Name");
            this.Type = reader.GetString("Type");
        }
    }
}
