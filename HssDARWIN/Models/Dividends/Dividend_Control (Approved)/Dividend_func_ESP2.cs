using System;
using System.Text;
using System.Collections.Generic;

using HssUtility.SQLserver;
using HssDARWIN.Models.Custodians;
using HssDARWIN.Models.Countries;
using HssDARWIN.Models.ESP2.Events;
using HssDARWIN.Models.ESP2.Depositaries;
using HssDARWIN.Models.ESP2.Custodians;

namespace HssDARWIN.Models.Dividends
{
    public partial class Dividend
    {
        public int Publish_to_ESP2()
        {
            int successValue = 0;

            /***************************************deal with security******************************************/
            List<ESP2.Securities.Security> esp2_secList = ESP2.Securities.SecurityMaster.Get_secList_cusip(this.CUSIP.Value);
            ESP2.Securities.Security esp2_sec = null;
            if (esp2_secList.Count < 1)
            {
                Securities.Security drwin_sec = this.Get_security();
                if (drwin_sec == null) return -1;

                ESP2.Securities.Security new_esp2_sec = new ESP2.Securities.Security();
                new_esp2_sec.Init_from_DRWIN_sec(drwin_sec);
                if (new_esp2_sec.Insert_to_DB()) successValue += 1;
            }
            else esp2_sec = esp2_secList[0];

            if (esp2_sec == null)//try get esp2 security again
            {
                esp2_secList = ESP2.Securities.SecurityMaster.Get_secList_cusip(this.CUSIP.Value);
                if (esp2_secList.Count < 1) return -2;
                else esp2_sec = esp2_secList[0];
            }
            /*^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^*/

            Event esp2_event = new Event();
            esp2_event.Init_from_Dividend(this);
            esp2_event.security_id.Value = esp2_sec.security_id;

            /***************************************deal with depository******************************************/
            DepositaryInfo depoInfo = DepositaryInfoMaster.GetDepo_by_name(this.Depositary.Value);
            if (depoInfo == null)
            {
                DepositaryInfo new_depo = new DepositaryInfo();
                Depositaries.Depositary drwin_depo = Depositaries.DepositaryMaster.GetDepositary_by_name(this.Depositary.Value);

                new_depo.Init_from_DRWIN_depo(drwin_depo);
                new_depo.Insert_to_DB();
                DepositaryInfoMaster.Reset();

                depoInfo = DepositaryInfoMaster.GetDepo_by_name(this.Depositary.Value);
                if (depoInfo == null) return -3;

                DepositaryIdemnification di = new DepositaryIdemnification();
                di.Init_from_DRWIN_depo(drwin_depo);
                di.depositary_info_id.Value = depoInfo.depositary_info_id;
                di.Insert_to_DB();
            }
            /*^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^*/

            esp2_event.depositary_info_id.Value = depoInfo.depositary_info_id;//depositary info

            Dictionary<int, DividendCustodian> cust_dic = this.Get_dvdCust_dic(null);
            DividendCustodian primary_DRWIN_cust = null;
            foreach (DividendCustodian dvdCust in cust_dic.Values)
            {
                if (dvdCust.Custodian_Number.Value < 0) continue;
                if (dvdCust.Custodian_Type.Value.StartsWith("custodian", StringComparison.OrdinalIgnoreCase))
                {
                    primary_DRWIN_cust = dvdCust;
                    break;
                }
            }
            if (primary_DRWIN_cust == null) return -4;
            else
            {
                if (esp2_event.Insert_to_DB()) successValue += 2;
                else return -5;
            }

            /*******************************deal with dividend custodian************************************/
            Event inserted_esp2event = EventMaster.GetEvent_DividendIndex(this.DividendIndex);
            if (inserted_esp2event == null) return -6;

            Country cty = CountryMaster.GetCountry_name(this.Country.Value);
            if (cty == null) return -7;

            PrimaryCustodian pc = new PrimaryCustodian();
            pc.Init_from_DRWIN_dvdCust(primary_DRWIN_cust, cty, inserted_esp2event);
            pc.Insert_to_DB();

            EventContactInfo eci = new EventContactInfo();
            eci.Init_from_DRWIN_dvdCust(primary_DRWIN_cust, cty, inserted_esp2event);
            eci.Insert_to_DB();
            /*^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^*/

            return successValue;
        }

