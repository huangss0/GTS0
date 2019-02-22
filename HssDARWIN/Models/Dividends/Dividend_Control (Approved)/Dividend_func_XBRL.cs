using System;

using HssDARWIN.Models.XBRL.Event;
using HssDARWIN.Models.Securities;
using HssDARWIN.Models.EDI_synonyms;
using HssDARWIN.Models.Countries;
using HssDARWIN.Models.Fees;

namespace HssDARWIN.Models.Dividends
{
    public partial class Dividend
    {
        public void Init_from_XBRL(XBRL_event_info xei, Security sec)
        {
            if (xei == null || sec == null) return;

            this.XBRL_from_Security(sec);

            if (this.ISO2CntryCode.IsValueEmpty) this.ISO2CntryCode.Value = xei.ISO2CntryCode;
            if(!string.IsNullOrEmpty(xei.EventCompleteness)) this.PlaceOfSafekeeping.Value = xei.EventCompleteness;

            if (xei.PayDate_ADR > Utility.MinDate) this.PayDate_ADR.Value = xei.PayDate_ADR;
            if (xei.ExDate > Utility.MinDate) this.ExDate.Value = xei.ExDate;
            if (xei.PayDate_ORD > Utility.MinDate) this.PayDate_ORD.Value = xei.PayDate_ORD;
            if (xei.RecordDate_ADR > Utility.MinDate) this.RecordDate_ADR.Value = xei.RecordDate_ADR;
            if (xei.RecordDate_ORD > Utility.MinDate) this.RecordDate_ORD.Value = xei.RecordDate_ORD;

            if (xei.FXrate_US_to_foreign > 0)
            {
                if (xei.IsCompleteEvent_flag) this.FinalFXRate.Value = xei.FXrate_US_to_foreign;
                else this.ApproximateFXRate.Value = xei.FXrate_US_to_foreign;
            }            

            if (xei.IsCompleteEvent_flag) this.FinalDivGrossAmount_ORD.Value = xei.DivGrossAmount_ORD;
            else this.ApproxDivGrossAmount_ORD.Value = xei.DivGrossAmount_ORD;

            if (!string.IsNullOrEmpty(xei.PaidCurrency_ORD)) this.PaidCurrency_ORD.Value = xei.PaidCurrency_ORD;
            this.PaidCurrency.Value = "USD";
            this.EventType.Value = xei.EventType;

            this.XBRL_StatuteOfLimitation(xei.RecordDate_ADR);
            this.XBRL_StatRate_DTCposModel(xei);
            this.XBRL_CtyProType();
            this.XBRL_fees_DSC();
        }

        private void XBRL_StatuteOfLimitation(DateTime ADR_recDate)
        {
            if (ADR_recDate <= Utility.MinDate) return;

            EDI_times et = EDItime_master.GetRate_from_country(this.ISO2CntryCode.Value, DateTime.Now);
            if (et != null)
            {
                if (et.eoy.Value) this.StatuteOfLimitation.Value = new DateTime(ADR_recDate.Year, 12, 31).AddMonths(et.timebar.Value);
                else this.StatuteOfLimitation.Value = ADR_recDate.AddMonths(et.timebar.Value);
            }
        }

        /// <summary>
        /// Extract information from [Security]
        /// </summary>
        private void XBRL_from_Security(Security sec)
        {
            if (sec == null) return;

            this.Issue.Value = sec.Name.Value;
            this.CUSIP.Value = sec.CUSIP.Value;
            this.ISIN.Value = sec.ISIN.Value;
            this.TickerSymbol.Value = sec.TickerSymbol.Value;
            this.SEDOL.Value = sec.Sedol.Value;

            this.Country.Value = sec.Country.Value;
            Country cty = CountryMaster.GetCountry_name(sec.Country.Value);
            if (cty != null) this.ISO2CntryCode.Value = cty.cntry_cd.Value;

            this.Depositary.Value = sec.Depositary.Value;
            this.Sponsored.Value = !sec.Depositary.Value.Equals(Depositaries.Depositary.Unsponsored, StringComparison.OrdinalIgnoreCase);
            this.FirstFiler.Value = sec.FirstFiler.Value;

            this.ADR_Ratio_ADR.Value = sec.ADR_RATIO_ADR.Value;
            this.ADR_Ratio_ORD.Value = sec.ADR_RATIO_ORD.Value;
        }

