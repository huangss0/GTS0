using System;
using System.Windows.Forms;
using System.Collections.Generic;

using HssUtility.SQLserver;
using HssUtility.General;
using HssDARWIN.Models.Depositaries;

namespace HssDARWIN.Models.Dividends
{
    public class Helper_Dividend
    {
        public static Dividend GetDividend_XBRL_refNum(string XBRL_ReferenceNumber, DividendTable_option table = DividendTable_option.Dividend_Control_Approved)
        {
            if (string.IsNullOrEmpty(XBRL_ReferenceNumber)) return null;

            CmdTemplate tp = new CmdTemplate();
            tp.tableName = "Dividend_XBRL";
            tp.AddColumn("DividendIndex");

            DB_select selt = new DB_select(tp);
            SQL_relation rela = new SQL_relation("XBRL_ReferenceNumber", RelationalOperator.Equals, XBRL_ReferenceNumber);
            selt.SetCondition(rela);

            DB_reader reader = new DB_reader(selt, Utility.Get_DRWIN_hDB());

            int dividendIndex = -1;
            if (reader.Read()) dividendIndex = reader.GetInt("DividendIndex");
            reader.Close();

            if (dividendIndex < 0) return null;

            Dividend dvd = new Dividend(dividendIndex);
            dvd.Init_from_DB(table);

            return dvd;
        }

        public static Dividend GetDividend_dvdID(string dvdID, DividendTable_option tableOpt)
        {
            hssDB hDB = Utility.Get_DRWIN_hDB();

            DB_select selt = new DB_select(Dividend.Get_cmdTP());
            selt.tableName = tableOpt.ToString();

            SQL_relation rela = new SQL_relation("DividendID", RelationalOperator.Equals, dvdID);
            selt.SetCondition(rela);

            Dividend dvd = null;
            DB_reader reader = new DB_reader(selt, hDB);
            if (reader.Read())
            {
                dvd = new Dividend();
                dvd.Init_from_reader(reader);
            }
            reader.Close();

            return dvd;
        }

        public static List<Dividend> Get_DividendList_CUSIP(string CUSIP, DividendTable_option table = DividendTable_option.Dividend_Control_Approved)
        {
            List<Dividend> dvdList = new List<Dividend>();
            if (string.IsNullOrEmpty(CUSIP)) return dvdList;

            DB_select selt = new DB_select(Dividend.Get_cmdTP());
            selt.tableName = table.ToString();
            SQL_relation rela = new SQL_relation("CUSIP", RelationalOperator.Equals, CUSIP);
            selt.SetCondition(rela);

            DB_reader reader = new DB_reader(selt, Utility.Get_DRWIN_hDB());
            while (reader.Read())
            {
                Dividend dvd = new Dividend();
                dvd.Init_from_reader(reader);
                dvdList.Add(dvd);
            }
            reader.Close();

            return dvdList;
        }

        public static List<Dividend> Get_DividendList_CR(string CUSIP, DateTime recordDate, DividendTable_option table = DividendTable_option.Dividend_Control_Approved)
        {
            List<Dividend> all_List = Helper_Dividend.Get_DividendList_CUSIP(CUSIP, table);
            List<Dividend> res_list = new List<Dividend>();

            foreach (Dividend dvd in all_List)
            {
                int val = HssDateTime.CompareDateTime_day(recordDate, dvd.RecordDate_ADR.Value);
                if (val == 0) res_list.Add(dvd);
            }

            return res_list;
        }

        /// <summary>
        /// Used in DARWIN\UserControls\XBRLApproval.vb for JIRA: DRWIN-166
        /// Handle XBRL cancelled files
        /// </summary>
        /// <returns>
        /// less than 0: stop parsing XBRL
        /// greater than or equal 0: go on parsing XBRL
        /// </returns>
        public static int DealWith_Dividend_XBRL(string referenceNumber, bool xbrl_cancelled, ref Dividend currDividend)
        {
            currDividend = Helper_Dividend.GetDividend_XBRL_refNum(referenceNumber);
            if (currDividend == null)
            {
                if (xbrl_cancelled) return -1;
                else return 2;
            }

            if (Helper_hssStatus.Str_to_Status(currDividend.Status.Value) == HssStatus.Cancel)
            {
                if (xbrl_cancelled)
                {
                    MessageBox.Show("Dividend " + currDividend.DividendIndex + " already cancelled");
                    return -2;
                }
                else
                {
                    string msg = "Dividend " + currDividend.DividendIndex + "has been cancelled.\nDo you want to reinstate it and approve it?";
                    if (MessageBox.Show(msg, "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes) return 1;
                    else return -3;
                }
            }
            else
            {
                if (xbrl_cancelled)
                {
                    Helper_Dividend.CancelDivdiend(currDividend);
                    MessageBox.Show("Dividend " + currDividend.DividendIndex + " is cancelled");
                    return -4;//need to move XBRL to Approved tab
                }
            }

            return 0;
        }

        public static void CancelDivdiend(Dividend dvd)
        {
            if (dvd == null) return;

            dvd.SetStatus(HssStatus.Cancel);
            dvd.Update_to_DB(DividendTable_option.Dividend_Control, false);
            dvd.Update_to_DB(DividendTable_option.Dividend_Control_Approved, false);
            dvd.SyncWithDB();
        }
    }

    public enum DividendTable_option
    {
        Dividend_Control = 1,
        Dividend_Control_Approved = 2,
    }
}
