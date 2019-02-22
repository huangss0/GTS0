using System.Collections.Generic;
using HssDARWIN.Models.Details;
using HssDARWIN.Models.DTC_Position;
using HssUtility.SQLserver;

namespace HssDARWIN.Models.DTC_Participant
{
    public class ParticipantMaster
    {
        /// <summary>
        /// [DTC] as key
        /// </summary>
        private Dictionary<int, Participant> parti_dic = new Dictionary<int, Participant>();

        public void Init_from_DDlist(List<Dividend_Detail_simpleEF> dd_list)
        {
            if (dd_list == null) return;

            HashSet<int> hs = new HashSet<int>();
            foreach (Dividend_Detail_simpleEF dd in dd_list)
            {
                string tempStr = dd.DTC_Number.Value;
                int tempInt = -1;
                if (int.TryParse(tempStr, out tempInt)) hs.Add(tempInt);
            }

            this.Init_from_DB(hs);
        }

        public void Init_from_dtcPosList(List<Dividend_DTC_Position> pos_list)
        {
            if (pos_list == null) return;

            HashSet<int> hs = new HashSet<int>();
            foreach (Dividend_DTC_Position pos in pos_list)
            {
                string tempStr = pos.DTC_Number.Value;
                int tempInt = -1;
                if (int.TryParse(tempStr, out tempInt)) hs.Add(tempInt);
            }

            this.Init_from_DB(hs);
        }

        public void Init_from_dtcPosList(List<Position> pos_list)
        {
            if (pos_list == null) return;

            HashSet<int> hs = new HashSet<int>();
            foreach (Position pos in pos_list)
            {
                string tempStr = pos.DTC_Number;
                int tempInt = -1;
                if (int.TryParse(tempStr, out tempInt)) hs.Add(tempInt);
            }

            this.Init_from_DB(hs);
        }

        private void Init_from_DB(HashSet<int> dtcNum_hs)
        {
            this.Reset();
            Participant.Init_cmdTP();
            DB_select selt = new DB_select(Participant.DBcmd_TP);
            SQL_relation rela = new SQL_relation("DTC", true, dtcNum_hs);
            selt.SetCondition(rela);

            DB_reader reader = new DB_reader(selt, Utility.Get_DRWIN_hDB());
            while (reader.Read())
            {
                Participant pi = new Participant();
                pi.Init_from_reader(reader);
                this.parti_dic[pi.DTC] = pi;
            }
            reader.Close();
        }

        public Participant GetParticipant(string dtc_str)
        {
            int dtc = -1;
            if (int.TryParse(dtc_str, out dtc)) return this.GetParticipant(dtc);
            else return null;
        }

        public Participant GetParticipant(int dtc)
        {
            if (this.parti_dic.ContainsKey(dtc)) return this.parti_dic[dtc];
            else return null;
        }

        public void Reset()
        {
            this.parti_dic.Clear();
        }
    }
}