        /// <summary>
        /// Deal with StatutoryRate and DTC Position Model number
        /// </summary>
        private void XBRL_StatRate_DTCposModel(XBRL_event_info xei)
        {
            //Get Statutory Rate
            StatutoryRate_edi rt = RateMaster_edi.GetRate_from_country(this.ISO2CntryCode.Value, this.RecordDate_ADR.Value);
            if (rt != null) this.StatutoryRate.Value = rt.statry_rt.Value;

            //Get DTC position model number
            DTC_Model.DTCPositionModelNumber_Mapping dm = 
                DTC_Model.DTC_model_master.GetMapping_country(this.Country.Value, this.Issue.Value, this.RecordDate_ADR.Value, this.SecurityTypeID.Value);
            if (dm != null) this.DTCPosition_ModelNumber.Value = dm.ModelNumber.Value;

            //Get amounts based on Statutary Rate
            if (xei!= null && xei.fee_list.Count > 0)
            {
                FeeInfo WHrate_fi = xei.fee_list[0];
                foreach (FeeInfo fi in xei.fee_list)
                {
                    if (fi.WithholdingTaxPercentage == this.StatutoryRate.Value)
                    {
                        WHrate_fi = fi;
                        break;
                    }
                }

                this.DivNetAmount_ADR.Value = WHrate_fi.PayoutAmountNetOfTax;

                if (xei.IsCompleteEvent_flag) this.FinalDivGrossAmount_ADR.Value = WHrate_fi.PayoutAmount;
                else this.ApproxDivGrossAmount_ADR.Value = WHrate_fi.PayoutAmount;
            }
        }

        /// <summary>
        /// Deal with Country_ProcedureTypes
        /// </summary>
        private void XBRL_CtyProType()
        {
            Country_ProcedureTypes cpt = ProcedureTypeMaster.GetCPT_country(this.Country.Value, this.Sponsored.Value);
            if (cpt != null)
            {
                this.AtSource.Value = cpt.At_Source.Value;
                this.QuickRefund.Value = cpt.Quick_Refund.Value;
                this.LongForm.Value = cpt.Long_Form.Value;
            }
        }

        /// <summary>
        /// Deal with fees
        /// </summary>
        private void XBRL_fees_DSC()
        {
            Schedule_Of_Fees_DSC sf = DSC_master.GetDSC_from_CDS(this.Country.Value, this.Depositary.Value, this.RecordDate_ADR.Value, this.SecurityTypeID.Value);
            if (sf != null)
            {
                if (!sf.LongFormFees.IsNull_flag) this.LongFormFee.Value = sf.LongFormFees.Value;
                if (!sf.ShortFormFees.IsNull_flag)
                {
                    this.ShortFormFee.Value = sf.ShortFormFees.Value;
                    this.QuickRefundFee.Value = sf.ShortFormFees.Value;//May need more thoughts
                }
                this.AtSourceFee.Value = 0;//Just give it a value for now

                if (!sf.MinLongFormFee.IsNull_flag) this.MinLongFormFee.Value = sf.MinLongFormFee.Value;
                if (!sf.MinQuickRefundFee.IsNull_flag) this.MinQuickRefundFee.Value = sf.MinQuickRefundFee.Value;
                if (!sf.MinAtSourceFee.IsNull_flag) this.MinAtSource_Fee.Value = sf.MinAtSourceFee.Value;
                if (!sf.MinShortFormFee.IsNull_flag) this.MinShortFormFee.Value = sf.MinShortFormFee.Value;

                if (!sf.FavAtSourceFee.IsNull_flag) this.FavAtSourceFee.Value = sf.FavAtSourceFee.Value;
                if (!sf.ExemptAtSourceFee.IsNull_flag) this.ExemptAtSourceFee.Value = sf.ExemptAtSourceFee.Value;
                if (!sf.FavTransparentEntityFee.IsNull_flag) this.FavTransparentEntityFee.Value = sf.FavTransparentEntityFee.Value;
            }
        }
    }
}
