using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace HssUtility.SQLserver
{
    public class hssDB
    {
        public const int CommandTimeout = 120;

        internal readonly SqlConnection DB_connection = null;

        public readonly bool Connected = false;
        public string DBname { get { return this.DB_connection.Database; } }

        /// <summary>
        /// Constructor of the class. Connection is opened here
        /// </summary>
        /// <param name="connStr"></param>
        public hssDB(string connStr)
        {
            try
            {
                this.DB_connection = new SqlConnection(connStr);                
                this.DB_connection.Open();
                this.Connected = true;
            }
            catch { this.Connected = false; }
        }

        /// <summary>
        /// Get SqlCommand based on sql, often used for parameterized query or transactions
        /// </summary>
        /// <param name="sql">query string</param>
        public SqlCommand GetSQLcmd(string sql)
        {
            if (string.IsNullOrEmpty(sql)) return null;

            SqlCommand cmd = new SqlCommand(sql);
            cmd.Connection = this.DB_connection;
            return cmd;
        }

        /// <summary>
        /// Execute non-query commands
        /// </summary>
        public int ExeNonQuery(string sql)
        {
            return this.ExeNonQuery(this.GetSQLcmd(sql));
        }
        public int ExeNonQuery(SqlCommand cmd, bool withTryCatch = true)
        {
            if (cmd == null) return -2;
            if (cmd.Connection == null) cmd.Connection = this.DB_connection;

            int res = -1;

            if (withTryCatch)
            {
                try { res = cmd.ExecuteNonQuery(); }
                catch (Exception ex) { Console.WriteLine("hssDB error 0: ExeNonQuery failed\n" + ex.ToString()); }
            }
            else res = cmd.ExecuteNonQuery();

            return res;
        }
        public int ExeNonQuery(List<SqlCommand> cmd_list, bool withTrans = true)
        {
            if (cmd_list == null || cmd_list.Count < 1) return -2;

            SqlTransaction trans = null;
            if (withTrans)
            {
                trans = this.DB_connection.BeginTransaction();
                foreach (SqlCommand cmd in cmd_list) cmd.Transaction = trans;
            }

            int res = 0;
            foreach (SqlCommand cmd in cmd_list)
            {
                if (cmd == null) continue;
                if (cmd.Connection == null) cmd.Connection = this.DB_connection;
                res += cmd.ExecuteNonQuery();
            }
            if (trans != null) trans.Commit();

            return res;
        }
        public int ExeNonQuery(List<string> sql_list, bool withTrans = true)
        {
            if (sql_list == null || sql_list.Count < 1) return -2;

            List<SqlCommand> cmd_list = new List<SqlCommand>();
            foreach (string sql in sql_list)
            {
                SqlCommand cmd = this.GetSQLcmd(sql);
                cmd_list.Add(cmd);
            }

            return this.ExeNonQuery(cmd_list, withTrans);
        }

        /// <summary>
        /// Query results from DB and return as DatSet
        /// </summary>
        public DataSet QueryDS(string sql)
        {
            return this.QueryDS(this.GetSQLcmd(sql));
        }

        /// <summary>
        /// Query results from DB and return as DatSet
        /// </summary>
        public DataSet QueryDS(SqlCommand cmd)
        {
            DataSet ds = new DataSet();
            if (cmd == null) return ds;

            if (cmd.Connection == null) cmd.Connection = this.DB_connection;
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;

            adapter.Fill(ds);
            return ds;
        }

        /// <summary>
        /// Close DB connection
        /// </summary>
        public void Close()
        {
            this.DB_connection.Close();
        }

        /*--------------------------------------------------------------------------------------------------------------------*/
        private Dictionary<string, HashSet<string>> schemaTable_dic = null;//[Schema] as Key

        public bool ContainsTable(string tableName, string schema = "dbo")
        {
            this.Init_schemaTable_dic();
            if (string.IsNullOrEmpty(tableName) || string.IsNullOrEmpty(schema)) return false;

            if (this.schemaTable_dic.ContainsKey(schema)) return this.schemaTable_dic[schema].Contains(tableName);
            else return false;
        }

        private void Init_schemaTable_dic()
        {
            if (this.schemaTable_dic != null) return;

            this.schemaTable_dic = new Dictionary<string, HashSet<string>>(StringComparer.OrdinalIgnoreCase);

            DB_select selt = new DB_select(TableSchema.Get_cmdTP());
            DB_reader reader = null;
            
            try { reader = new DB_reader(selt, this); }
            catch (Exception ex)
            {
                Console.WriteLine("hssDB error 1: " + ex.ToString());
                return;
            }

            while (reader.Read())
            {
                TableSchema ts = new TableSchema();
                ts.Init_from_reader(reader);

                if (!this.schemaTable_dic.ContainsKey(ts.TABLE_SCHEMA))
                {
                    HashSet<string> table_hs = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
                    this.schemaTable_dic[ts.TABLE_SCHEMA] = table_hs;
                }
                this.schemaTable_dic[ts.TABLE_SCHEMA].Add(ts.TABLE_NAME);
            }
            reader.Close();
        }
        /*^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^*/
    }

    class TableSchema
    {
        private static CmdTemplate DBcmd_TP = null;
        public static CmdTemplate Get_cmdTP()
        {
            if (TableSchema.DBcmd_TP != null) return TableSchema.DBcmd_TP;

            TableSchema.DBcmd_TP = new CmdTemplate();
            TableSchema.DBcmd_TP.schema = "INFORMATION_SCHEMA";
            TableSchema.DBcmd_TP.tableName = "TABLES";

            TableSchema.DBcmd_TP.AddColumn("TABLE_SCHEMA");
            TableSchema.DBcmd_TP.AddColumn("TABLE_NAME");

            return TableSchema.DBcmd_TP;
        }

        public string TABLE_SCHEMA, TABLE_NAME;

        internal void Init_from_reader(DB_reader reader)
        {
            if (reader == null || reader.IsClosed) return;

            this.TABLE_SCHEMA = reader.GetString("TABLE_SCHEMA");
            this.TABLE_NAME = reader.GetString("TABLE_NAME");
        }
    }
}
