using System;

namespace HssUtility.General.Attributes
{
    public class Decimal_attr : I_modelAttr
    {
        private decimal curr_value = -1, DB_value = -1;
        private bool curr_Null_flag = true, DB_Null_flag = true;

        public Decimal_attr() { }
        public Decimal_attr(decimal val)
        {
            this.curr_value = val;
            this.DB_value = val;
            this.curr_Null_flag = false;
        }

        public decimal Value
        {
            get { return this.curr_value; }
            set
            {
                this.curr_Null_flag = false;
                this.curr_value = value;
            }
        }

        public bool Init_from_attr(Decimal_attr attr)
        {
            if (attr == null) return false;

            this.IsNull_flag = attr.IsNull_flag;
            this.curr_value = attr.Value;
            return true;
        }

        public bool IsNull_flag
        {
            get { return this.curr_Null_flag; }
            set { this.curr_Null_flag = value; }
        }

        public bool ValueChanged
        {
            get
            {
                if (this.curr_Null_flag != this.DB_Null_flag) return true;
                return this.curr_value != this.DB_value;
            }
        }

        public void SyncWithDB()
        {
            this.DB_Null_flag = this.curr_Null_flag;
            this.DB_value = this.Value;
        }

        public string GetValue_in_string(int option)
        {
            return this.curr_value.ToString();
        }

        public Type GetRawValueType()
        {
            return typeof(decimal);
        }
    }
}
