using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HssDARWIN.Models.Details
{
    public class Dividend_Detail_simple1
    {
        private static HssUtility.SQLserver.CmdTemplate DBcmd_TP = null;
        public static HssUtility.SQLserver.CmdTemplate Get_cmdTP()
        {
            if (Dividend_Detail_simple1.DBcmd_TP != null) return Dividend_Detail_simple1.DBcmd_TP;

            Dividend_Detail_simple1.DBcmd_TP = new HssUtility.SQLserver.CmdTemplate();
            Dividend_Detail_simple1.DBcmd_TP.tableName = "Dividend_Detail";
            Dividend_Detail_simple1.DBcmd_TP.schema = "dbo";

            Dividend_Detail_simple1.DBcmd_TP.AddColumn("DetailID");
            Dividend_Detail_simple1.DBcmd_TP.AddColumn("DividendIndex");
            Dividend_Detail_simple1.DBcmd_TP.AddColumn("ClaimID");/*Optional 3*/
            Dividend_Detail_simple1.DBcmd_TP.AddColumn("Issue");
            Dividend_Detail_simple1.DBcmd_TP.AddColumn("DTC_Number");
            Dividend_Detail_simple1.DBcmd_TP.AddColumn("DTC_Name");/*Optional 6*/
            Dividend_Detail_simple1.DBcmd_TP.AddColumn("DTC_Address1");/*Optional 7*/
            Dividend_Detail_simple1.DBcmd_TP.AddColumn("DTC_Address2");/*Optional 8*/
            Dividend_Detail_simple1.DBcmd_TP.AddColumn("DTC_ATTN");/*Optional 9*/
            Dividend_Detail_simple1.DBcmd_TP.AddColumn("Depositary");/*Optional 10*/
            Dividend_Detail_simple1.DBcmd_TP.AddColumn("DTC_PositionID");/*Optional 11*/
            Dividend_Detail_simple1.DBcmd_TP.AddColumn("BoName");/*Optional 12*/
            Dividend_Detail_simple1.DBcmd_TP.AddColumn("BoAddress1");/*Optional 13*/
            Dividend_Detail_simple1.DBcmd_TP.AddColumn("BoAddress2");/*Optional 14*/
            Dividend_Detail_simple1.DBcmd_TP.AddColumn("BoAddress3");/*Optional 15*/
            Dividend_Detail_simple1.DBcmd_TP.AddColumn("BoAddress4");/*Optional 16*/
            Dividend_Detail_simple1.DBcmd_TP.AddColumn("BoAddress5");/*Optional 17*/
            Dividend_Detail_simple1.DBcmd_TP.AddColumn("BO_COR");/*Optional 18*/
            Dividend_Detail_simple1.DBcmd_TP.AddColumn("BO_EntityType");/*Optional 19*/
            Dividend_Detail_simple1.DBcmd_TP.AddColumn("BoTaxID");/*Optional 20*/
            Dividend_Detail_simple1.DBcmd_TP.AddColumn("ReceivedDate");/*Optional 21*/
            Dividend_Detail_simple1.DBcmd_TP.AddColumn("ReclaimRate");/*Optional 22*/
            Dividend_Detail_simple1.DBcmd_TP.AddColumn("ClaimType");/*Optional 23*/
            Dividend_Detail_simple1.DBcmd_TP.AddColumn("Custodian");/*Optional 24*/
            Dividend_Detail_simple1.DBcmd_TP.AddColumn("CustodianID");/*Optional 25*/
            Dividend_Detail_simple1.DBcmd_TP.AddColumn("ReclaimAmount");/*Optional 26*/
            Dividend_Detail_simple1.DBcmd_TP.AddColumn("Status");/*Optional 27*/
            Dividend_Detail_simple1.DBcmd_TP.AddColumn("CreatedDate");/*Optional 28*/
            Dividend_Detail_simple1.DBcmd_TP.AddColumn("PaymentReferenceDate");/*Optional 29*/
            Dividend_Detail_simple1.DBcmd_TP.AddColumn("RecordDatePosition");/*Optional 30*/
            Dividend_Detail_simple1.DBcmd_TP.AddColumn("Internal_Ref_Number");/*Optional 31*/
            Dividend_Detail_simple1.DBcmd_TP.AddColumn("Internal_Batch_Num");/*Optional 32*/
            Dividend_Detail_simple1.DBcmd_TP.AddColumn("External_Client_Ref_Num");/*Optional 33*/
            Dividend_Detail_simple1.DBcmd_TP.AddColumn("External_Claim_Ref_Num");/*Optional 34*/
            Dividend_Detail_simple1.DBcmd_TP.AddColumn("External_Batch_Num");/*Optional 35*/
            Dividend_Detail_simple1.DBcmd_TP.AddColumn("Notes");/*Optional 36*/
            Dividend_Detail_simple1.DBcmd_TP.AddColumn("Dividend_FilingID");/*Optional 37*/
            Dividend_Detail_simple1.DBcmd_TP.AddColumn("Dividend_PayID");/*Optional 38*/
            Dividend_Detail_simple1.DBcmd_TP.AddColumn("CurrentMode");/*Optional 39*/
            Dividend_Detail_simple1.DBcmd_TP.AddColumn("Editor");/*Optional 40*/
            Dividend_Detail_simple1.DBcmd_TP.AddColumn("ReclaimFeesType");/*Optional 41*/
            Dividend_Detail_simple1.DBcmd_TP.AddColumn("Filing_Reference_Number");/*Optional 42*/
            Dividend_Detail_simple1.DBcmd_TP.AddColumn("ModifiedDateTime");/*Optional 43*/
            Dividend_Detail_simple1.DBcmd_TP.AddColumn("LastModifiedBy");/*Optional 44*/
            Dividend_Detail_simple1.DBcmd_TP.AddColumn("External_Service_Provider_Name");/*Optional 45*/
            Dividend_Detail_simple1.DBcmd_TP.AddColumn("NewRow");
            Dividend_Detail_simple1.DBcmd_TP.AddColumn("Override_Fees");/*Optional 47*/
            Dividend_Detail_simple1.DBcmd_TP.AddColumn("Residency_Percent");/*Optional 48*/
            Dividend_Detail_simple1.DBcmd_TP.AddColumn("EST_Time_To_Pay");/*Optional 49*/
            Dividend_Detail_simple1.DBcmd_TP.AddColumn("Override_Rate");/*Optional 50*/
            Dividend_Detail_simple1.DBcmd_TP.AddColumn("Override_Custodial_Fees");/*Optional 51*/
            Dividend_Detail_simple1.DBcmd_TP.AddColumn("EntityType_France");/*Optional 52*/
            Dividend_Detail_simple1.DBcmd_TP.AddColumn("Interest_Paid_EUR");/*Optional 53*/
            Dividend_Detail_simple1.DBcmd_TP.AddColumn("Custodial_Ref_Num");/*Optional 54*/
            Dividend_Detail_simple1.DBcmd_TP.AddColumn("Custodial_Report_Date");/*Optional 55*/
            Dividend_Detail_simple1.DBcmd_TP.AddColumn("Custodial_Report_Status");/*Optional 56*/
            Dividend_Detail_simple1.DBcmd_TP.AddColumn("LawOfEstablishment");/*Optional 57*/
            Dividend_Detail_simple1.DBcmd_TP.AddColumn("CERT");/*Optional 58*/
            Dividend_Detail_simple1.DBcmd_TP.AddColumn("Validation");/*Optional 59*/
            Dividend_Detail_simple1.DBcmd_TP.AddColumn("Validation_Reason");/*Optional 60*/
            Dividend_Detail_simple1.DBcmd_TP.AddColumn("Broker_BO_Name");/*Optional 61*/
            Dividend_Detail_simple1.DBcmd_TP.AddColumn("Paid_And_Locked");/*Optional 62*/
            Dividend_Detail_simple1.DBcmd_TP.AddColumn("Category");/*Optional 63*/
            Dividend_Detail_simple1.DBcmd_TP.AddColumn("Name_Of_Underlying_Holder");/*Optional 64*/
            Dividend_Detail_simple1.DBcmd_TP.AddColumn("Entity_Name");/*Optional 65*/
            Dividend_Detail_simple1.DBcmd_TP.AddColumn("PercentOfShares_Held_UH");/*Optional 66*/
            Dividend_Detail_simple1.DBcmd_TP.AddColumn("RSHID");/*Optional 67*/
            Dividend_Detail_simple1.DBcmd_TP.AddColumn("ParentID");/*Optional 68*/
            Dividend_Detail_simple1.DBcmd_TP.AddColumn("ThreadID");/*Optional 69*/
            Dividend_Detail_simple1.DBcmd_TP.AddColumn("ESPAccountNumber");/*Optional 70*/
            Dividend_Detail_simple1.DBcmd_TP.AddColumn("Tier");/*Optional 71*/
            Dividend_Detail_simple1.DBcmd_TP.AddColumn("Tier2AccountNumber");/*Optional 72*/
            Dividend_Detail_simple1.DBcmd_TP.AddColumn("Tier3AccountNumber");/*Optional 73*/
            Dividend_Detail_simple1.DBcmd_TP.AddColumn("Tier4AccountNumber");/*Optional 74*/
            Dividend_Detail_simple1.DBcmd_TP.AddColumn("Tier5AccountNumber");/*Optional 75*/
            Dividend_Detail_simple1.DBcmd_TP.AddColumn("ClientID");
            Dividend_Detail_simple1.DBcmd_TP.AddColumn("Designated");/*Optional 77*/
            Dividend_Detail_simple1.DBcmd_TP.AddColumn("PID");
            Dividend_Detail_simple1.DBcmd_TP.AddColumn("BOIndex");/*Optional 79*/
            Dividend_Detail_simple1.DBcmd_TP.AddColumn("TotalParticipants");/*Optional 80*/
            Dividend_Detail_simple1.DBcmd_TP.AddColumn("TotalTreatyParticipants");/*Optional 81*/
            Dividend_Detail_simple1.DBcmd_TP.AddColumn("DateOfFiscalYearEnd");/*Optional 82*/
            Dividend_Detail_simple1.DBcmd_TP.AddColumn("RejectReasons");/*Optional 83*/
            Dividend_Detail_simple1.DBcmd_TP.AddColumn("Tier6AccountNumber");/*Optional 84*/
            Dividend_Detail_simple1.DBcmd_TP.AddColumn("Tier7AccountNumber");/*Optional 85*/
            Dividend_Detail_simple1.DBcmd_TP.AddColumn("BoEmail");/*Optional 86*/
            Dividend_Detail_simple1.DBcmd_TP.AddColumn("BOAccountNumber");/*Optional 87*/
            Dividend_Detail_simple1.DBcmd_TP.AddColumn("StatusDate");/*Optional 88*/
            Dividend_Detail_simple1.DBcmd_TP.AddColumn("RejectParty");/*Optional 89*/
            Dividend_Detail_simple1.DBcmd_TP.AddColumn("AuditDeadline");/*Optional 90*/
            Dividend_Detail_simple1.DBcmd_TP.AddColumn("ExtensionRequested");/*Optional 91*/
            Dividend_Detail_simple1.DBcmd_TP.AddColumn("ExtensionDeadline");/*Optional 92*/
            Dividend_Detail_simple1.DBcmd_TP.AddColumn("ElectionOption");/*Optional 93*/
            Dividend_Detail_simple1.DBcmd_TP.AddColumn("DocStatus_ESP");/*Optional 94*/
            Dividend_Detail_simple1.DBcmd_TP.AddColumn("DocStatus");/*Optional 95*/
            Dividend_Detail_simple1.DBcmd_TP.AddColumn("boclient_id");/*Optional 96*/
            Dividend_Detail_simple1.DBcmd_TP.AddColumn("pension_plan");/*Optional 97*/
            Dividend_Detail_simple1.DBcmd_TP.AddColumn("VoucherStatus");/*Optional 98*/
            Dividend_Detail_simple1.DBcmd_TP.AddColumn("VoucherDate");/*Optional 99*/
            Dividend_Detail_simple1.DBcmd_TP.AddColumn("LocalMarketID");/*Optional 100*/
            Dividend_Detail_simple1.DBcmd_TP.AddColumn("Dividend_RejectionID");/*Optional 101*/
            Dividend_Detail_simple1.DBcmd_TP.AddColumn("Depositary_Fees_USD_Locked");/*Optional 102*/
            Dividend_Detail_simple1.DBcmd_TP.AddColumn("Custodial_Fees_EUR_Locked");/*Optional 103*/
            Dividend_Detail_simple1.DBcmd_TP.AddColumn("Custodial_Fees_USD_Locked");/*Optional 104*/
            Dividend_Detail_simple1.DBcmd_TP.AddColumn("Net_Amount_Paid_USD_Locked");/*Optional 105*/
            Dividend_Detail_simple1.DBcmd_TP.AddColumn("Net_Amount_Paid_EUR_Locked");/*Optional 106*/
            Dividend_Detail_simple1.DBcmd_TP.AddColumn("BoBirthDate");/*Optional 107*/
            //Dividend_Detail_simple1.DBcmd_TP.AddColumn("BoLastName");/*Optional 108*/
            //Dividend_Detail_simple1.DBcmd_TP.AddColumn("BoFirstName");/*Optional 109*/
            //Dividend_Detail_simple1.DBcmd_TP.AddColumn("ClientListingID");/*Optional 110*/
            //Dividend_Detail_simple1.DBcmd_TP.AddColumn("BoData");/*Optional 111*/
            //Dividend_Detail_simple1.DBcmd_TP.AddColumn("Status_Detail");/*Optional 112*/
            //Dividend_Detail_simple1.DBcmd_TP.AddColumn("Doc_Deadline");/*Optional 113*/
            //Dividend_Detail_simple1.DBcmd_TP.AddColumn("Kenmerk_Number");/*Optional 114*/
            //Dividend_Detail_simple1.DBcmd_TP.AddColumn("Kenmerk_Status");/*Optional 115*/
            //Dividend_Detail_simple1.DBcmd_TP.AddColumn("Kenmerk_Status_Date");/*Optional 116*/
            //Dividend_Detail_simple1.DBcmd_TP.AddColumn("FileLinking_Status");/*Optional 117*/
            //Dividend_Detail_simple1.DBcmd_TP.AddColumn("Filing_Attempts");/*Optional 118*/
            //Dividend_Detail_simple1.DBcmd_TP.AddColumn("Kenmerk_Status_Reason");/*Optional 119*/
            //Dividend_Detail_simple1.DBcmd_TP.AddColumn("PaidViaDTCC");/*Optional 120*/
            //Dividend_Detail_simple1.DBcmd_TP.AddColumn("COI");/*Optional 121*/
            //Dividend_Detail_simple1.DBcmd_TP.AddColumn("Par_ID");/*Optional 122*/
            Dividend_Detail_simple1.DBcmd_TP.AddColumn("Depositary_FeesA_USD_Locked");/*Optional 123*/
            //Dividend_Detail_simple1.DBcmd_TP.AddColumn("Payment_Cycle");/*Optional 124*/
            //Dividend_Detail_simple1.DBcmd_TP.AddColumn("Payment_Cycle_DateTime");/*Optional 125*/
            //Dividend_Detail_simple1.DBcmd_TP.AddColumn("StatusUpdatedBy");/*Optional 126*/
            //Dividend_Detail_simple1.DBcmd_TP.AddColumn("FundISIN");/*Optional 127*/
            //Dividend_Detail_simple1.DBcmd_TP.AddColumn("PurchaseDate");/*Optional 128*/
            //Dividend_Detail_simple1.DBcmd_TP.AddColumn("ORDNUNGS_NR");/*Optional 129*/
            //Dividend_Detail_simple1.DBcmd_TP.AddColumn("NewBoTaxID");/*Optional 130*/
            //Dividend_Detail_simple1.DBcmd_TP.AddColumn("AuditStatus");/*Optional 131*/
            //Dividend_Detail_simple1.DBcmd_TP.AddColumn("AuditStatusDate");/*Optional 132*/

            return Dividend_Detail_simple1.DBcmd_TP;
        }

        public int DetailID = -1;
        public int DividendIndex = -1;
        public long ClaimID = -1;
        public string Issue = null;
        public string DTC_Number = null;
        public string DTC_Name = null;
        public string DTC_Address1 = null;
        public string DTC_Address2 = null;
        public string DTC_ATTN = null;
        public string Depositary = null;
        public int DTC_PositionID = -1;
        public string BoName = null;
        public string BoAddress1 = null;
        public string BoAddress2 = null;
        public string BoAddress3 = null;
        public string BoAddress4 = null;
        public string BoAddress5 = null;
        public string BO_COR = null;
        public string BO_EntityType = null;
        public string BoTaxID = null;
        public DateTime ReceivedDate = Utility.MinDate;
        public decimal ReclaimRate = 0;
        public decimal ClaimType = 0;
        public string Custodian = null;
        public int CustodianID = -1;
        public decimal ReclaimAmount = 0;
        public string Status = null;
        public DateTime CreatedDate = Utility.MinDate;
        public DateTime PaymentReferenceDate = Utility.MinDate;
        public decimal RecordDatePosition = 0;
        public string Internal_Ref_Number = null;
        public string Internal_Batch_Num = null;
        public string External_Client_Ref_Num = null;
        public string External_Claim_Ref_Num = null;
        public string External_Batch_Num = null;
        public string Notes = null;
        public int Dividend_FilingID = -1;
        public int Dividend_PayID = -1;
        public string CurrentMode = null;
        public string Editor = null;
        public string ReclaimFeesType = null;
        public string Filing_Reference_Number = null;
        public DateTime ModifiedDateTime = Utility.MinDate;
        public string LastModifiedBy = null;
        public string External_Service_Provider_Name = null;
        public bool NewRow = false;
        public decimal Override_Fees = 0;
        public decimal Residency_Percent = 0;
        public int EST_Time_To_Pay = -1;
        public bool Override_Rate = false;
        public decimal Override_Custodial_Fees = 0;
        public string EntityType_France = null;
        public decimal Interest_Paid_EUR = 0;
        public string Custodial_Ref_Num = null;
        public DateTime Custodial_Report_Date = Utility.MinDate;
        public string Custodial_Report_Status = null;
        public string LawOfEstablishment = null;
        public bool CERT = false;
        public string Validation = null;
        public string Validation_Reason = null;
        public string Broker_BO_Name = null;
        public bool Paid_And_Locked = false;
        public string Category = null;
        public string Name_Of_Underlying_Holder = null;
        public string Entity_Name = null;
        public decimal PercentOfShares_Held_UH = 0;
        public int RSHID = -1;
        public string ParentID = null;
        public string ThreadID = null;
        public string ESPAccountNumber = null;
        public int Tier = -1;
        public string Tier2AccountNumber = null;
        public string Tier3AccountNumber = null;
        public string Tier4AccountNumber = null;
        public string Tier5AccountNumber = null;
        public int ClientID = -1;
        public bool Designated = false;
        public int PID = -1;
        public int BOIndex = -1;
        public int TotalParticipants = -1;
        public int TotalTreatyParticipants = -1;
        public DateTime DateOfFiscalYearEnd = Utility.MinDate;
        public string RejectReasons = null;
        public string Tier6AccountNumber = null;
        public string Tier7AccountNumber = null;
        public string BoEmail = null;
        public string BOAccountNumber = null;
        public DateTime StatusDate = Utility.MinDate;
        public string RejectParty = null;
        public DateTime AuditDeadline = Utility.MinDate;
        public bool ExtensionRequested = false;
        public DateTime ExtensionDeadline = Utility.MinDate;
        public string ElectionOption = null;
        public int DocStatus_ESP = -1;
        public string DocStatus = null;
        public int boclient_id = -1;
        public string pension_plan = null;
        public string VoucherStatus = null;
        public DateTime VoucherDate = Utility.MinDate;
        public string LocalMarketID = null;
        public int Dividend_RejectionID = -1;
        public decimal Depositary_Fees_USD_Locked = 0;
        public decimal Custodial_Fees_EUR_Locked = 0;
        public decimal Custodial_Fees_USD_Locked = 0;
        public decimal Net_Amount_Paid_USD_Locked = 0;
        public decimal Net_Amount_Paid_EUR_Locked = 0;
        public DateTime BoBirthDate = Utility.MinDate;
        public DateTime FiledDate = Utility.MinDate;//not in template
        public string Master_Reference_Number = null;//not in template
        public string Reference_Number = null;//not in template
        public decimal Depositary_FeesA_USD_Locked = 0;
        public string FedEx_Number = null;//not in template

        internal void Init_from_reader(HssUtility.SQLserver.DB_reader reader)
        {
            if (reader == null || reader.IsClosed) return;

            this.DetailID = reader.GetInt("DetailID");
            this.DividendIndex = reader.GetInt("DividendIndex");
            this.ClaimID = reader.GetLong("ClaimID");/*Optional 3*/
            this.Issue = reader.GetString("Issue");
            this.DTC_Number = reader.GetString("DTC_Number");
            this.DTC_Name = reader.GetString("DTC_Name");/*Optional 6*/
            this.DTC_Address1 = reader.GetString("DTC_Address1");/*Optional 7*/
            this.DTC_Address2 = reader.GetString("DTC_Address2");/*Optional 8*/
            this.DTC_ATTN = reader.GetString("DTC_ATTN");/*Optional 9*/
            this.Depositary = reader.GetString("Depositary");/*Optional 10*/
            this.DTC_PositionID = reader.GetInt("DTC_PositionID");/*Optional 11*/
            this.BoName = reader.GetString("BoName");/*Optional 12*/
            this.BoAddress1 = reader.GetString("BoAddress1");/*Optional 13*/
            this.BoAddress2 = reader.GetString("BoAddress2");/*Optional 14*/
            this.BoAddress3 = reader.GetString("BoAddress3");/*Optional 15*/
            this.BoAddress4 = reader.GetString("BoAddress4");/*Optional 16*/
            this.BoAddress5 = reader.GetString("BoAddress5");/*Optional 17*/
            this.BO_COR = reader.GetString("BO_COR");/*Optional 18*/
            this.BO_EntityType = reader.GetString("BO_EntityType");/*Optional 19*/
            this.BoTaxID = reader.GetString("BoTaxID");/*Optional 20*/
            this.ReceivedDate = reader.GetDateTime("ReceivedDate");/*Optional 21*/
            this.ReclaimRate = reader.GetDecimal("ReclaimRate");/*Optional 22*/
            reader.GetDecimal("ClaimType");/*Optional 23*/
            reader.GetString("Custodian");/*Optional 24*/
            reader.GetInt("CustodianID");/*Optional 25*/
            reader.GetDecimal("ReclaimAmount");/*Optional 26*/
            reader.GetString("Status");/*Optional 27*/
            reader.GetDateTime("CreatedDate");/*Optional 28*/
            reader.GetDateTime("PaymentReferenceDate");/*Optional 29*/
            reader.GetDecimal("RecordDatePosition");/*Optional 30*/
            reader.GetString("Internal_Ref_Number");/*Optional 31*/
            reader.GetString("Internal_Batch_Num");/*Optional 32*/
            reader.GetString("External_Client_Ref_Num");/*Optional 33*/
            reader.GetString("External_Claim_Ref_Num");/*Optional 34*/
            reader.GetString("External_Batch_Num");/*Optional 35*/
            reader.GetString("Notes");/*Optional 36*/
            reader.GetInt("Dividend_FilingID");/*Optional 37*/
            reader.GetInt("Dividend_PayID");/*Optional 38*/
            reader.GetString("CurrentMode");/*Optional 39*/
            reader.GetString("Editor");/*Optional 40*/
            reader.GetString("ReclaimFeesType");/*Optional 41*/
            reader.GetString("Filing_Reference_Number");/*Optional 42*/
            reader.GetDateTime("ModifiedDateTime");/*Optional 43*/
            reader.GetString("LastModifiedBy");/*Optional 44*/
            reader.GetString("External_Service_Provider_Name");/*Optional 45*/
            reader.GetBool("NewRow");
            reader.GetDecimal("Override_Fees");/*Optional 47*/
            reader.GetDecimal("Residency_Percent");/*Optional 48*/
            reader.GetInt("EST_Time_To_Pay");/*Optional 49*/
            reader.GetBool("Override_Rate");/*Optional 50*/
            reader.GetDecimal("Override_Custodial_Fees");/*Optional 51*/
            reader.GetString("EntityType_France");/*Optional 52*/
            reader.GetDecimal("Interest_Paid_EUR");/*Optional 53*/
            reader.GetString("Custodial_Ref_Num");/*Optional 54*/
            reader.GetDateTime("Custodial_Report_Date");/*Optional 55*/
            reader.GetString("Custodial_Report_Status");/*Optional 56*/
            reader.GetString("LawOfEstablishment");/*Optional 57*/
            reader.GetBool("CERT");/*Optional 58*/
            reader.GetString("Validation");/*Optional 59*/
            reader.GetString("Validation_Reason");/*Optional 60*/
            reader.GetString("Broker_BO_Name");/*Optional 61*/
            reader.GetBool("Paid_And_Locked");/*Optional 62*/
            reader.GetString("Category");/*Optional 63*/
            reader.GetString("Name_Of_Underlying_Holder");/*Optional 64*/
            reader.GetString("Entity_Name");/*Optional 65*/
            reader.GetDecimal("PercentOfShares_Held_UH");/*Optional 66*/
            reader.GetInt("RSHID");/*Optional 67*/
            reader.GetString("ParentID");/*Optional 68*/
            reader.GetString("ThreadID");/*Optional 69*/
            reader.GetString("ESPAccountNumber");/*Optional 70*/
            reader.GetInt("Tier");/*Optional 71*/
            reader.GetString("Tier2AccountNumber");/*Optional 72*/
            reader.GetString("Tier3AccountNumber");/*Optional 73*/
            reader.GetString("Tier4AccountNumber");/*Optional 74*/
            reader.GetString("Tier5AccountNumber");/*Optional 75*/
            reader.GetInt("ClientID");
            reader.GetBool("Designated");/*Optional 77*/
            reader.GetInt("PID");
            reader.GetInt("BOIndex");/*Optional 79*/
            reader.GetInt("TotalParticipants");/*Optional 80*/
            reader.GetInt("TotalTreatyParticipants");/*Optional 81*/
            reader.GetDateTime("DateOfFiscalYearEnd");/*Optional 82*/
            reader.GetString("RejectReasons");/*Optional 83*/
            reader.GetString("Tier6AccountNumber");/*Optional 84*/
            reader.GetString("Tier7AccountNumber");/*Optional 85*/
            reader.GetString("BoEmail");/*Optional 86*/
            reader.GetString("BOAccountNumber");/*Optional 87*/
            reader.GetDateTime("StatusDate");/*Optional 88*/
            reader.GetString("RejectParty");/*Optional 89*/
            reader.GetDateTime("AuditDeadline");/*Optional 90*/
            reader.GetBool("ExtensionRequested");/*Optional 91*/
            reader.GetDateTime("ExtensionDeadline");/*Optional 92*/
            reader.GetString("ElectionOption");/*Optional 93*/
            reader.GetInt("DocStatus_ESP");/*Optional 94*/
            reader.GetString("DocStatus");/*Optional 95*/
            reader.GetInt("boclient_id");/*Optional 96*/
            reader.GetString("pension_plan");/*Optional 97*/
            reader.GetString("VoucherStatus");/*Optional 98*/
            reader.GetDateTime("VoucherDate");/*Optional 99*/
            reader.GetString("LocalMarketID");/*Optional 100*/
            reader.GetInt("Dividend_RejectionID");/*Optional 101*/
            reader.GetDecimal("Depositary_Fees_USD_Locked");/*Optional 102*/
            reader.GetDecimal("Custodial_Fees_EUR_Locked");/*Optional 103*/
            reader.GetDecimal("Custodial_Fees_USD_Locked");/*Optional 104*/
            reader.GetDecimal("Net_Amount_Paid_USD_Locked");/*Optional 105*/
            reader.GetDecimal("Net_Amount_Paid_EUR_Locked");/*Optional 106*/
            reader.GetDateTime("BoBirthDate");/*Optional 107*/
            reader.GetString("BoLastName");/*Optional 108*/
            reader.GetString("BoFirstName");/*Optional 109*/
            reader.GetInt("ClientListingID");/*Optional 110*/
            reader.GetString("BoData");/*Optional 111*/
            reader.GetString("Status_Detail");/*Optional 112*/
            reader.GetDateTime("Doc_Deadline");/*Optional 113*/
            reader.GetString("Kenmerk_Number");/*Optional 114*/
            reader.GetString("Kenmerk_Status");/*Optional 115*/
            reader.GetDateTime("Kenmerk_Status_Date");/*Optional 116*/
            reader.GetString("FileLinking_Status");/*Optional 117*/
            reader.GetInt("Filing_Attempts");/*Optional 118*/
            reader.GetString("Kenmerk_Status_Reason");/*Optional 119*/
            reader.GetBool("PaidViaDTCC");/*Optional 120*/
            reader.GetString("COI");/*Optional 121*/
            reader.GetInt("Par_ID");/*Optional 122*/
            reader.GetDecimal("Depositary_FeesA_USD_Locked");/*Optional 123*/
            reader.GetString("Payment_Cycle");/*Optional 124*/
            reader.GetDateTime("Payment_Cycle_DateTime");/*Optional 125*/
            reader.GetString("StatusUpdatedBy");/*Optional 126*/
            reader.GetString("FundISIN");/*Optional 127*/
            reader.GetDateTime("PurchaseDate");/*Optional 128*/
            reader.GetString("ORDNUNGS_NR");/*Optional 129*/
            reader.GetString("NewBoTaxID");/*Optional 130*/
            reader.GetString("AuditStatus");/*Optional 131*/
            reader.GetDateTime("AuditStatusDate");/*Optional 132*/
        }
    }
}
