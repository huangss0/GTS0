using System;

using HssUtility.General.Attributes;

namespace HssUtility.Forms.Attribute
{
    public partial class StrAttr_UserControl : Abs_Attr_UserControl
    {
        public StrAttr_UserControl()
        {
            this.InitializeComponent();
        }

        public String_attr strAttr = null;
        public Int_attr intAttr = null;
        public Decimal_attr decAttr = null;
        public Long_attr longAttr = null;

        public StrAttr_UserControl(string name, String_attr attr, bool readOnly = false)
        {
            this.InitializeComponent();
            this.name_label.Text = name;
            this.strAttr = attr;

            this.Refresh_Data();
            this.ReadOnly_flag = readOnly;
        }
        public StrAttr_UserControl(string name, Int_attr attr, bool readOnly = false)
        {
            this.InitializeComponent();
            this.name_label.Text = name;
            this.intAttr = attr;

            this.Refresh_Data();
            this.ReadOnly_flag = readOnly;
        }
        public StrAttr_UserControl(string name, Decimal_attr attr, bool readOnly = false)
        {
            this.InitializeComponent();
            this.name_label.Text = name;
            this.decAttr = attr;

            this.Refresh_Data();
            this.ReadOnly_flag = readOnly;
        }
        public StrAttr_UserControl(string name, Long_attr attr, bool readOnly = false)
        {
            this.InitializeComponent();
            this.name_label.Text = name;
            this.longAttr = attr;

            this.Refresh_Data();
            this.ReadOnly_flag = readOnly;
        }

        /******************************************************************************************************************************/

        public bool ReadOnly_flag = false;
        private bool nullValue_flag = true;
        public Utility.Void_NoParams_delegate ValueChangedEvent = Utility.Void_NoParams_emptyFunc;

        public override void Commit()
        {
            if (this.nullValue_flag) return;

            string text = this.value_textBox.Text;

            if (this.strAttr != null) this.strAttr.Value = text;
            if (this.intAttr != null)
            {
                int temp = -1;
                if (int.TryParse(text, out temp)) this.intAttr.Value = temp;
            }
            if (this.decAttr != null)
            {
                decimal temp = -1;
                if (decimal.TryParse(text, out temp)) this.decAttr.Value = temp;
            }
            if (this.longAttr != null)
            {
                long temp = -1;
                if (long.TryParse(text, out temp)) this.longAttr.Value = temp;
            }
        }

        public override void Refresh_Data()
        {
            if (this.strAttr != null) this.value_textBox.Text = this.strAttr.Value;
            else if (this.intAttr != null && !this.intAttr.IsNull_flag) this.value_textBox.Text = this.intAttr.Value.ToString();
            else if (this.decAttr != null && !this.decAttr.IsNull_flag) this.value_textBox.Text = this.decAttr.Value.ToString();
            else if (this.longAttr != null && !this.longAttr.IsNull_flag) this.value_textBox.Text = this.longAttr.Value.ToString();
            else this.value_textBox.Text = "";
        }

        private void value_textBox_MouseDoubleClick(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (strAttr == null) return;

            ViewTextForm vtf = new ViewTextForm();
            vtf.NotePad_SetData(this.value_textBox.Text);
            vtf.ShowDialog();

            this.value_textBox.Text = vtf.NewText_str;
        }

        private void value_textBox_TextChanged(object sender, EventArgs e)
        {
            if (this.ReadOnly_flag)
            {
                if (this.strAttr != null && !this.strAttr.IsNull_flag) this.value_textBox.Text = this.strAttr.Value;
                else if (this.intAttr != null && !this.intAttr.IsNull_flag) this.value_textBox.Text = this.intAttr.Value.ToString();
                else if (this.decAttr != null && !this.decAttr.IsNull_flag) this.value_textBox.Text = this.decAttr.Value.ToString();
                else if (this.longAttr != null && !this.longAttr.IsNull_flag) this.value_textBox.Text = this.longAttr.Value.ToString();
            }
            else this.nullValue_flag = false;
        }
    }
}
