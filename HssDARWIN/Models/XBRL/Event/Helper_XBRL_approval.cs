using System;
using System.Collections.Generic;
using System.Windows.Forms;

using HssUtility.SQLserver;

using HssDARWIN.Models.Dividends;
using HssDARWIN.Models.DTC_Position;
using HssDARWIN.Models.Tasks.Task21;
using HssDARWIN.Models.XBRL.DvdXBRL;
using HssDARWIN.Models.Securities;
using HssDARWIN.Models.Depositaries;
using HssDARWIN.Models.Fees;

namespace HssDARWIN.Models.XBRL.Event
{
    public class Helper_XBRL_approval
    {
        public static Dividend ApproveXBRL(int xbrl_id)
        {
            XBRL_SavedFile xsf = Helper_XBRL_approval.ApproveXBRL0_get_xsFile(xbrl_id);
            XBRL_event_info xei = new XBRL_event_info(xsf.XBRLobj);

            Security sec = SecurityMaster.XBRL_Create_or_Get_Security(xei, true);
            if (sec == null)
            {
                MessageBox.Show("Helper_XBRL error 0: no Security info in either XBRL or Security Master");
                return null;
            }

            Dividend existing_dvd = Helper_XBRL_approval.ApproveXBRL0_find_existingDividend(xei);
            if (xei.IsCancellation_flag) return Helper_XBRL_approval.ApproveXBRL1_cancellation_XBRL(existing_dvd, xsf);

            Action next_step = XBRL_event_matrix.ApproveXBRL_action(xei, existing_dvd);

            Dividend approved_dvd = null;
            if (next_step == Action.Create_New_Event)
            {
                approved_dvd = Helper_XBRL_approval.ApproveXBRL2_CreateNewDividend(xei, sec);
                Helper_XBRL_approval.ApproveXBRL4_InsertDvdXBRL(xei, approved_dvd);

                if (approved_dvd != null)
                {
                    if (existing_dvd == null) MessageBox.Show("New Dividend " + approved_dvd.DividendIndex + " created");
                    else MessageBox.Show("Another Dividend " + approved_dvd.DividendIndex + " created with existing Dividend " + existing_dvd.DividendIndex);
                }
            }
            else if (next_step == Action.Update_Existing_event)
            {
                approved_dvd = Helper_XBRL_approval.ApproveXBRL2_UpdateDividend(xei, existing_dvd, sec);
                Helper_XBRL_approval.ApproveXBRL4_InsertDvdXBRL(xei, approved_dvd);

                if (approved_dvd != null) MessageBox.Show("Existing Dividend " + approved_dvd.DividendIndex + " is updated");
            }
            else if (next_step == Action.Add_Ref_to_Current)
            {
                approved_dvd = Helper_XBRL_approval.ApproveXBRL4_InsertDvdXBRL(xei, existing_dvd);

                if (approved_dvd != null) MessageBox.Show("XBRL ref# is added to existing Dividend " + approved_dvd.DividendIndex);
            }

            if (approved_dvd != null)//Mark [XBRL_SavedFile] as approved
            {
                xsf.processState.Value = 1;
                xsf.DividendIndex.Value = approved_dvd.DividendIndex;
                xsf.Update_to_DB();/*Commented out for testing by Steven if needed*/
            }

            return approved_dvd;
        }

        /*-----------------------------------Functions for Approval--------------------------------------------------*/
        /// <summary>
        /// Get XBRL_SavedFile based on file ID
        /// </summary>
        private static XBRL_SavedFile ApproveXBRL0_get_xsFile(int xbrl_id)
        {
            XBRL_SavedFile xsf = new XBRL_SavedFile(xbrl_id);
            if (!xsf.Init_from_DB(false))
            {
                MessageBox.Show("Helper_XBRL error 2: Error in reading XBRL file");
                return null;
            }
            return xsf;
        }

        private static Dividend ApproveXBRL0_find_existingDividend(XBRL_event_info xei)
        {
            if (xei == null) return null;

            Dividend existingDVD = Helper_Dividend.GetDividend_XBRL_refNum(xei.XBRL_ReferenceNumber);
            if (existingDVD == null)
            {
                List<Dividend> list = Helper_Dividend.Get_DividendList_CR(xei.CUSIP, xei.RecordDate_ADR);
                foreach (Dividend dvd in list)
                {
                    if (dvd.GetStatus() == HssUtility.General.HssStatus.Cancel) continue;
                    else { existingDVD = dvd; break; }
                }
            }

            return existingDVD;
        }

