using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HssUtility.Service.JSON
{
    public class JSON_obj : HssUtility.Service.I_RESTful
    {
        private Dictionary<string, JSON_obj> attr_dic = new Dictionary<string, JSON_obj>(StringComparer.OrdinalIgnoreCase);

        public readonly JSobj_type JStype;
        public readonly string str_val = null;
        public readonly decimal num_val = 0;
        public readonly List<JSON_obj> obj_list = new List<JSON_obj>();

        public JSON_obj()
        {
            this.JStype = JSobj_type.Object;
        }
        public JSON_obj(string str)
        {
            this.str_val = str;
            this.JStype = JSobj_type.String;
        }
        public JSON_obj(decimal val)
        {
            this.num_val = val;
            this.JStype = JSobj_type.Number;
        }
        public JSON_obj(List<JSON_obj> list)
        {
            this.obj_list = list;
            this.JStype = JSobj_type.List;
        }

        public bool AddAttr(string name, string str)
        {
            return this.AddAttr(name, new JSON_obj(str));
        }

        public bool AddAttr(string name, decimal num)
        {
            return this.AddAttr(name, new JSON_obj(num));
        }

        public bool AddAttr(string name, List<JSON_obj> list)
        {
            return this.AddAttr(name, new JSON_obj(list));
        }

        /// <summary>
        /// Add new attribute to attribute dictionary
        /// </summary>
        /// <param name="name">name of the attribute</param>
        /// <param name="obj_val">attribute value</param>
        public bool AddAttr(string name, JSON_obj obj_val)
        {
            if (name == null) return false;

            this.attr_dic[name] = obj_val;
            return true;
        }

        public JSON_obj this[string attrName]
        {
            get
            {
                if (attrName == null) return null;

                if (this.attr_dic.ContainsKey(attrName)) return attr_dic[attrName];
                else return null;
            }
        }

        public void ClearAttr()
        {
            this.attr_dic.Clear();
        }

        public bool Read_from_str(string str)
        {
            return this.Read_from_str(str, true);
        }

        /// <summary>
        /// Construct this object from string
        /// </summary>
        public bool Read_from_str(string str_json, bool transformQuote)
        {
            if (str_json == null) return false;
            else this.ClearAttr();

            JSON_parser parser = new JSON_parser();
            parser.str = str_json;

            ParseState currState = ParseState.None;
            Stack<StackItem> stack = new Stack<StackItem>();

            while ((currState = parser.Next()) != ParseState.None)
            {
                /*Fot testing*/
                //if (currState == ParseState.Value_str) Console.WriteLine("state:" + currState + "    str:" + parser.val_str);
                //else if (currState == ParseState.Value_num) Console.WriteLine("state:" + currState + "    num:" + parser.val_num);
                //else if (currState == ParseState.Between) continue;
                //else Console.WriteLine("state:" + currState);

                if (currState == ParseState.Between) continue;
                StackItem item = new StackItem(currState, parser.val_str, parser.val_num);

                if (item.state == ParseState.Obj_begin)
                {
                    if (stack.Count < 1) item.jsObj = this;
                    else item.jsObj = new JSON_obj();

                    stack.Push(item);
                }
                else if (item.state == ParseState.List_start)
                {
                    if (stack.Count < 1) return false;

                    if (stack.Peek().state == ParseState.Obj_begin) return false;
                    else
                    {
                        item.jsObj = new JSON_obj(new List<JSON_obj>());
                        stack.Push(item);
                    }
                }
                else if (item.state == ParseState.Value_num)
                {
                    if (stack.Count < 1) return false;

                    if (stack.Peek().state == ParseState.Obj_begin) stack.Push(item);
                    else
                    {
                        string key = null;
                        if (stack.Peek().state == ParseState.Value_str)
                        {
                            key = stack.Pop().val_str;
                            stack.Peek().jsObj.AddAttr(key, new JSON_obj(item.val_num));
                        }
                        else if (stack.Peek().state == ParseState.Value_num)
                        {
                            key = stack.Pop().val_num.ToString();
                            stack.Peek().jsObj.AddAttr(key, new JSON_obj(item.val_num));
                        }
                        else if (stack.Peek().state == ParseState.List_start)
                        {
                            stack.Peek().jsObj.obj_list.Add(new JSON_obj(item.val_num));
                        }
                    }
                }
                else if (item.state == ParseState.Value_str)
                {
                    if (stack.Count < 1) continue;

                    if (stack.Peek().state == ParseState.Obj_begin) stack.Push(item);
                    else
                    {
                        if (stack.Peek().state == ParseState.Value_str)
                        {
                            string key = this.ToOriStr_JSON(stack.Pop().val_str, transformQuote);
                            string val = this.ToOriStr_JSON(item.val_str, transformQuote);
                            stack.Peek().jsObj.AddAttr(key, new JSON_obj(val));
                        }
                        else if (stack.Peek().state == ParseState.Value_num)
                        {
                            string key = stack.Pop().val_num.ToString();
                            string val = this.ToOriStr_JSON(item.val_str, transformQuote);
                            stack.Peek().jsObj.AddAttr(key, new JSON_obj(val));
                        }
                        else if (stack.Peek().state == ParseState.List_start)
                        {
                            string val = this.ToOriStr_JSON(item.val_str, transformQuote);
                            stack.Peek().jsObj.obj_list.Add(new JSON_obj(val));
                        }
                    }
                }
                else if (item.state == ParseState.Obj_end)
                {
                    if (stack.Count < 1) return false;

                    while (stack.Peek().state != ParseState.Obj_begin) stack.Pop();
                    if (stack.Count == 1) break;//find root JSON_obj

                    string key = null;
                    JSON_obj value_obj = stack.Pop().jsObj;//wrap current obj into a JSON_obj

                    if (stack.Peek().state == ParseState.Value_str)
                    {
                        key = stack.Pop().val_str;
                        stack.Peek().jsObj.AddAttr(key, value_obj);
                    }
                    else if (stack.Peek().state == ParseState.Value_num)
                    {
                        key = stack.Pop().val_num.ToString();
                        stack.Peek().jsObj.AddAttr(key, value_obj);
                    }
                    else if (stack.Peek().state == ParseState.List_start)
                    {
                        stack.Peek().jsObj.obj_list.Add(value_obj);
                    }
                }
                else if (item.state == ParseState.List_end)
                {
                    if (stack.Count < 1) return false;

                    while (stack.Peek().state != ParseState.List_start) stack.Pop();

                    string key = null;
                    JSON_obj value_obj = stack.Pop().jsObj;//wrap current list into a JSON object
                    if (stack.Count < 1) return false;

                    if (stack.Peek().state == ParseState.Value_str)
                    {
                        key = stack.Pop().val_str;
                        stack.Peek().jsObj.AddAttr(key, value_obj);
                    }
                    else if (stack.Peek().state == ParseState.Value_num)
                    {
                        key = stack.Pop().val_num.ToString();
                        stack.Peek().jsObj.AddAttr(key, value_obj);
                    }
                    else if (stack.Peek().state == ParseState.List_start)
                    {
                        stack.Peek().jsObj.obj_list.Add(value_obj);
                    }
                }
            }

            return true;
        }

        public string Convert_to_str()
        {
            return this.Convert_to_str(true);
        }

        /// <summary>
        /// Convert this object to string
        /// </summary>
        /// <param name="transformQuote">Indicate if " is transformed</param>
        public string Convert_to_str(bool transformQuote)
        {
            StringBuilder sb = new StringBuilder();

            if (this.JStype == JSobj_type.String)
            {
                string temp = this.ToLegelStr_JSON(this.str_val, transformQuote);
                sb.Append('\"').Append(temp).Append('\"');
            }
            else if (this.JStype == JSobj_type.Number) sb.Append(this.num_val);
            else if (this.JStype == JSobj_type.List)
            {
                sb.Append("[ ");
                foreach (JSON_obj obj in this.obj_list) sb.Append(' ').Append(obj.Convert_to_str(transformQuote)).Append(',');

                int lastIndex = sb.Length - 1;
                if (sb[lastIndex] == ',') sb.Remove(lastIndex, 1);
                sb.Append(" ]");
            }
            else if (this.JStype == JSobj_type.Object)
            {
                sb.Append("{ ");
                foreach (KeyValuePair<string, JSON_obj> pair in this.attr_dic)
                {
                    sb.Append("\"").Append(this.ToLegelStr_JSON(pair.Key, transformQuote)).Append("\":");
                    sb.Append(pair.Value.Convert_to_str(transformQuote)).Append(" ");
                }
                sb.Append('}');
            }

            return sb.ToString();
        }        

        private string ToLegelStr_JSON(string s, bool transformQuote)
        {
            if (!transformQuote || s == null) return s;

            string res = s.Replace("&", "&01");//deal with key char
            res = res.Replace("\"", "&02");

            return res;
        }

        private string ToOriStr_JSON(string s, bool transformQuote)
        {
            if (!transformQuote || s == null) return s;

            string res = s.Replace("&02", "\"");
            res = res.Replace("&01", "&");//deal with key char

            return res;
        }
    }

    class StackItem
    {
        public readonly ParseState state = ParseState.None;
        public readonly string val_str = null;
        public readonly decimal val_num = 0;

        public JSON_obj jsObj = null;

        public StackItem(ParseState ps, string s, decimal dc)
        {
            this.state = ps;
            this.val_str = s;
            this.val_num = dc;
        }
    }
}
