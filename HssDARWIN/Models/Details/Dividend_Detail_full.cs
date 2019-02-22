using System;
using System.Collections.Generic;
using System.Text;

using HssDARWIN.Models.Dividends;

namespace HssDARWIN.Models.Details
{
    public class Dividend_Detail_full
    {
        /*-----------------------------Hss Entity Framework Auto Generated Code-------------------------------*/
        private static HssUtility.SQLserver.CmdTemplate DBcmd_TP = null;
        public static HssUtility.SQLserver.CmdTemplate Get_cmdTP()
        {
            if (Dividend_Detail_full.DBcmd_TP != null) return Dividend_Detail_full.DBcmd_TP;

            Dividend_Detail_full.DBcmd_TP = new HssUtility.SQLserver.CmdTemplate();
            Dividend_Detail_full.DBcmd_TP.tableName = "Dividend_Detail";
            Dividend_Detail_full.DBcmd_TP.schema = "dbo";

            Dividend_Detail_full.DBcmd_TP.AddColumn("DetailID");
            Dividend_Detail_full.DBcmd_TP.AddColumn("DividendIndex");
            Dividend_Detail_full.DBcmd_TP.AddColumn("ClaimID");/*Optional 3*/
            Dividend_Detail_full.DBcmd_TP.AddColumn("Issue");
            Dividend_Detail_full.DBcmd_TP.AddColumn("DTC_Number");
            Dividend_Detail_full.DBcmd_TP.AddColumn("DTC_Name");/*Optional 6*/
            Dividend_Detail_full.DBcmd_TP.AddColumn("DTC_Address1");/*Optional 7*/
            Dividend_Detail_full.DBcmd_TP.AddColumn("DTC_Address2");/*Optional 8*/
            Dividend_Detail_full.DBcmd_TP.AddColumn("DTC_ATTN");/*Optional 9*/
            Dividend_Detail_full.DBcmd_TP.AddColumn("Depositary");/*Optional 10*/
            Dividend_Detail_full.DBcmd_TP.AddColumn("DTC_PositionID");/*Optional 11*/
            Dividend_Detail_full.DBcmd_TP.AddColumn("BoName");/*Optional 12*/
            Dividend_Detail_full.DBcmd_TP.AddColumn("BoAddress1");/*Optional 13*/
            Dividend_Detail_full.DBcmd_TP.AddColumn("BoAddress2");/*Optional 14*/
            Dividend_Detail_full.DBcmd_TP.AddColumn("BoAddress3");/*Optional 15*/
            Dividend_Detail_full.DBcmd_TP.AddColumn("BoAddress4");/*Optional 16*/
            Dividend_Detail_full.DBcmd_TP.AddColumn("BoAddress5");/*Optional 17*/
            Dividend_Detail_full.DBcmd_TP.AddColumn("BO_COR");/*Optional 18*/
            Dividend_Detail_full.DBcmd_TP.AddColumn("BO_EntityType");/*Optional 19*/
            Dividend_Detail_full.DBcmd_TP.AddColumn("BoTaxID");/*Optional 20*/
            Dividend_Detail_full.DBcmd_TP.AddColumn("ReceivedDate");/*Optional 21*/
            Dividend_Detail_full.DBcmd_TP.AddColumn("ReclaimRate");/*Optional 22*/
            Dividend_Detail_full.DBcmd_TP.AddColumn("ClaimType");/*Optional 23*/
            Dividend_Detail_full.DBcmd_TP.AddColumn("Custodian");/*Optional 24*/
            Dividend_Detail_full.DBcmd_TP.AddColumn("CustodianID");/*Optional 25*/
            Dividend_Detail_full.DBcmd_TP.AddColumn("ReclaimAmount");/*Optional 26*/
            Dividend_Detail_full.DBcmd_TP.AddColumn("Status");/*Optional 27*/
            Dividend_Detail_full.DBcmd_TP.AddColumn("CreatedDate");/*Optional 28*/
            Dividend_Detail_full.DBcmd_TP.AddColumn("PaymentReferenceDate");/*Optional 29*/
            Dividend_Detail_full.DBcmd_TP.AddColumn("RecordDatePosition");/*Optional 30*/
            Dividend_Detail_full.DBcmd_TP.AddColumn("Internal_Ref_Number");/*Optional 31*/
            Dividend_Detail_full.DBcmd_TP.AddColumn("Internal_Batch_Num");/*Optional 32*/
            Dividend_Detail_full.DBcmd_TP.AddColumn("External_Client_Ref_Num");/*Optional 33*/
            Dividend_Detail_full.DBcmd_TP.AddColumn("External_Claim_Ref_Num");/*Optional 34*/
            Dividend_Detail_full.DBcmd_TP.AddColumn("External_Batch_Num");/*Optional 35*/
            Dividend_Detail_full.DBcmd_TP.AddColumn("Notes");/*Optional 36*/
            Dividend_Detail_full.DBcmd_TP.AddColumn("Dividend_FilingID");/*Optional 37*/
            Dividend_Detail_full.DBcmd_TP.AddColumn("Dividend_PayID");/*Optional 38*/
            Dividend_Detail_full.DBcmd_TP.AddColumn("CurrentMode");/*Optional 39*/
            Dividend_Detail_full.DBcmd_TP.AddColumn("Editor");/*Optional 40*/
            Dividend_Detail_full.DBcmd_TP.AddColumn("ReclaimFeesType");/*Optional 41*/
            Dividend_Detail_full.DBcmd_TP.AddColumn("Filing_Reference_Number");/*Optional 42*/
            Dividend_Detail_full.DBcmd_TP.AddColumn("ModifiedDateTime");/*Optional 43*/
            Dividend_Detail_full.DBcmd_TP.AddColumn("LastModifiedBy");/*Optional 44*/
            Dividend_Detail_full.DBcmd_TP.AddColumn("External_Service_Provider_Name");/*Optional 45*/
            Dividend_Detail_full.DBcmd_TP.AddColumn("NewRow");
            Dividend_Detail_full.DBcmd_TP.AddColumn("Override_Fees");/*Optional 47*/
            Dividend_Detail_full.DBcmd_TP.AddColumn("Residency_Percent");/*Optional 48*/
            Dividend_Detail_full.DBcmd_TP.AddColumn("EST_Time_To_Pay");/*Optional 49*/
            Dividend_Detail_full.DBcmd_TP.AddColumn("Override_Rate");/*Optional 50*/
            Dividend_Detail_full.DBcmd_TP.AddColumn("Override_Custodial_Fees");/*Optional 51*/
            Dividend_Detail_full.DBcmd_TP.AddColumn("EntityType_France");/*Optional 52*/
            Dividend_Detail_full.DBcmd_TP.AddColumn("Interest_Paid_EUR");/*Optional 53*/
            Dividend_Detail_full.DBcmd_TP.AddColumn("Custodial_Ref_Num");/*Optional 54*/
            Dividend_Detail_full.DBcmd_TP.AddColumn("Custodial_Report_Date");/*Optional 55*/
            Dividend_Detail_full.DBcmd_TP.AddColumn("Custodial_Report_Status");/*Optional 56*/
            Dividend_Detail_full.DBcmd_TP.AddColumn("LawOfEstablishment");/*Optional 57*/
            Dividend_Detail_full.DBcmd_TP.AddColumn("CERT");/*Optional 58*/
            Dividend_Detail_full.DBcmd_TP.AddColumn("Validation");/*Optional 59*/
            Dividend_Detail_full.DBcmd_TP.AddColumn("Validation_Reason");/*Optional 60*/
            Dividend_Detail_full.DBcmd_TP.AddColumn("Broker_BO_Name");/*Optional 61*/
            Dividend_Detail_full.DBcmd_TP.AddColumn("Paid_And_Locked");/*Optional 62*/
            Dividend_Detail_full.DBcmd_TP.AddColumn("Category");/*Optional 63*/
            Dividend_Detail_full.DBcmd_TP.AddColumn("Name_Of_Underlying_Holder");/*Optional 64*/
            Dividend_Detail_full.DBcmd_TP.AddColumn("Entity_Name");/*Optional 65*/
            Dividend_Detail_full.DBcmd_TP.AddColumn("PercentOfShares_Held_UH");/*Optional 66*/
            Dividend_Detail_full.DBcmd_TP.AddColumn("RSHID");/*Optional 67*/
            Dividend_Detail_full.DBcmd_TP.AddColumn("ParentID");/*Optional 68*/
            Dividend_Detail_full.DBcmd_TP.AddColumn("ThreadID");/*Optional 69*/
            Dividend_Detail_full.DBcmd_TP.AddColumn("ESPAccountNumber");/*Optional 70*/
            Dividend_Detail_full.DBcmd_TP.AddColumn("Tier");/*Optional 71*/
            Dividend_Detail_full.DBcmd_TP.AddColumn("Tier2AccountNumber");/*Optional 72*/
            Dividend_Detail_full.DBcmd_TP.AddColumn("Tier3AccountNumber");/*Optional 73*/
            Dividend_Detail_full.DBcmd_TP.AddColumn("Tier4AccountNumber");/*Optional 74*/
            Dividend_Detail_full.DBcmd_TP.AddColumn("Tier5AccountNumber");/*Optional 75*/
            Dividend_Detail_full.DBcmd_TP.AddColumn("ClientID");
            Dividend_Detail_full.DBcmd_TP.AddColumn("Designated");/*Optional 77*/
            Dividend_Detail_full.DBcmd_TP.AddColumn("PID");
            Dividend_Detail_full.DBcmd_TP.AddColumn("BOIndex");/*Optional 79*/
            Dividend_Detail_full.DBcmd_TP.AddColumn("TotalParticipants");/*Optional 80*/
            Dividend_Detail_full.DBcmd_TP.AddColumn("TotalTreatyParticipants");/*Optional 81*/
            Dividend_Detail_full.DBcmd_TP.AddColumn("DateOfFiscalYearEnd");/*Optional 82*/
            Dividend_Detail_full.DBcmd_TP.AddColumn("RejectReasons");/*Optional 83*/
            Dividend_Detail_full.DBcmd_TP.AddColumn("Tier6AccountNumber");/*Optional 84*/
            Dividend_Detail_full.DBcmd_TP.AddColumn("Tier7AccountNumber");/*Optional 85*/
            Dividend_Detail_full.DBcmd_TP.AddColumn("BoEmail");/*Optional 86*/
            Dividend_Detail_full.DBcmd_TP.AddColumn("BOAccountNumber");/*Optional 87*/
            Dividend_Detail_full.DBcmd_TP.AddColumn("StatusDate");/*Optional 88*/
            Dividend_Detail_full.DBcmd_TP.AddColumn("RejectParty");/*Optional 89*/
            Dividend_Detail_full.DBcmd_TP.AddColumn("AuditDeadline");/*Optional 90*/
            Dividend_Detail_full.DBcmd_TP.AddColumn("ExtensionRequested");/*Optional 91*/
            Dividend_Detail_full.DBcmd_TP.AddColumn("ExtensionDeadline");/*Optional 92*/
            Dividend_Detail_full.DBcmd_TP.AddColumn("ElectionOption");/*Optional 93*/
            Dividend_Detail_full.DBcmd_TP.AddColumn("DocStatus_ESP");/*Optional 94*/
            Dividend_Detail_full.DBcmd_TP.AddColumn("DocStatus");/*Optional 95*/
            Dividend_Detail_full.DBcmd_TP.AddColumn("boclient_id");/*Optional 96*/
            Dividend_Detail_full.DBcmd_TP.AddColumn("pension_plan");/*Optional 97*/
            Dividend_Detail_full.DBcmd_TP.AddColumn("VoucherStatus");/*Optional 98*/
            Dividend_Detail_full.DBcmd_TP.AddColumn("VoucherDate");/*Optional 99*/
            Dividend_Detail_full.DBcmd_TP.AddColumn("LocalMarketID");/*Optional 100*/
            Dividend_Detail_full.DBcmd_TP.AddColumn("Dividend_RejectionID");/*Optional 101*/
            Dividend_Detail_full.DBcmd_TP.AddColumn("Depositary_Fees_USD_Locked");/*Optional 102*/
            Dividend_Detail_full.DBcmd_TP.AddColumn("Custodial_Fees_EUR_Locked");/*Optional 103*/
            Dividend_Detail_full.DBcmd_TP.AddColumn("Custodial_Fees_USD_Locked");/*Optional 104*/
            Dividend_Detail_full.DBcmd_TP.AddColumn("Net_Amount_Paid_USD_Locked");/*Optional 105*/
            Dividend_Detail_full.DBcmd_TP.AddColumn("Net_Amount_Paid_EUR_Locked");/*Optional 106*/
            Dividend_Detail_full.DBcmd_TP.AddColumn("BoBirthDate");/*Optional 107*/
            Dividend_Detail_full.DBcmd_TP.AddColumn("BoLastName");/*Optional 108*/
            Dividend_Detail_full.DBcmd_TP.AddColumn("BoFirstName");/*Optional 109*/
            Dividend_Detail_full.DBcmd_TP.AddColumn("ClientListingID");/*Optional 110*/
            Dividend_Detail_full.DBcmd_TP.AddColumn("BoData");/*Optional 111*/
            Dividend_Detail_full.DBcmd_TP.AddColumn("Status_Detail");/*Optional 112*/
            Dividend_Detail_full.DBcmd_TP.AddColumn("Doc_Deadline");/*Optional 113*/
            Dividend_Detail_full.DBcmd_TP.AddColumn("Kenmerk_Number");/*Optional 114*/
            Dividend_Detail_full.DBcmd_TP.AddColumn("Kenmerk_Status");/*Optional 115*/
            Dividend_Detail_full.DBcmd_TP.AddColumn("Kenmerk_Status_Date");/*Optional 116*/
            Dividend_Detail_full.DBcmd_TP.AddColumn("FileLinking_Status");/*Optional 117*/
            Dividend_Detail_full.DBcmd_TP.AddColumn("Filing_Attempts");/*Optional 118*/
            Dividend_Detail_full.DBcmd_TP.AddColumn("Kenmerk_Status_Reason");/*Optional 119*/
            Dividend_Detail_full.DBcmd_TP.AddColumn("PaidViaDTCC");/*Optional 120*/
            Dividend_Detail_full.DBcmd_TP.AddColumn("COI");/*Optional 121*/
            Dividend_Detail_full.DBcmd_TP.AddColumn("Par_ID");/*Optional 122*/
            Dividend_Detail_full.DBcmd_TP.AddColumn("Depositary_FeesA_USD_Locked");/*Optional 123*/
            Dividend_Detail_full.DBcmd_TP.AddColumn("Payment_Cycle");/*Optional 124*/
            Dividend_Detail_full.DBcmd_TP.AddColumn("Payment_Cycle_DateTime");/*Optional 125*/
            Dividend_Detail_full.DBcmd_TP.AddColumn("StatusUpdatedBy");/*Optional 126*/
            Dividend_Detail_full.DBcmd_TP.AddColumn("FundISIN");/*Optional 127*/
            Dividend_Detail_full.DBcmd_TP.AddColumn("PurchaseDate");/*Optional 128*/
            Dividend_Detail_full.DBcmd_TP.AddColumn("ORDNUNGS_NR");/*Optional 129*/
            Dividend_Detail_full.DBcmd_TP.AddColumn("NewBoTaxID");/*Optional 130*/
            Dividend_Detail_full.DBcmd_TP.AddColumn("AuditStatus");/*Optional 131*/
            Dividend_Detail_full.DBcmd_TP.AddColumn("AuditStatusDate");/*Optional 132*/

            return Dividend_Detail_full.DBcmd_TP;
        }

