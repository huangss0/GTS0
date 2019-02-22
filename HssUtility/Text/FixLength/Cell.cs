using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HssUtility.Text.FixLength
{
    public class Cell
    {
        public string Value
        {
            get
            {
                if (this.length < 0) return null;

                if (this.oriVal_str.Length > this.length) return this.oriVal_str.Substring(0, this.length);

                string extraStr = new string(this.fill_char, this.length - this.oriVal_str.Length);
                if (leftJustified) return this.oriVal_str + extraStr;
                else return extraStr + this.oriVal_str;
            }
        }

        public bool leftJustified = false;
        public char fill_char = ' ';
        public int length = -1;

        private string oriVal_str = null;

        public Cell(object obj, bool leftJustified = false, char fill_char = ' ')
        {
            if (obj != null)
            {
                this.oriVal_str = obj.ToString();
                this.length = this.oriVal_str.Length;
            }
            this.leftJustified = leftJustified;
            this.fill_char = fill_char;
        }

        public Cell(object obj, int len, bool leftJustified = false, char fill_char = ' ')
        {
            this.length = len;
            if (obj != null) this.oriVal_str = obj.ToString();

            this.leftJustified = leftJustified;
            this.fill_char = fill_char;
        }

        public Cell(int i, int len, bool leftJustified = false, char fill_char = '0')
        {
            this.oriVal_str = i.ToString();
            this.length = len;

            this.leftJustified = leftJustified;
            this.fill_char = fill_char;
        }

        public Cell(char c, int len, bool leftJustified = false, char fill_char = ' ')
        {
            this.oriVal_str = c.ToString();
            this.length = len;

            this.leftJustified = leftJustified;
            this.fill_char = fill_char;
        }

        public bool SetOriVal(int val)
        {
            this.oriVal_str = val.ToString();
            return true;
        }

        public bool SetOriVal(string s)
        {
            if (s == null) this.oriVal_str = "";
            return true;
        }
    }
}
