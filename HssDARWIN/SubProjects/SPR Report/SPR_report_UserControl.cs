using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;

using HssDARWIN.Helpers;
using HssDARWIN.Models.Dividends;
using HssUtility.General;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinEditors;

namespace HssDARWIN.SubProjects.SPR_Report
{
    public partial class SPR_report_UserControl : UserControl
    {
        private SPR_fileControl sf_control = new SPR_fileControl();
        private UltraTextEditor pending_textEditor, appr_textEditor, rej_textEditor;

        public SPR_report_UserControl()
        {
            this.InitializeComponent();
            if (Utility.Is_DWRIN_admin()) this.upload_button.Visible = true;

            UltraGrid_helper.InitGrid(this.main_ultraGrid);

            UltraTextEditor_setting setting_pending = new UltraTextEditor_setting();
            setting_pending.AddButton("Approve", "OK");
            setting_pending.AddButton("Reject", "Cancel");
            setting_pending.AddButton("ViewData");
            this.pending_textEditor = UltraTextEditor_helper.CreateTextEditorButtons(setting_pending);
            this.pending_textEditor.EditorButtonClick += this.ActionButtonEvent_textEditor;

            UltraTextEditor_setting setting_appr = new UltraTextEditor_setting();
            setting_appr.AddButton("Restore", "Restore");
            setting_appr.AddButton("ViewData");
            this.appr_textEditor = UltraTextEditor_helper.CreateTextEditorButtons(setting_appr);
            this.appr_textEditor.EditorButtonClick += this.ActionButtonEvent_textEditor;

            UltraTextEditor_setting setting_reject = new UltraTextEditor_setting();
            setting_reject.AddButton("Restore", "Restore");
            setting_reject.AddButton("ViewData");
            this.rej_textEditor = UltraTextEditor_helper.CreateTextEditorButtons(setting_reject);
            this.rej_textEditor.EditorButtonClick += this.ActionButtonEvent_textEditor;
        }

        public void RefreshData()
        {
            HssStatus status = HssStatus.None;
            if (this.appr_radioButton.Checked) status = HssStatus.Approved;
            else if (this.reject_radioButton.Checked) status = HssStatus.Rejected;
            else status = HssStatus.Pending;

            this.main_ultraGrid.DataSource = this.sf_control.Get_viewDT(status);

            UltraTextEditor curr_textEditor = null;
            if (this.appr_radioButton.Checked) curr_textEditor = this.appr_textEditor;
            else if (this.reject_radioButton.Checked) curr_textEditor = this.rej_textEditor;
            else curr_textEditor = this.pending_textEditor;

            this.main_ultraGrid.DisplayLayout.Bands[0].Columns["Action"].EditorComponent = curr_textEditor;
            this.main_ultraGrid.DisplayLayout.Bands[0].Columns["Action"].ButtonDisplayStyle = ButtonDisplayStyle.Always;
            this.main_ultraGrid.DisplayLayout.Bands[0].Columns["CreateTime"].Format = UltraGrid_helper.DateTime_format_full;
            this.main_ultraGrid.DisplayLayout.Bands[0].Columns["LastModifyAt"].Format = UltraGrid_helper.DateTime_format_full;

            UltraGrid_helper.AutoResize(this.main_ultraGrid);
        }

