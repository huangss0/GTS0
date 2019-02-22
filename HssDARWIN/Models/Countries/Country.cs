using System.Collections.Generic;
using System.Text;

namespace HssDARWIN.Models.Countries
{
    public class Country
    {
        /*-----------------------------Hss Entity Framework Auto Generated Code-------------------------------*/
        private static HssUtility.SQLserver.CmdTemplate DBcmd_TP = null;
        public static HssUtility.SQLserver.CmdTemplate Get_cmdTP()
        {
            if (Country.DBcmd_TP != null) return Country.DBcmd_TP;

            Country.DBcmd_TP = new HssUtility.SQLserver.CmdTemplate();
            Country.DBcmd_TP.tableName = "Countries";
            Country.DBcmd_TP.schema = "dbo";

            Country.DBcmd_TP.AddColumn("name");
            Country.DBcmd_TP.AddColumn("cntry_cd");
            Country.DBcmd_TP.AddColumn("currency_id");/*Optional 3*/
            Country.DBcmd_TP.AddColumn("longform_coefficient");/*Optional 5*/
            Country.DBcmd_TP.AddColumn("In_ESP");/*Optional 6*/
            Country.DBcmd_TP.AddColumn("ISO3_cntry_cd");/*Optional 7*/
            Country.DBcmd_TP.AddColumn("GlobeTaxEmail");/*Optional 8*/

            return Country.DBcmd_TP;
        }

        public Country() { }
        public Country(string id) { this.pk_ID = id; }

        private string pk_ID; //primary key
        public string name { get { return this.pk_ID; } }

        public readonly HssUtility.General.Attributes.String_attr cntry_cd = new HssUtility.General.Attributes.String_attr();
        public readonly HssUtility.General.Attributes.Int_attr currency_id = new HssUtility.General.Attributes.Int_attr();/*Optional 3*/
        public readonly HssUtility.General.Attributes.Decimal_attr longform_coefficient = new HssUtility.General.Attributes.Decimal_attr();/*Optional 5*/
        public readonly HssUtility.General.Attributes.Bool_attr In_ESP = new HssUtility.General.Attributes.Bool_attr();/*Optional 6*/
        public readonly HssUtility.General.Attributes.String_attr ISO3_cntry_cd = new HssUtility.General.Attributes.String_attr();/*Optional 7*/
        public readonly HssUtility.General.Attributes.String_attr GlobeTaxEmail = new HssUtility.General.Attributes.String_attr();/*Optional 8*/

        private List<HssUtility.General.Attributes.I_modelAttr> attrList = null;

        internal void Init_from_reader(HssUtility.SQLserver.DB_reader reader)
        {
            if (reader == null || reader.IsClosed) return;

            this.pk_ID = reader.GetString("name");
            reader.GetString("cntry_cd", this.cntry_cd);
            reader.GetInt("currency_id", this.currency_id);/*Optional 3*/
            reader.GetDecimal("longform_coefficient", this.longform_coefficient);/*Optional 5*/
            reader.GetBool("In_ESP", this.In_ESP);/*Optional 6*/
            reader.GetString("ISO3_cntry_cd", this.ISO3_cntry_cd);/*Optional 7*/
            reader.GetString("GlobeTaxEmail", this.GlobeTaxEmail);/*Optional 8*/

            this.SyncWithDB();
        }

