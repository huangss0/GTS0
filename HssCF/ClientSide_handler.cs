using System;
using System.Windows.Forms;
using System.Text;
using System.Net.Sockets;
using System.IO;

using HssCF.Models;

namespace HssCF
{
    public class ClientSide_handler
    {
        private Socket connSocket = null;
        public ClientForm parentForm = null;

        public ClientSide_handler(Socket sk)
        {
            this.connSocket = sk;
        }

        public void Run()
        {            
            File_info fi = null;

            while (true)
            {  
                if (fi == null)
                {
                    string cmd = this.ReceiveCmd();
                    if (cmd == null) break;

                    this.parentForm.AddInfo_to_UI("Received: " + cmd);

                    if (!cmd.StartsWith("Bye", StringComparison.OrdinalIgnoreCase))
                    {
                        fi = new File_info();
                        fi.FromXML(cmd);
                    }
                }
                else
                {
                    bool flag = this.ReceiveFile(fi);
                    if (!flag) break;
                    fi = null;
                }
            }
        }

        private string ReceiveCmd()
        {
            byte[] cmd_buffer = Utility.GetBlankBuffer();
            int count = 0;

            try { count = this.connSocket.Receive(cmd_buffer); }
            catch
            {
                Console.WriteLine("ClientSide_handler error 0: receive error");
                return null;
            }

            string cmd = Encoding.UTF8.GetString(cmd_buffer, 0, count);
            return cmd.TrimEnd();
        }

        private bool ReceiveFile(File_info fi)
        {
            byte[] fileBuffer = new byte[fi.length];
            int totalReceived = 0;

            while (totalReceived < fi.length)
            {
                try
                {
                    int count = this.connSocket.Receive(fileBuffer);
                    totalReceived += count;
                }
                catch
                {
                    Console.WriteLine("ClientSide_handler error 1: receive error");
                    return false;
                }
            }

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.FileName = fi.name;

            int dotIndex = fi.name.LastIndexOf('.');
            string format = fi.name.Substring(dotIndex + 1);
            sfd.Filter = format + "|*." + format;

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(sfd.FileName, FileMode.Create);
                fs.Write(fileBuffer, 0, totalReceived);
                fs.Close();
                this.parentForm.AddInfo_to_UI("---> Done, receive file size: " + totalReceived);
            }

            return true;
        }
    }
}
