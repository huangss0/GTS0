using System.Text;
using System.Collections.Generic;

namespace HssDARWIN.Models.FX_payment
{
    public class FX_Input
    {
        /*-----------------------------Hss Entity Framework Auto Generated Code-------------------------------*/
        private static HssUtility.SQLserver.CmdTemplate DBcmd_TP = null;
        public static HssUtility.SQLserver.CmdTemplate Get_cmdTP()
        {
            if (FX_Input.DBcmd_TP != null) return FX_Input.DBcmd_TP;

            FX_Input.DBcmd_TP = new HssUtility.SQLserver.CmdTemplate();
            FX_Input.DBcmd_TP.tableName = "FX_Input";
            FX_Input.DBcmd_TP.schema = "dbo";

            FX_Input.DBcmd_TP.AddColumn("FX_InputID");
            FX_Input.DBcmd_TP.AddColumn("CountryName");/*Optional 2*/
            FX_Input.DBcmd_TP.AddColumn("Custodian");/*Optional 3*/
            FX_Input.DBcmd_TP.AddColumn("AccountNumber");/*Optional 4*/
            FX_Input.DBcmd_TP.AddColumn("Currency_Code");/*Optional 5*/
            FX_Input.DBcmd_TP.AddColumn("FX_NotificationDate");/*Optional 6*/
            FX_Input.DBcmd_TP.AddColumn("LocalAmountReceived");/*Optional 7*/
            FX_Input.DBcmd_TP.AddColumn("Depositary_ReceivedDate");/*Optional 8*/
            FX_Input.DBcmd_TP.AddColumn("FX_RequestedDate");/*Optional 9*/
            FX_Input.DBcmd_TP.AddColumn("FX_ReceivedDate");/*Optional 10*/
            FX_Input.DBcmd_TP.AddColumn("Depositary");/*Optional 11*/
            FX_Input.DBcmd_TP.AddColumn("FX_Rate");/*Optional 12*/
            FX_Input.DBcmd_TP.AddColumn("USDAmountReceived");/*Optional 13*/
            FX_Input.DBcmd_TP.AddColumn("ActualCheckRequestDate");/*Optional 14*/
            FX_Input.DBcmd_TP.AddColumn("PayToBrokerDate");/*Optional 15*/
            FX_Input.DBcmd_TP.AddColumn("LastModifiedBy");/*Optional 16*/
            FX_Input.DBcmd_TP.AddColumn("ModifiedDateTime");/*Optional 17*/
            FX_Input.DBcmd_TP.AddColumn("Forex_Fee");/*Optional 18*/

            return FX_Input.DBcmd_TP;
        }

        public FX_Input() { }
        public FX_Input(int id) { this.pk_ID = id; }

        private int pk_ID = -1; //primary key
        public int FX_InputID { get { return this.pk_ID; } }

