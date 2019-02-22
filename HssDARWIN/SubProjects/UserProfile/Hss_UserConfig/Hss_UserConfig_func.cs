using System;
using System.Collections.Generic;
using System.Text;

using HssUtility.General;
using HssUtility.Text.XML;

namespace HssDARWIN.SubProjects.UserProfile
{
    public partial class Hss_UserConfig
    {
        public const string XML_name = "Hss_UserConfig";

        //Tab name as key
        private Dictionary<string, HssTabConfig> tabConfig_dic = new Dictionary<string, HssTabConfig>(StringComparer.OrdinalIgnoreCase);

        /// <summary>
        /// Add or set value of Grid Config
        /// </summary>
        public bool Set_TabConfig(string key, HssTabConfig value)
        {
            if (string.IsNullOrEmpty(key)) return false;

            this.tabConfig_dic[key] = value;
            return true;
        }

        public bool Contains_TabConfig(string key)
        {
            if (key == null) return false;
            return this.tabConfig_dic.ContainsKey(key);
        }

        public HssTabConfig Get_TabConfig(string key)
        {
            if (this.Contains_TabConfig(key)) return this.tabConfig_dic[key];
            else return null;
        }

        public void ClearConfig()
        {
            this.tabConfig_dic.Clear();
        }
        /*----------------------------------------------------------------------------------------------------------------------------------*/

        /// <summary>
        /// Get the XML of this User Config
        /// </summary>
        public string GetConfigXML()
        {
            StringBuilder sb = new StringBuilder("");
            sb.Append("<").Append(Hss_UserConfig.XML_name).Append(">").Append(HssStr.WinNextLine);
            foreach (HssTabConfig htc in this.tabConfig_dic.Values) sb.Append(htc.ToXML()).Append(HssStr.WinNextLine);            
            sb.Append("</").Append(Hss_UserConfig.XML_name).Append(">").Append(HssStr.WinNextLine);

            return sb.ToString();
        }

        /// <summary>
        /// Save this User Config to DataBase
        /// </summary>
        public bool Save_to_DB()
        {
            if (this.pk_ID < 0)
            {
                if (!this.Init_from_DB())
                {
                    this.Save_to_ConfigXML();
                    return this.Insert_to_DB();
                }
            }

            this.Save_to_ConfigXML();
            return this.Update_to_DB();
        }

        /// <summary>
        /// Convert the string value in ConfigXML to XML object
        /// </summary>
        public void Init_from_ConfigXML()
        {
            Hss_XML_reader xReader = new Hss_XML_reader();
            Hss_XML_obj xo_lvl0 = xReader.Read(this.ConfigXML.Value);
            if (xo_lvl0 == null) return;

            Hss_XML_obj xo_lvl1 = xo_lvl0.Get_obj(XML_name);
            if (xo_lvl1 == null) return;

            this.tabConfig_dic.Clear();
            foreach (Hss_XML_obj xo in xo_lvl1.Get_all_obj())
            {
                HssTabConfig htc = new HssTabConfig();
                htc.Init_from_XMLobj(xo);
                this.tabConfig_dic[htc.Name] = htc;
            }
        }

        /// <summary>
        /// Save all configs to gridConfig_dic and update ConfigXML
        /// </summary>
        public void Save_to_ConfigXML()
        {
            foreach (HssTabConfig htc in this.tabConfig_dic.Values) htc.Refresh_from_UI();
            this.ConfigXML.Value = this.GetConfigXML();
        }
    }
}
