using System;
using System.Collections.Generic;

using HssUtility.SQLserver;
using HssUtility.General;

namespace HssDARWIN.Models.ESP2.Securities
{
    public class SecurityMaster
    {
        public static List<Security> Get_secList_cusip(string cusip)
        {
            List<Security> secList = new List<Security>();

            DB_select selt = new DB_select(Security.Get_cmdTP());
            SQL_relation rela = new SQL_relation("cusip", RelationalOperator.Equals, cusip);
            selt.SetCondition(rela);

            DB_reader reader = new DB_reader(selt, Utility.Get_ESP2_hDB());
            while (reader.Read())
            {
                Security sec = new Security();
                sec.Init_from_reader(reader);
                secList.Add(sec);
            }
            reader.Close();

            return secList;
        }
    }
}
