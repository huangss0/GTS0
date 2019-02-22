using System;
using HssUtility.SQLserver;

namespace HssDARWIN.Models.DTC_Position
{
    public class Position
    {
        public int DTC_PositionID = -1;
        public int DividendIndex = -28414;

        public string DTC_Number = "-1", Company_Name = "Default:hssCompany";
        public int CustodianID = -1;
        public decimal Total_RecDate_Position = 0;

        public Rates RatePositions { get { return this.curr_ratePos; } }
        private Rates DB_ratePos = new Rates(), curr_ratePos = new Rates();

        public Rates Rate_Chargebacks { get { return this.curr_rateCharges; } }
        private Rates DB_rateCharges = new Rates(), curr_rateCharges = new Rates();

        public decimal[] Exampts = new decimal[6];

        public DateTime ModifiedDateTime = DateTime.Now;
        public string LastModifiedBy = Utility.CurrentUser;

        public Position()
        {
            Position.Init_cmdTP();
        }

        public static CmdTemplate DBcmd_TP = null;
        public static void Init_cmdTP()
        {
            if (Position.DBcmd_TP != null) return;

            Position.DBcmd_TP = new CmdTemplate();
            Position.DBcmd_TP.tableName = "Dividend_DTC_Position";

            Position.DBcmd_TP.AddColumn("DividendIndex");
            Position.DBcmd_TP.AddColumn("DTC_Number");
            Position.DBcmd_TP.AddColumn("Company_Name");
            Position.DBcmd_TP.AddColumn("Total_RecDate_Position");
            Position.DBcmd_TP.AddColumn("CustodianID");

            Position.DBcmd_TP.AddColumn("ModifiedDateTime");
            Position.DBcmd_TP.AddColumn("LastModifiedBy");

            Position.DBcmd_TP.AddColumn("Rate_Position_1");
            Position.DBcmd_TP.AddColumn("Rate_Position_2");
            Position.DBcmd_TP.AddColumn("Rate_Position_3");
            Position.DBcmd_TP.AddColumn("Rate_Position_4");
            Position.DBcmd_TP.AddColumn("Rate_Position_5");
            Position.DBcmd_TP.AddColumn("Rate_Position_6");
            Position.DBcmd_TP.AddColumn("Rate_Position_7");
            Position.DBcmd_TP.AddColumn("Rate_Position_8");
            Position.DBcmd_TP.AddColumn("Rate_Position_9");
            Position.DBcmd_TP.AddColumn("Rate_Position_10");
            Position.DBcmd_TP.AddColumn("Rate_Position_11");
            Position.DBcmd_TP.AddColumn("Rate_Position_12");
            Position.DBcmd_TP.AddColumn("Rate_Position_13");
            Position.DBcmd_TP.AddColumn("Rate_Position_14");
            Position.DBcmd_TP.AddColumn("Rate_Position_15");
            Position.DBcmd_TP.AddColumn("Rate_Position_16");
            Position.DBcmd_TP.AddColumn("Rate_Position_17");
            Position.DBcmd_TP.AddColumn("Rate_Position_18");

            Position.DBcmd_TP.AddColumn("Rate_Chargeback_1");
            Position.DBcmd_TP.AddColumn("Rate_Chargeback_2");
            Position.DBcmd_TP.AddColumn("Rate_Chargeback_3");
            Position.DBcmd_TP.AddColumn("Rate_Chargeback_4");
            Position.DBcmd_TP.AddColumn("Rate_Chargeback_5");
            Position.DBcmd_TP.AddColumn("Rate_Chargeback_6");
            Position.DBcmd_TP.AddColumn("Rate_Chargeback_7");
            Position.DBcmd_TP.AddColumn("Rate_Chargeback_8");
            Position.DBcmd_TP.AddColumn("Rate_Chargeback_9");
            Position.DBcmd_TP.AddColumn("Rate_Chargeback_10");
            Position.DBcmd_TP.AddColumn("Rate_Chargeback_11");
            Position.DBcmd_TP.AddColumn("Rate_Chargeback_12");
            Position.DBcmd_TP.AddColumn("Rate_Chargeback_13");
            Position.DBcmd_TP.AddColumn("Rate_Chargeback_14");
            Position.DBcmd_TP.AddColumn("Rate_Chargeback_15");
            Position.DBcmd_TP.AddColumn("Rate_Chargeback_16");
            Position.DBcmd_TP.AddColumn("Rate_Chargeback_17");
            Position.DBcmd_TP.AddColumn("Rate_Chargeback_18");

            Position.DBcmd_TP.AddColumn("Exempt1");
            Position.DBcmd_TP.AddColumn("Exempt2");
            Position.DBcmd_TP.AddColumn("Exempt3");
            Position.DBcmd_TP.AddColumn("Exempt4");
            Position.DBcmd_TP.AddColumn("Exempt5");
        }        

