using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using HssUtility.General;

namespace HssUtility.SQLserver
{
    public class SQL_condition
    {
        public readonly string SQL_str = null;

        public SQL_condition(SQL_relation rela)
        {
            this.SQL_str = this.Create_SQL_str(rela);
        }
        public SQL_condition(SQL_relation rela1, ConditionalOperator opt, SQL_relation rela2)
        {
            this.SQL_str = this.Create_SQL_str(rela1, opt, rela2);
        }
        public SQL_condition(SQL_relation rela1, ConditionalOperator opt, SQL_condition con2)
        {
            this.SQL_str = this.Create_SQL_str(con2, opt, rela1);
        }
        public SQL_condition(SQL_condition con1, ConditionalOperator opt, SQL_relation rela2)
        {
            this.SQL_str = this.Create_SQL_str(con1, opt, rela2);
        }
        public SQL_condition(SQL_condition con1, ConditionalOperator opt, SQL_condition con2)
        {
            this.SQL_str = this.Create_SQL_str(con1, opt, con2);
        }

        /*-------------------------------------------------------------------------------------------------------------*/

        private string Create_SQL_str(SQL_relation rela)
        {
            if (rela == null) return null;
            else return rela.SQL_str;
        }
        private string Create_SQL_str(SQL_relation rela1, ConditionalOperator opt, SQL_relation rela2)
        {
            if (SQL_relation.IsNull_or_Empty(rela1) && SQL_relation.IsNull_or_Empty(rela2)) return null;
            if (SQL_relation.IsNull_or_Empty(rela1)) return rela2.SQL_str;
            if (SQL_relation.IsNull_or_Empty(rela2)) return rela1.SQL_str;

            SQL_condition con1 = new SQL_condition(rela1);
            SQL_condition con2 = new SQL_condition(rela2);
            return this.Create_SQL_str(con1, opt, con2);
        }
        private string Create_SQL_str(SQL_condition con1, ConditionalOperator opt, SQL_relation rela2)
        {
            if (SQL_condition.IsNull_or_Empty(con1) && SQL_relation.IsNull_or_Empty(rela2)) return null;
            if (SQL_condition.IsNull_or_Empty(con1)) return rela2.SQL_str;
            if (SQL_relation.IsNull_or_Empty(rela2)) return con1.SQL_str;

            SQL_condition con2 = new SQL_condition(rela2);
            return this.Create_SQL_str(con1, opt, con2);
        }
        private string Create_SQL_str(SQL_condition con1, ConditionalOperator opt, SQL_condition con2)
        {
            if (SQL_condition.IsNull_or_Empty(con1) && SQL_condition.IsNull_or_Empty(con2)) return null;
            if (SQL_condition.IsNull_or_Empty(con1)) return con2.SQL_str;
            if (SQL_condition.IsNull_or_Empty(con2)) return con1.SQL_str;

            StringBuilder sb = new StringBuilder("(");
            sb.Append(con1.SQL_str);
            sb.Append(' ').Append(opt.ToString()).Append(' ');
            sb.Append(con2.SQL_str);
            sb.Append(')');

            return sb.ToString();
        }

        /***************************************************************************************************************/

        public static bool IsNull_or_Empty(SQL_condition cond)
        {
            if (cond == null) return true;
            return string.IsNullOrEmpty(cond.SQL_str);
        }
    }
}
