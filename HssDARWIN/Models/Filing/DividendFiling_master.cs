using System;
using System.Collections.Generic;

using HssUtility.SQLserver;
using HssUtility.General;

namespace HssDARWIN.Models.Filing
{
    public class DividendFiling_master
    {
        public static List<Dividend_Filing> GetList_dvdIndex(int dvdIndex)
        {
            List<Dividend_Filing> df_list = new List<Dividend_Filing>();

            DB_select selt = new DB_select(Dividend_Filing.Get_cmdTP());
            SQL_relation rela = new SQL_relation("DividendIndex", RelationalOperator.Equals, dvdIndex);
            selt.SetCondition(rela);

            DB_reader reader = new DB_reader(selt, Utility.Get_DRWIN_hDB());
            while (reader.Read())
            {
                Dividend_Filing df = new Dividend_Filing();
                df.Init_from_reader(reader);
                df_list.Add(df);
            }
            reader.Close();

            return df_list;
        }
    }
}
