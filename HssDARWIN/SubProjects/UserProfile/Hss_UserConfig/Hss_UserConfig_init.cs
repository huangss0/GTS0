using System;

namespace HssDARWIN.SubProjects.UserProfile
{
    public partial class Hss_UserConfig
    {
        public Hss_UserConfig() { }
        public Hss_UserConfig(int id) { this.pk_ID = id; }
        /// <summary>
        /// Another constructor using userName as primary key
        /// </summary>
        public Hss_UserConfig(string currentUser) { this.UserName.Value = currentUser; }

        /// <summary>
        /// Initialize object from DB
        /// </summary>
        public bool Init_from_DB()
        {
            HssUtility.SQLserver.SQL_relation rela = null;
            if (this.pk_ID > 0) rela = new HssUtility.SQLserver.SQL_relation("ID", HssUtility.General.RelationalOperator.Equals, this.ID);
            else
            {
                if (UserName.IsValueEmpty) return false;
                else rela = new HssUtility.SQLserver.SQL_relation("UserName", HssUtility.General.RelationalOperator.Equals, this.UserName.Value);
            }

            HssUtility.SQLserver.DB_select db_sel = new HssUtility.SQLserver.DB_select(Hss_UserConfig.Get_cmdTP());
            db_sel.tableName = "Hss_UserConfig";
            db_sel.SetCondition(rela);

            bool res_flag = false;
            HssUtility.SQLserver.DB_reader reader = new HssUtility.SQLserver.DB_reader(db_sel, Utility.Get_DRWIN_hDB());
            if (reader.Read())
            {
                this.Init_from_reader(reader);
                res_flag = true;
            }
            reader.Close();
            return res_flag;
        }
    }
}
