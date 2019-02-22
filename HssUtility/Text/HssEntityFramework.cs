using System;
using System.Collections.Generic;
using System.Text;

using System.Windows.Forms;
using HssUtility.General;
using HssUtility.SQLserver;

namespace HssUtility.Text
{
    public class HssEntityFramework
    {
        public const string Attr_lib = "HssUtility.General.Attributes.";
        public const string General_lib = "HssUtility.General.";
        public const string SQL_lib = "HssUtility.SQLserver.";

        public string hDB_name = "Utility.Get_DRWIN_hDB()";
        public bool builtInDB_flag = true;

        private List<ColumnSchema> col_list = new List<ColumnSchema>();
        public string className, schema, tableName;

        public void SetTable(string tableName, string schema, hssDB hDB)
        {
            if (hDB == null || !hDB.Connected)
            {
                MessageBox.Show("AutoCreatClass error 0: No DB connection");
                return;
            }

            this.col_list.Clear();
            this.tableName = tableName;
            if (string.IsNullOrEmpty(this.className)) this.className = tableName;
            this.schema = schema;

            DB_select selt = new DB_select(ColumnSchema.Get_cmdTP());
            SQL_relation rela1 = new SQL_relation("TABLE_NAME", RelationalOperator.Equals, tableName);
            SQL_relation rela2 = new SQL_relation("TABLE_SCHEMA", RelationalOperator.Equals, schema);
            SQL_condition cond = new SQL_condition(new SQL_condition(rela1), ConditionalOperator.And, new SQL_condition(rela2));
            selt.SetCondition(cond);

            DB_reader reader = new DB_reader(selt, hDB);
            while (reader.Read())
            {
                ColumnSchema cs = new ColumnSchema();
                cs.Init_from_reader(reader);
                this.col_list.Add(cs);
            }
            reader.Close();

            this.col_list.Sort((a, b) => (a.ORDINAL_POSITION - b.ORDINAL_POSITION));
        }

        public string Run()
        {
            if (this.col_list.Count < 1)
            {
                MessageBox.Show("AutoCreatClass error 1: No data");
                return null;
            }

            StringBuilder sb = new StringBuilder();
            sb.Append("/*-----------------------------Hss Entity Framework Auto Generated Code-------------------------------*/");
            sb.Append(HssStr.WinNextLine);
            sb.Append(this.Sub0_cmdTP()).Append(HssStr.WinNextLine);
            sb.Append(this.Sub1_constructor()).Append(HssStr.WinNextLine);
            sb.Append(this.Sub2_attrs()).Append(HssStr.WinNextLine);
            sb.Append(this.Sub3_init_reader()).Append(HssStr.WinNextLine);
            sb.Append(this.Sub3_init_DB()).Append(HssStr.WinNextLine);
            sb.Append(this.Sub4_syncDB()).Append(HssStr.WinNextLine);
            sb.Append(this.Sub5_chkChange()).Append(HssStr.WinNextLine);
            sb.Append(this.Sub6_createAttrDic()).Append(HssStr.WinNextLine);
            sb.Append(this.Sub7_insertDB()).Append(HssStr.WinNextLine);
            sb.Append(this.Sub8_getInsert()).Append(HssStr.WinNextLine);
            sb.Append(this.Sub9_updateDB()).Append(HssStr.WinNextLine);
            sb.Append(this.Sub10_getUpdate()).Append(HssStr.WinNextLine);
            sb.Append(this.Sub11_copy()).Append(HssStr.WinNextLine);
            sb.Append(this.Sub12_toXML()).Append(HssStr.WinNextLine);
            sb.Append(this.Sub13_getViewForm()).Append(HssStr.WinNextLine);
            sb.Append(this.Sub14_saveToDB());
            sb.Append("/*^^^^^^^^^^^^^^^^^^^^^^^^^^^^^Hss Entity Framework Auto Generated Code^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^*/");
            return sb.ToString();
        }

