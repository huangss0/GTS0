using System;
using System.Collections.Generic;

using HssUtility.SQLserver;
using HssUtility.General;

namespace HssDARWIN.Models.RSH
{
    public class RSH_master
    {
        public static List<RSH_log> Get_rshList_dvdIndex(int dvdIndex)
        {
            List<RSH_log> RSH_list = new List<RSH_log>();

            DB_select selt = new DB_select(RSH_log.Get_cmdTP());
            SQL_relation rela = new SQL_relation("DividendIndex", RelationalOperator.Equals, dvdIndex);
            selt.SetCondition(rela);

            DB_reader reader = new DB_reader(selt, Utility.Get_DRWIN_hDB());
            while (reader.Read())
            {
                RSH_log rsh = new RSH_log();
                rsh.Init_from_reader(reader);
                RSH_list.Add(rsh);
            }
            reader.Close();
            
            return RSH_list;
        }
    }
}
