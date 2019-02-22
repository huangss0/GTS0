using System.Collections.Generic;

namespace HssDARWIN.Models.Custodians
{
    public class DividendCustodian
    {
        /*-----------------------------Hss Entity Framework Auto Generated Code-------------------------------*/
        private static HssUtility.SQLserver.CmdTemplate DBcmd_TP = null;
        public static HssUtility.SQLserver.CmdTemplate Get_cmdTP()
        {
            if (DividendCustodian.DBcmd_TP != null) return DividendCustodian.DBcmd_TP;

            DividendCustodian.DBcmd_TP = new HssUtility.SQLserver.CmdTemplate();
            DividendCustodian.DBcmd_TP.tableName = "Dividend_Custodian";
            DividendCustodian.DBcmd_TP.schema = "dbo";

            DividendCustodian.DBcmd_TP.AddColumn("CustodianID");
            DividendCustodian.DBcmd_TP.AddColumn("Custodian_Number");/*Optional 2*/
            DividendCustodian.DBcmd_TP.AddColumn("DividendIndex");
            DividendCustodian.DBcmd_TP.AddColumn("Custodian");
            DividendCustodian.DBcmd_TP.AddColumn("Custodian_Reported");/*Optional 5*/
            DividendCustodian.DBcmd_TP.AddColumn("Custodian_Paid");/*Optional 6*/
            DividendCustodian.DBcmd_TP.AddColumn("FavAtSourceADRs");/*Optional 7*/
            DividendCustodian.DBcmd_TP.AddColumn("ExemptAtSourceADRs");/*Optional 8*/
            DividendCustodian.DBcmd_TP.AddColumn("FavTransparentEntityADRs");/*Optional 9*/
            DividendCustodian.DBcmd_TP.AddColumn("Custodian_Chargeback");/*Optional 10*/
            DividendCustodian.DBcmd_TP.AddColumn("SafeKeeping_AccountNum");/*Optional 11*/
            DividendCustodian.DBcmd_TP.AddColumn("Cash_Account_Number");/*Optional 12*/
            DividendCustodian.DBcmd_TP.AddColumn("Custodial_Fees");/*Optional 13*/
            DividendCustodian.DBcmd_TP.AddColumn("AtSourceFeePerShare");
            DividendCustodian.DBcmd_TP.AddColumn("Custodian_Type");/*Optional 15*/
            DividendCustodian.DBcmd_TP.AddColumn("Depositary");/*Optional 16*/
            DividendCustodian.DBcmd_TP.AddColumn("Currency");/*Optional 17*/
            DividendCustodian.DBcmd_TP.AddColumn("Base");/*Optional 18*/
            DividendCustodian.DBcmd_TP.AddColumn("Custodial_Percent");/*Optional 19*/
            DividendCustodian.DBcmd_TP.AddColumn("Maximum_Fees");/*Optional 20*/
            DividendCustodian.DBcmd_TP.AddColumn("Minimum_Fees");/*Optional 21*/
            DividendCustodian.DBcmd_TP.AddColumn("Contact_Name");/*Optional 22*/
            DividendCustodian.DBcmd_TP.AddColumn("Reference_Number");/*Optional 23*/
            DividendCustodian.DBcmd_TP.AddColumn("Address1");/*Optional 24*/
            DividendCustodian.DBcmd_TP.AddColumn("Address2");/*Optional 25*/
            DividendCustodian.DBcmd_TP.AddColumn("State");/*Optional 26*/
            DividendCustodian.DBcmd_TP.AddColumn("City");/*Optional 27*/
            DividendCustodian.DBcmd_TP.AddColumn("Zip");/*Optional 28*/
            DividendCustodian.DBcmd_TP.AddColumn("Comments");/*Optional 29*/
            DividendCustodian.DBcmd_TP.AddColumn("Email");/*Optional 30*/
            DividendCustodian.DBcmd_TP.AddColumn("Fax");/*Optional 31*/
            DividendCustodian.DBcmd_TP.AddColumn("Phone");/*Optional 32*/
            DividendCustodian.DBcmd_TP.AddColumn("Country");/*Optional 33*/
            DividendCustodian.DBcmd_TP.AddColumn("Primary_Contact");/*Optional 34*/
            DividendCustodian.DBcmd_TP.AddColumn("MasterFile");/*Optional 35*/
            DividendCustodian.DBcmd_TP.AddColumn("PDFFile");/*Optional 36*/
            DividendCustodian.DBcmd_TP.AddColumn("Paid_And_Locked");
            DividendCustodian.DBcmd_TP.AddColumn("Paid_And_Locked_DateTime");/*Optional 38*/
            DividendCustodian.DBcmd_TP.AddColumn("LastModifiedBy");/*Optional 39*/
            DividendCustodian.DBcmd_TP.AddColumn("Billed_Date");/*Optional 40*/
            DividendCustodian.DBcmd_TP.AddColumn("Paid_Date_Actual");/*Optional 41*/
            DividendCustodian.DBcmd_TP.AddColumn("JPResidenceAtSourceADRs");/*Optional 42*/
            DividendCustodian.DBcmd_TP.AddColumn("PSAFE");/*Optional 43*/
            DividendCustodian.DBcmd_TP.AddColumn("Election_Version");/*Optional 44*/
            DividendCustodian.DBcmd_TP.AddColumn("FavAtSourceADRs_RSH_Exclude");/*Optional 45*/
            DividendCustodian.DBcmd_TP.AddColumn("WriteOff");/*Optional 46*/
            DividendCustodian.DBcmd_TP.AddColumn("AffiliateRebate");/*Optional 47*/
            DividendCustodian.DBcmd_TP.AddColumn("ModifiedDateTime");/*Optional 48*/
            DividendCustodian.DBcmd_TP.AddColumn("Custodial_FeeID");/*Optional 49*/
            DividendCustodian.DBcmd_TP.AddColumn("FeeType");/*Optional 50*/
            DividendCustodian.DBcmd_TP.AddColumn("FavAtSourceADRs_Detail");/*Optional 51*/
            DividendCustodian.DBcmd_TP.AddColumn("RSH_Email_TimeStamp");/*Optional 52*/
            DividendCustodian.DBcmd_TP.AddColumn("Bal_Email_TimeStamp");/*Optional 53*/
            DividendCustodian.DBcmd_TP.AddColumn("CreatedDateTime");/*Optional 54*/
            DividendCustodian.DBcmd_TP.AddColumn("XBRL_ReferenceNumber");/*Optional 55*/

            return DividendCustodian.DBcmd_TP;
        }

