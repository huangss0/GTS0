using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using HssDARWIN.Models.Securities;
using HssDARWIN.Models.Dividends;
using HssUtility.General;

namespace HssDARWIN.Models.Tasks.Task21
{
    public class Task_Detail_21 : Task_Detail
    {
        public int DividendIndex { get { return this.dvdIndex; } }

        private int dvdIndex = -1;
        private Dividend currDvd = null;

        public Task_Detail_21(int index)
        {
            this.dvdIndex = index;
            this.CreateDividend();
        }

        public Task_Detail_21(Dividend dvd)
        {
            if (dvd != null)
            {
                this.dvdIndex = dvd.DividendIndex;
                this.currDvd = dvd;
            }
            this.CreateDividend();
        }

        private void CreateDividend()
        {
            base.TaskID.Value = 21;
            base.SourceID.Value = this.dvdIndex.ToString();
            base.SourceTable.Value = DividendTable_option.Dividend_Control_Approved.ToString();

            if (this.currDvd == null)
            {
                this.currDvd = new Dividend(this.dvdIndex);
                this.currDvd.Init_from_DB(DividendTable_option.Dividend_Control_Approved);
            }
        }

        public void InsertTask21_to_DB()
        {
            string task_str = this.GetDisplayStr(true);
            if (string.IsNullOrEmpty(task_str)) return;

            this.Notes.Value = task_str;
            this.Country.Value = this.currDvd.Country.Value;
            this.Insert_to_DB();
        }

        public string GetDisplayStr(bool normal_only)
        {
            Security sec = this.currDvd.Get_security();
            if (sec == null) return null;
            else return Task21_secMaster.GetDisplayStr(sec.SecurityID, normal_only);
        }
    }
}