        public string ToXML_ESP2()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("<Dividend>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<DividendIndex>").Append(this.DividendIndex).Append("</DividendIndex>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<DividendID>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.DividendID.Value)).Append("</DividendID>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<IncomeEventID>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.IncomeEventID.Value)).Append("</IncomeEventID>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Issue>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.Issue.Value)).Append("</Issue>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Depositary>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.Depositary.Value)).Append("</Depositary>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<CUSIP>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.CUSIP.Value)).Append("</CUSIP>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Sponsored>").Append(this.Sponsored.Value).Append("</Sponsored>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<RecordDate_ORD>").Append(this.RecordDate_ORD.Value).Append("</RecordDate_ORD>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<RecordDate_ADR>").Append(this.RecordDate_ADR.Value).Append("</RecordDate_ADR>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<PayDate_ORD>").Append(this.PayDate_ORD.Value).Append("</PayDate_ORD>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<PayDate_ADR>").Append(this.PayDate_ADR.Value).Append("</PayDate_ADR>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<FinalDivGrossAmount_ORD>").Append(this.FinalDivGrossAmount_ORD.Value).Append("</FinalDivGrossAmount_ORD>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<FinalDivGrossAmount_ADR>").Append(this.FinalDivGrossAmount_ADR.Value).Append("</FinalDivGrossAmount_ADR>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<ApproxDivGrossAmount_ORD>").Append(this.ApproxDivGrossAmount_ORD.Value).Append("</ApproxDivGrossAmount_ORD>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<ApproxDivGrossAmount_ADR>").Append(this.ApproxDivGrossAmount_ADR.Value).Append("</ApproxDivGrossAmount_ADR>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<DivNetAmount_ORD>").Append(this.DivNetAmount_ORD.Value).Append("</DivNetAmount_ORD>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<DivNetAmount_ADR>").Append(this.DivNetAmount_ADR.Value).Append("</DivNetAmount_ADR>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<ApproximateFXRate>").Append(this.ApproximateFXRate.Value).Append("</ApproximateFXRate>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<FinalFXRate>").Append(this.FinalFXRate.Value).Append("</FinalFXRate>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<ADR_Ratio_ORD>").Append(this.ADR_Ratio_ORD.Value).Append("</ADR_Ratio_ORD>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<ADR_Ratio_ADR>").Append(this.ADR_Ratio_ADR.Value).Append("</ADR_Ratio_ADR>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<LongFormFee>").Append(this.LongFormFee.Value).Append("</LongFormFee>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<ShortFormFee>").Append(this.ShortFormFee.Value).Append("</ShortFormFee>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<AtSourceFee>").Append(this.AtSourceFee.Value).Append("</AtSourceFee>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<QuickRefundFee>").Append(this.QuickRefundFee.Value).Append("</QuickRefundFee>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<MinLongFormFee>").Append(this.MinLongFormFee.Value).Append("</MinLongFormFee>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<MinQuickRefundFee>").Append(this.MinQuickRefundFee.Value).Append("</MinQuickRefundFee>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<MinAtSource_Fee>").Append(this.MinAtSource_Fee.Value).Append("</MinAtSource_Fee>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<MinShortFormFee>").Append(this.MinShortFormFee.Value).Append("</MinShortFormFee>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<ExDate>").Append(this.ExDate.Value).Append("</ExDate>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<SEDOL>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.SEDOL.Value)).Append("</SEDOL>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<ISIN>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.ISIN.Value)).Append("</ISIN>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<DepositaryAccountNumber>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.DepositaryAccountNumber.Value)).Append("</DepositaryAccountNumber>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<GermanySecurityNumber>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.GermanySecurityNumber.Value)).Append("</GermanySecurityNumber>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<CurrentMode>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.CurrentMode.Value)).Append("</CurrentMode>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Country>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.Country.Value)).Append("</Country>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<StatutoryRate>").Append(this.StatutoryRate.Value).Append("</StatutoryRate>").Append(HssUtility.General.HssStr.WinNextLine);
            //sb.Append("<Editor>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.Editor.Value)).Append("</Editor>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<paidCurrency>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.PaidCurrency.Value)).Append("</paidCurrency>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<paidCurrency_ORD>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.PaidCurrency_ORD.Value)).Append("</paidCurrency_ORD>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<atSource>").Append(this.AtSource.Value).Append("</atSource>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<quickRefund>").Append(this.QuickRefund.Value).Append("</quickRefund>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<longForm>").Append(this.LongForm.Value).Append("</longForm>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Publish_Important_Notice_Deadline>").Append(this.Publish_Important_Notice_Deadline.Value).Append("</Publish_Important_Notice_Deadline>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Mail_RSH_Important_Notice_Deadline>").Append(this.Mail_RSH_Important_Notice_Deadline.Value).Append("</Mail_RSH_Important_Notice_Deadline>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<EDS_Opens_Deadline>").Append(this.EDS_Opens_Deadline.Value).Append("</EDS_Opens_Deadline>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<EDS_Closes_Deadline>").Append(this.EDS_Closes_Deadline.Value).Append("</EDS_Closes_Deadline>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Filing_Deadline>").Append(this.Filing_Deadline.Value).Append("</Filing_Deadline>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<RSH_List_Receipt_Deadline>").Append(this.RSH_List_Receipt_Deadline.Value).Append("</RSH_List_Receipt_Deadline>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<EDS_Receipt_Deadline>").Append(this.EDS_Receipt_Deadline.Value).Append("</EDS_Receipt_Deadline>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Custodial_LongForm_Claims_Deadline>").Append(this.Custodial_LongForm_Claims_Deadline.Value).Append("</Custodial_LongForm_Claims_Deadline>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<At_Source_Deadline>").Append(this.At_Source_Deadline.Value).Append("</At_Source_Deadline>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Quick_Refund_Deadline>").Append(this.Quick_Refund_Deadline.Value).Append("</Quick_Refund_Deadline>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Cust_Statute_Limitations>").Append(this.Cust_Statute_Limitations.Value).Append("</Cust_Statute_Limitations>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Comments>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.Comments.Value)).Append("</Comments>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Model_Number>").Append(this.Model_Number.Value).Append("</Model_Number>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<DTCPosition_ModelNumber>").Append(this.DTCPosition_ModelNumber.Value).Append("</DTCPosition_ModelNumber>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Status>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.Status.Value)).Append("</Status>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<TickerSymbol>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.TickerSymbol.Value)).Append("</TickerSymbol>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<BAL_Sheet_Receipt_Deadline>").Append(this.BAL_Sheet_Receipt_Deadline.Value).Append("</BAL_Sheet_Receipt_Deadline>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<SEC_EDS_Opens_Deadline>").Append(this.SEC_EDS_Opens_Deadline.Value).Append("</SEC_EDS_Opens_Deadline>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<SEC_EDS_Closes_Deadline>").Append(this.SEC_EDS_Closes_Deadline.Value).Append("</SEC_EDS_Closes_Deadline>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<MAX_Fees>").Append(this.MAX_Fees.Value).Append("</MAX_Fees>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Publish_Important_Notice_Complete>").Append(this.Publish_Important_Notice_Complete.Value).Append("</Publish_Important_Notice_Complete>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Mail_RSH_Important_Notice_Complete>").Append(this.Mail_RSH_Important_Notice_Complete.Value).Append("</Mail_RSH_Important_Notice_Complete>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<RSH_List_Receipt_Complete>").Append(this.RSH_List_Receipt_Complete.Value).Append("</RSH_List_Receipt_Complete>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<BAL_Sheet_Receipt_Complete>").Append(this.BAL_Sheet_Receipt_Complete.Value).Append("</BAL_Sheet_Receipt_Complete>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<EDS_Receipt_Complete>").Append(this.EDS_Receipt_Complete.Value).Append("</EDS_Receipt_Complete>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<StatuteOfLimitation>").Append(this.StatuteOfLimitation.Value).Append("</StatuteOfLimitation>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<DBXML_ReferenceNumber>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.DBXML_ReferenceNumber.Value)).Append("</DBXML_ReferenceNumber>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<ISO2CntryCode>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.ISO2CntryCode.Value)).Append("</ISO2CntryCode>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<OverseasTaxCredit>").Append(this.OverseasTaxCredit.Value).Append("</OverseasTaxCredit>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<XBRL_ReferenceNumber>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.XBRL_ReferenceNumber.Value)).Append("</XBRL_ReferenceNumber>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Round_ClaimShares_ADRs>").Append(this.Round_ClaimShares_ADRs.Value).Append("</Round_ClaimShares_ADRs>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Round_ClaimShares_ORDs>").Append(this.Round_ClaimShares_ORDs.Value).Append("</Round_ClaimShares_ORDs>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<MinADRSimplifiedProcedure>").Append(this.MinADRSimplifiedProcedure.Value).Append("</MinADRSimplifiedProcedure>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<FavAtSourceFee>").Append(this.FavAtSourceFee.Value).Append("</FavAtSourceFee>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<ExemptAtSourceFee>").Append(this.ExemptAtSourceFee.Value).Append("</ExemptAtSourceFee>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<FavTransparentEntityFee>").Append(this.FavTransparentEntityFee.Value).Append("</FavTransparentEntityFee>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<AssetType>").Append(this.AssetType.Value).Append("</AssetType>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<ConsularizationFee>").Append(this.ConsularizationFee.Value).Append("</ConsularizationFee>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<AltFinalDivGrossAmount_ORD>").Append(this.AltFinalDivGrossAmount_ORD.Value).Append("</AltFinalDivGrossAmount_ORD>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<MaturityDate>").Append(this.MaturityDate.Value).Append("</MaturityDate>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<InterestRate>").Append(this.InterestRate.Value).Append("</InterestRate>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<DTCCImportantNoticeB>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.DTCCImportantNoticeB.Value)).Append("</DTCCImportantNoticeB>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<AddUSDisclosure>").Append(this.AddUSDisclosure.Value).Append("</AddUSDisclosure>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Domesticated>").Append(this.Domesticated.Value).Append("</Domesticated>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<SecurityTypeID>").Append(this.SecurityTypeID.Value).Append("</SecurityTypeID>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<ReversalIndicator>").Append(this.ReversalIndicator.Value).Append("</ReversalIndicator>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<FaceAmount>").Append(this.FaceAmount.Value).Append("</FaceAmount>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<PlaceOfSafekeeping>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.PlaceOfSafekeeping.Value)).Append("</PlaceOfSafekeeping>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<FirstFiler>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.FirstFiler.Value)).Append("</FirstFiler>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<ESPLogin>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.ESPLogin.Value)).Append("</ESPLogin>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<OriginalIssueDiscount>").Append(this.OriginalIssueDiscount.Value).Append("</OriginalIssueDiscount>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<LastInterestPayDate>").Append(this.LastInterestPayDate.Value).Append("</LastInterestPayDate>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<EventType>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.EventType.Value)).Append("</EventType>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<BondType>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.BondType.Value)).Append("</BondType>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<RecordDate_ADR_Missing>").Append(this.RecordDate_ADR_Missing.Value).Append("</RecordDate_ADR_Missing>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<AuditAvailable>").Append(this.AuditAvailable.Value).Append("</AuditAvailable>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Issuer_ATTN>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.Issuer_ATTN.Value)).Append("</Issuer_ATTN>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Issuer_Address1>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.Issuer_Address1.Value)).Append("</Issuer_Address1>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Issuer_Address2>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.Issuer_Address2.Value)).Append("</Issuer_Address2>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<SupplementalInterestPayment>").Append(this.SupplementalInterestPayment.Value).Append("</SupplementalInterestPayment>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<HidePayDate_ORD>").Append(this.HidePayDate_ORD.Value).Append("</HidePayDate_ORD>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<QR1stBatch_Deadline>").Append(this.QR1stBatch_Deadline.Value).Append("</QR1stBatch_Deadline>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Coupon_Number>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.Coupon_Number.Value)).Append("</Coupon_Number>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<LastModifiedBy>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.LastModifiedBy.Value)).Append("</LastModifiedBy>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<LastModifiedDateTime>").Append(this.LastModifiedDateTime.Value).Append("</LastModifiedDateTime>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Min_ReclaimValue_USD_QR>").Append(this.Min_ReclaimValue_USD_QR.Value).Append("</Min_ReclaimValue_USD_QR>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Min_ReclaimValue_USD_LF>").Append(this.Min_ReclaimValue_USD_LF.Value).Append("</Min_ReclaimValue_USD_LF>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Orange_Note>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.Orange_Note.Value)).Append("</Orange_Note>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<FirstFiling_Checked>").Append(this.FirstFiling_Checked.Value).Append("</FirstFiling_Checked>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<FirstPayment_Checked>").Append(this.FirstPayment_Checked.Value).Append("</FirstPayment_Checked>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<SuppressTasks_Checked>").Append(this.SuppressTasks_Checked.Value).Append("</SuppressTasks_Checked>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<CAWebCutoff_Deadline>").Append(this.CAWebCutoff_Deadline.Value).Append("</CAWebCutoff_Deadline>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("</Dividend>").Append(HssUtility.General.HssStr.WinNextLine);
            return sb.ToString();
        }
    }
}