        public DividendCustodian() { }
        public DividendCustodian(int id) { this.pk_ID = id; }

        private int pk_ID = -1; //primary key
        public int CustodianID { get { return this.pk_ID; } }

        public readonly HssUtility.General.Attributes.Int_attr Custodian_Number = new HssUtility.General.Attributes.Int_attr();/*Optional 2*/
        public readonly HssUtility.General.Attributes.Int_attr DividendIndex = new HssUtility.General.Attributes.Int_attr();
        public readonly HssUtility.General.Attributes.String_attr Custodian = new HssUtility.General.Attributes.String_attr();
        public readonly HssUtility.General.Attributes.Decimal_attr Custodian_Reported = new HssUtility.General.Attributes.Decimal_attr(0);/*Optional 5*/
        public readonly HssUtility.General.Attributes.Decimal_attr Custodian_Paid = new HssUtility.General.Attributes.Decimal_attr();/*Optional 6*/
        public readonly HssUtility.General.Attributes.Decimal_attr FavAtSourceADRs = new HssUtility.General.Attributes.Decimal_attr();/*Optional 7*/
        public readonly HssUtility.General.Attributes.Decimal_attr ExemptAtSourceADRs = new HssUtility.General.Attributes.Decimal_attr();/*Optional 8*/
        public readonly HssUtility.General.Attributes.Decimal_attr FavTransparentEntityADRs = new HssUtility.General.Attributes.Decimal_attr();/*Optional 9*/
        public readonly HssUtility.General.Attributes.Decimal_attr Custodian_Chargeback = new HssUtility.General.Attributes.Decimal_attr();/*Optional 10*/
        public readonly HssUtility.General.Attributes.String_attr SafeKeeping_AccountNum = new HssUtility.General.Attributes.String_attr();/*Optional 11*/
        public readonly HssUtility.General.Attributes.String_attr Cash_Account_Number = new HssUtility.General.Attributes.String_attr();/*Optional 12*/
        public readonly HssUtility.General.Attributes.Decimal_attr Custodial_Fees = new HssUtility.General.Attributes.Decimal_attr();/*Optional 13*/
        public readonly HssUtility.General.Attributes.Decimal_attr AtSourceFeePerShare = new HssUtility.General.Attributes.Decimal_attr();
        public readonly HssUtility.General.Attributes.String_attr Custodian_Type = new HssUtility.General.Attributes.String_attr();/*Optional 15*/
        public readonly HssUtility.General.Attributes.String_attr Depositary = new HssUtility.General.Attributes.String_attr();/*Optional 16*/
        public readonly HssUtility.General.Attributes.String_attr Currency = new HssUtility.General.Attributes.String_attr();/*Optional 17*/
        public readonly HssUtility.General.Attributes.Decimal_attr Base = new HssUtility.General.Attributes.Decimal_attr();/*Optional 18*/
        public readonly HssUtility.General.Attributes.Decimal_attr Custodial_Percent = new HssUtility.General.Attributes.Decimal_attr();/*Optional 19*/
        public readonly HssUtility.General.Attributes.Decimal_attr Maximum_Fees = new HssUtility.General.Attributes.Decimal_attr();/*Optional 20*/
        public readonly HssUtility.General.Attributes.Decimal_attr Minimum_Fees = new HssUtility.General.Attributes.Decimal_attr();/*Optional 21*/
        public readonly HssUtility.General.Attributes.String_attr Contact_Name = new HssUtility.General.Attributes.String_attr();/*Optional 22*/
        public readonly HssUtility.General.Attributes.String_attr Reference_Number = new HssUtility.General.Attributes.String_attr();/*Optional 23*/
        public readonly HssUtility.General.Attributes.String_attr Address1 = new HssUtility.General.Attributes.String_attr();/*Optional 24*/
        public readonly HssUtility.General.Attributes.String_attr Address2 = new HssUtility.General.Attributes.String_attr();/*Optional 25*/
        public readonly HssUtility.General.Attributes.String_attr State = new HssUtility.General.Attributes.String_attr();/*Optional 26*/
        public readonly HssUtility.General.Attributes.String_attr City = new HssUtility.General.Attributes.String_attr();/*Optional 27*/
        public readonly HssUtility.General.Attributes.String_attr Zip = new HssUtility.General.Attributes.String_attr();/*Optional 28*/
        public readonly HssUtility.General.Attributes.String_attr Comments = new HssUtility.General.Attributes.String_attr();/*Optional 29*/
        public readonly HssUtility.General.Attributes.String_attr Email = new HssUtility.General.Attributes.String_attr();/*Optional 30*/
        public readonly HssUtility.General.Attributes.String_attr Fax = new HssUtility.General.Attributes.String_attr();/*Optional 31*/
        public readonly HssUtility.General.Attributes.String_attr Phone = new HssUtility.General.Attributes.String_attr();/*Optional 32*/
        public readonly HssUtility.General.Attributes.String_attr Country = new HssUtility.General.Attributes.String_attr();/*Optional 33*/
        public readonly HssUtility.General.Attributes.Bool_attr Primary_Contact = new HssUtility.General.Attributes.Bool_attr();/*Optional 34*/
        public readonly HssUtility.General.Attributes.String_attr MasterFile = new HssUtility.General.Attributes.String_attr();/*Optional 35*/
        public readonly HssUtility.General.Attributes.String_attr PDFFile = new HssUtility.General.Attributes.String_attr();/*Optional 36*/
        public readonly HssUtility.General.Attributes.Bool_attr Paid_And_Locked = new HssUtility.General.Attributes.Bool_attr();
        public readonly HssUtility.General.Attributes.DateTime_attr Paid_And_Locked_DateTime = new HssUtility.General.Attributes.DateTime_attr();/*Optional 38*/
        public readonly HssUtility.General.Attributes.String_attr LastModifiedBy = new HssUtility.General.Attributes.String_attr();/*Optional 39*/
        public readonly HssUtility.General.Attributes.DateTime_attr Billed_Date = new HssUtility.General.Attributes.DateTime_attr();/*Optional 40*/
        public readonly HssUtility.General.Attributes.DateTime_attr Paid_Date_Actual = new HssUtility.General.Attributes.DateTime_attr();/*Optional 41*/
        public readonly HssUtility.General.Attributes.Decimal_attr JPResidenceAtSourceADRs = new HssUtility.General.Attributes.Decimal_attr();/*Optional 42*/
        public readonly HssUtility.General.Attributes.String_attr PSAFE = new HssUtility.General.Attributes.String_attr();/*Optional 43*/
        public readonly HssUtility.General.Attributes.Int_attr Election_Version = new HssUtility.General.Attributes.Int_attr();/*Optional 44*/
        public readonly HssUtility.General.Attributes.Decimal_attr FavAtSourceADRs_RSH_Exclude = new HssUtility.General.Attributes.Decimal_attr();/*Optional 45*/
        public readonly HssUtility.General.Attributes.String_attr WriteOff = new HssUtility.General.Attributes.String_attr();/*Optional 46*/
        public readonly HssUtility.General.Attributes.Decimal_attr AffiliateRebate = new HssUtility.General.Attributes.Decimal_attr();/*Optional 47*/
        public readonly HssUtility.General.Attributes.DateTime_attr ModifiedDateTime = new HssUtility.General.Attributes.DateTime_attr();/*Optional 48*/
        public readonly HssUtility.General.Attributes.Int_attr Custodial_FeeID = new HssUtility.General.Attributes.Int_attr();/*Optional 49*/
        public readonly HssUtility.General.Attributes.String_attr FeeType = new HssUtility.General.Attributes.String_attr();/*Optional 50*/
        public readonly HssUtility.General.Attributes.String_attr FavAtSourceADRs_Detail = new HssUtility.General.Attributes.String_attr();/*Optional 51*/
        public readonly HssUtility.General.Attributes.DateTime_attr RSH_Email_TimeStamp = new HssUtility.General.Attributes.DateTime_attr();/*Optional 52*/
        public readonly HssUtility.General.Attributes.DateTime_attr Bal_Email_TimeStamp = new HssUtility.General.Attributes.DateTime_attr();/*Optional 53*/
        public readonly HssUtility.General.Attributes.DateTime_attr CreatedDateTime = new HssUtility.General.Attributes.DateTime_attr();/*Optional 54*/
        public readonly HssUtility.General.Attributes.String_attr XBRL_ReferenceNumber = new HssUtility.General.Attributes.String_attr();/*Optional 55*/

