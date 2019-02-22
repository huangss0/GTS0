using System;
using System.Collections.Generic;

using HssUtility.SQLserver;
using HssDARWIN.Models.DTC_Participant;
using HssDARWIN.Models.DTC_Position;

namespace HssDARWIN.SubProjects.Business_Development
{
    public class BD_DTC_Position
    {
        private static CmdTemplate DBcmd_TP = null;
        public static CmdTemplate Get_cmdTP()
        {
            if (BD_DTC_Position.DBcmd_TP != null) return BD_DTC_Position.DBcmd_TP;

            BD_DTC_Position.DBcmd_TP = new CmdTemplate();
            BD_DTC_Position.DBcmd_TP.tableName = "Dividend_DTC_Position";
            BD_DTC_Position.DBcmd_TP.AddColumn("DTC_PositionID");
            BD_DTC_Position.DBcmd_TP.AddColumn("DTC_Number");
            BD_DTC_Position.DBcmd_TP.AddColumn("DividendIndex");
            BD_DTC_Position.DBcmd_TP.AddColumn("Total_RecDate_Position");

            BD_DTC_Position.DBcmd_TP.AddColumn("Rate_Position_1");/*Optional 6*/
            BD_DTC_Position.DBcmd_TP.AddColumn("Rate_Position_2");/*Optional 7*/
            BD_DTC_Position.DBcmd_TP.AddColumn("Rate_Position_3");/*Optional 8*/
            BD_DTC_Position.DBcmd_TP.AddColumn("Rate_Position_4");/*Optional 9*/
            BD_DTC_Position.DBcmd_TP.AddColumn("Rate_Position_5");/*Optional 10*/
            BD_DTC_Position.DBcmd_TP.AddColumn("Rate_Position_6");/*Optional 11*/
            BD_DTC_Position.DBcmd_TP.AddColumn("Rate_Position_7");/*Optional 12*/
            BD_DTC_Position.DBcmd_TP.AddColumn("Rate_Position_8");/*Optional 13*/
            BD_DTC_Position.DBcmd_TP.AddColumn("Rate_Position_9");/*Optional 14*/
            BD_DTC_Position.DBcmd_TP.AddColumn("Rate_Position_10");/*Optional 15*/
            BD_DTC_Position.DBcmd_TP.AddColumn("Rate_Position_11");/*Optional 16*/
            BD_DTC_Position.DBcmd_TP.AddColumn("Rate_Position_12");/*Optional 17*/
            BD_DTC_Position.DBcmd_TP.AddColumn("Rate_Position_13");/*Optional 18*/
            BD_DTC_Position.DBcmd_TP.AddColumn("Rate_Position_14");/*Optional 19*/
            BD_DTC_Position.DBcmd_TP.AddColumn("Rate_Position_15");/*Optional 20*/
            BD_DTC_Position.DBcmd_TP.AddColumn("Rate_Position_16");/*Optional 21*/
            BD_DTC_Position.DBcmd_TP.AddColumn("Rate_Position_17");/*Optional 22*/
            BD_DTC_Position.DBcmd_TP.AddColumn("Rate_Position_18");/*Optional 23*/
            BD_DTC_Position.DBcmd_TP.AddColumn("Rate_Chargeback_1");/*Optional 24*/
            BD_DTC_Position.DBcmd_TP.AddColumn("Rate_Chargeback_2");/*Optional 25*/
            BD_DTC_Position.DBcmd_TP.AddColumn("Rate_Chargeback_3");/*Optional 26*/
            BD_DTC_Position.DBcmd_TP.AddColumn("Rate_Chargeback_4");/*Optional 27*/
            BD_DTC_Position.DBcmd_TP.AddColumn("Rate_Chargeback_5");/*Optional 28*/
            BD_DTC_Position.DBcmd_TP.AddColumn("Rate_Chargeback_6");/*Optional 29*/
            BD_DTC_Position.DBcmd_TP.AddColumn("Rate_Chargeback_7");/*Optional 30*/
            BD_DTC_Position.DBcmd_TP.AddColumn("Rate_Chargeback_8");/*Optional 31*/
            BD_DTC_Position.DBcmd_TP.AddColumn("Rate_Chargeback_9");/*Optional 32*/
            BD_DTC_Position.DBcmd_TP.AddColumn("Rate_Chargeback_10");/*Optional 33*/
            BD_DTC_Position.DBcmd_TP.AddColumn("Rate_Chargeback_11");/*Optional 34*/
            BD_DTC_Position.DBcmd_TP.AddColumn("Rate_Chargeback_12");/*Optional 35*/
            BD_DTC_Position.DBcmd_TP.AddColumn("Rate_Chargeback_13");/*Optional 36*/
            BD_DTC_Position.DBcmd_TP.AddColumn("Rate_Chargeback_14");/*Optional 37*/
            BD_DTC_Position.DBcmd_TP.AddColumn("Rate_Chargeback_15");/*Optional 38*/
            BD_DTC_Position.DBcmd_TP.AddColumn("Rate_Chargeback_16");/*Optional 39*/
            BD_DTC_Position.DBcmd_TP.AddColumn("Rate_Chargeback_17");/*Optional 40*/
            BD_DTC_Position.DBcmd_TP.AddColumn("Rate_Chargeback_18");/*Optional 41*/
            BD_DTC_Position.DBcmd_TP.AddColumn("Exempt1");/*Optional 42*/
            BD_DTC_Position.DBcmd_TP.AddColumn("Exempt2");/*Optional 43*/
            BD_DTC_Position.DBcmd_TP.AddColumn("Exempt3");/*Optional 44*/
            BD_DTC_Position.DBcmd_TP.AddColumn("Exempt4");/*Optional 45*/
            BD_DTC_Position.DBcmd_TP.AddColumn("Exempt5");/*Optional 46*/

            return BD_DTC_Position.DBcmd_TP;
        }

