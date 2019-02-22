using System;
using System.Windows.Forms;

using HssDARWIN.Helpers;
using HssDARWIN.SubProjects.UserProfile;
using HssUtility.Forms.Filter;
using HssUtility.General;
using HssUtility.SQLserver;

namespace HssDARWIN.Models.XBRL.UI
{
    public partial class XBRL_UserControl : UserControl
    {
        public const string Key_UserConfig = "StevenXBRL";

        private HssStatus shown_processState = HssStatus.Pending;
        public HssStatus ProcessingStat
        {
            get { return this.shown_processState; }
            set
            {
                if (value == HssStatus.Approved)
                {
                    this.shown_processState = HssStatus.Approved;
                    this.approved_radioButton.Checked = true;
                }
                else if (value == HssStatus.Rejected)
                {
                    this.shown_processState = HssStatus.Rejected;
                    this.rejected_radioButton.Checked = true;
                }
                else
                {
                    this.shown_processState = HssStatus.Pending;
                    this.pending_radioButton.Checked = true;
                }
            }
        }

        public bool StopRefresh_flag = false;

        public XBRL_UserControl()
        {
            this.InitializeComponent();
            UltraGrid_helper.InitGrid(this.main_ultraGrid, true, true);
            this.Prepare_actionColumn();
        }

        private void XBRL_UserControl_Load(object sender, EventArgs e)
        {
            UltraGrid_helper.SetDataSource(this.main_ultraGrid, this.sf_master.sourceDT);
            this.formFilter = new FilterForm(this.sf_master.sourceDT);
            this.RefreshData(null);

            this.main_ultraGrid.DisplayLayout.Bands[0].Columns[UltraGrid_helper.ActionColumnName].ButtonDisplayStyle =
                Infragistics.Win.UltraWinGrid.ButtonDisplayStyle.Always;
            UltraGrid_helper.SetMaxWidth(this.main_ultraGrid, 220);
        }

        public HssUtility.Utility.Void_IntParams_delegate GoToControl_func = HssUtility.Utility.Void_IntParams_emptyFunc;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            HssGridConfig hgc = UserConfigMaster.Get_GridConfig(XBRL_UserControl.Key_UserConfig, null, true);
            if (hgc != null) hgc.Init_from_grid(this.main_ultraGrid);

            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        /*---------------------------------------------------------------------------------------------------*/

        private void Prepare_actionColumn()
        {
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
    }
}
