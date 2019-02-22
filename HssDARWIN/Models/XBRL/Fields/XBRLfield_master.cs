using System;
using System.Collections.Generic;

using HssUtility.SQLserver;

namespace HssDARWIN.Models.XBRL.Fields
{
    public class XBRLfield_master
    {
        private static Dictionary<int, XBRLfield> id_dic = new Dictionary<int, XBRLfield>();
        private static Dictionary<string, XBRLfield> drwin_dic = new Dictionary<string, XBRLfield>(StringComparer.OrdinalIgnoreCase);

        private static DateTime lastUpdateTime = DateTime.MinValue;

        public static void Init_from_DB()
        {
            if ((DateTime.Now - XBRLfield_master.lastUpdateTime).TotalHours < Utility.RefreshInterval) return;

            XBRLfield_master.Reset();
            DB_select selt = new DB_select(XBRLfield.Get_cmdTP());
            DB_reader reader = new DB_reader(selt, Utility.Get_DRWIN_hDB());
            while (reader.Read())
            {
                XBRLfield xf = new XBRLfield();
                xf.Init_from_reader(reader);

                XBRLfield_master.id_dic[xf.id_XBRLField] = xf;
                XBRLfield_master.drwin_dic[xf.drwinFieldName.Value] = xf;
            }
            reader.Close();

            XBRLfield_master.lastUpdateTime = DateTime.Now;
        }

        public static List<XBRLfield> GetAll_fieldList()
        {
            XBRLfield_master.Init_from_DB();
            List<XBRLfield> list = new List<XBRLfield>(XBRLfield_master.id_dic.Values);
            return list;
        }

        public static XBRLfield GetField_drwin(string drField)
        {
            XBRLfield_master.Init_from_DB();
            if (drField == null)            return null;

            if (XBRLfield_master.drwin_dic.ContainsKey(drField)) return XBRLfield_master.drwin_dic[drField];
            else return null;
        }

        public static void Reset()
        {
            XBRLfield_master.lastUpdateTime = DateTime.MinValue;
            XBRLfield_master.id_dic.Clear();
        }
    }
}
