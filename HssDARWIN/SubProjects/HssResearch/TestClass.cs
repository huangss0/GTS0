using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HssDARWIN.SubProjects.HssResearch
{
    public class TestClass
    {
        /*-----------------------------Hss Entity Framework Auto Generated Code-------------------------------*/
        private static HssUtility.SQLserver.CmdTemplate DBcmd_TP = null;
        public static HssUtility.SQLserver.CmdTemplate Get_cmdTP()
        {
            if (TestClass.DBcmd_TP != null) return TestClass.DBcmd_TP;

            TestClass.DBcmd_TP = new HssUtility.SQLserver.CmdTemplate();
            TestClass.DBcmd_TP.tableName = "Person_test";
            TestClass.DBcmd_TP.schema = "rules";

            TestClass.DBcmd_TP.AddColumn("ID");
            TestClass.DBcmd_TP.AddColumn("Name");/*Optional 2*/
            TestClass.DBcmd_TP.AddColumn("Birthday");/*Optional 3*/
            TestClass.DBcmd_TP.AddColumn("Salary");/*Optional 4*/
            TestClass.DBcmd_TP.AddColumn("IsMarried");/*Optional 5*/

            return TestClass.DBcmd_TP;
        }

        public TestClass() { }
        public TestClass(int id) { this.pk_ID = id; }

        private int pk_ID = -1; //primary key
        public int ID { get { return this.pk_ID; } }

        public readonly HssUtility.General.Attributes.String_attr Name = new HssUtility.General.Attributes.String_attr();/*Optional 2*/
        public readonly HssUtility.General.Attributes.DateTime_attr Birthday = new HssUtility.General.Attributes.DateTime_attr();/*Optional 3*/
        public readonly HssUtility.General.Attributes.Decimal_attr Salary = new HssUtility.General.Attributes.Decimal_attr();/*Optional 4*/
        public readonly HssUtility.General.Attributes.Bool_attr IsMarried = new HssUtility.General.Attributes.Bool_attr();/*Optional 5*/

        private Dictionary<string, HssUtility.General.Attributes.I_modelAttr> attr_dic = null;

        internal void Init_from_reader(HssUtility.SQLserver.DB_reader reader)
        {
            if (reader == null || reader.IsClosed) return;

            this.pk_ID = reader.GetInt("ID");
            reader.GetString("Name", this.Name);/*Optional 2*/
            reader.GetDateTime("Birthday", this.Birthday);/*Optional 3*/
            reader.GetDecimal("Salary", this.Salary);/*Optional 4*/
            reader.GetBool("IsMarried", this.IsMarried);/*Optional 5*/

            this.SyncWithDB();
        }

        /// <summary>
        /// Initialize object from DB
        /// </summary>
        public bool Init_from_DB()
        {
            if (this.ID < 0) return false;

            HssUtility.SQLserver.DB_select db_sel = new HssUtility.SQLserver.DB_select(TestClass.Get_cmdTP());
            db_sel.tableName = "Person_test";
            HssUtility.SQLserver.SQL_relation rela = new HssUtility.SQLserver.SQL_relation("ID", HssUtility.General.RelationalOperator.Equals, this.ID);
            db_sel.SetCondition(rela);

            bool res_flag = false;
            HssUtility.SQLserver.DB_reader reader = new HssUtility.SQLserver.DB_reader(db_sel, Utility.Get_DRWIN_hDB());
            if (reader.Read())
            {
                this.Init_from_reader(reader);
                res_flag = true;
            }
            reader.Close();
            return res_flag;
        }

        internal void SyncWithDB()
        {
            this.Create_attrDic();
            foreach (HssUtility.General.Attributes.I_modelAttr ma in this.attr_dic.Values) ma.SyncWithDB();
        }

        public bool CheckValueChanges()
        {
            this.Create_attrDic();
            foreach (HssUtility.General.Attributes.I_modelAttr ma in this.attr_dic.Values) if (ma.ValueChanged) return true;
            return false;
        }

        private void Create_attrDic()
        {
            if (this.attr_dic != null) return;

            this.attr_dic = new Dictionary<string, HssUtility.General.Attributes.I_modelAttr>(StringComparer.OrdinalIgnoreCase);
            this.attr_dic.Add("Name", this.Name);/*Optional 2*/
            this.attr_dic.Add("Birthday", this.Birthday);/*Optional 3*/
            this.attr_dic.Add("Salary", this.Salary);/*Optional 4*/
            this.attr_dic.Add("IsMarried", this.IsMarried);/*Optional 5*/
        }

        /// <summary>
        /// Insert object to DB
        /// </summary>
        public bool Insert_to_DB()
        {
            HssUtility.SQLserver.DB_insert ins = this.Get_DBinsert();
            int count = ins.SaveToDB(Utility.Get_DRWIN_hDB());

            bool flag = count > 0;
            if (flag) this.SyncWithDB();

            return flag;
        }

        internal HssUtility.SQLserver.DB_insert Get_DBinsert()
        {
            HssUtility.SQLserver.DB_insert dbIns = new HssUtility.SQLserver.DB_insert(TestClass.Get_cmdTP());

            dbIns.AddValue("Name", this.Name);/*Optional 2*/
            dbIns.AddValue("Birthday", this.Birthday);/*Optional 3*/
            dbIns.AddValue("Salary", this.Salary);/*Optional 4*/
            dbIns.AddValue("IsMarried", this.IsMarried);/*Optional 5*/

            return dbIns;
        }

        /// <summary>
        /// Save updates to DB
        /// </summary>
        public bool Update_to_DB()
        {
            HssUtility.SQLserver.DB_update upd = this.Get_DBupdate();
            if (upd == null) return false;

            int count = upd.SaveToDB(Utility.Get_DRWIN_hDB());
            bool flag = count > 0;
            if (flag) this.SyncWithDB();

            return flag;
        }

        internal HssUtility.SQLserver.DB_update Get_DBupdate()
        {
            if (!this.CheckValueChanges()) return null;

            HssUtility.SQLserver.DB_update upd = new HssUtility.SQLserver.DB_update(TestClass.Get_cmdTP());
            if (this.Name.ValueChanged) upd.AddValue("Name", this.Name);/*Optional 2*/
            if (this.Birthday.ValueChanged) upd.AddValue("Birthday", this.Birthday);/*Optional 3*/
            if (this.Salary.ValueChanged) upd.AddValue("Salary", this.Salary);/*Optional 4*/
            if (this.IsMarried.ValueChanged) upd.AddValue("IsMarried", this.IsMarried);/*Optional 5*/

            HssUtility.SQLserver.SQL_relation rela = new HssUtility.SQLserver.SQL_relation("ID", HssUtility.General.RelationalOperator.Equals, this.pk_ID);
            upd.SetCondition(rela);

            return upd;
        }

        public TestClass GetCopy()
        {
            TestClass newEntity = new TestClass();
            if (!this.Name.IsNull_flag) newEntity.Name.Value = this.Name.Value;
            if (!this.Birthday.IsNull_flag) newEntity.Birthday.Value = this.Birthday.Value;
            if (!this.Salary.IsNull_flag) newEntity.Salary.Value = this.Salary.Value;
            if (!this.IsMarried.IsNull_flag) newEntity.IsMarried.Value = this.IsMarried.Value;
            return newEntity;
        }

        public string ToXML()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("<TestClass>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<ID>").Append(this.ID).Append("</ID>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Name>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.Name.Value)).Append("</Name>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Birthday>").Append(this.Birthday.Value).Append("</Birthday>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Salary>").Append(this.Salary.Value).Append("</Salary>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<IsMarried>").Append(this.IsMarried.Value).Append("</IsMarried>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("</TestClass>").Append(HssUtility.General.HssStr.WinNextLine);
            return sb.ToString();
        }

        public HssUtility.Forms.Attribute.Models_viewForm GetEditForm()
        {
            HssUtility.Forms.Attribute.Models_viewForm mvf = new HssUtility.Forms.Attribute.Models_viewForm();
            mvf.Text = "TestClass";
            mvf.Set_pk_label("ID:" + this.ID);
            mvf.Add_Control(new HssUtility.Forms.Attribute.StrAttr_UserControl("Name", this.Name));/*Optional 2*/
            mvf.Add_Control(new HssUtility.Forms.Attribute.DateTimeAttr_UserControl("Birthday", this.Birthday));/*Optional 3*/
            mvf.Add_Control(new HssUtility.Forms.Attribute.StrAttr_UserControl("Salary", this.Salary));/*Optional 4*/
            mvf.Add_Control(new HssUtility.Forms.Attribute.BoolAttr_UserControl("IsMarried", this.IsMarried));/*Optional 5*/
            mvf.SaveModel_func = delegate { return this.Save_to_DB(); };
            return mvf;
        }

        public bool Save_to_DB()
        {
            bool dataSaved_flag = false;
            if (this.pk_ID > 0) dataSaved_flag = this.Update_to_DB();
            else dataSaved_flag = this.Insert_to_DB();
            return dataSaved_flag;
        }
        /*^^^^^^^^^^^^^^^^^^^^^^^^^^^^^Hss Entity Framework Auto Generated Code^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^*/
    }
}