        public readonly HssUtility.General.Attributes.String_attr CountryName = new HssUtility.General.Attributes.String_attr();/*Optional 2*/
        public readonly HssUtility.General.Attributes.String_attr Custodian = new HssUtility.General.Attributes.String_attr();/*Optional 3*/
        public readonly HssUtility.General.Attributes.String_attr AccountNumber = new HssUtility.General.Attributes.String_attr();/*Optional 4*/
        public readonly HssUtility.General.Attributes.String_attr Currency_Code = new HssUtility.General.Attributes.String_attr();/*Optional 5*/
        public readonly HssUtility.General.Attributes.DateTime_attr FX_NotificationDate = new HssUtility.General.Attributes.DateTime_attr();/*Optional 6*/
        public readonly HssUtility.General.Attributes.Decimal_attr LocalAmountReceived = new HssUtility.General.Attributes.Decimal_attr();/*Optional 7*/
        public readonly HssUtility.General.Attributes.DateTime_attr Depositary_ReceivedDate = new HssUtility.General.Attributes.DateTime_attr();/*Optional 8*/
        public readonly HssUtility.General.Attributes.DateTime_attr FX_RequestedDate = new HssUtility.General.Attributes.DateTime_attr();/*Optional 9*/
        public readonly HssUtility.General.Attributes.DateTime_attr FX_ReceivedDate = new HssUtility.General.Attributes.DateTime_attr();/*Optional 10*/
        public readonly HssUtility.General.Attributes.String_attr Depositary = new HssUtility.General.Attributes.String_attr();/*Optional 11*/
        public readonly HssUtility.General.Attributes.Decimal_attr FX_Rate = new HssUtility.General.Attributes.Decimal_attr();/*Optional 12*/
        public readonly HssUtility.General.Attributes.Decimal_attr USDAmountReceived = new HssUtility.General.Attributes.Decimal_attr();/*Optional 13*/
        public readonly HssUtility.General.Attributes.DateTime_attr ActualCheckRequestDate = new HssUtility.General.Attributes.DateTime_attr();/*Optional 14*/
        public readonly HssUtility.General.Attributes.DateTime_attr PayToBrokerDate = new HssUtility.General.Attributes.DateTime_attr();/*Optional 15*/
        public readonly HssUtility.General.Attributes.String_attr LastModifiedBy = new HssUtility.General.Attributes.String_attr();/*Optional 16*/
        public readonly HssUtility.General.Attributes.DateTime_attr ModifiedDateTime = new HssUtility.General.Attributes.DateTime_attr();/*Optional 17*/
        public readonly HssUtility.General.Attributes.Decimal_attr Forex_Fee = new HssUtility.General.Attributes.Decimal_attr();/*Optional 18*/

        private List<HssUtility.General.Attributes.I_modelAttr> attrList = null;

        internal void Init_from_reader(HssUtility.SQLserver.DB_reader reader)
        {
            if (reader == null || reader.IsClosed) return;

            this.pk_ID = reader.GetInt("FX_InputID");
            reader.GetString("CountryName", this.CountryName);/*Optional 2*/
            reader.GetString("Custodian", this.Custodian);/*Optional 3*/
            reader.GetString("AccountNumber", this.AccountNumber);/*Optional 4*/
            reader.GetString("Currency_Code", this.Currency_Code);/*Optional 5*/
            reader.GetDateTime("FX_NotificationDate", this.FX_NotificationDate);/*Optional 6*/
            reader.GetDecimal("LocalAmountReceived", this.LocalAmountReceived);/*Optional 7*/
            reader.GetDateTime("Depositary_ReceivedDate", this.Depositary_ReceivedDate);/*Optional 8*/
            reader.GetDateTime("FX_RequestedDate", this.FX_RequestedDate);/*Optional 9*/
            reader.GetDateTime("FX_ReceivedDate", this.FX_ReceivedDate);/*Optional 10*/
            reader.GetString("Depositary", this.Depositary);/*Optional 11*/
            reader.GetDecimal("FX_Rate", this.FX_Rate);/*Optional 12*/
            reader.GetDecimal("USDAmountReceived", this.USDAmountReceived);/*Optional 13*/
            reader.GetDateTime("ActualCheckRequestDate", this.ActualCheckRequestDate);/*Optional 14*/
            reader.GetDateTime("PayToBrokerDate", this.PayToBrokerDate);/*Optional 15*/
            reader.GetString("LastModifiedBy", this.LastModifiedBy);/*Optional 16*/
            reader.GetDateTime("ModifiedDateTime", this.ModifiedDateTime);/*Optional 17*/
            reader.GetDecimal("Forex_Fee", this.Forex_Fee);/*Optional 18*/

            this.SyncWithDB();
        }