        private List<HssUtility.General.Attributes.I_modelAttr> attrList = null;

        internal void Init_from_reader(HssUtility.SQLserver.DB_reader reader)
        {
            if (reader == null || reader.IsClosed) return;

            this.pk_ID = reader.GetInt("CustodianID");
            reader.GetInt("Custodian_Number", this.Custodian_Number);/*Optional 2*/
            reader.GetInt("DividendIndex", this.DividendIndex);
            reader.GetString("Custodian", this.Custodian);
            reader.GetDecimal("Custodian_Reported", this.Custodian_Reported);/*Optional 5*/
            reader.GetDecimal("Custodian_Paid", this.Custodian_Paid);/*Optional 6*/
            reader.GetDecimal("FavAtSourceADRs", this.FavAtSourceADRs);/*Optional 7*/
            reader.GetDecimal("ExemptAtSourceADRs", this.ExemptAtSourceADRs);/*Optional 8*/
            reader.GetDecimal("FavTransparentEntityADRs", this.FavTransparentEntityADRs);/*Optional 9*/
            reader.GetDecimal("Custodian_Chargeback", this.Custodian_Chargeback);/*Optional 10*/
            reader.GetString("SafeKeeping_AccountNum", this.SafeKeeping_AccountNum);/*Optional 11*/
            reader.GetString("Cash_Account_Number", this.Cash_Account_Number);/*Optional 12*/
            reader.GetDecimal("Custodial_Fees", this.Custodial_Fees);/*Optional 13*/
            reader.GetDecimal("AtSourceFeePerShare", this.AtSourceFeePerShare);
            reader.GetString("Custodian_Type", this.Custodian_Type);/*Optional 15*/
            reader.GetString("Depositary", this.Depositary);/*Optional 16*/
            reader.GetString("Currency", this.Currency);/*Optional 17*/
            reader.GetDecimal("Base", this.Base);/*Optional 18*/
            reader.GetDecimal("Custodial_Percent", this.Custodial_Percent);/*Optional 19*/
            reader.GetDecimal("Maximum_Fees", this.Maximum_Fees);/*Optional 20*/
            reader.GetDecimal("Minimum_Fees", this.Minimum_Fees);/*Optional 21*/
            reader.GetString("Contact_Name", this.Contact_Name);/*Optional 22*/
            reader.GetString("Reference_Number", this.Reference_Number);/*Optional 23*/
            reader.GetString("Address1", this.Address1);/*Optional 24*/
            reader.GetString("Address2", this.Address2);/*Optional 25*/
            reader.GetString("State", this.State);/*Optional 26*/
            reader.GetString("City", this.City);/*Optional 27*/
            reader.GetString("Zip", this.Zip);/*Optional 28*/
            reader.GetString("Comments", this.Comments);/*Optional 29*/
            reader.GetString("Email", this.Email);/*Optional 30*/
            reader.GetString("Fax", this.Fax);/*Optional 31*/
            reader.GetString("Phone", this.Phone);/*Optional 32*/
            reader.GetString("Country", this.Country);/*Optional 33*/
            reader.GetBool("Primary_Contact", this.Primary_Contact);/*Optional 34*/
            reader.GetString("MasterFile", this.MasterFile);/*Optional 35*/
            reader.GetString("PDFFile", this.PDFFile);/*Optional 36*/
            reader.GetBool("Paid_And_Locked", this.Paid_And_Locked);
            reader.GetDateTime("Paid_And_Locked_DateTime", this.Paid_And_Locked_DateTime);/*Optional 38*/
            reader.GetString("LastModifiedBy", this.LastModifiedBy);/*Optional 39*/
            reader.GetDateTime("Billed_Date", this.Billed_Date);/*Optional 40*/
            reader.GetDateTime("Paid_Date_Actual", this.Paid_Date_Actual);/*Optional 41*/
            reader.GetDecimal("JPResidenceAtSourceADRs", this.JPResidenceAtSourceADRs);/*Optional 42*/
            reader.GetString("PSAFE", this.PSAFE);/*Optional 43*/
            reader.GetInt("Election_Version", this.Election_Version);/*Optional 44*/
            reader.GetDecimal("FavAtSourceADRs_RSH_Exclude", this.FavAtSourceADRs_RSH_Exclude);/*Optional 45*/
            reader.GetString("WriteOff", this.WriteOff);/*Optional 46*/
            reader.GetDecimal("AffiliateRebate", this.AffiliateRebate);/*Optional 47*/
            reader.GetDateTime("ModifiedDateTime", this.ModifiedDateTime);/*Optional 48*/
            reader.GetInt("Custodial_FeeID", this.Custodial_FeeID);/*Optional 49*/
            reader.GetString("FeeType", this.FeeType);/*Optional 50*/
            reader.GetString("FavAtSourceADRs_Detail", this.FavAtSourceADRs_Detail);/*Optional 51*/
            reader.GetDateTime("RSH_Email_TimeStamp", this.RSH_Email_TimeStamp);/*Optional 52*/
            reader.GetDateTime("Bal_Email_TimeStamp", this.Bal_Email_TimeStamp);/*Optional 53*/
            reader.GetDateTime("CreatedDateTime", this.CreatedDateTime);/*Optional 54*/
            reader.GetString("XBRL_ReferenceNumber", this.XBRL_ReferenceNumber);/*Optional 55*/

            this.SyncWithDB();
        }

