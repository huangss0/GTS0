using System;
using System.Collections.Generic;
using System.Text;

using HssUtility.General;

namespace HssUtility.Text.XML
{
    public class Hss_XML_obj
    {
        public string name = null, value = null;
        public XML_ElementType Type = XML_ElementType.None;

        private Dictionary<string, string> attr_dic = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        private Dictionary<string, List<Hss_XML_obj>> XMLobj_dic = new Dictionary<string, List<Hss_XML_obj>>(StringComparer.OrdinalIgnoreCase);

        public Hss_XML_obj(string name)
        {
            this.name = name;
        }
        public Hss_XML_obj(string name, XML_ElementType tp)
        {
            this.name = name;
            this.Type = tp;
        }

        /**************************************XML attributes***************************************************/
        public void Add_attr(string key, string value)
        {
            if (key == null) return;
            this.attr_dic[key] = value;
        }

        public bool ContainsAttrKey(string key)
        {
            if (key == null) return false;
            return this.attr_dic.ContainsKey(key);
        }

        public string Get_attr(string key)
        {
            if (this.ContainsAttrKey(key)) return this.attr_dic[key];
            else return null;
        }
        /*^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^*/

        public string ToXML()
        {
            StringBuilder sb = new StringBuilder("<" + this.name);

            foreach (KeyValuePair<string, string> pair in this.attr_dic)
            {
                sb.Append(' ').Append(pair.Key);
                sb.Append("='").Append(pair.Value).Append("'");
            }
            sb.Append('>');

            if (!string.IsNullOrEmpty(this.value)) sb.Append(this.value);
            else
            {
                foreach (List<Hss_XML_obj> xo_list in this.XMLobj_dic.Values)
                {
                    foreach (Hss_XML_obj xo in xo_list)
                    {
                        sb.Append(HssStr.WinNextLine).Append(xo.ToXML());
                    }
                }

                if (this.XMLobj_dic.Count > 0) sb.Append(HssStr.WinNextLine);
            }

            sb.Append("</" + this.name + ">");
            return sb.ToString();
        }

        /**********************************Add and Find XML objects************************************************/
        public void Add_obj(Hss_XML_obj obj)
        {
            if (obj == null) return;

            if (!this.XMLobj_dic.ContainsKey(obj.name))//add to dictionary
            {
                List<Hss_XML_obj> list = new List<Hss_XML_obj>();
                this.XMLobj_dic[obj.name] = list;
            }
            this.XMLobj_dic[obj.name].Add(obj);
        }

        /* 
        * <Root>
        *   <A>0</A>
        *   <A>1</A>
        *   <B>2</B>
        * </Root>
        */
        /// <summary>
        /// Example above, get 0,1,2
        /// </summary>
        public List<Hss_XML_obj> Get_all_obj()
        {
            List<Hss_XML_obj> all_list = new List<Hss_XML_obj>();
            foreach (List<Hss_XML_obj> list in this.XMLobj_dic.Values) all_list.AddRange(list);
            return all_list;
        }

        /// <summary>
        /// Example above: if "A", get 0; if "B" get 2
        /// </summary>
        public Hss_XML_obj Get_obj(params string[] name_arr)
        {
            List<Hss_XML_obj> list = this.Get_obj_list(name_arr);
            if (list.Count > 0) return list[0];
            else return null;
        }

        /// <summary>
        /// Example above: if "A", get 0,1; if "B" get 2
        /// </summary>
        public List<Hss_XML_obj> Get_obj_list(params string[] name_arr)
        {
            Hss_XML_obj curr_obj = this;

            for (int i = 0; i < name_arr.Length - 1; ++i)
            {
                string name = name_arr[i];
                if (curr_obj.XMLobj_dic.ContainsKey(name)) curr_obj = curr_obj.XMLobj_dic[name][0];                
                else return new List<Hss_XML_obj>();
            }

            if (name_arr.Length > 0)
            {
                string name = name_arr[name_arr.Length - 1];
                if (curr_obj.XMLobj_dic.ContainsKey(name)) return curr_obj.XMLobj_dic[name];
            }

            return new List<Hss_XML_obj>();
        }

        /// <summary>
        /// Depth first search for an XML_obj
        /// </summary>
        public Hss_XML_obj Search_obj(string name)
        {
            if (string.IsNullOrEmpty(name)) return null;

            if (this.XMLobj_dic.ContainsKey(name)) //if found return the first one
            {
                List<Hss_XML_obj> list =  this.XMLobj_dic[name];
                if (list.Count > 0) return list[0];
            }

            foreach (List<Hss_XML_obj> list in this.XMLobj_dic.Values)
            {
                foreach (Hss_XML_obj xo in list)
                {
                    Hss_XML_obj res = xo.Search_obj(name);
                    if (res != null) return res;
                }
            }

            return null;
        }
        /*^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^*/


        /*********************************Internal use by Steven Huang***********************************************/
        private string tempKey = null;//for parsing use
        internal void SetTempKey(string s) { this.tempKey = s; }
        internal void SetTempValue(string s)
        {
            if (tempKey == null)
            {
                Console.WriteLine("XBRL_obj Error 0");
                return;
            }

            this.Add_attr(tempKey, s);
            tempKey = null;
        }

        public void Reset()
        {
            this.name = null;
            this.value = null;
            this.Type = XML_ElementType.None;

            this.attr_dic.Clear();
            this.XMLobj_dic.Clear();
        }

        public void Show()
        {
            Console.WriteLine("Name:" + this.name + " Value:" + this.value + " Type:" + this.Type);

            foreach (KeyValuePair<string, string> pair in this.attr_dic)
            {
                Console.WriteLine("-->" + pair.Key + "=" + pair.Value);
            }
        }
        /*^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^*/
    }
}
