using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using HssUtility.Debug;

namespace HssUtility.DataSource.FTP.Native
{
    public class Native_FTP : I_FileSource
    {
        private I_hssLog errorLog = null;

        private Socket cmdSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        private int cmdPort = 21, conn_retryTimes = 10;
        private bool connected_flag = false;

        public bool Login(string serverAddr, string userID, string pwd)
        {
            this.cmdSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            /*Initial connection to remote server*/
            try { this.cmdSocket.Connect(serverAddr, this.cmdPort); }
            catch (Exception ex)
            {
                if (this.errorLog != null) this.errorLog.Add("Native_FTP error 0", "can't connect to server\r\n" + ex.ToString());
                return this.connected_flag = false;
            }

            FTP_response res_init = this.ReadMsg_fromServer();
            if (res_init.statusCode != 220) //220 Service ready for new user.
            {
                if (this.errorLog != null) this.errorLog.Add("Native_FTP error 1", res_init.message);
                return this.connected_flag = false;
            }

            /*Send user ID*/
            FTP_response res_uid = this.SendCmd_toServer("USER " + userID);
            for (int i = 0; i < this.conn_retryTimes && res_uid.statusCode == 220; ++i) res_uid = this.SendCmd_toServer("USER " + userID);
            if (res_uid.statusCode != 331) //331 User name okay, need password.
            {
                if (this.errorLog != null) this.errorLog.Add("Native_FTP error 2", res_uid.message);
                return this.connected_flag = false;
            }

            /*Send password*/
            FTP_response res_pwd = this.SendCmd_toServer("PASS " + pwd);
            for (int i = 0; i < this.conn_retryTimes && res_pwd.statusCode == 331; ++i) res_pwd = this.SendCmd_toServer("PASS " + pwd);
            if (res_pwd.statusCode != 230) //230 User logged in, proceed. Logged out if appropriate.
            {
                if (this.errorLog != null) this.errorLog.Add("Native_FTP error 3", res_pwd.message);
                return this.connected_flag = false;
            }

            //FTP_response res_tp = this.SendCmd_toServer("TYPE I");//binary type

            return this.connected_flag = true;

        }

        public bool Delete(string remotePath)
        {
            throw new NotImplementedException();
        }

        public long DownloadFile(string reomteFileName, Stream fs_for_save)
        {
            if (fs_for_save == null) return -2;
            if (!this.connected_flag) return -3;

            FileReceiver fr = new FileReceiver();
            fr.receiver_stream = fs_for_save;
            fr.Receive(fs_for_save);

            System.Windows.Forms.MessageBox.Show("Start listen to port");

            IPEndPoint localIP = (IPEndPoint)this.cmdSocket.LocalEndPoint;
            string localIP_str = localIP.Address.ToString();

            FTP_response res_port = this.SendCmd_toServer("PORT " + localIP_str.Replace('.', ',') + ",10,107");            
            FTP_response res_retr = this.SendCmd_toServer("RETR " + reomteFileName);

            return -1;
        }

        public List<File_info> GetFilesList(string dir)
        {
            throw new NotImplementedException();
        }

        public long UploadFile(string remoteFileName, Stream fs_to_upload)
        {
            throw new NotImplementedException();
        }

        public void SetErrorLog(I_hssLog eLog)
        {
            this.errorLog = eLog;
        }

        /*********************************************************************************************************************/

        private FTP_response ReadMsg_fromServer()
        {
            if (!this.cmdSocket.Connected) return new FTP_response(null);

            byte[] buffer = new byte[1024];
            StringBuilder sb = new StringBuilder();

            while (true)
            {
                int recNum = this.cmdSocket.Receive(buffer, buffer.Length, SocketFlags.None);
                sb.Append(Encoding.UTF8.GetString(buffer, 0, recNum));

                if (recNum < buffer.Length) break;
            }

            string msg = sb.ToString();
            /*For testing*/
            Console.WriteLine("--> Server said: " + msg.Replace("\r\n", ""));

            return new FTP_response(msg);
        }

        private FTP_response SendCmd_toServer(string cmd_str)
        {
            if (!this.cmdSocket.Connected) return new FTP_response(null);

            Byte[] buffer = Encoding.ASCII.GetBytes(cmd_str + "\r\n");
            this.cmdSocket.Send(buffer, buffer.Length, SocketFlags.None);
            return this.ReadMsg_fromServer();
        }

        private void Reset()
        {
            if (this.cmdSocket.Connected)
            {
                this.cmdSocket.Shutdown(SocketShutdown.Both);
                this.cmdSocket.Close();
            }
        }
    }
}