        public bool Init_from_DB()
        {
            if (this.CustodianID < 0) return false;

            HssUtility.SQLserver.DB_select db_sel = new HssUtility.SQLserver.DB_select(DividendCustodian.Get_cmdTP());
            db_sel.tableName = "Dividend_Custodian";
            HssUtility.SQLserver.SQL_relation rela = new HssUtility.SQLserver.SQL_relation("CustodianID", HssUtility.General.RelationalOperator.Equals, this.CustodianID);
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
            this.attrList.Add(this.Custodian_Number);/*Optional 2*/
            this.attrList.Add(this.DividendIndex);
            this.attrList.Add(this.Custodian);
            this.attrList.Add(this.Custodian_Reported);/*Optional 5*/
            this.attrList.Add(this.Custodian_Paid);/*Optional 6*/
            this.attrList.Add(this.FavAtSourceADRs);/*Optional 7*/
            this.attrList.Add(this.ExemptAtSourceADRs);/*Optional 8*/
            this.attrList.Add(this.FavTransparentEntityADRs);/*Optional 9*/
            this.attrList.Add(this.Custodian_Chargeback);/*Optional 10*/
            this.attrList.Add(this.SafeKeeping_AccountNum);/*Optional 11*/
            this.attrList.Add(this.Cash_Account_Number);/*Optional 12*/
            this.attrList.Add(this.Custodial_Fees);/*Optional 13*/
            this.attrList.Add(this.AtSourceFeePerShare);
            this.attrList.Add(this.Custodian_Type);/*Optional 15*/
            this.attrList.Add(this.Depositary);/*Optional 16*/
            this.attrList.Add(this.Currency);/*Optional 17*/
            this.attrList.Add(this.Base);/*Optional 18*/
            this.attrList.Add(this.Custodial_Percent);/*Optional 19*/
            this.attrList.Add(this.Maximum_Fees);/*Optional 20*/
            this.attrList.Add(this.Minimum_Fees);/*Optional 21*/
            this.attrList.Add(this.Contact_Name);/*Optional 22*/
            this.attrList.Add(this.Reference_Number);/*Optional 23*/
            this.attrList.Add(this.Address1);/*Optional 24*/
            this.attrList.Add(this.Address2);/*Optional 25*/
            this.attrList.Add(this.State);/*Optional 26*/
            this.attrList.Add(this.City);/*Optional 27*/
            this.attrList.Add(this.Zip);/*Optional 28*/
            this.attrList.Add(this.Comments);/*Optional 29*/
            this.attrList.Add(this.Email);/*Optional 30*/
            this.attrList.Add(this.Fax);/*Optional 31*/
            this.attrList.Add(this.Phone);/*Optional 32*/
            this.attrList.Add(this.Country);/*Optional 33*/
            this.attrList.Add(this.Primary_Contact);/*Optional 34*/
            this.attrList.Add(this.MasterFile);/*Optional 35*/
            this.attrList.Add(this.PDFFile);/*Optional 36*/
            this.attrList.Add(this.Paid_And_Locked);
            this.attrList.Add(this.Paid_And_Locked_DateTime);/*Optional 38*/
            this.attrList.Add(this.LastModifiedBy);/*Optional 39*/
            this.attrList.Add(this.Billed_Date);/*Optional 40*/
            this.attrList.Add(this.Paid_Date_Actual);/*Optional 41*/
            this.attrList.Add(this.JPResidenceAtSourceADRs);/*Optional 42*/
            this.attrList.Add(this.PSAFE);/*Optional 43*/
            this.attrList.Add(this.Election_Version);/*Optional 44*/
            this.attrList.Add(this.FavAtSourceADRs_RSH_Exclude);/*Optional 45*/
            this.attrList.Add(this.WriteOff);/*Optional 46*/
            this.attrList.Add(this.AffiliateRebate);/*Optional 47*/
            this.attrList.Add(this.ModifiedDateTime);/*Optional 48*/
            this.attrList.Add(this.Custodial_FeeID);/*Optional 49*/
            this.attrList.Add(this.FeeType);/*Optional 50*/
            this.attrList.Add(this.FavAtSourceADRs_Detail);/*Optional 51*/
            this.attrList.Add(this.RSH_Email_TimeStamp);/*Optional 52*/
            this.attrList.Add(this.Bal_Email_TimeStamp);/*Optional 53*/
            this.attrList.Add(this.CreatedDateTime);/*Optional 54*/
            this.attrList.Add(this.XBRL_ReferenceNumber);/*Optional 55*/
        }

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
            HssUtility.SQLserver.DB_insert dbIns = new HssUtility.SQLserver.DB_insert(DividendCustodian.Get_cmdTP());