        /// <summary>
        /// Deal with cancellation XBRL
        /// </summary>
        private static Dividend ApproveXBRL1_cancellation_XBRL(Dividend existing_dvd, XBRL_SavedFile xsf)
        {
            if (existing_dvd == null)
            {
                MessageBox.Show("No Dividend created for this cancellation XBRL");
                if (xsf != null) xsf.processState.Value = 2;
            }
            else
            {
                Helper_Dividend.CancelDivdiend(existing_dvd);//cancel existing dividend
                MessageBox.Show("Dividend " + existing_dvd.DividendIndex + " is cancelled");
                if (xsf != null) xsf.processState.Value = 1;
            }

            if (xsf != null) xsf.Update_to_DB();
            return existing_dvd;
        }

        /// <summary>
        /// Create New Dividend
        /// </summary>
        /// <returns>Approved Dividend in [Dividend_Control_Approved]</returns>
        private static Dividend ApproveXBRL2_CreateNewDividend(XBRL_event_info xei, Security sec)
        {
            Dividend XBRL_dvd = new Dividend();
            XBRL_dvd.Init_from_XBRL(xei, sec);
            XBRL_dvd.LastModifiedBy.Value = "StevenXBRL-" + Utility.CurrentUser;

            //insert temp dividend into [Dividend_Control]
            if (!XBRL_dvd.Insert_to_DB(DividendTable_option.Dividend_Control))
            {
                MessageBox.Show("Helper_XBRL error 0: can't save into [Dividend_Control]");
                return null;
            }

            //Get DividendIndex from saved dividend in [Dividend_Control]
            Dividend appr_dvd = Helper_Dividend.GetDividend_dvdID(XBRL_dvd.DividendID.Value, DividendTable_option.Dividend_Control);
            if (appr_dvd != null)
            {
                Helper_XBRL_approval.ApproveXBRL3_AddFees(appr_dvd);
                appr_dvd.Insert_to_DB(DividendTable_option.Dividend_Control_Approved);
            }
            else
            {
                MessageBox.Show("Helper_XBRL error 1: can't save into [Dividend_Control_Approved]");
                return null;
            }

            return appr_dvd;
        }

        private static Dividend ApproveXBRL2_UpdateDividend(XBRL_event_info xei, Dividend existing_dvd, Security sec)
        {
            if (existing_dvd == null || xei == null) return null;

            existing_dvd.Init_from_XBRL(xei, sec);
            existing_dvd.LastModifiedBy.Value = "StevenXBRL-" + Utility.CurrentUser;

            bool f1 = existing_dvd.Update_to_DB(DividendTable_option.Dividend_Control, false);
            bool f2 = existing_dvd.Update_to_DB(DividendTable_option.Dividend_Control_Approved, true);

            return existing_dvd;
        }

