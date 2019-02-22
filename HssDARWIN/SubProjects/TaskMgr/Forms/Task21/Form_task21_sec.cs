using System;
using System.Data;
using System.Windows.Forms;

using HssDARWIN.Models.Tasks.Task21;

namespace HssDARWIN.SubProjects.TaskMgr.Forms.Task21
{
    public partial class Form_task21_sec : Form
    {
        public Form_task21_sec(int id)
        {
            this.InitializeComponent();

            this.secNum_label.Text = "Security #:" + id;
            this.secID = id;
            this.InitGrid();
        }

        private const string edit_colName = "Edit", del_colName = "Delete";
        private const string ID_colName = "ID", taskName_colName = "TaskName", status_colName = "Status";
        private int secID = -1;
        private DataTable main_dt = new DataTable();

        public HssUtility.Utility.Void_NoParams_delegate Refresh_parentUI = HssUtility.Utility.Void_NoParams_emptyFunc;

        private void InitGrid()
        {
            this.main_dt.Columns.Add(Form_task21_sec.edit_colName).DefaultValue = Form_task21_sec.edit_colName;
            this.main_dt.Columns.Add(Form_task21_sec.del_colName).DefaultValue = Form_task21_sec.del_colName;
            this.main_dt.Columns.Add(Form_task21_sec.ID_colName, typeof(int));
            this.main_dt.Columns.Add(Form_task21_sec.status_colName);
            this.main_dt.Columns.Add(Form_task21_sec.taskName_colName);

            this.BindData();
            this.main_ultraGrid.DataSource = this.main_dt;
        }

        private void BindData()
        {
            this.main_dt.Clear();

            foreach (Task21_security td in Task21_secMaster.Get_secList(this.secID))
            {
                DataRow row = this.main_dt.Rows.Add();
                row[Form_task21_sec.ID_colName] = td.ID;
                row[Form_task21_sec.taskName_colName] = td.TaskName.Value;
                row[Form_task21_sec.status_colName] = td.Status.Value;
            }
        }

        private void Pop_detailForm(Form_task21_detail detailForm)
        {
            detailForm.Refresh_UI = delegate ()
            {
                this.Refresh_parentUI();
                this.BindData();
            };
            detailForm.Show();
        }

        /******************************UI Event handlers**************************************/

        private void add_button_Click(object sender, EventArgs e)
        {
            Form_task21_detail detailForm = new Form_task21_detail(this.secID);
            this.Pop_detailForm(detailForm);
        }

        private void close_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void main_ultraGrid_InitializeLayout(object sender, Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs e)
        {
            Infragistics.Win.UltraWinGrid.UltraGridColumn edit_col = e.Layout.Bands[0].Columns[Form_task21_sec.edit_colName];
            edit_col.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Button;
            edit_col.ButtonDisplayStyle = Infragistics.Win.UltraWinGrid.ButtonDisplayStyle.Always;
            edit_col.MaxWidth = Form_task21_sec.edit_colName.Length * Utility.FormCharWidth;
            edit_col.Header.Caption = "";

            Infragistics.Win.UltraWinGrid.UltraGridColumn del_col = e.Layout.Bands[0].Columns[Form_task21_sec.del_colName];
            del_col.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Button;
            del_col.ButtonDisplayStyle = Infragistics.Win.UltraWinGrid.ButtonDisplayStyle.Always;
            del_col.MaxWidth = Form_task21_sec.del_colName.Length * Utility.FormCharWidth;
            del_col.Header.Caption = "";
        }

        private void main_ultraGrid_ClickCellButton(object sender, Infragistics.Win.UltraWinGrid.CellEventArgs e)
        {
            int detailID = (int)e.Cell.Row.Cells[Form_task21_sec.ID_colName].Value;

            if (e.Cell.Value.Equals(Form_task21_sec.edit_colName))
            {
                Form_task21_detail detailForm = new Form_task21_detail(this.secID, detailID);
                this.Pop_detailForm(detailForm);
            }
            else if (e.Cell.Value.Equals(Form_task21_sec.del_colName))
            {
                if (MessageBox.Show("Are you sure to Delete Task " + detailID + "?", "Msg", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    Task21_security detail = new Task21_security(detailID);
                    if (detail == null) return;

                    detail.Delete_from_DB();
                    Task21_secMaster.Reset();
                    this.Refresh_parentUI();
                    this.BindData();
                }
            }
        }
    }
}
