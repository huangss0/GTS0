using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

using HssUtility.General;

namespace HssUtility.Text.XML
{
    public class Hss_XML_reader
    {
        public const int BufferSize = 1024;

        private HashSet<char> blankChars_hs = new HashSet<char>();//initialized in constructor
        private HashSet<char> quoteChars_hs = new HashSet<char>();
        public Hss_XML_reader()
        {
            this.blankChars_hs.Add('\r');
            this.blankChars_hs.Add('\n');
            this.blankChars_hs.Add('\t');
            this.blankChars_hs.Add(' ');

            this.quoteChars_hs.Add('"');
            this.quoteChars_hs.Add('\'');
        }

        /// <summary>
        /// Reset all pointers and states
        /// </summary>
        private void Reset()
        {
            this.ParsingFinished = false;
            this.count = 0;
            this.pt = 0;

            this.element_st.Clear();
            this.ParsingState = XML_ParseState.OutElement;
            this.ElementType = XML_ElementType.None;
            this.sb.Clear();
            this.element_st.Push(new Hss_XML_obj("root"));

            //clear all data source
            this.XBRL_data_bytes = null;
            this.XBRL_data_str = null;
            this.XBRL_data_stream = null;
        }

        private Stream XBRL_data_stream = null;//data from stream
        private byte[] buffer = new byte[Hss_XML_reader.BufferSize];

        private string XBRL_data_str = null;//data in a string
        private byte[] XBRL_data_bytes = null;//data in a byte array

        private int pt = 0; //pointer if the buffer array
        private int count = 0; //count of data in buffer

        private char currChar;//current char in during parsing
        private bool ParsingFinished = true;//indicate if there's more data to parse

        private Stack<Hss_XML_obj> element_st = new Stack<Hss_XML_obj>();
        private XML_ParseState ParsingState = XML_ParseState.OutElement;
        private XML_ElementType ElementType = XML_ElementType.None;
        StringBuilder sb = new StringBuilder();

        private int ReadNext_byte()
        {
            if (this.XBRL_data_stream != null) //next byte from stream
            {
                if (this.pt >= this.count)
                {
                    this.count = this.XBRL_data_stream.Read(buffer, 0, Hss_XML_reader.BufferSize);
                    this.pt = 0;
                }

                if (this.pt < this.count) return this.buffer[this.pt++];
            }
            else if (this.XBRL_data_bytes != null) //next byte from byte array
            {
                if (this.pt < this.XBRL_data_bytes.Length) return this.XBRL_data_bytes[this.pt++];
            }

            this.ParsingFinished = true;
            return -1;
        }

        private bool ReadNext_char()
        {
            if (this.XBRL_data_str != null)//read next charater from string
            {
                if (this.pt < this.XBRL_data_str.Length)
                {
                    this.currChar = this.XBRL_data_str[this.pt++];
                    return true;
                }
                else
                {
                    this.ParsingFinished = true;
                    return false;
                }
            }
            else //read next charater from stream or byte array
            {
                int val = this.ReadNext_byte();

                if (val >= 0 && val <= 127)
                {
                    this.currChar = (char)val;
                    return true;
                }
                else if (val >= 192 && val <= 223)//two bytes
                {
                    int val2 = this.ReadNext_byte();
                    int first = (val & 31) << 6, second = val2 & 63;

                    int code = first | second;
                    this.currChar = (char)code;

                    return true;
                }
                else if (val >= 224 && val <= 239)//three bytes
                {
                    int val2 = this.ReadNext_byte(), val3 = this.ReadNext_byte();
                    int first = (val & 15) << 12, second = (val2 & 63) << 6, third = val3 & 63;

                    int code = first | second | third;
                    this.currChar = (char)code;

                    return true;
                }
                else
                {
                    this.ParsingFinished = true;
                    return false;
                }
            }
        }

        public Hss_XML_obj Read(Stream stm)
        {
            if (stm == null) return null;
            this.Reset();
            this.XBRL_data_stream = stm;
            return this.Read();
        }

        public Hss_XML_obj Read(string str)
        {
            if (str == null) return null;
            this.Reset();
            this.XBRL_data_str = str;
            return this.Read();
        }

        public Hss_XML_obj Read(byte[] arr)
        {
            if (arr == null) return null;
            this.Reset();
            this.XBRL_data_bytes = arr;
            return this.Read();
        }

        private Hss_XML_obj Read()
        {
            while (!this.ParsingFinished)
            {
                if (this.ParsingState == XML_ParseState.OutElement) this.Parse_OutElement();
                else if (this.ParsingState == XML_ParseState.ElementStart) this.Parse_ElementStart();
                else if (this.ParsingState == XML_ParseState.ElementName) this.Parse_ElementName();
                else if (this.ParsingState == XML_ParseState.InElement) this.Parse_InElement();
                else if (this.ParsingState == XML_ParseState.AttrName) this.Parse_AttrName();
                else if (this.ParsingState == XML_ParseState.AfterAttrName) this.Parse_AfterAttrName();
                else if (this.ParsingState == XML_ParseState.AttrValue) this.Parse_AttrValue();
                else if (this.ParsingState == XML_ParseState.ElementEnd) this.Parse_ElementEnd();
                else if (this.ParsingState == XML_ParseState.CommentValue) this.Parse_CommentValue();
            }

            if (this.element_st.Count > 0) return this.element_st.Peek();
            else return null;
        }

        private void Parse_OutElement()
        {
            while (this.ReadNext_char())
            {
                if (this.currChar == '<')
                {
                    this.ParsingState = XML_ParseState.ElementStart;
                    break;
                }
                else if (this.blankChars_hs.Contains(this.currChar))
                {
                    this.sb.Append(' ');
                }
                else this.sb.Append(this.currChar);
            }
        }

