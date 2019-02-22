using System;
using System.Collections.Generic;

using HssUtility.Text.XML;

namespace HssDARWIN.Models.XBRL.Event
{
    public class XBRL_event_info
    {
        public string ISO2CntryCode = null;
        public string CUSIP = null;
        public string ISIN = null;

        public bool Sponsored = false;
        public bool IsFirstFiler = false;

        public DateTime PayDate_ADR = Utility.MinDate;
        public DateTime ExDate = Utility.MinDate;
        public DateTime PayDate_ORD = Utility.MinDate;
        public DateTime RecordDate_ADR = Utility.MinDate;
        public DateTime RecordDate_ORD = Utility.MinDate;

        public decimal ADR_Ratio_ADR = 0;
        public decimal ADR_Ratio_ORD = 0;

        public decimal FXrate_US_to_foreign = 0;
        public decimal FXrate_foreign_to_US = 0;

        public decimal StatutoryRate = 0;

        public string EventCompleteness = null;
        public string EventType = "Cash Dividend";

        public decimal DivGrossAmount_ORD = 0;
        public string PaidCurrency_ORD = null;

        public string TickerSymbol = null;
        public string Issue = null;     

        public string depoName = null;
        public string Sender = null;

        public string XBRL_ReferenceNumber = null;

        public string AnnouncementType = null;
        public string AnnouncementIdentifier = null;
        public DateTime AnnouncementDate = Utility.MinDate;

        public List<FeeInfo> fee_list = new List<FeeInfo>();

        /*----------------------------------------------Constructor--------------------------------------------*/
        public XBRL_event_info() { }
        public XBRL_event_info(byte[] rawBytes)
        {
            if (rawBytes == null || rawBytes.Length < 1) return;

            Hss_XML_reader reader = new Hss_XML_reader();
            this.Init_from_XMLobj(reader.Read(rawBytes));
        }
        public XBRL_event_info(string xml_str)
        {
            if (string.IsNullOrEmpty(xml_str)) return;

            Hss_XML_reader reader = new Hss_XML_reader();
            this.Init_from_XMLobj(reader.Read(xml_str));
        }
        public XBRL_event_info(Hss_XML_obj xo) { this.Init_from_XMLobj(xo); }

        private void Init_from_XMLobj(Hss_XML_obj xbrl)
        {
            this.XBRL_rootName = this.Find_rootEntry(xbrl);
            if (string.IsNullOrEmpty(this.XBRL_rootName)) return;

            this.Parse_all_values(xbrl);
        }
        /*^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^*/

        /*------------------------------------------Private Functions------------------------------------------*/
        public const string XML_rootName = "xbrli:xbrl", XML_rootName0 = "xbrl:xbrl";
        private string XBRL_rootName = null;

        private string Find_rootEntry(Hss_XML_obj xbrl)
        {
            if (xbrl == null) return null;

            if (xbrl.Get_obj(XBRL_event_info.XML_rootName) != null) return XBRL_event_info.XML_rootName;
            else if (xbrl.Get_obj(XBRL_event_info.XML_rootName0) != null) return XBRL_event_info.XML_rootName0;

            return null;
        }