        public Dividend_Detail_full() { }
        public Dividend_Detail_full(int id) { this.pk_ID = id; }

        private int pk_ID = -1; //primary key
        public int DetailID { get { return this.pk_ID; } }

        public readonly HssUtility.General.Attributes.Int_attr DividendIndex = new HssUtility.General.Attributes.Int_attr();
        public readonly HssUtility.General.Attributes.Long_attr ClaimID = new HssUtility.General.Attributes.Long_attr();/*Optional 3*/
        public readonly HssUtility.General.Attributes.String_attr Issue = new HssUtility.General.Attributes.String_attr();
        public readonly HssUtility.General.Attributes.String_attr DTC_Number = new HssUtility.General.Attributes.String_attr();
        public readonly HssUtility.General.Attributes.String_attr DTC_Name = new HssUtility.General.Attributes.String_attr();/*Optional 6*/
        public readonly HssUtility.General.Attributes.String_attr DTC_Address1 = new HssUtility.General.Attributes.String_attr();/*Optional 7*/
        public readonly HssUtility.General.Attributes.String_attr DTC_Address2 = new HssUtility.General.Attributes.String_attr();/*Optional 8*/
        public readonly HssUtility.General.Attributes.String_attr DTC_ATTN = new HssUtility.General.Attributes.String_attr();/*Optional 9*/
        public readonly HssUtility.General.Attributes.String_attr Depositary = new HssUtility.General.Attributes.String_attr();/*Optional 10*/
        public readonly HssUtility.General.Attributes.Int_attr DTC_PositionID = new HssUtility.General.Attributes.Int_attr();/*Optional 11*/
        public readonly HssUtility.General.Attributes.String_attr BoName = new HssUtility.General.Attributes.String_attr();/*Optional 12*/
        public readonly HssUtility.General.Attributes.String_attr BoAddress1 = new HssUtility.General.Attributes.String_attr();/*Optional 13*/
        public readonly HssUtility.General.Attributes.String_attr BoAddress2 = new HssUtility.General.Attributes.String_attr();/*Optional 14*/
        public readonly HssUtility.General.Attributes.String_attr BoAddress3 = new HssUtility.General.Attributes.String_attr();/*Optional 15*/
        public readonly HssUtility.General.Attributes.String_attr BoAddress4 = new HssUtility.General.Attributes.String_attr();/*Optional 16*/
        public readonly HssUtility.General.Attributes.String_attr BoAddress5 = new HssUtility.General.Attributes.String_attr();/*Optional 17*/
        public readonly HssUtility.General.Attributes.String_attr BO_COR = new HssUtility.General.Attributes.String_attr();/*Optional 18*/
        public readonly HssUtility.General.Attributes.String_attr BO_EntityType = new HssUtility.General.Attributes.String_attr();/*Optional 19*/
        public readonly HssUtility.General.Attributes.String_attr BoTaxID = new HssUtility.General.Attributes.String_attr();/*Optional 20*/
        public readonly HssUtility.General.Attributes.DateTime_attr ReceivedDate = new HssUtility.General.Attributes.DateTime_attr();/*Optional 21*/
        public readonly HssUtility.General.Attributes.Decimal_attr ReclaimRate = new HssUtility.General.Attributes.Decimal_attr();/*Optional 22*/
        public readonly HssUtility.General.Attributes.Decimal_attr ClaimType = new HssUtility.General.Attributes.Decimal_attr();/*Optional 23*/
        public readonly HssUtility.General.Attributes.String_attr Custodian = new HssUtility.General.Attributes.String_attr();/*Optional 24*/
        public readonly HssUtility.General.Attributes.Int_attr CustodianID = new HssUtility.General.Attributes.Int_attr();/*Optional 25*/
        public readonly HssUtility.General.Attributes.Decimal_attr ReclaimAmount = new HssUtility.General.Attributes.Decimal_attr();/*Optional 26*/
        public readonly HssUtility.General.Attributes.String_attr Status = new HssUtility.General.Attributes.String_attr();/*Optional 27*/
        public readonly HssUtility.General.Attributes.DateTime_attr CreatedDate = new HssUtility.General.Attributes.DateTime_attr();/*Optional 28*/
        public readonly HssUtility.General.Attributes.DateTime_attr PaymentReferenceDate = new HssUtility.General.Attributes.DateTime_attr();/*Optional 29*/
        public readonly HssUtility.General.Attributes.Decimal_attr RecordDatePosition = new HssUtility.General.Attributes.Decimal_attr();/*Optional 30*/
        public readonly HssUtility.General.Attributes.String_attr Internal_Ref_Number = new HssUtility.General.Attributes.String_attr();/*Optional 31*/
        public readonly HssUtility.General.Attributes.String_attr Internal_Batch_Num = new HssUtility.General.Attributes.String_attr();/*Optional 32*/
        public readonly HssUtility.General.Attributes.String_attr External_Client_Ref_Num = new HssUtility.General.Attributes.String_attr();/*Optional 33*/
        public readonly HssUtility.General.Attributes.String_attr External_Claim_Ref_Num = new HssUtility.General.Attributes.String_attr();/*Optional 34*/
        public readonly HssUtility.General.Attributes.String_attr External_Batch_Num = new HssUtility.General.Attributes.String_attr();/*Optional 35*/
        public readonly HssUtility.General.Attributes.String_attr Notes = new HssUtility.General.Attributes.String_attr();/*Optional 36*/
        public readonly HssUtility.General.Attributes.Int_attr Dividend_FilingID = new HssUtility.General.Attributes.Int_attr();/*Optional 37*/
        public readonly HssUtility.General.Attributes.Int_attr Dividend_PayID = new HssUtility.General.Attributes.Int_attr();/*Optional 38*/
        public readonly HssUtility.General.Attributes.String_attr CurrentMode = new HssUtility.General.Attributes.String_attr();/*Optional 39*/
        public readonly HssUtility.General.Attributes.String_attr Editor = new HssUtility.General.Attributes.String_attr();/*Optional 40*/
        public readonly HssUtility.General.Attributes.String_attr ReclaimFeesType = new HssUtility.General.Attributes.String_attr();/*Optional 41*/
        public readonly HssUtility.General.Attributes.String_attr Filing_Reference_Number = new HssUtility.General.Attributes.String_attr();/*Optional 42*/
        public readonly HssUtility.General.Attributes.DateTime_attr ModifiedDateTime = new HssUtility.General.Attributes.DateTime_attr();/*Optional 43*/
        public readonly HssUtility.General.Attributes.String_attr LastModifiedBy = new HssUtility.General.Attributes.String_attr();/*Optional 44*/
        public readonly HssUtility.General.Attributes.String_attr External_Service_Provider_Name = new HssUtility.General.Attributes.String_attr();/*Optional 45*/
        public readonly HssUtility.General.Attributes.Bool_attr NewRow = new HssUtility.General.Attributes.Bool_attr();
        public readonly HssUtility.General.Attributes.Decimal_attr Override_Fees = new HssUtility.General.Attributes.Decimal_attr();/*Optional 47*/
        public readonly HssUtility.General.Attributes.Decimal_attr Residency_Percent = new HssUtility.General.Attributes.Decimal_attr();/*Optional 48*/
        public readonly HssUtility.General.Attributes.Int_attr EST_Time_To_Pay = new HssUtility.General.Attributes.Int_attr();/*Optional 49*/
        public readonly HssUtility.General.Attributes.Bool_attr Override_Rate = new HssUtility.General.Attributes.Bool_attr();/*Optional 50*/
        public readonly HssUtility.General.Attributes.Decimal_attr Override_Custodial_Fees = new HssUtility.General.Attributes.Decimal_attr();/*Optional 51*/
        public readonly HssUtility.General.Attributes.String_attr EntityType_France = new HssUtility.General.Attributes.String_attr();/*Optional 52*/
        public readonly HssUtility.General.Attributes.Decimal_attr Interest_Paid_EUR = new HssUtility.General.Attributes.Decimal_attr();/*Optional 53*/
        public readonly HssUtility.General.Attributes.String_attr Custodial_Ref_Num = new HssUtility.General.Attributes.String_attr();/*Optional 54*/
        public readonly HssUtility.General.Attributes.DateTime_attr Custodial_Report_Date = new HssUtility.General.Attributes.DateTime_attr();/*Optional 55*/
        public readonly HssUtility.General.Attributes.String_attr Custodial_Report_Status = new HssUtility.General.Attributes.String_attr();/*Optional 56*/
        public readonly HssUtility.General.Attributes.String_attr LawOfEstablishment = new HssUtility.General.Attributes.String_attr();/*Optional 57*/
        public readonly HssUtility.General.Attributes.Bool_attr CERT = new HssUtility.General.Attributes.Bool_attr();/*Optional 58*/
        public readonly HssUtility.General.Attributes.String_attr Validation = new HssUtility.General.Attributes.String_attr();/*Optional 59*/
        public readonly HssUtility.General.Attributes.String_attr Validation_Reason = new HssUtility.General.Attributes.String_attr();/*Optional 60*/
        public readonly HssUtility.General.Attributes.String_attr Broker_BO_Name = new HssUtility.General.Attributes.String_attr();/*Optional 61*/
        public readonly HssUtility.General.Attributes.Bool_attr Paid_And_Locked = new HssUtility.General.Attributes.Bool_attr();/*Optional 62*/
        public readonly HssUtility.General.Attributes.String_attr Category = new HssUtility.General.Attributes.String_attr();/*Optional 63*/
        public readonly HssUtility.General.Attributes.String_attr Name_Of_Underlying_Holder = new HssUtility.General.Attributes.String_attr();/*Optional 64*/
        public readonly HssUtility.General.Attributes.String_attr Entity_Name = new HssUtility.General.Attributes.String_attr();/*Optional 65*/
        public readonly HssUtility.General.Attributes.Decimal_attr PercentOfShares_Held_UH = new HssUtility.General.Attributes.Decimal_attr();/*Optional 66*/
        public readonly HssUtility.General.Attributes.Int_attr RSHID = new HssUtility.General.Attributes.Int_attr();/*Optional 67*/
        public readonly HssUtility.General.Attributes.String_attr ParentID = new HssUtility.General.Attributes.String_attr();/*Optional 68*/
        public readonly HssUtility.General.Attributes.String_attr ThreadID = new HssUtility.General.Attributes.String_attr();/*Optional 69*/
        public readonly HssUtility.General.Attributes.String_attr ESPAccountNumber = new HssUtility.General.Attributes.String_attr();/*Optional 70*/
        public readonly HssUtility.General.Attributes.Int_attr Tier = new HssUtility.General.Attributes.Int_attr();/*Optional 71*/
        public readonly HssUtility.General.Attributes.String_attr Tier2AccountNumber = new HssUtility.General.Attributes.String_attr();/*Optional 72*/
        public readonly HssUtility.General.Attributes.String_attr Tier3AccountNumber = new HssUtility.General.Attributes.String_attr();/*Optional 73*/
        public readonly HssUtility.General.Attributes.String_attr Tier4AccountNumber = new HssUtility.General.Attributes.String_attr();/*Optional 74*/
        public readonly HssUtility.General.Attributes.String_attr Tier5AccountNumber = new HssUtility.General.Attributes.String_attr();/*Optional 75*/
        public readonly HssUtility.General.Attributes.Int_attr ClientID = new HssUtility.General.Attributes.Int_attr();
        public readonly HssUtility.General.Attributes.Bool_attr Designated = new HssUtility.General.Attributes.Bool_attr();/*Optional 77*/
        public readonly HssUtility.General.Attributes.Int_attr PID = new HssUtility.General.Attributes.Int_attr();
        public readonly HssUtility.General.Attributes.Int_attr BOIndex = new HssUtility.General.Attributes.Int_attr();/*Optional 79*/
        public readonly HssUtility.General.Attributes.Int_attr TotalParticipants = new HssUtility.General.Attributes.Int_attr();/*Optional 80*/
        public readonly HssUtility.General.Attributes.Int_attr TotalTreatyParticipants = new HssUtility.General.Attributes.Int_attr();/*Optional 81*/
        public readonly HssUtility.General.Attributes.DateTime_attr DateOfFiscalYearEnd = new HssUtility.General.Attributes.DateTime_attr();/*Optional 82*/
        public readonly HssUtility.General.Attributes.String_attr RejectReasons = new HssUtility.General.Attributes.String_attr();/*Optional 83*/
        public readonly HssUtility.General.Attributes.String_attr Tier6AccountNumber = new HssUtility.General.Attributes.String_attr();/*Optional 84*/
        public readonly HssUtility.General.Attributes.String_attr Tier7AccountNumber = new HssUtility.General.Attributes.String_attr();/*Optional 85*/
        public readonly HssUtility.General.Attributes.String_attr BoEmail = new HssUtility.General.Attributes.String_attr();/*Optional 86*/
        public readonly HssUtility.General.Attributes.String_attr BOAccountNumber = new HssUtility.General.Attributes.String_attr();/*Optional 87*/
        public readonly HssUtility.General.Attributes.DateTime_attr StatusDate = new HssUtility.General.Attributes.DateTime_attr();/*Optional 88*/
        public readonly HssUtility.General.Attributes.String_attr RejectParty = new HssUtility.General.Attributes.String_attr();/*Optional 89*/
        public readonly HssUtility.General.Attributes.DateTime_attr AuditDeadline = new HssUtility.General.Attributes.DateTime_attr();/*Optional 90*/
        public readonly HssUtility.General.Attributes.Bool_attr ExtensionRequested = new HssUtility.General.Attributes.Bool_attr();/*Optional 91*/
        public readonly HssUtility.General.Attributes.DateTime_attr ExtensionDeadline = new HssUtility.General.Attributes.DateTime_attr();/*Optional 92*/
        public readonly HssUtility.General.Attributes.String_attr ElectionOption = new HssUtility.General.Attributes.String_attr();/*Optional 93*/
        public readonly HssUtility.General.Attributes.Int_attr DocStatus_ESP = new HssUtility.General.Attributes.Int_attr();/*Optional 94*/
        public readonly HssUtility.General.Attributes.String_attr DocStatus = new HssUtility.General.Attributes.String_attr();/*Optional 95*/
        public readonly HssUtility.General.Attributes.Int_attr boclient_id = new HssUtility.General.Attributes.Int_attr();/*Optional 96*/
        public readonly HssUtility.General.Attributes.String_attr pension_plan = new HssUtility.General.Attributes.String_attr();/*Optional 97*/
        public readonly HssUtility.General.Attributes.String_attr VoucherStatus = new HssUtility.General.Attributes.String_attr();/*Optional 98*/
        public readonly HssUtility.General.Attributes.DateTime_attr VoucherDate = new HssUtility.General.Attributes.DateTime_attr();/*Optional 99*/
        public readonly HssUtility.General.Attributes.String_attr LocalMarketID = new HssUtility.General.Attributes.String_attr();/*Optional 100*/
        public readonly HssUtility.General.Attributes.Int_attr Dividend_RejectionID = new HssUtility.General.Attributes.Int_attr();/*Optional 101*/
        public readonly HssUtility.General.Attributes.Decimal_attr Depositary_Fees_USD_Locked = new HssUtility.General.Attributes.Decimal_attr();/*Optional 102*/
        public readonly HssUtility.General.Attributes.Decimal_attr Custodial_Fees_EUR_Locked = new HssUtility.General.Attributes.Decimal_attr();/*Optional 103*/
        public readonly HssUtility.General.Attributes.Decimal_attr Custodial_Fees_USD_Locked = new HssUtility.General.Attributes.Decimal_attr();/*Optional 104*/
        public readonly HssUtility.General.Attributes.Decimal_attr Net_Amount_Paid_USD_Locked = new HssUtility.General.Attributes.Decimal_attr();/*Optional 105*/
        public readonly HssUtility.General.Attributes.Decimal_attr Net_Amount_Paid_EUR_Locked = new HssUtility.General.Attributes.Decimal_attr();/*Optional 106*/
        public readonly HssUtility.General.Attributes.DateTime_attr BoBirthDate = new HssUtility.General.Attributes.DateTime_attr();/*Optional 107*/
        public readonly HssUtility.General.Attributes.String_attr BoLastName = new HssUtility.General.Attributes.String_attr();/*Optional 108*/
        public readonly HssUtility.General.Attributes.String_attr BoFirstName = new HssUtility.General.Attributes.String_attr();/*Optional 109*/
        public readonly HssUtility.General.Attributes.Int_attr ClientListingID = new HssUtility.General.Attributes.Int_attr();/*Optional 110*/
        public readonly HssUtility.General.Attributes.String_attr BoData = new HssUtility.General.Attributes.String_attr();/*Optional 111*/
        public readonly HssUtility.General.Attributes.String_attr Status_Detail = new HssUtility.General.Attributes.String_attr();/*Optional 112*/
        public readonly HssUtility.General.Attributes.DateTime_attr Doc_Deadline = new HssUtility.General.Attributes.DateTime_attr();/*Optional 113*/
        public readonly HssUtility.General.Attributes.String_attr Kenmerk_Number = new HssUtility.General.Attributes.String_attr();/*Optional 114*/
        public readonly HssUtility.General.Attributes.String_attr Kenmerk_Status = new HssUtility.General.Attributes.String_attr();/*Optional 115*/
        public readonly HssUtility.General.Attributes.DateTime_attr Kenmerk_Status_Date = new HssUtility.General.Attributes.DateTime_attr();/*Optional 116*/
        public readonly HssUtility.General.Attributes.String_attr FileLinking_Status = new HssUtility.General.Attributes.String_attr();/*Optional 117*/
        public readonly HssUtility.General.Attributes.Int_attr Filing_Attempts = new HssUtility.General.Attributes.Int_attr();/*Optional 118*/
        public readonly HssUtility.General.Attributes.String_attr Kenmerk_Status_Reason = new HssUtility.General.Attributes.String_attr();/*Optional 119*/
        public readonly HssUtility.General.Attributes.Bool_attr PaidViaDTCC = new HssUtility.General.Attributes.Bool_attr();/*Optional 120*/
        public readonly HssUtility.General.Attributes.String_attr COI = new HssUtility.General.Attributes.String_attr();/*Optional 121*/
        public readonly HssUtility.General.Attributes.Int_attr Par_ID = new HssUtility.General.Attributes.Int_attr();/*Optional 122*/
        public readonly HssUtility.General.Attributes.Decimal_attr Depositary_FeesA_USD_Locked = new HssUtility.General.Attributes.Decimal_attr();/*Optional 123*/
        public readonly HssUtility.General.Attributes.String_attr Payment_Cycle = new HssUtility.General.Attributes.String_attr();/*Optional 124*/
        public readonly HssUtility.General.Attributes.DateTime_attr Payment_Cycle_DateTime = new HssUtility.General.Attributes.DateTime_attr();/*Optional 125*/
        public readonly HssUtility.General.Attributes.String_attr StatusUpdatedBy = new HssUtility.General.Attributes.String_attr();/*Optional 126*/
        public readonly HssUtility.General.Attributes.String_attr FundISIN = new HssUtility.General.Attributes.String_attr();/*Optional 127*/
        public readonly HssUtility.General.Attributes.DateTime_attr PurchaseDate = new HssUtility.General.Attributes.DateTime_attr();/*Optional 128*/
        public readonly HssUtility.General.Attributes.String_attr ORDNUNGS_NR = new HssUtility.General.Attributes.String_attr();/*Optional 129*/
        public readonly HssUtility.General.Attributes.String_attr NewBoTaxID = new HssUtility.General.Attributes.String_attr();/*Optional 130*/
        public readonly HssUtility.General.Attributes.String_attr AuditStatus = new HssUtility.General.Attributes.String_attr();/*Optional 131*/
        public readonly HssUtility.General.Attributes.DateTime_attr AuditStatusDate = new HssUtility.General.Attributes.DateTime_attr();/*Optional 132*/

