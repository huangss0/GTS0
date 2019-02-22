using System;
using System.Collections.Generic;

using HssDARWIN.Models.Securities;
using HssDARWIN.Models.Custodians;
using HssUtility.General;
using HssUtility.SQLserver;

namespace HssDARWIN.Models.Dividends
{
    public partial class Dividend
    {
        public Security Get_security()
        {
            if (string.IsNullOrEmpty(this.CUSIP.Value)) return null;
            return SecurityMaster.GetSecurity_cusip(this.CUSIP.Value, this.RecordDate_ADR.Value);
        }

        /// <summary>
        /// Get DividendCustodian dictionary, [CustodianID] as key
        /// </summary>
        public Dictionary<int, DividendCustodian> Get_dvdCust_dic(string custodianType)
        {
            Dictionary<int, DividendCustodian> dic = new Dictionary<int, DividendCustodian>();

            DB_select selt = new DB_select(DividendCustodian.Get_cmdTP());
            SQL_relation rela0 = new SQL_relation("DividendIndex", RelationalOperator.Equals, this.DividendIndex);

            if (string.IsNullOrEmpty(custodianType)) selt.SetCondition(rela0);
            else
            {
                SQL_relation rela1 = new SQL_relation("Custodian_Type", RelationalOperator.Equals, custodianType);
                SQL_condition cond = new SQL_condition(rela0, ConditionalOperator.And, rela1);
                selt.SetCondition(cond);
            }

            DB_reader reader = new DB_reader(selt, Utility.Get_DRWIN_hDB());
            while (reader.Read())
            {
                DividendCustodian dc = new DividendCustodian();
                dc.Init_from_reader(reader);
                dic[dc.CustodianID] = dc;
            }
            reader.Close();

            return dic;
        }

        /// <summary>
        /// Get Custodian dictionary, [Custodian_Number] as key
        /// </summary>
        public Dictionary<int, Custodian> Get_custodian_dic()
        {
            HashSet<int> num_hs = new HashSet<int>();
            foreach (DividendCustodian dc in this.Get_dvdCust_dic(null).Values) num_hs.Add(dc.Custodian_Number.Value);

            Dictionary<int, Custodian> dic = new Dictionary<int, Custodian>();

            DB_select selt = new DB_select(Custodian.Get_cmdTP());
            SQL_relation rela = new SQL_relation("Custodian_Number", true, num_hs);
            selt.SetCondition(rela);

            DB_reader reader = new DB_reader(selt, Utility.Get_DRWIN_hDB());
            while (reader.Read())
            {
                Custodian cust = new Custodian();
                cust.Init_from_reader(reader);
                dic[cust.Custodian_Number] = cust;
            }
            reader.Close();

            return dic;
        }
    }
}