        private void Parse_all_values(Hss_XML_obj xbrl)
        {
            Hss_XML_obj country_xo = xbrl.Get_obj(this.XBRL_rootName, "ca:UnderlyingSecurityIssuerCountryofIncorporation");
            if (country_xo != null) this.ISO2CntryCode = country_xo.value;

            this.Get_CUSIP(xbrl);

            /*----------------------------------------------------------------------------------------------------------------------*/

            Hss_XML_obj sponsered_xo = xbrl.Get_obj(this.XBRL_rootName, "ca:DepositoryReceiptSponsorIndicator");
            this.Sponsored = Helper_XML.Get_bool(sponsered_xo);

            Hss_XML_obj IsFirstFiler_xo = xbrl.Get_obj(this.XBRL_rootName, "ca:FirstFilerFlag");
            this.IsFirstFiler = Helper_XML.Get_bool(IsFirstFiler_xo);

            /*----------------------------------------------------------------------------------------------------------------------*/

            Hss_XML_obj PayDate_ADR_xo = xbrl.Get_obj(this.XBRL_rootName, "ca:PaymentDate");
            this.PayDate_ADR = Helper_XML.Get_datetime(PayDate_ADR_xo, "yyyy-MM-dd", Utility.MinDate);

            Hss_XML_obj ExDate_xo = xbrl.Get_obj(this.XBRL_rootName, "ca:OrdExDividendDate");
            this.ExDate = Helper_XML.Get_datetime(ExDate_xo, "yyyy-MM-dd", Utility.MinDate);

            Hss_XML_obj PayDate_ORD_xo = xbrl.Get_obj(this.XBRL_rootName, "ca:OrdPaymentDate");
            this.PayDate_ORD = Helper_XML.Get_datetime(PayDate_ORD_xo, "yyyy-MM-dd", Utility.MinDate);

            Hss_XML_obj RecordDate_ADR_xo = xbrl.Get_obj(this.XBRL_rootName, "ca:RecordDate");
            this.RecordDate_ADR = Helper_XML.Get_datetime(RecordDate_ADR_xo, "yyyy-MM-dd", Utility.MinDate);

            Hss_XML_obj RecordDate_ORD_xo = xbrl.Get_obj(this.XBRL_rootName, "ca:OrdRecordDate");
            this.RecordDate_ORD = Helper_XML.Get_datetime(RecordDate_ORD_xo, "yyyy-MM-dd", Utility.MinDate);

            /*----------------------------------------------------------------------------------------------------------------------*/

            Hss_XML_obj ratio_ADR_xo = xbrl.Get_obj(this.XBRL_rootName, "ca:ADRBase");
            Hss_XML_obj ratio_ORD_xo = xbrl.Get_obj(this.XBRL_rootName, "ca:OrdinaryShare");
            this.ADR_Ratio_ADR = Helper_XML.Get_decimal(ratio_ADR_xo, 0);
            this.ADR_Ratio_ORD = Helper_XML.Get_decimal(ratio_ORD_xo, 0);

            this.Get_FXrate(xbrl);

            Hss_XML_obj StatutoryRate_xo = xbrl.Get_obj(this.XBRL_rootName, "ca:WithholdingTaxPercentage");
            this.StatutoryRate = Helper_XML.Get_decimal(StatutoryRate_xo, 0);

            /*----------------------------------------------------------------------------------------------------------------------*/

            Hss_XML_obj EventCompleteness_xo = xbrl.Get_obj(this.XBRL_rootName, "ca:EventCompleteness");
            if (EventCompleteness_xo != null) this.EventCompleteness = EventCompleteness_xo.value;

            Hss_XML_obj EventType_xo = xbrl.Get_obj(this.XBRL_rootName, "ca:EventType");
            if (EventType_xo != null) this.EventType = EventType_xo.value;

            Hss_XML_obj DivGrossAmount_ORD_xo = xbrl.Get_obj(this.XBRL_rootName, "ca:OrdinaryGrossDividendPayoutRate");
            this.DivGrossAmount_ORD = Helper_XML.Get_decimal(DivGrossAmount_ORD_xo, 0);
            if (DivGrossAmount_ORD_xo != null) this.PaidCurrency_ORD = DivGrossAmount_ORD_xo.Get_attr("UnitRef");

            Hss_XML_obj TickerSymbol_xo = xbrl.Get_obj(this.XBRL_rootName, "ca:TradingSymbol");
            if (TickerSymbol_xo != null) this.TickerSymbol = TickerSymbol_xo.value;

            Hss_XML_obj issue_xo = xbrl.Get_obj(this.XBRL_rootName, "ca:SecurityDescription");
            if (issue_xo != null) this.Issue = issue_xo.value;

            /*----------------------------------------------------------------------------------------------------------------------*/

            Hss_XML_obj depo_xo = xbrl.Get_obj(this.XBRL_rootName, "ca:DepositaryName");
            if (depo_xo != null) this.depoName = depo_xo.value;

            Hss_XML_obj sender_xo = xbrl.Get_obj(this.XBRL_rootName, "xbrli:context", "xbrli:entity", "xbrli:identifier");
            if (sender_xo != null) this.Sender = sender_xo.value;

            /*----------------------------------------------------------------------------------------------------------------------*/

            Hss_XML_obj xbrl_ref_xo = xbrl.Get_obj(this.XBRL_rootName, "ca:UniqueUniversalEventIdentifier");
            if (xbrl_ref_xo != null) this.XBRL_ReferenceNumber = xbrl_ref_xo.value;

            Hss_XML_obj annType_xo = xbrl.Get_obj(this.XBRL_rootName, "ca:AnnouncementType");
            if (annType_xo != null) this.AnnouncementType = annType_xo.value;

            Hss_XML_obj annID_xo = xbrl.Get_obj(this.XBRL_rootName, "ca:AnnouncementIdentifier");
            if (annID_xo != null) this.AnnouncementIdentifier = annID_xo.value;

            Hss_XML_obj annDate_xo = xbrl.Get_obj(this.XBRL_rootName, "ca:AnnouncementDate");
            this.AnnouncementDate = Helper_XML.Get_datetime(annDate_xo, "yyyy-MM-dd", Utility.MinDate);

            /****************************************/
            this.Get_Fees(xbrl);
        }

        private void Get_CUSIP(Hss_XML_obj xbrl)
        {
            if (xbrl == null) return;

            List<Hss_XML_obj> list = xbrl.Get_obj_list(this.XBRL_rootName, "ca:InstrumentIdentifier");
            foreach (Hss_XML_obj xo in list)
            {
                string s = xo.Get_attr("contextRef");
                if (s == null) continue;
                else s = s.ToUpper();

                if (s.Contains("CUSIP")) this.CUSIP = xo.value;
                else if (s.Contains("ISIN")) this.ISIN = xo.value;
            }
        }

