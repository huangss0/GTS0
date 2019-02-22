using System;
using System.Collections.Generic;

using HssUtility.SQLserver;

namespace HssDARWIN.Models.RSH
{
    public class SavedFiles_master
    {
        public static List<SavedFiles_CSV> Get_RSH_fileList()
        {
            List<SavedFiles_CSV> list = new List<SavedFiles_CSV>();

            DB_reader reader = SavedFiles_master.Get_DB_reader();
            while (reader.Read())
            {
                SavedFiles_CSV sf = new SavedFiles_CSV();
                sf.Init_from_reader(reader);
                list.Add(sf);
            }
            reader.Close();

            return list;
        }

        private static DB_reader Get_DB_reader()
        {
            DB_select selt = new DB_select(SavedFiles_CSV.Get_cmdTP());
            selt.IgnoreColumn("SavedFiles_CSV");
            selt.IgnoreColumn("cpuSavedFiles_CSV");
            selt.IgnoreColumn("OriginalSchema");
            selt.IgnoreColumn("OriginalData");

            DB_reader reader = new DB_reader(selt, Utility.Get_XBRL_hDB());
            return reader;
        }
    }
}
