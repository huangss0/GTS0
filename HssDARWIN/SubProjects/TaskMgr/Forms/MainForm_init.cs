using System;
using System.Windows.Forms;

using HssDARWIN.Helpers;
using HssDARWIN.SubProjects.UserProfile;
using HssUtility.Forms.Filter;

namespace HssDARWIN.SubProjects.TaskMgr.Forms
{
    public partial class MainForm : Form
    {
        public const string Key_UserConfig = "TaskMgr";

        public MainForm()
        {
            this.InitializeComponent();

            UltraGrid_helper.SetDataSource(this.main_ultraGrid, this.tsk_vc.sourceDT);
            UltraGrid_helper.InitGrid(this.main_ultraGrid, false, false);
            UltraGrid_helper.Set_readOnly_columns(this.main_ultraGrid, false, 0);
            UltraGrid_helper.SetMaxWidth(this.main_ultraGrid, 250);

            this.main_ultraGrid.DisplayLayout.Bands[0].Columns["TaskDetailID"].Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Button;
            this.main_ultraGrid.DisplayLayout.Bands[0].Columns["TaskDetailID"].ButtonDisplayStyle = Infragistics.Win.UltraWinGrid.ButtonDisplayStyle.Always;
            this.main_ultraGrid.DisplayLayout.Bands[0].SortedColumns.Add("TaskDetailID", false);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.formFilter = new FilterForm(this.tsk_vc.sourceDT);

            this.Init_taskMembers();
            this.Init_countries();
            this.RefreshMainGrid();

            HssGridConfig hgc = UserConfigMaster.Get_GridConfig(MainForm.Key_UserConfig, null, true);
            if (hgc != null)
            {
                hgc.ConfigGrid(this.main_ultraGrid);
                UserConfigMaster.AddControl(this);
            }
        }

        private void main_ultraGrid_Leave(object sender, EventArgs e)
        {
            HssGridConfig hgc = UserConfigMaster.Get_GridConfig(MainForm.Key_UserConfig, null, true);
            if (hgc != null) hgc.Init_from_grid(this.main_ultraGrid);
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            HssGridConfig hgc = UserConfigMaster.Get_GridConfig(MainForm.Key_UserConfig, null, true);
            if (hgc != null) hgc.Init_from_grid(this.main_ultraGrid);

            if (disposing && (this.components != null)) this.components.Dispose();            
            base.Dispose(disposing);
        }
    }
}
