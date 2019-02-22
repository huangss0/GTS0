using System;
using System.Windows.Forms;

using HssDARWIN.Models.Tasks;

namespace HssDARWIN.SubProjects.TaskMgr.Forms.Task17
{
    public partial class Form_task17 : Form
    {
        public Form_task17()
        {
            this.InitializeComponent();
        }

        private Task_Detail tsk_record = new Task_Detail();
        public HssUtility.Utility.Void_NoParams_delegate Refresh_parentUI = HssUtility.Utility.Void_NoParams_emptyFunc;

        private void save_button_Click(object sender, EventArgs e)
        {
            this.tsk_record.TaskID.Value = 17;

            this.tsk_record.TaskName.Value = this.taskName_textBox.Text;
            this.tsk_record.Notes.Value = this.notes_textBox.Text;
            this.tsk_record.Completed.Value = this.complete_checkBox.Checked;

            bool flag = this.tsk_record.Insert_to_DB();
            this.Refresh_parentUI();

            MessageBox.Show("Saved! " + flag);
            this.Close();
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
