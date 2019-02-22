using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HssDARWIN.Models.EDI_synonyms
{
    public class EDI_times
    {/*-----------------------------Hss Entity Framework Auto Generated Code-------------------------------*/
        private static HssUtility.SQLserver.CmdTemplate DBcmd_TP = null;
        public static HssUtility.SQLserver.CmdTemplate Get_cmdTP()
        {
            if (EDI_times.DBcmd_TP != null) return EDI_times.DBcmd_TP;

            EDI_times.DBcmd_TP = new HssUtility.SQLserver.CmdTemplate();
            EDI_times.DBcmd_TP.tableName = "times";
            EDI_times.DBcmd_TP.schema = "dbo";

            EDI_times.DBcmd_TP.AddColumn("id");
            EDI_times.DBcmd_TP.AddColumn("cntry_cd");
            EDI_times.DBcmd_TP.AddColumn("bo_cor");
            EDI_times.DBcmd_TP.AddColumn("timebar");
            EDI_times.DBcmd_TP.AddColumn("eoy");
            EDI_times.DBcmd_TP.AddColumn("pay_dt");
            EDI_times.DBcmd_TP.AddColumn("expect_dt");
            EDI_times.DBcmd_TP.AddColumn("effect_dt");
            EDI_times.DBcmd_TP.AddColumn("from_dt");
            EDI_times.DBcmd_TP.AddColumn("created_dt");
            EDI_times.DBcmd_TP.AddColumn("modified_dt");
            EDI_times.DBcmd_TP.AddColumn("migratedId");
            EDI_times.DBcmd_TP.AddColumn("sec_type");

            return EDI_times.DBcmd_TP;
        }

        public EDI_times() { }
        public EDI_times(int id) { this.pk_ID = id; }

        private int pk_ID = -1; //primary key
        public int id { get { return this.pk_ID; } }

        public readonly HssUtility.General.Attributes.String_attr cntry_cd = new HssUtility.General.Attributes.String_attr();
        public readonly HssUtility.General.Attributes.String_attr bo_cor = new HssUtility.General.Attributes.String_attr();
        public readonly HssUtility.General.Attributes.Int_attr timebar = new HssUtility.General.Attributes.Int_attr();
        public readonly HssUtility.General.Attributes.Bool_attr eoy = new HssUtility.General.Attributes.Bool_attr();
        public readonly HssUtility.General.Attributes.Bool_attr pay_dt = new HssUtility.General.Attributes.Bool_attr();
        public readonly HssUtility.General.Attributes.Int_attr expect_dt = new HssUtility.General.Attributes.Int_attr();
        public readonly HssUtility.General.Attributes.DateTime_attr effect_dt = new HssUtility.General.Attributes.DateTime_attr();
        public readonly HssUtility.General.Attributes.DateTime_attr from_dt = new HssUtility.General.Attributes.DateTime_attr();
        public readonly HssUtility.General.Attributes.DateTime_attr created_dt = new HssUtility.General.Attributes.DateTime_attr();
        public readonly HssUtility.General.Attributes.DateTime_attr modified_dt = new HssUtility.General.Attributes.DateTime_attr();
        public readonly HssUtility.General.Attributes.Int_attr migratedId = new HssUtility.General.Attributes.Int_attr();
        public readonly HssUtility.General.Attributes.Int_attr sec_type = new HssUtility.General.Attributes.Int_attr();

        private Dictionary<string, HssUtility.General.Attributes.I_modelAttr> attr_dic = null;

        internal void Init_from_reader(HssUtility.SQLserver.DB_reader reader)
        {
            if (reader == null || reader.IsClosed) return;

            this.pk_ID = reader.GetInt("id");
            reader.GetString("cntry_cd", this.cntry_cd);
            reader.GetString("bo_cor", this.bo_cor);
            reader.GetInt("timebar", this.timebar);
            reader.GetBool("eoy", this.eoy);
            reader.GetBool("pay_dt", this.pay_dt);
            reader.GetInt("expect_dt", this.expect_dt);
            reader.GetDateTime("effect_dt", this.effect_dt);
            reader.GetDateTime("from_dt", this.from_dt);
            reader.GetDateTime("created_dt", this.created_dt);
            reader.GetDateTime("modified_dt", this.modified_dt);
            reader.GetInt("migratedId", this.migratedId);
            reader.GetInt("sec_type", this.sec_type);

            this.SyncWithDB();
        }

        /// <summary>
        /// Initialize object from DB
        /// </summary>
        public bool Init_from_DB()
        {
            if (this.id < 0) return false;

            HssUtility.SQLserver.DB_select db_sel = new HssUtility.SQLserver.DB_select(EDI_times.Get_cmdTP());
            db_sel.tableName = "times";
            HssUtility.SQLserver.SQL_relation rela = new HssUtility.SQLserver.SQL_relation("id", HssUtility.General.RelationalOperator.Equals, this.id);
            db_sel.SetCondition(rela);

            bool res_flag = false;
            HssUtility.SQLserver.DB_reader reader = new HssUtility.SQLserver.DB_reader(db_sel, Utility.Get_EDI_hDB());
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
            this.attr_dic.Add("cntry_cd", this.cntry_cd);
            this.attr_dic.Add("bo_cor", this.bo_cor);
            this.attr_dic.Add("timebar", this.timebar);
            this.attr_dic.Add("eoy", this.eoy);
            this.attr_dic.Add("pay_dt", this.pay_dt);
            this.attr_dic.Add("expect_dt", this.expect_dt);
            this.attr_dic.Add("effect_dt", this.effect_dt);
            this.attr_dic.Add("from_dt", this.from_dt);
            this.attr_dic.Add("created_dt", this.created_dt);
            this.attr_dic.Add("modified_dt", this.modified_dt);
            this.attr_dic.Add("migratedId", this.migratedId);
            this.attr_dic.Add("sec_type", this.sec_type);
        }

        /// <summary>
        /// Insert object to DB
        /// </summary>
        public bool Insert_to_DB()
        {
            HssUtility.SQLserver.DB_insert ins = this.Get_DBinsert();
            int count = ins.SaveToDB(Utility.Get_EDI_hDB());

            bool flag = count > 0;
            if (flag) this.SyncWithDB();

            return flag;
        }

        internal HssUtility.SQLserver.DB_insert Get_DBinsert()
        {
            HssUtility.SQLserver.DB_insert dbIns = new HssUtility.SQLserver.DB_insert(EDI_times.Get_cmdTP());

            dbIns.AddValue("cntry_cd", this.cntry_cd);
            dbIns.AddValue("bo_cor", this.bo_cor);
            dbIns.AddValue("timebar", this.timebar);
            dbIns.AddValue("eoy", this.eoy);
            dbIns.AddValue("pay_dt", this.pay_dt);
            dbIns.AddValue("expect_dt", this.expect_dt);
            dbIns.AddValue("effect_dt", this.effect_dt);
            dbIns.AddValue("from_dt", this.from_dt);
            dbIns.AddValue("created_dt", this.created_dt);
            dbIns.AddValue("modified_dt", this.modified_dt);
            dbIns.AddValue("migratedId", this.migratedId);
            dbIns.AddValue("sec_type", this.sec_type);

            return dbIns;
        }

        /// <summary>
        /// Save updates to DB
        /// </summary>
        public bool Update_to_DB()
        {
            HssUtility.SQLserver.DB_update upd = this.Get_DBupdate();
            if (upd == null) return false;

            int count = upd.SaveToDB(Utility.Get_EDI_hDB());
            bool flag = count > 0;
            if (flag) this.SyncWithDB();

            return flag;
        }

        internal HssUtility.SQLserver.DB_update Get_DBupdate()
        {
            if (!this.CheckValueChanges()) return null;

            HssUtility.SQLserver.DB_update upd = new HssUtility.SQLserver.DB_update(EDI_times.Get_cmdTP());
            if (this.cntry_cd.ValueChanged) upd.AddValue("cntry_cd", this.cntry_cd);
            if (this.bo_cor.ValueChanged) upd.AddValue("bo_cor", this.bo_cor);
            if (this.timebar.ValueChanged) upd.AddValue("timebar", this.timebar);
            if (this.eoy.ValueChanged) upd.AddValue("eoy", this.eoy);
            if (this.pay_dt.ValueChanged) upd.AddValue("pay_dt", this.pay_dt);
            if (this.expect_dt.ValueChanged) upd.AddValue("expect_dt", this.expect_dt);
            if (this.effect_dt.ValueChanged) upd.AddValue("effect_dt", this.effect_dt);
            if (this.from_dt.ValueChanged) upd.AddValue("from_dt", this.from_dt);
            if (this.created_dt.ValueChanged) upd.AddValue("created_dt", this.created_dt);
            if (this.modified_dt.ValueChanged) upd.AddValue("modified_dt", this.modified_dt);
            if (this.migratedId.ValueChanged) upd.AddValue("migratedId", this.migratedId);
            if (this.sec_type.ValueChanged) upd.AddValue("sec_type", this.sec_type);

            HssUtility.SQLserver.SQL_relation rela = new HssUtility.SQLserver.SQL_relation("id", HssUtility.General.RelationalOperator.Equals, this.pk_ID);
            upd.SetCondition(rela);

            return upd;
        }

        public EDI_times GetCopy()
        {
            EDI_times newEntity = new EDI_times();
            if (!this.cntry_cd.IsNull_flag) newEntity.cntry_cd.Value = this.cntry_cd.Value;
            if (!this.bo_cor.IsNull_flag) newEntity.bo_cor.Value = this.bo_cor.Value;
            if (!this.timebar.IsNull_flag) newEntity.timebar.Value = this.timebar.Value;
            if (!this.eoy.IsNull_flag) newEntity.eoy.Value = this.eoy.Value;
            if (!this.pay_dt.IsNull_flag) newEntity.pay_dt.Value = this.pay_dt.Value;
            if (!this.expect_dt.IsNull_flag) newEntity.expect_dt.Value = this.expect_dt.Value;
            if (!this.effect_dt.IsNull_flag) newEntity.effect_dt.Value = this.effect_dt.Value;
            if (!this.from_dt.IsNull_flag) newEntity.from_dt.Value = this.from_dt.Value;
            if (!this.created_dt.IsNull_flag) newEntity.created_dt.Value = this.created_dt.Value;
            if (!this.modified_dt.IsNull_flag) newEntity.modified_dt.Value = this.modified_dt.Value;
            if (!this.migratedId.IsNull_flag) newEntity.migratedId.Value = this.migratedId.Value;
            if (!this.sec_type.IsNull_flag) newEntity.sec_type.Value = this.sec_type.Value;
            return newEntity;
        }

        public string ToXML()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("<EDI_times>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<id>").Append(this.id).Append("</id>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<cntry_cd>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.cntry_cd.Value)).Append("</cntry_cd>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<bo_cor>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.bo_cor.Value)).Append("</bo_cor>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<timebar>").Append(this.timebar.Value).Append("</timebar>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<eoy>").Append(this.eoy.Value).Append("</eoy>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<pay_dt>").Append(this.pay_dt.Value).Append("</pay_dt>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<expect_dt>").Append(this.expect_dt.Value).Append("</expect_dt>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<effect_dt>").Append(this.effect_dt.Value).Append("</effect_dt>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<from_dt>").Append(this.from_dt.Value).Append("</from_dt>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<created_dt>").Append(this.created_dt.Value).Append("</created_dt>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<modified_dt>").Append(this.modified_dt.Value).Append("</modified_dt>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<migratedId>").Append(this.migratedId.Value).Append("</migratedId>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<sec_type>").Append(this.sec_type.Value).Append("</sec_type>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("</EDI_times>").Append(HssUtility.General.HssStr.WinNextLine);
            return sb.ToString();
        }
        /*^^^^^^^^^^^^^^^^^^^^^^^^^^^^^Hss Entity Framework Auto Generated Code^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^*/
    }
}
