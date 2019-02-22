using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HssDARWIN.Models.Filing
{
    public class Dividend_Filing
    {
        /*-----------------------------Hss Entity Framework Auto Generated Code-------------------------------*/
        private static HssUtility.SQLserver.CmdTemplate DBcmd_TP = null;
        public static HssUtility.SQLserver.CmdTemplate Get_cmdTP()
        {
            if (Dividend_Filing.DBcmd_TP != null) return Dividend_Filing.DBcmd_TP;

            Dividend_Filing.DBcmd_TP = new HssUtility.SQLserver.CmdTemplate();
            Dividend_Filing.DBcmd_TP.tableName = "Dividend_Filing";
            Dividend_Filing.DBcmd_TP.schema = "dbo";

            Dividend_Filing.DBcmd_TP.AddColumn("Dividend_FilingID");
            Dividend_Filing.DBcmd_TP.AddColumn("DividendIndex");
            Dividend_Filing.DBcmd_TP.AddColumn("Custodian_Tax_Authority");/*Optional 3*/
            Dividend_Filing.DBcmd_TP.AddColumn("FiledDate");
            Dividend_Filing.DBcmd_TP.AddColumn("Num_ADRs_Filed");/*Optional 5*/
            Dividend_Filing.DBcmd_TP.AddColumn("Num_ORDs_Filed");/*Optional 6*/
            Dividend_Filing.DBcmd_TP.AddColumn("FedEx_Number");/*Optional 7*/
            Dividend_Filing.DBcmd_TP.AddColumn("Filing_Method");/*Optional 8*/
            Dividend_Filing.DBcmd_TP.AddColumn("Reference_Number");/*Optional 9*/
            Dividend_Filing.DBcmd_TP.AddColumn("Delivery_Status");/*Optional 10*/
            Dividend_Filing.DBcmd_TP.AddColumn("Accept");/*Optional 11*/
            Dividend_Filing.DBcmd_TP.AddColumn("LastModifiedBy");/*Optional 12*/
            Dividend_Filing.DBcmd_TP.AddColumn("ModifiedDateTime");/*Optional 13*/
            Dividend_Filing.DBcmd_TP.AddColumn("Custodial_Receipt_Date");/*Optional 14*/
            Dividend_Filing.DBcmd_TP.AddColumn("CustodianID");/*Optional 15*/
            Dividend_Filing.DBcmd_TP.AddColumn("ReclaimFeesType");/*Optional 16*/
            Dividend_Filing.DBcmd_TP.AddColumn("Master_Reference_Number");/*Optional 17*/
            Dividend_Filing.DBcmd_TP.AddColumn("FilingStatus");/*Optional 18*/
            Dividend_Filing.DBcmd_TP.AddColumn("Allowed_ReclaimFeesTypes");/*Optional 19*/
            Dividend_Filing.DBcmd_TP.AddColumn("FilingTo");/*Optional 20*/

            return Dividend_Filing.DBcmd_TP;
        }

        public Dividend_Filing() { }
        public Dividend_Filing(int id) { this.pk_ID = id; }

        private int pk_ID = -1; //primary key
        public int Dividend_FilingID { get { return this.pk_ID; } }

        public readonly HssUtility.General.Attributes.Int_attr DividendIndex = new HssUtility.General.Attributes.Int_attr();
        public readonly HssUtility.General.Attributes.String_attr Custodian_Tax_Authority = new HssUtility.General.Attributes.String_attr();/*Optional 3*/
        public readonly HssUtility.General.Attributes.DateTime_attr FiledDate = new HssUtility.General.Attributes.DateTime_attr();
        public readonly HssUtility.General.Attributes.Int_attr Num_ADRs_Filed = new HssUtility.General.Attributes.Int_attr();/*Optional 5*/
        public readonly HssUtility.General.Attributes.Int_attr Num_ORDs_Filed = new HssUtility.General.Attributes.Int_attr();/*Optional 6*/
        public readonly HssUtility.General.Attributes.String_attr FedEx_Number = new HssUtility.General.Attributes.String_attr();/*Optional 7*/
        public readonly HssUtility.General.Attributes.String_attr Filing_Method = new HssUtility.General.Attributes.String_attr();/*Optional 8*/
        public readonly HssUtility.General.Attributes.String_attr Reference_Number = new HssUtility.General.Attributes.String_attr();/*Optional 9*/
        public readonly HssUtility.General.Attributes.String_attr Delivery_Status = new HssUtility.General.Attributes.String_attr();/*Optional 10*/
        public readonly HssUtility.General.Attributes.Bool_attr Accept = new HssUtility.General.Attributes.Bool_attr();/*Optional 11*/
        public readonly HssUtility.General.Attributes.String_attr LastModifiedBy = new HssUtility.General.Attributes.String_attr();/*Optional 12*/
        public readonly HssUtility.General.Attributes.DateTime_attr ModifiedDateTime = new HssUtility.General.Attributes.DateTime_attr();/*Optional 13*/
        public readonly HssUtility.General.Attributes.DateTime_attr Custodial_Receipt_Date = new HssUtility.General.Attributes.DateTime_attr();/*Optional 14*/
        public readonly HssUtility.General.Attributes.Int_attr CustodianID = new HssUtility.General.Attributes.Int_attr();/*Optional 15*/
        public readonly HssUtility.General.Attributes.String_attr ReclaimFeesType = new HssUtility.General.Attributes.String_attr();/*Optional 16*/
        public readonly HssUtility.General.Attributes.String_attr Master_Reference_Number = new HssUtility.General.Attributes.String_attr();/*Optional 17*/
        public readonly HssUtility.General.Attributes.String_attr FilingStatus = new HssUtility.General.Attributes.String_attr();/*Optional 18*/
        public readonly HssUtility.General.Attributes.String_attr Allowed_ReclaimFeesTypes = new HssUtility.General.Attributes.String_attr();/*Optional 19*/
        public readonly HssUtility.General.Attributes.String_attr FilingTo = new HssUtility.General.Attributes.String_attr();/*Optional 20*/

        private Dictionary<string, HssUtility.General.Attributes.I_modelAttr> attr_dic = null;

        internal void Init_from_reader(HssUtility.SQLserver.DB_reader reader)
        {
            if (reader == null || reader.IsClosed) return;

            this.pk_ID = reader.GetInt("Dividend_FilingID");
            reader.GetInt("DividendIndex", this.DividendIndex);
            reader.GetString("Custodian_Tax_Authority", this.Custodian_Tax_Authority);/*Optional 3*/
            reader.GetDateTime("FiledDate", this.FiledDate);
            reader.GetInt("Num_ADRs_Filed", this.Num_ADRs_Filed);/*Optional 5*/
            reader.GetInt("Num_ORDs_Filed", this.Num_ORDs_Filed);/*Optional 6*/
            reader.GetString("FedEx_Number", this.FedEx_Number);/*Optional 7*/
            reader.GetString("Filing_Method", this.Filing_Method);/*Optional 8*/
            reader.GetString("Reference_Number", this.Reference_Number);/*Optional 9*/
            reader.GetString("Delivery_Status", this.Delivery_Status);/*Optional 10*/
            reader.GetBool("Accept", this.Accept);/*Optional 11*/
            reader.GetString("LastModifiedBy", this.LastModifiedBy);/*Optional 12*/
            reader.GetDateTime("ModifiedDateTime", this.ModifiedDateTime);/*Optional 13*/
            reader.GetDateTime("Custodial_Receipt_Date", this.Custodial_Receipt_Date);/*Optional 14*/
            reader.GetInt("CustodianID", this.CustodianID);/*Optional 15*/
            reader.GetString("ReclaimFeesType", this.ReclaimFeesType);/*Optional 16*/
            reader.GetString("Master_Reference_Number", this.Master_Reference_Number);/*Optional 17*/
            reader.GetString("FilingStatus", this.FilingStatus);/*Optional 18*/
            reader.GetString("Allowed_ReclaimFeesTypes", this.Allowed_ReclaimFeesTypes);/*Optional 19*/
            reader.GetString("FilingTo", this.FilingTo);/*Optional 20*/

            this.SyncWithDB();
        }

        /// <summary>
        /// Initialize object from DB
        /// </summary>
        public bool Init_from_DB()
        {
            if (this.Dividend_FilingID < 0) return false;

            HssUtility.SQLserver.DB_select db_sel = new HssUtility.SQLserver.DB_select(Dividend_Filing.Get_cmdTP());
            db_sel.tableName = "Dividend_Filing";
            HssUtility.SQLserver.SQL_relation rela = new HssUtility.SQLserver.SQL_relation("Dividend_FilingID", HssUtility.General.RelationalOperator.Equals, this.Dividend_FilingID);
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
            this.attr_dic.Add("DividendIndex", this.DividendIndex);
            this.attr_dic.Add("Custodian_Tax_Authority", this.Custodian_Tax_Authority);/*Optional 3*/
            this.attr_dic.Add("FiledDate", this.FiledDate);
            this.attr_dic.Add("Num_ADRs_Filed", this.Num_ADRs_Filed);/*Optional 5*/
            this.attr_dic.Add("Num_ORDs_Filed", this.Num_ORDs_Filed);/*Optional 6*/
            this.attr_dic.Add("FedEx_Number", this.FedEx_Number);/*Optional 7*/
            this.attr_dic.Add("Filing_Method", this.Filing_Method);/*Optional 8*/
            this.attr_dic.Add("Reference_Number", this.Reference_Number);/*Optional 9*/
            this.attr_dic.Add("Delivery_Status", this.Delivery_Status);/*Optional 10*/
            this.attr_dic.Add("Accept", this.Accept);/*Optional 11*/
            this.attr_dic.Add("LastModifiedBy", this.LastModifiedBy);/*Optional 12*/
            this.attr_dic.Add("ModifiedDateTime", this.ModifiedDateTime);/*Optional 13*/
            this.attr_dic.Add("Custodial_Receipt_Date", this.Custodial_Receipt_Date);/*Optional 14*/
            this.attr_dic.Add("CustodianID", this.CustodianID);/*Optional 15*/
            this.attr_dic.Add("ReclaimFeesType", this.ReclaimFeesType);/*Optional 16*/
            this.attr_dic.Add("Master_Reference_Number", this.Master_Reference_Number);/*Optional 17*/
            this.attr_dic.Add("FilingStatus", this.FilingStatus);/*Optional 18*/
            this.attr_dic.Add("Allowed_ReclaimFeesTypes", this.Allowed_ReclaimFeesTypes);/*Optional 19*/
            this.attr_dic.Add("FilingTo", this.FilingTo);/*Optional 20*/
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
            HssUtility.SQLserver.DB_insert dbIns = new HssUtility.SQLserver.DB_insert(Dividend_Filing.Get_cmdTP());

            dbIns.AddValue("DividendIndex", this.DividendIndex);
            dbIns.AddValue("Custodian_Tax_Authority", this.Custodian_Tax_Authority);/*Optional 3*/
            dbIns.AddValue("FiledDate", this.FiledDate);
            dbIns.AddValue("Num_ADRs_Filed", this.Num_ADRs_Filed);/*Optional 5*/
            dbIns.AddValue("Num_ORDs_Filed", this.Num_ORDs_Filed);/*Optional 6*/
            dbIns.AddValue("FedEx_Number", this.FedEx_Number);/*Optional 7*/
            dbIns.AddValue("Filing_Method", this.Filing_Method);/*Optional 8*/
            dbIns.AddValue("Reference_Number", this.Reference_Number);/*Optional 9*/
            dbIns.AddValue("Delivery_Status", this.Delivery_Status);/*Optional 10*/
            dbIns.AddValue("Accept", this.Accept);/*Optional 11*/
            dbIns.AddValue("LastModifiedBy", this.LastModifiedBy);/*Optional 12*/
            dbIns.AddValue("ModifiedDateTime", this.ModifiedDateTime);/*Optional 13*/
            dbIns.AddValue("Custodial_Receipt_Date", this.Custodial_Receipt_Date);/*Optional 14*/
            dbIns.AddValue("CustodianID", this.CustodianID);/*Optional 15*/
            dbIns.AddValue("ReclaimFeesType", this.ReclaimFeesType);/*Optional 16*/
            dbIns.AddValue("Master_Reference_Number", this.Master_Reference_Number);/*Optional 17*/
            dbIns.AddValue("FilingStatus", this.FilingStatus);/*Optional 18*/
            dbIns.AddValue("Allowed_ReclaimFeesTypes", this.Allowed_ReclaimFeesTypes);/*Optional 19*/
            dbIns.AddValue("FilingTo", this.FilingTo);/*Optional 20*/

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

            HssUtility.SQLserver.DB_update upd = new HssUtility.SQLserver.DB_update(Dividend_Filing.Get_cmdTP());
            if (this.DividendIndex.ValueChanged) upd.AddValue("DividendIndex", this.DividendIndex);
            if (this.Custodian_Tax_Authority.ValueChanged) upd.AddValue("Custodian_Tax_Authority", this.Custodian_Tax_Authority);/*Optional 3*/
            if (this.FiledDate.ValueChanged) upd.AddValue("FiledDate", this.FiledDate);
            if (this.Num_ADRs_Filed.ValueChanged) upd.AddValue("Num_ADRs_Filed", this.Num_ADRs_Filed);/*Optional 5*/
            if (this.Num_ORDs_Filed.ValueChanged) upd.AddValue("Num_ORDs_Filed", this.Num_ORDs_Filed);/*Optional 6*/
            if (this.FedEx_Number.ValueChanged) upd.AddValue("FedEx_Number", this.FedEx_Number);/*Optional 7*/
            if (this.Filing_Method.ValueChanged) upd.AddValue("Filing_Method", this.Filing_Method);/*Optional 8*/
            if (this.Reference_Number.ValueChanged) upd.AddValue("Reference_Number", this.Reference_Number);/*Optional 9*/
            if (this.Delivery_Status.ValueChanged) upd.AddValue("Delivery_Status", this.Delivery_Status);/*Optional 10*/
            if (this.Accept.ValueChanged) upd.AddValue("Accept", this.Accept);/*Optional 11*/
            if (this.LastModifiedBy.ValueChanged) upd.AddValue("LastModifiedBy", this.LastModifiedBy);/*Optional 12*/
            if (this.ModifiedDateTime.ValueChanged) upd.AddValue("ModifiedDateTime", this.ModifiedDateTime);/*Optional 13*/
            if (this.Custodial_Receipt_Date.ValueChanged) upd.AddValue("Custodial_Receipt_Date", this.Custodial_Receipt_Date);/*Optional 14*/
            if (this.CustodianID.ValueChanged) upd.AddValue("CustodianID", this.CustodianID);/*Optional 15*/
            if (this.ReclaimFeesType.ValueChanged) upd.AddValue("ReclaimFeesType", this.ReclaimFeesType);/*Optional 16*/
            if (this.Master_Reference_Number.ValueChanged) upd.AddValue("Master_Reference_Number", this.Master_Reference_Number);/*Optional 17*/
            if (this.FilingStatus.ValueChanged) upd.AddValue("FilingStatus", this.FilingStatus);/*Optional 18*/
            if (this.Allowed_ReclaimFeesTypes.ValueChanged) upd.AddValue("Allowed_ReclaimFeesTypes", this.Allowed_ReclaimFeesTypes);/*Optional 19*/
            if (this.FilingTo.ValueChanged) upd.AddValue("FilingTo", this.FilingTo);/*Optional 20*/

            HssUtility.SQLserver.SQL_relation rela = new HssUtility.SQLserver.SQL_relation("Dividend_FilingID", HssUtility.General.RelationalOperator.Equals, this.pk_ID);
            upd.SetCondition(rela);

            return upd;
        }

        public Dividend_Filing GetCopy()
        {
            Dividend_Filing newEntity = new Dividend_Filing();
            if (!this.DividendIndex.IsNull_flag) newEntity.DividendIndex.Value = this.DividendIndex.Value;
            if (!this.Custodian_Tax_Authority.IsNull_flag) newEntity.Custodian_Tax_Authority.Value = this.Custodian_Tax_Authority.Value;
            if (!this.FiledDate.IsNull_flag) newEntity.FiledDate.Value = this.FiledDate.Value;
            if (!this.Num_ADRs_Filed.IsNull_flag) newEntity.Num_ADRs_Filed.Value = this.Num_ADRs_Filed.Value;
            if (!this.Num_ORDs_Filed.IsNull_flag) newEntity.Num_ORDs_Filed.Value = this.Num_ORDs_Filed.Value;
            if (!this.FedEx_Number.IsNull_flag) newEntity.FedEx_Number.Value = this.FedEx_Number.Value;
            if (!this.Filing_Method.IsNull_flag) newEntity.Filing_Method.Value = this.Filing_Method.Value;
            if (!this.Reference_Number.IsNull_flag) newEntity.Reference_Number.Value = this.Reference_Number.Value;
            if (!this.Delivery_Status.IsNull_flag) newEntity.Delivery_Status.Value = this.Delivery_Status.Value;
            if (!this.Accept.IsNull_flag) newEntity.Accept.Value = this.Accept.Value;
            if (!this.LastModifiedBy.IsNull_flag) newEntity.LastModifiedBy.Value = this.LastModifiedBy.Value;
            if (!this.ModifiedDateTime.IsNull_flag) newEntity.ModifiedDateTime.Value = this.ModifiedDateTime.Value;
            if (!this.Custodial_Receipt_Date.IsNull_flag) newEntity.Custodial_Receipt_Date.Value = this.Custodial_Receipt_Date.Value;
            if (!this.CustodianID.IsNull_flag) newEntity.CustodianID.Value = this.CustodianID.Value;
            if (!this.ReclaimFeesType.IsNull_flag) newEntity.ReclaimFeesType.Value = this.ReclaimFeesType.Value;
            if (!this.Master_Reference_Number.IsNull_flag) newEntity.Master_Reference_Number.Value = this.Master_Reference_Number.Value;
            if (!this.FilingStatus.IsNull_flag) newEntity.FilingStatus.Value = this.FilingStatus.Value;
            if (!this.Allowed_ReclaimFeesTypes.IsNull_flag) newEntity.Allowed_ReclaimFeesTypes.Value = this.Allowed_ReclaimFeesTypes.Value;
            if (!this.FilingTo.IsNull_flag) newEntity.FilingTo.Value = this.FilingTo.Value;
            return newEntity;
        }

        public string ToXML()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("<Dividend_Filing>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Dividend_FilingID>").Append(this.Dividend_FilingID).Append("</Dividend_FilingID>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<DividendIndex>").Append(this.DividendIndex.Value).Append("</DividendIndex>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Custodian_Tax_Authority>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.Custodian_Tax_Authority.Value)).Append("</Custodian_Tax_Authority>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<FiledDate>").Append(this.FiledDate.Value).Append("</FiledDate>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Num_ADRs_Filed>").Append(this.Num_ADRs_Filed.Value).Append("</Num_ADRs_Filed>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Num_ORDs_Filed>").Append(this.Num_ORDs_Filed.Value).Append("</Num_ORDs_Filed>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<FedEx_Number>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.FedEx_Number.Value)).Append("</FedEx_Number>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Filing_Method>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.Filing_Method.Value)).Append("</Filing_Method>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Reference_Number>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.Reference_Number.Value)).Append("</Reference_Number>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Delivery_Status>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.Delivery_Status.Value)).Append("</Delivery_Status>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Accept>").Append(this.Accept.Value).Append("</Accept>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<LastModifiedBy>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.LastModifiedBy.Value)).Append("</LastModifiedBy>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<ModifiedDateTime>").Append(this.ModifiedDateTime.Value).Append("</ModifiedDateTime>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Custodial_Receipt_Date>").Append(this.Custodial_Receipt_Date.Value).Append("</Custodial_Receipt_Date>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<CustodianID>").Append(this.CustodianID.Value).Append("</CustodianID>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<ReclaimFeesType>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.ReclaimFeesType.Value)).Append("</ReclaimFeesType>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Master_Reference_Number>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.Master_Reference_Number.Value)).Append("</Master_Reference_Number>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<FilingStatus>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.FilingStatus.Value)).Append("</FilingStatus>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Allowed_ReclaimFeesTypes>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.Allowed_ReclaimFeesTypes.Value)).Append("</Allowed_ReclaimFeesTypes>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<FilingTo>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.FilingTo.Value)).Append("</FilingTo>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("</Dividend_Filing>").Append(HssUtility.General.HssStr.WinNextLine);
            return sb.ToString();
        }
        /*^^^^^^^^^^^^^^^^^^^^^^^^^^^^^Hss Entity Framework Auto Generated Code^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^*/
    }
}
