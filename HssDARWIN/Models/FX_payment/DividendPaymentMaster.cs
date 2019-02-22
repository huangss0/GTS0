using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using HssUtility.SQLserver;
using HssUtility.General;

namespace HssDARWIN.Models.FX_payment
{
    public class DividendPaymentMaster
    {
        /// <summary>
        /// Get a list of Dividend_Payment
        /// </summary>
        /// <param name="option">0 for unlocked and 1 for locked, other values for all records</param>
        public static List<Dividend_Payment> GetAll_payment_list(int option)
        {
            List<Dividend_Payment> list = new List<Dividend_Payment>();

            DB_select db_sel = new DB_select(Dividend_Payment.Get_cmdTP());
            if (option == 0 || option == 1)
            {
                SQL_relation rela = new SQL_relation("Paid_And_Locked", RelationalOperator.Equals, option);
                db_sel.SetCondition(rela);
            }

            DB_reader reader = new DB_reader(db_sel, Utility.Get_DRWIN_hDB());
            while (reader.Read())
            {
                Dividend_Payment dp = new Dividend_Payment();
                dp.Init_from_reader(reader);
                list.Add(dp);
            }
            reader.Close();

            return list;
        }

        public static List<Dividend_Payment> GetPayments_FX(int fxInput_id)
        {
            List<Dividend_Payment> list = new List<Dividend_Payment>();

            DB_select db_sel = new DB_select(Dividend_Payment.Get_cmdTP());
            SQL_relation rela = new SQL_relation("FX_InputID", RelationalOperator.Equals, fxInput_id);
            db_sel.SetCondition(rela);

            DB_reader reader = new DB_reader(db_sel, Utility.Get_DRWIN_hDB());
            while (reader.Read())
            {
                Dividend_Payment dp = new Dividend_Payment();
                dp.Init_from_reader(reader);
                list.Add(dp);
            }
            reader.Close();

            return list;
        }
    }
}
