using System;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace HssUtility.SQLserver
{
    public class DB_delete : I_DBcmd
    {
        public string DBname = null, schema = "dbo", tableName = null;
        private SQL_condition condition = null;

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
            if (string.IsNullOrEmpty(this.DBname) || string.IsNullOrEmpty(this.schema) || string.IsNullOrEmpty(this.tableName))
            {
                Console.WriteLine("DB_update error 1: no name");
                return null;
            }

            if (!this.ExistCondition())
            {
                if (MessageBox.Show("No condition in delete SQL", "Warning", MessageBoxButtons.YesNo) != DialogResult.Yes)
                    return null;
            }

            StringBuilder sql_sb = new StringBuilder("Delete from ");
            sql_sb.Append("[" + this.DBname.Replace("]", "]]") + "]");
            sql_sb.Append(".");
            sql_sb.Append("[" + this.schema.Replace("]", "]]") + "]");
            sql_sb.Append(".");
            sql_sb.Append("[" + this.tableName.Replace("]", "]]") + "]");

            if (this.ExistCondition()) sql_sb.Append(" where ").Append(this.condition.SQL_str);

            SqlCommand cmd = new SqlCommand(sql_sb.ToString());
            return cmd;
        }

        public void SetDBname(string name) { this.DBname = name; }

        public int SaveToDB(hssDB hDB)
        {
            if (hDB == null || !hDB.Connected) return -1;

            this.DBname = hDB.DBname;
            SqlCommand cmd = this.GetSQL_cmd();
            cmd.Connection = hDB.DB_connection;

            int count = hDB.ExeNonQuery(cmd, false);
            return count;
        }

        private bool ExistCondition()
        {
            if (this.condition == null || string.IsNullOrEmpty(this.condition.SQL_str)) return false;
            else return true;
        }
    }
}