        private Dictionary<string, HssUtility.General.Attributes.I_modelAttr> attr_dic = null;

        internal void Init_from_reader(HssUtility.SQLserver.DB_reader reader)
        {
            if (reader == null || reader.IsClosed) return;

            this.pk_ID = reader.GetInt("DetailID");
            reader.GetInt("DividendIndex", this.DividendIndex);
            reader.GetLong("ClaimID", this.ClaimID);/*Optional 3*/
            reader.GetString("Issue", this.Issue);
            reader.GetString("DTC_Number", this.DTC_Number);
            reader.GetString("DTC_Name", this.DTC_Name);/*Optional 6*/
            reader.GetString("DTC_Address1", this.DTC_Address1);/*Optional 7*/
            reader.GetString("DTC_Address2", this.DTC_Address2);/*Optional 8*/
            reader.GetString("DTC_ATTN", this.DTC_ATTN);/*Optional 9*/
            reader.GetString("Depositary", this.Depositary);/*Optional 10*/
            reader.GetInt("DTC_PositionID", this.DTC_PositionID);/*Optional 11*/
            reader.GetString("BoName", this.BoName);/*Optional 12*/
            reader.GetString("BoAddress1", this.BoAddress1);/*Optional 13*/
            reader.GetString("BoAddress2", this.BoAddress2);/*Optional 14*/
            reader.GetString("BoAddress3", this.BoAddress3);/*Optional 15*/
            reader.GetString("BoAddress4", this.BoAddress4);/*Optional 16*/
            reader.GetString("BoAddress5", this.BoAddress5);/*Optional 17*/
            reader.GetString("BO_COR", this.BO_COR);/*Optional 18*/
            reader.GetString("BO_EntityType", this.BO_EntityType);/*Optional 19*/
            reader.GetString("BoTaxID", this.BoTaxID);/*Optional 20*/
            reader.GetDateTime("ReceivedDate", this.ReceivedDate);/*Optional 21*/
            reader.GetDecimal("ReclaimRate", this.ReclaimRate);/*Optional 22*/
            reader.GetDecimal("ClaimType", this.ClaimType);/*Optional 23*/
            reader.GetString("Custodian", this.Custodian);/*Optional 24*/
            reader.GetInt("CustodianID", this.CustodianID);/*Optional 25*/
            reader.GetDecimal("ReclaimAmount", this.ReclaimAmount);/*Optional 26*/
            reader.GetString("Status", this.Status);/*Optional 27*/
            reader.GetDateTime("CreatedDate", this.CreatedDate);/*Optional 28*/
            reader.GetDateTime("PaymentReferenceDate", this.PaymentReferenceDate);/*Optional 29*/
            reader.GetDecimal("RecordDatePosition", this.RecordDatePosition);/*Optional 30*/
            reader.GetString("Internal_Ref_Number", this.Internal_Ref_Number);/*Optional 31*/
            reader.GetString("Internal_Batch_Num", this.Internal_Batch_Num);/*Optional 32*/
            reader.GetString("External_Client_Ref_Num", this.External_Client_Ref_Num);/*Optional 33*/
            reader.GetString("External_Claim_Ref_Num", this.External_Claim_Ref_Num);/*Optional 34*/
            reader.GetString("External_Batch_Num", this.External_Batch_Num);/*Optional 35*/
            reader.GetString("Notes", this.Notes);/*Optional 36*/
            reader.GetInt("Dividend_FilingID", this.Dividend_FilingID);/*Optional 37*/
            reader.GetInt("Dividend_PayID", this.Dividend_PayID);/*Optional 38*/
            reader.GetString("CurrentMode", this.CurrentMode);/*Optional 39*/
            reader.GetString("Editor", this.Editor);/*Optional 40*/
            reader.GetString("ReclaimFeesType", this.ReclaimFeesType);/*Optional 41*/
            reader.GetString("Filing_Reference_Number", this.Filing_Reference_Number);/*Optional 42*/
            reader.GetDateTime("ModifiedDateTime", this.ModifiedDateTime);/*Optional 43*/
            reader.GetString("LastModifiedBy", this.LastModifiedBy);/*Optional 44*/
            reader.GetString("External_Service_Provider_Name", this.External_Service_Provider_Name);/*Optional 45*/
            reader.GetBool("NewRow", this.NewRow);
            reader.GetDecimal("Override_Fees", this.Override_Fees);/*Optional 47*/
            reader.GetDecimal("Residency_Percent", this.Residency_Percent);/*Optional 48*/
            reader.GetInt("EST_Time_To_Pay", this.EST_Time_To_Pay);/*Optional 49*/
            reader.GetBool("Override_Rate", this.Override_Rate);/*Optional 50*/
            reader.GetDecimal("Override_Custodial_Fees", this.Override_Custodial_Fees);/*Optional 51*/
            reader.GetString("EntityType_France", this.EntityType_France);/*Optional 52*/
            reader.GetDecimal("Interest_Paid_EUR", this.Interest_Paid_EUR);/*Optional 53*/
            reader.GetString("Custodial_Ref_Num", this.Custodial_Ref_Num);/*Optional 54*/
            reader.GetDateTime("Custodial_Report_Date", this.Custodial_Report_Date);/*Optional 55*/
            reader.GetString("Custodial_Report_Status", this.Custodial_Report_Status);/*Optional 56*/
            reader.GetString("LawOfEstablishment", this.LawOfEstablishment);/*Optional 57*/
            reader.GetBool("CERT", this.CERT);/*Optional 58*/
            reader.GetString("Validation", this.Validation);/*Optional 59*/
            reader.GetString("Validation_Reason", this.Validation_Reason);/*Optional 60*/
            reader.GetString("Broker_BO_Name", this.Broker_BO_Name);/*Optional 61*/
            reader.GetBool("Paid_And_Locked", this.Paid_And_Locked);/*Optional 62*/
            reader.GetString("Category", this.Category);/*Optional 63*/
            reader.GetString("Name_Of_Underlying_Holder", this.Name_Of_Underlying_Holder);/*Optional 64*/
            reader.GetString("Entity_Name", this.Entity_Name);/*Optional 65*/
            reader.GetDecimal("PercentOfShares_Held_UH", this.PercentOfShares_Held_UH);/*Optional 66*/
            reader.GetInt("RSHID", this.RSHID);/*Optional 67*/
            reader.GetString("ParentID", this.ParentID);/*Optional 68*/
            reader.GetString("ThreadID", this.ThreadID);/*Optional 69*/
            reader.GetString("ESPAccountNumber", this.ESPAccountNumber);/*Optional 70*/
            reader.GetInt("Tier", this.Tier);/*Optional 71*/
            reader.GetString("Tier2AccountNumber", this.Tier2AccountNumber);/*Optional 72*/
            reader.GetString("Tier3AccountNumber", this.Tier3AccountNumber);/*Optional 73*/
            reader.GetString("Tier4AccountNumber", this.Tier4AccountNumber);/*Optional 74*/
            reader.GetString("Tier5AccountNumber", this.Tier5AccountNumber);/*Optional 75*/
            reader.GetInt("ClientID", this.ClientID);
            reader.GetBool("Designated", this.Designated);/*Optional 77*/
            reader.GetInt("PID", this.PID);
            reader.GetInt("BOIndex", this.BOIndex);/*Optional 79*/
            reader.GetInt("TotalParticipants", this.TotalParticipants);/*Optional 80*/
            reader.GetInt("TotalTreatyParticipants", this.TotalTreatyParticipants);/*Optional 81*/
            reader.GetDateTime("DateOfFiscalYearEnd", this.DateOfFiscalYearEnd);/*Optional 82*/
            reader.GetString("RejectReasons", this.RejectReasons);/*Optional 83*/
            reader.GetString("Tier6AccountNumber", this.Tier6AccountNumber);/*Optional 84*/
            reader.GetString("Tier7AccountNumber", this.Tier7AccountNumber);/*Optional 85*/
            reader.GetString("BoEmail", this.BoEmail);/*Optional 86*/
            reader.GetString("BOAccountNumber", this.BOAccountNumber);/*Optional 87*/
            reader.GetDateTime("StatusDate", this.StatusDate);/*Optional 88*/
            reader.GetString("RejectParty", this.RejectParty);/*Optional 89*/
            reader.GetDateTime("AuditDeadline", this.AuditDeadline);/*Optional 90*/
            reader.GetBool("ExtensionRequested", this.ExtensionRequested);/*Optional 91*/
            reader.GetDateTime("ExtensionDeadline", this.ExtensionDeadline);/*Optional 92*/
            reader.GetString("ElectionOption", this.ElectionOption);/*Optional 93*/
            reader.GetInt("DocStatus_ESP", this.DocStatus_ESP);/*Optional 94*/
            reader.GetString("DocStatus", this.DocStatus);/*Optional 95*/
            reader.GetInt("boclient_id", this.boclient_id);/*Optional 96*/
            reader.GetString("pension_plan", this.pension_plan);/*Optional 97*/
            reader.GetString("VoucherStatus", this.VoucherStatus);/*Optional 98*/
            reader.GetDateTime("VoucherDate", this.VoucherDate);/*Optional 99*/
            reader.GetString("LocalMarketID", this.LocalMarketID);/*Optional 100*/
            reader.GetInt("Dividend_RejectionID", this.Dividend_RejectionID);/*Optional 101*/
            reader.GetDecimal("Depositary_Fees_USD_Locked", this.Depositary_Fees_USD_Locked);/*Optional 102*/
            reader.GetDecimal("Custodial_Fees_EUR_Locked", this.Custodial_Fees_EUR_Locked);/*Optional 103*/
            reader.GetDecimal("Custodial_Fees_USD_Locked", this.Custodial_Fees_USD_Locked);/*Optional 104*/
            reader.GetDecimal("Net_Amount_Paid_USD_Locked", this.Net_Amount_Paid_USD_Locked);/*Optional 105*/
            reader.GetDecimal("Net_Amount_Paid_EUR_Locked", this.Net_Amount_Paid_EUR_Locked);/*Optional 106*/
            reader.GetDateTime("BoBirthDate", this.BoBirthDate);/*Optional 107*/
            reader.GetString("BoLastName", this.BoLastName);/*Optional 108*/
            reader.GetString("BoFirstName", this.BoFirstName);/*Optional 109*/
            reader.GetInt("ClientListingID", this.ClientListingID);/*Optional 110*/
            reader.GetString("BoData", this.BoData);/*Optional 111*/
            reader.GetString("Status_Detail", this.Status_Detail);/*Optional 112*/
            reader.GetDateTime("Doc_Deadline", this.Doc_Deadline);/*Optional 113*/
            reader.GetString("Kenmerk_Number", this.Kenmerk_Number);/*Optional 114*/
            reader.GetString("Kenmerk_Status", this.Kenmerk_Status);/*Optional 115*/
            reader.GetDateTime("Kenmerk_Status_Date", this.Kenmerk_Status_Date);/*Optional 116*/
            reader.GetString("FileLinking_Status", this.FileLinking_Status);/*Optional 117*/
            reader.GetInt("Filing_Attempts", this.Filing_Attempts);/*Optional 118*/
            reader.GetString("Kenmerk_Status_Reason", this.Kenmerk_Status_Reason);/*Optional 119*/
            reader.GetBool("PaidViaDTCC", this.PaidViaDTCC);/*Optional 120*/
            reader.GetString("COI", this.COI);/*Optional 121*/
            reader.GetInt("Par_ID", this.Par_ID);/*Optional 122*/
            reader.GetDecimal("Depositary_FeesA_USD_Locked", this.Depositary_FeesA_USD_Locked);/*Optional 123*/
            reader.GetString("Payment_Cycle", this.Payment_Cycle);/*Optional 124*/
            reader.GetDateTime("Payment_Cycle_DateTime", this.Payment_Cycle_DateTime);/*Optional 125*/
            reader.GetString("StatusUpdatedBy", this.StatusUpdatedBy);/*Optional 126*/
            reader.GetString("FundISIN", this.FundISIN);/*Optional 127*/
            reader.GetDateTime("PurchaseDate", this.PurchaseDate);/*Optional 128*/
            reader.GetString("ORDNUNGS_NR", this.ORDNUNGS_NR);/*Optional 129*/
            reader.GetString("NewBoTaxID", this.NewBoTaxID);/*Optional 130*/
            reader.GetString("AuditStatus", this.AuditStatus);/*Optional 131*/
            reader.GetDateTime("AuditStatusDate", this.AuditStatusDate);/*Optional 132*/

            this.SyncWithDB();
        }

