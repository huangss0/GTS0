using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;

using HssCF.Models;

namespace HssCF
{
    public partial class ServerForm : Form
    {
        public ServerForm()
        {
            this.InitializeComponent();
        }

        private Socket serverSK = null;
        public bool Started_flag { get { return this.serverSK != null; } }

        public byte[] fileData_bts = null;
        public File_info fileInfo = null;

        private void SetupServerSocket()
        {
            int port = (int)this.port_numericUpDown.Value;
            this.serverSK = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);            

            string hostName = Dns.GetHostName();
            IPHostEntry host = Dns.GetHostEntry(hostName);
            foreach (IPAddress ipAddr in host.AddressList)
            {
                if (ipAddr.AddressFamily == AddressFamily.InterNetwork) //IPv4
                {
                    IPEndPoint localEP = new IPEndPoint(ipAddr, port);
                    this.serverSK.Bind(localEP);

                    this.info_textBox.AppendText("Listen Started! Local IP Address: " + ipAddr + "\r\n");
                    break;
                }
            }            
        }        

        public void AddInfo_to_UI(string s)
        {
            if (this.IsDisposed) return;

            this.Invoke(
                (MethodInvoker)
                delegate { this.info_textBox.AppendText(s + "\r\n"); }
            );
        }
        /*-----------------------------------------------------------------------------------------*/

        private void StartListen_threadFunc()
        {
            this.serverSK.Listen(10);
            while (!this.IsDisposed)
            {
                Socket clientSK = null;
                try { clientSK = this.serverSK.Accept(); }
                catch { break; }

                ServerSide_handler sh = new ServerSide_handler(clientSK);
                sh.parentForm = this;
                Thread th = new Thread(sh.Run);
                th.Start();
            }
        }

        /*********************************************************************************************/

        private void start_button_Click(object sender, EventArgs e)
        {
            if (this.Started_flag)
            {
                this.serverSK.Close();
                this.serverSK = null;
                this.start_button.Text = "Start";
            }
            else
            {
                this.SetupServerSocket();

                Thread th = new Thread(this.StartListen_threadFunc);
                th.Start();

                this.start_button.Text = "Stop";
            }
        }
               
        private void open_button_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(ofd.FileName, FileMode.Open, FileAccess.Read);
                this.fileData_bts = new byte[fs.Length];
                fs.Read(this.fileData_bts, 0, this.fileData_bts.Length);
                fs.Close();

                this.filePath_textBox.Text = ofd.FileName;

                string fileName = ofd.FileName.Substring(ofd.FileName.LastIndexOf('\\') + 1);
                this.fileInfo = new File_info(fileName, this.fileData_bts.Length);

                File_info fi = new File_info();
                string xml = this.fileInfo.ToXML();
                fi.FromXML(xml);
            }
        }
    }
}
