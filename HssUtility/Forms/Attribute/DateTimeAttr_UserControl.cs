using System;
using System.Windows.Forms;
using System.Drawing;

using HssUtility.General.Attributes;

namespace HssUtility.Forms.Attribute
{
    public partial class DateTimeAttr_UserControl : Abs_Attr_UserControl
    {
        public DateTimeAttr_UserControl()
        {
            this.InitializeComponent();
        }
        public DateTimeAttr_UserControl(string name, DateTime_attr attr, bool readOnly = false)
        {
            this.InitializeComponent();
            this.name_label.Text = name;
            this.dtAttr = attr;

            this.Refresh_Data();
            this.ReadOnly_flag = readOnly;
        }

        public Utility.Void_NoParams_delegate ValueChangedEvent = Utility.Void_NoParams_emptyFunc;
        public DateTime_attr dtAttr = null;
        public bool ReadOnly_flag = false;
        private bool nullValue_flag = true;

        public override void Commit()
        {
            if (this.dtAttr != null)
            {
                DateTime dt = this.value_dateTimePicker.Value;
                if (dt > Utility.MinDate) this.dtAttr.Value = dt;
            }
        }

        public override void Refresh_Data()
        {
            if (this.dtAttr != null)
            {
                this.nullValue_flag = this.dtAttr.IsNull_flag;
                this.value_dateTimePicker.Value = this.dtAttr.Value;
            }
        }
        /*---------------------------------------------------------------------------------------------------------------------------------*/

        private void value_dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if (this.ReadOnly_flag)
            {
                if (this.dtAttr == null) this.value_dateTimePicker.Value = Utility.MinDate;
                else this.value_dateTimePicker.Value = this.dtAttr.Value;
            }
            else this.nullValue_flag = false;
        }
    }
}
