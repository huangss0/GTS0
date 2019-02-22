using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HssDARWIN.Models.DTC_Position
{
    public class Dividend_DTC_Position
    {
        /*-----------------------------Hss Entity Framework Auto Generated Code-------------------------------*/
        private static HssUtility.SQLserver.CmdTemplate DBcmd_TP = null;
        public static HssUtility.SQLserver.CmdTemplate Get_cmdTP()
        {
            if (Dividend_DTC_Position.DBcmd_TP != null) return Dividend_DTC_Position.DBcmd_TP;

            Dividend_DTC_Position.DBcmd_TP = new HssUtility.SQLserver.CmdTemplate();
            Dividend_DTC_Position.DBcmd_TP.tableName = "Dividend_DTC_Position";
            Dividend_DTC_Position.DBcmd_TP.schema = "dbo";

            Dividend_DTC_Position.DBcmd_TP.AddColumn("DTC_PositionID");
            Dividend_DTC_Position.DBcmd_TP.AddColumn("DividendIndex");
            Dividend_DTC_Position.DBcmd_TP.AddColumn("DTC_Number");
            Dividend_DTC_Position.DBcmd_TP.AddColumn("Company_Name");/*Optional 4*/
            Dividend_DTC_Position.DBcmd_TP.AddColumn("Total_RecDate_Position");/*Optional 5*/
            Dividend_DTC_Position.DBcmd_TP.AddColumn("Rate_Position_1");/*Optional 6*/
            Dividend_DTC_Position.DBcmd_TP.AddColumn("Rate_Position_2");/*Optional 7*/
            Dividend_DTC_Position.DBcmd_TP.AddColumn("Rate_Position_3");/*Optional 8*/
            Dividend_DTC_Position.DBcmd_TP.AddColumn("Rate_Position_4");/*Optional 9*/
            Dividend_DTC_Position.DBcmd_TP.AddColumn("Rate_Position_5");/*Optional 10*/
            Dividend_DTC_Position.DBcmd_TP.AddColumn("Rate_Position_6");/*Optional 11*/
            Dividend_DTC_Position.DBcmd_TP.AddColumn("Rate_Position_7");/*Optional 12*/
            Dividend_DTC_Position.DBcmd_TP.AddColumn("Rate_Position_8");/*Optional 13*/
            Dividend_DTC_Position.DBcmd_TP.AddColumn("Rate_Position_9");/*Optional 14*/
            Dividend_DTC_Position.DBcmd_TP.AddColumn("Rate_Position_10");/*Optional 15*/
            Dividend_DTC_Position.DBcmd_TP.AddColumn("Rate_Position_11");/*Optional 16*/
            Dividend_DTC_Position.DBcmd_TP.AddColumn("Rate_Position_12");/*Optional 17*/
            Dividend_DTC_Position.DBcmd_TP.AddColumn("Rate_Position_13");/*Optional 18*/
            Dividend_DTC_Position.DBcmd_TP.AddColumn("Rate_Position_14");/*Optional 19*/
            Dividend_DTC_Position.DBcmd_TP.AddColumn("Rate_Position_15");/*Optional 20*/
            Dividend_DTC_Position.DBcmd_TP.AddColumn("Rate_Position_16");/*Optional 21*/
            Dividend_DTC_Position.DBcmd_TP.AddColumn("Rate_Position_17");/*Optional 22*/
            Dividend_DTC_Position.DBcmd_TP.AddColumn("Rate_Position_18");/*Optional 23*/
            Dividend_DTC_Position.DBcmd_TP.AddColumn("Rate_Chargeback_1");/*Optional 24*/
            Dividend_DTC_Position.DBcmd_TP.AddColumn("Rate_Chargeback_2");/*Optional 25*/
            Dividend_DTC_Position.DBcmd_TP.AddColumn("Rate_Chargeback_3");/*Optional 26*/
            Dividend_DTC_Position.DBcmd_TP.AddColumn("Rate_Chargeback_4");/*Optional 27*/
            Dividend_DTC_Position.DBcmd_TP.AddColumn("Rate_Chargeback_5");/*Optional 28*/
            Dividend_DTC_Position.DBcmd_TP.AddColumn("Rate_Chargeback_6");/*Optional 29*/
            Dividend_DTC_Position.DBcmd_TP.AddColumn("Rate_Chargeback_7");/*Optional 30*/
            Dividend_DTC_Position.DBcmd_TP.AddColumn("Rate_Chargeback_8");/*Optional 31*/
            Dividend_DTC_Position.DBcmd_TP.AddColumn("Rate_Chargeback_9");/*Optional 32*/
            Dividend_DTC_Position.DBcmd_TP.AddColumn("Rate_Chargeback_10");/*Optional 33*/
            Dividend_DTC_Position.DBcmd_TP.AddColumn("Rate_Chargeback_11");/*Optional 34*/
            Dividend_DTC_Position.DBcmd_TP.AddColumn("Rate_Chargeback_12");/*Optional 35*/
            Dividend_DTC_Position.DBcmd_TP.AddColumn("Rate_Chargeback_13");/*Optional 36*/
            Dividend_DTC_Position.DBcmd_TP.AddColumn("Rate_Chargeback_14");/*Optional 37*/
            Dividend_DTC_Position.DBcmd_TP.AddColumn("Rate_Chargeback_15");/*Optional 38*/
            Dividend_DTC_Position.DBcmd_TP.AddColumn("Rate_Chargeback_16");/*Optional 39*/
            Dividend_DTC_Position.DBcmd_TP.AddColumn("Rate_Chargeback_17");/*Optional 40*/
            Dividend_DTC_Position.DBcmd_TP.AddColumn("Rate_Chargeback_18");/*Optional 41*/
            Dividend_DTC_Position.DBcmd_TP.AddColumn("Exempt1");/*Optional 42*/
            Dividend_DTC_Position.DBcmd_TP.AddColumn("Exempt2");/*Optional 43*/
            Dividend_DTC_Position.DBcmd_TP.AddColumn("Exempt3");/*Optional 44*/
            Dividend_DTC_Position.DBcmd_TP.AddColumn("Exempt4");/*Optional 45*/
            Dividend_DTC_Position.DBcmd_TP.AddColumn("Exempt5");/*Optional 46*/
            Dividend_DTC_Position.DBcmd_TP.AddColumn("LastModifiedBy");/*Optional 47*/
            Dividend_DTC_Position.DBcmd_TP.AddColumn("ModifiedDateTime");/*Optional 48*/
            Dividend_DTC_Position.DBcmd_TP.AddColumn("CustodianID");/*Optional 49*/
            Dividend_DTC_Position.DBcmd_TP.AddColumn("ChargeBackFX");/*Optional 50*/
            Dividend_DTC_Position.DBcmd_TP.AddColumn("ClientBookNumber");/*Optional 51*/

            return Dividend_DTC_Position.DBcmd_TP;
        }

        public Dividend_DTC_Position() { }
        public Dividend_DTC_Position(int id) { this.pk_ID = id; }

        private int pk_ID = -1; //primary key
        public int DTC_PositionID { get { return this.pk_ID; } }

        public readonly HssUtility.General.Attributes.Int_attr DividendIndex = new HssUtility.General.Attributes.Int_attr();
        public readonly HssUtility.General.Attributes.String_attr DTC_Number = new HssUtility.General.Attributes.String_attr();
        public readonly HssUtility.General.Attributes.String_attr Company_Name = new HssUtility.General.Attributes.String_attr();/*Optional 4*/
        public readonly HssUtility.General.Attributes.Decimal_attr Total_RecDate_Position = new HssUtility.General.Attributes.Decimal_attr(0);/*Optional 5*/
        public readonly HssUtility.General.Attributes.Decimal_attr Rate_Position_1 = new HssUtility.General.Attributes.Decimal_attr(0);/*Optional 6*/
        public readonly HssUtility.General.Attributes.Decimal_attr Rate_Position_2 = new HssUtility.General.Attributes.Decimal_attr(0);/*Optional 7*/
        public readonly HssUtility.General.Attributes.Decimal_attr Rate_Position_3 = new HssUtility.General.Attributes.Decimal_attr(0);/*Optional 8*/
        public readonly HssUtility.General.Attributes.Decimal_attr Rate_Position_4 = new HssUtility.General.Attributes.Decimal_attr(0);/*Optional 9*/
        public readonly HssUtility.General.Attributes.Decimal_attr Rate_Position_5 = new HssUtility.General.Attributes.Decimal_attr(0);/*Optional 10*/
        public readonly HssUtility.General.Attributes.Decimal_attr Rate_Position_6 = new HssUtility.General.Attributes.Decimal_attr(0);/*Optional 11*/
        public readonly HssUtility.General.Attributes.Decimal_attr Rate_Position_7 = new HssUtility.General.Attributes.Decimal_attr(0);/*Optional 12*/
        public readonly HssUtility.General.Attributes.Decimal_attr Rate_Position_8 = new HssUtility.General.Attributes.Decimal_attr(0);/*Optional 13*/
        public readonly HssUtility.General.Attributes.Decimal_attr Rate_Position_9 = new HssUtility.General.Attributes.Decimal_attr(0);/*Optional 14*/
        public readonly HssUtility.General.Attributes.Decimal_attr Rate_Position_10 = new HssUtility.General.Attributes.Decimal_attr(0);/*Optional 15*/
        public readonly HssUtility.General.Attributes.Decimal_attr Rate_Position_11 = new HssUtility.General.Attributes.Decimal_attr(0);/*Optional 16*/
        public readonly HssUtility.General.Attributes.Decimal_attr Rate_Position_12 = new HssUtility.General.Attributes.Decimal_attr(0);/*Optional 17*/
        public readonly HssUtility.General.Attributes.Decimal_attr Rate_Position_13 = new HssUtility.General.Attributes.Decimal_attr(0);/*Optional 18*/
        public readonly HssUtility.General.Attributes.Decimal_attr Rate_Position_14 = new HssUtility.General.Attributes.Decimal_attr(0);/*Optional 19*/
        public readonly HssUtility.General.Attributes.Decimal_attr Rate_Position_15 = new HssUtility.General.Attributes.Decimal_attr(0);/*Optional 20*/
        public readonly HssUtility.General.Attributes.Decimal_attr Rate_Position_16 = new HssUtility.General.Attributes.Decimal_attr(0);/*Optional 21*/
        public readonly HssUtility.General.Attributes.Decimal_attr Rate_Position_17 = new HssUtility.General.Attributes.Decimal_attr(0);/*Optional 22*/
        public readonly HssUtility.General.Attributes.Decimal_attr Rate_Position_18 = new HssUtility.General.Attributes.Decimal_attr(0);/*Optional 23*/
        public readonly HssUtility.General.Attributes.Decimal_attr Rate_Chargeback_1 = new HssUtility.General.Attributes.Decimal_attr(0);/*Optional 24*/
        public readonly HssUtility.General.Attributes.Decimal_attr Rate_Chargeback_2 = new HssUtility.General.Attributes.Decimal_attr(0);/*Optional 25*/
        public readonly HssUtility.General.Attributes.Decimal_attr Rate_Chargeback_3 = new HssUtility.General.Attributes.Decimal_attr(0);/*Optional 26*/
        public readonly HssUtility.General.Attributes.Decimal_attr Rate_Chargeback_4 = new HssUtility.General.Attributes.Decimal_attr(0);/*Optional 27*/
        public readonly HssUtility.General.Attributes.Decimal_attr Rate_Chargeback_5 = new HssUtility.General.Attributes.Decimal_attr(0);/*Optional 28*/
        public readonly HssUtility.General.Attributes.Decimal_attr Rate_Chargeback_6 = new HssUtility.General.Attributes.Decimal_attr(0);/*Optional 29*/
        public readonly HssUtility.General.Attributes.Decimal_attr Rate_Chargeback_7 = new HssUtility.General.Attributes.Decimal_attr(0);/*Optional 30*/
        public readonly HssUtility.General.Attributes.Decimal_attr Rate_Chargeback_8 = new HssUtility.General.Attributes.Decimal_attr(0);/*Optional 31*/
        public readonly HssUtility.General.Attributes.Decimal_attr Rate_Chargeback_9 = new HssUtility.General.Attributes.Decimal_attr(0);/*Optional 32*/
        public readonly HssUtility.General.Attributes.Decimal_attr Rate_Chargeback_10 = new HssUtility.General.Attributes.Decimal_attr(0);/*Optional 33*/
        public readonly HssUtility.General.Attributes.Decimal_attr Rate_Chargeback_11 = new HssUtility.General.Attributes.Decimal_attr(0);/*Optional 34*/
        public readonly HssUtility.General.Attributes.Decimal_attr Rate_Chargeback_12 = new HssUtility.General.Attributes.Decimal_attr(0);/*Optional 35*/
        public readonly HssUtility.General.Attributes.Decimal_attr Rate_Chargeback_13 = new HssUtility.General.Attributes.Decimal_attr(0);/*Optional 36*/
        public readonly HssUtility.General.Attributes.Decimal_attr Rate_Chargeback_14 = new HssUtility.General.Attributes.Decimal_attr(0);/*Optional 37*/
        public readonly HssUtility.General.Attributes.Decimal_attr Rate_Chargeback_15 = new HssUtility.General.Attributes.Decimal_attr(0);/*Optional 38*/
        public readonly HssUtility.General.Attributes.Decimal_attr Rate_Chargeback_16 = new HssUtility.General.Attributes.Decimal_attr(0);/*Optional 39*/
        public readonly HssUtility.General.Attributes.Decimal_attr Rate_Chargeback_17 = new HssUtility.General.Attributes.Decimal_attr(0);/*Optional 40*/
        public readonly HssUtility.General.Attributes.Decimal_attr Rate_Chargeback_18 = new HssUtility.General.Attributes.Decimal_attr(0);/*Optional 41*/
        public readonly HssUtility.General.Attributes.Decimal_attr Exempt1 = new HssUtility.General.Attributes.Decimal_attr(0);/*Optional 42*/
        public readonly HssUtility.General.Attributes.Decimal_attr Exempt2 = new HssUtility.General.Attributes.Decimal_attr(0);/*Optional 43*/
        public readonly HssUtility.General.Attributes.Decimal_attr Exempt3 = new HssUtility.General.Attributes.Decimal_attr(0);/*Optional 44*/
        public readonly HssUtility.General.Attributes.Decimal_attr Exempt4 = new HssUtility.General.Attributes.Decimal_attr(0);/*Optional 45*/
        public readonly HssUtility.General.Attributes.Decimal_attr Exempt5 = new HssUtility.General.Attributes.Decimal_attr(0);/*Optional 46*/
        public readonly HssUtility.General.Attributes.String_attr LastModifiedBy = new HssUtility.General.Attributes.String_attr();/*Optional 47*/
        public readonly HssUtility.General.Attributes.DateTime_attr ModifiedDateTime = new HssUtility.General.Attributes.DateTime_attr();/*Optional 48*/
        public readonly HssUtility.General.Attributes.Int_attr CustodianID = new HssUtility.General.Attributes.Int_attr();/*Optional 49*/
        public readonly HssUtility.General.Attributes.Decimal_attr ChargeBackFX = new HssUtility.General.Attributes.Decimal_attr(0);/*Optional 50*/
        public readonly HssUtility.General.Attributes.String_attr ClientBookNumber = new HssUtility.General.Attributes.String_attr();/*Optional 51*/

        private Dictionary<string, HssUtility.General.Attributes.I_modelAttr> attr_dic = null;

        internal void Init_from_reader(HssUtility.SQLserver.DB_reader reader)
        {
            if (reader == null || reader.IsClosed) return;

            this.pk_ID = reader.GetInt("DTC_PositionID");
            reader.GetInt("DividendIndex", this.DividendIndex);
            reader.GetString("DTC_Number", this.DTC_Number);
            reader.GetString("Company_Name", this.Company_Name);/*Optional 4*/
            reader.GetDecimal("Total_RecDate_Position", this.Total_RecDate_Position);/*Optional 5*/
            reader.GetDecimal("Rate_Position_1", this.Rate_Position_1);/*Optional 6*/
            reader.GetDecimal("Rate_Position_2", this.Rate_Position_2);/*Optional 7*/
            reader.GetDecimal("Rate_Position_3", this.Rate_Position_3);/*Optional 8*/
            reader.GetDecimal("Rate_Position_4", this.Rate_Position_4);/*Optional 9*/
            reader.GetDecimal("Rate_Position_5", this.Rate_Position_5);/*Optional 10*/
            reader.GetDecimal("Rate_Position_6", this.Rate_Position_6);/*Optional 11*/
            reader.GetDecimal("Rate_Position_7", this.Rate_Position_7);/*Optional 12*/
            reader.GetDecimal("Rate_Position_8", this.Rate_Position_8);/*Optional 13*/
            reader.GetDecimal("Rate_Position_9", this.Rate_Position_9);/*Optional 14*/
            reader.GetDecimal("Rate_Position_10", this.Rate_Position_10);/*Optional 15*/
            reader.GetDecimal("Rate_Position_11", this.Rate_Position_11);/*Optional 16*/
            reader.GetDecimal("Rate_Position_12", this.Rate_Position_12);/*Optional 17*/
            reader.GetDecimal("Rate_Position_13", this.Rate_Position_13);/*Optional 18*/
            reader.GetDecimal("Rate_Position_14", this.Rate_Position_14);/*Optional 19*/
            reader.GetDecimal("Rate_Position_15", this.Rate_Position_15);/*Optional 20*/
            reader.GetDecimal("Rate_Position_16", this.Rate_Position_16);/*Optional 21*/
            reader.GetDecimal("Rate_Position_17", this.Rate_Position_17);/*Optional 22*/
            reader.GetDecimal("Rate_Position_18", this.Rate_Position_18);/*Optional 23*/
            reader.GetDecimal("Rate_Chargeback_1", this.Rate_Chargeback_1);/*Optional 24*/
            reader.GetDecimal("Rate_Chargeback_2", this.Rate_Chargeback_2);/*Optional 25*/
            reader.GetDecimal("Rate_Chargeback_3", this.Rate_Chargeback_3);/*Optional 26*/
            reader.GetDecimal("Rate_Chargeback_4", this.Rate_Chargeback_4);/*Optional 27*/
            reader.GetDecimal("Rate_Chargeback_5", this.Rate_Chargeback_5);/*Optional 28*/
            reader.GetDecimal("Rate_Chargeback_6", this.Rate_Chargeback_6);/*Optional 29*/
            reader.GetDecimal("Rate_Chargeback_7", this.Rate_Chargeback_7);/*Optional 30*/
            reader.GetDecimal("Rate_Chargeback_8", this.Rate_Chargeback_8);/*Optional 31*/
            reader.GetDecimal("Rate_Chargeback_9", this.Rate_Chargeback_9);/*Optional 32*/
            reader.GetDecimal("Rate_Chargeback_10", this.Rate_Chargeback_10);/*Optional 33*/
            reader.GetDecimal("Rate_Chargeback_11", this.Rate_Chargeback_11);/*Optional 34*/
            reader.GetDecimal("Rate_Chargeback_12", this.Rate_Chargeback_12);/*Optional 35*/
            reader.GetDecimal("Rate_Chargeback_13", this.Rate_Chargeback_13);/*Optional 36*/
            reader.GetDecimal("Rate_Chargeback_14", this.Rate_Chargeback_14);/*Optional 37*/
            reader.GetDecimal("Rate_Chargeback_15", this.Rate_Chargeback_15);/*Optional 38*/
            reader.GetDecimal("Rate_Chargeback_16", this.Rate_Chargeback_16);/*Optional 39*/
            reader.GetDecimal("Rate_Chargeback_17", this.Rate_Chargeback_17);/*Optional 40*/
            reader.GetDecimal("Rate_Chargeback_18", this.Rate_Chargeback_18);/*Optional 41*/
            reader.GetDecimal("Exempt1", this.Exempt1);/*Optional 42*/
            reader.GetDecimal("Exempt2", this.Exempt2);/*Optional 43*/
            reader.GetDecimal("Exempt3", this.Exempt3);/*Optional 44*/
            reader.GetDecimal("Exempt4", this.Exempt4);/*Optional 45*/
            reader.GetDecimal("Exempt5", this.Exempt5);/*Optional 46*/
            reader.GetString("LastModifiedBy", this.LastModifiedBy);/*Optional 47*/
            reader.GetDateTime("ModifiedDateTime", this.ModifiedDateTime);/*Optional 48*/
            reader.GetInt("CustodianID", this.CustodianID);/*Optional 49*/
            reader.GetDecimal("ChargeBackFX", this.ChargeBackFX);/*Optional 50*/
            reader.GetString("ClientBookNumber", this.ClientBookNumber);/*Optional 51*/

            this.SyncWithDB();
        }

        /// <summary>
        /// Initialize object from DB
        /// </summary>
        public bool Init_from_DB()
        {
            if (this.DTC_PositionID < 0) return false;

            HssUtility.SQLserver.DB_select db_sel = new HssUtility.SQLserver.DB_select(Dividend_DTC_Position.Get_cmdTP());
            db_sel.tableName = "Dividend_DTC_Position";
            HssUtility.SQLserver.SQL_relation rela = new HssUtility.SQLserver.SQL_relation("DTC_PositionID", HssUtility.General.RelationalOperator.Equals, this.DTC_PositionID);
            db_sel.SetCondition(rela);

            bool res_flag = false;
            HssUtility.SQLserver.DB_reader reader = new HssUtility.SQLserver.DB_reader(db_sel, Utility.Get_DRWIN_hDB());
            if (reader.Read())
            {
                this.Init_from_reader(reader);
                res_flag = true;
            }
            reader.Close();
            return res_flag;
        }

        internal void SyncWithDB()
        {
            this.Create_attrDic();
            foreach (HssUtility.General.Attributes.I_modelAttr ma in this.attr_dic.Values) ma.SyncWithDB();
        }

        public bool CheckValueChanges()
        {
            this.Create_attrDic();
            foreach (HssUtility.General.Attributes.I_modelAttr ma in this.attr_dic.Values) if (ma.ValueChanged) return true;
            return false;
        }

        private void Create_attrDic()
        {
            if (this.attr_dic != null) return;

            this.attr_dic = new Dictionary<string, HssUtility.General.Attributes.I_modelAttr>(StringComparer.OrdinalIgnoreCase);
            this.attr_dic.Add("DividendIndex", this.DividendIndex);
            this.attr_dic.Add("DTC_Number", this.DTC_Number);
            this.attr_dic.Add("Company_Name", this.Company_Name);/*Optional 4*/
            this.attr_dic.Add("Total_RecDate_Position", this.Total_RecDate_Position);/*Optional 5*/
            this.attr_dic.Add("Rate_Position_1", this.Rate_Position_1);/*Optional 6*/
            this.attr_dic.Add("Rate_Position_2", this.Rate_Position_2);/*Optional 7*/
            this.attr_dic.Add("Rate_Position_3", this.Rate_Position_3);/*Optional 8*/
            this.attr_dic.Add("Rate_Position_4", this.Rate_Position_4);/*Optional 9*/
            this.attr_dic.Add("Rate_Position_5", this.Rate_Position_5);/*Optional 10*/
            this.attr_dic.Add("Rate_Position_6", this.Rate_Position_6);/*Optional 11*/
            this.attr_dic.Add("Rate_Position_7", this.Rate_Position_7);/*Optional 12*/
            this.attr_dic.Add("Rate_Position_8", this.Rate_Position_8);/*Optional 13*/
            this.attr_dic.Add("Rate_Position_9", this.Rate_Position_9);/*Optional 14*/
            this.attr_dic.Add("Rate_Position_10", this.Rate_Position_10);/*Optional 15*/
            this.attr_dic.Add("Rate_Position_11", this.Rate_Position_11);/*Optional 16*/
            this.attr_dic.Add("Rate_Position_12", this.Rate_Position_12);/*Optional 17*/
            this.attr_dic.Add("Rate_Position_13", this.Rate_Position_13);/*Optional 18*/
            this.attr_dic.Add("Rate_Position_14", this.Rate_Position_14);/*Optional 19*/
            this.attr_dic.Add("Rate_Position_15", this.Rate_Position_15);/*Optional 20*/
            this.attr_dic.Add("Rate_Position_16", this.Rate_Position_16);/*Optional 21*/
            this.attr_dic.Add("Rate_Position_17", this.Rate_Position_17);/*Optional 22*/
            this.attr_dic.Add("Rate_Position_18", this.Rate_Position_18);/*Optional 23*/
            this.attr_dic.Add("Rate_Chargeback_1", this.Rate_Chargeback_1);/*Optional 24*/
            this.attr_dic.Add("Rate_Chargeback_2", this.Rate_Chargeback_2);/*Optional 25*/
            this.attr_dic.Add("Rate_Chargeback_3", this.Rate_Chargeback_3);/*Optional 26*/
            this.attr_dic.Add("Rate_Chargeback_4", this.Rate_Chargeback_4);/*Optional 27*/
            this.attr_dic.Add("Rate_Chargeback_5", this.Rate_Chargeback_5);/*Optional 28*/
            this.attr_dic.Add("Rate_Chargeback_6", this.Rate_Chargeback_6);/*Optional 29*/
            this.attr_dic.Add("Rate_Chargeback_7", this.Rate_Chargeback_7);/*Optional 30*/
            this.attr_dic.Add("Rate_Chargeback_8", this.Rate_Chargeback_8);/*Optional 31*/
            this.attr_dic.Add("Rate_Chargeback_9", this.Rate_Chargeback_9);/*Optional 32*/
            this.attr_dic.Add("Rate_Chargeback_10", this.Rate_Chargeback_10);/*Optional 33*/
            this.attr_dic.Add("Rate_Chargeback_11", this.Rate_Chargeback_11);/*Optional 34*/
            this.attr_dic.Add("Rate_Chargeback_12", this.Rate_Chargeback_12);/*Optional 35*/
            this.attr_dic.Add("Rate_Chargeback_13", this.Rate_Chargeback_13);/*Optional 36*/
            this.attr_dic.Add("Rate_Chargeback_14", this.Rate_Chargeback_14);/*Optional 37*/
            this.attr_dic.Add("Rate_Chargeback_15", this.Rate_Chargeback_15);/*Optional 38*/
            this.attr_dic.Add("Rate_Chargeback_16", this.Rate_Chargeback_16);/*Optional 39*/
            this.attr_dic.Add("Rate_Chargeback_17", this.Rate_Chargeback_17);/*Optional 40*/
            this.attr_dic.Add("Rate_Chargeback_18", this.Rate_Chargeback_18);/*Optional 41*/
            this.attr_dic.Add("Exempt1", this.Exempt1);/*Optional 42*/
            this.attr_dic.Add("Exempt2", this.Exempt2);/*Optional 43*/
            this.attr_dic.Add("Exempt3", this.Exempt3);/*Optional 44*/
            this.attr_dic.Add("Exempt4", this.Exempt4);/*Optional 45*/
            this.attr_dic.Add("Exempt5", this.Exempt5);/*Optional 46*/
            this.attr_dic.Add("LastModifiedBy", this.LastModifiedBy);/*Optional 47*/
            this.attr_dic.Add("ModifiedDateTime", this.ModifiedDateTime);/*Optional 48*/
            this.attr_dic.Add("CustodianID", this.CustodianID);/*Optional 49*/
            this.attr_dic.Add("ChargeBackFX", this.ChargeBackFX);/*Optional 50*/
            this.attr_dic.Add("ClientBookNumber", this.ClientBookNumber);/*Optional 51*/
        }

        /// <summary>
        /// Insert object to DB
        /// </summary>
        public bool Insert_to_DB()
        {
            HssUtility.SQLserver.DB_insert ins = this.Get_DBinsert();
            int count = ins.SaveToDB(Utility.Get_DRWIN_hDB());

            bool flag = count > 0;
            if (flag) this.SyncWithDB();

            return flag;
        }

        internal HssUtility.SQLserver.DB_insert Get_DBinsert()
        {
            HssUtility.SQLserver.DB_insert dbIns = new HssUtility.SQLserver.DB_insert(Dividend_DTC_Position.Get_cmdTP());

            dbIns.AddValue("DividendIndex", this.DividendIndex);
            dbIns.AddValue("DTC_Number", this.DTC_Number);
            dbIns.AddValue("Company_Name", this.Company_Name);/*Optional 4*/
            dbIns.AddValue("Total_RecDate_Position", this.Total_RecDate_Position);/*Optional 5*/
            dbIns.AddValue("Rate_Position_1", this.Rate_Position_1);/*Optional 6*/
            dbIns.AddValue("Rate_Position_2", this.Rate_Position_2);/*Optional 7*/
            dbIns.AddValue("Rate_Position_3", this.Rate_Position_3);/*Optional 8*/
            dbIns.AddValue("Rate_Position_4", this.Rate_Position_4);/*Optional 9*/
            dbIns.AddValue("Rate_Position_5", this.Rate_Position_5);/*Optional 10*/
            dbIns.AddValue("Rate_Position_6", this.Rate_Position_6);/*Optional 11*/
            dbIns.AddValue("Rate_Position_7", this.Rate_Position_7);/*Optional 12*/
            dbIns.AddValue("Rate_Position_8", this.Rate_Position_8);/*Optional 13*/
            dbIns.AddValue("Rate_Position_9", this.Rate_Position_9);/*Optional 14*/
            dbIns.AddValue("Rate_Position_10", this.Rate_Position_10);/*Optional 15*/
            dbIns.AddValue("Rate_Position_11", this.Rate_Position_11);/*Optional 16*/
            dbIns.AddValue("Rate_Position_12", this.Rate_Position_12);/*Optional 17*/
            dbIns.AddValue("Rate_Position_13", this.Rate_Position_13);/*Optional 18*/
            dbIns.AddValue("Rate_Position_14", this.Rate_Position_14);/*Optional 19*/
            dbIns.AddValue("Rate_Position_15", this.Rate_Position_15);/*Optional 20*/
            dbIns.AddValue("Rate_Position_16", this.Rate_Position_16);/*Optional 21*/
            dbIns.AddValue("Rate_Position_17", this.Rate_Position_17);/*Optional 22*/
            dbIns.AddValue("Rate_Position_18", this.Rate_Position_18);/*Optional 23*/
            dbIns.AddValue("Rate_Chargeback_1", this.Rate_Chargeback_1);/*Optional 24*/
            dbIns.AddValue("Rate_Chargeback_2", this.Rate_Chargeback_2);/*Optional 25*/
            dbIns.AddValue("Rate_Chargeback_3", this.Rate_Chargeback_3);/*Optional 26*/
            dbIns.AddValue("Rate_Chargeback_4", this.Rate_Chargeback_4);/*Optional 27*/
            dbIns.AddValue("Rate_Chargeback_5", this.Rate_Chargeback_5);/*Optional 28*/
            dbIns.AddValue("Rate_Chargeback_6", this.Rate_Chargeback_6);/*Optional 29*/
            dbIns.AddValue("Rate_Chargeback_7", this.Rate_Chargeback_7);/*Optional 30*/
            dbIns.AddValue("Rate_Chargeback_8", this.Rate_Chargeback_8);/*Optional 31*/
            dbIns.AddValue("Rate_Chargeback_9", this.Rate_Chargeback_9);/*Optional 32*/
            dbIns.AddValue("Rate_Chargeback_10", this.Rate_Chargeback_10);/*Optional 33*/
            dbIns.AddValue("Rate_Chargeback_11", this.Rate_Chargeback_11);/*Optional 34*/
            dbIns.AddValue("Rate_Chargeback_12", this.Rate_Chargeback_12);/*Optional 35*/
            dbIns.AddValue("Rate_Chargeback_13", this.Rate_Chargeback_13);/*Optional 36*/
            dbIns.AddValue("Rate_Chargeback_14", this.Rate_Chargeback_14);/*Optional 37*/
            dbIns.AddValue("Rate_Chargeback_15", this.Rate_Chargeback_15);/*Optional 38*/
            dbIns.AddValue("Rate_Chargeback_16", this.Rate_Chargeback_16);/*Optional 39*/
            dbIns.AddValue("Rate_Chargeback_17", this.Rate_Chargeback_17);/*Optional 40*/
            dbIns.AddValue("Rate_Chargeback_18", this.Rate_Chargeback_18);/*Optional 41*/
            dbIns.AddValue("Exempt1", this.Exempt1);/*Optional 42*/
            dbIns.AddValue("Exempt2", this.Exempt2);/*Optional 43*/
            dbIns.AddValue("Exempt3", this.Exempt3);/*Optional 44*/
            dbIns.AddValue("Exempt4", this.Exempt4);/*Optional 45*/
            dbIns.AddValue("Exempt5", this.Exempt5);/*Optional 46*/
            dbIns.AddValue("LastModifiedBy", this.LastModifiedBy);/*Optional 47*/
            dbIns.AddValue("ModifiedDateTime", this.ModifiedDateTime);/*Optional 48*/
            dbIns.AddValue("CustodianID", this.CustodianID);/*Optional 49*/
            dbIns.AddValue("ChargeBackFX", this.ChargeBackFX);/*Optional 50*/
            dbIns.AddValue("ClientBookNumber", this.ClientBookNumber);/*Optional 51*/

            return dbIns;
        }

        /// <summary>
        /// Save updates to DB
        /// </summary>
        public bool Update_to_DB()
        {
            HssUtility.SQLserver.DB_update upd = this.Get_DBupdate();
            if (upd == null) return false;

            int count = upd.SaveToDB(Utility.Get_DRWIN_hDB());
            bool flag = count > 0;
            if (flag) this.SyncWithDB();

            return flag;
        }

        internal HssUtility.SQLserver.DB_update Get_DBupdate()
        {
            if (!this.CheckValueChanges()) return null;

            HssUtility.SQLserver.DB_update upd = new HssUtility.SQLserver.DB_update(Dividend_DTC_Position.Get_cmdTP());
            if (this.DividendIndex.ValueChanged) upd.AddValue("DividendIndex", this.DividendIndex);
            if (this.DTC_Number.ValueChanged) upd.AddValue("DTC_Number", this.DTC_Number);
            if (this.Company_Name.ValueChanged) upd.AddValue("Company_Name", this.Company_Name);/*Optional 4*/
            if (this.Total_RecDate_Position.ValueChanged) upd.AddValue("Total_RecDate_Position", this.Total_RecDate_Position);/*Optional 5*/
            if (this.Rate_Position_1.ValueChanged) upd.AddValue("Rate_Position_1", this.Rate_Position_1);/*Optional 6*/
            if (this.Rate_Position_2.ValueChanged) upd.AddValue("Rate_Position_2", this.Rate_Position_2);/*Optional 7*/
            if (this.Rate_Position_3.ValueChanged) upd.AddValue("Rate_Position_3", this.Rate_Position_3);/*Optional 8*/
            if (this.Rate_Position_4.ValueChanged) upd.AddValue("Rate_Position_4", this.Rate_Position_4);/*Optional 9*/
            if (this.Rate_Position_5.ValueChanged) upd.AddValue("Rate_Position_5", this.Rate_Position_5);/*Optional 10*/
            if (this.Rate_Position_6.ValueChanged) upd.AddValue("Rate_Position_6", this.Rate_Position_6);/*Optional 11*/
            if (this.Rate_Position_7.ValueChanged) upd.AddValue("Rate_Position_7", this.Rate_Position_7);/*Optional 12*/
            if (this.Rate_Position_8.ValueChanged) upd.AddValue("Rate_Position_8", this.Rate_Position_8);/*Optional 13*/
            if (this.Rate_Position_9.ValueChanged) upd.AddValue("Rate_Position_9", this.Rate_Position_9);/*Optional 14*/
            if (this.Rate_Position_10.ValueChanged) upd.AddValue("Rate_Position_10", this.Rate_Position_10);/*Optional 15*/
            if (this.Rate_Position_11.ValueChanged) upd.AddValue("Rate_Position_11", this.Rate_Position_11);/*Optional 16*/
            if (this.Rate_Position_12.ValueChanged) upd.AddValue("Rate_Position_12", this.Rate_Position_12);/*Optional 17*/
            if (this.Rate_Position_13.ValueChanged) upd.AddValue("Rate_Position_13", this.Rate_Position_13);/*Optional 18*/
            if (this.Rate_Position_14.ValueChanged) upd.AddValue("Rate_Position_14", this.Rate_Position_14);/*Optional 19*/
            if (this.Rate_Position_15.ValueChanged) upd.AddValue("Rate_Position_15", this.Rate_Position_15);/*Optional 20*/
            if (this.Rate_Position_16.ValueChanged) upd.AddValue("Rate_Position_16", this.Rate_Position_16);/*Optional 21*/
            if (this.Rate_Position_17.ValueChanged) upd.AddValue("Rate_Position_17", this.Rate_Position_17);/*Optional 22*/
            if (this.Rate_Position_18.ValueChanged) upd.AddValue("Rate_Position_18", this.Rate_Position_18);/*Optional 23*/
            if (this.Rate_Chargeback_1.ValueChanged) upd.AddValue("Rate_Chargeback_1", this.Rate_Chargeback_1);/*Optional 24*/
            if (this.Rate_Chargeback_2.ValueChanged) upd.AddValue("Rate_Chargeback_2", this.Rate_Chargeback_2);/*Optional 25*/
            if (this.Rate_Chargeback_3.ValueChanged) upd.AddValue("Rate_Chargeback_3", this.Rate_Chargeback_3);/*Optional 26*/
            if (this.Rate_Chargeback_4.ValueChanged) upd.AddValue("Rate_Chargeback_4", this.Rate_Chargeback_4);/*Optional 27*/
            if (this.Rate_Chargeback_5.ValueChanged) upd.AddValue("Rate_Chargeback_5", this.Rate_Chargeback_5);/*Optional 28*/
            if (this.Rate_Chargeback_6.ValueChanged) upd.AddValue("Rate_Chargeback_6", this.Rate_Chargeback_6);/*Optional 29*/
            if (this.Rate_Chargeback_7.ValueChanged) upd.AddValue("Rate_Chargeback_7", this.Rate_Chargeback_7);/*Optional 30*/
            if (this.Rate_Chargeback_8.ValueChanged) upd.AddValue("Rate_Chargeback_8", this.Rate_Chargeback_8);/*Optional 31*/
            if (this.Rate_Chargeback_9.ValueChanged) upd.AddValue("Rate_Chargeback_9", this.Rate_Chargeback_9);/*Optional 32*/
            if (this.Rate_Chargeback_10.ValueChanged) upd.AddValue("Rate_Chargeback_10", this.Rate_Chargeback_10);/*Optional 33*/
            if (this.Rate_Chargeback_11.ValueChanged) upd.AddValue("Rate_Chargeback_11", this.Rate_Chargeback_11);/*Optional 34*/
            if (this.Rate_Chargeback_12.ValueChanged) upd.AddValue("Rate_Chargeback_12", this.Rate_Chargeback_12);/*Optional 35*/
            if (this.Rate_Chargeback_13.ValueChanged) upd.AddValue("Rate_Chargeback_13", this.Rate_Chargeback_13);/*Optional 36*/
            if (this.Rate_Chargeback_14.ValueChanged) upd.AddValue("Rate_Chargeback_14", this.Rate_Chargeback_14);/*Optional 37*/
            if (this.Rate_Chargeback_15.ValueChanged) upd.AddValue("Rate_Chargeback_15", this.Rate_Chargeback_15);/*Optional 38*/
            if (this.Rate_Chargeback_16.ValueChanged) upd.AddValue("Rate_Chargeback_16", this.Rate_Chargeback_16);/*Optional 39*/
            if (this.Rate_Chargeback_17.ValueChanged) upd.AddValue("Rate_Chargeback_17", this.Rate_Chargeback_17);/*Optional 40*/
            if (this.Rate_Chargeback_18.ValueChanged) upd.AddValue("Rate_Chargeback_18", this.Rate_Chargeback_18);/*Optional 41*/
            if (this.Exempt1.ValueChanged) upd.AddValue("Exempt1", this.Exempt1);/*Optional 42*/
            if (this.Exempt2.ValueChanged) upd.AddValue("Exempt2", this.Exempt2);/*Optional 43*/
            if (this.Exempt3.ValueChanged) upd.AddValue("Exempt3", this.Exempt3);/*Optional 44*/
            if (this.Exempt4.ValueChanged) upd.AddValue("Exempt4", this.Exempt4);/*Optional 45*/
            if (this.Exempt5.ValueChanged) upd.AddValue("Exempt5", this.Exempt5);/*Optional 46*/
            if (this.LastModifiedBy.ValueChanged) upd.AddValue("LastModifiedBy", this.LastModifiedBy);/*Optional 47*/
            if (this.ModifiedDateTime.ValueChanged) upd.AddValue("ModifiedDateTime", this.ModifiedDateTime);/*Optional 48*/
            if (this.CustodianID.ValueChanged) upd.AddValue("CustodianID", this.CustodianID);/*Optional 49*/
            if (this.ChargeBackFX.ValueChanged) upd.AddValue("ChargeBackFX", this.ChargeBackFX);/*Optional 50*/
            if (this.ClientBookNumber.ValueChanged) upd.AddValue("ClientBookNumber", this.ClientBookNumber);/*Optional 51*/

            HssUtility.SQLserver.SQL_relation rela = new HssUtility.SQLserver.SQL_relation("DTC_PositionID", HssUtility.General.RelationalOperator.Equals, this.pk_ID);
            upd.SetCondition(rela);

            return upd;
        }

        public Dividend_DTC_Position GetCopy()
        {
            Dividend_DTC_Position newEntity = new Dividend_DTC_Position();
            if (!this.DividendIndex.IsNull_flag) newEntity.DividendIndex.Value = this.DividendIndex.Value;
            if (!this.DTC_Number.IsNull_flag) newEntity.DTC_Number.Value = this.DTC_Number.Value;
            if (!this.Company_Name.IsNull_flag) newEntity.Company_Name.Value = this.Company_Name.Value;
            if (!this.Total_RecDate_Position.IsNull_flag) newEntity.Total_RecDate_Position.Value = this.Total_RecDate_Position.Value;
            if (!this.Rate_Position_1.IsNull_flag) newEntity.Rate_Position_1.Value = this.Rate_Position_1.Value;
            if (!this.Rate_Position_2.IsNull_flag) newEntity.Rate_Position_2.Value = this.Rate_Position_2.Value;
            if (!this.Rate_Position_3.IsNull_flag) newEntity.Rate_Position_3.Value = this.Rate_Position_3.Value;
            if (!this.Rate_Position_4.IsNull_flag) newEntity.Rate_Position_4.Value = this.Rate_Position_4.Value;
            if (!this.Rate_Position_5.IsNull_flag) newEntity.Rate_Position_5.Value = this.Rate_Position_5.Value;
            if (!this.Rate_Position_6.IsNull_flag) newEntity.Rate_Position_6.Value = this.Rate_Position_6.Value;
            if (!this.Rate_Position_7.IsNull_flag) newEntity.Rate_Position_7.Value = this.Rate_Position_7.Value;
            if (!this.Rate_Position_8.IsNull_flag) newEntity.Rate_Position_8.Value = this.Rate_Position_8.Value;
            if (!this.Rate_Position_9.IsNull_flag) newEntity.Rate_Position_9.Value = this.Rate_Position_9.Value;
            if (!this.Rate_Position_10.IsNull_flag) newEntity.Rate_Position_10.Value = this.Rate_Position_10.Value;
            if (!this.Rate_Position_11.IsNull_flag) newEntity.Rate_Position_11.Value = this.Rate_Position_11.Value;
            if (!this.Rate_Position_12.IsNull_flag) newEntity.Rate_Position_12.Value = this.Rate_Position_12.Value;
            if (!this.Rate_Position_13.IsNull_flag) newEntity.Rate_Position_13.Value = this.Rate_Position_13.Value;
            if (!this.Rate_Position_14.IsNull_flag) newEntity.Rate_Position_14.Value = this.Rate_Position_14.Value;
            if (!this.Rate_Position_15.IsNull_flag) newEntity.Rate_Position_15.Value = this.Rate_Position_15.Value;
            if (!this.Rate_Position_16.IsNull_flag) newEntity.Rate_Position_16.Value = this.Rate_Position_16.Value;
            if (!this.Rate_Position_17.IsNull_flag) newEntity.Rate_Position_17.Value = this.Rate_Position_17.Value;
            if (!this.Rate_Position_18.IsNull_flag) newEntity.Rate_Position_18.Value = this.Rate_Position_18.Value;
            if (!this.Rate_Chargeback_1.IsNull_flag) newEntity.Rate_Chargeback_1.Value = this.Rate_Chargeback_1.Value;
            if (!this.Rate_Chargeback_2.IsNull_flag) newEntity.Rate_Chargeback_2.Value = this.Rate_Chargeback_2.Value;
            if (!this.Rate_Chargeback_3.IsNull_flag) newEntity.Rate_Chargeback_3.Value = this.Rate_Chargeback_3.Value;
            if (!this.Rate_Chargeback_4.IsNull_flag) newEntity.Rate_Chargeback_4.Value = this.Rate_Chargeback_4.Value;
            if (!this.Rate_Chargeback_5.IsNull_flag) newEntity.Rate_Chargeback_5.Value = this.Rate_Chargeback_5.Value;
            if (!this.Rate_Chargeback_6.IsNull_flag) newEntity.Rate_Chargeback_6.Value = this.Rate_Chargeback_6.Value;
            if (!this.Rate_Chargeback_7.IsNull_flag) newEntity.Rate_Chargeback_7.Value = this.Rate_Chargeback_7.Value;
            if (!this.Rate_Chargeback_8.IsNull_flag) newEntity.Rate_Chargeback_8.Value = this.Rate_Chargeback_8.Value;
            if (!this.Rate_Chargeback_9.IsNull_flag) newEntity.Rate_Chargeback_9.Value = this.Rate_Chargeback_9.Value;
            if (!this.Rate_Chargeback_10.IsNull_flag) newEntity.Rate_Chargeback_10.Value = this.Rate_Chargeback_10.Value;
            if (!this.Rate_Chargeback_11.IsNull_flag) newEntity.Rate_Chargeback_11.Value = this.Rate_Chargeback_11.Value;
            if (!this.Rate_Chargeback_12.IsNull_flag) newEntity.Rate_Chargeback_12.Value = this.Rate_Chargeback_12.Value;
            if (!this.Rate_Chargeback_13.IsNull_flag) newEntity.Rate_Chargeback_13.Value = this.Rate_Chargeback_13.Value;
            if (!this.Rate_Chargeback_14.IsNull_flag) newEntity.Rate_Chargeback_14.Value = this.Rate_Chargeback_14.Value;
            if (!this.Rate_Chargeback_15.IsNull_flag) newEntity.Rate_Chargeback_15.Value = this.Rate_Chargeback_15.Value;
            if (!this.Rate_Chargeback_16.IsNull_flag) newEntity.Rate_Chargeback_16.Value = this.Rate_Chargeback_16.Value;
            if (!this.Rate_Chargeback_17.IsNull_flag) newEntity.Rate_Chargeback_17.Value = this.Rate_Chargeback_17.Value;
            if (!this.Rate_Chargeback_18.IsNull_flag) newEntity.Rate_Chargeback_18.Value = this.Rate_Chargeback_18.Value;
            if (!this.Exempt1.IsNull_flag) newEntity.Exempt1.Value = this.Exempt1.Value;
            if (!this.Exempt2.IsNull_flag) newEntity.Exempt2.Value = this.Exempt2.Value;
            if (!this.Exempt3.IsNull_flag) newEntity.Exempt3.Value = this.Exempt3.Value;
            if (!this.Exempt4.IsNull_flag) newEntity.Exempt4.Value = this.Exempt4.Value;
            if (!this.Exempt5.IsNull_flag) newEntity.Exempt5.Value = this.Exempt5.Value;
            if (!this.LastModifiedBy.IsNull_flag) newEntity.LastModifiedBy.Value = this.LastModifiedBy.Value;
            if (!this.ModifiedDateTime.IsNull_flag) newEntity.ModifiedDateTime.Value = this.ModifiedDateTime.Value;
            if (!this.CustodianID.IsNull_flag) newEntity.CustodianID.Value = this.CustodianID.Value;
            if (!this.ChargeBackFX.IsNull_flag) newEntity.ChargeBackFX.Value = this.ChargeBackFX.Value;
            if (!this.ClientBookNumber.IsNull_flag) newEntity.ClientBookNumber.Value = this.ClientBookNumber.Value;
            return newEntity;
        }

        public string ToXML()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("<Dividend_DTC_Position>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<DTC_PositionID>").Append(this.DTC_PositionID).Append("</DTC_PositionID>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<DividendIndex>").Append(this.DividendIndex.Value).Append("</DividendIndex>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<DTC_Number>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.DTC_Number.Value)).Append("</DTC_Number>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Company_Name>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.Company_Name.Value)).Append("</Company_Name>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Total_RecDate_Position>").Append(this.Total_RecDate_Position.Value).Append("</Total_RecDate_Position>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Rate_Position_1>").Append(this.Rate_Position_1.Value).Append("</Rate_Position_1>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Rate_Position_2>").Append(this.Rate_Position_2.Value).Append("</Rate_Position_2>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Rate_Position_3>").Append(this.Rate_Position_3.Value).Append("</Rate_Position_3>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Rate_Position_4>").Append(this.Rate_Position_4.Value).Append("</Rate_Position_4>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Rate_Position_5>").Append(this.Rate_Position_5.Value).Append("</Rate_Position_5>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Rate_Position_6>").Append(this.Rate_Position_6.Value).Append("</Rate_Position_6>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Rate_Position_7>").Append(this.Rate_Position_7.Value).Append("</Rate_Position_7>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Rate_Position_8>").Append(this.Rate_Position_8.Value).Append("</Rate_Position_8>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Rate_Position_9>").Append(this.Rate_Position_9.Value).Append("</Rate_Position_9>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Rate_Position_10>").Append(this.Rate_Position_10.Value).Append("</Rate_Position_10>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Rate_Position_11>").Append(this.Rate_Position_11.Value).Append("</Rate_Position_11>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Rate_Position_12>").Append(this.Rate_Position_12.Value).Append("</Rate_Position_12>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Rate_Position_13>").Append(this.Rate_Position_13.Value).Append("</Rate_Position_13>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Rate_Position_14>").Append(this.Rate_Position_14.Value).Append("</Rate_Position_14>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Rate_Position_15>").Append(this.Rate_Position_15.Value).Append("</Rate_Position_15>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Rate_Position_16>").Append(this.Rate_Position_16.Value).Append("</Rate_Position_16>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Rate_Position_17>").Append(this.Rate_Position_17.Value).Append("</Rate_Position_17>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Rate_Position_18>").Append(this.Rate_Position_18.Value).Append("</Rate_Position_18>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Rate_Chargeback_1>").Append(this.Rate_Chargeback_1.Value).Append("</Rate_Chargeback_1>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Rate_Chargeback_2>").Append(this.Rate_Chargeback_2.Value).Append("</Rate_Chargeback_2>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Rate_Chargeback_3>").Append(this.Rate_Chargeback_3.Value).Append("</Rate_Chargeback_3>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Rate_Chargeback_4>").Append(this.Rate_Chargeback_4.Value).Append("</Rate_Chargeback_4>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Rate_Chargeback_5>").Append(this.Rate_Chargeback_5.Value).Append("</Rate_Chargeback_5>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Rate_Chargeback_6>").Append(this.Rate_Chargeback_6.Value).Append("</Rate_Chargeback_6>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Rate_Chargeback_7>").Append(this.Rate_Chargeback_7.Value).Append("</Rate_Chargeback_7>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Rate_Chargeback_8>").Append(this.Rate_Chargeback_8.Value).Append("</Rate_Chargeback_8>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Rate_Chargeback_9>").Append(this.Rate_Chargeback_9.Value).Append("</Rate_Chargeback_9>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Rate_Chargeback_10>").Append(this.Rate_Chargeback_10.Value).Append("</Rate_Chargeback_10>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Rate_Chargeback_11>").Append(this.Rate_Chargeback_11.Value).Append("</Rate_Chargeback_11>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Rate_Chargeback_12>").Append(this.Rate_Chargeback_12.Value).Append("</Rate_Chargeback_12>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Rate_Chargeback_13>").Append(this.Rate_Chargeback_13.Value).Append("</Rate_Chargeback_13>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Rate_Chargeback_14>").Append(this.Rate_Chargeback_14.Value).Append("</Rate_Chargeback_14>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Rate_Chargeback_15>").Append(this.Rate_Chargeback_15.Value).Append("</Rate_Chargeback_15>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Rate_Chargeback_16>").Append(this.Rate_Chargeback_16.Value).Append("</Rate_Chargeback_16>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Rate_Chargeback_17>").Append(this.Rate_Chargeback_17.Value).Append("</Rate_Chargeback_17>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Rate_Chargeback_18>").Append(this.Rate_Chargeback_18.Value).Append("</Rate_Chargeback_18>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Exempt1>").Append(this.Exempt1.Value).Append("</Exempt1>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Exempt2>").Append(this.Exempt2.Value).Append("</Exempt2>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Exempt3>").Append(this.Exempt3.Value).Append("</Exempt3>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Exempt4>").Append(this.Exempt4.Value).Append("</Exempt4>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Exempt5>").Append(this.Exempt5.Value).Append("</Exempt5>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<LastModifiedBy>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.LastModifiedBy.Value)).Append("</LastModifiedBy>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<ModifiedDateTime>").Append(this.ModifiedDateTime.Value).Append("</ModifiedDateTime>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<CustodianID>").Append(this.CustodianID.Value).Append("</CustodianID>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<ChargeBackFX>").Append(this.ChargeBackFX.Value).Append("</ChargeBackFX>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<ClientBookNumber>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.ClientBookNumber.Value)).Append("</ClientBookNumber>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("</Dividend_DTC_Position>").Append(HssUtility.General.HssStr.WinNextLine);
            return sb.ToString();
        }
        /*^^^^^^^^^^^^^^^^^^^^^^^^^^^^^Hss Entity Framework Auto Generated Code^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^*/

        private Dictionary<string, HssUtility.General.Attributes.Decimal_attr> rate_values_dic = null;
        private void Create_rateValues_attrDic()
        {
            if (this.rate_values_dic != null) return;

            this.rate_values_dic = new Dictionary<string, HssUtility.General.Attributes.Decimal_attr>(StringComparer.OrdinalIgnoreCase);
            this.rate_values_dic.Add("Total_RecDate_Position", this.Total_RecDate_Position);/*Optional 5*/
            this.rate_values_dic.Add("Rate_Position_1", this.Rate_Position_1);/*Optional 6*/
            this.rate_values_dic.Add("Rate_Position_2", this.Rate_Position_2);/*Optional 7*/
            this.rate_values_dic.Add("Rate_Position_3", this.Rate_Position_3);/*Optional 8*/
            this.rate_values_dic.Add("Rate_Position_4", this.Rate_Position_4);/*Optional 9*/
            this.rate_values_dic.Add("Rate_Position_5", this.Rate_Position_5);/*Optional 10*/
            this.rate_values_dic.Add("Rate_Position_6", this.Rate_Position_6);/*Optional 11*/
            this.rate_values_dic.Add("Rate_Position_7", this.Rate_Position_7);/*Optional 12*/
            this.rate_values_dic.Add("Rate_Position_8", this.Rate_Position_8);/*Optional 13*/
            this.rate_values_dic.Add("Rate_Position_9", this.Rate_Position_9);/*Optional 14*/
            this.rate_values_dic.Add("Rate_Position_10", this.Rate_Position_10);/*Optional 15*/
            this.rate_values_dic.Add("Rate_Position_11", this.Rate_Position_11);/*Optional 16*/
            this.rate_values_dic.Add("Rate_Position_12", this.Rate_Position_12);/*Optional 17*/
            this.rate_values_dic.Add("Rate_Position_13", this.Rate_Position_13);/*Optional 18*/
            this.rate_values_dic.Add("Rate_Position_14", this.Rate_Position_14);/*Optional 19*/
            this.rate_values_dic.Add("Rate_Position_15", this.Rate_Position_15);/*Optional 20*/
            this.rate_values_dic.Add("Rate_Position_16", this.Rate_Position_16);/*Optional 21*/
            this.rate_values_dic.Add("Rate_Position_17", this.Rate_Position_17);/*Optional 22*/
            this.rate_values_dic.Add("Rate_Position_18", this.Rate_Position_18);/*Optional 23*/
            this.rate_values_dic.Add("Rate_Chargeback_1", this.Rate_Chargeback_1);/*Optional 24*/
            this.rate_values_dic.Add("Rate_Chargeback_2", this.Rate_Chargeback_2);/*Optional 25*/
            this.rate_values_dic.Add("Rate_Chargeback_3", this.Rate_Chargeback_3);/*Optional 26*/
            this.rate_values_dic.Add("Rate_Chargeback_4", this.Rate_Chargeback_4);/*Optional 27*/
            this.rate_values_dic.Add("Rate_Chargeback_5", this.Rate_Chargeback_5);/*Optional 28*/
            this.rate_values_dic.Add("Rate_Chargeback_6", this.Rate_Chargeback_6);/*Optional 29*/
            this.rate_values_dic.Add("Rate_Chargeback_7", this.Rate_Chargeback_7);/*Optional 30*/
            this.rate_values_dic.Add("Rate_Chargeback_8", this.Rate_Chargeback_8);/*Optional 31*/
            this.rate_values_dic.Add("Rate_Chargeback_9", this.Rate_Chargeback_9);/*Optional 32*/
            this.rate_values_dic.Add("Rate_Chargeback_10", this.Rate_Chargeback_10);/*Optional 33*/
            this.rate_values_dic.Add("Rate_Chargeback_11", this.Rate_Chargeback_11);/*Optional 34*/
            this.rate_values_dic.Add("Rate_Chargeback_12", this.Rate_Chargeback_12);/*Optional 35*/
            this.rate_values_dic.Add("Rate_Chargeback_13", this.Rate_Chargeback_13);/*Optional 36*/
            this.rate_values_dic.Add("Rate_Chargeback_14", this.Rate_Chargeback_14);/*Optional 37*/
            this.rate_values_dic.Add("Rate_Chargeback_15", this.Rate_Chargeback_15);/*Optional 38*/
            this.rate_values_dic.Add("Rate_Chargeback_16", this.Rate_Chargeback_16);/*Optional 39*/
            this.rate_values_dic.Add("Rate_Chargeback_17", this.Rate_Chargeback_17);/*Optional 40*/
            this.rate_values_dic.Add("Rate_Chargeback_18", this.Rate_Chargeback_18);/*Optional 41*/
            this.rate_values_dic.Add("Exempt1", this.Exempt1);/*Optional 42*/
            this.rate_values_dic.Add("Exempt2", this.Exempt2);/*Optional 43*/
            this.rate_values_dic.Add("Exempt3", this.Exempt3);/*Optional 44*/
            this.rate_values_dic.Add("Exempt4", this.Exempt4);/*Optional 45*/
            this.rate_values_dic.Add("Exempt5", this.Exempt5);/*Optional 46*/
            this.rate_values_dic.Add("ChargeBackFX", this.ChargeBackFX);/*Optional 50*/
        }

        /// <summary>
        /// Get the value based on column name
        /// </summary>
        /// <param name="colName">Total_RecDate_Position, Rate_position/chargeback_n, Exempt n, ChargeBackFX</param>
        public decimal GetRateValues(string colName)
        {
            this.Create_rateValues_attrDic();
            if (colName == null) return 0;

            if (this.rate_values_dic.ContainsKey(colName))
            {
                HssUtility.General.Attributes.Decimal_attr dAttr = this.rate_values_dic[colName];
                if (dAttr.IsNull_flag) return 0;
                else return dAttr.Value;
            }
            else return 0;
        }


    }
}
