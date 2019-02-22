using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

using Infragistics.Win;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinEditors;

using HssUtility.Forms.Filter;
using HssDARWIN.Helpers;
using HssDARWIN.Models.XBRL.Event;
using HssDARWIN.SubProjects.UserProfile;

namespace HssDARWIN.Models.XBRL.UI
{
    public partial class XBRL_UserControl : UserControl
    {
        private XBRL_SavedFile_master sf_master = new XBRL_SavedFile_master();
        private UltraTextEditor pending_textEditor, appr_textEditor, rej_textEditor;
        private FilterForm formFilter = null;

        private void pending_radioButton_Click(object sender, EventArgs e)
        {
            if (this.pending_radioButton.Checked)
            {
                this.shown_processState = HssUtility.General.HssStatus.Pending;
                this.lastRefreshAt = DateTime.MinValue;
                this.RefreshData(null);
            }
        }

        private void approved_radioButton_Click(object sender, EventArgs e)
        {
            if (this.approved_radioButton.Checked)
            {
                this.shown_processState = HssUtility.General.HssStatus.Approved;
                this.lastRefreshAt = DateTime.MinValue;
                this.RefreshData(null);
            }
        }

        private void rejected_radioButton_Click(object sender, EventArgs e)
        {
            if (this.rejected_radioButton.Checked)
            {
                this.shown_processState = HssUtility.General.HssStatus.Rejected;
                this.lastRefreshAt = DateTime.MinValue;
                this.RefreshData(null);
            }
        }

        /*-----------------------------------------------------------------------------------------------------------------------------------------------*/

        private void loadAll_button_Click(object sender, EventArgs e)
        {
            if (this.sf_master.DataLoadingFinished_flag)
            {
                int rowsAdded = this.sf_master.Add_XBRLrows_to_DT(int.MaxValue);
                this.SetGird_sortFilter(true);
            }
            else MessageBox.Show("Still loading...");
        }

        private void uploadXBRL_button_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string filePath = ofd.FileName;
                FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
                byte[] buffer = new byte[fs.Length];
                fs.Read(buffer, 0, buffer.Length);
                fs.Close();

                XBRL_SavedFile xsf = new XBRL_SavedFile();
                xsf.savedfile = buffer;
                xsf.Init_from_info(new XBRL_event_info(buffer));
                xsf.originalFileName.Value = filePath.Substring(filePath.LastIndexOf('\\') + 1);
                MessageBox.Show(xsf.originalFileName.Value + " (" + xsf.Insert_to_DB() + ")");

                this.RefreshData(null);
            }
        }

        private void filter_button_Click(object sender, EventArgs e)
        {
            this.formFilter.ShowDialog();
            this.RefreshData(this.formFilter.FilterCondition);
        }

        private void main_ultraGrid_MouseDown(object sender, MouseEventArgs e)
        {
            this.main_ultraGrid.ContextMenuStrip = null;
            if (e.Button != MouseButtons.Right) return;

            Point clickPoint = new Point(e.X, e.Y);
            UIElement el = this.main_ultraGrid.DisplayLayout.UIElement.ElementFromPoint(clickPoint);
            if (el is TextUIElement == false) return;

            TextUIElement tue = (TextUIElement)el;
            if (el.Parent is HeaderUIElement) this.main_ultraGrid.ContextMenuStrip = this.Get_ColRightClick_menu(tue.Text);
        }

        private void XBRL_UserControl_Resize(object sender, EventArgs e)
        {
            int width = this.Size.Width, height = this.Size.Height - this.main_ultraGrid.Location.Y;
            this.main_ultraGrid.Size = new Size(width, height);
        }

        private void refresh_button_Click(object sender, EventArgs e)
        {
            this.RefreshData(null);
        }

        private void main_ultraGrid_InitializeLayout(object sender, InitializeLayoutEventArgs e)
        {
            HssGridConfig hgc = UserConfigMaster.Get_GridConfig(XBRL_UserControl.Key_UserConfig, null, true);
            if (hgc != null)
            {
                hgc.ConfigGrid(this.main_ultraGrid);
                UserConfigMaster.AddControl(this);
            }
        }

        

        private void main_ultraGrid_Leave(object sender, EventArgs e)
        {
            HssGridConfig hgc = UserConfigMaster.Get_GridConfig(XBRL_UserControl.Key_UserConfig, null, true);
            if (hgc != null) hgc.ConfigGrid(this.main_ultraGrid);
        }

        private void main_ultraGrid_AfterRowRegionScroll(object sender, RowScrollRegionEventArgs e)
        {
            if (e.RowScrollRegion.ScrollPosition + e.RowScrollRegion.VisibleRows.Count > this.sf_master.sourceDT.Rows.Count - 1)
            {
                int rowsAdded = this.sf_master.Add_XBRLrows_to_DT();
                UltraGrid_helper.AutoResize(this.main_ultraGrid);
                if (rowsAdded == 0) this.SetGird_sortFilter(this.sf_master.ViewData_match_flag);
            }
        }
    }
}