        public int DTC_PositionID = -1;
        public string DTC_Number = null;
        public int DividendIndex = -1;
        public decimal Total_RecDate_Position = 0;

        private Dictionary<string, decimal> values_dic = new Dictionary<string, decimal>(StringComparer.OrdinalIgnoreCase);

        public void Init_from_reader(DB_reader reader)
        {
            if (reader == null || reader.IsClosed) return;

            this.DTC_PositionID = reader.GetInt("DTC_PositionID");
            this.DTC_Number = reader.GetString("DTC_Number");
            this.DividendIndex = reader.GetInt("DividendIndex");
            this.Total_RecDate_Position = reader.GetDecimal("Total_RecDate_Position");

            for (int i = 1; i <= 18; ++i)
            {
                string colName = "Rate_Position_" + i;
                decimal val = reader.GetDecimal(colName, 0);
                if(val > 0) this.values_dic[colName] = val;
            }
            for (int i = 1; i <= 18; ++i)
            {
                string colName = "Rate_Chargeback_" + i;
                decimal val = reader.GetDecimal(colName, 0);
                if (val > 0) this.values_dic[colName] = val;
            }
            for (int i = 1; i <= 5; ++i)
            {
                string colName = "Exempt" + i;
                decimal val = reader.GetDecimal(colName, 0);
                if (val > 0) this.values_dic[colName] = val;
            }
        }

        /*----------------------------------------------------------------------------------------------------------------------*/

        public decimal ClaimShares_ADRS_SUM = 0;//values from [Dividend_Detail]
        public decimal ExemptPosition = 0, FavorablePosition = 0, ChargeBackPosition = 0;
        public decimal RemainingTotalADRS = 0;

        public DTC_Participants dtcParti = null;
        public string DTC_Name { get { return this.dtcParti == null ? null : this.dtcParti.Company_Name.Value; } }

        /************************************************************************************************************************/

        public decimal GetValue_by_colName(string colName)
        {
            if (string.IsNullOrEmpty(colName)) return 0;

            if (this.values_dic.ContainsKey(colName)) return this.values_dic[colName];
            else return 0;
        }

        public decimal GetSum_by_list(List<DTC_Position_Headers> header_list)
        {
            decimal sum = 0;

            foreach (DTC_Position_Headers dph in header_list)
            {
                if (dph == null) continue;
                sum += this.GetValue_by_colName(dph.Table_Column.Value);
            }

            return sum;
        }
    }
}