            dbIns.AddValue("Custodian_Number", this.Custodian_Number);/*Optional 2*/
            dbIns.AddValue("DividendIndex", this.DividendIndex.Value);
            dbIns.AddValue("Custodian", this.Custodian.Value);
            dbIns.AddValue("Custodian_Reported", this.Custodian_Reported);/*Optional 5*/
            dbIns.AddValue("Custodian_Paid", this.Custodian_Paid);/*Optional 6*/
            dbIns.AddValue("FavAtSourceADRs", this.FavAtSourceADRs);/*Optional 7*/
            dbIns.AddValue("ExemptAtSourceADRs", this.ExemptAtSourceADRs);/*Optional 8*/
            dbIns.AddValue("FavTransparentEntityADRs", this.FavTransparentEntityADRs);/*Optional 9*/
            dbIns.AddValue("Custodian_Chargeback", this.Custodian_Chargeback);/*Optional 10*/
            dbIns.AddValue("SafeKeeping_AccountNum", this.SafeKeeping_AccountNum);/*Optional 11*/
            dbIns.AddValue("Cash_Account_Number", this.Cash_Account_Number);/*Optional 12*/
            dbIns.AddValue("Custodial_Fees", this.Custodial_Fees);/*Optional 13*/
            dbIns.AddValue("AtSourceFeePerShare", this.AtSourceFeePerShare.Value);
            dbIns.AddValue("Custodian_Type", this.Custodian_Type);/*Optional 15*/
            dbIns.AddValue("Depositary", this.Depositary);/*Optional 16*/
            dbIns.AddValue("Currency", this.Currency);/*Optional 17*/
            dbIns.AddValue("Base", this.Base);/*Optional 18*/
            dbIns.AddValue("Custodial_Percent", this.Custodial_Percent);/*Optional 19*/
            dbIns.AddValue("Maximum_Fees", this.Maximum_Fees);/*Optional 20*/
            dbIns.AddValue("Minimum_Fees", this.Minimum_Fees);/*Optional 21*/
            dbIns.AddValue("Contact_Name", this.Contact_Name);/*Optional 22*/
            dbIns.AddValue("Reference_Number", this.Reference_Number);/*Optional 23*/
            dbIns.AddValue("Address1", this.Address1);/*Optional 24*/
            dbIns.AddValue("Address2", this.Address2);/*Optional 25*/
            dbIns.AddValue("State", this.State);/*Optional 26*/
            dbIns.AddValue("City", this.City);/*Optional 27*/
            dbIns.AddValue("Zip", this.Zip);/*Optional 28*/
            dbIns.AddValue("Comments", this.Comments);/*Optional 29*/
            dbIns.AddValue("Email", this.Email);/*Optional 30*/
            dbIns.AddValue("Fax", this.Fax);/*Optional 31*/
            dbIns.AddValue("Phone", this.Phone);/*Optional 32*/
            dbIns.AddValue("Country", this.Country);/*Optional 33*/
            dbIns.AddValue("Primary_Contact", this.Primary_Contact);/*Optional 34*/
            dbIns.AddValue("MasterFile", this.MasterFile);/*Optional 35*/
            dbIns.AddValue("PDFFile", this.PDFFile);/*Optional 36*/
            dbIns.AddValue("Paid_And_Locked", this.Paid_And_Locked.Value);
            dbIns.AddValue("Paid_And_Locked_DateTime", this.Paid_And_Locked_DateTime);/*Optional 38*/
            dbIns.AddValue("LastModifiedBy", this.LastModifiedBy);/*Optional 39*/
            dbIns.AddValue("Billed_Date", this.Billed_Date);/*Optional 40*/
            dbIns.AddValue("Paid_Date_Actual", this.Paid_Date_Actual);/*Optional 41*/
            dbIns.AddValue("JPResidenceAtSourceADRs", this.JPResidenceAtSourceADRs);/*Optional 42*/
            dbIns.AddValue("PSAFE", this.PSAFE);/*Optional 43*/
            dbIns.AddValue("Election_Version", this.Election_Version);/*Optional 44*/
            dbIns.AddValue("FavAtSourceADRs_RSH_Exclude", this.FavAtSourceADRs_RSH_Exclude);/*Optional 45*/
            dbIns.AddValue("WriteOff", this.WriteOff);/*Optional 46*/
            dbIns.AddValue("AffiliateRebate", this.AffiliateRebate);/*Optional 47*/
            dbIns.AddValue("ModifiedDateTime", this.ModifiedDateTime);/*Optional 48*/
            dbIns.AddValue("Custodial_FeeID", this.Custodial_FeeID);/*Optional 49*/
            dbIns.AddValue("FeeType", this.FeeType);/*Optional 50*/
            dbIns.AddValue("FavAtSourceADRs_Detail", this.FavAtSourceADRs_Detail);/*Optional 51*/
            dbIns.AddValue("RSH_Email_TimeStamp", this.RSH_Email_TimeStamp);/*Optional 52*/
            dbIns.AddValue("Bal_Email_TimeStamp", this.Bal_Email_TimeStamp);/*Optional 53*/
            dbIns.AddValue("CreatedDateTime", this.CreatedDateTime);/*Optional 54*/
            dbIns.AddValue("XBRL_ReferenceNumber", this.XBRL_ReferenceNumber);/*Optional 55*/

