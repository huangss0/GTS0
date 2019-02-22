using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

using HssUtility.General;
using HssUtility.General.Attributes;

namespace HssUtility.SQLserver
{
    public class DB_update : I_DBcmd
    {
        private CmdTemplate template = null;
        private Dictionary<string, SqlParameter> col_val_dic = new Dictionary<string, SqlParameter>(StringComparer.OrdinalIgnoreCase);

        public string DBname = null, schema = null, tableName = null;
        private SQL_condition condition = null;

        public DB_update(CmdTemplate tp)
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
            if (attr == null) return false;
            if (this.template == null || !this.template.Exist_colName(colName, false)) return false;

            SqlParameter sp = new SqlParameter();

            if (attr.IsNull_flag) sp.Value = DBNull.Value;
            else sp.Value = attr.Value;

            sp.SqlDbType = SqlDbType.Int;
            this.col_val_dic[colName] = sp;

            return true;
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
            if (this.template == null || !this.template.Exist_colName(colName, false)) return false;

            SqlParameter sp = new SqlParameter();

            if (attr.IsNull_flag) sp.Value = DBNull.Value;
            else sp.Value = attr.Value;

            sp.SqlDbType = SqlDbType.BigInt;
            this.col_val_dic[colName] = sp;

            return true;
        }

        public bool AddValue(string colName, string val)
        {
            if (this.template == null || !this.template.Exist_colName(colName, false)) return false;

            SqlParameter sp = new SqlParameter();
            if (val == null) sp.Value = DBNull.Value;
            else sp.Value = val;
            sp.SqlDbType = SqlDbType.NVarChar;
            this.col_val_dic[colName] = sp;

            return true;
        }
        public bool AddValue(string colName, String_attr attr)
        {
            if (attr == null) return false;
            if (this.template == null || !this.template.Exist_colName(colName, false)) return false;

            SqlParameter sp = new SqlParameter();

            if (attr.IsNull_flag || attr.Value == null) sp.Value = DBNull.Value;
            else sp.Value = attr.Value;

            sp.SqlDbType = SqlDbType.NVarChar;
            this.col_val_dic[colName] = sp;

            return true;
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
            if (this.template == null || !this.template.Exist_colName(colName, false)) return false;

            SqlParameter sp = new SqlParameter();

            if(attr.IsNull_flag) sp.Value = DBNull.Value;
            else sp.Value = attr.Value;

            sp.SqlDbType = SqlDbType.Decimal;
            this.col_val_dic[colName] = sp;

            return true;
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
            if (this.template == null || !this.template.Exist_colName(colName, false)) return false;

            SqlParameter sp = new SqlParameter();

            if (attr.IsNull_flag) sp.Value = DBNull.Value;
            else sp.Value = attr.Value;

            sp.SqlDbType = SqlDbType.Bit;
            this.col_val_dic[colName] = sp;

            return true;
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
            if (this.template == null || !this.template.Exist_colName(colName, false)) return false;

            SqlParameter sp = new SqlParameter();

            if (attr.IsNull_flag) sp.Value = DBNull.Value;
            else sp.Value = attr.Value;

            sp.SqlDbType = SqlDbType.DateTime;
            this.col_val_dic[colName] = sp;

            return true;
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

        public bool AddNull(string colName)
        {
            string val = null;
            return this.AddValue(colName, val);
        }

        public void SetCondition(SQL_relation rela)
        {
            SQL_condition cond = new SQL_condition(rela);
            this.condition = cond;
        }

        public void SetCondition(SQL_condition cond)
        {
            this.condition = cond;
        }

        public SqlCommand GetSQL_cmd()
        {
            if (this.template == null)
            {
                Console.WriteLine("DB_update error 0: no template");
                return null;
            }
            if (string.IsNullOrEmpty(this.DBname) || string.IsNullOrEmpty(this.schema) || string.IsNullOrEmpty(this.tableName))
            {
                Console.WriteLine("DB_update error 1: no name");
                return null;
            }
            if (col_val_dic.Count < 1)
            {
                Console.WriteLine("DB_update error 2: no column");
                return null;
            }

            if (!this.ExistCondition())
            {
                if (MessageBox.Show("No condition in update SQL", "Warning", MessageBoxButtons.YesNo) != DialogResult.Yes)
                    return null;
            }

            StringBuilder sql_sb = new StringBuilder("Update ");
            sql_sb.Append("[" + this.DBname.Replace("]", "]]") + "]");
            sql_sb.Append(".");
            sql_sb.Append("[" + this.schema.Replace("]", "]]") + "]");
            sql_sb.Append(".");
            sql_sb.Append("[" + this.tableName.Replace("]", "]]") + "]");
            sql_sb.Append(" set ");

            StringBuilder val_sb = new StringBuilder();
            SqlCommand cmd = new SqlCommand();
            int tempID = 0;
            foreach (KeyValuePair<string, SqlParameter> pair in this.col_val_dic)
            {
                string colName = pair.Key.Replace("]", "]]");
                string valName = "@Val" + tempID;

                val_sb.Append("[").Append(colName).Append("]");
                val_sb.Append(" = ");
                val_sb.Append(valName).Append(", ");

                SqlParameter val_sp = new SqlParameter();
                val_sp.Value = pair.Value.Value;
                val_sp.SqlDbType = pair.Value.SqlDbType;
                val_sp.ParameterName = valName;

                cmd.Parameters.Add(val_sp);
                ++tempID;
            }
            HssStr.RemoveLastChar(val_sb, ',');

            sql_sb.Append(val_sb);
            if (this.ExistCondition()) sql_sb.Append(" where ").Append(this.condition.SQL_str);

            cmd.CommandText = sql_sb.ToString();
            return cmd;
        }

        public void SetDBname(string name) { this.DBname = name; }

        private bool ExistCondition()
        {
            if (this.condition == null || string.IsNullOrEmpty(this.condition.SQL_str)) return false;
            else return true;
        }

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
