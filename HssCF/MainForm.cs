using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HssCF
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            this.InitializeComponent();
        }

        private void client_button_Click(object sender, EventArgs e)
        {
            ClientForm sf = new ClientForm();
            sf.Show();
        }

        private void server_button_Click(object sender, EventArgs e)
        {
            ServerForm rf = new ServerForm();
            rf.Show();
        }
    }
}
