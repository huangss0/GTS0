using System;
using System.Data.SqlClient;
using System.Text;
using System.Collections.Generic;

using HssUtility.General;

namespace HssUtility.SQLserver
{
    public class DB_select : I_DBcmd
    {
        public string DBname = "", schema = "dbo", tableName = "";
        public int Top = -1;

        private CmdTemplate template = null;
        private SQL_condition condition = null;
        private HashSet<string> excludeColumn_hs = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

        public DB_select(CmdTemplate tp)
        {
            this.template = tp;

            this.DBname = tp.DBname;
            this.schema = tp.schema;
            this.tableName = tp.tableName;
        }

        public bool Exist_sel_column(string colName)
        {
            if (this.template == null) return false;
            if (string.IsNullOrEmpty(colName)) return false;
            if (this.excludeColumn_hs.Contains(colName)) return false;

            return this.template.Exist_colName(colName, true);
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

        /// <summary>
        /// Get the SqlCommand for SQL server
        /// </summary>
        public SqlCommand GetSQL_cmd()
        {
            if (this.template == null)
            {
                Console.WriteLine("DB_select error 1: no template");
                return null;
            }
            if (string.IsNullOrEmpty(this.DBname) || string.IsNullOrEmpty(this.schema) || string.IsNullOrEmpty(tableName))
            {
                Console.WriteLine("DB_select error 0: no name");
                return null;
            }

            HashSet<ColumnTemplate> colTP_hs = this.GetQueryColumns();
            if (colTP_hs.Count == 0) return null;

            StringBuilder sql_sb = new StringBuilder("select ");
            StringBuilder top_sb = this.Get_top_sb();
            StringBuilder col_sb = this.Get_selectCol_sb(colTP_hs);
            StringBuilder from_sb = this.Get_from_sb();
            StringBuilder where_sb = this.Get_where_sb();
            StringBuilder groupBy_sb = this.Get_groupBy_sb(colTP_hs);

            sql_sb.Append(top_sb);
            sql_sb.Append(col_sb);
            sql_sb.Append(from_sb);
            sql_sb.Append(where_sb);
            sql_sb.Append(groupBy_sb);

            SqlCommand cmd = new SqlCommand(sql_sb.ToString());
            return cmd;
        }

        public void SetDBname(string name) { this.DBname = name; }

        private bool ExistCondition()
        {
            if (this.condition == null || string.IsNullOrEmpty(this.condition.SQL_str)) return false;
            else return true;
        }

        public void ClearCondition() { this.condition = null; }

        /// <summary>
        /// Add DoNot select column in SQL
        /// </summary>
        public void IgnoreColumn(string colName)
        {
            if (this.template == null) return;
            if (!this.template.Exist_colName(colName, false)) return;

            this.excludeColumn_hs.Add(colName);
        }

        public void Reset()
        {
            this.condition = null;
            this.excludeColumn_hs.Clear();
        }

        /*----------------------------------------------------------------------------------------------------*/
        private HashSet<ColumnTemplate> GetQueryColumns()
        {
            HashSet<ColumnTemplate> hs = new HashSet<ColumnTemplate>();
            if (this.template == null) return hs;

            HashSet<ColumnTemplate> all_hs = this.template.Get_colTP_hs();
            foreach (ColumnTemplate ct in all_hs)
            {
                if (this.excludeColumn_hs.Contains(ct.ColName)) continue;
                hs.Add(ct);
            }

            return hs;
        }

        private bool HasAggregateFunction(HashSet<ColumnTemplate> hs)
        {
            if (hs == null) return false;
            foreach (ColumnTemplate ct in hs)
            {
                if (ct.AggregateFunc != AggregateFunction.None) return true;
            }

            return false;
        }

        private StringBuilder Get_top_sb()
        {
            StringBuilder top_sb = new StringBuilder();
            if (this.Top > 0) top_sb.Append(" top ").Append(this.Top).Append(" ");
            return top_sb;
        }

        private StringBuilder Get_selectCol_sb(HashSet<ColumnTemplate> hs)
        {
            StringBuilder col_sb = new StringBuilder();
            if (hs == null || hs.Count == 0) return col_sb;

            foreach (ColumnTemplate ct in hs)
            {
                string colName = "[" + ct.ColName.Replace("]", "]]") + "]";
                string alia = ct.aliaName;

                if (ct.AggregateFunc == AggregateFunction.Sum)
                {
                    if (string.IsNullOrEmpty(alia)) alia = "sum_" + ct.ColName;
                    alia = "[" + alia.Replace("]", "]]") + "]";

                    col_sb.Append("Sum(").Append(colName).Append(") as ").Append(alia).Append(',');
                }
                else
                {
                    if (string.IsNullOrEmpty(alia)) col_sb.Append(colName).Append(',');
                    else
                    {
                        alia = "[" + alia.Replace("]", "]]") + "]";
                        col_sb.Append(colName).Append(" as ").Append(alia).Append(',');
                    }
                }
            }
            HssStr.RemoveLastChar(col_sb, ',');

            return col_sb;
        }

        private StringBuilder Get_from_sb()
        {
            StringBuilder from_sb = new StringBuilder();
            from_sb.Append(" from ");
            from_sb.Append("[" + this.DBname.Replace("]", "]]") + "]");
            from_sb.Append(".");
            from_sb.Append("[" + this.schema.Replace("]", "]]") + "]");
            from_sb.Append(".");
            from_sb.Append("[" + this.tableName.Replace("]", "]]") + "]");
            return from_sb;
        }

        private StringBuilder Get_where_sb()
        {
            StringBuilder where_sb = new StringBuilder();
            if (this.ExistCondition()) where_sb.Append(" where ").Append(this.condition.SQL_str);
            return where_sb;
        }

        private StringBuilder Get_groupBy_sb(HashSet<ColumnTemplate> hs)
        {
            StringBuilder groupBy_sb = new StringBuilder();
            if (!this.HasAggregateFunction(hs)) return groupBy_sb;

            groupBy_sb.Append(" Group by ");
            int non_aggCount = 0;
            foreach (ColumnTemplate ct in hs)
            {
                if (ct.AggregateFunc != AggregateFunction.None) continue;

                string colName = ct.ColName.Replace("]", "]]");
                groupBy_sb.Append("[").Append(colName).Append("]").Append(',');
                non_aggCount++;
            }
            HssStr.RemoveLastChar(groupBy_sb, ',');

            if (non_aggCount < 1) groupBy_sb.Clear();
            return groupBy_sb;
        }

        internal HashSet<string> ColumnName_hs
        {
            get
            {
                HashSet<string> hs = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
                if (this.template == null) return hs;

                foreach (ColumnTemplate ct in this.template.Get_colTP_hs())
                {
                    string colName = ct.ColName;
                    hs.Add(colName);
                }

                return hs;
            }
        }
    }
}