        /// <summary>
        /// Initialize object from DB
        /// </summary>
        public bool Init_from_DB()
        {
            if (this.FX_InputID < 0) return false;

            HssUtility.SQLserver.DB_select db_sel = new HssUtility.SQLserver.DB_select(FX_Input.Get_cmdTP());
            db_sel.tableName = "FX_Input";
            HssUtility.SQLserver.SQL_relation rela = new HssUtility.SQLserver.SQL_relation("FX_InputID", HssUtility.General.RelationalOperator.Equals, this.FX_InputID);
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
            this.Create_attrList();
            foreach (HssUtility.General.Attributes.I_modelAttr ma in this.attrList) ma.SyncWithDB();
        }

        public bool CheckValueChanges()
        {
            this.Create_attrList();
            foreach (HssUtility.General.Attributes.I_modelAttr ma in this.attrList) if (ma.ValueChanged) return true;
            return false;
        }

        private void Create_attrList()
        {
            if (this.attrList != null) return;

            this.attrList = new List<HssUtility.General.Attributes.I_modelAttr>();
            this.attrList.Add(this.CountryName);/*Optional 2*/
            this.attrList.Add(this.Custodian);/*Optional 3*/
            this.attrList.Add(this.AccountNumber);/*Optional 4*/
            this.attrList.Add(this.Currency_Code);/*Optional 5*/
            this.attrList.Add(this.FX_NotificationDate);/*Optional 6*/
            this.attrList.Add(this.LocalAmountReceived);/*Optional 7*/
            this.attrList.Add(this.Depositary_ReceivedDate);/*Optional 8*/
            this.attrList.Add(this.FX_RequestedDate);/*Optional 9*/
            this.attrList.Add(this.FX_ReceivedDate);/*Optional 10*/
            this.attrList.Add(this.Depositary);/*Optional 11*/
            this.attrList.Add(this.FX_Rate);/*Optional 12*/
            this.attrList.Add(this.USDAmountReceived);/*Optional 13*/
            this.attrList.Add(this.ActualCheckRequestDate);/*Optional 14*/
            this.attrList.Add(this.PayToBrokerDate);/*Optional 15*/
            this.attrList.Add(this.LastModifiedBy);/*Optional 16*/
            this.attrList.Add(this.ModifiedDateTime);/*Optional 17*/
            this.attrList.Add(this.Forex_Fee);/*Optional 18*/
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
            HssUtility.SQLserver.DB_insert dbIns = new HssUtility.SQLserver.DB_insert(FX_Input.Get_cmdTP());

            dbIns.AddValue("CountryName", this.CountryName);/*Optional 2*/
            dbIns.AddValue("Custodian", this.Custodian);/*Optional 3*/
            dbIns.AddValue("AccountNumber", this.AccountNumber);/*Optional 4*/
            dbIns.AddValue("Currency_Code", this.Currency_Code);/*Optional 5*/
            dbIns.AddValue("FX_NotificationDate", this.FX_NotificationDate);/*Optional 6*/
            dbIns.AddValue("LocalAmountReceived", this.LocalAmountReceived);/*Optional 7*/
            dbIns.AddValue("Depositary_ReceivedDate", this.Depositary_ReceivedDate);/*Optional 8*/
            dbIns.AddValue("FX_RequestedDate", this.FX_RequestedDate);/*Optional 9*/
            dbIns.AddValue("FX_ReceivedDate", this.FX_ReceivedDate);/*Optional 10*/
            dbIns.AddValue("Depositary", this.Depositary);/*Optional 11*/
            dbIns.AddValue("FX_Rate", this.FX_Rate);/*Optional 12*/
            dbIns.AddValue("USDAmountReceived", this.USDAmountReceived);/*Optional 13*/
            dbIns.AddValue("ActualCheckRequestDate", this.ActualCheckRequestDate);/*Optional 14*/
            dbIns.AddValue("PayToBrokerDate", this.PayToBrokerDate);/*Optional 15*/
            dbIns.AddValue("LastModifiedBy", this.LastModifiedBy);/*Optional 16*/
            dbIns.AddValue("ModifiedDateTime", this.ModifiedDateTime);/*Optional 17*/
            dbIns.AddValue("Forex_Fee", this.Forex_Fee);/*Optional 18*/

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

            HssUtility.SQLserver.DB_update upd = new HssUtility.SQLserver.DB_update(FX_Input.Get_cmdTP());
            if (this.CountryName.ValueChanged) upd.AddValue("CountryName", this.CountryName);
            if (this.Custodian.ValueChanged) upd.AddValue("Custodian", this.Custodian);
            if (this.AccountNumber.ValueChanged) upd.AddValue("AccountNumber", this.AccountNumber);
            if (this.Currency_Code.ValueChanged) upd.AddValue("Currency_Code", this.Currency_Code);
            if (this.FX_NotificationDate.ValueChanged) upd.AddValue("FX_NotificationDate", this.FX_NotificationDate);
            if (this.LocalAmountReceived.ValueChanged) upd.AddValue("LocalAmountReceived", this.LocalAmountReceived);
            if (this.Depositary_ReceivedDate.ValueChanged) upd.AddValue("Depositary_ReceivedDate", this.Depositary_ReceivedDate);
            if (this.FX_RequestedDate.ValueChanged) upd.AddValue("FX_RequestedDate", this.FX_RequestedDate);
            if (this.FX_ReceivedDate.ValueChanged) upd.AddValue("FX_ReceivedDate", this.FX_ReceivedDate);
            if (this.Depositary.ValueChanged) upd.AddValue("Depositary", this.Depositary);
            if (this.FX_Rate.ValueChanged) upd.AddValue("FX_Rate", this.FX_Rate);
            if (this.USDAmountReceived.ValueChanged) upd.AddValue("USDAmountReceived", this.USDAmountReceived);
            if (this.ActualCheckRequestDate.ValueChanged) upd.AddValue("ActualCheckRequestDate", this.ActualCheckRequestDate);
            if (this.PayToBrokerDate.ValueChanged) upd.AddValue("PayToBrokerDate", this.PayToBrokerDate);
            if (this.LastModifiedBy.ValueChanged) upd.AddValue("LastModifiedBy", this.LastModifiedBy);
            if (this.ModifiedDateTime.ValueChanged) upd.AddValue("ModifiedDateTime", this.ModifiedDateTime);
            if (this.Forex_Fee.ValueChanged) upd.AddValue("Forex_Fee", this.Forex_Fee);

            HssUtility.SQLserver.SQL_relation rela = new HssUtility.SQLserver.SQL_relation("FX_InputID", HssUtility.General.RelationalOperator.Equals, this.pk_ID);
            upd.SetCondition(rela);

            return upd;
        }