        private void Parse_ElementStart()
        {
            if (!this.ReadNext_char()) return;

            if (this.currChar == '?')
            {
                this.sb.Clear();
                this.ParsingState = XML_ParseState.ElementName;
                this.ElementType = XML_ElementType.Declare;
            }
            else if (this.currChar == '!')
            {
                this.sb.Clear();
                this.ParsingState = XML_ParseState.CommentValue;
                this.ElementType = XML_ElementType.Comment;
            }
            else if (this.currChar == '>')
            {
                Hss_XML_obj xo = this.element_st.Peek();
                xo.Add_obj(new Hss_XML_obj(null, this.ElementType));

                this.ParsingState = XML_ParseState.OutElement;
            }
            else if (this.currChar == '/')
            {
                Hss_XML_obj xo = this.element_st.Pop();
                xo.value = HssStr.SafeXML_to_ori(this.sb.ToString().Trim());
                this.sb.Clear();

                this.element_st.Peek().Add_obj(xo);
                //xo.Show();//test output

                this.ParsingState = XML_ParseState.ElementEnd;
            }
            else
            {
                this.sb.Clear();
                this.sb.Append(this.currChar);

                this.ParsingState = XML_ParseState.ElementName;
                this.ElementType = XML_ElementType.Normal;
            }
        }

        private void Parse_ElementEnd()
        {
            while (this.ReadNext_char())
            {
                if (this.currChar == '>')
                {
                    this.ParsingState = XML_ParseState.OutElement;
                    break;
                }
            }
        }

        private void Parse_ElementName()
        {
            while (this.ReadNext_char())
            {
                if (this.blankChars_hs.Contains(this.currChar))
                {
                    string eleName = HssStr.SafeXML_to_ori(this.sb.ToString());
                    this.element_st.Push(new Hss_XML_obj(eleName, this.ElementType));
                    this.sb.Clear();

                    this.ParsingState = XML_ParseState.InElement;
                    break;
                }
                else if (this.currChar == '>')
                {
                    string eleName = HssStr.SafeXML_to_ori(this.sb.ToString());
                    this.element_st.Push(new Hss_XML_obj(eleName, this.ElementType));
                    this.sb.Clear();
                    this.ParsingState = XML_ParseState.OutElement;
                    break;
                }
                else
                {
                    this.sb.Append(this.currChar);
                }
            }
        }

        private void Parse_InElement()
        {
            while (this.ReadNext_char())
            {
                if (this.blankChars_hs.Contains(this.currChar)) continue;
                else if (this.currChar == '>')
                {
                    this.ParsingState = XML_ParseState.OutElement;
                }
                else if (this.currChar == '/' || this.currChar == '?')
                {
                    Hss_XML_obj xo = this.element_st.Pop();
                    this.element_st.Peek().Add_obj(xo);
                    //xo.Show();//test output

                    this.ParsingState = XML_ParseState.OutElement;
                }
                else
                {
                    this.sb.Clear();
                    this.sb.Append(this.currChar);
                    this.ParsingState = XML_ParseState.AttrName;
                }

                break;
            }
        }

        private void Parse_AttrName()
        {
            while (this.ReadNext_char())
            {
                if (this.blankChars_hs.Contains(this.currChar) || this.currChar == '=')
                {
                    Hss_XML_obj xo = this.element_st.Peek();
                    xo.SetTempKey(this.sb.ToString());

                    this.sb.Clear();
                    this.ParsingState = XML_ParseState.AfterAttrName;
                    break;
                }
                else if (this.currChar == '>')
                {
                    this.sb.Clear();
                    this.ParsingState = XML_ParseState.OutElement;
                    break;
                }
                else
                {
                    this.sb.Append(this.currChar);
                }
            }
        }

        private void Parse_AfterAttrName()
        {
            while (this.ReadNext_char())
            {
                if (this.blankChars_hs.Contains(this.currChar) || this.currChar == '=') continue;
                else if (this.quoteChars_hs.Contains(this.currChar))
                {
                    this.sb.Clear();
                    this.ParsingState = XML_ParseState.AttrValue;
                    this.value_hasQuote_flag = true;
                }
                else
                {
                    this.sb.Clear();
                    this.sb.Append(this.currChar);
                    this.ParsingState = XML_ParseState.AttrValue;
                    this.value_hasQuote_flag = false;
                }

                break;
            }
        }

        private bool value_hasQuote_flag = false;

        private void Parse_AttrValue()
        {
            while (this.ReadNext_char())
            {
                if ((this.quoteChars_hs.Contains(this.currChar) && this.value_hasQuote_flag) ||
                    (this.blankChars_hs.Contains(this.currChar) && !this.value_hasQuote_flag))
                {
                    Hss_XML_obj xo = this.element_st.Peek();
                    xo.SetTempValue(this.sb.ToString());

                    this.sb.Clear();
                    this.ParsingState = XML_ParseState.InElement;
                    break;
                }
                else
                {
                    this.sb.Append(this.currChar);
                }
            }
        }

        private void Parse_CommentValue()
        {
            char c1 = ' ', c2 = ' ';
            while (this.ReadNext_char())
            {
                if (this.currChar == '>')
                {
                    if (c1 == '-' && c2 == '-')
                    {
                        string comment = sb.ToString();
                        if (comment.Length >= 4) comment = comment.Substring(2, comment.Length - 4);

                        Hss_XML_obj xo = new Hss_XML_obj("$Comment$", XML_ElementType.Comment);
                        xo.value = comment;
                        this.element_st.Peek().Add_obj(xo);

                        this.sb.Clear();
                        this.ParsingState = XML_ParseState.OutElement;
                        break;
                    }
                }

                c1 = c2;
                c2 = this.currChar;
                this.sb.Append(this.currChar);
            }
        }
    }
}