        private void Get_FXrate(Hss_XML_obj xbrl)
        {
            if (xbrl == null) return;

            Hss_XML_obj fx_xo = xbrl.Get_obj(this.XBRL_rootName, "ca:ForeignExchangeConversionRateForADRPayment");
            if (fx_xo == null) return;

            decimal val = Helper_XML.Get_decimal(fx_xo, 0);
            if (val == 0) return;

            string unitRef = fx_xo.Get_attr("unitRef");
            if (unitRef == null) unitRef = "";
            unitRef = unitRef.ToUpper().Trim();

            int index_usd = unitRef.IndexOf("USD");
            if (index_usd == 0)
            {
                this.FXrate_US_to_foreign = val;
                this.FXrate_foreign_to_US = 1m / val;
            }
            else
            {
                this.FXrate_foreign_to_US = val;
                this.FXrate_US_to_foreign = 1m / val;
            }
        }

        private void Get_Fees(Hss_XML_obj xbrl)
        {
            if (xbrl == null) return;
            else this.fee_list.Clear();

            List<Hss_XML_obj> WithholdingTaxPercentage_xoList = xbrl.Get_obj_list(this.XBRL_rootName, "ca:WithholdingTaxPercentage");
            foreach (Hss_XML_obj xo in WithholdingTaxPercentage_xoList)
            {
                FeeInfo fi = new FeeInfo();
                this.fee_list.Add(fi);
                fi.WithholdingTaxPercentage = Helper_XML.Get_decimal(xo, 0);
            }

            List<Hss_XML_obj> PayoutAmount_xoList = xbrl.Get_obj_list(this.XBRL_rootName, "ca:PayoutAmount");
            for (int i = 0; i < this.fee_list.Count; ++i)
            {
                if (i >= PayoutAmount_xoList.Count) break;
                else this.fee_list[i].PayoutAmount = Helper_XML.Get_decimal(PayoutAmount_xoList[i], 0);
            }

            List<Hss_XML_obj> TaxAmountWithheldFromPayout_xoList = xbrl.Get_obj_list(this.XBRL_rootName, "ca:TaxAmountWithheldFromPayout");
            for (int i = 0; i < this.fee_list.Count; ++i)
            {
                if (i >= TaxAmountWithheldFromPayout_xoList.Count) break;
                else this.fee_list[i].TaxAmountWithheldFromPayout = Helper_XML.Get_decimal(TaxAmountWithheldFromPayout_xoList[i], 0);
            }

            List<Hss_XML_obj> TaxReliefFee_xoList = xbrl.Get_obj_list(this.XBRL_rootName, "ca:TaxReliefFee");
            for (int i = 0; i < this.fee_list.Count; ++i)
            {
                if (i >= TaxReliefFee_xoList.Count) break;
                else this.fee_list[i].TaxReliefFee = Helper_XML.Get_decimal(TaxReliefFee_xoList[i], 0);
            }

            List<Hss_XML_obj> FeeRate_xoList = xbrl.Get_obj_list(this.XBRL_rootName, "ca:FeeRate");
            for (int i = 0; i < this.fee_list.Count; ++i)
            {
                if (i >= FeeRate_xoList.Count) break;
                else this.fee_list[i].FeeRate = Helper_XML.Get_decimal(FeeRate_xoList[i], 0);
            }

            List<Hss_XML_obj> PayoutAmountNetOfTax_xoList = xbrl.Get_obj_list(this.XBRL_rootName, "ca:PayoutAmountNetOfTax");
            for (int i = 0; i < this.fee_list.Count; ++i)
            {
                if (i >= PayoutAmountNetOfTax_xoList.Count) break;
                else this.fee_list[i].PayoutAmountNetOfTax = Helper_XML.Get_decimal(PayoutAmountNetOfTax_xoList[i], 0);
            }

            List<Hss_XML_obj> DepositaryServiceFee_xoList = xbrl.Get_obj_list(this.XBRL_rootName, "ca:DepositaryServiceFee");
            for (int i = 0; i < this.fee_list.Count; ++i)
            {
                if (i >= DepositaryServiceFee_xoList.Count) break;
                else this.fee_list[i].DepositaryServiceFee = Helper_XML.Get_decimal(DepositaryServiceFee_xoList[i], 0);
            }
        }
        /*^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^*/

        public bool IsCompleteEvent_flag
        {
            get
            {
                if (string.IsNullOrEmpty(this.EventCompleteness)) return false;
                return this.EventCompleteness.StartsWith("Complete", StringComparison.OrdinalIgnoreCase);
            }
        }

        public bool IsCancellation_flag
        {
            get
            {
                if (string.IsNullOrEmpty(this.AnnouncementType)) return false;
                return this.AnnouncementType.StartsWith("Cancel", StringComparison.OrdinalIgnoreCase);
            }
        }
    }

    public class FeeInfo
    {
        public decimal WithholdingTaxPercentage = 0;
        public decimal PayoutAmount = 0;
        public decimal TaxAmountWithheldFromPayout = 0;
        public decimal TaxReliefFee = 0;
        public decimal FeeRate = 0;
        public decimal PayoutAmountNetOfTax = 0;

        public decimal DepositaryServiceFee = 0;
    }
}
