using System;
using System.Collections.Generic;

namespace HssDARWIN.SubProjects.UserProfile
{
    public partial class Hss_UserConfig
    {
        /*-----------------------------Hss Entity Framework Auto Generated Code-------------------------------*/
        private static HssUtility.SQLserver.CmdTemplate DBcmd_TP = null;
        public static HssUtility.SQLserver.CmdTemplate Get_cmdTP()
        {
            if (Hss_UserConfig.DBcmd_TP != null) return Hss_UserConfig.DBcmd_TP;

            Hss_UserConfig.DBcmd_TP = new HssUtility.SQLserver.CmdTemplate();
            Hss_UserConfig.DBcmd_TP.tableName = "Hss_UserConfig";
            Hss_UserConfig.DBcmd_TP.schema = "Task";

            Hss_UserConfig.DBcmd_TP.AddColumn("ID");
            Hss_UserConfig.DBcmd_TP.AddColumn("UserName");/*Optional 2*/
            Hss_UserConfig.DBcmd_TP.AddColumn("ConfigXML");/*Optional 3*/
            Hss_UserConfig.DBcmd_TP.AddColumn("LastModifyAt");/*Optional 4*/

            return Hss_UserConfig.DBcmd_TP;
        }

        private int pk_ID = -1; //primary key
        public int ID { get { return this.pk_ID; } }

        public readonly HssUtility.General.Attributes.String_attr UserName = new HssUtility.General.Attributes.String_attr(Utility.CurrentUser);/*Optional 2*/
        public readonly HssUtility.General.Attributes.String_attr ConfigXML = new HssUtility.General.Attributes.String_attr();/*Optional 3*/
        public readonly HssUtility.General.Attributes.DateTime_attr LastModifyAt = new HssUtility.General.Attributes.DateTime_attr();/*Optional 4*/

        private Dictionary<string, HssUtility.General.Attributes.I_modelAttr> attr_dic = null;

        internal void Init_from_reader(HssUtility.SQLserver.DB_reader reader)
        {
            if (reader == null || reader.IsClosed) return;

            this.pk_ID = reader.GetInt("ID");
            reader.GetString("UserName", this.UserName);/*Optional 2*/
            reader.GetString("ConfigXML", this.ConfigXML);/*Optional 3*/
            reader.GetDateTime("LastModifyAt", this.LastModifyAt);/*Optional 4*/

            this.SyncWithDB();
        }

        internal void SyncWithDB()
        {
            this.Create_attrDic();
            foreach (HssUtility.General.Attributes.I_modelAttr ma in this.attr_dic.Values) ma.SyncWithDB();
        }

        public bool CheckValueChanges()
        {
            this.Create_attrDic();
            foreach (HssUtility.General.Attributes.I_modelAttr ma in this.attr_dic.Values) if (ma.ValueChanged) return true;
            return false;
        }

        private void Create_attrDic()
        {
            if (this.attr_dic != null) return;

            this.attr_dic = new Dictionary<string, HssUtility.General.Attributes.I_modelAttr>(StringComparer.OrdinalIgnoreCase);
            this.attr_dic.Add("UserName", this.UserName);/*Optional 2*/
            this.attr_dic.Add("ConfigXML", this.ConfigXML);/*Optional 3*/
            this.attr_dic.Add("LastModifyAt", this.LastModifyAt);/*Optional 4*/
        }

        /// <summary>
        /// Insert object to DB
        /// </summary>
        public bool Insert_to_DB()
        {
            HssUtility.SQLserver.DB_insert ins = this.Get_DBinsert();
            int count = ins.SaveToDB(Utility.Get_DRWIN_hDB());

            bool flag = count > 0;
            if (flag) this.SyncWithDB();

            return flag;
        }

        internal HssUtility.SQLserver.DB_insert Get_DBinsert()
        {
            this.LastModifyAt.Value = DateTime.Now;

            HssUtility.SQLserver.DB_insert dbIns = new HssUtility.SQLserver.DB_insert(Hss_UserConfig.Get_cmdTP());
            dbIns.AddValue("UserName", this.UserName);/*Optional 2*/
            dbIns.AddValue("ConfigXML", this.ConfigXML);/*Optional 3*/
            dbIns.AddValue("LastModifyAt", this.LastModifyAt);/*Optional 4*/
            return dbIns;
        }

        /// <summary>
        /// Save updates to DB
        /// </summary>
        public bool Update_to_DB()
        {
            HssUtility.SQLserver.DB_update upd = this.Get_DBupdate();
            if (upd == null) return false;

            int count = upd.SaveToDB(Utility.Get_DRWIN_hDB());
            bool flag = count > 0;
            if (flag) this.SyncWithDB();

            return flag;
        }

        internal HssUtility.SQLserver.DB_update Get_DBupdate()
        {
            if (!this.CheckValueChanges()) return null;
            else this.LastModifyAt.Value = DateTime.Now;

            HssUtility.SQLserver.DB_update upd = new HssUtility.SQLserver.DB_update(Hss_UserConfig.Get_cmdTP());
            if (this.UserName.ValueChanged) upd.AddValue("UserName", this.UserName);/*Optional 2*/
            if (this.ConfigXML.ValueChanged) upd.AddValue("ConfigXML", this.ConfigXML);/*Optional 3*/
            if (this.LastModifyAt.ValueChanged) upd.AddValue("LastModifyAt", this.LastModifyAt);/*Optional 4*/

            HssUtility.SQLserver.SQL_relation rela = new HssUtility.SQLserver.SQL_relation("ID", HssUtility.General.RelationalOperator.Equals, this.pk_ID);
            upd.SetCondition(rela);

            return upd;
        }

        public Hss_UserConfig GetCopy()
        {
            Hss_UserConfig newEntity = new Hss_UserConfig();
            if (!this.UserName.IsNull_flag) newEntity.UserName.Value = this.UserName.Value;
            if (!this.ConfigXML.IsNull_flag) newEntity.ConfigXML.Value = this.ConfigXML.Value;
            if (!this.LastModifyAt.IsNull_flag) newEntity.LastModifyAt.Value = this.LastModifyAt.Value;
            return newEntity;
        }
        /*^^^^^^^^^^^^^^^^^^^^^^^^^^^^^Hss Entity Framework Auto Generated Code^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^*/
    }
}
