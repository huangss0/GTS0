using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HssDARWIN.Models.EDI_synonyms
{
    public class EDI_country
    {
        /*-----------------------------Hss Entity Framework Auto Generated Code-------------------------------*/
        private static HssUtility.SQLserver.CmdTemplate DBcmd_TP = null;
        public static HssUtility.SQLserver.CmdTemplate Get_cmdTP()
        {
            if (EDI_country.DBcmd_TP != null) return EDI_country.DBcmd_TP;

            EDI_country.DBcmd_TP = new HssUtility.SQLserver.CmdTemplate();
            EDI_country.DBcmd_TP.tableName = "edi_cntrytable";
            EDI_country.DBcmd_TP.schema = "dbo";

            EDI_country.DBcmd_TP.AddColumn("cntry_cd");
            EDI_country.DBcmd_TP.AddColumn("name");/*Optional 2*/
            EDI_country.DBcmd_TP.AddColumn("currency_id");/*Optional 3*/
            EDI_country.DBcmd_TP.AddColumn("iso2_cd");/*Optional 4*/
            EDI_country.DBcmd_TP.AddColumn("iso3_cd");/*Optional 5*/

            return EDI_country.DBcmd_TP;
        }

        public EDI_country() { }
        public EDI_country(string id) { this.pk_ID = id; }

        private string pk_ID; //primary key
        public string cntry_cd { get { return this.pk_ID; } }

        public readonly HssUtility.General.Attributes.String_attr name = new HssUtility.General.Attributes.String_attr();/*Optional 2*/
        public readonly HssUtility.General.Attributes.Int_attr currency_id = new HssUtility.General.Attributes.Int_attr();/*Optional 3*/
        public readonly HssUtility.General.Attributes.String_attr iso2_cd = new HssUtility.General.Attributes.String_attr();/*Optional 4*/
        public readonly HssUtility.General.Attributes.String_attr iso3_cd = new HssUtility.General.Attributes.String_attr();/*Optional 5*/

        private List<HssUtility.General.Attributes.I_modelAttr> attrList = null;

        internal void Init_from_reader(HssUtility.SQLserver.DB_reader reader)
        {
            if (reader == null || reader.IsClosed) return;

            this.pk_ID = reader.GetString("cntry_cd");
            reader.GetString("name", this.name);/*Optional 2*/
            reader.GetInt("currency_id", this.currency_id);/*Optional 3*/
            reader.GetString("iso2_cd", this.iso2_cd);/*Optional 4*/
            reader.GetString("iso3_cd", this.iso3_cd);/*Optional 5*/

            this.SyncWithDB();
        }

        /// <summary>
        /// Initialize object from DB
        /// </summary>
        public bool Init_from_DB()
        {
            if (string.IsNullOrEmpty(this.cntry_cd)) return false;

            HssUtility.SQLserver.DB_select db_sel = new HssUtility.SQLserver.DB_select(EDI_country.Get_cmdTP());
            db_sel.tableName = "edi_cntrytable";
            HssUtility.SQLserver.SQL_relation rela = new HssUtility.SQLserver.SQL_relation("cntry_cd", HssUtility.General.RelationalOperator.Equals, this.cntry_cd);
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
            this.attrList.Add(this.name);/*Optional 2*/
            this.attrList.Add(this.currency_id);/*Optional 3*/
            this.attrList.Add(this.iso2_cd);/*Optional 4*/
            this.attrList.Add(this.iso3_cd);/*Optional 5*/
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
            HssUtility.SQLserver.DB_insert dbIns = new HssUtility.SQLserver.DB_insert(EDI_country.Get_cmdTP());

            dbIns.AddValue("name", this.name);/*Optional 2*/
            dbIns.AddValue("currency_id", this.currency_id);/*Optional 3*/
            dbIns.AddValue("iso2_cd", this.iso2_cd);/*Optional 4*/
            dbIns.AddValue("iso3_cd", this.iso3_cd);/*Optional 5*/

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

            HssUtility.SQLserver.DB_update upd = new HssUtility.SQLserver.DB_update(EDI_country.Get_cmdTP());
            if (this.name.ValueChanged) upd.AddValue("name", this.name);
            if (this.currency_id.ValueChanged) upd.AddValue("currency_id", this.currency_id);
            if (this.iso2_cd.ValueChanged) upd.AddValue("iso2_cd", this.iso2_cd);
            if (this.iso3_cd.ValueChanged) upd.AddValue("iso3_cd", this.iso3_cd);

            HssUtility.SQLserver.SQL_relation rela = new HssUtility.SQLserver.SQL_relation("cntry_cd", HssUtility.General.RelationalOperator.Equals, this.pk_ID);
            upd.SetCondition(rela);

            return upd;
        }

        public EDI_country GetCopy()
        {
            EDI_country newEntity = new EDI_country();
            if (!this.name.IsNull_flag) newEntity.name.Value = this.name.Value;
            if (!this.currency_id.IsNull_flag) newEntity.currency_id.Value = this.currency_id.Value;
            if (!this.iso2_cd.IsNull_flag) newEntity.iso2_cd.Value = this.iso2_cd.Value;
            if (!this.iso3_cd.IsNull_flag) newEntity.iso3_cd.Value = this.iso3_cd.Value;
            return newEntity;
        }

        public string ToXML()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("<EDI_country>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<cntry_cd>").Append(this.cntry_cd).Append("</cntry_cd>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<name>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.name.Value)).Append("</name>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<currency_id>").Append(this.currency_id.Value).Append("</currency_id>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<iso2_cd>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.iso2_cd.Value)).Append("</iso2_cd>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<iso3_cd>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.iso3_cd.Value)).Append("</iso3_cd>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("</EDI_country>").Append(HssUtility.General.HssStr.WinNextLine);
            return sb.ToString();
        }
        /*^^^^^^^^^^^^^^^^^^^^^^^^^^^^^Hss Entity Framework Auto Generated Code^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^*/
    }
}
