using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using HssUtility.SQLserver;
using HssUtility.General;

namespace HssDARWIN.Models.ESP2.Events
{
    public class EventMaster
    {
        public static Event GetEvent_DividendIndex(int dvdIndex)
        {
            DB_select selt = new DB_select(Event.Get_cmdTP());
            SQL_relation rela = new SQL_relation("dividend_index", RelationalOperator.Equals, dvdIndex);
            selt.SetCondition(rela);

            Event eve = null;
            DB_reader reader = new DB_reader(selt, Utility.Get_ESP2_hDB());
            if (reader.Read())
            {
                eve = new Event();
                eve.Init_from_reader(reader);
            }
            reader.Close();

            return eve;
        }
    }
}
