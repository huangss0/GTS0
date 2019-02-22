using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HssDARWIN.Models.Dividends
{
    public partial class Dividend
    {
        /*-----------------------------Hss Entity Framework Auto Generated Code-------------------------------*/
        private static HssUtility.SQLserver.CmdTemplate DBcmd_TP = null;
        public static HssUtility.SQLserver.CmdTemplate Get_cmdTP()
        {
            if (Dividend.DBcmd_TP != null) return Dividend.DBcmd_TP;

            Dividend.DBcmd_TP = new HssUtility.SQLserver.CmdTemplate();
            Dividend.DBcmd_TP.tableName = "Dividend_Control";
            Dividend.DBcmd_TP.schema = "dbo";

            Dividend.DBcmd_TP.AddColumn("DividendIndex");
            Dividend.DBcmd_TP.AddColumn("DividendID");
            Dividend.DBcmd_TP.AddColumn("IncomeEventID");/*Optional 3*/
            Dividend.DBcmd_TP.AddColumn("Issue");
            Dividend.DBcmd_TP.AddColumn("Depositary");
            Dividend.DBcmd_TP.AddColumn("CUSIP");
            Dividend.DBcmd_TP.AddColumn("Sponsored");/*Optional 7*/
            Dividend.DBcmd_TP.AddColumn("RecordDate_ORD");/*Optional 8*/
            Dividend.DBcmd_TP.AddColumn("RecordDate_ADR");
            Dividend.DBcmd_TP.AddColumn("PayDate_ORD");/*Optional 10*/
            Dividend.DBcmd_TP.AddColumn("PayDate_ADR");/*Optional 11*/
            Dividend.DBcmd_TP.AddColumn("FinalDivGrossAmount_ORD");/*Optional 12*/
            Dividend.DBcmd_TP.AddColumn("FinalDivGrossAmount_ADR");/*Optional 13*/
            Dividend.DBcmd_TP.AddColumn("ApproxDivGrossAmount_ORD");/*Optional 14*/
            Dividend.DBcmd_TP.AddColumn("ApproxDivGrossAmount_ADR");/*Optional 15*/
            Dividend.DBcmd_TP.AddColumn("DivNetAmount_ORD");/*Optional 16*/
            Dividend.DBcmd_TP.AddColumn("DivNetAmount_ADR");/*Optional 17*/
            Dividend.DBcmd_TP.AddColumn("ApproximateFXRate");/*Optional 18*/
            Dividend.DBcmd_TP.AddColumn("FinalFXRate");/*Optional 19*/
            Dividend.DBcmd_TP.AddColumn("ADR_Ratio_ORD");/*Optional 20*/
            Dividend.DBcmd_TP.AddColumn("ADR_Ratio_ADR");/*Optional 21*/
            Dividend.DBcmd_TP.AddColumn("LongFormFee");
            Dividend.DBcmd_TP.AddColumn("ShortFormFee");
            Dividend.DBcmd_TP.AddColumn("AtSourceFee");
            Dividend.DBcmd_TP.AddColumn("QuickRefundFee");
            Dividend.DBcmd_TP.AddColumn("MinLongFormFee");
            Dividend.DBcmd_TP.AddColumn("MinQuickRefundFee");
            Dividend.DBcmd_TP.AddColumn("MinAtSource_Fee");
            Dividend.DBcmd_TP.AddColumn("MinShortFormFee");
            Dividend.DBcmd_TP.AddColumn("ExDate");/*Optional 30*/
            Dividend.DBcmd_TP.AddColumn("SEDOL");/*Optional 31*/
            Dividend.DBcmd_TP.AddColumn("ISIN");/*Optional 32*/
            Dividend.DBcmd_TP.AddColumn("DepositaryAccountNumber");/*Optional 33*/
            Dividend.DBcmd_TP.AddColumn("GermanySecurityNumber");/*Optional 34*/
            Dividend.DBcmd_TP.AddColumn("CurrentMode");/*Optional 35*/
            Dividend.DBcmd_TP.AddColumn("Country");
            Dividend.DBcmd_TP.AddColumn("StatutoryRate");/*Optional 37*/
            //Dividend2.DBcmd_TP.AddColumn("Editor");
            Dividend.DBcmd_TP.AddColumn("PaidCurrency");
            Dividend.DBcmd_TP.AddColumn("PaidCurrency_ORD");/*Optional 40*/
            Dividend.DBcmd_TP.AddColumn("AtSource");/*Optional 41*/
            Dividend.DBcmd_TP.AddColumn("QuickRefund");/*Optional 42*/
            Dividend.DBcmd_TP.AddColumn("LongForm");/*Optional 43*/
            Dividend.DBcmd_TP.AddColumn("Publish_Important_Notice_Deadline");/*Optional 44*/
            Dividend.DBcmd_TP.AddColumn("Mail_RSH_Important_Notice_Deadline");/*Optional 45*/
            Dividend.DBcmd_TP.AddColumn("EDS_Opens_Deadline");/*Optional 46*/
            Dividend.DBcmd_TP.AddColumn("EDS_Closes_Deadline");/*Optional 47*/
            Dividend.DBcmd_TP.AddColumn("Filing_Deadline");/*Optional 48*/
            Dividend.DBcmd_TP.AddColumn("RSH_List_Receipt_Deadline");/*Optional 49*/
            Dividend.DBcmd_TP.AddColumn("EDS_Receipt_Deadline");/*Optional 50*/
            Dividend.DBcmd_TP.AddColumn("Custodial_LongForm_Claims_Deadline");/*Optional 51*/
            Dividend.DBcmd_TP.AddColumn("At_Source_Deadline");/*Optional 52*/
            Dividend.DBcmd_TP.AddColumn("Quick_Refund_Deadline");/*Optional 53*/
            Dividend.DBcmd_TP.AddColumn("Cust_Statute_Limitations");/*Optional 54*/
            Dividend.DBcmd_TP.AddColumn("Comments");/*Optional 55*/
            Dividend.DBcmd_TP.AddColumn("Model_Number");/*Optional 56*/
            Dividend.DBcmd_TP.AddColumn("DTCPosition_ModelNumber");
            Dividend.DBcmd_TP.AddColumn("Status");
            Dividend.DBcmd_TP.AddColumn("TickerSymbol");/*Optional 59*/
            Dividend.DBcmd_TP.AddColumn("BAL_Sheet_Receipt_Deadline");/*Optional 60*/
            Dividend.DBcmd_TP.AddColumn("SEC_EDS_Opens_Deadline");/*Optional 61*/
            Dividend.DBcmd_TP.AddColumn("SEC_EDS_Closes_Deadline");/*Optional 62*/
            Dividend.DBcmd_TP.AddColumn("MAX_Fees");/*Optional 63*/
            Dividend.DBcmd_TP.AddColumn("Publish_Important_Notice_Complete");/*Optional 64*/
            Dividend.DBcmd_TP.AddColumn("Mail_RSH_Important_Notice_Complete");/*Optional 65*/
            Dividend.DBcmd_TP.AddColumn("RSH_List_Receipt_Complete");/*Optional 66*/
            Dividend.DBcmd_TP.AddColumn("BAL_Sheet_Receipt_Complete");/*Optional 67*/
            Dividend.DBcmd_TP.AddColumn("EDS_Receipt_Complete");/*Optional 68*/
            Dividend.DBcmd_TP.AddColumn("StatuteOfLimitation");/*Optional 69*/
            Dividend.DBcmd_TP.AddColumn("DBXML_ReferenceNumber");/*Optional 70*/
            Dividend.DBcmd_TP.AddColumn("ISO2CntryCode");
            Dividend.DBcmd_TP.AddColumn("OverseasTaxCredit");/*Optional 72*/
            Dividend.DBcmd_TP.AddColumn("XBRL_ReferenceNumber");/*Optional 73*/
            Dividend.DBcmd_TP.AddColumn("Round_ClaimShares_ADRs");
            Dividend.DBcmd_TP.AddColumn("Round_ClaimShares_ORDs");
            Dividend.DBcmd_TP.AddColumn("MinADRSimplifiedProcedure");
            Dividend.DBcmd_TP.AddColumn("FavAtSourceFee");/*Optional 77*/
            Dividend.DBcmd_TP.AddColumn("ExemptAtSourceFee");/*Optional 78*/
            Dividend.DBcmd_TP.AddColumn("FavTransparentEntityFee");/*Optional 79*/
            Dividend.DBcmd_TP.AddColumn("AssetType");/*Optional 80*/
            Dividend.DBcmd_TP.AddColumn("ConsularizationFee");/*Optional 81*/
            Dividend.DBcmd_TP.AddColumn("AltFinalDivGrossAmount_ORD");
            Dividend.DBcmd_TP.AddColumn("MaturityDate");/*Optional 83*/
            Dividend.DBcmd_TP.AddColumn("InterestRate");/*Optional 84*/
            Dividend.DBcmd_TP.AddColumn("DTCCImportantNoticeB");/*Optional 85*/
            Dividend.DBcmd_TP.AddColumn("AddUSDisclosure");/*Optional 86*/
            Dividend.DBcmd_TP.AddColumn("Domesticated");/*Optional 87*/
            Dividend.DBcmd_TP.AddColumn("SecurityTypeID");
            Dividend.DBcmd_TP.AddColumn("ReversalIndicator");/*Optional 89*/
            Dividend.DBcmd_TP.AddColumn("FaceAmount");/*Optional 90*/
            Dividend.DBcmd_TP.AddColumn("PlaceOfSafekeeping");/*Optional 91*/
            Dividend.DBcmd_TP.AddColumn("FirstFiler");/*Optional 92*/
            Dividend.DBcmd_TP.AddColumn("ESPLogin");
            Dividend.DBcmd_TP.AddColumn("OriginalIssueDiscount");/*Optional 94*/
            Dividend.DBcmd_TP.AddColumn("LastInterestPayDate");/*Optional 95*/
            Dividend.DBcmd_TP.AddColumn("EventType");/*Optional 96*/
            Dividend.DBcmd_TP.AddColumn("BondType");/*Optional 97*/
            Dividend.DBcmd_TP.AddColumn("RecordDate_ADR_Missing");/*Optional 98*/
            Dividend.DBcmd_TP.AddColumn("AuditAvailable");/*Optional 99*/
            Dividend.DBcmd_TP.AddColumn("Issuer_ATTN");/*Optional 100*/
            Dividend.DBcmd_TP.AddColumn("Issuer_Address1");/*Optional 101*/
            Dividend.DBcmd_TP.AddColumn("Issuer_Address2");/*Optional 102*/
            Dividend.DBcmd_TP.AddColumn("SupplementalInterestPayment");/*Optional 103*/
            Dividend.DBcmd_TP.AddColumn("HidePayDate_ORD");/*Optional 104*/
            Dividend.DBcmd_TP.AddColumn("QR1stBatch_Deadline");/*Optional 105*/
            Dividend.DBcmd_TP.AddColumn("Coupon_Number");/*Optional 106*/
            Dividend.DBcmd_TP.AddColumn("LastModifiedBy");/*Optional 107*/
            Dividend.DBcmd_TP.AddColumn("LastModifiedDateTime");/*Optional 108*/
            Dividend.DBcmd_TP.AddColumn("Min_ReclaimValue_USD_QR");/*Optional 109*/
            Dividend.DBcmd_TP.AddColumn("Min_ReclaimValue_USD_LF");/*Optional 110*/
            Dividend.DBcmd_TP.AddColumn("Orange_Note");/*Optional 111*/
            Dividend.DBcmd_TP.AddColumn("FirstFiling_Checked");/*Optional 112*/
            Dividend.DBcmd_TP.AddColumn("FirstPayment_Checked");/*Optional 113*/
            Dividend.DBcmd_TP.AddColumn("SuppressTasks_Checked");/*Optional 114*/
            Dividend.DBcmd_TP.AddColumn("CAWebCutoff_Deadline");/*Optional 115*/
            Dividend.DBcmd_TP.AddColumn("AGMDate");/*Optional 116*/
            Dividend.DBcmd_TP.AddColumn("GDR");/*Optional 117*/

            return Dividend.DBcmd_TP;
        }

        public Dividend() { }
        public Dividend(int id) { this.pk_ID = id; }

        private int pk_ID = -1; //primary key
        public int DividendIndex { get { return this.pk_ID; } }

        public readonly HssUtility.General.Attributes.String_attr DividendID = new HssUtility.General.Attributes.String_attr();
        public readonly HssUtility.General.Attributes.String_attr IncomeEventID = new HssUtility.General.Attributes.String_attr("01");/*Optional 3*/
        public readonly HssUtility.General.Attributes.String_attr Issue = new HssUtility.General.Attributes.String_attr();
        public readonly HssUtility.General.Attributes.String_attr Depositary = new HssUtility.General.Attributes.String_attr("");
        public readonly HssUtility.General.Attributes.String_attr CUSIP = new HssUtility.General.Attributes.String_attr("");
        public readonly HssUtility.General.Attributes.Bool_attr Sponsored = new HssUtility.General.Attributes.Bool_attr();/*Optional 7*/
        public readonly HssUtility.General.Attributes.DateTime_attr RecordDate_ORD = new HssUtility.General.Attributes.DateTime_attr();/*Optional 8*/
        public readonly HssUtility.General.Attributes.DateTime_attr RecordDate_ADR = new HssUtility.General.Attributes.DateTime_attr();
        public readonly HssUtility.General.Attributes.DateTime_attr PayDate_ORD = new HssUtility.General.Attributes.DateTime_attr();/*Optional 10*/
        public readonly HssUtility.General.Attributes.DateTime_attr PayDate_ADR = new HssUtility.General.Attributes.DateTime_attr();/*Optional 11*/
        public readonly HssUtility.General.Attributes.Decimal_attr FinalDivGrossAmount_ORD = new HssUtility.General.Attributes.Decimal_attr();/*Optional 12*/
        public readonly HssUtility.General.Attributes.Decimal_attr FinalDivGrossAmount_ADR = new HssUtility.General.Attributes.Decimal_attr();/*Optional 13*/
        public readonly HssUtility.General.Attributes.Decimal_attr ApproxDivGrossAmount_ORD = new HssUtility.General.Attributes.Decimal_attr();/*Optional 14*/
        public readonly HssUtility.General.Attributes.Decimal_attr ApproxDivGrossAmount_ADR = new HssUtility.General.Attributes.Decimal_attr();/*Optional 15*/
        public readonly HssUtility.General.Attributes.Decimal_attr DivNetAmount_ORD = new HssUtility.General.Attributes.Decimal_attr();/*Optional 16*/
        public readonly HssUtility.General.Attributes.Decimal_attr DivNetAmount_ADR = new HssUtility.General.Attributes.Decimal_attr();/*Optional 17*/
        public readonly HssUtility.General.Attributes.Decimal_attr ApproximateFXRate = new HssUtility.General.Attributes.Decimal_attr();/*Optional 18*/
        public readonly HssUtility.General.Attributes.Decimal_attr FinalFXRate = new HssUtility.General.Attributes.Decimal_attr();/*Optional 19*/
        public readonly HssUtility.General.Attributes.Decimal_attr ADR_Ratio_ORD = new HssUtility.General.Attributes.Decimal_attr();/*Optional 20*/
        public readonly HssUtility.General.Attributes.Decimal_attr ADR_Ratio_ADR = new HssUtility.General.Attributes.Decimal_attr();/*Optional 21*/
        public readonly HssUtility.General.Attributes.Decimal_attr LongFormFee = new HssUtility.General.Attributes.Decimal_attr(0);
        public readonly HssUtility.General.Attributes.Decimal_attr ShortFormFee = new HssUtility.General.Attributes.Decimal_attr(0);
        public readonly HssUtility.General.Attributes.Decimal_attr AtSourceFee = new HssUtility.General.Attributes.Decimal_attr(0);
        public readonly HssUtility.General.Attributes.Decimal_attr QuickRefundFee = new HssUtility.General.Attributes.Decimal_attr(0);
        public readonly HssUtility.General.Attributes.Decimal_attr MinLongFormFee = new HssUtility.General.Attributes.Decimal_attr(0);
        public readonly HssUtility.General.Attributes.Decimal_attr MinQuickRefundFee = new HssUtility.General.Attributes.Decimal_attr(0);
        public readonly HssUtility.General.Attributes.Decimal_attr MinAtSource_Fee = new HssUtility.General.Attributes.Decimal_attr(0);
        public readonly HssUtility.General.Attributes.Decimal_attr MinShortFormFee = new HssUtility.General.Attributes.Decimal_attr(0);
        public readonly HssUtility.General.Attributes.DateTime_attr ExDate = new HssUtility.General.Attributes.DateTime_attr();/*Optional 30*/
        public readonly HssUtility.General.Attributes.String_attr SEDOL = new HssUtility.General.Attributes.String_attr();/*Optional 31*/
        public readonly HssUtility.General.Attributes.String_attr ISIN = new HssUtility.General.Attributes.String_attr();/*Optional 32*/
        public readonly HssUtility.General.Attributes.String_attr DepositaryAccountNumber = new HssUtility.General.Attributes.String_attr();/*Optional 33*/
        public readonly HssUtility.General.Attributes.String_attr GermanySecurityNumber = new HssUtility.General.Attributes.String_attr();/*Optional 34*/
        public readonly HssUtility.General.Attributes.String_attr CurrentMode = new HssUtility.General.Attributes.String_attr("");/*Optional 35*/
        public readonly HssUtility.General.Attributes.String_attr Country = new HssUtility.General.Attributes.String_attr();
        public readonly HssUtility.General.Attributes.Decimal_attr StatutoryRate = new HssUtility.General.Attributes.Decimal_attr();/*Optional 37*/
        //public readonly HssUtility.General.Attributes.String_attr Editor = new HssUtility.General.Attributes.String_attr();
        public readonly HssUtility.General.Attributes.String_attr PaidCurrency = new HssUtility.General.Attributes.String_attr();
        public readonly HssUtility.General.Attributes.String_attr PaidCurrency_ORD = new HssUtility.General.Attributes.String_attr();/*Optional 40*/
        public readonly HssUtility.General.Attributes.Bool_attr AtSource = new HssUtility.General.Attributes.Bool_attr();/*Optional 41*/
        public readonly HssUtility.General.Attributes.Bool_attr QuickRefund = new HssUtility.General.Attributes.Bool_attr();/*Optional 42*/
        public readonly HssUtility.General.Attributes.Bool_attr LongForm = new HssUtility.General.Attributes.Bool_attr();/*Optional 43*/
        public readonly HssUtility.General.Attributes.DateTime_attr Publish_Important_Notice_Deadline = new HssUtility.General.Attributes.DateTime_attr();/*Optional 44*/
        public readonly HssUtility.General.Attributes.DateTime_attr Mail_RSH_Important_Notice_Deadline = new HssUtility.General.Attributes.DateTime_attr();/*Optional 45*/
        public readonly HssUtility.General.Attributes.DateTime_attr EDS_Opens_Deadline = new HssUtility.General.Attributes.DateTime_attr();/*Optional 46*/
        public readonly HssUtility.General.Attributes.DateTime_attr EDS_Closes_Deadline = new HssUtility.General.Attributes.DateTime_attr();/*Optional 47*/
        public readonly HssUtility.General.Attributes.DateTime_attr Filing_Deadline = new HssUtility.General.Attributes.DateTime_attr();/*Optional 48*/
        public readonly HssUtility.General.Attributes.DateTime_attr RSH_List_Receipt_Deadline = new HssUtility.General.Attributes.DateTime_attr();/*Optional 49*/
        public readonly HssUtility.General.Attributes.DateTime_attr EDS_Receipt_Deadline = new HssUtility.General.Attributes.DateTime_attr();/*Optional 50*/
        public readonly HssUtility.General.Attributes.DateTime_attr Custodial_LongForm_Claims_Deadline = new HssUtility.General.Attributes.DateTime_attr();/*Optional 51*/
        public readonly HssUtility.General.Attributes.DateTime_attr At_Source_Deadline = new HssUtility.General.Attributes.DateTime_attr();/*Optional 52*/
        public readonly HssUtility.General.Attributes.DateTime_attr Quick_Refund_Deadline = new HssUtility.General.Attributes.DateTime_attr();/*Optional 53*/
        public readonly HssUtility.General.Attributes.DateTime_attr Cust_Statute_Limitations = new HssUtility.General.Attributes.DateTime_attr();/*Optional 54*/
        public readonly HssUtility.General.Attributes.String_attr Comments = new HssUtility.General.Attributes.String_attr();/*Optional 55*/
        public readonly HssUtility.General.Attributes.Int_attr Model_Number = new HssUtility.General.Attributes.Int_attr();/*Optional 56*/
        public readonly HssUtility.General.Attributes.Int_attr DTCPosition_ModelNumber = new HssUtility.General.Attributes.Int_attr();
        public readonly HssUtility.General.Attributes.String_attr Status = new HssUtility.General.Attributes.String_attr(HssUtility.General.HssStatus.Active.ToString());
        public readonly HssUtility.General.Attributes.String_attr TickerSymbol = new HssUtility.General.Attributes.String_attr();/*Optional 59*/
        public readonly HssUtility.General.Attributes.DateTime_attr BAL_Sheet_Receipt_Deadline = new HssUtility.General.Attributes.DateTime_attr();/*Optional 60*/
        public readonly HssUtility.General.Attributes.DateTime_attr SEC_EDS_Opens_Deadline = new HssUtility.General.Attributes.DateTime_attr();/*Optional 61*/
        public readonly HssUtility.General.Attributes.DateTime_attr SEC_EDS_Closes_Deadline = new HssUtility.General.Attributes.DateTime_attr();/*Optional 62*/
        public readonly HssUtility.General.Attributes.Decimal_attr MAX_Fees = new HssUtility.General.Attributes.Decimal_attr(0);/*Optional 63*/
        public readonly HssUtility.General.Attributes.DateTime_attr Publish_Important_Notice_Complete = new HssUtility.General.Attributes.DateTime_attr();/*Optional 64*/
        public readonly HssUtility.General.Attributes.DateTime_attr Mail_RSH_Important_Notice_Complete = new HssUtility.General.Attributes.DateTime_attr();/*Optional 65*/
        public readonly HssUtility.General.Attributes.DateTime_attr RSH_List_Receipt_Complete = new HssUtility.General.Attributes.DateTime_attr();/*Optional 66*/
        public readonly HssUtility.General.Attributes.DateTime_attr BAL_Sheet_Receipt_Complete = new HssUtility.General.Attributes.DateTime_attr();/*Optional 67*/
        public readonly HssUtility.General.Attributes.DateTime_attr EDS_Receipt_Complete = new HssUtility.General.Attributes.DateTime_attr();/*Optional 68*/
        public readonly HssUtility.General.Attributes.DateTime_attr StatuteOfLimitation = new HssUtility.General.Attributes.DateTime_attr();/*Optional 69*/
        public readonly HssUtility.General.Attributes.String_attr DBXML_ReferenceNumber = new HssUtility.General.Attributes.String_attr();/*Optional 70*/
        public readonly HssUtility.General.Attributes.String_attr ISO2CntryCode = new HssUtility.General.Attributes.String_attr("");
        public readonly HssUtility.General.Attributes.Decimal_attr OverseasTaxCredit = new HssUtility.General.Attributes.Decimal_attr(0);/*Optional 72*/
        public readonly HssUtility.General.Attributes.String_attr XBRL_ReferenceNumber = new HssUtility.General.Attributes.String_attr();/*Optional 73*/
        public readonly HssUtility.General.Attributes.Bool_attr Round_ClaimShares_ADRs = new HssUtility.General.Attributes.Bool_attr();
        public readonly HssUtility.General.Attributes.Bool_attr Round_ClaimShares_ORDs = new HssUtility.General.Attributes.Bool_attr();
        public readonly HssUtility.General.Attributes.Decimal_attr MinADRSimplifiedProcedure = new HssUtility.General.Attributes.Decimal_attr(0);
        public readonly HssUtility.General.Attributes.Decimal_attr FavAtSourceFee = new HssUtility.General.Attributes.Decimal_attr();/*Optional 77*/
        public readonly HssUtility.General.Attributes.Decimal_attr ExemptAtSourceFee = new HssUtility.General.Attributes.Decimal_attr();/*Optional 78*/
        public readonly HssUtility.General.Attributes.Decimal_attr FavTransparentEntityFee = new HssUtility.General.Attributes.Decimal_attr();/*Optional 79*/
        public readonly HssUtility.General.Attributes.Int_attr AssetType = new HssUtility.General.Attributes.Int_attr(0);/*Optional 80*/
        public readonly HssUtility.General.Attributes.Decimal_attr ConsularizationFee = new HssUtility.General.Attributes.Decimal_attr(0);/*Optional 81*/
        public readonly HssUtility.General.Attributes.Decimal_attr AltFinalDivGrossAmount_ORD = new HssUtility.General.Attributes.Decimal_attr(0);
        public readonly HssUtility.General.Attributes.DateTime_attr MaturityDate = new HssUtility.General.Attributes.DateTime_attr();/*Optional 83*/
        public readonly HssUtility.General.Attributes.Decimal_attr InterestRate = new HssUtility.General.Attributes.Decimal_attr();/*Optional 84*/
        public readonly HssUtility.General.Attributes.String_attr DTCCImportantNoticeB = new HssUtility.General.Attributes.String_attr();/*Optional 85*/
        public readonly HssUtility.General.Attributes.Bool_attr AddUSDisclosure = new HssUtility.General.Attributes.Bool_attr();/*Optional 86*/
        public readonly HssUtility.General.Attributes.Bool_attr Domesticated = new HssUtility.General.Attributes.Bool_attr();/*Optional 87*/
        public readonly HssUtility.General.Attributes.Int_attr SecurityTypeID = new HssUtility.General.Attributes.Int_attr(1);
        public readonly HssUtility.General.Attributes.Bool_attr ReversalIndicator = new HssUtility.General.Attributes.Bool_attr(false);/*Optional 89*/
        public readonly HssUtility.General.Attributes.Decimal_attr FaceAmount = new HssUtility.General.Attributes.Decimal_attr(0);/*Optional 90*/
        public readonly HssUtility.General.Attributes.String_attr PlaceOfSafekeeping = new HssUtility.General.Attributes.String_attr();/*Optional 91*/
        public readonly HssUtility.General.Attributes.String_attr FirstFiler = new HssUtility.General.Attributes.String_attr();/*Optional 92*/
        public readonly HssUtility.General.Attributes.String_attr ESPLogin = new HssUtility.General.Attributes.String_attr("DTCC");
        public readonly HssUtility.General.Attributes.Decimal_attr OriginalIssueDiscount = new HssUtility.General.Attributes.Decimal_attr();/*Optional 94*/
        public readonly HssUtility.General.Attributes.DateTime_attr LastInterestPayDate = new HssUtility.General.Attributes.DateTime_attr();/*Optional 95*/
        public readonly HssUtility.General.Attributes.String_attr EventType = new HssUtility.General.Attributes.String_attr("Cash Dividend");/*Optional 96*/
        public readonly HssUtility.General.Attributes.String_attr BondType = new HssUtility.General.Attributes.String_attr();/*Optional 97*/
        public readonly HssUtility.General.Attributes.Bool_attr RecordDate_ADR_Missing = new HssUtility.General.Attributes.Bool_attr();/*Optional 98*/
        public readonly HssUtility.General.Attributes.Bool_attr AuditAvailable = new HssUtility.General.Attributes.Bool_attr();/*Optional 99*/
        public readonly HssUtility.General.Attributes.String_attr Issuer_ATTN = new HssUtility.General.Attributes.String_attr();/*Optional 100*/
        public readonly HssUtility.General.Attributes.String_attr Issuer_Address1 = new HssUtility.General.Attributes.String_attr();/*Optional 101*/
        public readonly HssUtility.General.Attributes.String_attr Issuer_Address2 = new HssUtility.General.Attributes.String_attr();/*Optional 102*/
        public readonly HssUtility.General.Attributes.Bool_attr SupplementalInterestPayment = new HssUtility.General.Attributes.Bool_attr();/*Optional 103*/
        public readonly HssUtility.General.Attributes.Bool_attr HidePayDate_ORD = new HssUtility.General.Attributes.Bool_attr();/*Optional 104*/
        public readonly HssUtility.General.Attributes.DateTime_attr QR1stBatch_Deadline = new HssUtility.General.Attributes.DateTime_attr(Utility.MinDate);/*Optional 105*/
        public readonly HssUtility.General.Attributes.String_attr Coupon_Number = new HssUtility.General.Attributes.String_attr();/*Optional 106*/
        public readonly HssUtility.General.Attributes.String_attr LastModifiedBy = new HssUtility.General.Attributes.String_attr();/*Optional 107*/
        public readonly HssUtility.General.Attributes.DateTime_attr LastModifiedDateTime = new HssUtility.General.Attributes.DateTime_attr();/*Optional 108*/
        public readonly HssUtility.General.Attributes.Decimal_attr Min_ReclaimValue_USD_QR = new HssUtility.General.Attributes.Decimal_attr();/*Optional 109*/
        public readonly HssUtility.General.Attributes.Decimal_attr Min_ReclaimValue_USD_LF = new HssUtility.General.Attributes.Decimal_attr();/*Optional 110*/
        public readonly HssUtility.General.Attributes.String_attr Orange_Note = new HssUtility.General.Attributes.String_attr();/*Optional 111*/
        public readonly HssUtility.General.Attributes.Bool_attr FirstFiling_Checked = new HssUtility.General.Attributes.Bool_attr();/*Optional 112*/
        public readonly HssUtility.General.Attributes.Bool_attr FirstPayment_Checked = new HssUtility.General.Attributes.Bool_attr();/*Optional 113*/
        public readonly HssUtility.General.Attributes.Bool_attr SuppressTasks_Checked = new HssUtility.General.Attributes.Bool_attr();/*Optional 114*/
        public readonly HssUtility.General.Attributes.DateTime_attr CAWebCutoff_Deadline = new HssUtility.General.Attributes.DateTime_attr();/*Optional 115*/
        public readonly HssUtility.General.Attributes.DateTime_attr AGMDate = new HssUtility.General.Attributes.DateTime_attr();/*Optional 116*/
        public readonly HssUtility.General.Attributes.Bool_attr GDR = new HssUtility.General.Attributes.Bool_attr();/*Optional 117*/

        private Dictionary<string, HssUtility.General.Attributes.I_modelAttr> attr_dic = null;
    }
}