        internal void Init_from_reader(DB_reader reader)
        {
            if (reader == null || reader.IsClosed) return;

            this.DividendIndex = reader.GetInt("DividendIndex");
            this.DTC_Number = reader.GetString("DTC_Number");
            this.Company_Name = reader.GetString("Company_Name");
            this.Total_RecDate_Position = reader.GetDecimal("Total_RecDate_Position");
            this.CustodianID = reader.GetInt("CustodianID");

            for (int i = 1; i <= Rates.RateCount; ++i)
            {
                this.curr_ratePos[i] = reader.GetDecimal("Rate_Position_" + i);
                this.DB_ratePos[i] = this.curr_ratePos[i];

                this.curr_rateCharges[i] = reader.GetDecimal("Rate_Chargeback_" + i);
                this.DB_rateCharges[i] = this.curr_rateCharges[i];
            }

            for (int i = 1; i <= 5; ++i) this.Exampts[i] = reader.GetDecimal("Exempt" + i);
        }

        public bool SaveToDB()
        {
            hssDB hDB = Utility.Get_DRWIN_hDB();
            if (hDB == null) return false;

            DB_insert dbIns = this.Get_DBinsert();
            dbIns.DBname = hDB.DBname;
            int count = dbIns.SaveToDB(hDB);

            return count > 0;
        }

        public bool RatePos_changed(int index)
        {
            if (index < 1 || index >= Rates.RateCount) return false;
            decimal d1 = this.DB_ratePos[index], d2 = this.curr_ratePos[index];
            return d1 != d2;
        }

        public bool RateCharges_changed(int index)
        {
            if (index < 1 || index >= Rates.RateCount) return false;
            decimal d1 = this.DB_rateCharges[index], d2 = this.curr_rateCharges[index];
            return d1 != d2;
        }

        internal DB_insert Get_DBinsert()
        {
            DB_insert dbIns = new DB_insert(Position.DBcmd_TP);
            dbIns.AddValue("DividendIndex", this.DividendIndex);
            dbIns.AddValue("DTC_Number", this.DTC_Number);
            dbIns.AddValue("Company_Name", this.Company_Name);
            dbIns.AddValue("Total_RecDate_Position", this.Total_RecDate_Position);

            dbIns.AddValue("ModifiedDateTime", this.ModifiedDateTime);
            dbIns.AddValue("LastModifiedBy", this.LastModifiedBy);

            for (int i = 1; i <= Rates.RateCount; ++i)
            {
                if (this.RatePos_changed(i)) dbIns.AddValue("Rate_Position_" + i, this.RatePositions[i]);
                if (this.RateCharges_changed(i)) dbIns.AddValue("Rate_Chargeback_" + i, this.Rate_Chargebacks[i]);
            }

            return dbIns;
        }

        public void SyncWithDB()
        {
            for (int i = 1; i <= Rates.RateCount; ++i)
            {
                this.DB_ratePos[i] = this.curr_ratePos[i];
                this.DB_rateCharges[i] = this.curr_rateCharges[i];
            }
        }
    }
}
