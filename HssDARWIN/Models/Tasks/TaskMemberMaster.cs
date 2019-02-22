using System;
using System.Collections.Generic;

using HssUtility.SQLserver;

namespace HssDARWIN.Models.Tasks
{
    public class TaskMemberMaster
    {
        private static Dictionary<int, ADR_Group> group_dic = new Dictionary<int, ADR_Group>();
        private static Dictionary<string, ADR_Group_Member> groupMember_dic = new Dictionary<string, ADR_Group_Member>(StringComparer.OrdinalIgnoreCase);

        private static Dictionary<string, ADR_TaskOwner> owner_dic = new Dictionary<string, ADR_TaskOwner>(StringComparer.OrdinalIgnoreCase);//OwnerSID GroupID as key
        private static Dictionary<int, Dictionary<string, ADR_TaskOwner>> ownerList_dic = new Dictionary<int, Dictionary<string, ADR_TaskOwner>>();//ADR_Group's GroupID as key

        private static Dictionary<string, List<ADR_Member_Country>> country_dic = 
            new Dictionary<string, List<ADR_Member_Country>>(StringComparer.OrdinalIgnoreCase);//TaskOwner_SID as key

        private static DateTime lastUpdateTime = DateTime.MinValue;

        public static void Init_from_DB()
        {
            if ((DateTime.Now - TaskMemberMaster.lastUpdateTime).TotalHours < Utility.RefreshInterval) return;
            else TaskMemberMaster.Reset();

            TaskMemberMaster.Init_group_dic();
            TaskMemberMaster.Init_groupMember_dic();
            TaskMemberMaster.Init_owner_dic();
            TaskMemberMaster.Init_country_dic();

            TaskMemberMaster.lastUpdateTime = DateTime.Now;
        }

        public static ADR_Group Get_ADRgroup_ID(int id)
        {
            TaskMemberMaster.Init_from_DB();

            if (TaskMemberMaster.group_dic.ContainsKey(id)) return TaskMemberMaster.group_dic[id];
            else return null;
        }

        public static Dictionary<string, ADR_TaskOwner> Get_taskOwnerList_groupID(int groupID)
        {
            TaskMemberMaster.Init_from_DB();

            if (TaskMemberMaster.ownerList_dic.ContainsKey(groupID)) return TaskMemberMaster.ownerList_dic[groupID];
            else return new Dictionary<string, ADR_TaskOwner>(StringComparer.OrdinalIgnoreCase);
        }

        public static List<ADR_Group> GetGroup_list()
        {
            TaskMemberMaster.Init_from_DB();
            List<ADR_Group> list = new List<ADR_Group>();

            foreach (ADR_Group ag in TaskMemberMaster.group_dic.Values) list.Add(ag);
            list.Sort((a, b) => (string.Compare(a.GroupName.Value, b.GroupName.Value)));

            return list;
        }

        public static ADR_TaskOwner Get_taskOwner_SID(string sid)
        {
            TaskMemberMaster.Init_from_DB();
            if (string.IsNullOrEmpty(sid)) return null;

            if (TaskMemberMaster.owner_dic.ContainsKey(sid)) return TaskMemberMaster.owner_dic[sid];
            else return null;
        }

        public static List<ADR_Member_Country> Get_mcList_SID(string sid)
        {
            TaskMemberMaster.Init_from_DB();
            if (string.IsNullOrEmpty(sid)) return new List<ADR_Member_Country>();

            if (TaskMemberMaster.country_dic.ContainsKey(sid)) return TaskMemberMaster.country_dic[sid];
            else return new List<ADR_Member_Country>();
        }

        public static void Reset()
        {
            TaskMemberMaster.group_dic.Clear();
            TaskMemberMaster.groupMember_dic.Clear();
            TaskMemberMaster.owner_dic.Clear();
            TaskMemberMaster.ownerList_dic.Clear();
            TaskMemberMaster.country_dic.Clear();
            TaskMemberMaster.lastUpdateTime = DateTime.MinValue;
        }

        /*---------------------------------------------------------------------------------------------------------*/

        private static void Init_group_dic()
        {
            DB_select selt = new DB_select(ADR_Group.Get_cmdTP());
            DB_reader reader = new DB_reader(selt, Utility.Get_DRWIN_hDB());
            while (reader.Read())
            {
                ADR_Group ag = new ADR_Group();
                ag.Init_from_reader(reader);

                TaskMemberMaster.group_dic[ag.GroupID] = ag;
            }
            reader.Close();
        }

        private static void Init_groupMember_dic()
        {
            DB_select selt = new DB_select(ADR_Group_Member.Get_cmdTP());
            DB_reader reader = new DB_reader(selt, Utility.Get_DRWIN_hDB());
            while (reader.Read())
            {
                ADR_Group_Member agm = new ADR_Group_Member();
                agm.Init_from_reader(reader);

                TaskMemberMaster.groupMember_dic[agm.OwnerSID.Value] = agm;
            }
            reader.Close();
        }

        private static void Init_owner_dic()
        {
            DB_select selt = new DB_select(ADR_TaskOwner.Get_cmdTP());
            DB_reader reader = new DB_reader(selt, Utility.Get_DRWIN_hDB());
            while (reader.Read())
            {
                ADR_TaskOwner ato = new ADR_TaskOwner();
                ato.Init_from_reader(reader);

                string ownerSID = ato.OwnerSID.Value;
                TaskMemberMaster.owner_dic[ownerSID] = ato;
                if (!TaskMemberMaster.groupMember_dic.ContainsKey(ownerSID)) continue;

                int groupID = TaskMemberMaster.groupMember_dic[ownerSID].GroupID.Value;
                if (!TaskMemberMaster.ownerList_dic.ContainsKey(groupID))
                {
                    Dictionary<string, ADR_TaskOwner> dic = new Dictionary<string, ADR_TaskOwner>(StringComparer.OrdinalIgnoreCase);
                    TaskMemberMaster.ownerList_dic[groupID] = dic;
                }

                TaskMemberMaster.ownerList_dic[groupID][ato.OwnerSID.Value] = ato;
            }
            reader.Close();
        }

        private static void Init_country_dic()
        {
            DB_select selt = new DB_select(ADR_Member_Country.Get_cmdTP());
            DB_reader reader = new DB_reader(selt, Utility.Get_DRWIN_hDB());
            while (reader.Read())
            {
                ADR_Member_Country amc = new ADR_Member_Country();
                amc.Init_from_reader(reader);

                if (!TaskMemberMaster.country_dic.ContainsKey(amc.TaskOwner_SID.Value))
                {
                    List<ADR_Member_Country> list = new List<ADR_Member_Country>();
                    TaskMemberMaster.country_dic[amc.TaskOwner_SID.Value] = list;
                }
                TaskMemberMaster.country_dic[amc.TaskOwner_SID.Value].Add(amc);
            }
            reader.Close();
        }
    }
}
