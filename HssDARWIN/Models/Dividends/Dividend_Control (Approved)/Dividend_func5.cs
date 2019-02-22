using System;
using System.Collections.Generic;

using HssDARWIN.Models.Details;
using HssDARWIN.Models.XBRL.DvdXBRL;
using HssDARWIN.Models.RSH;
using HssUtility.SQLserver;
using HssUtility.General;

namespace HssDARWIN.Models.Dividends
{
    public partial class Dividend
    {
        public List<Dividend_Detail_simpleEF> Get_dvdDetail_list(string reclaimFeeType)
        {
            List<Dividend_Detail_simpleEF> list = new List<Dividend_Detail_simpleEF>();

            DB_select selt = new DB_select(Dividend_Detail_simpleEF.Get_cmdTP());
            SQL_relation rela0 = new SQL_relation("DividendIndex", RelationalOperator.Equals, this.DividendIndex);
            if (string.IsNullOrEmpty(reclaimFeeType)) selt.SetCondition(rela0);
            else
            {
                SQL_relation rela1 = new SQL_relation("ReclaimFeesType", RelationalOperator.Equals, reclaimFeeType);
                SQL_condition cond = new SQL_condition(rela0, ConditionalOperator.And, rela1);
                selt.SetCondition(cond);
            }

            DB_reader reader = new DB_reader(selt, Utility.Get_DRWIN_hDB());
            while (reader.Read())
            {
                Dividend_Detail_simpleEF dd = new Dividend_Detail_simpleEF();
                dd.Init_from_reader(reader);
                list.Add(dd);
            }
            reader.Close();

            return list;
        }

        public List<Dividend_Detail_simpleAP> Get_dvdDetailAP_list(string reclaimFeeType)
        {
            List<Dividend_Detail_simpleAP> list = new List<Dividend_Detail_simpleAP>();

            DB_select selt = new DB_select(Dividend_Detail_simpleAP.Get_cmdTP());
            SQL_relation rela0 = new SQL_relation("DividendIndex", RelationalOperator.Equals, this.DividendIndex);
            if (string.IsNullOrEmpty(reclaimFeeType)) selt.SetCondition(rela0);
            else
            {
                SQL_relation rela1 = new SQL_relation("ReclaimFeesType", RelationalOperator.Equals, reclaimFeeType);
                SQL_condition cond = new SQL_condition(rela0, ConditionalOperator.And, rela1);
                selt.SetCondition(cond);
            }

            DB_reader reader = new DB_reader(selt, Utility.Get_DRWIN_hDB());
            while (reader.Read())
            {
                Dividend_Detail_simpleAP dd = new Dividend_Detail_simpleAP();
                dd.Init_from_reader(reader);
                list.Add(dd);
            }
            reader.Close();

            return list;
        }

        public int Delete_CustodianID_dvdDetail(string reclaimFeeType)
        {
            DB_update upd = new DB_update(Dividend_Detail_full.Get_cmdTP());
            upd.AddNull("CustodianID");

            SQL_relation rela0 = new SQL_relation("DividendIndex", RelationalOperator.Equals, this.DividendIndex);
            if (string.IsNullOrEmpty(reclaimFeeType)) upd.SetCondition(rela0);
            else
            {
                SQL_relation rela1 = new SQL_relation("ReclaimFeesType", RelationalOperator.Equals, reclaimFeeType);
                SQL_condition cond = new SQL_condition(rela0, ConditionalOperator.And, rela1);
                upd.SetCondition(cond);
            }
            
            Helper_SQLserver.AllTrigers("Dividend_Detail", false, Utility.Get_DRWIN_hDB());
            int count = upd.SaveToDB(Utility.Get_DRWIN_hDB());
            Helper_SQLserver.AllTrigers("Dividend_Detail", true, Utility.Get_DRWIN_hDB());

            return count;
        }

        public List<DividendXBRL> Get_dividendXBRL_list()
        {
            List<DividendXBRL> list = DividendXBRL_master.GetList_dvdIndex(this.DividendIndex);
            list.Sort((a, b) => (a.XBRL_ID - b.XBRL_ID));

            return list;
        }

        public List<RSH_log> Get_RSH_list()
        {
            return RSH_master.Get_rshList_dvdIndex(this.DividendIndex);
        }
    }
}
