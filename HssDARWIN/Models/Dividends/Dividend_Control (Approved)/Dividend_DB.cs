using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HssDARWIN.Models.Dividends
{
    public partial class Dividend
    {
        internal void Init_from_reader(HssUtility.SQLserver.DB_reader reader)
        {
            if (reader == null || reader.IsClosed) return;

            this.pk_ID = reader.GetInt("DividendIndex");
            reader.GetString("DividendID", this.DividendID);
            reader.GetString("IncomeEventID", this.IncomeEventID);/*Optional 3*/
            reader.GetString("Issue", this.Issue);
            reader.GetString("Depositary", this.Depositary);
            reader.GetString("CUSIP", this.CUSIP);
            reader.GetBool("Sponsored", this.Sponsored);/*Optional 7*/
            reader.GetDateTime("RecordDate_ORD", this.RecordDate_ORD);/*Optional 8*/
            reader.GetDateTime("RecordDate_ADR", this.RecordDate_ADR);
            reader.GetDateTime("PayDate_ORD", this.PayDate_ORD);/*Optional 10*/
            reader.GetDateTime("PayDate_ADR", this.PayDate_ADR);/*Optional 11*/
            reader.GetDecimal("FinalDivGrossAmount_ORD", this.FinalDivGrossAmount_ORD);/*Optional 12*/
            reader.GetDecimal("FinalDivGrossAmount_ADR", this.FinalDivGrossAmount_ADR);/*Optional 13*/
            reader.GetDecimal("ApproxDivGrossAmount_ORD", this.ApproxDivGrossAmount_ORD);/*Optional 14*/
            reader.GetDecimal("ApproxDivGrossAmount_ADR", this.ApproxDivGrossAmount_ADR);/*Optional 15*/
            reader.GetDecimal("DivNetAmount_ORD", this.DivNetAmount_ORD);/*Optional 16*/
            reader.GetDecimal("DivNetAmount_ADR", this.DivNetAmount_ADR);/*Optional 17*/
            reader.GetDecimal("ApproximateFXRate", this.ApproximateFXRate);/*Optional 18*/
            reader.GetDecimal("FinalFXRate", this.FinalFXRate);/*Optional 19*/
            reader.GetDecimal("ADR_Ratio_ORD", this.ADR_Ratio_ORD);/*Optional 20*/
            reader.GetDecimal("ADR_Ratio_ADR", this.ADR_Ratio_ADR);/*Optional 21*/
            reader.GetDecimal("LongFormFee", this.LongFormFee);
            reader.GetDecimal("ShortFormFee", this.ShortFormFee);
            reader.GetDecimal("AtSourceFee", this.AtSourceFee);
            reader.GetDecimal("QuickRefundFee", this.QuickRefundFee);
            reader.GetDecimal("MinLongFormFee", this.MinLongFormFee);
            reader.GetDecimal("MinQuickRefundFee", this.MinQuickRefundFee);
            reader.GetDecimal("MinAtSource_Fee", this.MinAtSource_Fee);
            reader.GetDecimal("MinShortFormFee", this.MinShortFormFee);
            reader.GetDateTime("ExDate", this.ExDate);/*Optional 30*/
            reader.GetString("SEDOL", this.SEDOL);/*Optional 31*/
            reader.GetString("ISIN", this.ISIN);/*Optional 32*/
            reader.GetString("DepositaryAccountNumber", this.DepositaryAccountNumber);/*Optional 33*/
            reader.GetString("GermanySecurityNumber", this.GermanySecurityNumber);/*Optional 34*/
            reader.GetString("CurrentMode", this.CurrentMode);/*Optional 35*/
            reader.GetString("Country", this.Country);
            reader.GetDecimal("StatutoryRate", this.StatutoryRate);/*Optional 37*/
            //reader.GetString("Editor", this.Editor);
            reader.GetString("PaidCurrency", this.PaidCurrency);
            reader.GetString("PaidCurrency_ORD", this.PaidCurrency_ORD);/*Optional 40*/
            reader.GetBool("AtSource", this.AtSource);/*Optional 41*/
            reader.GetBool("QuickRefund", this.QuickRefund);/*Optional 42*/
            reader.GetBool("LongForm", this.LongForm);/*Optional 43*/
            reader.GetDateTime("Publish_Important_Notice_Deadline", this.Publish_Important_Notice_Deadline);/*Optional 44*/
            reader.GetDateTime("Mail_RSH_Important_Notice_Deadline", this.Mail_RSH_Important_Notice_Deadline);/*Optional 45*/
            reader.GetDateTime("EDS_Opens_Deadline", this.EDS_Opens_Deadline);/*Optional 46*/
            reader.GetDateTime("EDS_Closes_Deadline", this.EDS_Closes_Deadline);/*Optional 47*/
            reader.GetDateTime("Filing_Deadline", this.Filing_Deadline);/*Optional 48*/
            reader.GetDateTime("RSH_List_Receipt_Deadline", this.RSH_List_Receipt_Deadline);/*Optional 49*/
            reader.GetDateTime("EDS_Receipt_Deadline", this.EDS_Receipt_Deadline);/*Optional 50*/
            reader.GetDateTime("Custodial_LongForm_Claims_Deadline", this.Custodial_LongForm_Claims_Deadline);/*Optional 51*/
            reader.GetDateTime("At_Source_Deadline", this.At_Source_Deadline);/*Optional 52*/
            reader.GetDateTime("Quick_Refund_Deadline", this.Quick_Refund_Deadline);/*Optional 53*/
            reader.GetDateTime("Cust_Statute_Limitations", this.Cust_Statute_Limitations);/*Optional 54*/
            reader.GetString("Comments", this.Comments);/*Optional 55*/
            reader.GetInt("Model_Number", this.Model_Number);/*Optional 56*/
            reader.GetInt("DTCPosition_ModelNumber", this.DTCPosition_ModelNumber);
            reader.GetString("Status", this.Status);
            reader.GetString("TickerSymbol", this.TickerSymbol);/*Optional 59*/
            reader.GetDateTime("BAL_Sheet_Receipt_Deadline", this.BAL_Sheet_Receipt_Deadline);/*Optional 60*/
            reader.GetDateTime("SEC_EDS_Opens_Deadline", this.SEC_EDS_Opens_Deadline);/*Optional 61*/
            reader.GetDateTime("SEC_EDS_Closes_Deadline", this.SEC_EDS_Closes_Deadline);/*Optional 62*/
            reader.GetDecimal("MAX_Fees", this.MAX_Fees);/*Optional 63*/
            reader.GetDateTime("Publish_Important_Notice_Complete", this.Publish_Important_Notice_Complete);/*Optional 64*/
            reader.GetDateTime("Mail_RSH_Important_Notice_Complete", this.Mail_RSH_Important_Notice_Complete);/*Optional 65*/
            reader.GetDateTime("RSH_List_Receipt_Complete", this.RSH_List_Receipt_Complete);/*Optional 66*/
            reader.GetDateTime("BAL_Sheet_Receipt_Complete", this.BAL_Sheet_Receipt_Complete);/*Optional 67*/
            reader.GetDateTime("EDS_Receipt_Complete", this.EDS_Receipt_Complete);/*Optional 68*/
            reader.GetDateTime("StatuteOfLimitation", this.StatuteOfLimitation);/*Optional 69*/
            reader.GetString("DBXML_ReferenceNumber", this.DBXML_ReferenceNumber);/*Optional 70*/
            reader.GetString("ISO2CntryCode", this.ISO2CntryCode);
            reader.GetDecimal("OverseasTaxCredit", this.OverseasTaxCredit);/*Optional 72*/
            reader.GetString("XBRL_ReferenceNumber", this.XBRL_ReferenceNumber);/*Optional 73*/
            reader.GetBool("Round_ClaimShares_ADRs", this.Round_ClaimShares_ADRs);
            reader.GetBool("Round_ClaimShares_ORDs", this.Round_ClaimShares_ORDs);
            reader.GetDecimal("MinADRSimplifiedProcedure", this.MinADRSimplifiedProcedure);
            reader.GetDecimal("FavAtSourceFee", this.FavAtSourceFee);/*Optional 77*/
            reader.GetDecimal("ExemptAtSourceFee", this.ExemptAtSourceFee);/*Optional 78*/
            reader.GetDecimal("FavTransparentEntityFee", this.FavTransparentEntityFee);/*Optional 79*/
            reader.GetInt("AssetType", this.AssetType);/*Optional 80*/
            reader.GetDecimal("ConsularizationFee", this.ConsularizationFee);/*Optional 81*/
            reader.GetDecimal("AltFinalDivGrossAmount_ORD", this.AltFinalDivGrossAmount_ORD);
            reader.GetDateTime("MaturityDate", this.MaturityDate);/*Optional 83*/
            reader.GetDecimal("InterestRate", this.InterestRate);/*Optional 84*/
            reader.GetString("DTCCImportantNoticeB", this.DTCCImportantNoticeB);/*Optional 85*/
            reader.GetBool("AddUSDisclosure", this.AddUSDisclosure);/*Optional 86*/
            reader.GetBool("Domesticated", this.Domesticated);/*Optional 87*/
            reader.GetInt("SecurityTypeID", this.SecurityTypeID);
            reader.GetBool("ReversalIndicator", this.ReversalIndicator);/*Optional 89*/
            reader.GetDecimal("FaceAmount", this.FaceAmount);/*Optional 90*/
            reader.GetString("PlaceOfSafekeeping", this.PlaceOfSafekeeping);/*Optional 91*/
            reader.GetString("FirstFiler", this.FirstFiler);/*Optional 92*/
            reader.GetString("ESPLogin", this.ESPLogin);
            reader.GetDecimal("OriginalIssueDiscount", this.OriginalIssueDiscount);/*Optional 94*/
            reader.GetDateTime("LastInterestPayDate", this.LastInterestPayDate);/*Optional 95*/
            reader.GetString("EventType", this.EventType);/*Optional 96*/
            reader.GetString("BondType", this.BondType);/*Optional 97*/
            reader.GetBool("RecordDate_ADR_Missing", this.RecordDate_ADR_Missing);/*Optional 98*/
            reader.GetBool("AuditAvailable", this.AuditAvailable);/*Optional 99*/
            reader.GetString("Issuer_ATTN", this.Issuer_ATTN);/*Optional 100*/
            reader.GetString("Issuer_Address1", this.Issuer_Address1);/*Optional 101*/
            reader.GetString("Issuer_Address2", this.Issuer_Address2);/*Optional 102*/
            reader.GetBool("SupplementalInterestPayment", this.SupplementalInterestPayment);/*Optional 103*/
            reader.GetBool("HidePayDate_ORD", this.HidePayDate_ORD);/*Optional 104*/
            reader.GetDateTime("QR1stBatch_Deadline", this.QR1stBatch_Deadline);/*Optional 105*/
            reader.GetString("Coupon_Number", this.Coupon_Number);/*Optional 106*/
            reader.GetString("LastModifiedBy", this.LastModifiedBy);/*Optional 107*/
            reader.GetDateTime("LastModifiedDateTime", this.LastModifiedDateTime);/*Optional 108*/
            reader.GetDecimal("Min_ReclaimValue_USD_QR", this.Min_ReclaimValue_USD_QR);/*Optional 109*/
            reader.GetDecimal("Min_ReclaimValue_USD_LF", this.Min_ReclaimValue_USD_LF);/*Optional 110*/
            reader.GetString("Orange_Note", this.Orange_Note);/*Optional 111*/
            reader.GetBool("FirstFiling_Checked", this.FirstFiling_Checked);/*Optional 112*/
            reader.GetBool("FirstPayment_Checked", this.FirstPayment_Checked);/*Optional 113*/
            reader.GetBool("SuppressTasks_Checked", this.SuppressTasks_Checked);/*Optional 114*/
            reader.GetDateTime("CAWebCutoff_Deadline", this.CAWebCutoff_Deadline);/*Optional 115*/
            reader.GetDateTime("AGMDate", this.AGMDate);/*Optional 116*/
            reader.GetBool("GDR", this.GDR);/*Optional 117*/

            this.SyncWithDB();
        }

        public bool Init_from_DB(DividendTable_option table)
        {
            if (this.DividendIndex < 0) return false;

            HssUtility.SQLserver.DB_select db_sel = new HssUtility.SQLserver.DB_select(Dividend.Get_cmdTP());
            db_sel.tableName = table.ToString();
            HssUtility.SQLserver.SQL_relation rela = new HssUtility.SQLserver.SQL_relation("DividendIndex", HssUtility.General.RelationalOperator.Equals, this.DividendIndex);
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
            this.attr_dic.Add("DividendID", this.DividendID);
            this.attr_dic.Add("IncomeEventID", this.IncomeEventID);/*Optional 3*/
            this.attr_dic.Add("Issue", this.Issue);
            this.attr_dic.Add("Depositary", this.Depositary);
            this.attr_dic.Add("CUSIP", this.CUSIP);
            this.attr_dic.Add("Sponsored", this.Sponsored);/*Optional 7*/
            this.attr_dic.Add("RecordDate_ORD", this.RecordDate_ORD);/*Optional 8*/
            this.attr_dic.Add("RecordDate_ADR", this.RecordDate_ADR);
            this.attr_dic.Add("PayDate_ORD", this.PayDate_ORD);/*Optional 10*/
            this.attr_dic.Add("PayDate_ADR", this.PayDate_ADR);/*Optional 11*/
            this.attr_dic.Add("FinalDivGrossAmount_ORD", this.FinalDivGrossAmount_ORD);/*Optional 12*/
            this.attr_dic.Add("FinalDivGrossAmount_ADR", this.FinalDivGrossAmount_ADR);/*Optional 13*/
            this.attr_dic.Add("ApproxDivGrossAmount_ORD", this.ApproxDivGrossAmount_ORD);/*Optional 14*/
            this.attr_dic.Add("ApproxDivGrossAmount_ADR", this.ApproxDivGrossAmount_ADR);/*Optional 15*/
            this.attr_dic.Add("DivNetAmount_ORD", this.DivNetAmount_ORD);/*Optional 16*/
            this.attr_dic.Add("DivNetAmount_ADR", this.DivNetAmount_ADR);/*Optional 17*/
            this.attr_dic.Add("ApproximateFXRate", this.ApproximateFXRate);/*Optional 18*/
            this.attr_dic.Add("FinalFXRate", this.FinalFXRate);/*Optional 19*/
            this.attr_dic.Add("ADR_Ratio_ORD", this.ADR_Ratio_ORD);/*Optional 20*/
            this.attr_dic.Add("ADR_Ratio_ADR", this.ADR_Ratio_ADR);/*Optional 21*/
            this.attr_dic.Add("LongFormFee", this.LongFormFee);
            this.attr_dic.Add("ShortFormFee", this.ShortFormFee);
            this.attr_dic.Add("AtSourceFee", this.AtSourceFee);
            this.attr_dic.Add("QuickRefundFee", this.QuickRefundFee);
            this.attr_dic.Add("MinLongFormFee", this.MinLongFormFee);
            this.attr_dic.Add("MinQuickRefundFee", this.MinQuickRefundFee);
            this.attr_dic.Add("MinAtSource_Fee", this.MinAtSource_Fee);
            this.attr_dic.Add("MinShortFormFee", this.MinShortFormFee);
            this.attr_dic.Add("ExDate", this.ExDate);/*Optional 30*/
            this.attr_dic.Add("SEDOL", this.SEDOL);/*Optional 31*/
            this.attr_dic.Add("ISIN", this.ISIN);/*Optional 32*/
            this.attr_dic.Add("DepositaryAccountNumber", this.DepositaryAccountNumber);/*Optional 33*/
            this.attr_dic.Add("GermanySecurityNumber", this.GermanySecurityNumber);/*Optional 34*/
            this.attr_dic.Add("CurrentMode", this.CurrentMode);/*Optional 35*/
            this.attr_dic.Add("Country", this.Country);
            this.attr_dic.Add("StatutoryRate", this.StatutoryRate);/*Optional 37*/
            //this.attr_dic.Add("Editor", this.Editor);
            this.attr_dic.Add("PaidCurrency", this.PaidCurrency);/*Optional 39*/
            this.attr_dic.Add("PaidCurrency_ORD", this.PaidCurrency_ORD);/*Optional 40*/
            this.attr_dic.Add("AtSource", this.AtSource);/*Optional 41*/
            this.attr_dic.Add("QuickRefund", this.QuickRefund);/*Optional 42*/
            this.attr_dic.Add("LongForm", this.LongForm);/*Optional 43*/
            this.attr_dic.Add("Publish_Important_Notice_Deadline", this.Publish_Important_Notice_Deadline);/*Optional 44*/
            this.attr_dic.Add("Mail_RSH_Important_Notice_Deadline", this.Mail_RSH_Important_Notice_Deadline);/*Optional 45*/
            this.attr_dic.Add("EDS_Opens_Deadline", this.EDS_Opens_Deadline);/*Optional 46*/
            this.attr_dic.Add("EDS_Closes_Deadline", this.EDS_Closes_Deadline);/*Optional 47*/
            this.attr_dic.Add("Filing_Deadline", this.Filing_Deadline);/*Optional 48*/
            this.attr_dic.Add("RSH_List_Receipt_Deadline", this.RSH_List_Receipt_Deadline);/*Optional 49*/
            this.attr_dic.Add("EDS_Receipt_Deadline", this.EDS_Receipt_Deadline);/*Optional 50*/
            this.attr_dic.Add("Custodial_LongForm_Claims_Deadline", this.Custodial_LongForm_Claims_Deadline);/*Optional 51*/
            this.attr_dic.Add("At_Source_Deadline", this.At_Source_Deadline);/*Optional 52*/
            this.attr_dic.Add("Quick_Refund_Deadline", this.Quick_Refund_Deadline);/*Optional 53*/
            this.attr_dic.Add("Cust_Statute_Limitations", this.Cust_Statute_Limitations);/*Optional 54*/
            this.attr_dic.Add("Comments", this.Comments);/*Optional 55*/
            this.attr_dic.Add("Model_Number", this.Model_Number);/*Optional 56*/
            this.attr_dic.Add("DTCPosition_ModelNumber", this.DTCPosition_ModelNumber);
            this.attr_dic.Add("Status", this.Status);
            this.attr_dic.Add("TickerSymbol", this.TickerSymbol);/*Optional 59*/
            this.attr_dic.Add("BAL_Sheet_Receipt_Deadline", this.BAL_Sheet_Receipt_Deadline);/*Optional 60*/
            this.attr_dic.Add("SEC_EDS_Opens_Deadline", this.SEC_EDS_Opens_Deadline);/*Optional 61*/
            this.attr_dic.Add("SEC_EDS_Closes_Deadline", this.SEC_EDS_Closes_Deadline);/*Optional 62*/
            this.attr_dic.Add("MAX_Fees", this.MAX_Fees);/*Optional 63*/
            this.attr_dic.Add("Publish_Important_Notice_Complete", this.Publish_Important_Notice_Complete);/*Optional 64*/
            this.attr_dic.Add("Mail_RSH_Important_Notice_Complete", this.Mail_RSH_Important_Notice_Complete);/*Optional 65*/
            this.attr_dic.Add("RSH_List_Receipt_Complete", this.RSH_List_Receipt_Complete);/*Optional 66*/
            this.attr_dic.Add("BAL_Sheet_Receipt_Complete", this.BAL_Sheet_Receipt_Complete);/*Optional 67*/
            this.attr_dic.Add("EDS_Receipt_Complete", this.EDS_Receipt_Complete);/*Optional 68*/
            this.attr_dic.Add("StatuteOfLimitation", this.StatuteOfLimitation);/*Optional 69*/
            this.attr_dic.Add("DBXML_ReferenceNumber", this.DBXML_ReferenceNumber);/*Optional 70*/
            this.attr_dic.Add("ISO2CntryCode", this.ISO2CntryCode);
            this.attr_dic.Add("OverseasTaxCredit", this.OverseasTaxCredit);/*Optional 72*/
            this.attr_dic.Add("XBRL_ReferenceNumber", this.XBRL_ReferenceNumber);/*Optional 73*/
            this.attr_dic.Add("Round_ClaimShares_ADRs", this.Round_ClaimShares_ADRs);
            this.attr_dic.Add("Round_ClaimShares_ORDs", this.Round_ClaimShares_ORDs);
            this.attr_dic.Add("MinADRSimplifiedProcedure", this.MinADRSimplifiedProcedure);
            this.attr_dic.Add("FavAtSourceFee", this.FavAtSourceFee);/*Optional 77*/
            this.attr_dic.Add("ExemptAtSourceFee", this.ExemptAtSourceFee);/*Optional 78*/
            this.attr_dic.Add("FavTransparentEntityFee", this.FavTransparentEntityFee);/*Optional 79*/
            this.attr_dic.Add("AssetType", this.AssetType);/*Optional 80*/
            this.attr_dic.Add("ConsularizationFee", this.ConsularizationFee);/*Optional 81*/
            this.attr_dic.Add("AltFinalDivGrossAmount_ORD", this.AltFinalDivGrossAmount_ORD);
            this.attr_dic.Add("MaturityDate", this.MaturityDate);/*Optional 83*/
            this.attr_dic.Add("InterestRate", this.InterestRate);/*Optional 84*/
            this.attr_dic.Add("DTCCImportantNoticeB", this.DTCCImportantNoticeB);/*Optional 85*/
            this.attr_dic.Add("AddUSDisclosure", this.AddUSDisclosure);/*Optional 86*/
            this.attr_dic.Add("Domesticated", this.Domesticated);/*Optional 87*/
            this.attr_dic.Add("SecurityTypeID", this.SecurityTypeID);
            this.attr_dic.Add("ReversalIndicator", this.ReversalIndicator);/*Optional 89*/
            this.attr_dic.Add("FaceAmount", this.FaceAmount);/*Optional 90*/
            this.attr_dic.Add("PlaceOfSafekeeping", this.PlaceOfSafekeeping);/*Optional 91*/
            this.attr_dic.Add("FirstFiler", this.FirstFiler);/*Optional 92*/
            this.attr_dic.Add("ESPLogin", this.ESPLogin);
            this.attr_dic.Add("OriginalIssueDiscount", this.OriginalIssueDiscount);/*Optional 94*/
            this.attr_dic.Add("LastInterestPayDate", this.LastInterestPayDate);/*Optional 95*/
            this.attr_dic.Add("EventType", this.EventType);/*Optional 96*/
            this.attr_dic.Add("BondType", this.BondType);/*Optional 97*/
            this.attr_dic.Add("RecordDate_ADR_Missing", this.RecordDate_ADR_Missing);/*Optional 98*/
            this.attr_dic.Add("AuditAvailable", this.AuditAvailable);/*Optional 99*/
            this.attr_dic.Add("Issuer_ATTN", this.Issuer_ATTN);/*Optional 100*/
            this.attr_dic.Add("Issuer_Address1", this.Issuer_Address1);/*Optional 101*/
            this.attr_dic.Add("Issuer_Address2", this.Issuer_Address2);/*Optional 102*/
            this.attr_dic.Add("SupplementalInterestPayment", this.SupplementalInterestPayment);/*Optional 103*/
            this.attr_dic.Add("HidePayDate_ORD", this.HidePayDate_ORD);/*Optional 104*/
            this.attr_dic.Add("QR1stBatch_Deadline", this.QR1stBatch_Deadline);/*Optional 105*/
            this.attr_dic.Add("Coupon_Number", this.Coupon_Number);/*Optional 106*/
            this.attr_dic.Add("LastModifiedBy", this.LastModifiedBy);/*Optional 107*/
            this.attr_dic.Add("LastModifiedDateTime", this.LastModifiedDateTime);/*Optional 108*/
            this.attr_dic.Add("Min_ReclaimValue_USD_QR", this.Min_ReclaimValue_USD_QR);/*Optional 109*/
            this.attr_dic.Add("Min_ReclaimValue_USD_LF", this.Min_ReclaimValue_USD_LF);/*Optional 110*/
            this.attr_dic.Add("Orange_Note", this.Orange_Note);/*Optional 111*/
            this.attr_dic.Add("FirstFiling_Checked", this.FirstFiling_Checked);/*Optional 112*/
            this.attr_dic.Add("FirstPayment_Checked", this.FirstPayment_Checked);/*Optional 113*/
            this.attr_dic.Add("SuppressTasks_Checked", this.SuppressTasks_Checked);/*Optional 114*/
            this.attr_dic.Add("CAWebCutoff_Deadline", this.CAWebCutoff_Deadline);/*Optional 115*/
            this.attr_dic.Add("AGMDate", this.AGMDate);/*Optional 116*/
            this.attr_dic.Add("GDR", this.GDR);/*Optional 117*/
        }

        public bool Insert_to_DB(DividendTable_option table)
        {
            this.LastModifiedDateTime.Value = DateTime.Now;

            /*--------------------------deal with DividendID---------------------------------*/
            if (table == DividendTable_option.Dividend_Control)
            {
                List<Dividend> dvdList = Helper_Dividend.Get_DividendList_CUSIP(this.CUSIP.Value);
                HashSet<string> dvdID_hs = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
                foreach (Dividend dvd in dvdList) dvdID_hs.Add(dvd.DividendID.Value);

                int ID_offset = 0;
                string dvdID = this.Create_dividendID(ID_offset);
                while (dvdID_hs.Contains(dvdID))
                {
                    dvdID = this.Create_dividendID(ID_offset);
                    if (++ID_offset > 49) return false;
                }
                this.DividendID.Value = dvdID;
            }
            /*^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^*/

            HssUtility.SQLserver.DB_insert ins = this.Get_DBinsert(table);
            int count = ins.SaveToDB(Utility.Get_DRWIN_hDB());

            bool flag = count > 0;
            if (flag) this.SyncWithDB();

            return flag;
        }

        internal HssUtility.SQLserver.DB_insert Get_DBinsert(DividendTable_option table)
        {
            HssUtility.SQLserver.DB_insert dbIns = new HssUtility.SQLserver.DB_insert(Dividend.Get_cmdTP());
            dbIns.tableName = table.ToString();

            if (table == DividendTable_option.Dividend_Control_Approved) dbIns.AddValue("DividendIndex", this.DividendIndex);

            dbIns.AddValue("DividendID", this.DividendID.Value);
            dbIns.AddValue("IncomeEventID", this.IncomeEventID);/*Optional 3*/
            dbIns.AddValue("Issue", this.Issue.Value);
            dbIns.AddValue("Depositary", this.Depositary.Value);
            dbIns.AddValue("CUSIP", this.CUSIP.Value);
            dbIns.AddValue("Sponsored", this.Sponsored);/*Optional 7*/
            dbIns.AddValue("RecordDate_ORD", this.RecordDate_ORD);/*Optional 8*/
            dbIns.AddValue("RecordDate_ADR", this.RecordDate_ADR.Value);
            dbIns.AddValue("PayDate_ORD", this.PayDate_ORD);/*Optional 10*/
            dbIns.AddValue("PayDate_ADR", this.PayDate_ADR);/*Optional 11*/
            dbIns.AddValue("FinalDivGrossAmount_ORD", this.FinalDivGrossAmount_ORD);/*Optional 12*/
            dbIns.AddValue("FinalDivGrossAmount_ADR", this.FinalDivGrossAmount_ADR);/*Optional 13*/
            dbIns.AddValue("ApproxDivGrossAmount_ORD", this.ApproxDivGrossAmount_ORD);/*Optional 14*/
            dbIns.AddValue("ApproxDivGrossAmount_ADR", this.ApproxDivGrossAmount_ADR);/*Optional 15*/
            dbIns.AddValue("DivNetAmount_ORD", this.DivNetAmount_ORD);/*Optional 16*/
            dbIns.AddValue("DivNetAmount_ADR", this.DivNetAmount_ADR);/*Optional 17*/
            dbIns.AddValue("ApproximateFXRate", this.ApproximateFXRate);/*Optional 18*/
            dbIns.AddValue("FinalFXRate", this.FinalFXRate);/*Optional 19*/
            dbIns.AddValue("ADR_Ratio_ORD", this.ADR_Ratio_ORD);/*Optional 20*/
            dbIns.AddValue("ADR_Ratio_ADR", this.ADR_Ratio_ADR);/*Optional 21*/
            dbIns.AddValue("LongFormFee", this.LongFormFee.Value);
            dbIns.AddValue("ShortFormFee", this.ShortFormFee.Value);
            dbIns.AddValue("AtSourceFee", this.AtSourceFee.Value);
            dbIns.AddValue("QuickRefundFee", this.QuickRefundFee.Value);
            dbIns.AddValue("MinLongFormFee", this.MinLongFormFee.Value);
            dbIns.AddValue("MinQuickRefundFee", this.MinQuickRefundFee.Value);
            dbIns.AddValue("MinAtSource_Fee", this.MinAtSource_Fee.Value);
            dbIns.AddValue("MinShortFormFee", this.MinShortFormFee.Value);
            dbIns.AddValue("ExDate", this.ExDate);/*Optional 30*/
            dbIns.AddValue("SEDOL", this.SEDOL);/*Optional 31*/
            dbIns.AddValue("ISIN", this.ISIN);/*Optional 32*/
            dbIns.AddValue("DepositaryAccountNumber", this.DepositaryAccountNumber);/*Optional 33*/
            dbIns.AddValue("GermanySecurityNumber", this.GermanySecurityNumber);/*Optional 34*/
            dbIns.AddValue("CurrentMode", this.CurrentMode);/*Optional 35*/
            dbIns.AddValue("Country", this.Country.Value);
            dbIns.AddValue("StatutoryRate", this.StatutoryRate);/*Optional 37*/
            //dbIns.AddValue("Editor", this.Editor.Value);
            dbIns.AddValue("PaidCurrency", this.PaidCurrency.Value);
            dbIns.AddValue("PaidCurrency_ORD", this.PaidCurrency_ORD);/*Optional 40*/
            dbIns.AddValue("AtSource", this.AtSource);/*Optional 41*/
            dbIns.AddValue("QuickRefund", this.QuickRefund);/*Optional 42*/
            dbIns.AddValue("LongForm", this.LongForm);/*Optional 43*/
            dbIns.AddValue("Publish_Important_Notice_Deadline", this.Publish_Important_Notice_Deadline);/*Optional 44*/
            dbIns.AddValue("Mail_RSH_Important_Notice_Deadline", this.Mail_RSH_Important_Notice_Deadline);/*Optional 45*/
            dbIns.AddValue("EDS_Opens_Deadline", this.EDS_Opens_Deadline);/*Optional 46*/
            dbIns.AddValue("EDS_Closes_Deadline", this.EDS_Closes_Deadline);/*Optional 47*/
            dbIns.AddValue("Filing_Deadline", this.Filing_Deadline);/*Optional 48*/
            dbIns.AddValue("RSH_List_Receipt_Deadline", this.RSH_List_Receipt_Deadline);/*Optional 49*/
            dbIns.AddValue("EDS_Receipt_Deadline", this.EDS_Receipt_Deadline);/*Optional 50*/
            dbIns.AddValue("Custodial_LongForm_Claims_Deadline", this.Custodial_LongForm_Claims_Deadline);/*Optional 51*/
            dbIns.AddValue("At_Source_Deadline", this.At_Source_Deadline);/*Optional 52*/
            dbIns.AddValue("Quick_Refund_Deadline", this.Quick_Refund_Deadline);/*Optional 53*/
            dbIns.AddValue("Cust_Statute_Limitations", this.Cust_Statute_Limitations);/*Optional 54*/
            dbIns.AddValue("Comments", this.Comments);/*Optional 55*/
            dbIns.AddValue("Model_Number", this.Model_Number, false);/*Optional 56*/
            dbIns.AddValue("DTCPosition_ModelNumber", this.DTCPosition_ModelNumber.Value);
            dbIns.AddValue("Status", this.Status.Value);
            dbIns.AddValue("TickerSymbol", this.TickerSymbol);/*Optional 59*/
            dbIns.AddValue("BAL_Sheet_Receipt_Deadline", this.BAL_Sheet_Receipt_Deadline);/*Optional 60*/
            dbIns.AddValue("SEC_EDS_Opens_Deadline", this.SEC_EDS_Opens_Deadline);/*Optional 61*/
            dbIns.AddValue("SEC_EDS_Closes_Deadline", this.SEC_EDS_Closes_Deadline);/*Optional 62*/
            dbIns.AddValue("MAX_Fees", this.MAX_Fees);/*Optional 63*/
            dbIns.AddValue("Publish_Important_Notice_Complete", this.Publish_Important_Notice_Complete);/*Optional 64*/
            dbIns.AddValue("Mail_RSH_Important_Notice_Complete", this.Mail_RSH_Important_Notice_Complete);/*Optional 65*/
            dbIns.AddValue("RSH_List_Receipt_Complete", this.RSH_List_Receipt_Complete);/*Optional 66*/
            dbIns.AddValue("BAL_Sheet_Receipt_Complete", this.BAL_Sheet_Receipt_Complete);/*Optional 67*/
            dbIns.AddValue("EDS_Receipt_Complete", this.EDS_Receipt_Complete);/*Optional 68*/
            dbIns.AddValue("StatuteOfLimitation", this.StatuteOfLimitation);/*Optional 69*/
            dbIns.AddValue("DBXML_ReferenceNumber", this.DBXML_ReferenceNumber);/*Optional 70*/
            dbIns.AddValue("ISO2CntryCode", this.ISO2CntryCode.Value);
            dbIns.AddValue("OverseasTaxCredit", this.OverseasTaxCredit);/*Optional 72*/
            dbIns.AddValue("XBRL_ReferenceNumber", this.XBRL_ReferenceNumber);/*Optional 73*/
            dbIns.AddValue("Round_ClaimShares_ADRs", this.Round_ClaimShares_ADRs.Value);
            dbIns.AddValue("Round_ClaimShares_ORDs", this.Round_ClaimShares_ORDs.Value);
            dbIns.AddValue("MinADRSimplifiedProcedure", this.MinADRSimplifiedProcedure.Value);
            dbIns.AddValue("FavAtSourceFee", this.FavAtSourceFee);/*Optional 77*/
            dbIns.AddValue("ExemptAtSourceFee", this.ExemptAtSourceFee);/*Optional 78*/
            dbIns.AddValue("FavTransparentEntityFee", this.FavTransparentEntityFee);/*Optional 79*/
            dbIns.AddValue("AssetType", this.AssetType);/*Optional 80*/
            dbIns.AddValue("ConsularizationFee", this.ConsularizationFee);/*Optional 81*/
            dbIns.AddValue("AltFinalDivGrossAmount_ORD", this.AltFinalDivGrossAmount_ORD.Value);
            dbIns.AddValue("MaturityDate", this.MaturityDate);/*Optional 83*/
            dbIns.AddValue("InterestRate", this.InterestRate);/*Optional 84*/
            dbIns.AddValue("DTCCImportantNoticeB", this.DTCCImportantNoticeB);/*Optional 85*/
            dbIns.AddValue("AddUSDisclosure", this.AddUSDisclosure);/*Optional 86*/
            dbIns.AddValue("Domesticated", this.Domesticated);/*Optional 87*/
            dbIns.AddValue("SecurityTypeID", this.SecurityTypeID.Value);
            dbIns.AddValue("ReversalIndicator", this.ReversalIndicator);/*Optional 89*/
            dbIns.AddValue("FaceAmount", this.FaceAmount);/*Optional 90*/
            dbIns.AddValue("PlaceOfSafekeeping", this.PlaceOfSafekeeping);/*Optional 91*/
            dbIns.AddValue("FirstFiler", this.FirstFiler);/*Optional 92*/
            dbIns.AddValue("ESPLogin", this.ESPLogin.Value);
            dbIns.AddValue("OriginalIssueDiscount", this.OriginalIssueDiscount);/*Optional 94*/
            dbIns.AddValue("LastInterestPayDate", this.LastInterestPayDate);/*Optional 95*/
            dbIns.AddValue("EventType", this.EventType);/*Optional 96*/
            dbIns.AddValue("BondType", this.BondType);/*Optional 97*/
            dbIns.AddValue("RecordDate_ADR_Missing", this.RecordDate_ADR_Missing);/*Optional 98*/
            dbIns.AddValue("AuditAvailable", this.AuditAvailable);/*Optional 99*/
            dbIns.AddValue("Issuer_ATTN", this.Issuer_ATTN);/*Optional 100*/
            dbIns.AddValue("Issuer_Address1", this.Issuer_Address1);/*Optional 101*/
            dbIns.AddValue("Issuer_Address2", this.Issuer_Address2);/*Optional 102*/
            dbIns.AddValue("SupplementalInterestPayment", this.SupplementalInterestPayment);/*Optional 103*/
            dbIns.AddValue("HidePayDate_ORD", this.HidePayDate_ORD);/*Optional 104*/
            dbIns.AddValue("QR1stBatch_Deadline", this.QR1stBatch_Deadline);/*Optional 105*/
            dbIns.AddValue("Coupon_Number", this.Coupon_Number);/*Optional 106*/
            dbIns.AddValue("LastModifiedBy", this.LastModifiedBy);/*Optional 107*/
            dbIns.AddValue("LastModifiedDateTime", this.LastModifiedDateTime);/*Optional 108*/
            dbIns.AddValue("Min_ReclaimValue_USD_QR", this.Min_ReclaimValue_USD_QR);/*Optional 109*/
            dbIns.AddValue("Min_ReclaimValue_USD_LF", this.Min_ReclaimValue_USD_LF);/*Optional 110*/
            dbIns.AddValue("Orange_Note", this.Orange_Note);/*Optional 111*/
            dbIns.AddValue("FirstFiling_Checked", this.FirstFiling_Checked);/*Optional 112*/
            dbIns.AddValue("FirstPayment_Checked", this.FirstPayment_Checked);/*Optional 113*/
            dbIns.AddValue("SuppressTasks_Checked", this.SuppressTasks_Checked);/*Optional 114*/
            dbIns.AddValue("CAWebCutoff_Deadline", this.CAWebCutoff_Deadline);/*Optional 115*/
            dbIns.AddValue("AGMDate", this.AGMDate);/*Optional 116*/
            dbIns.AddValue("GDR", this.GDR);/*Optional 117*/

            return dbIns;
        }

        public bool Update_to_DB(DividendTable_option table, bool autoSyncValue_flag)
        {
            this.LastModifiedDateTime.Value = DateTime.Now;

            HssUtility.SQLserver.DB_update upd = this.Get_DBupdate(table);
            if (upd == null) return false;

            int count = upd.SaveToDB(Utility.Get_DRWIN_hDB());
            bool flag = count > 0;
            if (flag && autoSyncValue_flag) this.SyncWithDB();

            return flag;
        }

        internal HssUtility.SQLserver.DB_update Get_DBupdate(DividendTable_option table)
        {
            if (!this.CheckValueChanges()) return null;

            HssUtility.SQLserver.DB_update upd = new HssUtility.SQLserver.DB_update(Dividend.Get_cmdTP());
            upd.tableName = table.ToString();

            if (this.DividendID.ValueChanged) upd.AddValue("DividendID", this.DividendID);
            if (this.IncomeEventID.ValueChanged) upd.AddValue("IncomeEventID", this.IncomeEventID);/*Optional 3*/
            if (this.Issue.ValueChanged) upd.AddValue("Issue", this.Issue);
            if (this.Depositary.ValueChanged) upd.AddValue("Depositary", this.Depositary);
            if (this.CUSIP.ValueChanged) upd.AddValue("CUSIP", this.CUSIP);
            if (this.Sponsored.ValueChanged) upd.AddValue("Sponsored", this.Sponsored);/*Optional 7*/
            if (this.RecordDate_ORD.ValueChanged) upd.AddValue("RecordDate_ORD", this.RecordDate_ORD);/*Optional 8*/
            if (this.RecordDate_ADR.ValueChanged) upd.AddValue("RecordDate_ADR", this.RecordDate_ADR);
            if (this.PayDate_ORD.ValueChanged) upd.AddValue("PayDate_ORD", this.PayDate_ORD);/*Optional 10*/
            if (this.PayDate_ADR.ValueChanged) upd.AddValue("PayDate_ADR", this.PayDate_ADR);/*Optional 11*/
            if (this.FinalDivGrossAmount_ORD.ValueChanged) upd.AddValue("FinalDivGrossAmount_ORD", this.FinalDivGrossAmount_ORD);/*Optional 12*/
            if (this.FinalDivGrossAmount_ADR.ValueChanged) upd.AddValue("FinalDivGrossAmount_ADR", this.FinalDivGrossAmount_ADR);/*Optional 13*/
            if (this.ApproxDivGrossAmount_ORD.ValueChanged) upd.AddValue("ApproxDivGrossAmount_ORD", this.ApproxDivGrossAmount_ORD);/*Optional 14*/
            if (this.ApproxDivGrossAmount_ADR.ValueChanged) upd.AddValue("ApproxDivGrossAmount_ADR", this.ApproxDivGrossAmount_ADR);/*Optional 15*/
            if (this.DivNetAmount_ORD.ValueChanged) upd.AddValue("DivNetAmount_ORD", this.DivNetAmount_ORD);/*Optional 16*/
            if (this.DivNetAmount_ADR.ValueChanged) upd.AddValue("DivNetAmount_ADR", this.DivNetAmount_ADR);/*Optional 17*/
            if (this.ApproximateFXRate.ValueChanged) upd.AddValue("ApproximateFXRate", this.ApproximateFXRate);/*Optional 18*/
            if (this.FinalFXRate.ValueChanged) upd.AddValue("FinalFXRate", this.FinalFXRate);/*Optional 19*/
            if (this.ADR_Ratio_ORD.ValueChanged) upd.AddValue("ADR_Ratio_ORD", this.ADR_Ratio_ORD);/*Optional 20*/
            if (this.ADR_Ratio_ADR.ValueChanged) upd.AddValue("ADR_Ratio_ADR", this.ADR_Ratio_ADR);/*Optional 21*/
            if (this.LongFormFee.ValueChanged) upd.AddValue("LongFormFee", this.LongFormFee);
            if (this.ShortFormFee.ValueChanged) upd.AddValue("ShortFormFee", this.ShortFormFee);
            if (this.AtSourceFee.ValueChanged) upd.AddValue("AtSourceFee", this.AtSourceFee);
            if (this.QuickRefundFee.ValueChanged) upd.AddValue("QuickRefundFee", this.QuickRefundFee);
            if (this.MinLongFormFee.ValueChanged) upd.AddValue("MinLongFormFee", this.MinLongFormFee);
            if (this.MinQuickRefundFee.ValueChanged) upd.AddValue("MinQuickRefundFee", this.MinQuickRefundFee);
            if (this.MinAtSource_Fee.ValueChanged) upd.AddValue("MinAtSource_Fee", this.MinAtSource_Fee);
            if (this.MinShortFormFee.ValueChanged) upd.AddValue("MinShortFormFee", this.MinShortFormFee);
            if (this.ExDate.ValueChanged) upd.AddValue("ExDate", this.ExDate);/*Optional 30*/
            if (this.SEDOL.ValueChanged) upd.AddValue("SEDOL", this.SEDOL);/*Optional 31*/
            if (this.ISIN.ValueChanged) upd.AddValue("ISIN", this.ISIN);/*Optional 32*/
            if (this.DepositaryAccountNumber.ValueChanged) upd.AddValue("DepositaryAccountNumber", this.DepositaryAccountNumber);/*Optional 33*/
            if (this.GermanySecurityNumber.ValueChanged) upd.AddValue("GermanySecurityNumber", this.GermanySecurityNumber);/*Optional 34*/
            if (this.CurrentMode.ValueChanged) upd.AddValue("CurrentMode", this.CurrentMode);/*Optional 35*/
            if (this.Country.ValueChanged) upd.AddValue("Country", this.Country);
            if (this.StatutoryRate.ValueChanged) upd.AddValue("StatutoryRate", this.StatutoryRate);/*Optional 37*/
            //if (this.Editor.ValueChanged) upd.AddValue("Editor", this.Editor);
            if (this.PaidCurrency.ValueChanged) upd.AddValue("PaidCurrency", this.PaidCurrency);/*Optional 39*/
            if (this.PaidCurrency_ORD.ValueChanged) upd.AddValue("PaidCurrency_ORD", this.PaidCurrency_ORD);/*Optional 40*/
            if (this.AtSource.ValueChanged) upd.AddValue("AtSource", this.AtSource);/*Optional 41*/
            if (this.QuickRefund.ValueChanged) upd.AddValue("QuickRefund", this.QuickRefund);/*Optional 42*/
            if (this.LongForm.ValueChanged) upd.AddValue("LongForm", this.LongForm);/*Optional 43*/
            if (this.Publish_Important_Notice_Deadline.ValueChanged) upd.AddValue("Publish_Important_Notice_Deadline", this.Publish_Important_Notice_Deadline);/*Optional 44*/
            if (this.Mail_RSH_Important_Notice_Deadline.ValueChanged) upd.AddValue("Mail_RSH_Important_Notice_Deadline", this.Mail_RSH_Important_Notice_Deadline);/*Optional 45*/
            if (this.EDS_Opens_Deadline.ValueChanged) upd.AddValue("EDS_Opens_Deadline", this.EDS_Opens_Deadline);/*Optional 46*/
            if (this.EDS_Closes_Deadline.ValueChanged) upd.AddValue("EDS_Closes_Deadline", this.EDS_Closes_Deadline);/*Optional 47*/
            if (this.Filing_Deadline.ValueChanged) upd.AddValue("Filing_Deadline", this.Filing_Deadline);/*Optional 48*/
            if (this.RSH_List_Receipt_Deadline.ValueChanged) upd.AddValue("RSH_List_Receipt_Deadline", this.RSH_List_Receipt_Deadline);/*Optional 49*/
            if (this.EDS_Receipt_Deadline.ValueChanged) upd.AddValue("EDS_Receipt_Deadline", this.EDS_Receipt_Deadline);/*Optional 50*/
            if (this.Custodial_LongForm_Claims_Deadline.ValueChanged) upd.AddValue("Custodial_LongForm_Claims_Deadline", this.Custodial_LongForm_Claims_Deadline);/*Optional 51*/
            if (this.At_Source_Deadline.ValueChanged) upd.AddValue("At_Source_Deadline", this.At_Source_Deadline);/*Optional 52*/
            if (this.Quick_Refund_Deadline.ValueChanged) upd.AddValue("Quick_Refund_Deadline", this.Quick_Refund_Deadline);/*Optional 53*/
            if (this.Cust_Statute_Limitations.ValueChanged) upd.AddValue("Cust_Statute_Limitations", this.Cust_Statute_Limitations);/*Optional 54*/
            if (this.Comments.ValueChanged) upd.AddValue("Comments", this.Comments);/*Optional 55*/
            if (this.Model_Number.ValueChanged) upd.AddValue("Model_Number", this.Model_Number);/*Optional 56*/
            if (this.DTCPosition_ModelNumber.ValueChanged) upd.AddValue("DTCPosition_ModelNumber", this.DTCPosition_ModelNumber);
            if (this.Status.ValueChanged) upd.AddValue("Status", this.Status);
            if (this.TickerSymbol.ValueChanged) upd.AddValue("TickerSymbol", this.TickerSymbol);/*Optional 59*/
            if (this.BAL_Sheet_Receipt_Deadline.ValueChanged) upd.AddValue("BAL_Sheet_Receipt_Deadline", this.BAL_Sheet_Receipt_Deadline);/*Optional 60*/
            if (this.SEC_EDS_Opens_Deadline.ValueChanged) upd.AddValue("SEC_EDS_Opens_Deadline", this.SEC_EDS_Opens_Deadline);/*Optional 61*/
            if (this.SEC_EDS_Closes_Deadline.ValueChanged) upd.AddValue("SEC_EDS_Closes_Deadline", this.SEC_EDS_Closes_Deadline);/*Optional 62*/
            if (this.MAX_Fees.ValueChanged) upd.AddValue("MAX_Fees", this.MAX_Fees);/*Optional 63*/
            if (this.Publish_Important_Notice_Complete.ValueChanged) upd.AddValue("Publish_Important_Notice_Complete", this.Publish_Important_Notice_Complete);/*Optional 64*/
            if (this.Mail_RSH_Important_Notice_Complete.ValueChanged) upd.AddValue("Mail_RSH_Important_Notice_Complete", this.Mail_RSH_Important_Notice_Complete);/*Optional 65*/
            if (this.RSH_List_Receipt_Complete.ValueChanged) upd.AddValue("RSH_List_Receipt_Complete", this.RSH_List_Receipt_Complete);/*Optional 66*/
            if (this.BAL_Sheet_Receipt_Complete.ValueChanged) upd.AddValue("BAL_Sheet_Receipt_Complete", this.BAL_Sheet_Receipt_Complete);/*Optional 67*/
            if (this.EDS_Receipt_Complete.ValueChanged) upd.AddValue("EDS_Receipt_Complete", this.EDS_Receipt_Complete);/*Optional 68*/
            if (this.StatuteOfLimitation.ValueChanged) upd.AddValue("StatuteOfLimitation", this.StatuteOfLimitation);/*Optional 69*/
            if (this.DBXML_ReferenceNumber.ValueChanged) upd.AddValue("DBXML_ReferenceNumber", this.DBXML_ReferenceNumber);/*Optional 70*/
            if (this.ISO2CntryCode.ValueChanged) upd.AddValue("ISO2CntryCode", this.ISO2CntryCode);
            if (this.OverseasTaxCredit.ValueChanged) upd.AddValue("OverseasTaxCredit", this.OverseasTaxCredit);/*Optional 72*/
            if (this.XBRL_ReferenceNumber.ValueChanged) upd.AddValue("XBRL_ReferenceNumber", this.XBRL_ReferenceNumber);/*Optional 73*/
            if (this.Round_ClaimShares_ADRs.ValueChanged) upd.AddValue("Round_ClaimShares_ADRs", this.Round_ClaimShares_ADRs);
            if (this.Round_ClaimShares_ORDs.ValueChanged) upd.AddValue("Round_ClaimShares_ORDs", this.Round_ClaimShares_ORDs);
            if (this.MinADRSimplifiedProcedure.ValueChanged) upd.AddValue("MinADRSimplifiedProcedure", this.MinADRSimplifiedProcedure);
            if (this.FavAtSourceFee.ValueChanged) upd.AddValue("FavAtSourceFee", this.FavAtSourceFee);/*Optional 77*/
            if (this.ExemptAtSourceFee.ValueChanged) upd.AddValue("ExemptAtSourceFee", this.ExemptAtSourceFee);/*Optional 78*/
            if (this.FavTransparentEntityFee.ValueChanged) upd.AddValue("FavTransparentEntityFee", this.FavTransparentEntityFee);/*Optional 79*/
            if (this.AssetType.ValueChanged) upd.AddValue("AssetType", this.AssetType);/*Optional 80*/
            if (this.ConsularizationFee.ValueChanged) upd.AddValue("ConsularizationFee", this.ConsularizationFee);/*Optional 81*/
            if (this.AltFinalDivGrossAmount_ORD.ValueChanged) upd.AddValue("AltFinalDivGrossAmount_ORD", this.AltFinalDivGrossAmount_ORD);
            if (this.MaturityDate.ValueChanged) upd.AddValue("MaturityDate", this.MaturityDate);/*Optional 83*/
            if (this.InterestRate.ValueChanged) upd.AddValue("InterestRate", this.InterestRate);/*Optional 84*/
            if (this.DTCCImportantNoticeB.ValueChanged) upd.AddValue("DTCCImportantNoticeB", this.DTCCImportantNoticeB);/*Optional 85*/
            if (this.AddUSDisclosure.ValueChanged) upd.AddValue("AddUSDisclosure", this.AddUSDisclosure);/*Optional 86*/
            if (this.Domesticated.ValueChanged) upd.AddValue("Domesticated", this.Domesticated);/*Optional 87*/
            if (this.SecurityTypeID.ValueChanged) upd.AddValue("SecurityTypeID", this.SecurityTypeID);
            if (this.ReversalIndicator.ValueChanged) upd.AddValue("ReversalIndicator", this.ReversalIndicator);/*Optional 89*/
            if (this.FaceAmount.ValueChanged) upd.AddValue("FaceAmount", this.FaceAmount);/*Optional 90*/
            if (this.PlaceOfSafekeeping.ValueChanged) upd.AddValue("PlaceOfSafekeeping", this.PlaceOfSafekeeping);/*Optional 91*/
            if (this.FirstFiler.ValueChanged) upd.AddValue("FirstFiler", this.FirstFiler);/*Optional 92*/
            if (this.ESPLogin.ValueChanged) upd.AddValue("ESPLogin", this.ESPLogin);
            if (this.OriginalIssueDiscount.ValueChanged) upd.AddValue("OriginalIssueDiscount", this.OriginalIssueDiscount);/*Optional 94*/
            if (this.LastInterestPayDate.ValueChanged) upd.AddValue("LastInterestPayDate", this.LastInterestPayDate);/*Optional 95*/
            if (this.EventType.ValueChanged) upd.AddValue("EventType", this.EventType);/*Optional 96*/
            if (this.BondType.ValueChanged) upd.AddValue("BondType", this.BondType);/*Optional 97*/
            if (this.RecordDate_ADR_Missing.ValueChanged) upd.AddValue("RecordDate_ADR_Missing", this.RecordDate_ADR_Missing);/*Optional 98*/
            if (this.AuditAvailable.ValueChanged) upd.AddValue("AuditAvailable", this.AuditAvailable);/*Optional 99*/
            if (this.Issuer_ATTN.ValueChanged) upd.AddValue("Issuer_ATTN", this.Issuer_ATTN);/*Optional 100*/
            if (this.Issuer_Address1.ValueChanged) upd.AddValue("Issuer_Address1", this.Issuer_Address1);/*Optional 101*/
            if (this.Issuer_Address2.ValueChanged) upd.AddValue("Issuer_Address2", this.Issuer_Address2);/*Optional 102*/
            if (this.SupplementalInterestPayment.ValueChanged) upd.AddValue("SupplementalInterestPayment", this.SupplementalInterestPayment);/*Optional 103*/
            if (this.HidePayDate_ORD.ValueChanged) upd.AddValue("HidePayDate_ORD", this.HidePayDate_ORD);/*Optional 104*/
            if (this.QR1stBatch_Deadline.ValueChanged) upd.AddValue("QR1stBatch_Deadline", this.QR1stBatch_Deadline);/*Optional 105*/
            if (this.Coupon_Number.ValueChanged) upd.AddValue("Coupon_Number", this.Coupon_Number);/*Optional 106*/
            if (this.LastModifiedBy.ValueChanged) upd.AddValue("LastModifiedBy", this.LastModifiedBy);/*Optional 107*/
            if (this.LastModifiedDateTime.ValueChanged) upd.AddValue("LastModifiedDateTime", this.LastModifiedDateTime);/*Optional 108*/
            if (this.Min_ReclaimValue_USD_QR.ValueChanged) upd.AddValue("Min_ReclaimValue_USD_QR", this.Min_ReclaimValue_USD_QR);/*Optional 109*/
            if (this.Min_ReclaimValue_USD_LF.ValueChanged) upd.AddValue("Min_ReclaimValue_USD_LF", this.Min_ReclaimValue_USD_LF);/*Optional 110*/
            if (this.Orange_Note.ValueChanged) upd.AddValue("Orange_Note", this.Orange_Note);/*Optional 111*/
            if (this.FirstFiling_Checked.ValueChanged) upd.AddValue("FirstFiling_Checked", this.FirstFiling_Checked);/*Optional 112*/
            if (this.FirstPayment_Checked.ValueChanged) upd.AddValue("FirstPayment_Checked", this.FirstPayment_Checked);/*Optional 113*/
            if (this.SuppressTasks_Checked.ValueChanged) upd.AddValue("SuppressTasks_Checked", this.SuppressTasks_Checked);/*Optional 114*/
            if (this.CAWebCutoff_Deadline.ValueChanged) upd.AddValue("CAWebCutoff_Deadline", this.CAWebCutoff_Deadline);/*Optional 115*/
            if (this.AGMDate.ValueChanged) upd.AddValue("AGMDate", this.AGMDate);/*Optional 116*/
            if (this.GDR.ValueChanged) upd.AddValue("GDR", this.GDR);/*Optional 117*/

            HssUtility.SQLserver.SQL_relation rela = new HssUtility.SQLserver.SQL_relation("DividendIndex", HssUtility.General.RelationalOperator.Equals, this.pk_ID);
            upd.SetCondition(rela);

            return upd;
        }

        public Dividend GetCopy()
        {
            Dividend newEntity = new Dividend();
            if (!this.DividendID.IsNull_flag) newEntity.DividendID.Value = this.DividendID.Value;
            if (!this.IncomeEventID.IsNull_flag) newEntity.IncomeEventID.Value = this.IncomeEventID.Value;
            if (!this.Issue.IsNull_flag) newEntity.Issue.Value = this.Issue.Value;
            if (!this.Depositary.IsNull_flag) newEntity.Depositary.Value = this.Depositary.Value;
            if (!this.CUSIP.IsNull_flag) newEntity.CUSIP.Value = this.CUSIP.Value;
            if (!this.Sponsored.IsNull_flag) newEntity.Sponsored.Value = this.Sponsored.Value;
            if (!this.RecordDate_ORD.IsNull_flag) newEntity.RecordDate_ORD.Value = this.RecordDate_ORD.Value;
            if (!this.RecordDate_ADR.IsNull_flag) newEntity.RecordDate_ADR.Value = this.RecordDate_ADR.Value;
            if (!this.PayDate_ORD.IsNull_flag) newEntity.PayDate_ORD.Value = this.PayDate_ORD.Value;
            if (!this.PayDate_ADR.IsNull_flag) newEntity.PayDate_ADR.Value = this.PayDate_ADR.Value;
            if (!this.FinalDivGrossAmount_ORD.IsNull_flag) newEntity.FinalDivGrossAmount_ORD.Value = this.FinalDivGrossAmount_ORD.Value;
            if (!this.FinalDivGrossAmount_ADR.IsNull_flag) newEntity.FinalDivGrossAmount_ADR.Value = this.FinalDivGrossAmount_ADR.Value;
            if (!this.ApproxDivGrossAmount_ORD.IsNull_flag) newEntity.ApproxDivGrossAmount_ORD.Value = this.ApproxDivGrossAmount_ORD.Value;
            if (!this.ApproxDivGrossAmount_ADR.IsNull_flag) newEntity.ApproxDivGrossAmount_ADR.Value = this.ApproxDivGrossAmount_ADR.Value;
            if (!this.DivNetAmount_ORD.IsNull_flag) newEntity.DivNetAmount_ORD.Value = this.DivNetAmount_ORD.Value;
            if (!this.DivNetAmount_ADR.IsNull_flag) newEntity.DivNetAmount_ADR.Value = this.DivNetAmount_ADR.Value;
            if (!this.ApproximateFXRate.IsNull_flag) newEntity.ApproximateFXRate.Value = this.ApproximateFXRate.Value;
            if (!this.FinalFXRate.IsNull_flag) newEntity.FinalFXRate.Value = this.FinalFXRate.Value;
            if (!this.ADR_Ratio_ORD.IsNull_flag) newEntity.ADR_Ratio_ORD.Value = this.ADR_Ratio_ORD.Value;
            if (!this.ADR_Ratio_ADR.IsNull_flag) newEntity.ADR_Ratio_ADR.Value = this.ADR_Ratio_ADR.Value;
            if (!this.LongFormFee.IsNull_flag) newEntity.LongFormFee.Value = this.LongFormFee.Value;
            if (!this.ShortFormFee.IsNull_flag) newEntity.ShortFormFee.Value = this.ShortFormFee.Value;
            if (!this.AtSourceFee.IsNull_flag) newEntity.AtSourceFee.Value = this.AtSourceFee.Value;
            if (!this.QuickRefundFee.IsNull_flag) newEntity.QuickRefundFee.Value = this.QuickRefundFee.Value;
            if (!this.MinLongFormFee.IsNull_flag) newEntity.MinLongFormFee.Value = this.MinLongFormFee.Value;
            if (!this.MinQuickRefundFee.IsNull_flag) newEntity.MinQuickRefundFee.Value = this.MinQuickRefundFee.Value;
            if (!this.MinAtSource_Fee.IsNull_flag) newEntity.MinAtSource_Fee.Value = this.MinAtSource_Fee.Value;
            if (!this.MinShortFormFee.IsNull_flag) newEntity.MinShortFormFee.Value = this.MinShortFormFee.Value;
            if (!this.ExDate.IsNull_flag) newEntity.ExDate.Value = this.ExDate.Value;
            if (!this.SEDOL.IsNull_flag) newEntity.SEDOL.Value = this.SEDOL.Value;
            if (!this.ISIN.IsNull_flag) newEntity.ISIN.Value = this.ISIN.Value;
            if (!this.DepositaryAccountNumber.IsNull_flag) newEntity.DepositaryAccountNumber.Value = this.DepositaryAccountNumber.Value;
            if (!this.GermanySecurityNumber.IsNull_flag) newEntity.GermanySecurityNumber.Value = this.GermanySecurityNumber.Value;
            if (!this.CurrentMode.IsNull_flag) newEntity.CurrentMode.Value = this.CurrentMode.Value;
            if (!this.Country.IsNull_flag) newEntity.Country.Value = this.Country.Value;
            if (!this.StatutoryRate.IsNull_flag) newEntity.StatutoryRate.Value = this.StatutoryRate.Value;
            //if (!this.Editor.IsNull_flag) newEntity.Editor.Value = this.Editor.Value;
            if (!this.PaidCurrency.IsNull_flag) newEntity.PaidCurrency.Value = this.PaidCurrency.Value;
            if (!this.PaidCurrency_ORD.IsNull_flag) newEntity.PaidCurrency_ORD.Value = this.PaidCurrency_ORD.Value;
            if (!this.AtSource.IsNull_flag) newEntity.AtSource.Value = this.AtSource.Value;
            if (!this.QuickRefund.IsNull_flag) newEntity.QuickRefund.Value = this.QuickRefund.Value;
            if (!this.LongForm.IsNull_flag) newEntity.LongForm.Value = this.LongForm.Value;
            if (!this.Publish_Important_Notice_Deadline.IsNull_flag) newEntity.Publish_Important_Notice_Deadline.Value = this.Publish_Important_Notice_Deadline.Value;
            if (!this.Mail_RSH_Important_Notice_Deadline.IsNull_flag) newEntity.Mail_RSH_Important_Notice_Deadline.Value = this.Mail_RSH_Important_Notice_Deadline.Value;
            if (!this.EDS_Opens_Deadline.IsNull_flag) newEntity.EDS_Opens_Deadline.Value = this.EDS_Opens_Deadline.Value;
            if (!this.EDS_Closes_Deadline.IsNull_flag) newEntity.EDS_Closes_Deadline.Value = this.EDS_Closes_Deadline.Value;
            if (!this.Filing_Deadline.IsNull_flag) newEntity.Filing_Deadline.Value = this.Filing_Deadline.Value;
            if (!this.RSH_List_Receipt_Deadline.IsNull_flag) newEntity.RSH_List_Receipt_Deadline.Value = this.RSH_List_Receipt_Deadline.Value;
            if (!this.EDS_Receipt_Deadline.IsNull_flag) newEntity.EDS_Receipt_Deadline.Value = this.EDS_Receipt_Deadline.Value;
            if (!this.Custodial_LongForm_Claims_Deadline.IsNull_flag) newEntity.Custodial_LongForm_Claims_Deadline.Value = this.Custodial_LongForm_Claims_Deadline.Value;
            if (!this.At_Source_Deadline.IsNull_flag) newEntity.At_Source_Deadline.Value = this.At_Source_Deadline.Value;
            if (!this.Quick_Refund_Deadline.IsNull_flag) newEntity.Quick_Refund_Deadline.Value = this.Quick_Refund_Deadline.Value;
            if (!this.Cust_Statute_Limitations.IsNull_flag) newEntity.Cust_Statute_Limitations.Value = this.Cust_Statute_Limitations.Value;
            if (!this.Comments.IsNull_flag) newEntity.Comments.Value = this.Comments.Value;
            if (!this.Model_Number.IsNull_flag) newEntity.Model_Number.Value = this.Model_Number.Value;
            if (!this.DTCPosition_ModelNumber.IsNull_flag) newEntity.DTCPosition_ModelNumber.Value = this.DTCPosition_ModelNumber.Value;
            if (!this.Status.IsNull_flag) newEntity.Status.Value = this.Status.Value;
            if (!this.TickerSymbol.IsNull_flag) newEntity.TickerSymbol.Value = this.TickerSymbol.Value;
            if (!this.BAL_Sheet_Receipt_Deadline.IsNull_flag) newEntity.BAL_Sheet_Receipt_Deadline.Value = this.BAL_Sheet_Receipt_Deadline.Value;
            if (!this.SEC_EDS_Opens_Deadline.IsNull_flag) newEntity.SEC_EDS_Opens_Deadline.Value = this.SEC_EDS_Opens_Deadline.Value;
            if (!this.SEC_EDS_Closes_Deadline.IsNull_flag) newEntity.SEC_EDS_Closes_Deadline.Value = this.SEC_EDS_Closes_Deadline.Value;
            if (!this.MAX_Fees.IsNull_flag) newEntity.MAX_Fees.Value = this.MAX_Fees.Value;
            if (!this.Publish_Important_Notice_Complete.IsNull_flag) newEntity.Publish_Important_Notice_Complete.Value = this.Publish_Important_Notice_Complete.Value;
            if (!this.Mail_RSH_Important_Notice_Complete.IsNull_flag) newEntity.Mail_RSH_Important_Notice_Complete.Value = this.Mail_RSH_Important_Notice_Complete.Value;
            if (!this.RSH_List_Receipt_Complete.IsNull_flag) newEntity.RSH_List_Receipt_Complete.Value = this.RSH_List_Receipt_Complete.Value;
            if (!this.BAL_Sheet_Receipt_Complete.IsNull_flag) newEntity.BAL_Sheet_Receipt_Complete.Value = this.BAL_Sheet_Receipt_Complete.Value;
            if (!this.EDS_Receipt_Complete.IsNull_flag) newEntity.EDS_Receipt_Complete.Value = this.EDS_Receipt_Complete.Value;
            if (!this.StatuteOfLimitation.IsNull_flag) newEntity.StatuteOfLimitation.Value = this.StatuteOfLimitation.Value;
            if (!this.DBXML_ReferenceNumber.IsNull_flag) newEntity.DBXML_ReferenceNumber.Value = this.DBXML_ReferenceNumber.Value;
            if (!this.ISO2CntryCode.IsNull_flag) newEntity.ISO2CntryCode.Value = this.ISO2CntryCode.Value;
            if (!this.OverseasTaxCredit.IsNull_flag) newEntity.OverseasTaxCredit.Value = this.OverseasTaxCredit.Value;
            if (!this.XBRL_ReferenceNumber.IsNull_flag) newEntity.XBRL_ReferenceNumber.Value = this.XBRL_ReferenceNumber.Value;
            if (!this.Round_ClaimShares_ADRs.IsNull_flag) newEntity.Round_ClaimShares_ADRs.Value = this.Round_ClaimShares_ADRs.Value;
            if (!this.Round_ClaimShares_ORDs.IsNull_flag) newEntity.Round_ClaimShares_ORDs.Value = this.Round_ClaimShares_ORDs.Value;
            if (!this.MinADRSimplifiedProcedure.IsNull_flag) newEntity.MinADRSimplifiedProcedure.Value = this.MinADRSimplifiedProcedure.Value;
            if (!this.FavAtSourceFee.IsNull_flag) newEntity.FavAtSourceFee.Value = this.FavAtSourceFee.Value;
            if (!this.ExemptAtSourceFee.IsNull_flag) newEntity.ExemptAtSourceFee.Value = this.ExemptAtSourceFee.Value;
            if (!this.FavTransparentEntityFee.IsNull_flag) newEntity.FavTransparentEntityFee.Value = this.FavTransparentEntityFee.Value;
            if (!this.AssetType.IsNull_flag) newEntity.AssetType.Value = this.AssetType.Value;
            if (!this.ConsularizationFee.IsNull_flag) newEntity.ConsularizationFee.Value = this.ConsularizationFee.Value;
            if (!this.AltFinalDivGrossAmount_ORD.IsNull_flag) newEntity.AltFinalDivGrossAmount_ORD.Value = this.AltFinalDivGrossAmount_ORD.Value;
            if (!this.MaturityDate.IsNull_flag) newEntity.MaturityDate.Value = this.MaturityDate.Value;
            if (!this.InterestRate.IsNull_flag) newEntity.InterestRate.Value = this.InterestRate.Value;
            if (!this.DTCCImportantNoticeB.IsNull_flag) newEntity.DTCCImportantNoticeB.Value = this.DTCCImportantNoticeB.Value;
            if (!this.AddUSDisclosure.IsNull_flag) newEntity.AddUSDisclosure.Value = this.AddUSDisclosure.Value;
            if (!this.Domesticated.IsNull_flag) newEntity.Domesticated.Value = this.Domesticated.Value;
            if (!this.SecurityTypeID.IsNull_flag) newEntity.SecurityTypeID.Value = this.SecurityTypeID.Value;
            if (!this.ReversalIndicator.IsNull_flag) newEntity.ReversalIndicator.Value = this.ReversalIndicator.Value;
            if (!this.FaceAmount.IsNull_flag) newEntity.FaceAmount.Value = this.FaceAmount.Value;
            if (!this.PlaceOfSafekeeping.IsNull_flag) newEntity.PlaceOfSafekeeping.Value = this.PlaceOfSafekeeping.Value;
            if (!this.FirstFiler.IsNull_flag) newEntity.FirstFiler.Value = this.FirstFiler.Value;
            if (!this.ESPLogin.IsNull_flag) newEntity.ESPLogin.Value = this.ESPLogin.Value;
            if (!this.OriginalIssueDiscount.IsNull_flag) newEntity.OriginalIssueDiscount.Value = this.OriginalIssueDiscount.Value;
            if (!this.LastInterestPayDate.IsNull_flag) newEntity.LastInterestPayDate.Value = this.LastInterestPayDate.Value;
            if (!this.EventType.IsNull_flag) newEntity.EventType.Value = this.EventType.Value;
            if (!this.BondType.IsNull_flag) newEntity.BondType.Value = this.BondType.Value;
            if (!this.RecordDate_ADR_Missing.IsNull_flag) newEntity.RecordDate_ADR_Missing.Value = this.RecordDate_ADR_Missing.Value;
            if (!this.AuditAvailable.IsNull_flag) newEntity.AuditAvailable.Value = this.AuditAvailable.Value;
            if (!this.Issuer_ATTN.IsNull_flag) newEntity.Issuer_ATTN.Value = this.Issuer_ATTN.Value;
            if (!this.Issuer_Address1.IsNull_flag) newEntity.Issuer_Address1.Value = this.Issuer_Address1.Value;
            if (!this.Issuer_Address2.IsNull_flag) newEntity.Issuer_Address2.Value = this.Issuer_Address2.Value;
            if (!this.SupplementalInterestPayment.IsNull_flag) newEntity.SupplementalInterestPayment.Value = this.SupplementalInterestPayment.Value;
            if (!this.HidePayDate_ORD.IsNull_flag) newEntity.HidePayDate_ORD.Value = this.HidePayDate_ORD.Value;
            if (!this.QR1stBatch_Deadline.IsNull_flag) newEntity.QR1stBatch_Deadline.Value = this.QR1stBatch_Deadline.Value;
            if (!this.Coupon_Number.IsNull_flag) newEntity.Coupon_Number.Value = this.Coupon_Number.Value;
            if (!this.LastModifiedBy.IsNull_flag) newEntity.LastModifiedBy.Value = this.LastModifiedBy.Value;
            if (!this.LastModifiedDateTime.IsNull_flag) newEntity.LastModifiedDateTime.Value = this.LastModifiedDateTime.Value;
            if (!this.Min_ReclaimValue_USD_QR.IsNull_flag) newEntity.Min_ReclaimValue_USD_QR.Value = this.Min_ReclaimValue_USD_QR.Value;
            if (!this.Min_ReclaimValue_USD_LF.IsNull_flag) newEntity.Min_ReclaimValue_USD_LF.Value = this.Min_ReclaimValue_USD_LF.Value;
            if (!this.Orange_Note.IsNull_flag) newEntity.Orange_Note.Value = this.Orange_Note.Value;
            if (!this.FirstFiling_Checked.IsNull_flag) newEntity.FirstFiling_Checked.Value = this.FirstFiling_Checked.Value;
            if (!this.FirstPayment_Checked.IsNull_flag) newEntity.FirstPayment_Checked.Value = this.FirstPayment_Checked.Value;
            if (!this.SuppressTasks_Checked.IsNull_flag) newEntity.SuppressTasks_Checked.Value = this.SuppressTasks_Checked.Value;
            if (!this.CAWebCutoff_Deadline.IsNull_flag) newEntity.CAWebCutoff_Deadline.Value = this.CAWebCutoff_Deadline.Value;
            if (!this.AGMDate.IsNull_flag) newEntity.AGMDate.Value = this.AGMDate.Value;
            if (!this.GDR.IsNull_flag) newEntity.GDR.Value = this.GDR.Value;
            return newEntity;
        }

        public string ToXML()
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
            sb.Append("<PaidCurrency>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.PaidCurrency.Value)).Append("</PaidCurrency>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<PaidCurrency_ORD>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.PaidCurrency_ORD.Value)).Append("</PaidCurrency_ORD>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<AtSource>").Append(this.AtSource.Value).Append("</AtSource>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<QuickRefund>").Append(this.QuickRefund.Value).Append("</QuickRefund>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<LongForm>").Append(this.LongForm.Value).Append("</LongForm>").Append(HssUtility.General.HssStr.WinNextLine);
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
            sb.Append("<AGMDate>").Append(this.AGMDate.Value).Append("</AGMDate>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<GDR>").Append(this.GDR.Value).Append("</GDR>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("</Dividend>").Append(HssUtility.General.HssStr.WinNextLine);
            return sb.ToString();
        }
        /*^^^^^^^^^^^^^^^^^^^^^^^^^^^^^Hss Entity Framework Auto Generated Code^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^*/

        public void PrintAllAttributeValues()
        {
            this.Create_attrDic();

            foreach (KeyValuePair<string, HssUtility.General.Attributes.I_modelAttr> pair in this.attr_dic)
            {
                Console.WriteLine(pair.Key + ": " + pair.Value.GetValue_in_string(0));
            }
        }
    }
}
