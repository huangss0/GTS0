using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

using HssDARWIN.Helpers;
using HssUtility.Forms.Attribute;

namespace HssDARWIN.SubProjects.Daily_Jobs
{
    public partial class DailyJobs_form : Form
    {
        public DailyJobs_form()
        {
            this.InitializeComponent();

            this.sourceDT = this.Get_dailyJobs_dt();
            UltraGrid_helper.SetDataSource(this.main_ultraGrid, this.sourceDT);
            UltraGrid_helper.InitGrid(this.main_ultraGrid);

            this.main_ultraGrid.DisplayLayout.Bands[0].Columns["ID"].Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Button;
            this.main_ultraGrid.DisplayLayout.Bands[0].Columns["ID"].ButtonDisplayStyle = Infragistics.Win.UltraWinGrid.ButtonDisplayStyle.Always;
        }

        private DataTable sourceDT = null;

        /*------------------------------------------------------------------------------------------------------------------------------------*/

        private DataTable Get_dailyJobs_dt()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("Job_Class");
            dt.Columns.Add("Job_ID", typeof(int));
            dt.Columns.Add("LastRunAt");
            dt.Columns.Add("LastRunBy");
            dt.Columns.Add("Locked");
            dt.Columns.Add("Notes");
            dt.Columns.Add("LastLockAt");
            dt.Columns.Add("LastLockBy");

            return dt;
        }

        private void RefreshMainGrid()
        {
            List<Hss_DailyJobs> list = Hss_DailyJobs_master.GetAllJobs();
            this.sourceDT.Clear();
            foreach (Hss_DailyJobs hdj in list)
            {
                DataRow row = this.sourceDT.Rows.Add();
                row["ID"] = hdj.ID;
                row["Job_Class"] = hdj.Job_Class.Value;
                row["Job_ID"] = hdj.Job_ID.Value;
                row["LastRunAt"] = hdj.LastRunAt.GetValue_in_string(1);
                row["LastRunBy"] = hdj.LastRunBy.Value;
                row["Locked"] = hdj.Locked.Value;
                row["Notes"] = hdj.Notes.Value;
                row["LastLockAt"] = hdj.LastLockAt.GetValue_in_string(1);
                row["LastLockBy"] = hdj.LastLockBy.Value;
            }

            UltraGrid_helper.AutoResize(this.main_ultraGrid);
        }

        /*---------------------------------------------------------------------------------------------------------------------------------------*/

        private void main_ultraGrid_ClickCellButton(object sender, Infragistics.Win.UltraWinGrid.CellEventArgs e)
        {
            int detail_id = (int)e.Cell.Row.Cells["ID"].Value;

            Hss_DailyJobs td = new Hss_DailyJobs(detail_id);
            td.Init_from_DB();
            Models_viewForm mvf = td.GetEditForm();
            mvf.Refresh_parentUI = this.RefreshMainGrid;
            mvf.Show();
        }

        private void DailyJobs_form_Load(object sender, EventArgs e)
        {
            this.RefreshMainGrid();
        }
    }
}
