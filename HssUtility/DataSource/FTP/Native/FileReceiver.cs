using System;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Text;
using System.Threading;

namespace HssUtility.DataSource.FTP.Native
{
    class FileReceiver
    {
        private Socket localSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        public Stream receiver_stream = null;
        private Thread mainThread = null;

        private bool run_flag = false;
        private int dataPort = 2667, timeoutSeconds = 60, bufferSize = 1024;

        public void Receive(Stream rec_sm)
        {
            this.receiver_stream = rec_sm;

            if (this.mainThread == null) this.mainThread = new Thread(this.Listen);

            if (this.mainThread.IsAlive)
            {
                Console.WriteLine("FileReceiver error 0: thread running now");
                return;
            }
            else this.mainThread.Start();
        }

        public bool Running { get { return this.run_flag; } }

        public void Listen()
        {
            this.Listen(this.receiver_stream);
        }

        public void Listen(Stream recSM)
        {
            if (recSM == null) return;

            IPEndPoint localEndPoint = new IPEndPoint(IPAddress.Any, this.dataPort);
            localSocket.Bind(localEndPoint);
            localSocket.Listen(10);
            this.run_flag = true;

            while (this.run_flag)
            {
                Socket remoteSocket = null;
                try
                {
                    Console.WriteLine("FileReceiver status 0: waiting for incomming connection");
                    remoteSocket = localSocket.Accept();
                    Console.WriteLine("FileReceiver status 1: connected");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("FileReceiver error 1: " + ex.ToString());
                    this.run_flag = false;
                    break;
                }

                byte[] buffer = new byte[this.bufferSize];
                DateTime timeout = DateTime.Now.AddSeconds(this.timeoutSeconds);

                while (timeout > DateTime.Now)
                {
                    int recNum = remoteSocket.Receive(buffer, buffer.Length, SocketFlags.None);
                    recSM.Write(buffer, 0, recNum);

                    if (recNum < buffer.Length) break;
                }

                this.run_flag = false;//one time receive data
            }

            byte[] rec_data = new byte[recSM.Length];
            recSM.Seek(0, SeekOrigin.Begin);
            recSM.Read(rec_data, 0, rec_data.Length);
            System.Windows.Forms.MessageBox.Show("FileReceiver status 2: \r\n"+Encoding.UTF8.GetString(rec_data));
        }

        public void Close()
        {
            this.run_flag = false;
            if (this.localSocket.Connected)
            {
                this.localSocket.Shutdown(SocketShutdown.Both);
                this.localSocket.Close();
            }
        }
    }
}
