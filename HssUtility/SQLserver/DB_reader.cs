using System;
using System.Data.SqlClient;
using System.Text;
using HssUtility.General.Attributes;

namespace HssUtility.SQLserver
{
    public class DB_reader
    {
        private SqlDataReader reader = null;
        private DB_select db_sel = null;

        public DB_reader(DB_select selt, hssDB hDB)
        {
            if (hDB == null || !hDB.Connected) return;
            if (selt == null) return;

            selt.DBname = hDB.DBname;
            this.db_sel = selt;

            SqlCommand cmd = selt.GetSQL_cmd();
            cmd.Connection = hDB.DB_connection;
            cmd.CommandTimeout = hssDB.CommandTimeout;
            this.reader = cmd.ExecuteReader();
        }

        public bool Read()
        {
            if (this.IsClosed) return false;

            bool flag = this.reader.Read();
            if (flag == false) this.reader.Close();

            return flag;
        }

        public string GetString(string colName)
        {
            if (!this.Check_getCol(colName)) return null;
            return this.reader[colName].ToString();
        }

        public void GetString(string colName, String_attr attr)
        {
            if (attr == null) return;
            if (!this.Check_getCol(colName)) return;

            object temp_obj = this.reader[colName];
            if (temp_obj == DBNull.Value) attr.IsNull_flag = true;
            else attr.Value = temp_obj.ToString();
        }

        public int GetInt(string colName, int defaultVal = 0)
        {
            if (!this.Check_getCol(colName)) return defaultVal;

            object temp_obj = this.reader[colName];
            if (temp_obj == DBNull.Value) return defaultVal;

            if (this.reader[colName].GetType() == typeof(byte)) return (byte)temp_obj;
            else if (this.reader[colName].GetType() == typeof(double))
            {
                double db_val = (double)temp_obj;
                return (int)db_val;
            }
            else return (int)temp_obj;
        }

        public void GetInt(string colName, Int_attr attr)
        {
            if (attr == null) return;
            if (!this.Check_getCol(colName)) return;

            object temp_obj = this.reader[colName];
            if (temp_obj == DBNull.Value) attr.IsNull_flag = true;
            else
            {
                if (this.reader[colName].GetType() == typeof(byte)) attr.Value = (byte)temp_obj;
                else if (this.reader[colName].GetType() == typeof(double))
                {
                    double db_val = (double)temp_obj;
                    attr.Value = (int)db_val;
                }
                else attr.Value = (int)temp_obj;  
            }
        }

        public long GetLong(string colName, long defaultVal = 0)
        {
            if (!this.Check_getCol(colName)) return defaultVal;

            object temp_obj = this.reader[colName];
            if (temp_obj == DBNull.Value) return defaultVal;

            return (long)temp_obj;
        }

        public void GetLong(string colName, Long_attr attr)
        {
            if (attr == null) return;
            if (!this.Check_getCol(colName)) return;

            object temp_obj = this.reader[colName];
            if (temp_obj == DBNull.Value) attr.IsNull_flag = true;
            else attr.Value = (long)temp_obj;
        }

        public decimal GetDecimal(string colName, decimal defaultVal = 0)
        {
            if (!this.Check_getCol(colName)) return defaultVal;

            object temp_obj = this.reader[colName];
            if (temp_obj == DBNull.Value) return defaultVal;

            if (this.reader[colName].GetType() == typeof(double))
            {
                double db_val = (double)temp_obj;
                return (decimal)db_val;
            }
            else return (decimal)temp_obj;
        }

        public void GetDecimal(string colName, Decimal_attr attr)
        {
            if (attr == null) return;
            if (!this.Check_getCol(colName)) return;

            object temp_obj = this.reader[colName];
            if (temp_obj == DBNull.Value) attr.IsNull_flag = true;
            else
            {
                if (this.reader[colName].GetType() == typeof(double))
                {
                    double db_val = (double)temp_obj;
                    attr.Value = (decimal)db_val;
                }
                else attr.Value = (decimal)temp_obj;
            }
        }

        public DateTime GetDateTime(string colName, DateTime defaultVal = default(DateTime))
        {
            if (!this.Check_getCol(colName)) return defaultVal;

            object temp_obj = this.reader[colName];
            if (temp_obj == DBNull.Value) return defaultVal;

            return (DateTime)temp_obj;
        }

        public void GetDateTime(string colName, DateTime_attr attr)
        {
            if (attr == null) return;
            if (!this.Check_getCol(colName)) return;

            object temp_obj = this.reader[colName];
            if (temp_obj == DBNull.Value) attr.IsNull_flag = true;
            else attr.Value = (DateTime)temp_obj;
        }

        public bool GetBool(string colName, bool defaultVal = false)
        {
            if (!this.Check_getCol(colName)) return defaultVal;

            object temp_obj = this.reader[colName];
            if (temp_obj == DBNull.Value) return defaultVal;

            return (bool)temp_obj;
        }

        public void GetBool(string colName, Bool_attr attr)
        {
            if (attr == null) return;
            if (!this.Check_getCol(colName)) return;

            object temp_obj = this.reader[colName];
            if (temp_obj == DBNull.Value) attr.IsNull_flag = true;
            else attr.Value = (bool)temp_obj;
        }

        public byte[] GetBytes(string colName)
        {
            if (!this.Check_getCol(colName)) return null;

            object temp_obj = this.reader[colName];
            if (temp_obj == DBNull.Value) return null;

            return (byte[])this.reader[colName];
        }

        public bool IsClosed
        {
            get
            {
                if (this.reader == null) return true;
                return this.reader.IsClosed;
            }
        }

        private bool Check_getCol(string colName)
        {
            if (this.IsClosed) return false;
            if (!this.db_sel.Exist_sel_column(colName)) return false;

            return true;
        }

        public void Close()
        {
            if (this.reader != null) this.reader.Close();
        }

        internal string ReaderInfo
        {
            get
            {
                StringBuilder sb = new StringBuilder();

                foreach (string col in this.db_sel.ColumnName_hs)
                {
                    sb.Append(col).Append(":").Append(this.reader[col]);
                    sb.Append("\n");
                }

                return sb.ToString();
            }
        }

        ~DB_reader()
        {
            //Console.WriteLine("hss test output: DB_reader destroyed");
            this.Close();
        }
    }
}
