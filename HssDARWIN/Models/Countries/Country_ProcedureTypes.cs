using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HssDARWIN.Models.Countries
{
    public class Country_ProcedureTypes
    {
        /*-----------------------------Hss Entity Framework Auto Generated Code-------------------------------*/
        private static HssUtility.SQLserver.CmdTemplate DBcmd_TP = null;
        public static HssUtility.SQLserver.CmdTemplate Get_cmdTP()
        {
            if (Country_ProcedureTypes.DBcmd_TP != null) return Country_ProcedureTypes.DBcmd_TP;

            Country_ProcedureTypes.DBcmd_TP = new HssUtility.SQLserver.CmdTemplate();
            Country_ProcedureTypes.DBcmd_TP.tableName = "Country_ProcedureTypes";
            Country_ProcedureTypes.DBcmd_TP.schema = "dbo";

            Country_ProcedureTypes.DBcmd_TP.AddColumn("Country");
            Country_ProcedureTypes.DBcmd_TP.AddColumn("IsSponsored");/*Optional 2*/
            Country_ProcedureTypes.DBcmd_TP.AddColumn("At_Source");
            Country_ProcedureTypes.DBcmd_TP.AddColumn("Quick_Refund");
            Country_ProcedureTypes.DBcmd_TP.AddColumn("Long_Form");

            return Country_ProcedureTypes.DBcmd_TP;
        }

        public Country_ProcedureTypes() { }
        public Country_ProcedureTypes(string id) { this.pk_ID = id; }

        private string pk_ID; //primary key
        public string Country { get { return this.pk_ID; } }

        public readonly HssUtility.General.Attributes.Bool_attr IsSponsored = new HssUtility.General.Attributes.Bool_attr();/*Optional 2*/
        public readonly HssUtility.General.Attributes.Bool_attr At_Source = new HssUtility.General.Attributes.Bool_attr();
        public readonly HssUtility.General.Attributes.Bool_attr Quick_Refund = new HssUtility.General.Attributes.Bool_attr();
        public readonly HssUtility.General.Attributes.Bool_attr Long_Form = new HssUtility.General.Attributes.Bool_attr();

        private List<HssUtility.General.Attributes.I_modelAttr> attrList = null;

        internal void Init_from_reader(HssUtility.SQLserver.DB_reader reader)
        {
            if (reader == null || reader.IsClosed) return;

            this.pk_ID = reader.GetString("Country");
            reader.GetBool("IsSponsored", this.IsSponsored);/*Optional 2*/
            reader.GetBool("At_Source", this.At_Source);
            reader.GetBool("Quick_Refund", this.Quick_Refund);
            reader.GetBool("Long_Form", this.Long_Form);

            this.SyncWithDB();
        }

        /// <summary>
        /// Initialize object from DB
        /// </summary>
        public bool Init_from_DB()
        {
            if (string.IsNullOrEmpty(this.Country)) return false;

            HssUtility.SQLserver.DB_select db_sel = new HssUtility.SQLserver.DB_select(Country_ProcedureTypes.Get_cmdTP());
            db_sel.tableName = "Country_ProcedureTypes";
            HssUtility.SQLserver.SQL_relation rela = new HssUtility.SQLserver.SQL_relation("Country", HssUtility.General.RelationalOperator.Equals, this.Country);
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
            this.Create_attrList();
            foreach (HssUtility.General.Attributes.I_modelAttr ma in this.attrList) ma.SyncWithDB();
        }

        public bool CheckValueChanges()
        {
            this.Create_attrList();
            foreach (HssUtility.General.Attributes.I_modelAttr ma in this.attrList) if (ma.ValueChanged) return true;
            return false;
        }

        private void Create_attrList()
        {
            if (this.attrList != null) return;

            this.attrList = new List<HssUtility.General.Attributes.I_modelAttr>();
            this.attrList.Add(this.IsSponsored);/*Optional 2*/
            this.attrList.Add(this.At_Source);
            this.attrList.Add(this.Quick_Refund);
            this.attrList.Add(this.Long_Form);
        }

        /// <summary>
        /// insert object to DB
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
            HssUtility.SQLserver.DB_insert dbIns = new HssUtility.SQLserver.DB_insert(Country_ProcedureTypes.Get_cmdTP());

            dbIns.AddValue("IsSponsored", this.IsSponsored);/*Optional 2*/
            dbIns.AddValue("At_Source", this.At_Source.Value);
            dbIns.AddValue("Quick_Refund", this.Quick_Refund.Value);
            dbIns.AddValue("Long_Form", this.Long_Form.Value);

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

            HssUtility.SQLserver.DB_update upd = new HssUtility.SQLserver.DB_update(Country_ProcedureTypes.Get_cmdTP());
            if (this.IsSponsored.ValueChanged) upd.AddValue("IsSponsored", this.IsSponsored);
            if (this.At_Source.ValueChanged) upd.AddValue("At_Source", this.At_Source);
            if (this.Quick_Refund.ValueChanged) upd.AddValue("Quick_Refund", this.Quick_Refund);
            if (this.Long_Form.ValueChanged) upd.AddValue("Long_Form", this.Long_Form);

            HssUtility.SQLserver.SQL_relation rela = new HssUtility.SQLserver.SQL_relation("Country", HssUtility.General.RelationalOperator.Equals, this.pk_ID);
            upd.SetCondition(rela);

            return upd;
        }

        public Country_ProcedureTypes GetCopy()
        {
            Country_ProcedureTypes newEntity = new Country_ProcedureTypes();
            if (!this.IsSponsored.IsNull_flag) newEntity.IsSponsored.Value = this.IsSponsored.Value;
            if (!this.At_Source.IsNull_flag) newEntity.At_Source.Value = this.At_Source.Value;
            if (!this.Quick_Refund.IsNull_flag) newEntity.Quick_Refund.Value = this.Quick_Refund.Value;
            if (!this.Long_Form.IsNull_flag) newEntity.Long_Form.Value = this.Long_Form.Value;
            return newEntity;
        }

        public string ToXML()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("<Country_ProcedureTypes>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Country>").Append(this.Country).Append("</Country>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<IsSponsored>").Append(this.IsSponsored.Value).Append("</IsSponsored>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<At_Source>").Append(this.At_Source.Value).Append("</At_Source>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Quick_Refund>").Append(this.Quick_Refund.Value).Append("</Quick_Refund>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Long_Form>").Append(this.Long_Form.Value).Append("</Long_Form>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("</Country_ProcedureTypes>").Append(HssUtility.General.HssStr.WinNextLine);
            return sb.ToString();
        }
        /*^^^^^^^^^^^^^^^^^^^^^^^^^^^^^Hss Entity Framework Auto Generated Code^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^*/
    }
}
