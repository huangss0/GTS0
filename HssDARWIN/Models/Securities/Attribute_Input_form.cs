using System;
using System.Collections.Generic;
using System.Windows.Forms;

using HssDARWIN.Models.Countries;

namespace HssDARWIN.Models.Securities
{
    public partial class Attribute_Input_form : Form
    {
        public Attribute_Input_form(string secName, string cusip)
        {
            this.InitializeComponent();

            this.info_label.Text = "Please input Ticker for Security CUSIP: " + cusip;
            this.sec_label.Text = "Security Name: " + secName;

            List<Security> sec_list = SecurityMaster.Get_secList_cusip(cusip);
            foreach (Security sec in sec_list) this.values_comboBox.Items.Add(sec.TickerSymbol.Value);
            if (this.values_comboBox.Items.Count > 0) this.values_comboBox.SelectedIndex = 0;
        }

        public Attribute_Input_form(Security sec, string attrName)
        {
            this.InitializeComponent();

            if (sec == null)
            {
                this.info_label.Text = "No Security Info";
                return;
            }

            this.info_label.Text = "Please input "+ attrName + " for Security CUSIP: " + sec.CUSIP.Value;
            this.sec_label.Text = "Security Name: " + sec.Name.Value;

            List<Country> list = CountryMaster.GetAll_countryList();
            foreach(Country cty in list) this.values_comboBox.Items.Add(cty.name);
        }

        private string user_input_str = null;
        public string UserInputValue { get { return this.user_input_str; } }

        private void ok_button_Click(object sender, EventArgs e)
        {
            this.user_input_str = this.values_comboBox.Text;
            this.Close();
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