        /// <summary>
        /// Initialize object from DB
        /// </summary>
        public bool Init_from_DB()
        {
            if (this.DetailID < 0) return false;

            HssUtility.SQLserver.DB_select db_sel = new HssUtility.SQLserver.DB_select(Dividend_Detail_full.Get_cmdTP());
            db_sel.tableName = "Dividend_Detail";
            HssUtility.SQLserver.SQL_relation rela = new HssUtility.SQLserver.SQL_relation("DetailID", HssUtility.General.RelationalOperator.Equals, this.DetailID);
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
            this.attr_dic.Add("ClaimID", this.ClaimID);/*Optional 3*/
            this.attr_dic.Add("Issue", this.Issue);
            this.attr_dic.Add("DTC_Number", this.DTC_Number);
            this.attr_dic.Add("DTC_Name", this.DTC_Name);/*Optional 6*/
            this.attr_dic.Add("DTC_Address1", this.DTC_Address1);/*Optional 7*/
            this.attr_dic.Add("DTC_Address2", this.DTC_Address2);/*Optional 8*/
            this.attr_dic.Add("DTC_ATTN", this.DTC_ATTN);/*Optional 9*/
            this.attr_dic.Add("Depositary", this.Depositary);/*Optional 10*/
            this.attr_dic.Add("DTC_PositionID", this.DTC_PositionID);/*Optional 11*/
            this.attr_dic.Add("BoName", this.BoName);/*Optional 12*/
            this.attr_dic.Add("BoAddress1", this.BoAddress1);/*Optional 13*/
            this.attr_dic.Add("BoAddress2", this.BoAddress2);/*Optional 14*/
            this.attr_dic.Add("BoAddress3", this.BoAddress3);/*Optional 15*/
            this.attr_dic.Add("BoAddress4", this.BoAddress4);/*Optional 16*/
            this.attr_dic.Add("BoAddress5", this.BoAddress5);/*Optional 17*/
            this.attr_dic.Add("BO_COR", this.BO_COR);/*Optional 18*/
            this.attr_dic.Add("BO_EntityType", this.BO_EntityType);/*Optional 19*/
            this.attr_dic.Add("BoTaxID", this.BoTaxID);/*Optional 20*/
            this.attr_dic.Add("ReceivedDate", this.ReceivedDate);/*Optional 21*/
            this.attr_dic.Add("ReclaimRate", this.ReclaimRate);/*Optional 22*/
            this.attr_dic.Add("ClaimType", this.ClaimType);/*Optional 23*/
            this.attr_dic.Add("Custodian", this.Custodian);/*Optional 24*/
            this.attr_dic.Add("CustodianID", this.CustodianID);/*Optional 25*/
            this.attr_dic.Add("ReclaimAmount", this.ReclaimAmount);/*Optional 26*/
            this.attr_dic.Add("Status", this.Status);/*Optional 27*/
            this.attr_dic.Add("CreatedDate", this.CreatedDate);/*Optional 28*/
            this.attr_dic.Add("PaymentReferenceDate", this.PaymentReferenceDate);/*Optional 29*/
            this.attr_dic.Add("RecordDatePosition", this.RecordDatePosition);/*Optional 30*/
            this.attr_dic.Add("Internal_Ref_Number", this.Internal_Ref_Number);/*Optional 31*/
            this.attr_dic.Add("Internal_Batch_Num", this.Internal_Batch_Num);/*Optional 32*/
            this.attr_dic.Add("External_Client_Ref_Num", this.External_Client_Ref_Num);/*Optional 33*/
            this.attr_dic.Add("External_Claim_Ref_Num", this.External_Claim_Ref_Num);/*Optional 34*/
            this.attr_dic.Add("External_Batch_Num", this.External_Batch_Num);/*Optional 35*/
            this.attr_dic.Add("Notes", this.Notes);/*Optional 36*/
            this.attr_dic.Add("Dividend_FilingID", this.Dividend_FilingID);/*Optional 37*/
            this.attr_dic.Add("Dividend_PayID", this.Dividend_PayID);/*Optional 38*/
            this.attr_dic.Add("CurrentMode", this.CurrentMode);/*Optional 39*/
            this.attr_dic.Add("Editor", this.Editor);/*Optional 40*/
            this.attr_dic.Add("ReclaimFeesType", this.ReclaimFeesType);/*Optional 41*/
            this.attr_dic.Add("Filing_Reference_Number", this.Filing_Reference_Number);/*Optional 42*/
            this.attr_dic.Add("ModifiedDateTime", this.ModifiedDateTime);/*Optional 43*/
            this.attr_dic.Add("LastModifiedBy", this.LastModifiedBy);/*Optional 44*/
            this.attr_dic.Add("External_Service_Provider_Name", this.External_Service_Provider_Name);/*Optional 45*/
            this.attr_dic.Add("NewRow", this.NewRow);
            this.attr_dic.Add("Override_Fees", this.Override_Fees);/*Optional 47*/
            this.attr_dic.Add("Residency_Percent", this.Residency_Percent);/*Optional 48*/
            this.attr_dic.Add("EST_Time_To_Pay", this.EST_Time_To_Pay);/*Optional 49*/
            this.attr_dic.Add("Override_Rate", this.Override_Rate);/*Optional 50*/
            this.attr_dic.Add("Override_Custodial_Fees", this.Override_Custodial_Fees);/*Optional 51*/
            this.attr_dic.Add("EntityType_France", this.EntityType_France);/*Optional 52*/
            this.attr_dic.Add("Interest_Paid_EUR", this.Interest_Paid_EUR);/*Optional 53*/
            this.attr_dic.Add("Custodial_Ref_Num", this.Custodial_Ref_Num);/*Optional 54*/
            this.attr_dic.Add("Custodial_Report_Date", this.Custodial_Report_Date);/*Optional 55*/
            this.attr_dic.Add("Custodial_Report_Status", this.Custodial_Report_Status);/*Optional 56*/
            this.attr_dic.Add("LawOfEstablishment", this.LawOfEstablishment);/*Optional 57*/
            this.attr_dic.Add("CERT", this.CERT);/*Optional 58*/
            this.attr_dic.Add("Validation", this.Validation);/*Optional 59*/
            this.attr_dic.Add("Validation_Reason", this.Validation_Reason);/*Optional 60*/
            this.attr_dic.Add("Broker_BO_Name", this.Broker_BO_Name);/*Optional 61*/
            this.attr_dic.Add("Paid_And_Locked", this.Paid_And_Locked);/*Optional 62*/
            this.attr_dic.Add("Category", this.Category);/*Optional 63*/
            this.attr_dic.Add("Name_Of_Underlying_Holder", this.Name_Of_Underlying_Holder);/*Optional 64*/
            this.attr_dic.Add("Entity_Name", this.Entity_Name);/*Optional 65*/
            this.attr_dic.Add("PercentOfShares_Held_UH", this.PercentOfShares_Held_UH);/*Optional 66*/
            this.attr_dic.Add("RSHID", this.RSHID);/*Optional 67*/
            this.attr_dic.Add("ParentID", this.ParentID);/*Optional 68*/
            this.attr_dic.Add("ThreadID", this.ThreadID);/*Optional 69*/
            this.attr_dic.Add("ESPAccountNumber", this.ESPAccountNumber);/*Optional 70*/
            this.attr_dic.Add("Tier", this.Tier);/*Optional 71*/
            this.attr_dic.Add("Tier2AccountNumber", this.Tier2AccountNumber);/*Optional 72*/
            this.attr_dic.Add("Tier3AccountNumber", this.Tier3AccountNumber);/*Optional 73*/
            this.attr_dic.Add("Tier4AccountNumber", this.Tier4AccountNumber);/*Optional 74*/
            this.attr_dic.Add("Tier5AccountNumber", this.Tier5AccountNumber);/*Optional 75*/
            this.attr_dic.Add("ClientID", this.ClientID);
            this.attr_dic.Add("Designated", this.Designated);/*Optional 77*/
            this.attr_dic.Add("PID", this.PID);
            this.attr_dic.Add("BOIndex", this.BOIndex);/*Optional 79*/
            this.attr_dic.Add("TotalParticipants", this.TotalParticipants);/*Optional 80*/
            this.attr_dic.Add("TotalTreatyParticipants", this.TotalTreatyParticipants);/*Optional 81*/
            this.attr_dic.Add("DateOfFiscalYearEnd", this.DateOfFiscalYearEnd);/*Optional 82*/
            this.attr_dic.Add("RejectReasons", this.RejectReasons);/*Optional 83*/
            this.attr_dic.Add("Tier6AccountNumber", this.Tier6AccountNumber);/*Optional 84*/
            this.attr_dic.Add("Tier7AccountNumber", this.Tier7AccountNumber);/*Optional 85*/
            this.attr_dic.Add("BoEmail", this.BoEmail);/*Optional 86*/
            this.attr_dic.Add("BOAccountNumber", this.BOAccountNumber);/*Optional 87*/
            this.attr_dic.Add("StatusDate", this.StatusDate);/*Optional 88*/
            this.attr_dic.Add("RejectParty", this.RejectParty);/*Optional 89*/
            this.attr_dic.Add("AuditDeadline", this.AuditDeadline);/*Optional 90*/
            this.attr_dic.Add("ExtensionRequested", this.ExtensionRequested);/*Optional 91*/
            this.attr_dic.Add("ExtensionDeadline", this.ExtensionDeadline);/*Optional 92*/
            this.attr_dic.Add("ElectionOption", this.ElectionOption);/*Optional 93*/
            this.attr_dic.Add("DocStatus_ESP", this.DocStatus_ESP);/*Optional 94*/
            this.attr_dic.Add("DocStatus", this.DocStatus);/*Optional 95*/
            this.attr_dic.Add("boclient_id", this.boclient_id);/*Optional 96*/
            this.attr_dic.Add("pension_plan", this.pension_plan);/*Optional 97*/
            this.attr_dic.Add("VoucherStatus", this.VoucherStatus);/*Optional 98*/
            this.attr_dic.Add("VoucherDate", this.VoucherDate);/*Optional 99*/
            this.attr_dic.Add("LocalMarketID", this.LocalMarketID);/*Optional 100*/
            this.attr_dic.Add("Dividend_RejectionID", this.Dividend_RejectionID);/*Optional 101*/
            this.attr_dic.Add("Depositary_Fees_USD_Locked", this.Depositary_Fees_USD_Locked);/*Optional 102*/
            this.attr_dic.Add("Custodial_Fees_EUR_Locked", this.Custodial_Fees_EUR_Locked);/*Optional 103*/
            this.attr_dic.Add("Custodial_Fees_USD_Locked", this.Custodial_Fees_USD_Locked);/*Optional 104*/
            this.attr_dic.Add("Net_Amount_Paid_USD_Locked", this.Net_Amount_Paid_USD_Locked);/*Optional 105*/
            this.attr_dic.Add("Net_Amount_Paid_EUR_Locked", this.Net_Amount_Paid_EUR_Locked);/*Optional 106*/
            this.attr_dic.Add("BoBirthDate", this.BoBirthDate);/*Optional 107*/
            this.attr_dic.Add("BoLastName", this.BoLastName);/*Optional 108*/
            this.attr_dic.Add("BoFirstName", this.BoFirstName);/*Optional 109*/
            this.attr_dic.Add("ClientListingID", this.ClientListingID);/*Optional 110*/
            this.attr_dic.Add("BoData", this.BoData);/*Optional 111*/
            this.attr_dic.Add("Status_Detail", this.Status_Detail);/*Optional 112*/
            this.attr_dic.Add("Doc_Deadline", this.Doc_Deadline);/*Optional 113*/
            this.attr_dic.Add("Kenmerk_Number", this.Kenmerk_Number);/*Optional 114*/
            this.attr_dic.Add("Kenmerk_Status", this.Kenmerk_Status);/*Optional 115*/
            this.attr_dic.Add("Kenmerk_Status_Date", this.Kenmerk_Status_Date);/*Optional 116*/
            this.attr_dic.Add("FileLinking_Status", this.FileLinking_Status);/*Optional 117*/
            this.attr_dic.Add("Filing_Attempts", this.Filing_Attempts);/*Optional 118*/
            this.attr_dic.Add("Kenmerk_Status_Reason", this.Kenmerk_Status_Reason);/*Optional 119*/
            this.attr_dic.Add("PaidViaDTCC", this.PaidViaDTCC);/*Optional 120*/
            this.attr_dic.Add("COI", this.COI);/*Optional 121*/
            this.attr_dic.Add("Par_ID", this.Par_ID);/*Optional 122*/
            this.attr_dic.Add("Depositary_FeesA_USD_Locked", this.Depositary_FeesA_USD_Locked);/*Optional 123*/
            this.attr_dic.Add("Payment_Cycle", this.Payment_Cycle);/*Optional 124*/
            this.attr_dic.Add("Payment_Cycle_DateTime", this.Payment_Cycle_DateTime);/*Optional 125*/
            this.attr_dic.Add("StatusUpdatedBy", this.StatusUpdatedBy);/*Optional 126*/
            this.attr_dic.Add("FundISIN", this.FundISIN);/*Optional 127*/
            this.attr_dic.Add("PurchaseDate", this.PurchaseDate);/*Optional 128*/
            this.attr_dic.Add("ORDNUNGS_NR", this.ORDNUNGS_NR);/*Optional 129*/
            this.attr_dic.Add("NewBoTaxID", this.NewBoTaxID);/*Optional 130*/
            this.attr_dic.Add("AuditStatus", this.AuditStatus);/*Optional 131*/
            this.attr_dic.Add("AuditStatusDate", this.AuditStatusDate);/*Optional 132*/
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
            HssUtility.SQLserver.DB_insert dbIns = new HssUtility.SQLserver.DB_insert(Dividend_Detail_full.Get_cmdTP());

            dbIns.AddValue("DividendIndex", this.DividendIndex);
            dbIns.AddValue("ClaimID", this.ClaimID);/*Optional 3*/
            dbIns.AddValue("Issue", this.Issue);
            dbIns.AddValue("DTC_Number", this.DTC_Number);
            dbIns.AddValue("DTC_Name", this.DTC_Name);/*Optional 6*/
            dbIns.AddValue("DTC_Address1", this.DTC_Address1);/*Optional 7*/
            dbIns.AddValue("DTC_Address2", this.DTC_Address2);/*Optional 8*/
            dbIns.AddValue("DTC_ATTN", this.DTC_ATTN);/*Optional 9*/
            dbIns.AddValue("Depositary", this.Depositary);/*Optional 10*/
            dbIns.AddValue("DTC_PositionID", this.DTC_PositionID);/*Optional 11*/
            dbIns.AddValue("BoName", this.BoName);/*Optional 12*/
            dbIns.AddValue("BoAddress1", this.BoAddress1);/*Optional 13*/
            dbIns.AddValue("BoAddress2", this.BoAddress2);/*Optional 14*/
            dbIns.AddValue("BoAddress3", this.BoAddress3);/*Optional 15*/
            dbIns.AddValue("BoAddress4", this.BoAddress4);/*Optional 16*/
            dbIns.AddValue("BoAddress5", this.BoAddress5);/*Optional 17*/
            dbIns.AddValue("BO_COR", this.BO_COR);/*Optional 18*/
            dbIns.AddValue("BO_EntityType", this.BO_EntityType);/*Optional 19*/
            dbIns.AddValue("BoTaxID", this.BoTaxID);/*Optional 20*/
            dbIns.AddValue("ReceivedDate", this.ReceivedDate);/*Optional 21*/
            dbIns.AddValue("ReclaimRate", this.ReclaimRate);/*Optional 22*/
            dbIns.AddValue("ClaimType", this.ClaimType);/*Optional 23*/
            dbIns.AddValue("Custodian", this.Custodian);/*Optional 24*/
            dbIns.AddValue("CustodianID", this.CustodianID);/*Optional 25*/
            dbIns.AddValue("ReclaimAmount", this.ReclaimAmount);/*Optional 26*/
            dbIns.AddValue("Status", this.Status);/*Optional 27*/
            dbIns.AddValue("CreatedDate", this.CreatedDate);/*Optional 28*/
            dbIns.AddValue("PaymentReferenceDate", this.PaymentReferenceDate);/*Optional 29*/
            dbIns.AddValue("RecordDatePosition", this.RecordDatePosition);/*Optional 30*/
            dbIns.AddValue("Internal_Ref_Number", this.Internal_Ref_Number);/*Optional 31*/
            dbIns.AddValue("Internal_Batch_Num", this.Internal_Batch_Num);/*Optional 32*/
            dbIns.AddValue("External_Client_Ref_Num", this.External_Client_Ref_Num);/*Optional 33*/
            dbIns.AddValue("External_Claim_Ref_Num", this.External_Claim_Ref_Num);/*Optional 34*/
            dbIns.AddValue("External_Batch_Num", this.External_Batch_Num);/*Optional 35*/
            dbIns.AddValue("Notes", this.Notes);/*Optional 36*/
            dbIns.AddValue("Dividend_FilingID", this.Dividend_FilingID);/*Optional 37*/
            dbIns.AddValue("Dividend_PayID", this.Dividend_PayID);/*Optional 38*/
            dbIns.AddValue("CurrentMode", this.CurrentMode);/*Optional 39*/
            dbIns.AddValue("Editor", this.Editor);/*Optional 40*/
            dbIns.AddValue("ReclaimFeesType", this.ReclaimFeesType);/*Optional 41*/
            dbIns.AddValue("Filing_Reference_Number", this.Filing_Reference_Number);/*Optional 42*/
            dbIns.AddValue("ModifiedDateTime", this.ModifiedDateTime);/*Optional 43*/
            dbIns.AddValue("LastModifiedBy", this.LastModifiedBy);/*Optional 44*/
            dbIns.AddValue("External_Service_Provider_Name", this.External_Service_Provider_Name);/*Optional 45*/
            dbIns.AddValue("NewRow", this.NewRow);
            dbIns.AddValue("Override_Fees", this.Override_Fees);/*Optional 47*/
            dbIns.AddValue("Residency_Percent", this.Residency_Percent);/*Optional 48*/
            dbIns.AddValue("EST_Time_To_Pay", this.EST_Time_To_Pay);/*Optional 49*/
            dbIns.AddValue("Override_Rate", this.Override_Rate);/*Optional 50*/
            dbIns.AddValue("Override_Custodial_Fees", this.Override_Custodial_Fees);/*Optional 51*/
            dbIns.AddValue("EntityType_France", this.EntityType_France);/*Optional 52*/
            dbIns.AddValue("Interest_Paid_EUR", this.Interest_Paid_EUR);/*Optional 53*/
            dbIns.AddValue("Custodial_Ref_Num", this.Custodial_Ref_Num);/*Optional 54*/
            dbIns.AddValue("Custodial_Report_Date", this.Custodial_Report_Date);/*Optional 55*/
            dbIns.AddValue("Custodial_Report_Status", this.Custodial_Report_Status);/*Optional 56*/
            dbIns.AddValue("LawOfEstablishment", this.LawOfEstablishment);/*Optional 57*/
            dbIns.AddValue("CERT", this.CERT);/*Optional 58*/
            dbIns.AddValue("Validation", this.Validation);/*Optional 59*/
            dbIns.AddValue("Validation_Reason", this.Validation_Reason);/*Optional 60*/
            dbIns.AddValue("Broker_BO_Name", this.Broker_BO_Name);/*Optional 61*/
            dbIns.AddValue("Paid_And_Locked", this.Paid_And_Locked);/*Optional 62*/
            dbIns.AddValue("Category", this.Category);/*Optional 63*/
            dbIns.AddValue("Name_Of_Underlying_Holder", this.Name_Of_Underlying_Holder);/*Optional 64*/
            dbIns.AddValue("Entity_Name", this.Entity_Name);/*Optional 65*/
            dbIns.AddValue("PercentOfShares_Held_UH", this.PercentOfShares_Held_UH);/*Optional 66*/
            dbIns.AddValue("RSHID", this.RSHID);/*Optional 67*/
            dbIns.AddValue("ParentID", this.ParentID);/*Optional 68*/
            dbIns.AddValue("ThreadID", this.ThreadID);/*Optional 69*/
            dbIns.AddValue("ESPAccountNumber", this.ESPAccountNumber);/*Optional 70*/
            dbIns.AddValue("Tier", this.Tier);/*Optional 71*/
            dbIns.AddValue("Tier2AccountNumber", this.Tier2AccountNumber);/*Optional 72*/
            dbIns.AddValue("Tier3AccountNumber", this.Tier3AccountNumber);/*Optional 73*/
            dbIns.AddValue("Tier4AccountNumber", this.Tier4AccountNumber);/*Optional 74*/
            dbIns.AddValue("Tier5AccountNumber", this.Tier5AccountNumber);/*Optional 75*/
            dbIns.AddValue("ClientID", this.ClientID);
            dbIns.AddValue("Designated", this.Designated);/*Optional 77*/
            dbIns.AddValue("PID", this.PID);
            dbIns.AddValue("BOIndex", this.BOIndex);/*Optional 79*/
            dbIns.AddValue("TotalParticipants", this.TotalParticipants);/*Optional 80*/
            dbIns.AddValue("TotalTreatyParticipants", this.TotalTreatyParticipants);/*Optional 81*/
            dbIns.AddValue("DateOfFiscalYearEnd", this.DateOfFiscalYearEnd);/*Optional 82*/
            dbIns.AddValue("RejectReasons", this.RejectReasons);/*Optional 83*/
            dbIns.AddValue("Tier6AccountNumber", this.Tier6AccountNumber);/*Optional 84*/
            dbIns.AddValue("Tier7AccountNumber", this.Tier7AccountNumber);/*Optional 85*/
            dbIns.AddValue("BoEmail", this.BoEmail);/*Optional 86*/
            dbIns.AddValue("BOAccountNumber", this.BOAccountNumber);/*Optional 87*/
            dbIns.AddValue("StatusDate", this.StatusDate);/*Optional 88*/
            dbIns.AddValue("RejectParty", this.RejectParty);/*Optional 89*/
            dbIns.AddValue("AuditDeadline", this.AuditDeadline);/*Optional 90*/
            dbIns.AddValue("ExtensionRequested", this.ExtensionRequested);/*Optional 91*/
            dbIns.AddValue("ExtensionDeadline", this.ExtensionDeadline);/*Optional 92*/
            dbIns.AddValue("ElectionOption", this.ElectionOption);/*Optional 93*/
            dbIns.AddValue("DocStatus_ESP", this.DocStatus_ESP);/*Optional 94*/
            dbIns.AddValue("DocStatus", this.DocStatus);/*Optional 95*/
            dbIns.AddValue("boclient_id", this.boclient_id);/*Optional 96*/
            dbIns.AddValue("pension_plan", this.pension_plan);/*Optional 97*/
            dbIns.AddValue("VoucherStatus", this.VoucherStatus);/*Optional 98*/
            dbIns.AddValue("VoucherDate", this.VoucherDate);/*Optional 99*/
            dbIns.AddValue("LocalMarketID", this.LocalMarketID);/*Optional 100*/
            dbIns.AddValue("Dividend_RejectionID", this.Dividend_RejectionID);/*Optional 101*/
            dbIns.AddValue("Depositary_Fees_USD_Locked", this.Depositary_Fees_USD_Locked);/*Optional 102*/
            dbIns.AddValue("Custodial_Fees_EUR_Locked", this.Custodial_Fees_EUR_Locked);/*Optional 103*/
            dbIns.AddValue("Custodial_Fees_USD_Locked", this.Custodial_Fees_USD_Locked);/*Optional 104*/
            dbIns.AddValue("Net_Amount_Paid_USD_Locked", this.Net_Amount_Paid_USD_Locked);/*Optional 105*/
            dbIns.AddValue("Net_Amount_Paid_EUR_Locked", this.Net_Amount_Paid_EUR_Locked);/*Optional 106*/
            dbIns.AddValue("BoBirthDate", this.BoBirthDate);/*Optional 107*/
            dbIns.AddValue("BoLastName", this.BoLastName);/*Optional 108*/
            dbIns.AddValue("BoFirstName", this.BoFirstName);/*Optional 109*/
            dbIns.AddValue("ClientListingID", this.ClientListingID);/*Optional 110*/
            dbIns.AddValue("BoData", this.BoData);/*Optional 111*/
            dbIns.AddValue("Status_Detail", this.Status_Detail);/*Optional 112*/
            dbIns.AddValue("Doc_Deadline", this.Doc_Deadline);/*Optional 113*/
            dbIns.AddValue("Kenmerk_Number", this.Kenmerk_Number);/*Optional 114*/
            dbIns.AddValue("Kenmerk_Status", this.Kenmerk_Status);/*Optional 115*/
            dbIns.AddValue("Kenmerk_Status_Date", this.Kenmerk_Status_Date);/*Optional 116*/
            dbIns.AddValue("FileLinking_Status", this.FileLinking_Status);/*Optional 117*/
            dbIns.AddValue("Filing_Attempts", this.Filing_Attempts);/*Optional 118*/
            dbIns.AddValue("Kenmerk_Status_Reason", this.Kenmerk_Status_Reason);/*Optional 119*/
            dbIns.AddValue("PaidViaDTCC", this.PaidViaDTCC);/*Optional 120*/
            dbIns.AddValue("COI", this.COI);/*Optional 121*/
            dbIns.AddValue("Par_ID", this.Par_ID);/*Optional 122*/
            dbIns.AddValue("Depositary_FeesA_USD_Locked", this.Depositary_FeesA_USD_Locked);/*Optional 123*/
            dbIns.AddValue("Payment_Cycle", this.Payment_Cycle);/*Optional 124*/
            dbIns.AddValue("Payment_Cycle_DateTime", this.Payment_Cycle_DateTime);/*Optional 125*/
            dbIns.AddValue("StatusUpdatedBy", this.StatusUpdatedBy);/*Optional 126*/
            dbIns.AddValue("FundISIN", this.FundISIN);/*Optional 127*/
            dbIns.AddValue("PurchaseDate", this.PurchaseDate);/*Optional 128*/
            dbIns.AddValue("ORDNUNGS_NR", this.ORDNUNGS_NR);/*Optional 129*/
            dbIns.AddValue("NewBoTaxID", this.NewBoTaxID);/*Optional 130*/
            dbIns.AddValue("AuditStatus", this.AuditStatus);/*Optional 131*/
            dbIns.AddValue("AuditStatusDate", this.AuditStatusDate);/*Optional 132*/

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

            HssUtility.SQLserver.DB_update upd = new HssUtility.SQLserver.DB_update(Dividend_Detail_full.Get_cmdTP());
            if (this.DividendIndex.ValueChanged) upd.AddValue("DividendIndex", this.DividendIndex);
            if (this.ClaimID.ValueChanged) upd.AddValue("ClaimID", this.ClaimID);/*Optional 3*/
            if (this.Issue.ValueChanged) upd.AddValue("Issue", this.Issue);
            if (this.DTC_Number.ValueChanged) upd.AddValue("DTC_Number", this.DTC_Number);
            if (this.DTC_Name.ValueChanged) upd.AddValue("DTC_Name", this.DTC_Name);/*Optional 6*/
            if (this.DTC_Address1.ValueChanged) upd.AddValue("DTC_Address1", this.DTC_Address1);/*Optional 7*/
            if (this.DTC_Address2.ValueChanged) upd.AddValue("DTC_Address2", this.DTC_Address2);/*Optional 8*/
            if (this.DTC_ATTN.ValueChanged) upd.AddValue("DTC_ATTN", this.DTC_ATTN);/*Optional 9*/
            if (this.Depositary.ValueChanged) upd.AddValue("Depositary", this.Depositary);/*Optional 10*/
            if (this.DTC_PositionID.ValueChanged) upd.AddValue("DTC_PositionID", this.DTC_PositionID);/*Optional 11*/
            if (this.BoName.ValueChanged) upd.AddValue("BoName", this.BoName);/*Optional 12*/
            if (this.BoAddress1.ValueChanged) upd.AddValue("BoAddress1", this.BoAddress1);/*Optional 13*/
            if (this.BoAddress2.ValueChanged) upd.AddValue("BoAddress2", this.BoAddress2);/*Optional 14*/
            if (this.BoAddress3.ValueChanged) upd.AddValue("BoAddress3", this.BoAddress3);/*Optional 15*/
            if (this.BoAddress4.ValueChanged) upd.AddValue("BoAddress4", this.BoAddress4);/*Optional 16*/
            if (this.BoAddress5.ValueChanged) upd.AddValue("BoAddress5", this.BoAddress5);/*Optional 17*/
            if (this.BO_COR.ValueChanged) upd.AddValue("BO_COR", this.BO_COR);/*Optional 18*/
            if (this.BO_EntityType.ValueChanged) upd.AddValue("BO_EntityType", this.BO_EntityType);/*Optional 19*/
            if (this.BoTaxID.ValueChanged) upd.AddValue("BoTaxID", this.BoTaxID);/*Optional 20*/
            if (this.ReceivedDate.ValueChanged) upd.AddValue("ReceivedDate", this.ReceivedDate);/*Optional 21*/
            if (this.ReclaimRate.ValueChanged) upd.AddValue("ReclaimRate", this.ReclaimRate);/*Optional 22*/
            if (this.ClaimType.ValueChanged) upd.AddValue("ClaimType", this.ClaimType);/*Optional 23*/
            if (this.Custodian.ValueChanged) upd.AddValue("Custodian", this.Custodian);/*Optional 24*/
            if (this.CustodianID.ValueChanged) upd.AddValue("CustodianID", this.CustodianID);/*Optional 25*/
            if (this.ReclaimAmount.ValueChanged) upd.AddValue("ReclaimAmount", this.ReclaimAmount);/*Optional 26*/
            if (this.Status.ValueChanged) upd.AddValue("Status", this.Status);/*Optional 27*/
            if (this.CreatedDate.ValueChanged) upd.AddValue("CreatedDate", this.CreatedDate);/*Optional 28*/
            if (this.PaymentReferenceDate.ValueChanged) upd.AddValue("PaymentReferenceDate", this.PaymentReferenceDate);/*Optional 29*/
            if (this.RecordDatePosition.ValueChanged) upd.AddValue("RecordDatePosition", this.RecordDatePosition);/*Optional 30*/
            if (this.Internal_Ref_Number.ValueChanged) upd.AddValue("Internal_Ref_Number", this.Internal_Ref_Number);/*Optional 31*/
            if (this.Internal_Batch_Num.ValueChanged) upd.AddValue("Internal_Batch_Num", this.Internal_Batch_Num);/*Optional 32*/
            if (this.External_Client_Ref_Num.ValueChanged) upd.AddValue("External_Client_Ref_Num", this.External_Client_Ref_Num);/*Optional 33*/
            if (this.External_Claim_Ref_Num.ValueChanged) upd.AddValue("External_Claim_Ref_Num", this.External_Claim_Ref_Num);/*Optional 34*/
            if (this.External_Batch_Num.ValueChanged) upd.AddValue("External_Batch_Num", this.External_Batch_Num);/*Optional 35*/
            if (this.Notes.ValueChanged) upd.AddValue("Notes", this.Notes);/*Optional 36*/
            if (this.Dividend_FilingID.ValueChanged) upd.AddValue("Dividend_FilingID", this.Dividend_FilingID);/*Optional 37*/
            if (this.Dividend_PayID.ValueChanged) upd.AddValue("Dividend_PayID", this.Dividend_PayID);/*Optional 38*/
            if (this.CurrentMode.ValueChanged) upd.AddValue("CurrentMode", this.CurrentMode);/*Optional 39*/
            if (this.Editor.ValueChanged) upd.AddValue("Editor", this.Editor);/*Optional 40*/
            if (this.ReclaimFeesType.ValueChanged) upd.AddValue("ReclaimFeesType", this.ReclaimFeesType);/*Optional 41*/
            if (this.Filing_Reference_Number.ValueChanged) upd.AddValue("Filing_Reference_Number", this.Filing_Reference_Number);/*Optional 42*/
            if (this.ModifiedDateTime.ValueChanged) upd.AddValue("ModifiedDateTime", this.ModifiedDateTime);/*Optional 43*/
            if (this.LastModifiedBy.ValueChanged) upd.AddValue("LastModifiedBy", this.LastModifiedBy);/*Optional 44*/
            if (this.External_Service_Provider_Name.ValueChanged) upd.AddValue("External_Service_Provider_Name", this.External_Service_Provider_Name);/*Optional 45*/
            if (this.NewRow.ValueChanged) upd.AddValue("NewRow", this.NewRow);
            if (this.Override_Fees.ValueChanged) upd.AddValue("Override_Fees", this.Override_Fees);/*Optional 47*/
            if (this.Residency_Percent.ValueChanged) upd.AddValue("Residency_Percent", this.Residency_Percent);/*Optional 48*/
            if (this.EST_Time_To_Pay.ValueChanged) upd.AddValue("EST_Time_To_Pay", this.EST_Time_To_Pay);/*Optional 49*/
            if (this.Override_Rate.ValueChanged) upd.AddValue("Override_Rate", this.Override_Rate);/*Optional 50*/
            if (this.Override_Custodial_Fees.ValueChanged) upd.AddValue("Override_Custodial_Fees", this.Override_Custodial_Fees);/*Optional 51*/
            if (this.EntityType_France.ValueChanged) upd.AddValue("EntityType_France", this.EntityType_France);/*Optional 52*/
            if (this.Interest_Paid_EUR.ValueChanged) upd.AddValue("Interest_Paid_EUR", this.Interest_Paid_EUR);/*Optional 53*/
            if (this.Custodial_Ref_Num.ValueChanged) upd.AddValue("Custodial_Ref_Num", this.Custodial_Ref_Num);/*Optional 54*/
            if (this.Custodial_Report_Date.ValueChanged) upd.AddValue("Custodial_Report_Date", this.Custodial_Report_Date);/*Optional 55*/
            if (this.Custodial_Report_Status.ValueChanged) upd.AddValue("Custodial_Report_Status", this.Custodial_Report_Status);/*Optional 56*/
            if (this.LawOfEstablishment.ValueChanged) upd.AddValue("LawOfEstablishment", this.LawOfEstablishment);/*Optional 57*/
            if (this.CERT.ValueChanged) upd.AddValue("CERT", this.CERT);/*Optional 58*/
            if (this.Validation.ValueChanged) upd.AddValue("Validation", this.Validation);/*Optional 59*/
            if (this.Validation_Reason.ValueChanged) upd.AddValue("Validation_Reason", this.Validation_Reason);/*Optional 60*/
            if (this.Broker_BO_Name.ValueChanged) upd.AddValue("Broker_BO_Name", this.Broker_BO_Name);/*Optional 61*/
            if (this.Paid_And_Locked.ValueChanged) upd.AddValue("Paid_And_Locked", this.Paid_And_Locked);/*Optional 62*/
            if (this.Category.ValueChanged) upd.AddValue("Category", this.Category);/*Optional 63*/
            if (this.Name_Of_Underlying_Holder.ValueChanged) upd.AddValue("Name_Of_Underlying_Holder", this.Name_Of_Underlying_Holder);/*Optional 64*/
            if (this.Entity_Name.ValueChanged) upd.AddValue("Entity_Name", this.Entity_Name);/*Optional 65*/
            if (this.PercentOfShares_Held_UH.ValueChanged) upd.AddValue("PercentOfShares_Held_UH", this.PercentOfShares_Held_UH);/*Optional 66*/
            if (this.RSHID.ValueChanged) upd.AddValue("RSHID", this.RSHID);/*Optional 67*/
            if (this.ParentID.ValueChanged) upd.AddValue("ParentID", this.ParentID);/*Optional 68*/
            if (this.ThreadID.ValueChanged) upd.AddValue("ThreadID", this.ThreadID);/*Optional 69*/
            if (this.ESPAccountNumber.ValueChanged) upd.AddValue("ESPAccountNumber", this.ESPAccountNumber);/*Optional 70*/
            if (this.Tier.ValueChanged) upd.AddValue("Tier", this.Tier);/*Optional 71*/
            if (this.Tier2AccountNumber.ValueChanged) upd.AddValue("Tier2AccountNumber", this.Tier2AccountNumber);/*Optional 72*/
            if (this.Tier3AccountNumber.ValueChanged) upd.AddValue("Tier3AccountNumber", this.Tier3AccountNumber);/*Optional 73*/
            if (this.Tier4AccountNumber.ValueChanged) upd.AddValue("Tier4AccountNumber", this.Tier4AccountNumber);/*Optional 74*/
            if (this.Tier5AccountNumber.ValueChanged) upd.AddValue("Tier5AccountNumber", this.Tier5AccountNumber);/*Optional 75*/
            if (this.ClientID.ValueChanged) upd.AddValue("ClientID", this.ClientID);
            if (this.Designated.ValueChanged) upd.AddValue("Designated", this.Designated);/*Optional 77*/
            if (this.PID.ValueChanged) upd.AddValue("PID", this.PID);
            if (this.BOIndex.ValueChanged) upd.AddValue("BOIndex", this.BOIndex);/*Optional 79*/
            if (this.TotalParticipants.ValueChanged) upd.AddValue("TotalParticipants", this.TotalParticipants);/*Optional 80*/
            if (this.TotalTreatyParticipants.ValueChanged) upd.AddValue("TotalTreatyParticipants", this.TotalTreatyParticipants);/*Optional 81*/
            if (this.DateOfFiscalYearEnd.ValueChanged) upd.AddValue("DateOfFiscalYearEnd", this.DateOfFiscalYearEnd);/*Optional 82*/
            if (this.RejectReasons.ValueChanged) upd.AddValue("RejectReasons", this.RejectReasons);/*Optional 83*/
            if (this.Tier6AccountNumber.ValueChanged) upd.AddValue("Tier6AccountNumber", this.Tier6AccountNumber);/*Optional 84*/
            if (this.Tier7AccountNumber.ValueChanged) upd.AddValue("Tier7AccountNumber", this.Tier7AccountNumber);/*Optional 85*/
            if (this.BoEmail.ValueChanged) upd.AddValue("BoEmail", this.BoEmail);/*Optional 86*/
            if (this.BOAccountNumber.ValueChanged) upd.AddValue("BOAccountNumber", this.BOAccountNumber);/*Optional 87*/
            if (this.StatusDate.ValueChanged) upd.AddValue("StatusDate", this.StatusDate);/*Optional 88*/
            if (this.RejectParty.ValueChanged) upd.AddValue("RejectParty", this.RejectParty);/*Optional 89*/
            if (this.AuditDeadline.ValueChanged) upd.AddValue("AuditDeadline", this.AuditDeadline);/*Optional 90*/
            if (this.ExtensionRequested.ValueChanged) upd.AddValue("ExtensionRequested", this.ExtensionRequested);/*Optional 91*/
            if (this.ExtensionDeadline.ValueChanged) upd.AddValue("ExtensionDeadline", this.ExtensionDeadline);/*Optional 92*/
            if (this.ElectionOption.ValueChanged) upd.AddValue("ElectionOption", this.ElectionOption);/*Optional 93*/
            if (this.DocStatus_ESP.ValueChanged) upd.AddValue("DocStatus_ESP", this.DocStatus_ESP);/*Optional 94*/
            if (this.DocStatus.ValueChanged) upd.AddValue("DocStatus", this.DocStatus);/*Optional 95*/
            if (this.boclient_id.ValueChanged) upd.AddValue("boclient_id", this.boclient_id);/*Optional 96*/
            if (this.pension_plan.ValueChanged) upd.AddValue("pension_plan", this.pension_plan);/*Optional 97*/
            if (this.VoucherStatus.ValueChanged) upd.AddValue("VoucherStatus", this.VoucherStatus);/*Optional 98*/
            if (this.VoucherDate.ValueChanged) upd.AddValue("VoucherDate", this.VoucherDate);/*Optional 99*/
            if (this.LocalMarketID.ValueChanged) upd.AddValue("LocalMarketID", this.LocalMarketID);/*Optional 100*/
            if (this.Dividend_RejectionID.ValueChanged) upd.AddValue("Dividend_RejectionID", this.Dividend_RejectionID);/*Optional 101*/
            if (this.Depositary_Fees_USD_Locked.ValueChanged) upd.AddValue("Depositary_Fees_USD_Locked", this.Depositary_Fees_USD_Locked);/*Optional 102*/
            if (this.Custodial_Fees_EUR_Locked.ValueChanged) upd.AddValue("Custodial_Fees_EUR_Locked", this.Custodial_Fees_EUR_Locked);/*Optional 103*/
            if (this.Custodial_Fees_USD_Locked.ValueChanged) upd.AddValue("Custodial_Fees_USD_Locked", this.Custodial_Fees_USD_Locked);/*Optional 104*/
            if (this.Net_Amount_Paid_USD_Locked.ValueChanged) upd.AddValue("Net_Amount_Paid_USD_Locked", this.Net_Amount_Paid_USD_Locked);/*Optional 105*/
            if (this.Net_Amount_Paid_EUR_Locked.ValueChanged) upd.AddValue("Net_Amount_Paid_EUR_Locked", this.Net_Amount_Paid_EUR_Locked);/*Optional 106*/
            if (this.BoBirthDate.ValueChanged) upd.AddValue("BoBirthDate", this.BoBirthDate);/*Optional 107*/
            if (this.BoLastName.ValueChanged) upd.AddValue("BoLastName", this.BoLastName);/*Optional 108*/
            if (this.BoFirstName.ValueChanged) upd.AddValue("BoFirstName", this.BoFirstName);/*Optional 109*/
            if (this.ClientListingID.ValueChanged) upd.AddValue("ClientListingID", this.ClientListingID);/*Optional 110*/
            if (this.BoData.ValueChanged) upd.AddValue("BoData", this.BoData);/*Optional 111*/
            if (this.Status_Detail.ValueChanged) upd.AddValue("Status_Detail", this.Status_Detail);/*Optional 112*/
            if (this.Doc_Deadline.ValueChanged) upd.AddValue("Doc_Deadline", this.Doc_Deadline);/*Optional 113*/
            if (this.Kenmerk_Number.ValueChanged) upd.AddValue("Kenmerk_Number", this.Kenmerk_Number);/*Optional 114*/
            if (this.Kenmerk_Status.ValueChanged) upd.AddValue("Kenmerk_Status", this.Kenmerk_Status);/*Optional 115*/
            if (this.Kenmerk_Status_Date.ValueChanged) upd.AddValue("Kenmerk_Status_Date", this.Kenmerk_Status_Date);/*Optional 116*/
            if (this.FileLinking_Status.ValueChanged) upd.AddValue("FileLinking_Status", this.FileLinking_Status);/*Optional 117*/
            if (this.Filing_Attempts.ValueChanged) upd.AddValue("Filing_Attempts", this.Filing_Attempts);/*Optional 118*/
            if (this.Kenmerk_Status_Reason.ValueChanged) upd.AddValue("Kenmerk_Status_Reason", this.Kenmerk_Status_Reason);/*Optional 119*/
            if (this.PaidViaDTCC.ValueChanged) upd.AddValue("PaidViaDTCC", this.PaidViaDTCC);/*Optional 120*/
            if (this.COI.ValueChanged) upd.AddValue("COI", this.COI);/*Optional 121*/
            if (this.Par_ID.ValueChanged) upd.AddValue("Par_ID", this.Par_ID);/*Optional 122*/
            if (this.Depositary_FeesA_USD_Locked.ValueChanged) upd.AddValue("Depositary_FeesA_USD_Locked", this.Depositary_FeesA_USD_Locked);/*Optional 123*/
            if (this.Payment_Cycle.ValueChanged) upd.AddValue("Payment_Cycle", this.Payment_Cycle);/*Optional 124*/
            if (this.Payment_Cycle_DateTime.ValueChanged) upd.AddValue("Payment_Cycle_DateTime", this.Payment_Cycle_DateTime);/*Optional 125*/
            if (this.StatusUpdatedBy.ValueChanged) upd.AddValue("StatusUpdatedBy", this.StatusUpdatedBy);/*Optional 126*/
            if (this.FundISIN.ValueChanged) upd.AddValue("FundISIN", this.FundISIN);/*Optional 127*/
            if (this.PurchaseDate.ValueChanged) upd.AddValue("PurchaseDate", this.PurchaseDate);/*Optional 128*/
            if (this.ORDNUNGS_NR.ValueChanged) upd.AddValue("ORDNUNGS_NR", this.ORDNUNGS_NR);/*Optional 129*/
            if (this.NewBoTaxID.ValueChanged) upd.AddValue("NewBoTaxID", this.NewBoTaxID);/*Optional 130*/
            if (this.AuditStatus.ValueChanged) upd.AddValue("AuditStatus", this.AuditStatus);/*Optional 131*/
            if (this.AuditStatusDate.ValueChanged) upd.AddValue("AuditStatusDate", this.AuditStatusDate);/*Optional 132*/

            HssUtility.SQLserver.SQL_relation rela = new HssUtility.SQLserver.SQL_relation("DetailID", HssUtility.General.RelationalOperator.Equals, this.pk_ID);
            upd.SetCondition(rela);

            return upd;
        }

