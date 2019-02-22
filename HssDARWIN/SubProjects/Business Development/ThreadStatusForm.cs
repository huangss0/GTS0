using System;
using System.Threading;
using System.Windows.Forms;

using HssUtility.General;
using HssUtility.Debug;

namespace HssDARWIN.SubProjects.Business_Development
{
    public partial class ThreadStatusForm : Form
    {
        public HssThreadInfo_log statusInfo = new HssThreadInfo_log();

        public ThreadStatusForm()
        {
            InitializeComponent();
        }

        private void ThreadStatusForm_Load(object sender, EventArgs e)
        {
            Thread th = new Thread(this.Run);
            th.Start();
        }

        private void Run()
        {
            if (this.statusInfo == null) return;

            while (!this.IsDisposed && this.statusInfo.IsActive)
            {
                this.Auto_checkRunningTime();
                this.Invoke((MethodInvoker)this.UpdateUI);
                Thread.Sleep(500);
            }

            if (!this.IsDisposed)
            {
                this.Auto_checkRunningTime();
                this.Invoke((MethodInvoker)this.UpdateUI);
            }
        }

        private string previousStatus = null;
        private DateTime previousStat_time = DateTime.MinValue;

        private void UpdateUI()
        {
            this.status_label.Text = this.statusInfo.status;
            this.recordNum_label.Text = this.statusInfo.recordNum.ToString();

            this.info_textBox.Text = null;
            foreach (string s in this.statusInfo.additional_info_list)
            {
                this.info_textBox.AppendText(s);
                this.info_textBox.AppendText(HssStr.WinNextLine);
            }
        }

        private void Auto_checkRunningTime()
        {
            if (this.previousStatus != null && this.previousStatus.Equals(this.statusInfo.status, StringComparison.OrdinalIgnoreCase)) return;

            DateTime currTime = DateTime.Now;            

            if (this.previousStatus != null)
            {
                TimeSpan ts = currTime - this.previousStat_time;
                string msg = "[Status]: " + this.previousStatus + " (" + ts.TotalSeconds + " seconds)";
                this.statusInfo.additional_info_list.Add(msg);
            }

            this.previousStatus = this.statusInfo.status;
            this.previousStat_time = currTime;
        }
    }
}
