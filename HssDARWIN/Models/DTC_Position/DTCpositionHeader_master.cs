using System;
using System.Collections.Generic;

using HssUtility.SQLserver;

namespace HssDARWIN.Models.DTC_Position
{
    public class DTCpositionHeader_master
    {
        private static Dictionary<int, List<DTC_Position_Headers>> modelNum_dic = new Dictionary<int, List<DTC_Position_Headers>>();

        private static DateTime lastUpdateTime = DateTime.MinValue;

        public static void Init_from_DB()
        {
            if ((DateTime.Now - DTCpositionHeader_master.lastUpdateTime).TotalHours < Utility.RefreshInterval) return;

            DTCpositionHeader_master.Reset();
            DB_select selt = new DB_select(DTC_Position_Headers.Get_cmdTP());

            DB_reader reader = new DB_reader(selt, Utility.Get_DRWIN_hDB());
            while (reader.Read())
            {
                DTC_Position_Headers dph = new DTC_Position_Headers();
                dph.Init_from_reader(reader);

                if (!DTCpositionHeader_master.modelNum_dic.ContainsKey(dph.ModelNumber.Value))
                {
                    List<DTC_Position_Headers> list = new List<DTC_Position_Headers>();
                    DTCpositionHeader_master.modelNum_dic[dph.ModelNumber.Value] = list;
                }
                DTCpositionHeader_master.modelNum_dic[dph.ModelNumber.Value].Add(dph);
            }
            reader.Close();

            DTCpositionHeader_master.lastUpdateTime = DateTime.Now;
        }

        public static List<DTC_Position_Headers> Get_headerList_modNum(int modelNum)
        {
            DTCpositionHeader_master.Init_from_DB();
            if (DTCpositionHeader_master.modelNum_dic.ContainsKey(modelNum)) return DTCpositionHeader_master.modelNum_dic[modelNum];
            else return null;
        }

        public static void Reset()
        {
            DTCpositionHeader_master.lastUpdateTime = DateTime.MinValue;
            DTCpositionHeader_master.modelNum_dic.Clear();
        }
    }
}
