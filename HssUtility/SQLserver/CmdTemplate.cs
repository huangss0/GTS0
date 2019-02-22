using System;
using System.Collections.Generic;

namespace HssUtility.SQLserver
{
    public class CmdTemplate
    {
        public string DBname = "", schema = "dbo", tableName = "";

        private HashSet<string> aliaName_hs = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
        private Dictionary<string, ColumnTemplate> colTP_dic = new Dictionary<string, ColumnTemplate>(StringComparer.OrdinalIgnoreCase);

        public void AddColumn(string colName)
        {
            this.AddColumn(colName, AggregateFunction.None, null);
        }

        public void AddColumn(string colName, AggregateFunction af, string alia)
        {
            if (string.IsNullOrEmpty(colName)) return;

            ColumnTemplate ct = new ColumnTemplate(colName, af, alia);
            this.colTP_dic[colName] = ct;

            if (string.IsNullOrEmpty(alia)) aliaName_hs.Add(colName);
            else aliaName_hs.Add(alia);
        }

        public bool Exist_colName(string colName, bool checkAlia)
        {
            if (string.IsNullOrEmpty(colName)) return false;

            if (checkAlia) return this.aliaName_hs.Contains(colName);
            else return this.colTP_dic.ContainsKey(colName);
        }

        public void Reset()
        {
            this.DBname = "";
            this.schema = "dbo";
            this.tableName = "";
            this.colTP_dic.Clear();
        }

        /// <summary>
        /// Get a copy of all column templates
        /// </summary>
        /// <returns></returns>
        public HashSet<ColumnTemplate> Get_colTP_hs()
        {
            HashSet<ColumnTemplate> hs = new HashSet<ColumnTemplate>();
            foreach (ColumnTemplate ct in this.colTP_dic.Values) hs.Add(ct);
            return hs;
        }
    }

    public class ColumnTemplate
    {
        public readonly string ColName = null, aliaName = null;
        public readonly AggregateFunction AggregateFunc = AggregateFunction.None;

        public ColumnTemplate(string col) { this.ColName = col; }
        public ColumnTemplate(string col, AggregateFunction af, string aliaName)
        {
            this.ColName = col;
            this.AggregateFunc = af;
            this.aliaName = aliaName;
        }
    }

    public enum AggregateFunction
    {
        None = -1,
        Sum = 1,
    }
}
