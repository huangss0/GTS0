using System;
using System.Collections.Generic;
using System.Text;

using Infragistics.Win.UltraWinGrid;
using HssUtility.General;

namespace HssDARWIN.SubProjects.UserProfile
{
    public class HssGridColumn
    {
        public readonly string column_key = null;
        public readonly bool hidden_flag = false;
        public readonly int visible_position = 9999;        

        public HssGridColumn(UltraGridColumn uCol)
        {
            if (uCol == null) return;

            this.hidden_flag = uCol.Hidden;
            this.visible_position = uCol.Header.VisiblePosition;
            this.column_key = uCol.Key;
        }
        public HssGridColumn(string colKey, bool hiden, int position)
        {
            this.hidden_flag = hiden;
            this.visible_position = position;
            this.column_key = colKey;
        }

        public void ConfigColumn(UltraGridColumn uCol)
        {
            if (uCol == null) return;

            uCol.Header.VisiblePosition = this.visible_position;
            uCol.Hidden = this.hidden_flag;            
        }

        public string ToXML()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("<col Hidden='").Append(this.hidden_flag).Append("'>");
            sb.Append(HssStr.ToSafeXML_str(this.column_key)).Append("</col>");
            return sb.ToString();
        }
    }
}
