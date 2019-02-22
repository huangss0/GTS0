using System;
using System.Windows.Forms;

using HssUtility.General;
using HssDARWIN.Models.Tasks.Task21;

namespace HssDARWIN.SubProjects.TaskMgr.Forms.Task21
{
    public partial class Form_task21_detail : Form
    {
        public Form_task21_detail(int secID, int detID = -1)
        {
            this.InitializeComponent();
            this.SecurityID = secID;
            this.DetailID = detID;

            this.secID_label.Text = "Security #:" + secID;
            Task21_security sec21 = new Task21_security(this.DetailID);
            if (sec21.Init_from_DB())
            {
                this.taskName_textBox.Text = sec21.TaskName.Value;
                this.status_comboBox.Text = sec21.Status.Value;
            }
        }

        public readonly int DetailID = -1, SecurityID = -1;
        public HssUtility.Utility.Void_NoParams_delegate Refresh_UI = HssUtility.Utility.Void_NoParams_emptyFunc;

        private void save_button_Click(object sender, EventArgs e)
        {
            Task21_security detail = new Task21_security(this.DetailID);
            bool existFlag = detail.Init_from_DB();
            if (!existFlag)
            {
                detail = new Task21_security();
                detail.SecurityID.Value = this.SecurityID;
            }

            detail.TaskName.Value = this.taskName_textBox.Text;
            detail.Status.Value = Helper_hssStatus.Str_to_Status(this.status_comboBox.Text).ToString();

            bool successFlag = false;
            if (existFlag) successFlag = detail.Update_to_DB();
            else successFlag = detail.Insert_to_DB();

            if (successFlag)
            {
                Task21_secMaster.Reset();
                this.Refresh_UI();
            }
            this.Close();
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