        /// <summary>
        /// Button events handler in Action column
        /// </summary>
        private void ActionButtonEvent_textEditor(object sender, EditorButtonEventArgs e)
        {
            if (e.Context is UltraGridCell == false) return;

            UltraGridCell cell = (UltraGridCell)e.Context;
            int ID = (int)cell.Row.Cells["ID"].Value;            

            SPR_file sf = new SPR_file(ID);
            sf.Init_from_DB();

            string option = e.Button.Key;
            if (option.StartsWith("Approve", StringComparison.OrdinalIgnoreCase))
            {
                if (MessageBox.Show("Approve file " + ID + "?", "Happy!", MessageBoxButtons.YesNo) != DialogResult.Yes) return;

                Dividend curr_dvd = null;
                string CUSIP = cell.Row.Cells["CUSIP"].Value.ToString();
                List<Dividend> dvdList = Helper_Dividend.Get_DividendList_CUSIP(CUSIP);

                foreach (Dividend dvd in dvdList)
                {
                    if (HssDateTime.CompareDateTime_day(sf.RecordDate.Value, dvd.RecordDate_ADR.Value) == 0)
                    {
                        curr_dvd = dvd;//matching Dividend found
                        break;
                    }
                }

                if (curr_dvd == null) //CUSIP and Record Date not found record in [Dividend_Control] table, let user to choose
                {
                    Form_DividendSelector fds = new Form_DividendSelector();
                    int dvd_index = fds.Init_from_list(dvdList);
                    if (dvd_index > 0) curr_dvd = new Dividend(dvd_index);
                }
                else //CUSIP and Record Date match record in [Dividend_Control] table
                {
                    if (MessageBox.Show("Update Dividend " + curr_dvd.DividendIndex + "?", "???", MessageBoxButtons.YesNo) != DialogResult.Yes) return;
                }

                if (curr_dvd != null)
                {
                    if (!curr_dvd.Insert_DTC_position(sf)) return;

                    sf.SetStatus(HssStatus.Approved);
                    sf.LastModifyAction.Value = "Approve";
                    sf.Update_to_DB();

                    MessageBox.Show("Dividend #" + curr_dvd.DividendIndex + " DTC position updated!");
                    this.RefreshData();
                }
                else MessageBox.Show("Dividend Event not found...");
            }
            else if (option.StartsWith("ViewData", StringComparison.OrdinalIgnoreCase))
            {
                ViewDataForm vdf = new ViewDataForm();
                vdf.Set_notePad_dataSource(sf.FileBinary, ViewDataOption.RawView_strLine);
                vdf.Show();
            }
            else if (option.StartsWith("Reject", StringComparison.OrdinalIgnoreCase))
            {
                if (MessageBox.Show("Reject file " + ID + "?", "Sad...", MessageBoxButtons.YesNo) != DialogResult.Yes) return;

                sf.SetStatus(HssStatus.Rejected);
                sf.LastModifyAction.Value = "Reject";
                sf.Update_to_DB();
                this.RefreshData();
            }
            else if (option.StartsWith("Restore", StringComparison.OrdinalIgnoreCase))
            {
                if (MessageBox.Show("Restore file " + ID + "?", "Hero is back!", MessageBoxButtons.YesNo) != DialogResult.Yes) return;

                sf.SetStatus(HssStatus.Pending);
                sf.LastModifyAction.Value = "Restore";
                sf.Update_to_DB();
                this.RefreshData();
            }
        }

        /*********************************************UI Events*******************************************************/
        private void SPR_report_UserControl_Load(object sender, EventArgs e) { this.RefreshData(); }
        private void pending_radioButton_CheckedChanged(object sender, EventArgs e) { if (this.pending_radioButton.Checked) this.RefreshData(); }
        private void appr_radioButton_CheckedChanged(object sender, EventArgs e) { if (this.appr_radioButton.Checked) this.RefreshData(); }
        private void reject_radioButton_CheckedChanged(object sender, EventArgs e) { if (this.reject_radioButton.Checked) this.RefreshData(); }

        private void refresh_button_Click(object sender, EventArgs e)
        {
            this.RefreshData();
        }

        private void upload_button_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(ofd.FileName, FileMode.Open, FileAccess.Read);
                byte[] byteArr = new byte[fs.Length];
                fs.Read(byteArr, 0, byteArr.Length);
                fs.Close();

                List<SPR_file> sf_list = SPR_fileControl.SplitRawFile(byteArr);

                string path = ofd.FileName;
                string name = path.Substring(path.LastIndexOf('\\') + 1);

                foreach (SPR_file sf in sf_list)
                {
                    sf.FileName.Value = name;
                    MessageBox.Show(sf.CUSIP.Value + ": " + sf.Insert_to_DB());
                }

                this.RefreshData();
            }
        }

        private void SPR_report_UserControl_Resize(object sender, EventArgs e)
        {
            int width = this.Size.Width, height = this.Size.Height - this.main_ultraGrid.Location.Y;
            this.main_ultraGrid.Size = new Size(width, height);
        }
    }
}
