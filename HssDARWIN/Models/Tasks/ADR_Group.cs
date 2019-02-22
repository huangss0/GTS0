using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using HssDARWIN.Models.Countries;

namespace HssDARWIN.Models.Tasks
{
    public class ADR_Group
    {
        /*-----------------------------Hss Entity Framework Auto Generated Code-------------------------------*/
        private static HssUtility.SQLserver.CmdTemplate DBcmd_TP = null;
        public static HssUtility.SQLserver.CmdTemplate Get_cmdTP()
        {
            if (ADR_Group.DBcmd_TP != null) return ADR_Group.DBcmd_TP;

            ADR_Group.DBcmd_TP = new HssUtility.SQLserver.CmdTemplate();
            ADR_Group.DBcmd_TP.tableName = "ADR_Group";
            ADR_Group.DBcmd_TP.schema = "dbo";

            ADR_Group.DBcmd_TP.AddColumn("GroupID");
            ADR_Group.DBcmd_TP.AddColumn("GroupName");
            ADR_Group.DBcmd_TP.AddColumn("Group_LeaderSID");
            ADR_Group.DBcmd_TP.AddColumn("Group_Email");/*Optional 4*/

            return ADR_Group.DBcmd_TP;
        }

        public ADR_Group() { }
        public ADR_Group(int id) { this.pk_ID = id; }

        private int pk_ID = -1; //primary key
        public int GroupID { get { return this.pk_ID; } }

        public readonly HssUtility.General.Attributes.String_attr GroupName = new HssUtility.General.Attributes.String_attr();
        public readonly HssUtility.General.Attributes.String_attr Group_LeaderSID = new HssUtility.General.Attributes.String_attr();
        public readonly HssUtility.General.Attributes.String_attr Group_Email = new HssUtility.General.Attributes.String_attr();/*Optional 4*/

        private List<HssUtility.General.Attributes.I_modelAttr> attrList = null;

        internal void Init_from_reader(HssUtility.SQLserver.DB_reader reader)
        {
            if (reader == null || reader.IsClosed) return;

            this.pk_ID = reader.GetInt("GroupID");
            reader.GetString("GroupName", this.GroupName);
            reader.GetString("Group_LeaderSID", this.Group_LeaderSID);
            reader.GetString("Group_Email", this.Group_Email);/*Optional 4*/

            this.SyncWithDB();
        }

        /// <summary>
        /// Initialize object from DB
        /// </summary>
        public bool Init_from_DB()
        {
            if (this.GroupID < 0) return false;

            HssUtility.SQLserver.DB_select db_sel = new HssUtility.SQLserver.DB_select(ADR_Group.Get_cmdTP());
            db_sel.tableName = "ADR_Group";
            HssUtility.SQLserver.SQL_relation rela = new HssUtility.SQLserver.SQL_relation("GroupID", HssUtility.General.RelationalOperator.Equals, this.GroupID);
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

        internal void SyncWithDB()
        {
            this.Create_attrList();
            foreach (HssUtility.General.Attributes.I_modelAttr ma in this.attrList) ma.SyncWithDB();
        }

        public bool CheckValueChanges()
        {
            this.Create_attrList();
            foreach (HssUtility.General.Attributes.I_modelAttr ma in this.attrList) if (ma.ValueChanged) return true;
            return false;
        }

        private void Create_attrList()
        {
            if (this.attrList != null) return;

            this.attrList = new List<HssUtility.General.Attributes.I_modelAttr>();
            this.attrList.Add(this.GroupName);
            this.attrList.Add(this.Group_LeaderSID);
            this.attrList.Add(this.Group_Email);/*Optional 4*/
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
            HssUtility.SQLserver.DB_insert dbIns = new HssUtility.SQLserver.DB_insert(ADR_Group.Get_cmdTP());

            dbIns.AddValue("GroupName", this.GroupName.Value);
            dbIns.AddValue("Group_LeaderSID", this.Group_LeaderSID.Value);
            dbIns.AddValue("Group_Email", this.Group_Email);/*Optional 4*/

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

            HssUtility.SQLserver.DB_update upd = new HssUtility.SQLserver.DB_update(ADR_Group.Get_cmdTP());
            if (this.GroupName.ValueChanged) upd.AddValue("GroupName", this.GroupName);
            if (this.Group_LeaderSID.ValueChanged) upd.AddValue("Group_LeaderSID", this.Group_LeaderSID);
            if (this.Group_Email.ValueChanged) upd.AddValue("Group_Email", this.Group_Email);

            HssUtility.SQLserver.SQL_relation rela = new HssUtility.SQLserver.SQL_relation("GroupID", HssUtility.General.RelationalOperator.Equals, this.pk_ID);
            upd.SetCondition(rela);

            return upd;
        }

        public ADR_Group GetCopy()
        {
            ADR_Group newEntity = new ADR_Group();
            if (!this.GroupName.IsNull_flag) newEntity.GroupName.Value = this.GroupName.Value;
            if (!this.Group_LeaderSID.IsNull_flag) newEntity.Group_LeaderSID.Value = this.Group_LeaderSID.Value;
            if (!this.Group_Email.IsNull_flag) newEntity.Group_Email.Value = this.Group_Email.Value;
            return newEntity;
        }

        public string ToXML()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("<ADR_Group>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<GroupID>").Append(this.GroupID).Append("</GroupID>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<GroupName>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.GroupName.Value)).Append("</GroupName>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Group_LeaderSID>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.Group_LeaderSID.Value)).Append("</Group_LeaderSID>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Group_Email>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.Group_Email.Value)).Append("</Group_Email>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("</ADR_Group>").Append(HssUtility.General.HssStr.WinNextLine);
            return sb.ToString();
        }
        /*^^^^^^^^^^^^^^^^^^^^^^^^^^^^^Hss Entity Framework Auto Generated Code^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^*/

        public Dictionary<string, ADR_TaskOwner> TaskOwner_dic
        {
            get
            {
                Dictionary<string, ADR_TaskOwner> dic = TaskMemberMaster.Get_taskOwnerList_groupID(this.GroupID);
                if (!dic.ContainsKey(this.Group_LeaderSID.Value))//add leader's name if not exist
                    dic[this.Group_LeaderSID.Value] = TaskMemberMaster.Get_taskOwner_SID(this.Group_LeaderSID.Value);
                return dic;
            }
        }

        public List<Country> Country_list
        {
            get
            {
                Dictionary<string, Country> cty_dic = new Dictionary<string, Country>(StringComparer.OrdinalIgnoreCase);
                foreach (ADR_TaskOwner ato in this.TaskOwner_dic.Values)
                    foreach (Country cty in ato.Country_list) cty_dic[cty.name] = cty;
                return new List<Country>(cty_dic.Values);
            }
        }

        public ADR_TaskOwner GroupLeader
        {
            get { return TaskMemberMaster.Get_taskOwner_SID(this.Group_LeaderSID.Value); }
        }
    }
}
