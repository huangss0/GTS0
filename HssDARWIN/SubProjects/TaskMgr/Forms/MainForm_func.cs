using System;
using System.Collections.Generic;
using System.Windows.Forms;

using Infragistics.Win.UltraWinGrid;

using HssDARWIN.Helpers;
using HssDARWIN.Models.Tasks;
using HssDARWIN.Models.Countries;
using HssUtility.Forms.Filter;
using HssUtility.SQLserver;
using HssUtility.General;

namespace HssDARWIN.SubProjects.TaskMgr.Forms
{
    public partial class MainForm
    {
        private TaskForm_viewControl tsk_vc = new TaskForm_viewControl();
        private FilterForm formFilter = null;
        private Dictionary<string, int> cty_itemID_dic = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);

        private void RefreshMainGrid()
        {
            string str = this.task_comboBox.Text;
            int option = -1;
            if (str.Equals("Uncompleted", StringComparison.OrdinalIgnoreCase)) option = 0;
            else if (str.Equals("Completed", StringComparison.OrdinalIgnoreCase)) option = 1;

            SQL_condition formCond = this.GetForm_SQLcondition(), filterCond = this.formFilter.FilterCondition;
            SQL_condition cond = new SQL_condition(formCond, ConditionalOperator.And, filterCond);
            this.tsk_vc.Get_viewDT_async(option, cond);

            //Display setting in Grid            
            this.SetGird_sortFilter(this.tsk_vc.ViewData_match_flag);
            UltraGrid_helper.AutoResize(this.main_ultraGrid);
            UltraGrid_helper.ClearCurrentFilters(this.main_ultraGrid);
            this.main_ultraGrid.ActiveRowScrollRegion.Scroll(RowScrollAction.Top);
        }

        private void Init_taskMembers()
        {
            List<ADR_Group> group_list = TaskMemberMaster.GetGroup_list();
            foreach (ADR_Group ag in group_list)
            {
                TreeNode tNode = this.members_treeView.Nodes.Add(ag.GroupID.ToString(), ag.GroupName.Value);
                foreach (ADR_TaskOwner atw in ag.TaskOwner_dic.Values)
                {
                    tNode.Nodes.Add(atw.OwnerSID.Value, atw.OwnerName.Value);
                }
            }
            this.members_treeView.ExpandAll();
        }

        private void Init_countries()
        {
            List<Country> list = CountryMaster.GetAll_countryList();
            foreach (Country cty in list)
            {
                this.cty_itemID_dic[cty.name] = this.cty_checkedListBox.Items.Count;
                this.cty_checkedListBox.Items.Add(cty.name);
            }
        }

        private void SetGird_sortFilter(bool visible)
        {
            this.showAll_button.Visible = !visible;
            UltraGrid_helper.Set_header_sortFilter(this.main_ultraGrid, visible);
            UltraGrid_helper.AutoResize(this.main_ultraGrid);
        }

        private SQL_condition GetForm_SQLcondition()
        {
            HashSet<string> country_hs = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
            foreach (object obj in this.cty_checkedListBox.CheckedItems) country_hs.Add(obj.ToString());            

            HashSet<string> taskID_hs = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
            foreach (object obj in this.taskID_checkedListBox.CheckedItems) taskID_hs.Add(obj.ToString());

            SQL_relation rela0 = null, rela1 = null;
            if (country_hs.Count > 0) rela0 = new SQL_relation("Country", true, country_hs);
            if (taskID_hs.Count > 0) rela1 = new SQL_relation("TaskID", true, taskID_hs);

            if (rela0 == null && rela1 == null) return null;
            return new SQL_condition(rela0, ConditionalOperator.And, rela1);
        }

        /*---------------------------------------------------------------------------------------------------------------------*/

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
