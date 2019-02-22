using System;
using System.Collections.Generic;
using System.IO;

using Rebex.Net;
using HssUtility.Debug;

namespace HssUtility.DataSource.FTP
{
    public class RebexFTP : I_FileSource
    {
        private Ftp ftp = new Ftp();
        private string ftpURL = null, ftp_userName = null, ftp_pwd = null;

        public I_hssLog errorLog = null;

        public RebexFTP(FileSource_transferType transferType = FileSource_transferType.Default)
        {
            if (transferType == FileSource_transferType.Ascii) this.ftp.TransferType = FtpTransferType.Ascii;
            else if (transferType == FileSource_transferType.Binary) this.ftp.TransferType = FtpTransferType.Binary;
        }

        public bool Login(string serverAddr, string userID, string pwd)
        {
            if (!serverAddr.StartsWith("ftp", StringComparison.OrdinalIgnoreCase)) this.ftpURL = "ftp://" + serverAddr;
            else this.ftpURL = serverAddr;

            this.ftp_userName = userID;
            this.ftp_pwd = pwd;

            string conn_rtnInfo = null, login_rtnInfo = null;//for informational purpose
            try
            {
                conn_rtnInfo = this.ftp.Connect(this.ftpURL);
                login_rtnInfo = this.ftp.Login(this.ftp_userName, this.ftp_pwd);

                this.ftp.Passive = false;
            }
            catch (Exception ex)
            {
                if (this.errorLog != null) this.errorLog.Add("RebexFTPsource error 0", "Login failed:\n" + ex.ToString());
                return false;
            }

            return true;
        }

        public List<File_info> GetFilesList(string dir)
        {
            List<File_info> res = new List<File_info>();
            if (!this.ftp.IsConnected) return res;
            if (!string.IsNullOrEmpty(dir))
            {
                try { this.ftp.ChangeDirectory(dir); }
                catch (Exception ex)
                {
                    if (this.errorLog != null) this.errorLog.Add("RebexFTPsource error 2", "Directory error:\n" + ex.ToString());
                    return res;
                }
            }

            FtpItemCollection fi_coll = null;

            try { fi_coll = this.ftp.GetList(); }
            catch (Exception ex)
            {
                if (this.errorLog != null) this.errorLog.Add("RebexFTPsource error 1", "GetList failed:\n" + ex.ToString());
                return res;
            }

            foreach (FtpItem item in fi_coll)
            {
                File_info fi = new File_info(item.Name);
                res.Add(fi);

                fi.mod_time = item.Modified;
                fi.size = item.Length;
            }

            return res;
        }

        public bool Delete(string remotePath)
        {
            if (!this.ftp.IsConnected) return false;

            try { this.ftp.Delete(remotePath, Rebex.IO.TraversalMode.Recursive); }
            catch { return false; }

            return true;
        }

        public long DownloadFile(string remoteFileName, Stream fs_for_save)
        {
            if (!this.ftp.IsConnected) return -2;
            if (fs_for_save == null || string.IsNullOrEmpty(remoteFileName)) return -1;

            long len = -1;
            try
            {
                len = this.ftp.GetFile(remoteFileName, fs_for_save);
                //this.ftp.GetFile(remoteFileName, @"C:\Users\SHuang\Desktop\FTP\DTCC\local.txt");
            }
            catch (Exception ex)
            {
                if (this.errorLog != null) this.errorLog.Add("RebexFTPsource error 1", "Download failed:\n" + ex.ToString());
                return len;
            }

            return len;
        }

        public long UploadFile(string remoteFileName, Stream fs_to_upload)
        {
            if (!this.ftp.IsConnected) return -2;
            if (fs_to_upload == null || string.IsNullOrEmpty(remoteFileName)) return -1;

            long len = -1;
            try { len = this.ftp.PutFile(fs_to_upload, remoteFileName); }
            catch (Exception ex)
            {
                if (this.errorLog != null) this.errorLog.Add("RebexFTPsource error 2", "Upload failed:\n" + ex.ToString());
                return len;
            }

            return len;
        }

        public void SetErrorLog(I_hssLog eLog)
        {
            this.errorLog = eLog;
        }
    }
}
