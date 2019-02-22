using System;

using System.Collections.Generic;
using System.Data.SqlClient;

namespace HssUtility.SQLserver
{
    public class Bulk_DBcmd
    {
        public const int BatchAmount = 512;

        /// <summary>
        /// Number of commands executed in one batch
        /// </summary>
        public int OneTimeAmount = Bulk_DBcmd.BatchAmount;
        private List<I_DBcmd> DBcmd_list = new List<I_DBcmd>();

        public void Add_DBcmd(I_DBcmd DBin)
        {
            if (DBin == null) return;
            this.DBcmd_list.Add(DBin);
        }

        public int SaveToDB(hssDB hDB)
        {
            if (hDB == null || !hDB.Connected) return -2;

            List<SqlCommand> cmd_list = new List<SqlCommand>();
            int count = 0;

            foreach (I_DBcmd di in this.DBcmd_list)
            {
                di.SetDBname(hDB.DBname);
                SqlCommand cmd = di.GetSQL_cmd();
                cmd_list.Add(cmd);

                if (cmd_list.Count >= this.OneTimeAmount)
                {
                    count += hDB.ExeNonQuery(cmd_list);
                    cmd_list.Clear();

                    //Console.WriteLine("Bulk_DBcmd info: count=" + count);
                }
            }

            if (cmd_list.Count > 0) count += hDB.ExeNonQuery(cmd_list);

            return count;
        }

        public int Count { get { return this.DBcmd_list.Count; } }

        public void Clear()
        {
            this.DBcmd_list.Clear();
        }
    }
}
