using System;
using System.Text;
using System.Net;
using System.Net.Sockets;

namespace HssCF
{
    public class ServerSide_handler
    {
        private Socket clientSK = null;
        public ServerForm parentForm = null;

        public ServerSide_handler(Socket sender)
        {
            this.clientSK = sender;
        }

        public void Run()
        {
            if (this.clientSK == null || !this.clientSK.Connected) return;

            IPEndPoint remoteEP = this.clientSK.RemoteEndPoint as IPEndPoint;
            string tempStr = "Connected " + remoteEP.Address + ":" + remoteEP.Port + " at (" + DateTime.Now + ")";
            this.parentForm.AddInfo_to_UI(tempStr);

            byte[] buffer = new byte[1024];
            for (int i = 0; i < buffer.Length; ++i) buffer[i] = 32;

            int count = 0;
            while (true)
            {
                try { count = this.clientSK.Receive(buffer); }
                catch { break; }

                if (!this.clientSK.Connected) break;

                string str_from_client = Encoding.UTF8.GetString(buffer, 0, count);
                tempStr = "(" + remoteEP.Address + ":" + remoteEP.Port + ") said: " + str_from_client;
                this.parentForm.AddInfo_to_UI(tempStr);

                byte[] bts_to_send = this.ParseCmd(str_from_client);

                this.clientSK.Send(bts_to_send);

                if (str_from_client.StartsWith("Get", StringComparison.OrdinalIgnoreCase) && this.parentForm.fileData_bts != null)
                    this.clientSK.Send(this.parentForm.fileData_bts);
            }
        }

        /// <summary>
        /// Return data needed to send back to client based on received command
        /// </summary>
        private byte[] ParseCmd(string cmd)
        {
            byte[] default_bts = Utility.GetCommendBuffer("Bye");
            if (string.IsNullOrEmpty(cmd)) return default_bts;

            if (cmd.StartsWith("Get", StringComparison.OrdinalIgnoreCase))
            {
                if (this.parentForm.fileInfo == null) return default_bts;

                byte[] res = Utility.GetCommendBuffer(this.parentForm.fileInfo.ToXML());
                return res;
            }

            return default_bts;
        }
    }

}
