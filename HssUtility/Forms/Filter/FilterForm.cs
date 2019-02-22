using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using HssUtility.SQLserver;
using HssUtility.General;

namespace HssUtility.Forms.Filter
{
    public partial class FilterForm : Form
    {
        public FilterForm(DataTable dt)
        {
            this.InitializeComponent();

            this.main_dt = dt;
            this.AddFilter_userControl();
        }

        private DataTable main_dt = null;
        private List<Filter_UserControl> ctl_list = new List<Filter_UserControl>();

        public SQL_condition FilterCondition { get { return this.cond; } }
        private SQL_condition cond = null;

        /****************************************************************************************************************/
        private void CreateSqlCondition()
        {
            this.cond = null;
            ConditionalOperator copt = this.and_radioButton.Checked ? ConditionalOperator.And : ConditionalOperator.Or;

            foreach (Filter_UserControl fuc in this.ctl_list)
            {
                SQL_relation rela = fuc.SQL_Rela;
                if (rela == null) continue;

                if (this.cond == null) this.cond = new SQL_condition(rela);
                else this.cond = new SQL_condition(this.cond, copt, rela);
            }

            this.Close();
        }

        private void AddFilter_userControl()
        {
            Filter_UserControl fuc = new Filter_UserControl();
            fuc.Init_from_DT(this.main_dt);
            fuc.Refresh_parentUI = this.CreateSqlCondition;
            this.main_flowLayoutPanel.Controls.Add(fuc);
            this.ctl_list.Add(fuc);
        }

        public void ClearAll()
        {
            this.ctl_list.Clear();
            this.main_flowLayoutPanel.Controls.Clear();
            this.cond = null;
        }
        /*--------------------------------------------------------------------------------------------------------------*/

        private void add_button_Click(object sender, EventArgs e)
        {
            this.AddFilter_userControl();
        }

        private void ok_button_Click(object sender, EventArgs e)
        {
            this.CreateSqlCondition();
        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            this.ClearAll();
        }
    }
}
