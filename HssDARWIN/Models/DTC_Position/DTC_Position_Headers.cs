using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HssUtility.General;

namespace HssDARWIN.Models.DTC_Position
{
    public class DTC_Position_Headers
    {
        /*-----------------------------Hss Entity Framework Auto Generated Code-------------------------------*/
        private static HssUtility.SQLserver.CmdTemplate DBcmd_TP = null;
        public static HssUtility.SQLserver.CmdTemplate Get_cmdTP()
        {
            if (DTC_Position_Headers.DBcmd_TP != null) return DTC_Position_Headers.DBcmd_TP;

            DTC_Position_Headers.DBcmd_TP = new HssUtility.SQLserver.CmdTemplate();
            DTC_Position_Headers.DBcmd_TP.tableName = "DTC_Position_Headers";
            DTC_Position_Headers.DBcmd_TP.schema = "dbo";

            DTC_Position_Headers.DBcmd_TP.AddColumn("ID");
            DTC_Position_Headers.DBcmd_TP.AddColumn("ModelNumber");
            DTC_Position_Headers.DBcmd_TP.AddColumn("Country");
            DTC_Position_Headers.DBcmd_TP.AddColumn("Column_Header_Name");
            DTC_Position_Headers.DBcmd_TP.AddColumn("Table_Column");
            DTC_Position_Headers.DBcmd_TP.AddColumn("Rate_Desc");/*Optional 6*/
            DTC_Position_Headers.DBcmd_TP.AddColumn("WHRate");/*Optional 7*/
            DTC_Position_Headers.DBcmd_TP.AddColumn("ArmorColumn");/*Optional 8*/
            DTC_Position_Headers.DBcmd_TP.AddColumn("Category");
            DTC_Position_Headers.DBcmd_TP.AddColumn("DiscloseType");
            DTC_Position_Headers.DBcmd_TP.AddColumn("SortOrder");
            DTC_Position_Headers.DBcmd_TP.AddColumn("ChargeBackFrom");/*Optional 12*/
            DTC_Position_Headers.DBcmd_TP.AddColumn("LastModifiedBy");/*Optional 13*/
            DTC_Position_Headers.DBcmd_TP.AddColumn("ModifiedDateTime");/*Optional 14*/

            return DTC_Position_Headers.DBcmd_TP;
        }

        public DTC_Position_Headers() { }
        public DTC_Position_Headers(int id) { this.pk_ID = id; }

        private int pk_ID = -1; //primary key
        public int ID { get { return this.pk_ID; } }

        public readonly HssUtility.General.Attributes.Int_attr ModelNumber = new HssUtility.General.Attributes.Int_attr();
        public readonly HssUtility.General.Attributes.String_attr Country = new HssUtility.General.Attributes.String_attr();
        public readonly HssUtility.General.Attributes.String_attr Column_Header_Name = new HssUtility.General.Attributes.String_attr();
        public readonly HssUtility.General.Attributes.String_attr Table_Column = new HssUtility.General.Attributes.String_attr();
        public readonly HssUtility.General.Attributes.String_attr Rate_Desc = new HssUtility.General.Attributes.String_attr();/*Optional 6*/
        public readonly HssUtility.General.Attributes.Decimal_attr WHRate = new HssUtility.General.Attributes.Decimal_attr();/*Optional 7*/
        public readonly HssUtility.General.Attributes.String_attr ArmorColumn = new HssUtility.General.Attributes.String_attr();/*Optional 8*/
        public readonly HssUtility.General.Attributes.String_attr Category = new HssUtility.General.Attributes.String_attr();
        public readonly HssUtility.General.Attributes.String_attr DiscloseType = new HssUtility.General.Attributes.String_attr();
        public readonly HssUtility.General.Attributes.Int_attr SortOrder = new HssUtility.General.Attributes.Int_attr();
        public readonly HssUtility.General.Attributes.Decimal_attr ChargeBackFrom = new HssUtility.General.Attributes.Decimal_attr();/*Optional 12*/
        public readonly HssUtility.General.Attributes.String_attr LastModifiedBy = new HssUtility.General.Attributes.String_attr();/*Optional 13*/
        public readonly HssUtility.General.Attributes.DateTime_attr ModifiedDateTime = new HssUtility.General.Attributes.DateTime_attr();/*Optional 14*/

        private List<HssUtility.General.Attributes.I_modelAttr> attrList = null;