            return dbIns;
        }

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

            HssUtility.SQLserver.DB_update upd = new HssUtility.SQLserver.DB_update(DividendCustodian.Get_cmdTP());
            if (this.Custodian_Number.ValueChanged) upd.AddValue("Custodian_Number", this.Custodian_Number);
            if (this.DividendIndex.ValueChanged) upd.AddValue("DividendIndex", this.DividendIndex);
            if (this.Custodian.ValueChanged) upd.AddValue("Custodian", this.Custodian);
            if (this.Custodian_Reported.ValueChanged) upd.AddValue("Custodian_Reported", this.Custodian_Reported);
            if (this.Custodian_Paid.ValueChanged) upd.AddValue("Custodian_Paid", this.Custodian_Paid);
            if (this.FavAtSourceADRs.ValueChanged) upd.AddValue("FavAtSourceADRs", this.FavAtSourceADRs);
            if (this.ExemptAtSourceADRs.ValueChanged) upd.AddValue("ExemptAtSourceADRs", this.ExemptAtSourceADRs);
            if (this.FavTransparentEntityADRs.ValueChanged) upd.AddValue("FavTransparentEntityADRs", this.FavTransparentEntityADRs);
            if (this.Custodian_Chargeback.ValueChanged) upd.AddValue("Custodian_Chargeback", this.Custodian_Chargeback);
            if (this.SafeKeeping_AccountNum.ValueChanged) upd.AddValue("SafeKeeping_AccountNum", this.SafeKeeping_AccountNum);
            if (this.Cash_Account_Number.ValueChanged) upd.AddValue("Cash_Account_Number", this.Cash_Account_Number);
            if (this.Custodial_Fees.ValueChanged) upd.AddValue("Custodial_Fees", this.Custodial_Fees);
            if (this.AtSourceFeePerShare.ValueChanged) upd.AddValue("AtSourceFeePerShare", this.AtSourceFeePerShare);
            if (this.Custodian_Type.ValueChanged) upd.AddValue("Custodian_Type", this.Custodian_Type);
            if (this.Depositary.ValueChanged) upd.AddValue("Depositary", this.Depositary);
            if (this.Currency.ValueChanged) upd.AddValue("Currency", this.Currency);
            if (this.Base.ValueChanged) upd.AddValue("Base", this.Base);
            if (this.Custodial_Percent.ValueChanged) upd.AddValue("Custodial_Percent", this.Custodial_Percent);
            if (this.Maximum_Fees.ValueChanged) upd.AddValue("Maximum_Fees", this.Maximum_Fees);
            if (this.Minimum_Fees.ValueChanged) upd.AddValue("Minimum_Fees", this.Minimum_Fees);
            if (this.Contact_Name.ValueChanged) upd.AddValue("Contact_Name", this.Contact_Name);
            if (this.Reference_Number.ValueChanged) upd.AddValue("Reference_Number", this.Reference_Number);
            if (this.Address1.ValueChanged) upd.AddValue("Address1", this.Address1);
            if (this.Address2.ValueChanged) upd.AddValue("Address2", this.Address2);
            if (this.State.ValueChanged) upd.AddValue("State", this.State);
            if (this.City.ValueChanged) upd.AddValue("City", this.City);
            if (this.Zip.ValueChanged) upd.AddValue("Zip", this.Zip);
            if (this.Comments.ValueChanged) upd.AddValue("Comments", this.Comments);
            if (this.Email.ValueChanged) upd.AddValue("Email", this.Email);
            if (this.Fax.ValueChanged) upd.AddValue("Fax", this.Fax);
            if (this.Phone.ValueChanged) upd.AddValue("Phone", this.Phone);
            if (this.Country.ValueChanged) upd.AddValue("Country", this.Country);
            if (this.Primary_Contact.ValueChanged) upd.AddValue("Primary_Contact", this.Primary_Contact);
            if (this.MasterFile.ValueChanged) upd.AddValue("MasterFile", this.MasterFile);
            if (this.PDFFile.ValueChanged) upd.AddValue("PDFFile", this.PDFFile);
            if (this.Paid_And_Locked.ValueChanged) upd.AddValue("Paid_And_Locked", this.Paid_And_Locked);
            if (this.Paid_And_Locked_DateTime.ValueChanged) upd.AddValue("Paid_And_Locked_DateTime", this.Paid_And_Locked_DateTime);
            if (this.LastModifiedBy.ValueChanged) upd.AddValue("LastModifiedBy", this.LastModifiedBy);
            if (this.Billed_Date.ValueChanged) upd.AddValue("Billed_Date", this.Billed_Date);
            if (this.Paid_Date_Actual.ValueChanged) upd.AddValue("Paid_Date_Actual", this.Paid_Date_Actual);
            if (this.JPResidenceAtSourceADRs.ValueChanged) upd.AddValue("JPResidenceAtSourceADRs", this.JPResidenceAtSourceADRs);
            if (this.PSAFE.ValueChanged) upd.AddValue("PSAFE", this.PSAFE);
            if (this.Election_Version.ValueChanged) upd.AddValue("Election_Version", this.Election_Version);
            if (this.FavAtSourceADRs_RSH_Exclude.ValueChanged) upd.AddValue("FavAtSourceADRs_RSH_Exclude", this.FavAtSourceADRs_RSH_Exclude);
            if (this.WriteOff.ValueChanged) upd.AddValue("WriteOff", this.WriteOff);
            if (this.AffiliateRebate.ValueChanged) upd.AddValue("AffiliateRebate", this.AffiliateRebate);
            if (this.ModifiedDateTime.ValueChanged) upd.AddValue("ModifiedDateTime", this.ModifiedDateTime);
            if (this.Custodial_FeeID.ValueChanged) upd.AddValue("Custodial_FeeID", this.Custodial_FeeID);
            if (this.FeeType.ValueChanged) upd.AddValue("FeeType", this.FeeType);
            if (this.FavAtSourceADRs_Detail.ValueChanged) upd.AddValue("FavAtSourceADRs_Detail", this.FavAtSourceADRs_Detail);
            if (this.RSH_Email_TimeStamp.ValueChanged) upd.AddValue("RSH_Email_TimeStamp", this.RSH_Email_TimeStamp);
            if (this.Bal_Email_TimeStamp.ValueChanged) upd.AddValue("Bal_Email_TimeStamp", this.Bal_Email_TimeStamp);
            if (this.CreatedDateTime.ValueChanged) upd.AddValue("CreatedDateTime", this.CreatedDateTime);
            if (this.XBRL_ReferenceNumber.ValueChanged) upd.AddValue("XBRL_ReferenceNumber", this.XBRL_ReferenceNumber);