        public Dividend_Detail_full GetCopy()
        {
            Dividend_Detail_full newEntity = new Dividend_Detail_full();
            if (!this.DividendIndex.IsNull_flag) newEntity.DividendIndex.Value = this.DividendIndex.Value;
            if (!this.ClaimID.IsNull_flag) newEntity.ClaimID.Value = this.ClaimID.Value;
            if (!this.Issue.IsNull_flag) newEntity.Issue.Value = this.Issue.Value;
            if (!this.DTC_Number.IsNull_flag) newEntity.DTC_Number.Value = this.DTC_Number.Value;
            if (!this.DTC_Name.IsNull_flag) newEntity.DTC_Name.Value = this.DTC_Name.Value;
            if (!this.DTC_Address1.IsNull_flag) newEntity.DTC_Address1.Value = this.DTC_Address1.Value;
            if (!this.DTC_Address2.IsNull_flag) newEntity.DTC_Address2.Value = this.DTC_Address2.Value;
            if (!this.DTC_ATTN.IsNull_flag) newEntity.DTC_ATTN.Value = this.DTC_ATTN.Value;
            if (!this.Depositary.IsNull_flag) newEntity.Depositary.Value = this.Depositary.Value;
            if (!this.DTC_PositionID.IsNull_flag) newEntity.DTC_PositionID.Value = this.DTC_PositionID.Value;
            if (!this.BoName.IsNull_flag) newEntity.BoName.Value = this.BoName.Value;
            if (!this.BoAddress1.IsNull_flag) newEntity.BoAddress1.Value = this.BoAddress1.Value;
            if (!this.BoAddress2.IsNull_flag) newEntity.BoAddress2.Value = this.BoAddress2.Value;
            if (!this.BoAddress3.IsNull_flag) newEntity.BoAddress3.Value = this.BoAddress3.Value;
            if (!this.BoAddress4.IsNull_flag) newEntity.BoAddress4.Value = this.BoAddress4.Value;
            if (!this.BoAddress5.IsNull_flag) newEntity.BoAddress5.Value = this.BoAddress5.Value;
            if (!this.BO_COR.IsNull_flag) newEntity.BO_COR.Value = this.BO_COR.Value;
            if (!this.BO_EntityType.IsNull_flag) newEntity.BO_EntityType.Value = this.BO_EntityType.Value;
            if (!this.BoTaxID.IsNull_flag) newEntity.BoTaxID.Value = this.BoTaxID.Value;
            if (!this.ReceivedDate.IsNull_flag) newEntity.ReceivedDate.Value = this.ReceivedDate.Value;
            if (!this.ReclaimRate.IsNull_flag) newEntity.ReclaimRate.Value = this.ReclaimRate.Value;
            if (!this.ClaimType.IsNull_flag) newEntity.ClaimType.Value = this.ClaimType.Value;
            if (!this.Custodian.IsNull_flag) newEntity.Custodian.Value = this.Custodian.Value;
            if (!this.CustodianID.IsNull_flag) newEntity.CustodianID.Value = this.CustodianID.Value;
            if (!this.ReclaimAmount.IsNull_flag) newEntity.ReclaimAmount.Value = this.ReclaimAmount.Value;
            if (!this.Status.IsNull_flag) newEntity.Status.Value = this.Status.Value;
            if (!this.CreatedDate.IsNull_flag) newEntity.CreatedDate.Value = this.CreatedDate.Value;
            if (!this.PaymentReferenceDate.IsNull_flag) newEntity.PaymentReferenceDate.Value = this.PaymentReferenceDate.Value;
            if (!this.RecordDatePosition.IsNull_flag) newEntity.RecordDatePosition.Value = this.RecordDatePosition.Value;
            if (!this.Internal_Ref_Number.IsNull_flag) newEntity.Internal_Ref_Number.Value = this.Internal_Ref_Number.Value;
            if (!this.Internal_Batch_Num.IsNull_flag) newEntity.Internal_Batch_Num.Value = this.Internal_Batch_Num.Value;
            if (!this.External_Client_Ref_Num.IsNull_flag) newEntity.External_Client_Ref_Num.Value = this.External_Client_Ref_Num.Value;
            if (!this.External_Claim_Ref_Num.IsNull_flag) newEntity.External_Claim_Ref_Num.Value = this.External_Claim_Ref_Num.Value;
            if (!this.External_Batch_Num.IsNull_flag) newEntity.External_Batch_Num.Value = this.External_Batch_Num.Value;
            if (!this.Notes.IsNull_flag) newEntity.Notes.Value = this.Notes.Value;
            if (!this.Dividend_FilingID.IsNull_flag) newEntity.Dividend_FilingID.Value = this.Dividend_FilingID.Value;
            if (!this.Dividend_PayID.IsNull_flag) newEntity.Dividend_PayID.Value = this.Dividend_PayID.Value;
            if (!this.CurrentMode.IsNull_flag) newEntity.CurrentMode.Value = this.CurrentMode.Value;
            if (!this.Editor.IsNull_flag) newEntity.Editor.Value = this.Editor.Value;
            if (!this.ReclaimFeesType.IsNull_flag) newEntity.ReclaimFeesType.Value = this.ReclaimFeesType.Value;
            if (!this.Filing_Reference_Number.IsNull_flag) newEntity.Filing_Reference_Number.Value = this.Filing_Reference_Number.Value;
            if (!this.ModifiedDateTime.IsNull_flag) newEntity.ModifiedDateTime.Value = this.ModifiedDateTime.Value;
            if (!this.LastModifiedBy.IsNull_flag) newEntity.LastModifiedBy.Value = this.LastModifiedBy.Value;
            if (!this.External_Service_Provider_Name.IsNull_flag) newEntity.External_Service_Provider_Name.Value = this.External_Service_Provider_Name.Value;
            if (!this.NewRow.IsNull_flag) newEntity.NewRow.Value = this.NewRow.Value;
            if (!this.Override_Fees.IsNull_flag) newEntity.Override_Fees.Value = this.Override_Fees.Value;
            if (!this.Residency_Percent.IsNull_flag) newEntity.Residency_Percent.Value = this.Residency_Percent.Value;
            if (!this.EST_Time_To_Pay.IsNull_flag) newEntity.EST_Time_To_Pay.Value = this.EST_Time_To_Pay.Value;
            if (!this.Override_Rate.IsNull_flag) newEntity.Override_Rate.Value = this.Override_Rate.Value;
            if (!this.Override_Custodial_Fees.IsNull_flag) newEntity.Override_Custodial_Fees.Value = this.Override_Custodial_Fees.Value;
            if (!this.EntityType_France.IsNull_flag) newEntity.EntityType_France.Value = this.EntityType_France.Value;
            if (!this.Interest_Paid_EUR.IsNull_flag) newEntity.Interest_Paid_EUR.Value = this.Interest_Paid_EUR.Value;
            if (!this.Custodial_Ref_Num.IsNull_flag) newEntity.Custodial_Ref_Num.Value = this.Custodial_Ref_Num.Value;
            if (!this.Custodial_Report_Date.IsNull_flag) newEntity.Custodial_Report_Date.Value = this.Custodial_Report_Date.Value;
            if (!this.Custodial_Report_Status.IsNull_flag) newEntity.Custodial_Report_Status.Value = this.Custodial_Report_Status.Value;
            if (!this.LawOfEstablishment.IsNull_flag) newEntity.LawOfEstablishment.Value = this.LawOfEstablishment.Value;
            if (!this.CERT.IsNull_flag) newEntity.CERT.Value = this.CERT.Value;
            if (!this.Validation.IsNull_flag) newEntity.Validation.Value = this.Validation.Value;
            if (!this.Validation_Reason.IsNull_flag) newEntity.Validation_Reason.Value = this.Validation_Reason.Value;
            if (!this.Broker_BO_Name.IsNull_flag) newEntity.Broker_BO_Name.Value = this.Broker_BO_Name.Value;
            if (!this.Paid_And_Locked.IsNull_flag) newEntity.Paid_And_Locked.Value = this.Paid_And_Locked.Value;
            if (!this.Category.IsNull_flag) newEntity.Category.Value = this.Category.Value;
            if (!this.Name_Of_Underlying_Holder.IsNull_flag) newEntity.Name_Of_Underlying_Holder.Value = this.Name_Of_Underlying_Holder.Value;
            if (!this.Entity_Name.IsNull_flag) newEntity.Entity_Name.Value = this.Entity_Name.Value;
            if (!this.PercentOfShares_Held_UH.IsNull_flag) newEntity.PercentOfShares_Held_UH.Value = this.PercentOfShares_Held_UH.Value;
            if (!this.RSHID.IsNull_flag) newEntity.RSHID.Value = this.RSHID.Value;
            if (!this.ParentID.IsNull_flag) newEntity.ParentID.Value = this.ParentID.Value;
            if (!this.ThreadID.IsNull_flag) newEntity.ThreadID.Value = this.ThreadID.Value;
            if (!this.ESPAccountNumber.IsNull_flag) newEntity.ESPAccountNumber.Value = this.ESPAccountNumber.Value;
            if (!this.Tier.IsNull_flag) newEntity.Tier.Value = this.Tier.Value;
            if (!this.Tier2AccountNumber.IsNull_flag) newEntity.Tier2AccountNumber.Value = this.Tier2AccountNumber.Value;
            if (!this.Tier3AccountNumber.IsNull_flag) newEntity.Tier3AccountNumber.Value = this.Tier3AccountNumber.Value;
            if (!this.Tier4AccountNumber.IsNull_flag) newEntity.Tier4AccountNumber.Value = this.Tier4AccountNumber.Value;
            if (!this.Tier5AccountNumber.IsNull_flag) newEntity.Tier5AccountNumber.Value = this.Tier5AccountNumber.Value;
            if (!this.ClientID.IsNull_flag) newEntity.ClientID.Value = this.ClientID.Value;
            if (!this.Designated.IsNull_flag) newEntity.Designated.Value = this.Designated.Value;
            if (!this.PID.IsNull_flag) newEntity.PID.Value = this.PID.Value;
            if (!this.BOIndex.IsNull_flag) newEntity.BOIndex.Value = this.BOIndex.Value;
            if (!this.TotalParticipants.IsNull_flag) newEntity.TotalParticipants.Value = this.TotalParticipants.Value;
            if (!this.TotalTreatyParticipants.IsNull_flag) newEntity.TotalTreatyParticipants.Value = this.TotalTreatyParticipants.Value;
            if (!this.DateOfFiscalYearEnd.IsNull_flag) newEntity.DateOfFiscalYearEnd.Value = this.DateOfFiscalYearEnd.Value;
            if (!this.RejectReasons.IsNull_flag) newEntity.RejectReasons.Value = this.RejectReasons.Value;
            if (!this.Tier6AccountNumber.IsNull_flag) newEntity.Tier6AccountNumber.Value = this.Tier6AccountNumber.Value;
            if (!this.Tier7AccountNumber.IsNull_flag) newEntity.Tier7AccountNumber.Value = this.Tier7AccountNumber.Value;
            if (!this.BoEmail.IsNull_flag) newEntity.BoEmail.Value = this.BoEmail.Value;
            if (!this.BOAccountNumber.IsNull_flag) newEntity.BOAccountNumber.Value = this.BOAccountNumber.Value;
            if (!this.StatusDate.IsNull_flag) newEntity.StatusDate.Value = this.StatusDate.Value;
            if (!this.RejectParty.IsNull_flag) newEntity.RejectParty.Value = this.RejectParty.Value;
            if (!this.AuditDeadline.IsNull_flag) newEntity.AuditDeadline.Value = this.AuditDeadline.Value;
            if (!this.ExtensionRequested.IsNull_flag) newEntity.ExtensionRequested.Value = this.ExtensionRequested.Value;
            if (!this.ExtensionDeadline.IsNull_flag) newEntity.ExtensionDeadline.Value = this.ExtensionDeadline.Value;
            if (!this.ElectionOption.IsNull_flag) newEntity.ElectionOption.Value = this.ElectionOption.Value;
            if (!this.DocStatus_ESP.IsNull_flag) newEntity.DocStatus_ESP.Value = this.DocStatus_ESP.Value;
            if (!this.DocStatus.IsNull_flag) newEntity.DocStatus.Value = this.DocStatus.Value;
            if (!this.boclient_id.IsNull_flag) newEntity.boclient_id.Value = this.boclient_id.Value;
            if (!this.pension_plan.IsNull_flag) newEntity.pension_plan.Value = this.pension_plan.Value;
            if (!this.VoucherStatus.IsNull_flag) newEntity.VoucherStatus.Value = this.VoucherStatus.Value;
            if (!this.VoucherDate.IsNull_flag) newEntity.VoucherDate.Value = this.VoucherDate.Value;
            if (!this.LocalMarketID.IsNull_flag) newEntity.LocalMarketID.Value = this.LocalMarketID.Value;
            if (!this.Dividend_RejectionID.IsNull_flag) newEntity.Dividend_RejectionID.Value = this.Dividend_RejectionID.Value;
            if (!this.Depositary_Fees_USD_Locked.IsNull_flag) newEntity.Depositary_Fees_USD_Locked.Value = this.Depositary_Fees_USD_Locked.Value;
            if (!this.Custodial_Fees_EUR_Locked.IsNull_flag) newEntity.Custodial_Fees_EUR_Locked.Value = this.Custodial_Fees_EUR_Locked.Value;
            if (!this.Custodial_Fees_USD_Locked.IsNull_flag) newEntity.Custodial_Fees_USD_Locked.Value = this.Custodial_Fees_USD_Locked.Value;
            if (!this.Net_Amount_Paid_USD_Locked.IsNull_flag) newEntity.Net_Amount_Paid_USD_Locked.Value = this.Net_Amount_Paid_USD_Locked.Value;
            if (!this.Net_Amount_Paid_EUR_Locked.IsNull_flag) newEntity.Net_Amount_Paid_EUR_Locked.Value = this.Net_Amount_Paid_EUR_Locked.Value;
            if (!this.BoBirthDate.IsNull_flag) newEntity.BoBirthDate.Value = this.BoBirthDate.Value;
            if (!this.BoLastName.IsNull_flag) newEntity.BoLastName.Value = this.BoLastName.Value;
            if (!this.BoFirstName.IsNull_flag) newEntity.BoFirstName.Value = this.BoFirstName.Value;
            if (!this.ClientListingID.IsNull_flag) newEntity.ClientListingID.Value = this.ClientListingID.Value;
            if (!this.BoData.IsNull_flag) newEntity.BoData.Value = this.BoData.Value;
            if (!this.Status_Detail.IsNull_flag) newEntity.Status_Detail.Value = this.Status_Detail.Value;
            if (!this.Doc_Deadline.IsNull_flag) newEntity.Doc_Deadline.Value = this.Doc_Deadline.Value;
            if (!this.Kenmerk_Number.IsNull_flag) newEntity.Kenmerk_Number.Value = this.Kenmerk_Number.Value;
            if (!this.Kenmerk_Status.IsNull_flag) newEntity.Kenmerk_Status.Value = this.Kenmerk_Status.Value;
            if (!this.Kenmerk_Status_Date.IsNull_flag) newEntity.Kenmerk_Status_Date.Value = this.Kenmerk_Status_Date.Value;
            if (!this.FileLinking_Status.IsNull_flag) newEntity.FileLinking_Status.Value = this.FileLinking_Status.Value;
            if (!this.Filing_Attempts.IsNull_flag) newEntity.Filing_Attempts.Value = this.Filing_Attempts.Value;
            if (!this.Kenmerk_Status_Reason.IsNull_flag) newEntity.Kenmerk_Status_Reason.Value = this.Kenmerk_Status_Reason.Value;
            if (!this.PaidViaDTCC.IsNull_flag) newEntity.PaidViaDTCC.Value = this.PaidViaDTCC.Value;
            if (!this.COI.IsNull_flag) newEntity.COI.Value = this.COI.Value;
            if (!this.Par_ID.IsNull_flag) newEntity.Par_ID.Value = this.Par_ID.Value;
            if (!this.Depositary_FeesA_USD_Locked.IsNull_flag) newEntity.Depositary_FeesA_USD_Locked.Value = this.Depositary_FeesA_USD_Locked.Value;
            if (!this.Payment_Cycle.IsNull_flag) newEntity.Payment_Cycle.Value = this.Payment_Cycle.Value;
            if (!this.Payment_Cycle_DateTime.IsNull_flag) newEntity.Payment_Cycle_DateTime.Value = this.Payment_Cycle_DateTime.Value;
            if (!this.StatusUpdatedBy.IsNull_flag) newEntity.StatusUpdatedBy.Value = this.StatusUpdatedBy.Value;
            if (!this.FundISIN.IsNull_flag) newEntity.FundISIN.Value = this.FundISIN.Value;
            if (!this.PurchaseDate.IsNull_flag) newEntity.PurchaseDate.Value = this.PurchaseDate.Value;
            if (!this.ORDNUNGS_NR.IsNull_flag) newEntity.ORDNUNGS_NR.Value = this.ORDNUNGS_NR.Value;
            if (!this.NewBoTaxID.IsNull_flag) newEntity.NewBoTaxID.Value = this.NewBoTaxID.Value;
            if (!this.AuditStatus.IsNull_flag) newEntity.AuditStatus.Value = this.AuditStatus.Value;
            if (!this.AuditStatusDate.IsNull_flag) newEntity.AuditStatusDate.Value = this.AuditStatusDate.Value;
            return newEntity;
        }

