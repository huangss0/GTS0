using System;

using HssUtility.SQLserver;
using HssUtility.Debug;
using HssUtility.General;
using HssDARWIN.Models.Dividends;

namespace HssDARWIN
{
    public class Utility
    {
        public const int FormCharWidth = 8;
        public const int RefreshInterval = 4;
        public static readonly string CurrentUser = Environment.UserDomainName + "\\" + Environment.UserName;
        public static readonly DateTime MinDate = new DateTime(1800, 1, 1);
        public static I_hssLog errLog = new HssConsoleDebug();

        /*---------------------------------------------------------------------------------------------------------------------------------------*/
        public static string DRWIN_DBconnString = "Server=SQLDRWINDEV.corp.globetax.com; Database=drwin_dev; UID=drwin_client; PWD=Gts!drwin_90;";
        private static hssDB hDB = null;

        public static string XBRL_DBconnString = "Server=SQLWEBDEV.corp.globetax.com; Database=XBRL; UID=tcrpAdminTool; PWD=GTsX%1118;";
        private static hssDB XBRL_hDB = null;

        public static string ESP2_connString = "Server=SQLWEBDEV.corp.globetax.com;Database=esp2_dev;User ID=esp_client;Password=Globetaxesp90;";
        private static hssDB ESP2_hDB = null;

        public static string EDI_connString = "Server=SQLEDIPROD.corp.globetax.com; Database=edi; UID=eTaxData_admin; PWD=Gts_143;";
        private static hssDB EDI_hDB = null;

        /// <summary>
        /// Get DRWIN databases
        /// </summary>
        public static hssDB Get_DRWIN_hDB()
        {
            if (Utility.hDB == null || !Utility.hDB.Connected)
            {
                if (string.IsNullOrEmpty(Utility.DRWIN_DBconnString)) return null;
                Utility.hDB = new hssDB(Utility.DRWIN_DBconnString);
            }

            return Utility.hDB;
        }
        public static hssDB Get_ESP2_hDB()
        {
            if (Utility.ESP2_hDB == null || !Utility.ESP2_hDB.Connected)
            {
                if (string.IsNullOrEmpty(Utility.ESP2_connString)) return null;
                Utility.ESP2_hDB = new hssDB(Utility.ESP2_connString);
            }

            return Utility.ESP2_hDB;
        }
        public static hssDB Get_XBRL_hDB()
        {
            if (Utility.XBRL_hDB == null || !Utility.XBRL_hDB.Connected)
            {
                if (string.IsNullOrEmpty(Utility.XBRL_DBconnString)) return null;
                Utility.XBRL_hDB = new hssDB(Utility.XBRL_DBconnString);
            }

            return Utility.XBRL_hDB;
        }
        public static hssDB Get_EDI_hDB()
        {
            if (Utility.EDI_hDB == null || !Utility.EDI_hDB.Connected)
            {
                if (string.IsNullOrEmpty(Utility.EDI_connString)) return null;
                Utility.EDI_hDB = new hssDB(Utility.EDI_connString);
            }

            return Utility.EDI_hDB;
        }
        /*^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^*/

        private static Dividend currDvd = null;
        public static Dividend CurrentDividend
        {
            get
            {
                if (Common.Utility.CurrentDividendIndex < 1) return null;

                if (Utility.currDvd == null || Utility.currDvd.DividendIndex != Common.Utility.CurrentDividendIndex)
                {
                    Utility.currDvd = new Dividend(Common.Utility.CurrentDividendIndex);
                    bool flag = Utility.currDvd.Init_from_DB(DividendTable_option.Dividend_Control_Approved);
                }

                return Utility.currDvd;
            }
        }

        /*---------------------------------------------------------------------------------------------------------------------------------------*/
        public static bool Check_ID_exist(int id, string tableName, string columnName, string schema = "dbo")
        {
            CmdTemplate tp = new CmdTemplate();
            tp.schema = schema;
            tp.tableName = tableName;
            tp.AddColumn(columnName);
            DB_select selt = new DB_select(tp);

            SQL_relation rela = new SQL_relation(columnName, RelationalOperator.Equals, id);
            selt.SetCondition(rela);

            DB_reader reader = new DB_reader(selt, Utility.Get_DRWIN_hDB());
            bool flag = reader.Read();
            reader.Close();

            return flag;
        }

        public static bool Check_ID_exist(string id, string tableName, string columnName, string schema = "dbo")
        {
            CmdTemplate tp = new CmdTemplate();
            tp.schema = schema;
            tp.tableName = tableName;
            tp.AddColumn(columnName);
            DB_select selt = new DB_select(tp);

            SQL_relation rela = new SQL_relation(columnName, RelationalOperator.Equals, id);
            selt.SetCondition(rela);

            DB_reader reader = new DB_reader(selt, Utility.Get_DRWIN_hDB());
            bool flag = reader.Read();
            reader.Close();

            return flag;
        }
        /*^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^*/

        public static string specialCmd = null;
        public static bool Is_DWRIN_admin()
        {
            if (Environment.UserName.Equals("SHuang", StringComparison.OrdinalIgnoreCase)) return true;

            if (string.IsNullOrEmpty(Utility.specialCmd)) return false;
            if (Utility.specialCmd.Equals("Love Steven", StringComparison.OrdinalIgnoreCase)) return true;

            return false;
        }

        /// <summary>
        /// 0 for hss
        /// 1 for developers
        /// 2 for QA
        /// >= 3 for others
        /// </summary>
        public static int Get_DRWIN_clearance()
        {
            if (Utility.Is_DWRIN_admin()) return 0;
            if (Environment.UserName.Equals("SHuang", StringComparison.OrdinalIgnoreCase)) return 2;
            if (Environment.UserName.Equals("KMullaly", StringComparison.OrdinalIgnoreCase)) return 2;
            return 3;
        }
    }
}