            HssUtility.SQLserver.SQL_relation rela = new HssUtility.SQLserver.SQL_relation("CustodianID", HssUtility.General.RelationalOperator.Equals, this.pk_ID);
            upd.SetCondition(rela);

            return upd;
        }

        public DividendCustodian GetCopy()
        {
            DividendCustodian newEntity = new DividendCustodian();
            if (!this.Custodian_Number.IsNull_flag) newEntity.Custodian_Number.Value = this.Custodian_Number.Value;
            if (!this.DividendIndex.IsNull_flag) newEntity.DividendIndex.Value = this.DividendIndex.Value;
            if (!this.Custodian.IsNull_flag) newEntity.Custodian.Value = this.Custodian.Value;
            if (!this.Custodian_Reported.IsNull_flag) newEntity.Custodian_Reported.Value = this.Custodian_Reported.Value;
            if (!this.Custodian_Paid.IsNull_flag) newEntity.Custodian_Paid.Value = this.Custodian_Paid.Value;
            if (!this.FavAtSourceADRs.IsNull_flag) newEntity.FavAtSourceADRs.Value = this.FavAtSourceADRs.Value;
            if (!this.ExemptAtSourceADRs.IsNull_flag) newEntity.ExemptAtSourceADRs.Value = this.ExemptAtSourceADRs.Value;
            if (!this.FavTransparentEntityADRs.IsNull_flag) newEntity.FavTransparentEntityADRs.Value = this.FavTransparentEntityADRs.Value;
            if (!this.Custodian_Chargeback.IsNull_flag) newEntity.Custodian_Chargeback.Value = this.Custodian_Chargeback.Value;
            if (!this.SafeKeeping_AccountNum.IsNull_flag) newEntity.SafeKeeping_AccountNum.Value = this.SafeKeeping_AccountNum.Value;
            if (!this.Cash_Account_Number.IsNull_flag) newEntity.Cash_Account_Number.Value = this.Cash_Account_Number.Value;
            if (!this.Custodial_Fees.IsNull_flag) newEntity.Custodial_Fees.Value = this.Custodial_Fees.Value;
            if (!this.AtSourceFeePerShare.IsNull_flag) newEntity.AtSourceFeePerShare.Value = this.AtSourceFeePerShare.Value;
            if (!this.Custodian_Type.IsNull_flag) newEntity.Custodian_Type.Value = this.Custodian_Type.Value;
            if (!this.Depositary.IsNull_flag) newEntity.Depositary.Value = this.Depositary.Value;
            if (!this.Currency.IsNull_flag) newEntity.Currency.Value = this.Currency.Value;
            if (!this.Base.IsNull_flag) newEntity.Base.Value = this.Base.Value;
            if (!this.Custodial_Percent.IsNull_flag) newEntity.Custodial_Percent.Value = this.Custodial_Percent.Value;
            if (!this.Maximum_Fees.IsNull_flag) newEntity.Maximum_Fees.Value = this.Maximum_Fees.Value;
            if (!this.Minimum_Fees.IsNull_flag) newEntity.Minimum_Fees.Value = this.Minimum_Fees.Value;
            if (!this.Contact_Name.IsNull_flag) newEntity.Contact_Name.Value = this.Contact_Name.Value;
            if (!this.Reference_Number.IsNull_flag) newEntity.Reference_Number.Value = this.Reference_Number.Value;
            if (!this.Address1.IsNull_flag) newEntity.Address1.Value = this.Address1.Value;
            if (!this.Address2.IsNull_flag) newEntity.Address2.Value = this.Address2.Value;
            if (!this.State.IsNull_flag) newEntity.State.Value = this.State.Value;
            if (!this.City.IsNull_flag) newEntity.City.Value = this.City.Value;
            if (!this.Zip.IsNull_flag) newEntity.Zip.Value = this.Zip.Value;
            if (!this.Comments.IsNull_flag) newEntity.Comments.Value = this.Comments.Value;
            if (!this.Email.IsNull_flag) newEntity.Email.Value = this.Email.Value;
            if (!this.Fax.IsNull_flag) newEntity.Fax.Value = this.Fax.Value;
            if (!this.Phone.IsNull_flag) newEntity.Phone.Value = this.Phone.Value;
            if (!this.Country.IsNull_flag) newEntity.Country.Value = this.Country.Value;
            if (!this.Primary_Contact.IsNull_flag) newEntity.Primary_Contact.Value = this.Primary_Contact.Value;
            if (!this.MasterFile.IsNull_flag) newEntity.MasterFile.Value = this.MasterFile.Value;
            if (!this.PDFFile.IsNull_flag) newEntity.PDFFile.Value = this.PDFFile.Value;
            if (!this.Paid_And_Locked.IsNull_flag) newEntity.Paid_And_Locked.Value = this.Paid_And_Locked.Value;
            if (!this.Paid_And_Locked_DateTime.IsNull_flag) newEntity.Paid_And_Locked_DateTime.Value = this.Paid_And_Locked_DateTime.Value;
            if (!this.LastModifiedBy.IsNull_flag) newEntity.LastModifiedBy.Value = this.LastModifiedBy.Value;
            if (!this.Billed_Date.IsNull_flag) newEntity.Billed_Date.Value = this.Billed_Date.Value;
            if (!this.Paid_Date_Actual.IsNull_flag) newEntity.Paid_Date_Actual.Value = this.Paid_Date_Actual.Value;
            if (!this.JPResidenceAtSourceADRs.IsNull_flag) newEntity.JPResidenceAtSourceADRs.Value = this.JPResidenceAtSourceADRs.Value;
            if (!this.PSAFE.IsNull_flag) newEntity.PSAFE.Value = this.PSAFE.Value;
            if (!this.Election_Version.IsNull_flag) newEntity.Election_Version.Value = this.Election_Version.Value;
            if (!this.FavAtSourceADRs_RSH_Exclude.IsNull_flag) newEntity.FavAtSourceADRs_RSH_Exclude.Value = this.FavAtSourceADRs_RSH_Exclude.Value;
            if (!this.WriteOff.IsNull_flag) newEntity.WriteOff.Value = this.WriteOff.Value;
            if (!this.AffiliateRebate.IsNull_flag) newEntity.AffiliateRebate.Value = this.AffiliateRebate.Value;
            if (!this.ModifiedDateTime.IsNull_flag) newEntity.ModifiedDateTime.Value = this.ModifiedDateTime.Value;
            if (!this.Custodial_FeeID.IsNull_flag) newEntity.Custodial_FeeID.Value = this.Custodial_FeeID.Value;
            if (!this.FeeType.IsNull_flag) newEntity.FeeType.Value = this.FeeType.Value;
            if (!this.FavAtSourceADRs_Detail.IsNull_flag) newEntity.FavAtSourceADRs_Detail.Value = this.FavAtSourceADRs_Detail.Value;
            if (!this.RSH_Email_TimeStamp.IsNull_flag) newEntity.RSH_Email_TimeStamp.Value = this.RSH_Email_TimeStamp.Value;
            if (!this.Bal_Email_TimeStamp.IsNull_flag) newEntity.Bal_Email_TimeStamp.Value = this.Bal_Email_TimeStamp.Value;
            if (!this.CreatedDateTime.IsNull_flag) newEntity.CreatedDateTime.Value = this.CreatedDateTime.Value;
            if (!this.XBRL_ReferenceNumber.IsNull_flag) newEntity.XBRL_ReferenceNumber.Value = this.XBRL_ReferenceNumber.Value;
            return newEntity;
        }
        /*^^^^^^^^^^^^^^^^^^^^^^^^^^^^^Hss Entity Framework Auto Generated Code^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^*/

        public string Get_custodian_fullName()
        {
            Custodian cust = CustodianMaster.GetCustodian_num(this.Custodian_Number.Value);
            if (cust == null) return this.Custodian.Value;
            else return cust.Custodian_FullName.Value;
        }
    }
}
