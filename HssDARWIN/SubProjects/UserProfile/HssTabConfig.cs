using System;
using System.Collections.Generic;
using System.Text;

using HssUtility.General;
using HssUtility.Text.XML;

namespace HssDARWIN.SubProjects.UserProfile
{
    public class HssTabConfig
    {
        public const string XML_name = "hTab";

        //Grid name as key
        private Dictionary<string, HssGridConfig> gridConfig_dic = new Dictionary<string, HssGridConfig>(StringComparer.OrdinalIgnoreCase);
        private string tabName = "$Default$";

        public string Name { get { return this.tabName; } }

        public HssTabConfig() { }
        public HssTabConfig(string tabName) { this.tabName = tabName; }

        /// <summary>
        /// Add or set value of Grid Config
        /// </summary>
        public bool Set_GridConfig(string key, HssGridConfig value)
        {
            if (string.IsNullOrEmpty(key)) return false;

            this.gridConfig_dic[key] = value;
            return true;
        }

        public bool Contains_GridConfig(string key)
        {
            if (key == null) return false;
            return this.gridConfig_dic.ContainsKey(key);
        }

        public HssGridConfig Get_GridConfig(string key)
        {
            if (this.Contains_GridConfig(key)) return this.gridConfig_dic[key];
            else return null;
        }

        public void Refresh_from_UI()
        {
            foreach (HssGridConfig hgc in this.gridConfig_dic.Values) hgc.Init_from_grid();
        }

        /*----------------------------------------------------------------------------------------------------------*/
        public void Init_from_XMLobj(Hss_XML_obj hxo)
        {
            if (hxo == null) return;

            this.Reset();   
            string name = hxo.Get_attr("Name");
            if (!string.IsNullOrEmpty(name)) this.tabName = name;

            List<Hss_XML_obj> list = hxo.Get_all_obj();
            foreach (Hss_XML_obj xo in list)
            {
                HssGridConfig hgc = new HssGridConfig();
                hgc.Init_from_XMLobj(xo);
                this.gridConfig_dic[hgc.Key] = hgc;
            }
        }

        /// <summary>
        /// Get the XML of this User Config
        /// </summary>
        public string ToXML()
        {
            StringBuilder sb = new StringBuilder();
            
            sb.Append("<").Append(HssTabConfig.XML_name).Append(" Name='").Append(this.Name).Append("'>").Append(HssStr.WinNextLine);
            foreach (HssGridConfig hgc in this.gridConfig_dic.Values) sb.Append(hgc.ToXML()).Append(HssStr.WinNextLine);
            sb.Append("</").Append(HssTabConfig.XML_name).Append(">");

            return sb.ToString();
        }

        public void Reset()
        {
            this.gridConfig_dic.Clear();
        }
    }
}