        internal void Init_from_reader(HssUtility.SQLserver.DB_reader reader)
        {
            if (reader == null || reader.IsClosed) return;

            this.pk_ID = reader.GetInt("ID");
            reader.GetInt("ModelNumber", this.ModelNumber);
            reader.GetString("Country", this.Country);
            reader.GetString("Column_Header_Name", this.Column_Header_Name);
            reader.GetString("Table_Column", this.Table_Column);
            reader.GetString("Rate_Desc", this.Rate_Desc);/*Optional 6*/
            reader.GetDecimal("WHRate", this.WHRate);/*Optional 7*/
            reader.GetString("ArmorColumn", this.ArmorColumn);/*Optional 8*/
            reader.GetString("Category", this.Category);
            reader.GetString("DiscloseType", this.DiscloseType);
            reader.GetInt("SortOrder", this.SortOrder);
            reader.GetDecimal("ChargeBackFrom", this.ChargeBackFrom);/*Optional 12*/
            reader.GetString("LastModifiedBy", this.LastModifiedBy);/*Optional 13*/
            reader.GetDateTime("ModifiedDateTime", this.ModifiedDateTime);/*Optional 14*/

            this.SyncWithDB();
        }

        /// <summary>
        /// Initialize object from DB
        /// </summary>
        public bool Init_from_DB()
        {
            if (this.ID < 0) return false;

            HssUtility.SQLserver.DB_select db_sel = new HssUtility.SQLserver.DB_select(DTC_Position_Headers.Get_cmdTP());
            db_sel.tableName = "DTC_Position_Headers";
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
            this.attrList.Add(this.ModelNumber);
            this.attrList.Add(this.Country);
            this.attrList.Add(this.Column_Header_Name);
            this.attrList.Add(this.Table_Column);
            this.attrList.Add(this.Rate_Desc);/*Optional 6*/
            this.attrList.Add(this.WHRate);/*Optional 7*/
            this.attrList.Add(this.ArmorColumn);/*Optional 8*/
            this.attrList.Add(this.Category);
            this.attrList.Add(this.DiscloseType);
            this.attrList.Add(this.SortOrder);
            this.attrList.Add(this.ChargeBackFrom);/*Optional 12*/
            this.attrList.Add(this.LastModifiedBy);/*Optional 13*/
            this.attrList.Add(this.ModifiedDateTime);/*Optional 14*/
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
            HssUtility.SQLserver.DB_insert dbIns = new HssUtility.SQLserver.DB_insert(DTC_Position_Headers.Get_cmdTP());

            dbIns.AddValue("ModelNumber", this.ModelNumber.Value);
            dbIns.AddValue("Country", this.Country.Value);
            dbIns.AddValue("Column_Header_Name", this.Column_Header_Name.Value);
            dbIns.AddValue("Table_Column", this.Table_Column.Value);
            dbIns.AddValue("Rate_Desc", this.Rate_Desc);/*Optional 6*/
            dbIns.AddValue("WHRate", this.WHRate);/*Optional 7*/
            dbIns.AddValue("ArmorColumn", this.ArmorColumn);/*Optional 8*/
            dbIns.AddValue("Category", this.Category.Value);
            dbIns.AddValue("DiscloseType", this.DiscloseType.Value);
            dbIns.AddValue("SortOrder", this.SortOrder.Value);
            dbIns.AddValue("ChargeBackFrom", this.ChargeBackFrom);/*Optional 12*/
            dbIns.AddValue("LastModifiedBy", this.LastModifiedBy);/*Optional 13*/
            dbIns.AddValue("ModifiedDateTime", this.ModifiedDateTime);/*Optional 14*/

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

            HssUtility.SQLserver.DB_update upd = new HssUtility.SQLserver.DB_update(DTC_Position_Headers.Get_cmdTP());
            if (this.ModelNumber.ValueChanged) upd.AddValue("ModelNumber", this.ModelNumber);
            if (this.Country.ValueChanged) upd.AddValue("Country", this.Country);
            if (this.Column_Header_Name.ValueChanged) upd.AddValue("Column_Header_Name", this.Column_Header_Name);
            if (this.Table_Column.ValueChanged) upd.AddValue("Table_Column", this.Table_Column);
            if (this.Rate_Desc.ValueChanged) upd.AddValue("Rate_Desc", this.Rate_Desc);
            if (this.WHRate.ValueChanged) upd.AddValue("WHRate", this.WHRate);
            if (this.ArmorColumn.ValueChanged) upd.AddValue("ArmorColumn", this.ArmorColumn);
            if (this.Category.ValueChanged) upd.AddValue("Category", this.Category);
            if (this.DiscloseType.ValueChanged) upd.AddValue("DiscloseType", this.DiscloseType);
            if (this.SortOrder.ValueChanged) upd.AddValue("SortOrder", this.SortOrder);
            if (this.ChargeBackFrom.ValueChanged) upd.AddValue("ChargeBackFrom", this.ChargeBackFrom);
            if (this.LastModifiedBy.ValueChanged) upd.AddValue("LastModifiedBy", this.LastModifiedBy);
            if (this.ModifiedDateTime.ValueChanged) upd.AddValue("ModifiedDateTime", this.ModifiedDateTime);

            HssUtility.SQLserver.SQL_relation rela = new HssUtility.SQLserver.SQL_relation("ID", HssUtility.General.RelationalOperator.Equals, this.pk_ID);
            upd.SetCondition(rela);

            return upd;
        }

