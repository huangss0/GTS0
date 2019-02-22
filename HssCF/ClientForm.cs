using System;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;

namespace HssCF
{
    public partial class ClientForm : Form
    {
        public ClientForm()
        {
            this.InitializeComponent();
        }

        private Socket senderSK = null;
        public bool Connected_flag
        {
            get
            {
                if (this.senderSK == null) return false;
                return this.senderSK.Connected;
            }
        }

        private bool Connect_to_server()
        {
            IPAddress receiverIP = null;
            if (!IPAddress.TryParse(this.IP_textBox.Text, out receiverIP))
            {
                MessageBox.Show("SenderForm error 0: IP parsing error");
                return false;
            }

            int port = (int)this.port_numericUpDown.Value;
            IPEndPoint receiverEP = new IPEndPoint(receiverIP, port);

            this.senderSK = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            try { this.senderSK.Connect(receiverEP); }
            catch (Exception ex)
            {
                Console.WriteLine("SenderForm error 1: " + ex.Message);
                return false;
            }

            return true;
        }

        public void AddInfo_to_UI(string s)
        {
            if (this.IsDisposed) return;

            this.Invoke(
                (MethodInvoker)
                delegate { this.info_textBox.AppendText(s + "\r\n"); }
            );
        }
        /*------------------------------------------------------------------------------------------------------------*/

        private void connect_button_Click(object sender, EventArgs e)
        {
            if (this.Connected_flag)
            {
                this.senderSK.Close();
                this.connect_button.Text = "Connect";
            }
            else
            {
                if (this.Connect_to_server())
                {
                    this.connect_button.Text = "DisConnect";
                    this.msg_toSend_textBox.Text = "GetFile " + DateTime.Now.ToLongTimeString();

                    ClientSide_handler csh = new ClientSide_handler(this.senderSK);
                    csh.parentForm = this;

                    Thread th = new Thread(csh.Run);
                    th.SetApartmentState(ApartmentState.STA);
                    th.Start();
                }
            }
        }

        private void send_button_Click(object sender, EventArgs e)
        {
            if (this.Connected_flag) this.senderSK.Send(Encoding.UTF8.GetBytes(this.msg_toSend_textBox.Text));            
            else MessageBox.Show("Not connected to Receiver");
        }
    }
}
