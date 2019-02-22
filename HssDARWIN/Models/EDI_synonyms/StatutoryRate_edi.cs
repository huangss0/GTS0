using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HssDARWIN.Models.EDI_synonyms
{
    public class StatutoryRate_edi
    {
        /*-----------------------------Hss Entity Framework Auto Generated Code-------------------------------*/
        private static HssUtility.SQLserver.CmdTemplate DBcmd_TP = null;
        public static HssUtility.SQLserver.CmdTemplate Get_cmdTP()
        {
            if (StatutoryRate_edi.DBcmd_TP != null) return StatutoryRate_edi.DBcmd_TP;

            StatutoryRate_edi.DBcmd_TP = new HssUtility.SQLserver.CmdTemplate();
            StatutoryRate_edi.DBcmd_TP.tableName = "edi_strtapprv";
            StatutoryRate_edi.DBcmd_TP.schema = "dbo";

            StatutoryRate_edi.DBcmd_TP.AddColumn("id");
            StatutoryRate_edi.DBcmd_TP.AddColumn("coi");/*Optional 2*/
            StatutoryRate_edi.DBcmd_TP.AddColumn("cor");/*Optional 3*/
            StatutoryRate_edi.DBcmd_TP.AddColumn("statry_rt");/*Optional 4*/
            StatutoryRate_edi.DBcmd_TP.AddColumn("int_rt");/*Optional 5*/
            StatutoryRate_edi.DBcmd_TP.AddColumn("effect_dt");/*Optional 6*/
            StatutoryRate_edi.DBcmd_TP.AddColumn("created_dt");/*Optional 7*/
            StatutoryRate_edi.DBcmd_TP.AddColumn("modified_dt");/*Optional 8*/
            StatutoryRate_edi.DBcmd_TP.AddColumn("migratedId");/*Optional 9*/
            StatutoryRate_edi.DBcmd_TP.AddColumn("sec_type");/*Optional 10*/
            StatutoryRate_edi.DBcmd_TP.AddColumn("bo_typ");/*Optional 11*/

            return StatutoryRate_edi.DBcmd_TP;
        }

        public StatutoryRate_edi() { }
        public StatutoryRate_edi(int id) { this.pk_ID = id; }

        private int pk_ID = -1; //primary key
        public int id { get { return this.pk_ID; } }

        public readonly HssUtility.General.Attributes.String_attr coi = new HssUtility.General.Attributes.String_attr();/*Optional 2*/
        public readonly HssUtility.General.Attributes.String_attr cor = new HssUtility.General.Attributes.String_attr();/*Optional 3*/
        public readonly HssUtility.General.Attributes.Decimal_attr statry_rt = new HssUtility.General.Attributes.Decimal_attr();/*Optional 4*/
        public readonly HssUtility.General.Attributes.Decimal_attr int_rt = new HssUtility.General.Attributes.Decimal_attr();/*Optional 5*/
        public readonly HssUtility.General.Attributes.DateTime_attr effect_dt = new HssUtility.General.Attributes.DateTime_attr();/*Optional 6*/
        public readonly HssUtility.General.Attributes.DateTime_attr created_dt = new HssUtility.General.Attributes.DateTime_attr();/*Optional 7*/
        public readonly HssUtility.General.Attributes.DateTime_attr modified_dt = new HssUtility.General.Attributes.DateTime_attr();/*Optional 8*/
        public readonly HssUtility.General.Attributes.Int_attr migratedId = new HssUtility.General.Attributes.Int_attr();/*Optional 9*/
        public readonly HssUtility.General.Attributes.Int_attr sec_type = new HssUtility.General.Attributes.Int_attr();/*Optional 10*/
        public readonly HssUtility.General.Attributes.String_attr bo_typ = new HssUtility.General.Attributes.String_attr();/*Optional 11*/

        private List<HssUtility.General.Attributes.I_modelAttr> attrList = null;

        internal void Init_from_reader(HssUtility.SQLserver.DB_reader reader)
        {
            if (reader == null || reader.IsClosed) return;

            this.pk_ID = reader.GetInt("id");
            reader.GetString("coi", this.coi);/*Optional 2*/
            reader.GetString("cor", this.cor);/*Optional 3*/
            reader.GetDecimal("statry_rt", this.statry_rt);/*Optional 4*/
            reader.GetDecimal("int_rt", this.int_rt);/*Optional 5*/
            reader.GetDateTime("effect_dt", this.effect_dt);/*Optional 6*/
            reader.GetDateTime("created_dt", this.created_dt);/*Optional 7*/
            reader.GetDateTime("modified_dt", this.modified_dt);/*Optional 8*/
            reader.GetInt("migratedId", this.migratedId);/*Optional 9*/
            reader.GetInt("sec_type", this.sec_type);/*Optional 10*/
            reader.GetString("bo_typ", this.bo_typ);/*Optional 11*/

            this.SyncWithDB();
        }

        /// <summary>
        /// Initialize object from DB
        /// </summary>
        public bool Init_from_DB()
        {
            if (this.id < 0) return false;

            HssUtility.SQLserver.DB_select db_sel = new HssUtility.SQLserver.DB_select(StatutoryRate_edi.Get_cmdTP());
            db_sel.tableName = "edi_strtapprv";
            HssUtility.SQLserver.SQL_relation rela = new HssUtility.SQLserver.SQL_relation("id", HssUtility.General.RelationalOperator.Equals, this.id);
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
            this.attrList.Add(this.coi);/*Optional 2*/
            this.attrList.Add(this.cor);/*Optional 3*/
            this.attrList.Add(this.statry_rt);/*Optional 4*/
            this.attrList.Add(this.int_rt);/*Optional 5*/
            this.attrList.Add(this.effect_dt);/*Optional 6*/
            this.attrList.Add(this.created_dt);/*Optional 7*/
            this.attrList.Add(this.modified_dt);/*Optional 8*/
            this.attrList.Add(this.migratedId);/*Optional 9*/
            this.attrList.Add(this.sec_type);/*Optional 10*/
            this.attrList.Add(this.bo_typ);/*Optional 11*/
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
            HssUtility.SQLserver.DB_insert dbIns = new HssUtility.SQLserver.DB_insert(StatutoryRate_edi.Get_cmdTP());

            dbIns.AddValue("coi", this.coi);/*Optional 2*/
            dbIns.AddValue("cor", this.cor);/*Optional 3*/
            dbIns.AddValue("statry_rt", this.statry_rt);/*Optional 4*/
            dbIns.AddValue("int_rt", this.int_rt);/*Optional 5*/
            dbIns.AddValue("effect_dt", this.effect_dt);/*Optional 6*/
            dbIns.AddValue("created_dt", this.created_dt);/*Optional 7*/
            dbIns.AddValue("modified_dt", this.modified_dt);/*Optional 8*/
            dbIns.AddValue("migratedId", this.migratedId);/*Optional 9*/
            dbIns.AddValue("sec_type", this.sec_type);/*Optional 10*/
            dbIns.AddValue("bo_typ", this.bo_typ);/*Optional 11*/

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

            HssUtility.SQLserver.DB_update upd = new HssUtility.SQLserver.DB_update(StatutoryRate_edi.Get_cmdTP());
            if (this.coi.ValueChanged) upd.AddValue("coi", this.coi);
            if (this.cor.ValueChanged) upd.AddValue("cor", this.cor);
            if (this.statry_rt.ValueChanged) upd.AddValue("statry_rt", this.statry_rt);
            if (this.int_rt.ValueChanged) upd.AddValue("int_rt", this.int_rt);
            if (this.effect_dt.ValueChanged) upd.AddValue("effect_dt", this.effect_dt);
            if (this.created_dt.ValueChanged) upd.AddValue("created_dt", this.created_dt);
            if (this.modified_dt.ValueChanged) upd.AddValue("modified_dt", this.modified_dt);
            if (this.migratedId.ValueChanged) upd.AddValue("migratedId", this.migratedId);
            if (this.sec_type.ValueChanged) upd.AddValue("sec_type", this.sec_type);
            if (this.bo_typ.ValueChanged) upd.AddValue("bo_typ", this.bo_typ);

            HssUtility.SQLserver.SQL_relation rela = new HssUtility.SQLserver.SQL_relation("id", HssUtility.General.RelationalOperator.Equals, this.pk_ID);
            upd.SetCondition(rela);

            return upd;
        }

        public StatutoryRate_edi GetCopy()
        {
            StatutoryRate_edi newEntity = new StatutoryRate_edi();
            if (!this.coi.IsNull_flag) newEntity.coi.Value = this.coi.Value;
            if (!this.cor.IsNull_flag) newEntity.cor.Value = this.cor.Value;
            if (!this.statry_rt.IsNull_flag) newEntity.statry_rt.Value = this.statry_rt.Value;
            if (!this.int_rt.IsNull_flag) newEntity.int_rt.Value = this.int_rt.Value;
            if (!this.effect_dt.IsNull_flag) newEntity.effect_dt.Value = this.effect_dt.Value;
            if (!this.created_dt.IsNull_flag) newEntity.created_dt.Value = this.created_dt.Value;
            if (!this.modified_dt.IsNull_flag) newEntity.modified_dt.Value = this.modified_dt.Value;
            if (!this.migratedId.IsNull_flag) newEntity.migratedId.Value = this.migratedId.Value;
            if (!this.sec_type.IsNull_flag) newEntity.sec_type.Value = this.sec_type.Value;
            if (!this.bo_typ.IsNull_flag) newEntity.bo_typ.Value = this.bo_typ.Value;
            return newEntity;
        }

        public string ToXML()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("<StatutoryRate>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<id>").Append(this.id).Append("</id>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<coi>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.coi.Value)).Append("</coi>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<cor>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.cor.Value)).Append("</cor>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<statry_rt>").Append(this.statry_rt.Value).Append("</statry_rt>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<int_rt>").Append(this.int_rt.Value).Append("</int_rt>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<effect_dt>").Append(this.effect_dt.Value).Append("</effect_dt>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<created_dt>").Append(this.created_dt.Value).Append("</created_dt>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<modified_dt>").Append(this.modified_dt.Value).Append("</modified_dt>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<migratedId>").Append(this.migratedId.Value).Append("</migratedId>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<sec_type>").Append(this.sec_type.Value).Append("</sec_type>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<bo_typ>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.bo_typ.Value)).Append("</bo_typ>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("</StatutoryRate>").Append(HssUtility.General.HssStr.WinNextLine);
            return sb.ToString();
        }
        /*^^^^^^^^^^^^^^^^^^^^^^^^^^^^^Hss Entity Framework Auto Generated Code^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^*/
    }
}
