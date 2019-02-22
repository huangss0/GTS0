using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HssUtility.Service.JSON
{
    public class JSON_parser
    {
        public string str = "";
        public int pointer = 0;

        public string val_str = null;
        public decimal val_num = 0;

        private ParseState currState = ParseState.Between;
        private bool withQuote_flag = false;

        public ParseState Next()
        {
            if (this.currState == ParseState.Obj_begin || this.currState == ParseState.Obj_end
                || this.currState == ParseState.List_start || this.currState == ParseState.List_end
                || this.currState == ParseState.Between)
            {
                ParseState temp_ps = this.currState;
                this.currState = this.Parse_between();
                return temp_ps;
            }
            else if (this.currState == ParseState.Value_str)
            {
                this.currState = this.Parse_value();
                return ParseState.Value_str;
            }
            else if (this.currState == ParseState.Value_num)
            {
                this.currState = this.Parse_value();

                if (decimal.TryParse(this.val_str, out this.val_num)) return ParseState.Value_num;
                else return ParseState.Value_str;
            }            

            return ParseState.None;
        }

        private ParseState Parse_between()
        {
            while (this.pointer < str.Length)
            {
                char c = this.str[this.pointer];

                if (c == '[')
                {
                    ++this.pointer;
                    return ParseState.List_start;
                }
                else if (c == ']')
                {
                    ++this.pointer;
                    return ParseState.List_end;
                }
                else if (c == '{')
                {
                    ++this.pointer;
                    return ParseState.Obj_begin;
                }
                else if (c == '}')
                {
                    ++this.pointer;
                    return ParseState.Obj_end;
                }
                else if (c == '\"')
                {
                    ++this.pointer;
                    this.withQuote_flag = true;
                    return ParseState.Value_str;
                }
                else if (JSON_helper.IsNum(c) || c == '-')
                {
                    this.withQuote_flag = false;
                    return ParseState.Value_num;
                }
                else if (JSON_helper.IsLetter(c))
                {
                    this.withQuote_flag = false;
                    return ParseState.Value_str;
                }
                else ++this.pointer;
            }

            return ParseState.None;
        }

        private ParseState Parse_value()
        {
            StringBuilder sb = new StringBuilder();
            while (this.pointer < str.Length)
            {
                char c = this.str[this.pointer];

                if (this.withQuote_flag)
                {
                    if (c == '\"')
                    {
                        ++this.pointer;
                        this.val_str = sb.ToString();
                        return ParseState.Between;
                    }
                    else
                    {
                        sb.Append(c);
                        ++this.pointer;
                    }
                }
                else
                {
                    if (JSON_helper.IsLetter(c))
                    {
                        sb.Append(c);
                        ++this.pointer;
                    }
                    else
                    {
                        this.val_str = sb.ToString();
                        return ParseState.Between;
                    }
                }
            }

            if (sb.Length > 0)
            {
                this.val_str = sb.ToString();
                return ParseState.Obj_end;
            }

            return ParseState.None;
        }
    }

    public enum ParseState
    {
        None = -1,

        Obj_begin = 0,
        Obj_end = 1,

        Between = 5,

        Value_str = 7,
        Value_num = 8,

        List_start = 17,
        List_end = 19,
    }
}
