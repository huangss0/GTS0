using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HssDARWIN.Models.XBRL.Fields
{
    public class XBRLfield
    {
        /*-----------------------------Hss Entity Framework Auto Generated Code-------------------------------*/
        private static HssUtility.SQLserver.CmdTemplate DBcmd_TP = null;
        public static HssUtility.SQLserver.CmdTemplate Get_cmdTP()
        {
            if (XBRLfield.DBcmd_TP != null) return XBRLfield.DBcmd_TP;

            XBRLfield.DBcmd_TP = new HssUtility.SQLserver.CmdTemplate();
            XBRLfield.DBcmd_TP.tableName = "XBRLField";
            XBRLfield.DBcmd_TP.schema = "dbo";

            XBRLfield.DBcmd_TP.AddColumn("id_XBRLField");
            XBRLfield.DBcmd_TP.AddColumn("xbrlElement");
            XBRLfield.DBcmd_TP.AddColumn("xbrlAttributeName");/*Optional 3*/
            XBRLfield.DBcmd_TP.AddColumn("xbrlContextRefValue");/*Optional 4*/
            XBRLfield.DBcmd_TP.AddColumn("namespace");/*Optional 5*/
            XBRLfield.DBcmd_TP.AddColumn("drwinFieldName");/*Optional 6*/
            XBRLfield.DBcmd_TP.AddColumn("drwinControlType");/*Optional 7*/
            XBRLfield.DBcmd_TP.AddColumn("multiple");/*Optional 8*/
            XBRLfield.DBcmd_TP.AddColumn("active");/*Optional 9*/
            XBRLfield.DBcmd_TP.AddColumn("chkCompleteness");/*Optional 10*/
            XBRLfield.DBcmd_TP.AddColumn("drwinFieldNameIncomplete");/*Optional 11*/
            XBRLfield.DBcmd_TP.AddColumn("drwinFieldNameComplete");/*Optional 12*/
            XBRLfield.DBcmd_TP.AddColumn("createdDate");
            XBRLfield.DBcmd_TP.AddColumn("createdBy");
            XBRLfield.DBcmd_TP.AddColumn("overridable");/*Optional 15*/

            return XBRLfield.DBcmd_TP;
        }

        public XBRLfield() { }
        public XBRLfield(int id) { this.pk_ID = id; }

        private int pk_ID = -1; //primary key
        public int id_XBRLField { get { return this.pk_ID; } }

        public readonly HssUtility.General.Attributes.String_attr xbrlElement = new HssUtility.General.Attributes.String_attr();
        public readonly HssUtility.General.Attributes.String_attr xbrlAttributeName = new HssUtility.General.Attributes.String_attr();/*Optional 3*/
        public readonly HssUtility.General.Attributes.String_attr xbrlContextRefValue = new HssUtility.General.Attributes.String_attr();/*Optional 4*/
        public readonly HssUtility.General.Attributes.String_attr NameSpace = new HssUtility.General.Attributes.String_attr();/*Optional 5*/
        public readonly HssUtility.General.Attributes.String_attr drwinFieldName = new HssUtility.General.Attributes.String_attr("");/*Optional 6*/
        public readonly HssUtility.General.Attributes.String_attr drwinControlType = new HssUtility.General.Attributes.String_attr();/*Optional 7*/
        public readonly HssUtility.General.Attributes.Bool_attr multiple = new HssUtility.General.Attributes.Bool_attr();/*Optional 8*/
        public readonly HssUtility.General.Attributes.Bool_attr active = new HssUtility.General.Attributes.Bool_attr();/*Optional 9*/
        public readonly HssUtility.General.Attributes.Bool_attr chkCompleteness = new HssUtility.General.Attributes.Bool_attr();/*Optional 10*/
        public readonly HssUtility.General.Attributes.String_attr drwinFieldNameIncomplete = new HssUtility.General.Attributes.String_attr();/*Optional 11*/
        public readonly HssUtility.General.Attributes.String_attr drwinFieldNameComplete = new HssUtility.General.Attributes.String_attr();/*Optional 12*/
        public readonly HssUtility.General.Attributes.DateTime_attr createdDate = new HssUtility.General.Attributes.DateTime_attr();
        public readonly HssUtility.General.Attributes.String_attr createdBy = new HssUtility.General.Attributes.String_attr();
        public readonly HssUtility.General.Attributes.Bool_attr overridable = new HssUtility.General.Attributes.Bool_attr();/*Optional 15*/

        private Dictionary<string, HssUtility.General.Attributes.I_modelAttr> attr_dic = null;

        internal void Init_from_reader(HssUtility.SQLserver.DB_reader reader)
        {
            if (reader == null || reader.IsClosed) return;

            this.pk_ID = reader.GetInt("id_XBRLField");
            reader.GetString("xbrlElement", this.xbrlElement);
            reader.GetString("xbrlAttributeName", this.xbrlAttributeName);/*Optional 3*/
            reader.GetString("xbrlContextRefValue", this.xbrlContextRefValue);/*Optional 4*/
            reader.GetString("namespace", this.NameSpace);/*Optional 5*/
            reader.GetString("drwinFieldName", this.drwinFieldName);/*Optional 6*/
            reader.GetString("drwinControlType", this.drwinControlType);/*Optional 7*/
            reader.GetBool("multiple", this.multiple);/*Optional 8*/
            reader.GetBool("active", this.active);/*Optional 9*/
            reader.GetBool("chkCompleteness", this.chkCompleteness);/*Optional 10*/
            reader.GetString("drwinFieldNameIncomplete", this.drwinFieldNameIncomplete);/*Optional 11*/
            reader.GetString("drwinFieldNameComplete", this.drwinFieldNameComplete);/*Optional 12*/
            reader.GetDateTime("createdDate", this.createdDate);
            reader.GetString("createdBy", this.createdBy);
            reader.GetBool("overridable", this.overridable);/*Optional 15*/

            this.SyncWithDB();
        }

        /// <summary>
        /// Initialize object from DB
        /// </summary>
        public bool Init_from_DB()
        {
            if (this.id_XBRLField < 0) return false;

            HssUtility.SQLserver.DB_select db_sel = new HssUtility.SQLserver.DB_select(XBRLfield.Get_cmdTP());
            db_sel.tableName = "XBRLField";
            HssUtility.SQLserver.SQL_relation rela = new HssUtility.SQLserver.SQL_relation("id_XBRLField", HssUtility.General.RelationalOperator.Equals, this.id_XBRLField);
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
            this.attr_dic.Add("xbrlElement", this.xbrlElement);
            this.attr_dic.Add("xbrlAttributeName", this.xbrlAttributeName);/*Optional 3*/
            this.attr_dic.Add("xbrlContextRefValue", this.xbrlContextRefValue);/*Optional 4*/
            this.attr_dic.Add("namespace", this.NameSpace);/*Optional 5*/
            this.attr_dic.Add("drwinFieldName", this.drwinFieldName);/*Optional 6*/
            this.attr_dic.Add("drwinControlType", this.drwinControlType);/*Optional 7*/
            this.attr_dic.Add("multiple", this.multiple);/*Optional 8*/
            this.attr_dic.Add("active", this.active);/*Optional 9*/
            this.attr_dic.Add("chkCompleteness", this.chkCompleteness);/*Optional 10*/
            this.attr_dic.Add("drwinFieldNameIncomplete", this.drwinFieldNameIncomplete);/*Optional 11*/
            this.attr_dic.Add("drwinFieldNameComplete", this.drwinFieldNameComplete);/*Optional 12*/
            this.attr_dic.Add("createdDate", this.createdDate);
            this.attr_dic.Add("createdBy", this.createdBy);
            this.attr_dic.Add("overridable", this.overridable);/*Optional 15*/
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
            HssUtility.SQLserver.DB_insert dbIns = new HssUtility.SQLserver.DB_insert(XBRLfield.Get_cmdTP());

            dbIns.AddValue("xbrlElement", this.xbrlElement.Value);
            dbIns.AddValue("xbrlAttributeName", this.xbrlAttributeName);/*Optional 3*/
            dbIns.AddValue("xbrlContextRefValue", this.xbrlContextRefValue);/*Optional 4*/
            dbIns.AddValue("namespace", this.NameSpace);/*Optional 5*/
            dbIns.AddValue("drwinFieldName", this.drwinFieldName);/*Optional 6*/
            dbIns.AddValue("drwinControlType", this.drwinControlType);/*Optional 7*/
            dbIns.AddValue("multiple", this.multiple);/*Optional 8*/
            dbIns.AddValue("active", this.active);/*Optional 9*/
            dbIns.AddValue("chkCompleteness", this.chkCompleteness);/*Optional 10*/
            dbIns.AddValue("drwinFieldNameIncomplete", this.drwinFieldNameIncomplete);/*Optional 11*/
            dbIns.AddValue("drwinFieldNameComplete", this.drwinFieldNameComplete);/*Optional 12*/
            dbIns.AddValue("createdDate", this.createdDate.Value);
            dbIns.AddValue("createdBy", this.createdBy.Value);
            dbIns.AddValue("overridable", this.overridable);/*Optional 15*/

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

            HssUtility.SQLserver.DB_update upd = new HssUtility.SQLserver.DB_update(XBRLfield.Get_cmdTP());
            if (this.xbrlElement.ValueChanged) upd.AddValue("xbrlElement", this.xbrlElement);
            if (this.xbrlAttributeName.ValueChanged) upd.AddValue("xbrlAttributeName", this.xbrlAttributeName);
            if (this.xbrlContextRefValue.ValueChanged) upd.AddValue("xbrlContextRefValue", this.xbrlContextRefValue);
            if (this.NameSpace.ValueChanged) upd.AddValue("namespace", this.NameSpace);
            if (this.drwinFieldName.ValueChanged) upd.AddValue("drwinFieldName", this.drwinFieldName);
            if (this.drwinControlType.ValueChanged) upd.AddValue("drwinControlType", this.drwinControlType);
            if (this.multiple.ValueChanged) upd.AddValue("multiple", this.multiple);
            if (this.active.ValueChanged) upd.AddValue("active", this.active);
            if (this.chkCompleteness.ValueChanged) upd.AddValue("chkCompleteness", this.chkCompleteness);
            if (this.drwinFieldNameIncomplete.ValueChanged) upd.AddValue("drwinFieldNameIncomplete", this.drwinFieldNameIncomplete);
            if (this.drwinFieldNameComplete.ValueChanged) upd.AddValue("drwinFieldNameComplete", this.drwinFieldNameComplete);
            if (this.createdDate.ValueChanged) upd.AddValue("createdDate", this.createdDate);
            if (this.createdBy.ValueChanged) upd.AddValue("createdBy", this.createdBy);
            if (this.overridable.ValueChanged) upd.AddValue("overridable", this.overridable);

            HssUtility.SQLserver.SQL_relation rela = new HssUtility.SQLserver.SQL_relation("id_XBRLField", HssUtility.General.RelationalOperator.Equals, this.pk_ID);
            upd.SetCondition(rela);

            return upd;
        }

        public XBRLfield GetCopy()
        {
            XBRLfield newEntity = new XBRLfield();
            if (!this.xbrlElement.IsNull_flag) newEntity.xbrlElement.Value = this.xbrlElement.Value;
            if (!this.xbrlAttributeName.IsNull_flag) newEntity.xbrlAttributeName.Value = this.xbrlAttributeName.Value;
            if (!this.xbrlContextRefValue.IsNull_flag) newEntity.xbrlContextRefValue.Value = this.xbrlContextRefValue.Value;
            if (!this.NameSpace.IsNull_flag) newEntity.NameSpace.Value = this.NameSpace.Value;
            if (!this.drwinFieldName.IsNull_flag) newEntity.drwinFieldName.Value = this.drwinFieldName.Value;
            if (!this.drwinControlType.IsNull_flag) newEntity.drwinControlType.Value = this.drwinControlType.Value;
            if (!this.multiple.IsNull_flag) newEntity.multiple.Value = this.multiple.Value;
            if (!this.active.IsNull_flag) newEntity.active.Value = this.active.Value;
            if (!this.chkCompleteness.IsNull_flag) newEntity.chkCompleteness.Value = this.chkCompleteness.Value;
            if (!this.drwinFieldNameIncomplete.IsNull_flag) newEntity.drwinFieldNameIncomplete.Value = this.drwinFieldNameIncomplete.Value;
            if (!this.drwinFieldNameComplete.IsNull_flag) newEntity.drwinFieldNameComplete.Value = this.drwinFieldNameComplete.Value;
            if (!this.createdDate.IsNull_flag) newEntity.createdDate.Value = this.createdDate.Value;
            if (!this.createdBy.IsNull_flag) newEntity.createdBy.Value = this.createdBy.Value;
            if (!this.overridable.IsNull_flag) newEntity.overridable.Value = this.overridable.Value;
            return newEntity;
        }

        public string ToXML()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("<XBRLField>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<id_XBRLField>").Append(this.id_XBRLField).Append("</id_XBRLField>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<xbrlElement>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.xbrlElement.Value)).Append("</xbrlElement>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<xbrlAttributeName>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.xbrlAttributeName.Value)).Append("</xbrlAttributeName>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<xbrlContextRefValue>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.xbrlContextRefValue.Value)).Append("</xbrlContextRefValue>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<namespace>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.NameSpace.Value)).Append("</namespace>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<drwinFieldName>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.drwinFieldName.Value)).Append("</drwinFieldName>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<drwinControlType>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.drwinControlType.Value)).Append("</drwinControlType>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<multiple>").Append(this.multiple.Value).Append("</multiple>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<active>").Append(this.active.Value).Append("</active>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<chkCompleteness>").Append(this.chkCompleteness.Value).Append("</chkCompleteness>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<drwinFieldNameIncomplete>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.drwinFieldNameIncomplete.Value)).Append("</drwinFieldNameIncomplete>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<drwinFieldNameComplete>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.drwinFieldNameComplete.Value)).Append("</drwinFieldNameComplete>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<createdDate>").Append(this.createdDate.Value).Append("</createdDate>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<createdBy>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.createdBy.Value)).Append("</createdBy>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<overridable>").Append(this.overridable.Value).Append("</overridable>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("</XBRLField>").Append(HssUtility.General.HssStr.WinNextLine);
            return sb.ToString();
        }
        /*^^^^^^^^^^^^^^^^^^^^^^^^^^^^^Hss Entity Framework Auto Generated Code^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^*/
    }
}