        public FX_Input GetCopy()
        {
            FX_Input newEntity = new FX_Input();
            if (!this.CountryName.IsNull_flag) newEntity.CountryName.Value = this.CountryName.Value;
            if (!this.Custodian.IsNull_flag) newEntity.Custodian.Value = this.Custodian.Value;
            if (!this.AccountNumber.IsNull_flag) newEntity.AccountNumber.Value = this.AccountNumber.Value;
            if (!this.Currency_Code.IsNull_flag) newEntity.Currency_Code.Value = this.Currency_Code.Value;
            if (!this.FX_NotificationDate.IsNull_flag) newEntity.FX_NotificationDate.Value = this.FX_NotificationDate.Value;
            if (!this.LocalAmountReceived.IsNull_flag) newEntity.LocalAmountReceived.Value = this.LocalAmountReceived.Value;
            if (!this.Depositary_ReceivedDate.IsNull_flag) newEntity.Depositary_ReceivedDate.Value = this.Depositary_ReceivedDate.Value;
            if (!this.FX_RequestedDate.IsNull_flag) newEntity.FX_RequestedDate.Value = this.FX_RequestedDate.Value;
            if (!this.FX_ReceivedDate.IsNull_flag) newEntity.FX_ReceivedDate.Value = this.FX_ReceivedDate.Value;
            if (!this.Depositary.IsNull_flag) newEntity.Depositary.Value = this.Depositary.Value;
            if (!this.FX_Rate.IsNull_flag) newEntity.FX_Rate.Value = this.FX_Rate.Value;
            if (!this.USDAmountReceived.IsNull_flag) newEntity.USDAmountReceived.Value = this.USDAmountReceived.Value;
            if (!this.ActualCheckRequestDate.IsNull_flag) newEntity.ActualCheckRequestDate.Value = this.ActualCheckRequestDate.Value;
            if (!this.PayToBrokerDate.IsNull_flag) newEntity.PayToBrokerDate.Value = this.PayToBrokerDate.Value;
            if (!this.LastModifiedBy.IsNull_flag) newEntity.LastModifiedBy.Value = this.LastModifiedBy.Value;
            if (!this.ModifiedDateTime.IsNull_flag) newEntity.ModifiedDateTime.Value = this.ModifiedDateTime.Value;
            if (!this.Forex_Fee.IsNull_flag) newEntity.Forex_Fee.Value = this.Forex_Fee.Value;
            return newEntity;
        }

