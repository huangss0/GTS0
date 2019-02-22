using System;
using System.Collections.Generic;
using System.Threading;
using System.IO;
using System.Windows.Forms;

using HssUtility.Debug;
using HssUtility.DataSource;
using HssUtility.General;
using HssDARWIN.SubProjects.SPR_Report;
using HssDARWIN.Models.Log;

namespace HssDARWIN.SubProjects.Daily_Jobs
{
    public class InboundData3_SPR : I_runable
    {
        private I_FileSource remoteSource = new HssUtility.DataSource.FTP.RebexFTP(FileSource_transferType.Ascii);
        private bool ftpLoggedIn_flag = false;
        private I_hssLog errLog = new EventLog_master("Inbound Data", 3);

        /// <summary>
        /// Implement "I_runable", check before connecting to DTCC
        /// </summary>
        public void Run()
        {
            if (!this.PreConnect_check()) return;

            this.errLog.Add("Start running InboundData3_SPR");
            long downloaded_len = this.GetFile_from_DTCC();

            if (downloaded_len >= 0)
            {
                this.errLog.Add("InboundData3_SPR success (download file size: " + downloaded_len + ")");
                if (this.hdj != null) this.hdj.UpdateRecordLock(false, true);
            }
            else
            {
                this.errLog.Add("InboundData3_SPR failed");
                if (this.hdj != null) this.hdj.UpdateRecordLock(false, false);
            }
        }

        Hss_DailyJobs hdj = null;

        private bool PreConnect_check()
        {
            DateTime currTime = DateTime.Now;

            //run Monday to Friday
            if (currTime.DayOfWeek == DayOfWeek.Saturday || currTime.DayOfWeek == DayOfWeek.Sunday) return false;

            //run between 8am to 8pm for Admin
            if (currTime.Hour < 8 || currTime.Hour > 20) return false;


            this.hdj = Hss_DailyJobs_master.GetJob_class_id("Inbound Data", 3);
            if (this.hdj == null) return false;
            else this.notes = this.hdj.Notes.Value;

            if (HssDateTime.CompareDateTime_day(currTime, this.hdj.LastRunAt.Value) <= 0)
            {
                Console.WriteLine("---> InboundData3_SPR info 0: Task previous run at " + this.hdj.LastRunAt.Value);
                return false;
            }

            return true;
        }

        /// <summary>
        /// Login and Grab file from DTCC
        /// </summary>
        /// <returns></returns>
        public long GetFile_from_DTCC()
        {
            this.Login();//connect to FTP
            if (!this.ftpLoggedIn_flag) return -1;

            this.CreateFile();//generate and upload request file

            long downloaded_len = 0;
            for (int i = 0; i < 3; ++i)
            {
                for (int j = 0; j < 30; ++j)
                {
                    if (Utility.Is_DWRIN_admin()) Console.WriteLine("/*Wait " + j + "*/");
                    Thread.Sleep(1000);
                }

                downloaded_len = this.DownloadFile();
                if (downloaded_len >= 0) break;
            }

            return downloaded_len;
        }

        /*---------------------------------------------------------------------------------------------------------*/
        private string notes = null;//Password info is in notes

        private void Login()
        {
            if (this.ftpLoggedIn_flag) return;

            string url = "207.45.34.1";//Login credentials for SPR
            string uID = "M0475201", pwd = "GTShss03";

            if (this.notes != null)
            {
                int start = this.notes.IndexOf('('), end = this.notes.IndexOf(')');
                if (start >= 0 && start < end) pwd = this.notes.Substring(start + 1, end - start - 1);
            }

            this.ftpLoggedIn_flag = this.remoteSource.Login(url, uID, pwd);
            if (this.ftpLoggedIn_flag) this.errLog.Add("Success login", url);
            else this.errLog.Add("Fail in login (" + pwd + ")");
        }

        private bool CreateFile()
        {
            if (!this.ftpLoggedIn_flag) return false;

            DTC_request_file df = new DTC_request_file();
            df.up_down_ReqTP = FTPrequestType.Input;
            df.DTCfunc = DTCfunction.OSOLPR;
            string upFile_name = "'" + df.Get_FTP_fileName() + "'";

            df.up_down_ReqTP = FTPrequestType.Output;
            this.downFile_name = "'" + df.Get_FTP_fileName() + "'";

            Stream sm = df.Get_FTP_fileContent_inStream();
            long len = this.remoteSource.UploadFile(upFile_name, sm);

            if (len >= 0)
            {
                this.errLog.Add("Upload success", "(size: " + len + ")");
                return true;
            }
            else
            {
                this.errLog.Add("Upload fail", len.ToString());
                return false;
            }
        }

        private string downFile_name = null;

        private long DownloadFile()
        {
            if (!this.ftpLoggedIn_flag) return -2;
            if (string.IsNullOrEmpty(this.downFile_name)) return -1;

            MemoryStream ms = new MemoryStream();
            long len = this.remoteSource.DownloadFile(this.downFile_name, ms);

            if (len < 0) return -2;
            else ms.Seek(0, SeekOrigin.Begin);

            byte[] fileData_bytes = new byte[len];
            ms.Read(fileData_bytes, 0, fileData_bytes.Length);

            //split and save file to DB
            List<SPR_file> sf_list = SPR_fileControl.SplitRawFile(fileData_bytes);
            foreach (SPR_file sf in sf_list)
            {
                sf.FileName.Value = this.downFile_name;
                this.errLog.Add("CUSIP: " + sf.CUSIP.Value + " " + (sf.Insert_to_DB() ? "Saved" : "Fail in saving"));
            }

            if (sf_list.Count < 1)//save no result file as rejected
            {
                SPR_file sf = new SPR_file();
                sf.SetStatus(HssStatus.Rejected);
                sf.FileName.Value = this.downFile_name;
                sf.FileBinary = fileData_bytes;
                this.errLog.Add("No Data file saved", sf.Insert_to_DB().ToString());
            }

            return len;
        }
    }
}
