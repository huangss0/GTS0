using System;

namespace HssUtility.General.Attributes
{
    public class DateTime_attr : I_modelAttr
    {
        private DateTime curr_value = Utility.MinDate, DB_value = Utility.MinDate;
        private bool curr_Null_flag = true, DB_Null_flag = true;

        public DateTime_attr() { }
        public DateTime_attr(DateTime dt)
        {
            this.curr_value = dt;
            this.DB_value = dt;
            this.curr_Null_flag = false;
        }

        public DateTime Value
        {
            get { return this.curr_value; }
            set
            {
                this.curr_Null_flag = false;
                this.curr_value = value;
            }
        }

        public bool Init_from_attr(DateTime_attr attr)
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
            this.DB_value = this.curr_value;
        }

        /// <summary>
        /// 0: default
        /// 1: return empty if null or min date
        /// </summary>
        public string GetValue_in_string(int option)
        {
            if (option == 0) return this.curr_value.ToString();
            else
            {
                if (this.IsNull_flag) return "";
                if (this.Value == Utility.MinDate) return "";
                return this.curr_value.ToString();
            }
        }

        public Type GetRawValueType()
        {
            return typeof(DateTime);
        }
    }
}
