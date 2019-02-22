using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WCF_client
{
    public partial class ClientForm : Form
    {
        public ClientForm()
        {
            InitializeComponent();
        }

        private void conn_button_Click(object sender, EventArgs e)
        {
            TestWCF.TestServiceClient http_client = new TestWCF.TestServiceClient("BasicHttpBinding_ITestService");
            MessageBox.Show(http_client.GetMessage("Steven"));

            TestWCF.TestServiceClient tcp_client = new TestWCF.TestServiceClient("NetTcpBinding_ITestService");
            MessageBox.Show(tcp_client.GetHello().ToString());

            DataTable dt = tcp_client.GetDT(20);
            foreach (DataRow row in dt.Rows) Console.WriteLine(dt.Columns[0].ColumnName + ": " + row[0]);
        }
    }
}
