using System;
using System.Collections.Generic;
using System.Drawing;
using System.Data;

using Infragistics.Win.UltraWinGrid;

namespace HssDARWIN.Helpers
{
    public class UltraGrid_helper
    {
        public const string DateTime_format_full = "MM/dd/yyyy HH:mm:ss";
        public const int RowsLoaded_per_scroll = 50;
        public const string ActionColumnName = "$Action$", SelectColumnName = "$select$";

        /// <summary>
        /// Basic setting initialization
        /// </summary>
        private static void BasicInit(UltraGrid grid)
        {
            if (grid.DisplayLayout.Bands.Count > 0) grid.DisplayLayout.Bands[0].ColHeaderLines = 2;

            grid.DisplayLayout.Override.HeaderAppearance.BackColor2 = Color.FromArgb(192, 192, 255);
            grid.DisplayLayout.Override.HeaderAppearance.BackColor = Color.FromArgb(255, 255, 255);
            grid.DisplayLayout.Override.HeaderAppearance.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            grid.DisplayLayout.Override.HeaderAppearance.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;

            grid.DisplayLayout.Override.RowSelectorAppearance.BackColor = Color.FromArgb(255, 255, 255);
            grid.DisplayLayout.Override.RowSelectorAppearance.BackColor2 = Color.FromArgb(192, 192, 255);
            grid.DisplayLayout.Override.RowSelectorAppearance.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;

            grid.DisplayLayout.ScrollBounds = ScrollBounds.ScrollToFill;
            grid.DisplayLayout.ScrollStyle = ScrollStyle.Immediate;

            grid.DisplayLayout.Override.RowSelectorNumberStyle = RowSelectorNumberStyle.VisibleIndex;
        }

        public static void InitGrid(UltraGrid grid)
        {
            UltraGrid_helper.InitGrid(grid, true, true);
        }

        public static void InitGrid(UltraGrid grid, bool isReadonly, bool headerSortFilter)
        {
            if (grid == null) return;

            if (isReadonly) grid.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.False;            
            grid.DisplayLayout.Override.AllowAddNew = AllowAddNew.No;
            grid.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.False;

            if (headerSortFilter)
            {
                grid.DisplayLayout.Override.HeaderClickAction = HeaderClickAction.SortSingle;
                grid.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.True;
            }

            UltraGrid_helper.BasicInit(grid);
        }

        public static void Set_readOnly_columns(UltraGrid grid, bool isReadonly, params int[] col_IDs)
        {
            if (grid == null) return;
            HashSet<int> hs = new HashSet<int>(col_IDs);
            foreach (UltraGridBand bd in grid.DisplayLayout.Bands)
            {
                for (int i = 0; i < bd.Columns.Count; ++i)
                {
                    if (hs.Contains(i)) bd.Columns[i].CellActivation = isReadonly ? Activation.NoEdit : Activation.AllowEdit;
                    else bd.Columns[i].CellActivation = isReadonly ? Activation.AllowEdit : Activation.NoEdit;
                }
            }
        }

        public static void Set_header_sortFilter(UltraGrid grid, bool flag)
        {
            if (grid == null) return;

            if (flag)
            {
                grid.DisplayLayout.Override.HeaderClickAction = HeaderClickAction.SortSingle;
                grid.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.True;
            }
            else
            {
                grid.DisplayLayout.Override.HeaderClickAction = HeaderClickAction.Select;
                grid.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            }
        }

        public static void AutoResize(UltraGrid grid)
        {
            if (grid == null) return;
            foreach (UltraGridBand bd in grid.DisplayLayout.Bands)
                bd.PerformAutoResizeColumns(false, PerformAutoSizeType.AllRowsInBand);
        }

        public static void SetMaxWidth(UltraGrid grid, int maxWidth = 150)
        {
            if (grid == null) return;
            if (maxWidth < 1) maxWidth = 150;

            foreach (UltraGridBand bd in grid.DisplayLayout.Bands)
            {
                foreach (UltraGridColumn col in bd.Columns) col.MaxWidth = maxWidth;                
            }
        }

        public static void SetDataSource(UltraGrid grid, DataTable dt)
        {
            if (grid == null) return;
            else grid.DataSource = dt;

            foreach (UltraGridBand bd in grid.DisplayLayout.Bands)
            {
                foreach (UltraGridColumn col in bd.Columns)
                {
                    if (col.DataType == typeof(DateTime)) col.Format = UltraGrid_helper.DateTime_format_full;
                }
            }
        }

        public static void ClearCurrentFilters(UltraGrid grid)
        {
            if (grid == null) return;
            foreach (UltraGridBand bd in grid.DisplayLayout.Bands) bd.ColumnFilters.ClearAllFilters();            
        }

        public static void UnhideAllColumns(UltraGrid grid)
        {
            if (grid == null) return;

            foreach (UltraGridBand bd in grid.DisplayLayout.Bands)
            {
                foreach (UltraGridColumn col in bd.Columns) col.Hidden = false;
            }
        }

        public static void HideColumn_byHeader(UltraGrid grid, string headerName)
        {
            if (grid == null || string.IsNullOrEmpty(headerName)) return;
            if (grid.DisplayLayout.Bands.Count < 1) return;

            int visibleColCount = 0;

            Dictionary<string, string> header_dic = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
            foreach (UltraGridColumn col in grid.DisplayLayout.Bands[0].Columns)
            {
                string header = col.Header.Caption;
                header_dic[header] = col.Key;

                if (!col.Hidden) ++visibleColCount;
            }            

            if (header_dic.ContainsKey(headerName))
            {
                if (visibleColCount <= 1) return;

                string key = header_dic[headerName];
                UltraGridColumn col = grid.DisplayLayout.Bands[0].Columns[key];
                col.Hidden = true;
            }
        }

        public static HashSet<int> Get_selected_IDs(UltraGrid grid, string colName)
        {
            HashSet<int> ID_hs = new HashSet<int>();
            if (string.IsNullOrEmpty(colName)) return ID_hs;
            if (grid == null) return ID_hs;

            foreach (UltraGridRow row in grid.Selected.Rows)
            {
                object obj = row.Cells[colName].Value;
                if (obj is int) ID_hs.Add((int)obj);
            }

            return ID_hs;
        }
    }
}