        private StringBuilder Sub0_cmdTP()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("private static HssUtility.SQLserver.CmdTemplate DBcmd_TP = null;").Append(HssStr.WinNextLine);
            sb.Append("public static HssUtility.SQLserver.CmdTemplate Get_cmdTP()").Append(HssStr.WinNextLine);
            sb.Append("{").Append(HssStr.WinNextLine);
            sb.Append("if (").Append(this.className).Append(".DBcmd_TP != null) return ").Append(this.className).Append(".DBcmd_TP;").Append(HssStr.WinNextLine);
            sb.Append(HssStr.WinNextLine);

            sb.Append(this.className).Append(".DBcmd_TP = new HssUtility.SQLserver.CmdTemplate();").Append(HssStr.WinNextLine);
            sb.Append(this.className).Append(".DBcmd_TP.tableName = \"").Append(this.tableName).Append("\";").Append(HssStr.WinNextLine);
            sb.Append(this.className).Append(".DBcmd_TP.schema = \"").Append(this.schema).Append("\";").Append(HssStr.WinNextLine);
            sb.Append(HssStr.WinNextLine);

            foreach (ColumnSchema cs in this.col_list)
            {
                sb.Append(this.className).Append(".DBcmd_TP.AddColumn(\"").Append(cs.COLUMN_NAME).Append("\");");
                sb.Append(this.Get_optional_sb(cs));
                sb.Append(HssStr.WinNextLine);
            }

            sb.Append(HssStr.WinNextLine);
            sb.Append("return ").Append(this.className).Append(".DBcmd_TP;").Append(HssStr.WinNextLine);
            sb.Append("}").Append(HssStr.WinNextLine);

            return sb;
        }

        private StringBuilder Sub1_constructor()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("public ").Append(this.className).Append("() { }").Append(HssStr.WinNextLine);

