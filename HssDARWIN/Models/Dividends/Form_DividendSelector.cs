using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

using HssDARWIN.Helpers;

namespace HssDARWIN.Models.Dividends
{
    public partial class Form_DividendSelector : Form
    {
        public Form_DividendSelector()
        {
            this.InitializeComponent();

            this.sourctDT.Columns.Add("DividendIndex", typeof(int));
            this.sourctDT.Columns.Add("CUSIP");
            this.sourctDT.Columns.Add("RecordDate", typeof(DateTime));
            this.sourctDT.Columns.Add("Depository");
            this.sourctDT.Columns.Add("Issue");

            this.main_ultraGrid.DataSource = this.sourctDT;

            this.main_ultraGrid.DisplayLayout.Bands[0].Columns["DividendIndex"].ButtonDisplayStyle = Infragistics.Win.UltraWinGrid.ButtonDisplayStyle.Always;
            this.main_ultraGrid.DisplayLayout.Bands[0].Columns["DividendIndex"].Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Button;

            UltraGrid_helper.InitGrid(this.main_ultraGrid);
        }

        private DataTable sourctDT = new DataTable();

        public void Init_from_CUSIP(string CUSIP)
        {
            List<Dividend> dvdList = Helper_Dividend.Get_DividendList_CUSIP(CUSIP);
            this.Init_from_list(dvdList);
        }

        public int Init_from_list(List<Dividend> dvdList)
        {
            this.sourctDT.Clear();
            if (dvdList == null) return -1;

            foreach (Dividend dvd in dvdList)
            {
                DataRow row = this.sourctDT.Rows.Add();
                row["DividendIndex"] = dvd.DividendIndex;
                row["CUSIP"] = dvd.CUSIP.Value;
                row["RecordDate"] = dvd.RecordDate_ADR.Value;
                row["Depository"] = dvd.Depositary.Value;
                row["Issue"] = dvd.Issue.Value;
            }

            UltraGrid_helper.AutoResize(this.main_ultraGrid);
            this.ShowDialog();
            return this.selected_dvdIndex;
        }

        private int selected_dvdIndex = -1;
        private void main_ultraGrid_ClickCellButton(object sender, Infragistics.Win.UltraWinGrid.CellEventArgs e)
        {
            this.selected_dvdIndex = (int)e.Cell.Value;
            this.Close();
        }
    }
}
