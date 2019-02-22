using System;
using System.Text;
using System.Data.SqlClient;

namespace HssUtility.SQLserver
{
    public class Helper_SQLserver
    {
        public static void AllTrigers(string tableName, bool enable, hssDB hDB, string schema = "dbo")
        {
            if (string.IsNullOrEmpty(tableName) || string.IsNullOrEmpty(schema))
            {
                Console.WriteLine("Helper_SQLserver error 0: no table or schema");
                return;
            }
            if (hDB == null)
            {
                Console.WriteLine("Helper_SQLserver error 1: no hssDB");
                return;
            }

            StringBuilder sb = new StringBuilder();
            if (enable) sb.Append("Enable ");
            else sb.Append("Disable ");

            sb.Append("TRIGGER ALL ON [");
            sb.Append(hDB.DBname).Append("].[");
            sb.Append(schema).Append("].[");
            sb.Append(tableName).Append("]");

            int count = hDB.ExeNonQuery(sb.ToString());
        }

        public static void SetTriger(string tableName, string triggerName, bool enable, hssDB hDB, string schema = "dbo")
        {
            if (string.IsNullOrEmpty(tableName) || string.IsNullOrEmpty(schema) || string.IsNullOrEmpty(triggerName))
            {
                Console.WriteLine("Helper_SQLserver error 2: no table, triggerName or schema");
                return;
            }
            if (hDB == null)
            {
                Console.WriteLine("Helper_SQLserver error 3: no hssDB");
                return;
            }

            tableName = tableName.Replace("]", "]]");
            triggerName = triggerName.Replace("]", "]]");
            schema = schema.Replace("]", "]]");

            StringBuilder sb = new StringBuilder();
            if (enable) sb.Append("Enable ");
            else sb.Append("Disable ");

            sb.Append("TRIGGER [").Append(schema).Append("].[").Append(triggerName).Append("] ON [");
            sb.Append(hDB.DBname).Append("].[").Append(schema).Append("].[").Append(tableName).Append("]");

            int count = hDB.ExeNonQuery(sb.ToString());
        }

        public static long Get_nextSequenceValue(string schema, string sequenceName, hssDB hDB)
        {
            if (string.IsNullOrEmpty(sequenceName) || string.IsNullOrEmpty(schema))
            {
                Console.WriteLine("Helper_SQLserver error 4: no table or schema");
                return -1;
            }
            if (hDB == null)
            {
                Console.WriteLine("Helper_SQLserver error 5: no hssDB");
                return -1;
            }

            sequenceName = sequenceName.Replace("]", "]]");
            schema = schema.Replace("]", "]]");

            string sql = "SELECT NEXT VALUE FOR ["+ schema + "].["+ sequenceName + "]";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Connection = hDB.DB_connection;
            cmd.CommandTimeout = hssDB.CommandTimeout;
            SqlDataReader reader = cmd.ExecuteReader();

            long val = -2;
            if (reader.Read()) val = (long)reader[0];
            reader.Close();

            return val;
        }
    }
}
