using System;
using System.Collections.Generic;
using System.Text;

using Infragistics.Win.UltraWinGrid;

using HssUtility.General;
using HssUtility.Text.XML;

namespace HssDARWIN.SubProjects.UserProfile
{
    public class HssGridConfig
    {
        public const string XML_name = "uGrid";

        public string Key = UserConfigMaster.DefaultName;
        private List<HssGridColumn> colKey_list = new List<HssGridColumn>();
        private UltraGrid mainGrid = null;

        public HssGridConfig() { }
        public HssGridConfig(string gridName) { this.Key = gridName; }

        /**************************************************************************************************************************/
        public void Init_from_XMLstr(string xml)
        {
            if (string.IsNullOrEmpty(xml)) return;

            Hss_XML_reader xReader = new Hss_XML_reader();
            Hss_XML_obj xo = xReader.Read(xml);
            this.Init_from_XMLobj(xo);
        }

        public void Init_from_XMLobj(Hss_XML_obj hxo)
        {
            if (hxo == null) return;

            this.colKey_list.Clear();
            string name = hxo.Get_attr("Key");
            if (!string.IsNullOrEmpty(name)) this.Key = name;

            List<Hss_XML_obj> list = hxo.Get_all_obj();
            for (int i = 0; i < list.Count; ++i)
            {
                Hss_XML_obj xo = list[i];
                string colKey = xo.value;
                bool hidden = HssStr.True_or_False(xo.Get_attr("Hidden"));

                HssGridColumn hgc = new HssGridColumn(colKey, hidden, i);
                this.colKey_list.Add(hgc);
            }
        }

        public void Init_from_grid(UltraGrid grid = null)
        {
            if (grid == null) grid = this.mainGrid;
            if (grid == null) return;
            if (grid.DisplayLayout == null || grid.DisplayLayout.Bands.Count < 1) return;

            this.mainGrid = grid;

            ColumnsCollection columns = grid.DisplayLayout.Bands[0].Columns;
            if (columns.Count < 1) return;
            else this.colKey_list.Clear();

            foreach (UltraGridColumn col in columns) this.colKey_list.Add(new HssGridColumn(col));

            this.colKey_list.Sort((a, b) => (a.visible_position - b.visible_position));
        }
        /*--------------------------------------------------------------------------------------------------------------------------*/

        public string ToXML()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("<").Append(HssGridConfig.XML_name).Append(" Key='").Append(this.Key).Append("'>").Append(HssStr.WinNextLine);
            foreach (HssGridColumn uCol in this.colKey_list) sb.Append(uCol.ToXML()).Append(HssStr.WinNextLine);
            sb.Append("</").Append(HssGridConfig.XML_name).Append(">");

            return sb.ToString();
        }

        /// <summary>
        /// Apply config info to UltraGrid
        /// </summary>
        public void ConfigGrid(UltraGrid grid)
        {
            if (grid == null || grid.DisplayLayout.Bands.Count < 1) return;
            else this.mainGrid = grid;

            ColumnsCollection uColumns = grid.DisplayLayout.Bands[0].Columns;
            HashSet<string> hs = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

            //int tempPos = 999;
            foreach (UltraGridColumn uCol in uColumns)
            {
                hs.Add(uCol.Key);
                //uCol.Hidden = true;
                //Console.WriteLine(uCol.Key + " Position:" + uCol.Header.VisiblePosition); 
            }

            foreach (HssGridColumn hgc in this.colKey_list)
            {
                if (!hs.Contains(hgc.column_key)) continue;

                UltraGridColumn uCol = uColumns[hgc.column_key];
                hgc.ConfigColumn(uCol);
            }
        }
    }
}
