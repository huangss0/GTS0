using System;

namespace HssUtility.General.Attributes
{
    public class String_attr : I_modelAttr
    {
        public readonly bool CaseSensitive = false;

        private string curr_value = null, DB_value = null;
        private bool curr_Null_flag = true, DB_Null_flag = true;

        public String_attr(bool caseSensitive = false)
        {
            this.CaseSensitive = caseSensitive;
        }
        public String_attr(string val, bool caseSensitive = false)
        {
            this.curr_value = val;
            this.DB_value = val;
            this.CaseSensitive = caseSensitive;
            this.curr_Null_flag = false;
        }

        public string Value
        {
            get { return this.curr_value; }
            set
            {
                this.curr_value = value;
                this.curr_Null_flag = (value == null);
            }
        }

        public bool Init_from_attr(String_attr attr)
        {
            if (attr == null) return false;

            this.IsNull_flag = attr.IsNull_flag;
            this.curr_value = attr.Value;
            return true;
        }

        public bool IsNull_flag
        {
            get { return this.curr_Null_flag; }
            set
            {
                this.curr_Null_flag = value;
                if (value) this.curr_value = null;
            }
        }

        public bool ValueChanged
        {
            get
            {
                if (this.curr_Null_flag != this.DB_Null_flag) return true;

                if (this.curr_value == null)
                {
                    if (this.DB_value == null) return false;
                    else return true;
                }
                else
                {
                    if (this.DB_value == null) return true;
                    else
                    {
                        if (this.CaseSensitive) return !this.curr_value.Equals(this.DB_value);
                        else return !this.curr_value.Equals(this.DB_value, StringComparison.OrdinalIgnoreCase);
                    }
                }
            }
        }

        public void SyncWithDB()
        {
            this.DB_Null_flag = this.curr_Null_flag;
            this.DB_value = this.curr_value;
        }

        public bool IsValueEmpty { get { return string.IsNullOrEmpty(this.curr_value); } }

        /// <summary>
        /// 0: default
        /// 1: return "" if null
        /// </summary>
        public string GetValue_in_string(int option)
        {
            if (option == 1) return this.curr_value == null ? "" : this.curr_value;

            return this.curr_value;
        }

        public Type GetRawValueType()
        {
            return typeof(string);
        }
    }
}