        public string ToXML()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("<FX_Input>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<FX_InputID>").Append(this.FX_InputID).Append("</FX_InputID>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<CountryName>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.CountryName.Value)).Append("</CountryName>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Custodian>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.Custodian.Value)).Append("</Custodian>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<AccountNumber>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.AccountNumber.Value)).Append("</AccountNumber>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Currency_Code>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.Currency_Code.Value)).Append("</Currency_Code>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<FX_NotificationDate>").Append(this.FX_NotificationDate.Value).Append("</FX_NotificationDate>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<LocalAmountReceived>").Append(this.LocalAmountReceived.Value).Append("</LocalAmountReceived>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Depositary_ReceivedDate>").Append(this.Depositary_ReceivedDate.Value).Append("</Depositary_ReceivedDate>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<FX_RequestedDate>").Append(this.FX_RequestedDate.Value).Append("</FX_RequestedDate>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<FX_ReceivedDate>").Append(this.FX_ReceivedDate.Value).Append("</FX_ReceivedDate>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Depositary>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.Depositary.Value)).Append("</Depositary>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<FX_Rate>").Append(this.FX_Rate.Value).Append("</FX_Rate>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<USDAmountReceived>").Append(this.USDAmountReceived.Value).Append("</USDAmountReceived>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<ActualCheckRequestDate>").Append(this.ActualCheckRequestDate.Value).Append("</ActualCheckRequestDate>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<PayToBrokerDate>").Append(this.PayToBrokerDate.Value).Append("</PayToBrokerDate>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<LastModifiedBy>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.LastModifiedBy.Value)).Append("</LastModifiedBy>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<ModifiedDateTime>").Append(this.ModifiedDateTime.Value).Append("</ModifiedDateTime>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Forex_Fee>").Append(this.Forex_Fee.Value).Append("</Forex_Fee>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("</FX_Input>").Append(HssUtility.General.HssStr.WinNextLine);
            return sb.ToString();
        }
        /*^^^^^^^^^^^^^^^^^^^^^^^^^^^^^Hss Entity Framework Auto Generated Code^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^*/

        private bool locked_flag = true;
        public bool Locked { get { return this.locked_flag; } }
        internal void SetLockFlag(bool val) { this.locked_flag = val; }

        public List<Dividend_Payment> dp_list = null;
        public bool RecheckLocked()
        {
            this.dp_list = DividendPaymentMaster.GetPayments_FX(this.FX_InputID);

            this.locked_flag = true;
            foreach (Dividend_Payment dp in this.dp_list)
            {
                if (!dp.Paid_And_Locked.Value)
                {
                    this.locked_flag = false;
                    break;
                }
            }
            return this.locked_flag;
        }
    }
}
