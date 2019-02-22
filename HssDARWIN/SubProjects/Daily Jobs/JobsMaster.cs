using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Threading;

using HssDARWIN.Models.Log;
using HssUtility.General;
using HssUtility.Debug;

namespace HssDARWIN.SubProjects.Daily_Jobs
{
    public class JobsMaster
    {
        private List<I_runable> run_list = new List<I_runable>();
        private Form parentForm = null;
        private I_hssLog errLog = new EventLog_master("Global (JobMaster)", 0);

        public JobsMaster()
        {
            this.run_list.Add(new InboundData3_SPR());
        }

        public JobsMaster(Form fm)
        {
            this.parentForm = fm;
            this.run_list.Add(new InboundData3_SPR());
        }

        public void Start(bool runIn_WinForm_flag)
        {
            if (runIn_WinForm_flag)
            {
                Thread th = new Thread(this.ThreadRun);
                th.Name = "Job Master by Steven " + DateTime.Now.ToString();
                th.Start();
            }
            else
            {
                foreach (I_runable ira in this.run_list)
                {
                    try { ira.Run(); }
                    catch (Exception ex) { this.errLog.Add("JobsMaster error 1: " + ex.ToString()); }
                }
            }
        }

        private void ThreadRun()
        {
            Random rd = new Random();
            if (this.Wait_for_running(rd.Next(15, 40))) return;//wait for 15-40 seconds before running

            while (true)
            {
                foreach (I_runable ira in this.run_list)
                {
                    try { ira.Run(); }
                    catch (Exception ex) { this.errLog.Add("JobsMaster error 0: " + ex.ToString()); }
                }

                int secondsWait = 43210;
                if (Utility.Is_DWRIN_admin()) secondsWait = rd.Next(3, 5) * 60;//re-run every 30-45 minutes
                else secondsWait = rd.Next(90, 120) * 60;//re-run every 90-120 minutes
                
                if (this.Wait_for_running(secondsWait)) return;                 
            }//End of while
        }

        /// <summary>
        /// Let current thread to wait for some time
        /// </summary>
        /// <param name="seconds">wait time in seconds</param>
        /// <returns>if application has terminated</returns>
        private bool Wait_for_running(int seconds)
        {
            int count = 10 * seconds;
            while (true)
            {
                if (this.parentForm == null || this.parentForm.IsDisposed) return true;
                else
                {
                    Thread.Sleep(100);
                    if (--count < 0) break;
                }
            }

            return false;
        }
    }
}
