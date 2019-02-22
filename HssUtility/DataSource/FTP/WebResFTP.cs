using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using HssUtility.Debug;

namespace HssUtility.DataSource.FTP
{
    public class WebResFTP : I_FileSource
    {
        private I_hssLog errorLog = null;
        private string ftpURL = null, ftp_userName = null, ftp_pwd = null;

        public bool Login(string serverAddr, string userID, string pwd)
        {
            if (!serverAddr.StartsWith("ftp", StringComparison.OrdinalIgnoreCase)) this.ftpURL = "ftp://" + serverAddr;
            else this.ftpURL = serverAddr;

            this.ftp_userName = userID;
            this.ftp_pwd = pwd;

            return true;
        }

        public List<File_info> GetFilesList(string dir)
        {
            List<File_info> res = new List<File_info>();

            FtpWebResponse response = this.TryGetResponse(WebRequestMethods.Ftp.ListDirectoryDetails, null);
            if (response == null) return res;
            StreamReader reader = new StreamReader(response.GetResponseStream());

            string s = null;
            while ((s = reader.ReadLine()) != null)
            {
                /*temp*/
                Console.WriteLine(s);
                string[] arr = s.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                //res.Add(arr[arr.Length - 1]);
                File_info fi = new File_info(arr[arr.Length - 1]);
                res.Add(fi);
            }

            response.Close();
            return res;
        }

        public bool Delete(string remotePath)
        {
            FtpWebResponse response = this.TryGetResponse(WebRequestMethods.Ftp.DeleteFile, remotePath);

            if (response == null) return false;
            else
            {
                response.Close();
                return true;
            }
        }

        public long DownloadFile(string reomteFileName, Stream fs_for_save)
        {
            FtpWebResponse response = this.TryGetResponse(WebRequestMethods.Ftp.DownloadFile, reomteFileName);

            if (response == null) return -1;

            Stream rmSm = response.GetResponseStream();
            if (rmSm == null) return -2;

            long startPos = fs_for_save.Position;
            rmSm.CopyTo(fs_for_save);

            return fs_for_save.Position - startPos;
        }

        public long UploadFile(string remoteFileName, Stream fs_to_upload)
        {
            if (fs_to_upload == null || string.IsNullOrEmpty(remoteFileName)) return -1;

            FtpWebRequest FtpRequest;

            string URL = this.ftpURL + '/' + remoteFileName;
            FtpRequest = (FtpWebRequest)FtpWebRequest.Create(URL);
            FtpRequest.UseBinary = true;

            FtpRequest.Method = WebRequestMethods.Ftp.UploadFile;
            if (this.ftp_userName != null && this.ftp_pwd != null) FtpRequest.Credentials = new NetworkCredential(this.ftp_userName, this.ftp_pwd);

            Stream ftp_st = null;
            try { ftp_st = FtpRequest.GetRequestStream(); }
            catch { return -2; }

            fs_to_upload.CopyTo(ftp_st);
            ftp_st.Close();

            return fs_to_upload.Length;
        }

        private FtpWebResponse TryGetResponse(string method, string fileName)
        {
            if (this.ftpURL == null) return null;

            string URL = this.ftpURL;
            if (!string.IsNullOrEmpty(fileName)) URL = this.ftpURL + "/" + fileName;

            FtpWebRequest request = (FtpWebRequest)FtpWebRequest.Create(URL);
            if (this.ftp_userName != null && this.ftp_pwd != null) request.Credentials = new NetworkCredential(this.ftp_userName, this.ftp_pwd);
            request.Proxy = null;
            request.Method = method;
            request.UseBinary = true;

            try { return (FtpWebResponse)request.GetResponse(); }
            catch (Exception ex)
            {
                if (this.errorLog != null) this.errorLog.Add("WebResFTP error 0", ex.ToString());
                return null;
            }
        }

        public void SetErrorLog(I_hssLog eLog)
        {
            this.errorLog = eLog;
        }
    }
}