        private static void ApproveXBRL3_AddFees(Dividend dvd)
        {
            if (dvd == null) return;

            string depo_str = dvd.Sponsored.Value ? dvd.Depositary.Value : dvd.FirstFiler.Value;
            Depositary depo = DepositaryMaster.GetDepositary_by_name(depo_str);
            if (depo == null) return;

            Schedule_Of_Fees_DSC sfd = DSC_master.GetDSC_from_CDS(dvd.Country.Value, depo.DepositaryName.Value, dvd.RecordDate_ADR.Value, dvd.SecurityTypeID.Value);
            if (sfd == null) return;
            Dictionary<decimal, Schedule_Of_Fees_Per_Rate> Japan_atSourceFee_dic = DSC_master.Get_SFPR_dic(dvd.Country.Value, depo.DepositaryName.Value, dvd.RecordDate_ADR.Value);

            Bulk_DBcmd bk_cmd = new Bulk_DBcmd();
            List<DTC_Position_Headers> header_list = DTCpositionHeader_master.Get_headerList_modNum(dvd.DTCPosition_ModelNumber.Value);

            HashSet<decimal> unique_WHrate_hs = new HashSet<decimal>();
            foreach (DTC_Position_Headers dph in header_list) unique_WHrate_hs.Add(dph.WHRate.Value);

            foreach (decimal WHrate in unique_WHrate_hs)
            {
                Dividend_Schedule_Of_Fees_DSC dsfd = new Dividend_Schedule_Of_Fees_DSC();
                dsfd.DividendIndex.Value = dvd.DividendIndex;
                dsfd.WHRate.Value = WHrate / 100;

                dsfd.LongFormFees.Value = sfd.LongFormFees.Value;
                dsfd.MinLongFormFee.Value = sfd.MinLongFormFee.Value;

                dsfd.Fee_Consularization.Value = dvd.ConsularizationFee.Value;
                dsfd.Fee_QuickRefund.Value = sfd.ShortFormFees.Value;

                /*  //useless for now
                    dsfd.Fee_AtSource.Value = dvd.AtSourceFee.Value; 
                    dsfd.Fee_Max.Value = dvd.MAX_Fees.Value; 
                    dsfd.ExemptAtSourceFee.Value = sfd.ExemptAtSourceFee.Value;//combined into FavAtSourceFee
                    dsfd.ShortFormFees.Value = sfd.ShortFormFees.Value; 
                    dsfd.MinShortFormFee.Value = sfd.MinShortFormFee.Value;
                */

                dsfd.MinAtSourceFee.Value = sfd.MinAtSourceFee.Value;
                dsfd.MinQuickRefundFee.Value = sfd.MinQuickRefundFee.Value;
                dsfd.FavTransparentEntityFee.Value = sfd.FavTransparentEntityFee.Value;

                if (Japan_atSourceFee_dic.ContainsKey(WHrate))
                {
                    Schedule_Of_Fees_Per_Rate sfpr = Japan_atSourceFee_dic[WHrate];
                    dsfd.FavAtSourceFee.Value = sfpr.RateWithADSC.Value;

                    dsfd.AdditionalDSCFee.Value = sfpr.ADSC.Value;
                    dsfd.AdditionalDSCFee1.Value = sfpr.ADSC.Value;
                }
                else
                {
                    if (WHrate == 0) dsfd.FavAtSourceFee.Value = sfd.ExemptAtSourceFee.Value;
                    else dsfd.FavAtSourceFee.Value = sfd.FavAtSourceFee.Value;

                    dsfd.AdditionalDSCFee.Value = sfd.AdditionalDSCFee.Value;
                    dsfd.AdditionalDSCFee1.Value = sfd.AdditionalDSCFee.Value;
                }

                dsfd.Source_FeeID.Value = sfd.FeesID;
                dsfd.LastModifiedBy.Value = "StevenXBRL-" + Utility.CurrentUser;
                dsfd.ModifiedDateTime.Value = DateTime.Now;

                bk_cmd.Add_DBcmd(dsfd.Get_DBinsert());
            }

            int count = bk_cmd.SaveToDB(Utility.Get_DRWIN_hDB());
        }

        private static Dividend ApproveXBRL4_InsertDvdXBRL(XBRL_event_info xei, Dividend dvd)
        {
            if (dvd == null || xei == null) return null;

            DividendXBRL dvdXBRL = DividendXBRL_master.Get_dvdXBRL(xei.XBRL_ReferenceNumber, dvd.DividendIndex);
            if (dvdXBRL == null) dvdXBRL = new DividendXBRL();

            Depositary depo = DepositaryMaster.GetDepositary_by_name(xei.depoName);
            if (depo == null) depo = DepositaryMaster.GetDepositary_by_name(xei.Sender);
            if (depo != null) dvdXBRL.Depositary.Value = depo.DepositaryName.Value;

            dvdXBRL.DividendIndex.Value = dvd.DividendIndex;
            dvdXBRL.XBRL_ReferenceNumber.Value = xei.XBRL_ReferenceNumber;

            dvdXBRL.Announcement_Identifier.Value = xei.AnnouncementIdentifier;
            if (!dvdXBRL.IsCompleteEvent_flag) dvdXBRL.Event_Completeness.Value = xei.EventCompleteness;

            if (dvdXBRL.XBRL_ID > 0)
            {
                if (dvdXBRL.CheckValueChanges())
                {
                    dvdXBRL.LastModifiedBy.Value = Utility.CurrentUser;
                    dvdXBRL.LastModifiedDate.Value = DateTime.Now;
                    bool flag = dvdXBRL.Update_to_DB();
                }
            }
            else
            {
                dvdXBRL.LastModifiedBy.Value = Utility.CurrentUser;
                dvdXBRL.LastModifiedDate.Value = DateTime.Now;
                bool flag = dvdXBRL.Insert_to_DB();
            }

            return dvd;
        }

        private static void ApproveXBRL5_taskMgr(Dividend approved_dvd)
        {
            Task_Detail_21 td21 = new Task_Detail_21(approved_dvd);
            td21.TaskName.Value = "XBRL approval";
            td21.InsertTask21_to_DB();
        }
    }
}