        public string ToXML()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("<Dividend_Detail_full>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<DetailID>").Append(this.DetailID).Append("</DetailID>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<DividendIndex>").Append(this.DividendIndex.Value).Append("</DividendIndex>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<ClaimID>").Append(this.ClaimID.Value).Append("</ClaimID>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Issue>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.Issue.Value)).Append("</Issue>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<DTC_Number>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.DTC_Number.Value)).Append("</DTC_Number>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<DTC_Name>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.DTC_Name.Value)).Append("</DTC_Name>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<DTC_Address1>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.DTC_Address1.Value)).Append("</DTC_Address1>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<DTC_Address2>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.DTC_Address2.Value)).Append("</DTC_Address2>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<DTC_ATTN>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.DTC_ATTN.Value)).Append("</DTC_ATTN>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Depositary>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.Depositary.Value)).Append("</Depositary>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<DTC_PositionID>").Append(this.DTC_PositionID.Value).Append("</DTC_PositionID>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<BoName>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.BoName.Value)).Append("</BoName>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<BoAddress1>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.BoAddress1.Value)).Append("</BoAddress1>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<BoAddress2>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.BoAddress2.Value)).Append("</BoAddress2>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<BoAddress3>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.BoAddress3.Value)).Append("</BoAddress3>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<BoAddress4>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.BoAddress4.Value)).Append("</BoAddress4>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<BoAddress5>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.BoAddress5.Value)).Append("</BoAddress5>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<BO_COR>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.BO_COR.Value)).Append("</BO_COR>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<BO_EntityType>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.BO_EntityType.Value)).Append("</BO_EntityType>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<BoTaxID>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.BoTaxID.Value)).Append("</BoTaxID>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<ReceivedDate>").Append(this.ReceivedDate.Value).Append("</ReceivedDate>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<ReclaimRate>").Append(this.ReclaimRate.Value).Append("</ReclaimRate>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<ClaimType>").Append(this.ClaimType.Value).Append("</ClaimType>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Custodian>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.Custodian.Value)).Append("</Custodian>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<CustodianID>").Append(this.CustodianID.Value).Append("</CustodianID>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<ReclaimAmount>").Append(this.ReclaimAmount.Value).Append("</ReclaimAmount>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Status>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.Status.Value)).Append("</Status>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<CreatedDate>").Append(this.CreatedDate.Value).Append("</CreatedDate>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<PaymentReferenceDate>").Append(this.PaymentReferenceDate.Value).Append("</PaymentReferenceDate>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<RecordDatePosition>").Append(this.RecordDatePosition.Value).Append("</RecordDatePosition>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Internal_Ref_Number>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.Internal_Ref_Number.Value)).Append("</Internal_Ref_Number>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Internal_Batch_Num>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.Internal_Batch_Num.Value)).Append("</Internal_Batch_Num>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<External_Client_Ref_Num>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.External_Client_Ref_Num.Value)).Append("</External_Client_Ref_Num>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<External_Claim_Ref_Num>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.External_Claim_Ref_Num.Value)).Append("</External_Claim_Ref_Num>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<External_Batch_Num>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.External_Batch_Num.Value)).Append("</External_Batch_Num>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Notes>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.Notes.Value)).Append("</Notes>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Dividend_FilingID>").Append(this.Dividend_FilingID.Value).Append("</Dividend_FilingID>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Dividend_PayID>").Append(this.Dividend_PayID.Value).Append("</Dividend_PayID>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<CurrentMode>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.CurrentMode.Value)).Append("</CurrentMode>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Editor>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.Editor.Value)).Append("</Editor>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<ReclaimFeesType>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.ReclaimFeesType.Value)).Append("</ReclaimFeesType>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Filing_Reference_Number>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.Filing_Reference_Number.Value)).Append("</Filing_Reference_Number>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<ModifiedDateTime>").Append(this.ModifiedDateTime.Value).Append("</ModifiedDateTime>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<LastModifiedBy>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.LastModifiedBy.Value)).Append("</LastModifiedBy>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<External_Service_Provider_Name>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.External_Service_Provider_Name.Value)).Append("</External_Service_Provider_Name>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<NewRow>").Append(this.NewRow.Value).Append("</NewRow>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Override_Fees>").Append(this.Override_Fees.Value).Append("</Override_Fees>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Residency_Percent>").Append(this.Residency_Percent.Value).Append("</Residency_Percent>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<EST_Time_To_Pay>").Append(this.EST_Time_To_Pay.Value).Append("</EST_Time_To_Pay>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Override_Rate>").Append(this.Override_Rate.Value).Append("</Override_Rate>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Override_Custodial_Fees>").Append(this.Override_Custodial_Fees.Value).Append("</Override_Custodial_Fees>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<EntityType_France>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.EntityType_France.Value)).Append("</EntityType_France>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Interest_Paid_EUR>").Append(this.Interest_Paid_EUR.Value).Append("</Interest_Paid_EUR>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Custodial_Ref_Num>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.Custodial_Ref_Num.Value)).Append("</Custodial_Ref_Num>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Custodial_Report_Date>").Append(this.Custodial_Report_Date.Value).Append("</Custodial_Report_Date>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Custodial_Report_Status>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.Custodial_Report_Status.Value)).Append("</Custodial_Report_Status>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<LawOfEstablishment>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.LawOfEstablishment.Value)).Append("</LawOfEstablishment>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<CERT>").Append(this.CERT.Value).Append("</CERT>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Validation>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.Validation.Value)).Append("</Validation>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Validation_Reason>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.Validation_Reason.Value)).Append("</Validation_Reason>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Broker_BO_Name>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.Broker_BO_Name.Value)).Append("</Broker_BO_Name>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Paid_And_Locked>").Append(this.Paid_And_Locked.Value).Append("</Paid_And_Locked>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Category>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.Category.Value)).Append("</Category>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Name_Of_Underlying_Holder>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.Name_Of_Underlying_Holder.Value)).Append("</Name_Of_Underlying_Holder>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Entity_Name>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.Entity_Name.Value)).Append("</Entity_Name>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<PercentOfShares_Held_UH>").Append(this.PercentOfShares_Held_UH.Value).Append("</PercentOfShares_Held_UH>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<RSHID>").Append(this.RSHID.Value).Append("</RSHID>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<ParentID>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.ParentID.Value)).Append("</ParentID>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<ThreadID>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.ThreadID.Value)).Append("</ThreadID>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<ESPAccountNumber>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.ESPAccountNumber.Value)).Append("</ESPAccountNumber>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Tier>").Append(this.Tier.Value).Append("</Tier>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Tier2AccountNumber>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.Tier2AccountNumber.Value)).Append("</Tier2AccountNumber>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Tier3AccountNumber>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.Tier3AccountNumber.Value)).Append("</Tier3AccountNumber>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Tier4AccountNumber>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.Tier4AccountNumber.Value)).Append("</Tier4AccountNumber>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Tier5AccountNumber>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.Tier5AccountNumber.Value)).Append("</Tier5AccountNumber>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<ClientID>").Append(this.ClientID.Value).Append("</ClientID>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Designated>").Append(this.Designated.Value).Append("</Designated>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<PID>").Append(this.PID.Value).Append("</PID>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<BOIndex>").Append(this.BOIndex.Value).Append("</BOIndex>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<TotalParticipants>").Append(this.TotalParticipants.Value).Append("</TotalParticipants>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<TotalTreatyParticipants>").Append(this.TotalTreatyParticipants.Value).Append("</TotalTreatyParticipants>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<DateOfFiscalYearEnd>").Append(this.DateOfFiscalYearEnd.Value).Append("</DateOfFiscalYearEnd>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<RejectReasons>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.RejectReasons.Value)).Append("</RejectReasons>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Tier6AccountNumber>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.Tier6AccountNumber.Value)).Append("</Tier6AccountNumber>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Tier7AccountNumber>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.Tier7AccountNumber.Value)).Append("</Tier7AccountNumber>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<BoEmail>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.BoEmail.Value)).Append("</BoEmail>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<BOAccountNumber>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.BOAccountNumber.Value)).Append("</BOAccountNumber>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<StatusDate>").Append(this.StatusDate.Value).Append("</StatusDate>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<RejectParty>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.RejectParty.Value)).Append("</RejectParty>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<AuditDeadline>").Append(this.AuditDeadline.Value).Append("</AuditDeadline>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<ExtensionRequested>").Append(this.ExtensionRequested.Value).Append("</ExtensionRequested>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<ExtensionDeadline>").Append(this.ExtensionDeadline.Value).Append("</ExtensionDeadline>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<ElectionOption>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.ElectionOption.Value)).Append("</ElectionOption>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<DocStatus_ESP>").Append(this.DocStatus_ESP.Value).Append("</DocStatus_ESP>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<DocStatus>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.DocStatus.Value)).Append("</DocStatus>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<boclient_id>").Append(this.boclient_id.Value).Append("</boclient_id>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<pension_plan>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.pension_plan.Value)).Append("</pension_plan>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<VoucherStatus>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.VoucherStatus.Value)).Append("</VoucherStatus>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<VoucherDate>").Append(this.VoucherDate.Value).Append("</VoucherDate>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<LocalMarketID>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.LocalMarketID.Value)).Append("</LocalMarketID>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Dividend_RejectionID>").Append(this.Dividend_RejectionID.Value).Append("</Dividend_RejectionID>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Depositary_Fees_USD_Locked>").Append(this.Depositary_Fees_USD_Locked.Value).Append("</Depositary_Fees_USD_Locked>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Custodial_Fees_EUR_Locked>").Append(this.Custodial_Fees_EUR_Locked.Value).Append("</Custodial_Fees_EUR_Locked>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Custodial_Fees_USD_Locked>").Append(this.Custodial_Fees_USD_Locked.Value).Append("</Custodial_Fees_USD_Locked>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Net_Amount_Paid_USD_Locked>").Append(this.Net_Amount_Paid_USD_Locked.Value).Append("</Net_Amount_Paid_USD_Locked>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Net_Amount_Paid_EUR_Locked>").Append(this.Net_Amount_Paid_EUR_Locked.Value).Append("</Net_Amount_Paid_EUR_Locked>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<BoBirthDate>").Append(this.BoBirthDate.Value).Append("</BoBirthDate>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<BoLastName>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.BoLastName.Value)).Append("</BoLastName>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<BoFirstName>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.BoFirstName.Value)).Append("</BoFirstName>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<ClientListingID>").Append(this.ClientListingID.Value).Append("</ClientListingID>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<BoData>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.BoData.Value)).Append("</BoData>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Status_Detail>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.Status_Detail.Value)).Append("</Status_Detail>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Doc_Deadline>").Append(this.Doc_Deadline.Value).Append("</Doc_Deadline>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Kenmerk_Number>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.Kenmerk_Number.Value)).Append("</Kenmerk_Number>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Kenmerk_Status>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.Kenmerk_Status.Value)).Append("</Kenmerk_Status>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Kenmerk_Status_Date>").Append(this.Kenmerk_Status_Date.Value).Append("</Kenmerk_Status_Date>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<FileLinking_Status>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.FileLinking_Status.Value)).Append("</FileLinking_Status>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Filing_Attempts>").Append(this.Filing_Attempts.Value).Append("</Filing_Attempts>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Kenmerk_Status_Reason>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.Kenmerk_Status_Reason.Value)).Append("</Kenmerk_Status_Reason>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<PaidViaDTCC>").Append(this.PaidViaDTCC.Value).Append("</PaidViaDTCC>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<COI>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.COI.Value)).Append("</COI>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Par_ID>").Append(this.Par_ID.Value).Append("</Par_ID>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Depositary_FeesA_USD_Locked>").Append(this.Depositary_FeesA_USD_Locked.Value).Append("</Depositary_FeesA_USD_Locked>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Payment_Cycle>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.Payment_Cycle.Value)).Append("</Payment_Cycle>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Payment_Cycle_DateTime>").Append(this.Payment_Cycle_DateTime.Value).Append("</Payment_Cycle_DateTime>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<StatusUpdatedBy>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.StatusUpdatedBy.Value)).Append("</StatusUpdatedBy>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<FundISIN>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.FundISIN.Value)).Append("</FundISIN>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<PurchaseDate>").Append(this.PurchaseDate.Value).Append("</PurchaseDate>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<ORDNUNGS_NR>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.ORDNUNGS_NR.Value)).Append("</ORDNUNGS_NR>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<NewBoTaxID>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.NewBoTaxID.Value)).Append("</NewBoTaxID>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<AuditStatus>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.AuditStatus.Value)).Append("</AuditStatus>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<AuditStatusDate>").Append(this.AuditStatusDate.Value).Append("</AuditStatusDate>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("</Dividend_Detail_full>").Append(HssUtility.General.HssStr.WinNextLine);
            return sb.ToString();
        }
        /*^^^^^^^^^^^^^^^^^^^^^^^^^^^^^Hss Entity Framework Auto Generated Code^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^*/
    }
}