        public DTC_Position_Headers GetCopy()
        {
            DTC_Position_Headers newEntity = new DTC_Position_Headers();
            if (!this.ModelNumber.IsNull_flag) newEntity.ModelNumber.Value = this.ModelNumber.Value;
            if (!this.Country.IsNull_flag) newEntity.Country.Value = this.Country.Value;
            if (!this.Column_Header_Name.IsNull_flag) newEntity.Column_Header_Name.Value = this.Column_Header_Name.Value;
            if (!this.Table_Column.IsNull_flag) newEntity.Table_Column.Value = this.Table_Column.Value;
            if (!this.Rate_Desc.IsNull_flag) newEntity.Rate_Desc.Value = this.Rate_Desc.Value;
            if (!this.WHRate.IsNull_flag) newEntity.WHRate.Value = this.WHRate.Value;
            if (!this.ArmorColumn.IsNull_flag) newEntity.ArmorColumn.Value = this.ArmorColumn.Value;
            if (!this.Category.IsNull_flag) newEntity.Category.Value = this.Category.Value;
            if (!this.DiscloseType.IsNull_flag) newEntity.DiscloseType.Value = this.DiscloseType.Value;
            if (!this.SortOrder.IsNull_flag) newEntity.SortOrder.Value = this.SortOrder.Value;
            if (!this.ChargeBackFrom.IsNull_flag) newEntity.ChargeBackFrom.Value = this.ChargeBackFrom.Value;
            if (!this.LastModifiedBy.IsNull_flag) newEntity.LastModifiedBy.Value = this.LastModifiedBy.Value;
            if (!this.ModifiedDateTime.IsNull_flag) newEntity.ModifiedDateTime.Value = this.ModifiedDateTime.Value;
            return newEntity;
        }

        public string ToXML()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("<DTC_Position_Headers>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<ID>").Append(this.ID).Append("</ID>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<ModelNumber>").Append(this.ModelNumber.Value).Append("</ModelNumber>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Country>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.Country.Value)).Append("</Country>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Column_Header_Name>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.Column_Header_Name.Value)).Append("</Column_Header_Name>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Table_Column>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.Table_Column.Value)).Append("</Table_Column>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Rate_Desc>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.Rate_Desc.Value)).Append("</Rate_Desc>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<WHRate>").Append(this.WHRate.Value).Append("</WHRate>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<ArmorColumn>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.ArmorColumn.Value)).Append("</ArmorColumn>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Category>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.Category.Value)).Append("</Category>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<DiscloseType>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.DiscloseType.Value)).Append("</DiscloseType>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<SortOrder>").Append(this.SortOrder.Value).Append("</SortOrder>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<ChargeBackFrom>").Append(this.ChargeBackFrom.Value).Append("</ChargeBackFrom>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<LastModifiedBy>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.LastModifiedBy.Value)).Append("</LastModifiedBy>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<ModifiedDateTime>").Append(this.ModifiedDateTime.Value).Append("</ModifiedDateTime>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("</DTC_Position_Headers>").Append(HssUtility.General.HssStr.WinNextLine);
            return sb.ToString();
        }
        /*^^^^^^^^^^^^^^^^^^^^^^^^^^^^^Hss Entity Framework Auto Generated Code^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^*/

        /****************************************************************************************************************************/
        public const int max_charCheckCount = 5;
        public int TableCol_index = -1;

        /// <summary>
        /// Get the index of [Table_column]
        /// </summary>
        public void Calculate()
        {
            string tc_str = this.Table_Column.Value;
            if (string.IsNullOrEmpty(tc_str)) return;

            int index = 0, baseTen = 1, checkCount = 0;

            for (int i = tc_str.Length - 1; i >= 0; --i)
            {
                char c = tc_str[i];
                if (!HssStr.IsNum(c)) break;

                index += (c - '0') * baseTen;
                baseTen *= 10;

                if (++checkCount >= DTC_Position_Headers.max_charCheckCount) break;
            }
            
            if (checkCount > 0) this.TableCol_index = index;
        }
    }
}
