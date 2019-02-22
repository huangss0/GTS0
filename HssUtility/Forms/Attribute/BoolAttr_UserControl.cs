using System;
using HssUtility.General.Attributes;

namespace HssUtility.Forms.Attribute
{
    public partial class BoolAttr_UserControl : Abs_Attr_UserControl
    {
        public BoolAttr_UserControl()
        {
            this.InitializeComponent();
        }
        public BoolAttr_UserControl(string name, Bool_attr attr, bool readOnly = false)
        {
            this.InitializeComponent();
            this.value_checkBox.Text = name;
            this.boolAttr = attr;

            this.Refresh_Data();
            this.ReadOnly_flag = readOnly;
        }

        public Bool_attr boolAttr = null;
        public Utility.Void_NoParams_delegate ValueChangedEvent = Utility.Void_NoParams_emptyFunc;
        private bool nullValue_flag = true;
        public bool ReadOnly_flag = false;

        public override void Commit()
        {
            if (this.boolAttr != null && !this.nullValue_flag)
            {
                this.boolAttr.Value = this.value_checkBox.Checked;
                if (this.boolAttr.ValueChanged) this.ValueChangedEvent();
            }
        }

        public override void Refresh_Data()
        {
            if (this.boolAttr != null)
            {
                this.nullValue_flag = this.boolAttr.IsNull_flag;
                this.value_checkBox.Checked = this.boolAttr.Value;
            }
        }

        private void value_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (this.ReadOnly_flag)
            {
                if (this.boolAttr == null) this.value_checkBox.Checked = false;
                else this.value_checkBox.Checked = this.boolAttr.Value;
            }
            else this.nullValue_flag = false;
        }
    }
}
