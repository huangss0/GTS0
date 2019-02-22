using System;
using System.Windows.Forms;

using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinEditors;

using HssUtility.General;
using HssUtility.SQLserver;
using HssDARWIN.Helpers;
using HssDARWIN.Models.Dividends;
using HssDARWIN.Models.XBRL.Event;

namespace HssDARWIN.Models.XBRL.UI
{
    public partial class XBRL_UserControl : UserControl
    {
        private DateTime lastRefreshAt = DateTime.MinValue;

        /// <summary>
        /// Refresh data on Grid
        /// </summary>
        public void RefreshData(SQL_condition cond)
        {
            if (this.StopRefresh_flag) return;

            if ((DateTime.Now - this.lastRefreshAt).TotalSeconds < 5)
            {
                Console.WriteLine("---> XBRL_UserControl_func info 0: no refresh within 5 seconds, last at " + this.lastRefreshAt);
                return;
            }
            else this.lastRefreshAt = DateTime.Now;

            Console.WriteLine("---> XBRL_UserControl_func info 1: LastRefreshAt: " + this.lastRefreshAt);
            //get display data table
            this.sf_master.Get_viewDT_async(this.shown_processState, cond);

            //Get action textEditor
            UltraTextEditor curr_textEditor = null;
            if (this.approved_radioButton.Checked) curr_textEditor = this.appr_textEditor;
            else if (this.rejected_radioButton.Checked) curr_textEditor = this.rej_textEditor;
            else curr_textEditor = this.pending_textEditor;
            this.main_ultraGrid.DisplayLayout.Bands[0].Columns[UltraGrid_helper.ActionColumnName].EditorComponent = curr_textEditor;

            //Display setting in Grid            
            this.SetGird_sortFilter(this.sf_master.ViewData_match_flag);
            UltraGrid_helper.AutoResize(this.main_ultraGrid);
            UltraGrid_helper.ClearCurrentFilters(this.main_ultraGrid);
            this.main_ultraGrid.ActiveRowScrollRegion.Scroll(RowScrollAction.Top);
        }

        private void SetGird_sortFilter(bool visible)
        {
            this.loadAll_button.Visible = !visible;
            UltraGrid_helper.Set_header_sortFilter(this.main_ultraGrid, visible);
            UltraGrid_helper.AutoResize(this.main_ultraGrid);
        }

        /// <summary>
        /// Action column event handler
        /// </summary>
        private void ActionButtonEvent_textEditor(object sender, EditorButtonEventArgs e)
        {
            if (e.Context is UltraGridCell == false) return;

            UltraGridCell cell = (UltraGridCell)e.Context;
            int ID = (int)cell.Row.Cells["id_SavedfilesRcvd"].Value;

            XBRL_SavedFile sf = new XBRL_SavedFile(ID);

            string option = e.Button.Key;
            if (option.StartsWith("Approve", StringComparison.OrdinalIgnoreCase))
            {
                if (MessageBox.Show("Approve file " + ID + "?", "Happy!", MessageBoxButtons.YesNo) != DialogResult.Yes) return;

                Dividend dvd = Helper_XBRL_approval.ApproveXBRL(ID);
                this.RefreshData(null);
                if (dvd != null && MessageBox.Show("Go to Control? " + dvd.DividendIndex, "???", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    this.GoToControl_func(dvd.DividendIndex);
            }
            else if (option.StartsWith("ViewData", StringComparison.OrdinalIgnoreCase))
            {
                sf.Init_from_DB(false);
                ViewDataForm vdf = new ViewDataForm();
                vdf.suggestedFileName_forSave = sf.id_SavedfilesRcvd.ToString();
                vdf.Set_grid_dataSource(sf.Get_XBRLinfo_DS());
                vdf.Set_notePad_dataSource(sf.savedfile);
                vdf.Show();
            }
            else if (option.StartsWith("Reject", StringComparison.OrdinalIgnoreCase))
            {
                if (MessageBox.Show("Reject file " + ID + "?", "Sad...", MessageBoxButtons.YesNo) != DialogResult.Yes) return;

                sf.Init_from_DB(true);
                sf.processState.Value = (int)HssStatus.Rejected;
                sf.Update_to_DB();

                this.lastRefreshAt = DateTime.MinValue;
                this.RefreshData(null);
            }
            else if (option.StartsWith("Restore", StringComparison.OrdinalIgnoreCase))
            {
                if (MessageBox.Show("Restore file " + ID + "?", "Hero is back!", MessageBoxButtons.YesNo) != DialogResult.Yes) return;

                sf.Init_from_DB(true);
                sf.processState.Value = (int)HssStatus.Pending;
                sf.Update_to_DB();

                this.lastRefreshAt = DateTime.MinValue;
                this.RefreshData(null);
            }
        }

        /*-------------------------------------------------------------------------------------------------------------------*/        

        private string currColName_toHide = null;//used in column header right mouse click

        private ContextMenuStrip Get_ColRightClick_menu(string colCaption)
        {
            ContextMenuStrip cms = new ContextMenuStrip();
            ToolStripMenuItem item0 = new ToolStripMenuItem("Hide Column: " + colCaption);
            item0.Click += this.ColHeader_hide_rightMouseClick;
            ToolStripMenuItem item1 = new ToolStripMenuItem("Unhide All Columns");
            item1.Click += this.ColHeader_unhideAll_rightMouseClick;

            cms.Items.Add(item0);
            cms.Items.Add(item1);
            this.currColName_toHide = colCaption;

            return cms;
        }

        private void ColHeader_hide_rightMouseClick(object sender, EventArgs e)
        {
            UltraGrid_helper.HideColumn_byHeader(this.main_ultraGrid, this.currColName_toHide);
        }

        private void ColHeader_unhideAll_rightMouseClick(object sender, EventArgs e)
        {
            UltraGrid_helper.UnhideAllColumns(this.main_ultraGrid);
        }
    }
}
