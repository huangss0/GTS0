using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

using System.Data.SqlClient;
using HssUtility.General;
using HssUtility.General.Attributes;

namespace HssUtility.SQLserver
{
    public class DB_insert : I_DBcmd
    {
        private CmdTemplate template = null;

        public string DBname = null, schema = null, tableName = null;
        private Dictionary<string, SqlParameter> col_val_dic = new Dictionary<string, SqlParameter>(StringComparer.OrdinalIgnoreCase);

        public DB_insert(CmdTemplate tp)
        {
            this.template = tp;

            this.DBname = tp.DBname;
            this.schema = tp.schema;
            this.tableName = tp.tableName;
        }

        public bool AddValue(string colName, int val)
        {
            if (this.template == null || !this.template.Exist_colName(colName, false)) return false;

            SqlParameter sp = new SqlParameter();
            sp.Value = val;
            sp.SqlDbType = SqlDbType.Int;
            this.col_val_dic[colName] = sp;

            return true;
        }
        public bool AddValue(string colName, Int_attr attr)
        {
            return this.AddValue(colName, attr, true);
        }
        public bool AddValue(string colName, Int_attr attr, bool ignoreNull_flag)
        {
            if (attr == null) return false;

            if (attr.IsNull_flag)
            {
                if (ignoreNull_flag) return false;

                SqlParameter sp = new SqlParameter();
                sp.Value = DBNull.Value;
                sp.SqlDbType = SqlDbType.Int;
                this.col_val_dic[colName] = sp;

                return true;
            }
            else return this.AddValue(colName, attr.Value);
        }

        public bool AddValue(string colName, long val)
        {
            if (this.template == null || !this.template.Exist_colName(colName, false)) return false;

            SqlParameter sp = new SqlParameter();
            sp.Value = val;
            sp.SqlDbType = SqlDbType.BigInt;
            this.col_val_dic[colName] = sp;

            return true;
        }
        public bool AddValue(string colName, Long_attr attr)
        {
            if (attr == null) return false;
            if (attr.IsNull_flag) return false;
            return this.AddValue(colName, attr.Value);
        }

        public bool AddValue(string colName, string val)
        {
            return this.AddValue(colName, val, true);
        }
        public bool AddValue(string colName, string val, bool ignoreNull_flag)
        {
            if (this.template == null || !this.template.Exist_colName(colName, false)) return false;
            if (val == null && ignoreNull_flag) return false;

            SqlParameter sp = new SqlParameter();
            sp.Value = val;
            sp.SqlDbType = SqlDbType.NVarChar;
            this.col_val_dic[colName] = sp;

            return true;
        }
        public bool AddValue(string colName, String_attr attr)
        {
            if (attr == null) return false;
            if (attr.IsNull_flag) return false;
            return this.AddValue(colName, attr.Value);
        }

        public bool AddValue(string colName, decimal val)
        {
            if (this.template == null || !this.template.Exist_colName(colName, false)) return false;

            SqlParameter sp = new SqlParameter();
            sp.Value = val;
            sp.SqlDbType = SqlDbType.Decimal;
            this.col_val_dic[colName] = sp;

            return true;
        }
        public bool AddValue(string colName, Decimal_attr attr)
        {
            if (attr == null) return false;
            if (attr.IsNull_flag) return false;
            return this.AddValue(colName, attr.Value);
        }

        public bool AddValue(string colName, bool val)
        {
            if (this.template == null || !this.template.Exist_colName(colName, false)) return false;

            SqlParameter sp = new SqlParameter();
            sp.Value = val;
            sp.SqlDbType = SqlDbType.Bit;
            this.col_val_dic[colName] = sp;

            return true;
        }
        public bool AddValue(string colName, Bool_attr attr)
        {
            if (attr == null) return false;
            if (attr.IsNull_flag) return false;
            return this.AddValue(colName, attr.Value);
        }

        public bool AddValue(string colName, DateTime val)
        {
            if (this.template == null || !this.template.Exist_colName(colName, false)) return false;

            SqlParameter sp = new SqlParameter();
            sp.Value = val;
            sp.SqlDbType = SqlDbType.DateTime;
            this.col_val_dic[colName] = sp;

            return true;
        }
        public bool AddValue(string colName, DateTime_attr attr)
        {
            if (attr == null) return false;
            if (attr.IsNull_flag) return false;
            return this.AddValue(colName, attr.Value);
        }

        public bool AddValue(string colName, byte[] byteArr)
        {
            if (this.template == null || !this.template.Exist_colName(colName, false)) return false;

            SqlParameter sp = new SqlParameter();
            sp.Value = byteArr;
            sp.SqlDbType = SqlDbType.VarBinary;
            this.col_val_dic[colName] = sp;

            return true;
        }

        public SqlCommand GetSQL_cmd()
        {
            if (this.template == null)
            {
                Console.WriteLine("DB_insert error 0: no template");
                return null;
            }
            if (string.IsNullOrEmpty(this.DBname) || string.IsNullOrEmpty(this.schema) || string.IsNullOrEmpty(this.tableName))
            {
                Console.WriteLine("DB_insert error 1: no name");
                return null;
            }
            if (col_val_dic.Count < 1)
            {
                Console.WriteLine("DB_insert error 2: no column");
                return null;
            }

            StringBuilder sql_sb = new StringBuilder("Insert into ");
            sql_sb.Append("[" + this.DBname.Replace("]", "]]") + "]");
            sql_sb.Append(".");
            sql_sb.Append("[" + this.schema.Replace("]", "]]") + "]");
            sql_sb.Append(".");
            sql_sb.Append("[" + this.tableName.Replace("]", "]]") + "] ");

            int tempID = 0;
            SqlCommand cmd = new SqlCommand();
            StringBuilder col_sb = new StringBuilder(), val_sb = new StringBuilder();
            foreach (KeyValuePair<string, SqlParameter> pair in this.col_val_dic)
            {
                string colName = pair.Key.Replace("]", "]]");
                string valName = "@Val" + tempID;

                col_sb.Append("[").Append(colName).Append("]").Append(',');
                val_sb.Append(valName).Append(',');

                SqlParameter val_sp = new SqlParameter();
                val_sp.Value = pair.Value.Value;
                val_sp.SqlDbType = pair.Value.SqlDbType;
                val_sp.ParameterName = valName;

                cmd.Parameters.Add(val_sp);
                ++tempID;
            }

            HssStr.RemoveLastChar(col_sb, ',');
            HssStr.RemoveLastChar(val_sb, ',');

            sql_sb.Append("(").Append(col_sb).Append(")");
            sql_sb.Append(" values ");
            sql_sb.Append("(").Append(val_sb).Append(") ");

            cmd.CommandText = sql_sb.ToString();
            return cmd;
        }

        public void SetDBname(string name) { this.DBname = name; }

        public int SaveToDB(hssDB hDB)
        {
            if (hDB == null || !hDB.Connected) return -2;

            this.DBname = hDB.DBname;
            SqlCommand cmd = this.GetSQL_cmd();
            cmd.Connection = hDB.DB_connection;

            int count = hDB.ExeNonQuery(cmd, false);
            return count;
        }
    }
}
