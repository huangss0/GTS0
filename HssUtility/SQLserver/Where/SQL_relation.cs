using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using HssUtility.General;

namespace HssUtility.SQLserver
{
    public class SQL_relation
    {
        public readonly string SQL_str = null;

        public SQL_relation(string colName, RelationalOperator opt, string val_str)
        {
            this.SQL_str = this.Init_RO(colName, opt, val_str);
        }
        public SQL_relation(string colName, RelationalOperator opt, int val_int)
        {
            this.SQL_str = this.Init_RO(colName, opt, val_int.ToString());
        }
        public SQL_relation(string colName, RelationalOperator opt, decimal val_dc)
        {
            this.SQL_str = this.Init_RO(colName, opt, val_dc.ToString());
        }
        public SQL_relation(string colName, RelationalOperator opt, bool val_bool)
        {
            this.SQL_str = this.Init_RO(colName, opt, val_bool.ToString());
        }
        public SQL_relation(string colName, RelationalOperator opt, DateTime val_dt)
        {
            this.SQL_str = this.Init_RO(colName, opt, val_dt.ToString());
        }

        public SQL_relation(string colName, bool inFlag, HashSet<string> strVal_hs)
        {
            this.SQL_str = this.Init_in(colName, inFlag, strVal_hs);
        }
        public SQL_relation(string colName, bool inFlag, List<string> strVal_list)
        {
            HashSet<string> strVal_hs = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
            foreach (string str in strVal_list)
            {
                if (str == null) continue;
                else strVal_hs.Add(str);
            }
            this.SQL_str = this.Init_in(colName, inFlag, strVal_hs);
        }
        public SQL_relation(string colName, bool inFlag, HashSet<int> intVal_hs)
        {
            HashSet<string> strVal_hs = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
            foreach (int intVal in intVal_hs) strVal_hs.Add(intVal.ToString());

            this.SQL_str = this.Init_in(colName, inFlag, strVal_hs);
        }
        public SQL_relation(string colName, bool inFlag, List<int> intVal_list)
        {
            HashSet<string> strVal_hs = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
            foreach (int intVal in intVal_list) strVal_hs.Add(intVal.ToString());

            this.SQL_str = this.Init_in(colName, inFlag, strVal_hs);
        }

        /*--------------------------------------------------------------------------------------------------------*/
        /// <summary>
        /// For in statement. e.g. "where [ID] in ('1','2')"
        /// </summary>
        /// <param name="colName">column name</param>
        /// <param name="inFlag">true for in, false for not in</param>
        /// <param name="val_hs">list of values</param>
        private string Init_in(string colName, bool inFlag, HashSet<string> val_hs)
        {
            if (string.IsNullOrEmpty(colName)) return null;
            if (val_hs == null) return null;

            StringBuilder list_sb = new StringBuilder();
            foreach (string str in val_hs)
            {
                if (str == null) continue;

                string val_str = str.Replace("'", "''");
                list_sb.Append("'").Append(val_str).Append("'").Append(',');
            }
            HssStr.RemoveLastChar(list_sb, ',');

            StringBuilder sql_sb = new StringBuilder();
            sql_sb.Append('[').Append(colName.Replace("]", "]]")).Append(']');

            sql_sb.Append(' ');
            if (inFlag) sql_sb.Append("in");
            else sql_sb.Append("not in");
            sql_sb.Append(' ');

            sql_sb.Append('(').Append(list_sb).Append(')');

            return sql_sb.ToString();
        }

        /// <summary>
        /// For statement other than 'in', like =,>,<
        /// </summary>
        /// <param name="colName">column name</param>
        /// <param name="opt">operater</param>
        /// <param name="val_str">value in string</param>
        /// <returns></returns>
        private string Init_RO(string colName, RelationalOperator opt, string val_str)
        {
            StringBuilder sb = new StringBuilder();
            if (string.IsNullOrEmpty(colName)) return null;

            sb.Append('[').Append(colName.Replace("]", "]]")).Append(']');

            if (val_str == null)
            {
                if (opt == RelationalOperator.Equals) sb.Append(" is NULL ");                
                else sb.Append(" is not NULL ");
            }
            else
            {
                sb.Append(' ').Append(SQL_relation.Operater_to_str(opt)).Append(' ');
                sb.Append("'").Append(val_str.Replace("'", "''")).Append("'");
            }

            return sb.ToString();
        }

        /************************************************************************************************************/

        public static string Operater_to_str(RelationalOperator opt)
        {
            if (opt == RelationalOperator.Equals) return "=";
            if (opt == RelationalOperator.GreaterThan) return ">";
            if (opt == RelationalOperator.LessThan) return "<";
            if (opt == RelationalOperator.NotEqual) return "!=";
            if (opt == RelationalOperator.Greater_or_Equals) return ">=";
            if (opt == RelationalOperator.Less_or_Equals) return "<=";

            return null;
        }

        public static bool IsNull_or_Empty(SQL_relation rela)
        {
            if (rela == null) return true;
            return string.IsNullOrEmpty(rela.SQL_str);
        }
    }
}