        /// <summary>
        /// Initialize object from DB
        /// </summary>
        public bool Init_from_DB()
        {
            if (string.IsNullOrEmpty(this.name)) return false;

            HssUtility.SQLserver.DB_select db_sel = new HssUtility.SQLserver.DB_select(Country.Get_cmdTP());
            db_sel.tableName = "Countries";
            HssUtility.SQLserver.SQL_relation rela = new HssUtility.SQLserver.SQL_relation("name", HssUtility.General.RelationalOperator.Equals, this.name);
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
            this.attrList.Add(this.cntry_cd);
            this.attrList.Add(this.currency_id);/*Optional 3*/
            this.attrList.Add(this.longform_coefficient);/*Optional 5*/
            this.attrList.Add(this.In_ESP);/*Optional 6*/
            this.attrList.Add(this.ISO3_cntry_cd);/*Optional 7*/
            this.attrList.Add(this.GlobeTaxEmail);/*Optional 8*/
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
            HssUtility.SQLserver.DB_insert dbIns = new HssUtility.SQLserver.DB_insert(Country.Get_cmdTP());

            dbIns.AddValue("cntry_cd", this.cntry_cd.Value);
            dbIns.AddValue("currency_id", this.currency_id);/*Optional 3*/
            dbIns.AddValue("longform_coefficient", this.longform_coefficient);/*Optional 5*/
            dbIns.AddValue("In_ESP", this.In_ESP);/*Optional 6*/
            dbIns.AddValue("ISO3_cntry_cd", this.ISO3_cntry_cd);/*Optional 7*/
            dbIns.AddValue("GlobeTaxEmail", this.GlobeTaxEmail);/*Optional 8*/

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

            HssUtility.SQLserver.DB_update upd = new HssUtility.SQLserver.DB_update(Country.Get_cmdTP());
            if (this.cntry_cd.ValueChanged) upd.AddValue("cntry_cd", this.cntry_cd);
            if (this.currency_id.ValueChanged) upd.AddValue("currency_id", this.currency_id);
            if (this.longform_coefficient.ValueChanged) upd.AddValue("longform_coefficient", this.longform_coefficient);
            if (this.In_ESP.ValueChanged) upd.AddValue("In_ESP", this.In_ESP);
            if (this.ISO3_cntry_cd.ValueChanged) upd.AddValue("ISO3_cntry_cd", this.ISO3_cntry_cd);
            if (this.GlobeTaxEmail.ValueChanged) upd.AddValue("GlobeTaxEmail", this.GlobeTaxEmail);

            HssUtility.SQLserver.SQL_relation rela = new HssUtility.SQLserver.SQL_relation("name", HssUtility.General.RelationalOperator.Equals, this.pk_ID);
            upd.SetCondition(rela);

            return upd;
        }

        public Country GetCopy()
        {
            Country newEntity = new Country();
            if (!this.cntry_cd.IsNull_flag) newEntity.cntry_cd.Value = this.cntry_cd.Value;
            if (!this.currency_id.IsNull_flag) newEntity.currency_id.Value = this.currency_id.Value;
            if (!this.longform_coefficient.IsNull_flag) newEntity.longform_coefficient.Value = this.longform_coefficient.Value;
            if (!this.In_ESP.IsNull_flag) newEntity.In_ESP.Value = this.In_ESP.Value;
            if (!this.ISO3_cntry_cd.IsNull_flag) newEntity.ISO3_cntry_cd.Value = this.ISO3_cntry_cd.Value;
            if (!this.GlobeTaxEmail.IsNull_flag) newEntity.GlobeTaxEmail.Value = this.GlobeTaxEmail.Value;
            return newEntity;
        }

        public string ToXML()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("<Country>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<name>").Append(this.name).Append("</name>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<cntry_cd>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.cntry_cd.Value)).Append("</cntry_cd>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<currency_id>").Append(this.currency_id.Value).Append("</currency_id>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<longform_coefficient>").Append(this.longform_coefficient.Value).Append("</longform_coefficient>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<In_ESP>").Append(this.In_ESP.Value).Append("</In_ESP>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<ISO3_cntry_cd>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.ISO3_cntry_cd.Value)).Append("</ISO3_cntry_cd>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<GlobeTaxEmail>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.GlobeTaxEmail.Value)).Append("</GlobeTaxEmail>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("</Country>").Append(HssUtility.General.HssStr.WinNextLine);
            return sb.ToString();
        }
        /*^^^^^^^^^^^^^^^^^^^^^^^^^^^^^Hss Entity Framework Auto Generated Code^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^*/
    }
}
