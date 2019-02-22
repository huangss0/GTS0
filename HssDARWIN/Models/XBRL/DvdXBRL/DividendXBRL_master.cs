using System;
using System.Collections.Generic;

using HssDARWIN.Models.Dividends;
using HssUtility.SQLserver;
using HssUtility.General;

namespace HssDARWIN.Models.XBRL.DvdXBRL
{
    public class DividendXBRL_master
    {
        public static List<DividendXBRL> GetList_dvdIndex(int dvdIndex)
        {
            List<DividendXBRL> dxList = new List<DividendXBRL>();

            DB_select selt = new DB_select(DividendXBRL.Get_cmdTP());
            SQL_relation rela = new SQL_relation("DividendIndex", RelationalOperator.Equals, dvdIndex);
            selt.SetCondition(rela);

            DB_reader reader = new DB_reader(selt, Utility.Get_DRWIN_hDB());
            while (reader.Read())
            {
                DividendXBRL dx = new DividendXBRL();
                dx.Init_from_reader(reader);
                dxList.Add(dx);
            }
            reader.Close();

            return dxList;
        }

        public static List<DividendXBRL> GetList_refNo(string refNo)
        {
            List<DividendXBRL> dxList = new List<DividendXBRL>();
            if (string.IsNullOrEmpty(refNo)) return dxList;

            DB_select selt = new DB_select(DividendXBRL.Get_cmdTP());
            SQL_relation rela = new SQL_relation("XBRL_ReferenceNumber", RelationalOperator.Equals, refNo);
            selt.SetCondition(rela);

            DB_reader reader = new DB_reader(selt, Utility.Get_DRWIN_hDB());
            while (reader.Read())
            {
                DividendXBRL dx = new DividendXBRL();
                dx.Init_from_reader(reader);
                dxList.Add(dx);
            }
            reader.Close();

            return dxList;
        }

        public static DividendXBRL Get_dvdXBRL(string refNo, int dvdIndex)
        {
            DB_select selt = new DB_select(DividendXBRL.Get_cmdTP());
            SQL_relation rela0 = new SQL_relation("XBRL_ReferenceNumber", RelationalOperator.Equals, refNo);
            SQL_relation rela1 = new SQL_relation("DividendIndex", RelationalOperator.Equals, dvdIndex);
            selt.SetCondition(new SQL_condition(rela0, ConditionalOperator.And, rela1));

            DividendXBRL dx = null;
            DB_reader reader = new DB_reader(selt, Utility.Get_DRWIN_hDB());
            if (reader.Read())
            {
                dx = new DividendXBRL();
                dx.Init_from_reader(reader);
            }
            reader.Close();

            return dx;
        }

        /// <summary>
        /// Check if XBRL_reference number already extst with a Dividend
        /// </summary>
        /// <returns>
        /// -3 refNo from this depo not exist before
        /// -2 for empty refNo or depossitoryName
        /// -1 for no DividendXBRL found 
        /// 0 refNo not found in DividendXBRLs but depository exists before
        /// 1 refNo found in DividendXBRLs
        /// </returns>
        public static int CheckExistence_refNo(int dvdIndex, string refNo, string depositoryName)
        {
            // Have to check whether the XBRL is from sponsored depo or fist filer.
            if (string.IsNullOrEmpty(refNo) || string.IsNullOrEmpty(depositoryName)) return -2;

            List<DividendXBRL> list = DividendXBRL_master.GetList_dvdIndex(dvdIndex);
            if (list.Count < 1) return -1;

            bool XBRL_from_this_depo_Exist = false;
            foreach (DividendXBRL dx in list)
            {
                if (dx.Depositary.Value.Equals(depositoryName, StringComparison.OrdinalIgnoreCase))
                {
                    XBRL_from_this_depo_Exist = true;
                    break;
                }
            }

            if (!XBRL_from_this_depo_Exist) return -3;

            foreach (DividendXBRL dx in list)
            {
                if (!dx.Depositary.Value.Equals(depositoryName, StringComparison.OrdinalIgnoreCase)) continue;
                if (refNo.Equals(dx.XBRL_ReferenceNumber.Value, StringComparison.OrdinalIgnoreCase)) return 1;
            }

            return 0;
        }
    }
}
