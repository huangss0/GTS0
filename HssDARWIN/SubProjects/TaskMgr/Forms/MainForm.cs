using System;
using System.Drawing;
using System.Windows.Forms;

using Infragistics.Win.UltraWinGrid;
using Infragistics.Win;

using HssDARWIN.Models.Tasks;
using HssDARWIN.Models.Countries;
using HssDARWIN.Helpers;
using HssUtility.Forms.Attribute;

namespace HssDARWIN.SubProjects.TaskMgr.Forms
{
    public partial class MainForm : Form
    {
        private void showAll_button_Click(object sender, EventArgs e)
        {
            if (this.tsk_vc.DataLoadingFinished_flag)
            {
                int rowsAdded = this.tsk_vc.Add_TDrows_to_DT(int.MaxValue);
                this.SetGird_sortFilter(true);
            }
            else MessageBox.Show("Still loading...");
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            //To be implemented...
        }

        private void run20_button_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Run task 20?", "???", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
            {
                Models.Tasks.Task20.Task20_master t20m = new Models.Tasks.Task20.Task20_master();
                t20m.PerformTasks();
                MessageBox.Show("Done");
            }
        }

        private void add17_button_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Add Task 17?", "???", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
            {
                Task17.Form_task17 ft17 = new Task17.Form_task17();
                ft17.Refresh_parentUI = this.RefreshMainGrid;
                ft17.Show();
            }
        }

        private void main_ultraGrid_ClickCellButton(object sender, CellEventArgs e)
        {
            int detail_id = (int)e.Cell.Row.Cells["TaskDetailID"].Value;

            Task_Detail td = new Task_Detail(detail_id);
            td.Init_from_DB();
            Models_viewForm mvf = td.GetEditForm();
            mvf.Refresh_parentUI = this.RefreshMainGrid;
            mvf.Show();
        }

        private void members_treeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            WinControl_helper.SetItemsChecked(this.cty_checkedListBox, false);

            int level = e.Node.Level;
            if (level == 0)
            {
                int gpID = -1;
                if (!int.TryParse(e.Node.Name, out gpID)) return;

                ADR_Group ag = TaskMemberMaster.Get_ADRgroup_ID(gpID);
                if (ag == null) return;


                foreach (Country cty in ag.Country_list)
                {
                    int itemID = this.cty_itemID_dic[cty.name];
                    this.cty_checkedListBox.SetItemChecked(itemID, true);
                }
            }
            else if (level == 1)
            {
                ADR_TaskOwner ato = TaskMemberMaster.Get_taskOwner_SID(e.Node.Name);
                if (ato == null) return;

                foreach (Country cty in ato.Country_list)
                {
                    int itemID = this.cty_itemID_dic[cty.name];
                    this.cty_checkedListBox.SetItemChecked(itemID, true);
                }
            }

            this.RefreshMainGrid();
        }

        private void cty_all_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            WinControl_helper.SetItemsChecked(this.cty_checkedListBox, this.cty_all_checkBox.Checked);
        }

        private void taskID_all_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            WinControl_helper.SetItemsChecked(this.taskID_checkedListBox, this.taskID_all_checkBox.Checked);
        }

        private void main_ultraGrid_AfterRowRegionScroll(object sender, RowScrollRegionEventArgs e)
        {
            if (e.RowScrollRegion.ScrollPosition + e.RowScrollRegion.VisibleRows.Count > this.tsk_vc.sourceDT.Rows.Count - 1)
            {
                int rowsAdded = this.tsk_vc.Add_TDrows_to_DT();
                UltraGrid_helper.AutoResize(this.main_ultraGrid);
                if (rowsAdded == 0) this.SetGird_sortFilter(this.tsk_vc.ViewData_match_flag);
            }
        }

        private void task_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.RefreshMainGrid();
        }

        private void filter_button_Click(object sender, EventArgs e)
        {
            this.formFilter.ShowDialog();
            this.RefreshMainGrid();
        }

        private void refresh_button_Click(object sender, EventArgs e)
        {
            this.RefreshMainGrid();
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

        private void test_button_Click(object sender, EventArgs e)
        {
            if (!Utility.Is_DWRIN_admin())
            {
                MessageBox.Show("Only for DRWIN developers");
                return;
            }
        }

        private void main_ultraGrid_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