            ColumnSchema pk_col = this.col_list[0];
            if (pk_col.DATA_TYPE.ToLower().Contains("int"))
                sb.Append("public ").Append(this.className).Append("(int id) { this.pk_ID = id; }").Append(HssStr.WinNextLine);
            else
                sb.Append("public ").Append(this.className).Append("(string id) { this.pk_ID = id; }").Append(HssStr.WinNextLine);
            return sb;
        }

        private StringBuilder Sub2_attrs()
        {
            StringBuilder sb = new StringBuilder();

            ColumnSchema pk_col = this.col_list[0];
            if (pk_col.DATA_TYPE.ToLower().Contains("int"))
            {
                sb.Append("private int pk_ID = -1; //primary key").Append(HssStr.WinNextLine);
                sb.Append("public int ").Append(pk_col.COLUMN_NAME).Append(" { get { return this.pk_ID; } }").Append(HssStr.WinNextLine);
            }
            else
            {
                sb.Append("private string pk_ID; //primary key").Append(HssStr.WinNextLine);
                sb.Append("public string ").Append(pk_col.COLUMN_NAME).Append(" { get { return this.pk_ID; } }").Append(HssStr.WinNextLine);
            }

            sb.Append(HssStr.WinNextLine);
            for (int i = 1; i < this.col_list.Count; ++i)
            {
                ColumnSchema cs = this.col_list[i];
                sb.Append(this.GetAttrs(cs));
                sb.Append(HssStr.WinNextLine);
            }

            sb.Append(HssStr.WinNextLine).Append("private Dictionary<string, ").Append(Attr_lib).Append("I_modelAttr> attr_dic = null;").Append(HssStr.WinNextLine);
            return sb;
        }

        private StringBuilder Sub3_init_reader()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("internal void Init_from_reader(").Append(SQL_lib).Append("DB_reader reader)").Append(HssStr.WinNextLine);
            sb.Append("{").Append(HssStr.WinNextLine);
            sb.Append("if (reader == null || reader.IsClosed) return;").Append(HssStr.WinNextLine);
            sb.Append(HssStr.WinNextLine);

            ColumnSchema pk_cs = this.col_list[0];
            string dataTP_str = pk_cs.DATA_TYPE.ToLower();
            if (dataTP_str.Contains("int"))
                sb.Append("this.pk_ID = reader.GetInt(\"").Append(pk_cs.COLUMN_NAME).Append("\");").Append(HssStr.WinNextLine);
            else if (dataTP_str.Contains("char"))
                sb.Append("this.pk_ID = reader.GetString(\"").Append(pk_cs.COLUMN_NAME).Append("\");").Append(HssStr.WinNextLine);

            for (int i = 1; i < this.col_list.Count; ++i)
            {
                ColumnSchema cs = this.col_list[i];
                sb.Append(this.Get_reader_sb(cs)).Append(HssStr.WinNextLine);
            }

            sb.Append(HssStr.WinNextLine).Append("this.SyncWithDB();").Append(HssStr.WinNextLine);
            sb.Append("}").Append(HssStr.WinNextLine);
            return sb;
        }

        private StringBuilder Sub3_init_DB()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("/// <summary>").Append(HssStr.WinNextLine);
            sb.Append("/// Initialize object from DB").Append(HssStr.WinNextLine);
            sb.Append("/// </summary>").Append(HssStr.WinNextLine);

            sb.Append("public bool Init_from_DB(").Append(this.Get_DBname(0)).Append(")").Append(HssStr.WinNextLine);
            sb.Append("{").Append(HssStr.WinNextLine);

            ColumnSchema pk_cs = this.col_list[0];
            string dataTP_str = pk_cs.DATA_TYPE.ToLower();

            if (dataTP_str.Contains("int"))
                sb.Append("if (this.").Append(pk_cs.COLUMN_NAME).Append(" < 0) return false;").Append(HssStr.WinNextLine);
            else if (dataTP_str.Contains("char"))
                sb.Append("if (string.IsNullOrEmpty(this.").Append(pk_cs.COLUMN_NAME).Append(")) return false;").Append(HssStr.WinNextLine);

            sb.Append(HssStr.WinNextLine);
            sb.Append(SQL_lib).Append("DB_select db_sel = new ").Append(SQL_lib).Append("DB_select(").Append(this.className).Append(".Get_cmdTP());").Append(HssStr.WinNextLine);
            sb.Append("db_sel.tableName = \"").Append(this.tableName).Append("\";").Append(HssStr.WinNextLine);

            sb.Append(SQL_lib).Append("SQL_relation rela = new ").Append(SQL_lib).Append("SQL_relation(\"");
            sb.Append(pk_cs.COLUMN_NAME).Append("\", ").Append(General_lib).Append("RelationalOperator.Equals, this.");
            sb.Append(pk_cs.COLUMN_NAME).Append(");").Append(HssStr.WinNextLine);

            sb.Append("db_sel.SetCondition(rela);").Append(HssStr.WinNextLine);
            sb.Append(HssStr.WinNextLine);
            sb.Append("bool res_flag = false;").Append(HssStr.WinNextLine);
            sb.Append(SQL_lib).Append("DB_reader reader = new ").Append(SQL_lib).Append("DB_reader(db_sel, ").Append(this.hDB_name).Append(");").Append(HssStr.WinNextLine);
            sb.Append("if (reader.Read())").Append(HssStr.WinNextLine);
            sb.Append("{").Append(HssStr.WinNextLine);
            sb.Append("this.Init_from_reader(reader);").Append(HssStr.WinNextLine);
            sb.Append("res_flag = true;").Append(HssStr.WinNextLine);
            sb.Append("}").Append(HssStr.WinNextLine);
            sb.Append("reader.Close();").Append(HssStr.WinNextLine);
            sb.Append("return res_flag;").Append(HssStr.WinNextLine);
            sb.Append("}").Append(HssStr.WinNextLine);
            return sb;
        }

        private StringBuilder Sub4_syncDB()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("internal void SyncWithDB()").Append(HssStr.WinNextLine);
            sb.Append("{").Append(HssStr.WinNextLine);
            sb.Append("this.Create_attrDic();").Append(HssStr.WinNextLine);
            sb.Append("foreach (").Append(Attr_lib).Append("I_modelAttr ma in this.attr_dic.Values) ma.SyncWithDB();").Append(HssStr.WinNextLine);
            sb.Append("}").Append(HssStr.WinNextLine);
            return sb;
        }

        private StringBuilder Sub5_chkChange()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("public bool CheckValueChanges()").Append(HssStr.WinNextLine);
            sb.Append("{").Append(HssStr.WinNextLine);
            sb.Append("this.Create_attrDic();").Append(HssStr.WinNextLine);
            sb.Append("foreach (").Append(Attr_lib).Append("I_modelAttr ma in this.attr_dic.Values) if (ma.ValueChanged) return true;").Append(HssStr.WinNextLine);
            sb.Append("return false;").Append(HssStr.WinNextLine);
            sb.Append("}").Append(HssStr.WinNextLine);
            return sb;
        }

        private StringBuilder Sub6_createAttrDic()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("private void Create_attrDic()").Append(HssStr.WinNextLine);
            sb.Append("{").Append(HssStr.WinNextLine);
            sb.Append("if (this.attr_dic != null) return;").Append(HssStr.WinNextLine);
            sb.Append(HssStr.WinNextLine);
            sb.Append("this.attr_dic = new Dictionary<string, ").Append(Attr_lib).Append("I_modelAttr>(StringComparer.OrdinalIgnoreCase);").Append(HssStr.WinNextLine);

            for (int i = 1; i < this.col_list.Count; ++i)
            {
                ColumnSchema cs = this.col_list[i];
                sb.Append("this.attr_dic.Add(\"").Append(cs.COLUMN_NAME).Append("\", this.").Append(cs.attr_name).Append(");");
                sb.Append(this.Get_optional_sb(cs)).Append(HssStr.WinNextLine);
            }

            sb.Append("}").Append(HssStr.WinNextLine);
            return sb;
        }

        private StringBuilder Sub7_insertDB()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("/// <summary>").Append(HssStr.WinNextLine);
            sb.Append("/// Insert object to DB").Append(HssStr.WinNextLine);
            sb.Append("/// </summary>").Append(HssStr.WinNextLine);

            sb.Append("public bool Insert_to_DB(").Append(this.Get_DBname(0)).Append(")").Append(HssStr.WinNextLine);
            sb.Append("{").Append(HssStr.WinNextLine);
            sb.Append(SQL_lib).Append("DB_insert ins = this.Get_DBinsert();").Append(HssStr.WinNextLine);
            sb.Append("int count = ins.SaveToDB(").Append(this.hDB_name).Append(");").Append(HssStr.WinNextLine);
            sb.Append(HssStr.WinNextLine);
            sb.Append("bool flag = count > 0;").Append(HssStr.WinNextLine);
            sb.Append("if (flag) this.SyncWithDB();").Append(HssStr.WinNextLine);
            sb.Append(HssStr.WinNextLine);
            sb.Append("return flag;").Append(HssStr.WinNextLine);
            sb.Append("}").Append(HssStr.WinNextLine);
            return sb;
        }

        private StringBuilder Sub8_getInsert()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("internal ").Append(SQL_lib).Append("DB_insert Get_DBinsert()").Append(HssStr.WinNextLine);
            sb.Append("{").Append(HssStr.WinNextLine);
            sb.Append(SQL_lib).Append("DB_insert dbIns = new ").Append(SQL_lib).Append("DB_insert(");
            sb.Append(this.className).Append(".Get_cmdTP());").Append(HssStr.WinNextLine);

            sb.Append(HssStr.WinNextLine);

            for (int i = 1; i < this.col_list.Count; ++i)
            {
                ColumnSchema cs = this.col_list[i];
                StringBuilder optional_sb = this.Get_optional_sb(cs);

                sb.Append("dbIns.AddValue(\"").Append(cs.COLUMN_NAME).Append("\", this.");
                sb.Append(cs.attr_name).Append(");").Append(optional_sb).Append(HssStr.WinNextLine);
            }

            sb.Append(HssStr.WinNextLine);
            sb.Append("return dbIns;").Append(HssStr.WinNextLine);
            sb.Append("}").Append(HssStr.WinNextLine);
            return sb;
        }

        private StringBuilder Sub9_updateDB()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("/// <summary>").Append(HssStr.WinNextLine);
            sb.Append("/// Save updates to DB").Append(HssStr.WinNextLine);
            sb.Append("/// </summary>").Append(HssStr.WinNextLine);

            sb.Append("public bool Update_to_DB(").Append(this.Get_DBname(0)).Append(")").Append(HssStr.WinNextLine);
            sb.Append("{").Append(HssStr.WinNextLine);
            sb.Append(SQL_lib).Append("DB_update upd = this.Get_DBupdate();").Append(HssStr.WinNextLine);
            sb.Append("if (upd == null) return false;").Append(HssStr.WinNextLine);
            sb.Append(HssStr.WinNextLine);
            sb.Append("int count = upd.SaveToDB(").Append(this.hDB_name).Append(");").Append(HssStr.WinNextLine);
            sb.Append("bool flag = count > 0;").Append(HssStr.WinNextLine);
            sb.Append("if (flag) this.SyncWithDB();").Append(HssStr.WinNextLine);
            sb.Append(HssStr.WinNextLine);
            sb.Append("return flag;").Append(HssStr.WinNextLine);
            sb.Append("}").Append(HssStr.WinNextLine);
            return sb;
        }

        private StringBuilder Sub10_getUpdate()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("internal ").Append(SQL_lib).Append("DB_update Get_DBupdate()").Append(HssStr.WinNextLine);
            sb.Append("{").Append(HssStr.WinNextLine);
            sb.Append("if (!this.CheckValueChanges()) return null;").Append(HssStr.WinNextLine);
            sb.Append(HssStr.WinNextLine);

            sb.Append(SQL_lib).Append("DB_update upd = new ").Append(SQL_lib).Append("DB_update(");
            sb.Append(this.className).Append(".Get_cmdTP());").Append(HssStr.WinNextLine);

            for (int i = 1; i < this.col_list.Count; ++i)
            {
                ColumnSchema cs = this.col_list[i];
                StringBuilder optional_sb = this.Get_optional_sb(cs);

                sb.Append("if (this.").Append(cs.attr_name).Append(".ValueChanged) upd.AddValue(\"").Append(cs.COLUMN_NAME).Append("\", this.");
                sb.Append(cs.attr_name).Append(");").Append(optional_sb).Append(HssStr.WinNextLine);
            }

            sb.Append(HssStr.WinNextLine);

            ColumnSchema pk_cs = this.col_list[0];
            sb.Append(SQL_lib).Append("SQL_relation rela = new ").Append(SQL_lib).Append("SQL_relation(\"").Append(pk_cs.COLUMN_NAME);
            sb.Append("\", ").Append(General_lib).Append("RelationalOperator.Equals, this.pk_ID);").Append(HssStr.WinNextLine);

            sb.Append("upd.SetCondition(rela);").Append(HssStr.WinNextLine);
            sb.Append(HssStr.WinNextLine);
            sb.Append("return upd;").Append(HssStr.WinNextLine);
            sb.Append("}").Append(HssStr.WinNextLine);

            return sb;
        }

        private StringBuilder Sub11_copy()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("public ").Append(this.className).Append(" GetCopy()").Append(HssStr.WinNextLine);
            sb.Append("{").Append(HssStr.WinNextLine);
            sb.Append(this.className).Append(" newEntity = new ").Append(this.className).Append("();").Append(HssStr.WinNextLine);

            for (int i = 1; i < this.col_list.Count; ++i)
            {
                ColumnSchema cs = this.col_list[i];
                sb.Append("if (!this.").Append(cs.attr_name).Append(".IsNull_flag)");
                sb.Append("newEntity.").Append(cs.attr_name).Append(".Value = this.");
                sb.Append(cs.attr_name).Append(".Value;").Append(HssStr.WinNextLine);
            }

            sb.Append("return newEntity;").Append(HssStr.WinNextLine);
            sb.Append("}").Append(HssStr.WinNextLine);
            return sb;
        }

        private StringBuilder Sub12_toXML()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("public string ToXML()").Append(HssStr.WinNextLine);
            sb.Append("{").Append(HssStr.WinNextLine);

            sb.Append("StringBuilder sb = new StringBuilder();").Append(HssStr.WinNextLine);
            sb.Append("sb.Append(\"<").Append(this.className).Append(">\").Append(HssUtility.General.HssStr.WinNextLine);").Append(HssStr.WinNextLine);

            ColumnSchema pk_cs = this.col_list[0];
            sb.Append("sb.Append(\"<").Append(pk_cs.COLUMN_NAME).Append(">\").Append(this.").Append(pk_cs.attr_name).Append(").Append(\"</");
            sb.Append(pk_cs.COLUMN_NAME).Append(">\").Append(HssUtility.General.HssStr.WinNextLine);").Append(HssStr.WinNextLine);

            for (int i = 1; i < this.col_list.Count; ++i)
            {
                ColumnSchema cs = this.col_list[i];

                string type_str = cs.DATA_TYPE.ToLower();
                StringBuilder replace_sb = new StringBuilder();
                if (type_str.Contains("char") || type_str.Contains("xml"))
                    replace_sb.Append("HssUtility.General.HssStr.ToSafeXML_str(this.").Append(cs.attr_name).Append(".Value)");
                else replace_sb.Append("this.").Append(cs.attr_name).Append(".Value");

                sb.Append("sb.Append(\"<").Append(cs.COLUMN_NAME).Append(">\").Append(").Append(replace_sb).Append(").Append(\"</");
                sb.Append(cs.COLUMN_NAME).Append(">\").Append(HssUtility.General.HssStr.WinNextLine);").Append(HssStr.WinNextLine);
            }

            sb.Append("sb.Append(\"</").Append(this.className).Append(">\").Append(HssUtility.General.HssStr.WinNextLine);").Append(HssStr.WinNextLine);
            sb.Append("return sb.ToString();").Append(HssStr.WinNextLine);
            sb.Append("}").Append(HssStr.WinNextLine);

            return sb;
        }

        private StringBuilder Sub13_getViewForm()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("public HssUtility.Forms.Attribute.Models_viewForm GetEditForm(").Append(this.Get_DBname(0)).Append(")").Append(HssStr.WinNextLine);
            sb.Append("{").Append(HssStr.WinNextLine);

            sb.Append("HssUtility.Forms.Attribute.Models_viewForm mvf = new HssUtility.Forms.Attribute.Models_viewForm();").Append(HssStr.WinNextLine);
            sb.Append("mvf.Text = \"").Append(this.className).Append("\";").Append(HssStr.WinNextLine);

            ColumnSchema pk_cs = this.col_list[0];
            sb.Append("mvf.Set_pk_label(\"").Append(pk_cs.COLUMN_NAME).Append(":\" + this.").Append(pk_cs.attr_name).Append(");").Append(HssStr.WinNextLine);

            for (int i = 1; i < this.col_list.Count; ++i)
            {
                ColumnSchema cs = this.col_list[i];
                sb.Append(this.Get_viewForm_sb(cs)).Append(HssStr.WinNextLine);
            }

            sb.Append("mvf.SaveModel_func = delegate { return this.Save_to_DB(").Append(this.Get_DBname(1)).Append("); };").Append(HssStr.WinNextLine);
            sb.Append("return mvf;").Append(HssStr.WinNextLine);
            sb.Append("}").Append(HssStr.WinNextLine);

            return sb;
        }

        private StringBuilder Sub14_saveToDB()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("public bool Save_to_DB(").Append(this.Get_DBname(0)).Append(")").Append(HssStr.WinNextLine);
            sb.Append("{").Append(HssStr.WinNextLine);
            sb.Append("bool dataSaved_flag = false;").Append(HssStr.WinNextLine);
            sb.Append("if (this.pk_ID > 0) dataSaved_flag = this.Update_to_DB(").Append(this.Get_DBname(1)).Append(");").Append(HssStr.WinNextLine);
            sb.Append("else dataSaved_flag = this.Insert_to_DB(").Append(this.Get_DBname(1)).Append(");").Append(HssStr.WinNextLine);
            sb.Append("return dataSaved_flag;").Append(HssStr.WinNextLine);
            sb.Append("}").Append(HssStr.WinNextLine);

            return sb;
        }

        /*-------------------------------------------------------------------------------------------------------------------------------------*/

        /// <summary>
        /// Get DataBase name
        /// </summary>
        /// <param name="type">0 for param, 1 for in function</param>
        private string Get_DBname(int type)
        {
            if (this.builtInDB_flag) return null;

            if (type == 0) return SQL_lib + "hssDB " + this.hDB_name;
            if (type == 1) return this.hDB_name;

            return null;
        }

        private StringBuilder GetAttrs(ColumnSchema cs)
        {
            StringBuilder sb = new StringBuilder();
            string type_str = cs.DATA_TYPE.ToLower();

            if (type_str.Contains("bigint"))
            {
                sb.Append("public readonly ").Append(Attr_lib).Append("Long_attr").Append(" ").Append(cs.attr_name);
                sb.Append(" = new ").Append(Attr_lib).Append("Long_attr").Append("();");
            }
            else if (type_str.Contains("int"))
            {
                sb.Append("public readonly ").Append(Attr_lib).Append("Int_attr").Append(" ").Append(cs.attr_name);
                sb.Append(" = new ").Append(Attr_lib).Append("Int_attr").Append("();");
            }
            else if (type_str.Contains("char") || type_str.Contains("xml"))
            {
                sb.Append("public readonly ").Append(Attr_lib).Append("String_attr").Append(" ").Append(cs.attr_name);
                sb.Append(" = new ").Append(Attr_lib).Append("String_attr").Append("();");
            }
            else if (type_str.Contains("numeric") || type_str.Contains("decimal") || type_str.Contains("float"))
            {
                sb.Append("public readonly ").Append(Attr_lib).Append("Decimal_attr").Append(" ").Append(cs.attr_name);
                sb.Append(" = new ").Append(Attr_lib).Append("Decimal_attr").Append("();");
            }
            else if (type_str.Contains("date"))
            {
                sb.Append("public readonly ").Append(Attr_lib).Append("DateTime_attr").Append(" ").Append(cs.attr_name);
                sb.Append(" = new ").Append(Attr_lib).Append("DateTime_attr").Append("();");
            }
            else if (type_str.Contains("bit"))
            {
                sb.Append("public readonly ").Append(Attr_lib).Append("Bool_attr").Append(" ").Append(cs.attr_name);
                sb.Append(" = new ").Append(Attr_lib).Append("Bool_attr").Append("();");
            }

            sb.Append(this.Get_optional_sb(cs));
            return sb;
        }

        private StringBuilder Get_optional_sb(ColumnSchema cs)
        {
            StringBuilder sb = new StringBuilder();
            if (cs.IS_NULLABLE.Equals("Yes", StringComparison.OrdinalIgnoreCase))
                sb.Append("/*Optional ").Append(cs.ORDINAL_POSITION).Append("*/");

            return sb;
        }

        private StringBuilder Get_reader_sb(ColumnSchema cs)
        {
            StringBuilder sb = new StringBuilder();
            string type_str = cs.DATA_TYPE.ToLower();

            if (type_str.Contains("bigint"))
            {
                sb.Append("reader.GetLong(\"").Append(cs.COLUMN_NAME).Append("\", this.").Append(cs.attr_name).Append(");");
            }
            else if (type_str.Contains("int"))
            {
                sb.Append("reader.GetInt(\"").Append(cs.COLUMN_NAME).Append("\", this.").Append(cs.attr_name).Append(");");
            }
            else if (type_str.Contains("char") || type_str.Contains("xml"))
            {
                sb.Append("reader.GetString(\"").Append(cs.COLUMN_NAME).Append("\", this.").Append(cs.attr_name).Append(");");
            }
            else if (type_str.Contains("numeric") || type_str.Contains("decimal") || type_str.Contains("float"))
            {
                sb.Append("reader.GetDecimal(\"").Append(cs.COLUMN_NAME).Append("\", this.").Append(cs.attr_name).Append(");");
            }
            else if (type_str.Contains("date"))
            {
                sb.Append("reader.GetDateTime(\"").Append(cs.COLUMN_NAME).Append("\", this.").Append(cs.attr_name).Append(");");
            }
            else if (type_str.Contains("bit"))
            {
                sb.Append("reader.GetBool(\"").Append(cs.COLUMN_NAME).Append("\", this.").Append(cs.attr_name).Append(");");
            }

            sb.Append(this.Get_optional_sb(cs));
            return sb;
        }

        private StringBuilder Get_viewForm_sb(ColumnSchema cs)
        {
            StringBuilder sb = new StringBuilder();
            string type_str = cs.DATA_TYPE.ToLower();

            if (type_str.Contains("bigint"))
            {
                sb.Append("mvf.Add_Control(new HssUtility.Forms.Attribute.StrAttr_UserControl(\"").Append(cs.COLUMN_NAME).Append("\", this.").Append(cs.attr_name).Append("));");
            }
            else if (type_str.Contains("int"))
            {
                sb.Append("mvf.Add_Control(new HssUtility.Forms.Attribute.StrAttr_UserControl(\"").Append(cs.COLUMN_NAME).Append("\", this.").Append(cs.attr_name).Append("));");
            }
            else if (type_str.Contains("char") || type_str.Contains("xml"))
            {
                sb.Append("mvf.Add_Control(new HssUtility.Forms.Attribute.StrAttr_UserControl(\"").Append(cs.COLUMN_NAME).Append("\", this.").Append(cs.attr_name).Append("));");
            }
            else if (type_str.Contains("numeric") || type_str.Contains("decimal") || type_str.Contains("float"))
            {
                sb.Append("mvf.Add_Control(new HssUtility.Forms.Attribute.StrAttr_UserControl(\"").Append(cs.COLUMN_NAME).Append("\", this.").Append(cs.attr_name).Append("));");
            }
            else if (type_str.Contains("date"))
            {
                sb.Append("mvf.Add_Control(new HssUtility.Forms.Attribute.DateTimeAttr_UserControl(\"").Append(cs.COLUMN_NAME).Append("\", this.").Append(cs.attr_name).Append("));");
            }
            else if (type_str.Contains("bit"))
            {
                sb.Append("mvf.Add_Control(new HssUtility.Forms.Attribute.BoolAttr_UserControl(\"").Append(cs.COLUMN_NAME).Append("\", this.").Append(cs.attr_name).Append("));");
            }

            sb.Append(this.Get_optional_sb(cs));
            return sb;
        }
    }

    class ColumnSchema
    {
        private static CmdTemplate DBcmd_TP = null;
        public static CmdTemplate Get_cmdTP()
        {
            if (ColumnSchema.DBcmd_TP != null) return ColumnSchema.DBcmd_TP;

            ColumnSchema.DBcmd_TP = new CmdTemplate();
            ColumnSchema.DBcmd_TP.schema = "INFORMATION_SCHEMA";
            ColumnSchema.DBcmd_TP.tableName = "COLUMNS";

            ColumnSchema.DBcmd_TP.AddColumn("TABLE_SCHEMA");
            ColumnSchema.DBcmd_TP.AddColumn("TABLE_NAME");
            ColumnSchema.DBcmd_TP.AddColumn("COLUMN_NAME");
            ColumnSchema.DBcmd_TP.AddColumn("ORDINAL_POSITION");
            ColumnSchema.DBcmd_TP.AddColumn("IS_NULLABLE");
            ColumnSchema.DBcmd_TP.AddColumn("DATA_TYPE");

            return ColumnSchema.DBcmd_TP;
        }

        public string TABLE_SCHEMA, TABLE_NAME, COLUMN_NAME, IS_NULLABLE, DATA_TYPE;
        public string attr_name;
        public int ORDINAL_POSITION = -1;

        internal void Init_from_reader(DB_reader reader)
        {
            if (reader == null || reader.IsClosed) return;

            this.TABLE_SCHEMA = reader.GetString("TABLE_SCHEMA");
            this.TABLE_NAME = reader.GetString("TABLE_NAME");
            this.COLUMN_NAME = reader.GetString("COLUMN_NAME");
            this.ORDINAL_POSITION = reader.GetInt("ORDINAL_POSITION");
            this.IS_NULLABLE = reader.GetString("IS_NULLABLE");
            this.DATA_TYPE = reader.GetString("DATA_TYPE");

            this.attr_name = this.COLUMN_NAME.Replace(' ', '_');
        }
    }
}
