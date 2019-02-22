using System;
using System.Windows.Forms;

using HssDARWIN.Models.Dividends;

namespace HssDARWIN.Models.XBRL.DvdXBRL
{
    public partial class DvdForm : Form
    {
        public DvdForm(Dividend dvd)
        {
            this.InitializeComponent();
            this.dvd = dvd;
        }

        private Dividend dvd = null;

        private void Form1_Load(object sender, EventArgs e)
        {
            if (dvd == null) this.msg_label.Text = "No dividend info";
            else
            {
                string msg = "Dividend " + this.dvd.DividendIndex + " is already created for the same CUSIP and Record Date\n"
                           + "Create new Dividend or update existing?";
                this.msg_label.Text = msg;
            }
        }


    }
}
