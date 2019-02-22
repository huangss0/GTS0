using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HssDARWIN.Models.DTC_Participant
{
    public class DTC_Participants
    {
        /*-----------------------------Hss Entity Framework Auto Generated Code-------------------------------*/
        private static HssUtility.SQLserver.CmdTemplate DBcmd_TP = null;
        public static HssUtility.SQLserver.CmdTemplate Get_cmdTP()
        {
            if (DTC_Participants.DBcmd_TP != null) return DTC_Participants.DBcmd_TP;

            DTC_Participants.DBcmd_TP = new HssUtility.SQLserver.CmdTemplate();
            DTC_Participants.DBcmd_TP.tableName = "DTC_Participants";
            DTC_Participants.DBcmd_TP.schema = "dbo";

            DTC_Participants.DBcmd_TP.AddColumn("DTC");
            DTC_Participants.DBcmd_TP.AddColumn("DTC_Number");
            DTC_Participants.DBcmd_TP.AddColumn("Company_Name");
            DTC_Participants.DBcmd_TP.AddColumn("ATTN");/*Optional 4*/
            DTC_Participants.DBcmd_TP.AddColumn("Address1");/*Optional 5*/
            DTC_Participants.DBcmd_TP.AddColumn("Address2");/*Optional 6*/
            DTC_Participants.DBcmd_TP.AddColumn("City");/*Optional 7*/
            DTC_Participants.DBcmd_TP.AddColumn("State");/*Optional 8*/
            DTC_Participants.DBcmd_TP.AddColumn("Country");/*Optional 9*/
            DTC_Participants.DBcmd_TP.AddColumn("Zip_Postal_Code");/*Optional 10*/
            DTC_Participants.DBcmd_TP.AddColumn("Phone");/*Optional 11*/
            DTC_Participants.DBcmd_TP.AddColumn("Fax");/*Optional 12*/
            DTC_Participants.DBcmd_TP.AddColumn("WebsiteUrl");/*Optional 13*/
            DTC_Participants.DBcmd_TP.AddColumn("Email");/*Optional 14*/
            DTC_Participants.DBcmd_TP.AddColumn("Fixed_Payment_ATTN");/*Optional 15*/
            DTC_Participants.DBcmd_TP.AddColumn("Type");/*Optional 16*/
            DTC_Participants.DBcmd_TP.AddColumn("Depositary");/*Optional 17*/
            DTC_Participants.DBcmd_TP.AddColumn("RejectEmail");/*Optional 18*/
            DTC_Participants.DBcmd_TP.AddColumn("PaymentEmail");/*Optional 19*/
            DTC_Participants.DBcmd_TP.AddColumn("DocInventoryEmail");/*Optional 20*/
            DTC_Participants.DBcmd_TP.AddColumn("SecurityTypeID");
            DTC_Participants.DBcmd_TP.AddColumn("AccountNumber");
            DTC_Participants.DBcmd_TP.AddColumn("IssuerCSD");/*Optional 23*/
            DTC_Participants.DBcmd_TP.AddColumn("ACH_Override");/*Optional 24*/
            DTC_Participants.DBcmd_TP.AddColumn("ACH_Bank");/*Optional 25*/
            DTC_Participants.DBcmd_TP.AddColumn("ACH_ABA");/*Optional 26*/
            DTC_Participants.DBcmd_TP.AddColumn("ACH_Account");/*Optional 27*/
            DTC_Participants.DBcmd_TP.AddColumn("ClearingSystem");
            DTC_Participants.DBcmd_TP.AddColumn("CustomWireMemo");/*Optional 29*/
            DTC_Participants.DBcmd_TP.AddColumn("ModifiedDateTime");/*Optional 30*/
            DTC_Participants.DBcmd_TP.AddColumn("Email_backup");/*Optional 31*/
            DTC_Participants.DBcmd_TP.AddColumn("PaymentEmail_backup");/*Optional 32*/
            DTC_Participants.DBcmd_TP.AddColumn("RejectEmail_backup");/*Optional 33*/
            DTC_Participants.DBcmd_TP.AddColumn("DocInventoryEmail_backup");/*Optional 34*/

            return DTC_Participants.DBcmd_TP;
        }

        public DTC_Participants() { }
        public DTC_Participants(int id) { this.pk_ID = id; }

        private int pk_ID = -1; //primary key
        public int DTC
        {
            get { return this.pk_ID; }
            set { this.pk_ID = value; }
        }

        public readonly HssUtility.General.Attributes.String_attr DTC_Number = new HssUtility.General.Attributes.String_attr();
        public readonly HssUtility.General.Attributes.String_attr Company_Name = new HssUtility.General.Attributes.String_attr();
        public readonly HssUtility.General.Attributes.String_attr ATTN = new HssUtility.General.Attributes.String_attr();/*Optional 4*/
        public readonly HssUtility.General.Attributes.String_attr Address1 = new HssUtility.General.Attributes.String_attr();/*Optional 5*/
        public readonly HssUtility.General.Attributes.String_attr Address2 = new HssUtility.General.Attributes.String_attr();/*Optional 6*/
        public readonly HssUtility.General.Attributes.String_attr City = new HssUtility.General.Attributes.String_attr();/*Optional 7*/
        public readonly HssUtility.General.Attributes.String_attr State = new HssUtility.General.Attributes.String_attr();/*Optional 8*/
        public readonly HssUtility.General.Attributes.String_attr Country = new HssUtility.General.Attributes.String_attr();/*Optional 9*/
        public readonly HssUtility.General.Attributes.String_attr Zip_Postal_Code = new HssUtility.General.Attributes.String_attr();/*Optional 10*/
        public readonly HssUtility.General.Attributes.String_attr Phone = new HssUtility.General.Attributes.String_attr();/*Optional 11*/
        public readonly HssUtility.General.Attributes.String_attr Fax = new HssUtility.General.Attributes.String_attr();/*Optional 12*/
        public readonly HssUtility.General.Attributes.String_attr WebsiteUrl = new HssUtility.General.Attributes.String_attr();/*Optional 13*/
        public readonly HssUtility.General.Attributes.String_attr Email = new HssUtility.General.Attributes.String_attr();/*Optional 14*/
        public readonly HssUtility.General.Attributes.String_attr Fixed_Payment_ATTN = new HssUtility.General.Attributes.String_attr();/*Optional 15*/
        public readonly HssUtility.General.Attributes.String_attr Type = new HssUtility.General.Attributes.String_attr();/*Optional 16*/
        public readonly HssUtility.General.Attributes.String_attr Depositary = new HssUtility.General.Attributes.String_attr();/*Optional 17*/
        public readonly HssUtility.General.Attributes.String_attr RejectEmail = new HssUtility.General.Attributes.String_attr();/*Optional 18*/
        public readonly HssUtility.General.Attributes.String_attr PaymentEmail = new HssUtility.General.Attributes.String_attr();/*Optional 19*/
        public readonly HssUtility.General.Attributes.String_attr DocInventoryEmail = new HssUtility.General.Attributes.String_attr();/*Optional 20*/
        public readonly HssUtility.General.Attributes.String_attr SecurityTypeID = new HssUtility.General.Attributes.String_attr("1");
        public readonly HssUtility.General.Attributes.String_attr AccountNumber = new HssUtility.General.Attributes.String_attr("");
        public readonly HssUtility.General.Attributes.String_attr IssuerCSD = new HssUtility.General.Attributes.String_attr();/*Optional 23*/
        public readonly HssUtility.General.Attributes.Bool_attr ACH_Override = new HssUtility.General.Attributes.Bool_attr();/*Optional 24*/
        public readonly HssUtility.General.Attributes.String_attr ACH_Bank = new HssUtility.General.Attributes.String_attr();/*Optional 25*/
        public readonly HssUtility.General.Attributes.String_attr ACH_ABA = new HssUtility.General.Attributes.String_attr();/*Optional 26*/
        public readonly HssUtility.General.Attributes.String_attr ACH_Account = new HssUtility.General.Attributes.String_attr();/*Optional 27*/
        public readonly HssUtility.General.Attributes.String_attr ClearingSystem = new HssUtility.General.Attributes.String_attr("DTCC");
        public readonly HssUtility.General.Attributes.String_attr CustomWireMemo = new HssUtility.General.Attributes.String_attr();/*Optional 29*/
        public readonly HssUtility.General.Attributes.DateTime_attr ModifiedDateTime = new HssUtility.General.Attributes.DateTime_attr();/*Optional 30*/
        public readonly HssUtility.General.Attributes.String_attr Email_backup = new HssUtility.General.Attributes.String_attr();/*Optional 31*/
        public readonly HssUtility.General.Attributes.String_attr PaymentEmail_backup = new HssUtility.General.Attributes.String_attr();/*Optional 32*/
        public readonly HssUtility.General.Attributes.String_attr RejectEmail_backup = new HssUtility.General.Attributes.String_attr();/*Optional 33*/
        public readonly HssUtility.General.Attributes.String_attr DocInventoryEmail_backup = new HssUtility.General.Attributes.String_attr();/*Optional 34*/

        private Dictionary<string, HssUtility.General.Attributes.I_modelAttr> attr_dic = null;

        internal void Init_from_reader(HssUtility.SQLserver.DB_reader reader)
        {
            if (reader == null || reader.IsClosed) return;

            this.pk_ID = reader.GetInt("DTC");
            reader.GetString("DTC_Number", this.DTC_Number);
            reader.GetString("Company_Name", this.Company_Name);
            reader.GetString("ATTN", this.ATTN);/*Optional 4*/
            reader.GetString("Address1", this.Address1);/*Optional 5*/
            reader.GetString("Address2", this.Address2);/*Optional 6*/
            reader.GetString("City", this.City);/*Optional 7*/
            reader.GetString("State", this.State);/*Optional 8*/
            reader.GetString("Country", this.Country);/*Optional 9*/
            reader.GetString("Zip_Postal_Code", this.Zip_Postal_Code);/*Optional 10*/
            reader.GetString("Phone", this.Phone);/*Optional 11*/
            reader.GetString("Fax", this.Fax);/*Optional 12*/
            reader.GetString("WebsiteUrl", this.WebsiteUrl);/*Optional 13*/
            reader.GetString("Email", this.Email);/*Optional 14*/
            reader.GetString("Fixed_Payment_ATTN", this.Fixed_Payment_ATTN);/*Optional 15*/
            reader.GetString("Type", this.Type);/*Optional 16*/
            reader.GetString("Depositary", this.Depositary);/*Optional 17*/
            reader.GetString("RejectEmail", this.RejectEmail);/*Optional 18*/
            reader.GetString("PaymentEmail", this.PaymentEmail);/*Optional 19*/
            reader.GetString("DocInventoryEmail", this.DocInventoryEmail);/*Optional 20*/
            reader.GetString("SecurityTypeID", this.SecurityTypeID);
            reader.GetString("AccountNumber", this.AccountNumber);
            reader.GetString("IssuerCSD", this.IssuerCSD);/*Optional 23*/
            reader.GetBool("ACH_Override", this.ACH_Override);/*Optional 24*/
            reader.GetString("ACH_Bank", this.ACH_Bank);/*Optional 25*/
            reader.GetString("ACH_ABA", this.ACH_ABA);/*Optional 26*/
            reader.GetString("ACH_Account", this.ACH_Account);/*Optional 27*/
            reader.GetString("ClearingSystem", this.ClearingSystem);
            reader.GetString("CustomWireMemo", this.CustomWireMemo);/*Optional 29*/
            reader.GetDateTime("ModifiedDateTime", this.ModifiedDateTime);/*Optional 30*/
            reader.GetString("Email_backup", this.Email_backup);/*Optional 31*/
            reader.GetString("PaymentEmail_backup", this.PaymentEmail_backup);/*Optional 32*/
            reader.GetString("RejectEmail_backup", this.RejectEmail_backup);/*Optional 33*/
            reader.GetString("DocInventoryEmail_backup", this.DocInventoryEmail_backup);/*Optional 34*/

            this.SyncWithDB();
        }

        /// <summary>
        /// Initialize object from DB
        /// </summary>
        public bool Init_from_DB()
        {
            if (this.DTC < 0) return false;

            HssUtility.SQLserver.DB_select db_sel = new HssUtility.SQLserver.DB_select(DTC_Participants.Get_cmdTP());
            db_sel.tableName = "DTC_Participants";
            HssUtility.SQLserver.SQL_relation rela = new HssUtility.SQLserver.SQL_relation("DTC", HssUtility.General.RelationalOperator.Equals, this.DTC);
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
            this.attr_dic.Add("DTC_Number", this.DTC_Number);
            this.attr_dic.Add("Company_Name", this.Company_Name);
            this.attr_dic.Add("ATTN", this.ATTN);/*Optional 4*/
            this.attr_dic.Add("Address1", this.Address1);/*Optional 5*/
            this.attr_dic.Add("Address2", this.Address2);/*Optional 6*/
            this.attr_dic.Add("City", this.City);/*Optional 7*/
            this.attr_dic.Add("State", this.State);/*Optional 8*/
            this.attr_dic.Add("Country", this.Country);/*Optional 9*/
            this.attr_dic.Add("Zip_Postal_Code", this.Zip_Postal_Code);/*Optional 10*/
            this.attr_dic.Add("Phone", this.Phone);/*Optional 11*/
            this.attr_dic.Add("Fax", this.Fax);/*Optional 12*/
            this.attr_dic.Add("WebsiteUrl", this.WebsiteUrl);/*Optional 13*/
            this.attr_dic.Add("Email", this.Email);/*Optional 14*/
            this.attr_dic.Add("Fixed_Payment_ATTN", this.Fixed_Payment_ATTN);/*Optional 15*/
            this.attr_dic.Add("Type", this.Type);/*Optional 16*/
            this.attr_dic.Add("Depositary", this.Depositary);/*Optional 17*/
            this.attr_dic.Add("RejectEmail", this.RejectEmail);/*Optional 18*/
            this.attr_dic.Add("PaymentEmail", this.PaymentEmail);/*Optional 19*/
            this.attr_dic.Add("DocInventoryEmail", this.DocInventoryEmail);/*Optional 20*/
            this.attr_dic.Add("SecurityTypeID", this.SecurityTypeID);
            this.attr_dic.Add("AccountNumber", this.AccountNumber);
            this.attr_dic.Add("IssuerCSD", this.IssuerCSD);/*Optional 23*/
            this.attr_dic.Add("ACH_Override", this.ACH_Override);/*Optional 24*/
            this.attr_dic.Add("ACH_Bank", this.ACH_Bank);/*Optional 25*/
            this.attr_dic.Add("ACH_ABA", this.ACH_ABA);/*Optional 26*/
            this.attr_dic.Add("ACH_Account", this.ACH_Account);/*Optional 27*/
            this.attr_dic.Add("ClearingSystem", this.ClearingSystem);
            this.attr_dic.Add("CustomWireMemo", this.CustomWireMemo);/*Optional 29*/
            this.attr_dic.Add("ModifiedDateTime", this.ModifiedDateTime);/*Optional 30*/
            this.attr_dic.Add("Email_backup", this.Email_backup);/*Optional 31*/
            this.attr_dic.Add("PaymentEmail_backup", this.PaymentEmail_backup);/*Optional 32*/
            this.attr_dic.Add("RejectEmail_backup", this.RejectEmail_backup);/*Optional 33*/
            this.attr_dic.Add("DocInventoryEmail_backup", this.DocInventoryEmail_backup);/*Optional 34*/
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
            HssUtility.SQLserver.DB_insert dbIns = new HssUtility.SQLserver.DB_insert(DTC_Participants.Get_cmdTP());

            dbIns.AddValue("DTC", this.DTC);
            dbIns.AddValue("DTC_Number", this.DTC_Number);
            dbIns.AddValue("Company_Name", this.Company_Name);
            dbIns.AddValue("ATTN", this.ATTN);/*Optional 4*/
            dbIns.AddValue("Address1", this.Address1);/*Optional 5*/
            dbIns.AddValue("Address2", this.Address2);/*Optional 6*/
            dbIns.AddValue("City", this.City);/*Optional 7*/
            dbIns.AddValue("State", this.State);/*Optional 8*/
            dbIns.AddValue("Country", this.Country);/*Optional 9*/
            dbIns.AddValue("Zip_Postal_Code", this.Zip_Postal_Code);/*Optional 10*/
            dbIns.AddValue("Phone", this.Phone);/*Optional 11*/
            dbIns.AddValue("Fax", this.Fax);/*Optional 12*/
            dbIns.AddValue("WebsiteUrl", this.WebsiteUrl);/*Optional 13*/
            dbIns.AddValue("Email", this.Email);/*Optional 14*/
            dbIns.AddValue("Fixed_Payment_ATTN", this.Fixed_Payment_ATTN);/*Optional 15*/
            dbIns.AddValue("Type", this.Type);/*Optional 16*/
            dbIns.AddValue("Depositary", this.Depositary);/*Optional 17*/
            dbIns.AddValue("RejectEmail", this.RejectEmail);/*Optional 18*/
            dbIns.AddValue("PaymentEmail", this.PaymentEmail);/*Optional 19*/
            dbIns.AddValue("DocInventoryEmail", this.DocInventoryEmail);/*Optional 20*/
            dbIns.AddValue("SecurityTypeID", this.SecurityTypeID);
            dbIns.AddValue("AccountNumber", this.AccountNumber);
            dbIns.AddValue("IssuerCSD", this.IssuerCSD);/*Optional 23*/
            dbIns.AddValue("ACH_Override", this.ACH_Override);/*Optional 24*/
            dbIns.AddValue("ACH_Bank", this.ACH_Bank);/*Optional 25*/
            dbIns.AddValue("ACH_ABA", this.ACH_ABA);/*Optional 26*/
            dbIns.AddValue("ACH_Account", this.ACH_Account);/*Optional 27*/
            dbIns.AddValue("ClearingSystem", this.ClearingSystem);
            dbIns.AddValue("CustomWireMemo", this.CustomWireMemo);/*Optional 29*/
            dbIns.AddValue("ModifiedDateTime", this.ModifiedDateTime);/*Optional 30*/
            dbIns.AddValue("Email_backup", this.Email_backup);/*Optional 31*/
            dbIns.AddValue("PaymentEmail_backup", this.PaymentEmail_backup);/*Optional 32*/
            dbIns.AddValue("RejectEmail_backup", this.RejectEmail_backup);/*Optional 33*/
            dbIns.AddValue("DocInventoryEmail_backup", this.DocInventoryEmail_backup);/*Optional 34*/

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

            HssUtility.SQLserver.DB_update upd = new HssUtility.SQLserver.DB_update(DTC_Participants.Get_cmdTP());
            if (this.DTC_Number.ValueChanged) upd.AddValue("DTC_Number", this.DTC_Number);
            if (this.Company_Name.ValueChanged) upd.AddValue("Company_Name", this.Company_Name);
            if (this.ATTN.ValueChanged) upd.AddValue("ATTN", this.ATTN);/*Optional 4*/
            if (this.Address1.ValueChanged) upd.AddValue("Address1", this.Address1);/*Optional 5*/
            if (this.Address2.ValueChanged) upd.AddValue("Address2", this.Address2);/*Optional 6*/
            if (this.City.ValueChanged) upd.AddValue("City", this.City);/*Optional 7*/
            if (this.State.ValueChanged) upd.AddValue("State", this.State);/*Optional 8*/
            if (this.Country.ValueChanged) upd.AddValue("Country", this.Country);/*Optional 9*/
            if (this.Zip_Postal_Code.ValueChanged) upd.AddValue("Zip_Postal_Code", this.Zip_Postal_Code);/*Optional 10*/
            if (this.Phone.ValueChanged) upd.AddValue("Phone", this.Phone);/*Optional 11*/
            if (this.Fax.ValueChanged) upd.AddValue("Fax", this.Fax);/*Optional 12*/
            if (this.WebsiteUrl.ValueChanged) upd.AddValue("WebsiteUrl", this.WebsiteUrl);/*Optional 13*/
            if (this.Email.ValueChanged) upd.AddValue("Email", this.Email);/*Optional 14*/
            if (this.Fixed_Payment_ATTN.ValueChanged) upd.AddValue("Fixed_Payment_ATTN", this.Fixed_Payment_ATTN);/*Optional 15*/
            if (this.Type.ValueChanged) upd.AddValue("Type", this.Type);/*Optional 16*/
            if (this.Depositary.ValueChanged) upd.AddValue("Depositary", this.Depositary);/*Optional 17*/
            if (this.RejectEmail.ValueChanged) upd.AddValue("RejectEmail", this.RejectEmail);/*Optional 18*/
            if (this.PaymentEmail.ValueChanged) upd.AddValue("PaymentEmail", this.PaymentEmail);/*Optional 19*/
            if (this.DocInventoryEmail.ValueChanged) upd.AddValue("DocInventoryEmail", this.DocInventoryEmail);/*Optional 20*/
            if (this.SecurityTypeID.ValueChanged) upd.AddValue("SecurityTypeID", this.SecurityTypeID);
            if (this.AccountNumber.ValueChanged) upd.AddValue("AccountNumber", this.AccountNumber);
            if (this.IssuerCSD.ValueChanged) upd.AddValue("IssuerCSD", this.IssuerCSD);/*Optional 23*/
            if (this.ACH_Override.ValueChanged) upd.AddValue("ACH_Override", this.ACH_Override);/*Optional 24*/
            if (this.ACH_Bank.ValueChanged) upd.AddValue("ACH_Bank", this.ACH_Bank);/*Optional 25*/
            if (this.ACH_ABA.ValueChanged) upd.AddValue("ACH_ABA", this.ACH_ABA);/*Optional 26*/
            if (this.ACH_Account.ValueChanged) upd.AddValue("ACH_Account", this.ACH_Account);/*Optional 27*/
            if (this.ClearingSystem.ValueChanged) upd.AddValue("ClearingSystem", this.ClearingSystem);
            if (this.CustomWireMemo.ValueChanged) upd.AddValue("CustomWireMemo", this.CustomWireMemo);/*Optional 29*/
            if (this.ModifiedDateTime.ValueChanged) upd.AddValue("ModifiedDateTime", this.ModifiedDateTime);/*Optional 30*/
            if (this.Email_backup.ValueChanged) upd.AddValue("Email_backup", this.Email_backup);/*Optional 31*/
            if (this.PaymentEmail_backup.ValueChanged) upd.AddValue("PaymentEmail_backup", this.PaymentEmail_backup);/*Optional 32*/
            if (this.RejectEmail_backup.ValueChanged) upd.AddValue("RejectEmail_backup", this.RejectEmail_backup);/*Optional 33*/
            if (this.DocInventoryEmail_backup.ValueChanged) upd.AddValue("DocInventoryEmail_backup", this.DocInventoryEmail_backup);/*Optional 34*/

            HssUtility.SQLserver.SQL_relation rela = new HssUtility.SQLserver.SQL_relation("DTC", HssUtility.General.RelationalOperator.Equals, this.pk_ID);
            upd.SetCondition(rela);

            return upd;
        }

        public DTC_Participants GetCopy()
        {
            DTC_Participants newEntity = new DTC_Participants();
            if (!this.DTC_Number.IsNull_flag) newEntity.DTC_Number.Value = this.DTC_Number.Value;
            if (!this.Company_Name.IsNull_flag) newEntity.Company_Name.Value = this.Company_Name.Value;
            if (!this.ATTN.IsNull_flag) newEntity.ATTN.Value = this.ATTN.Value;
            if (!this.Address1.IsNull_flag) newEntity.Address1.Value = this.Address1.Value;
            if (!this.Address2.IsNull_flag) newEntity.Address2.Value = this.Address2.Value;
            if (!this.City.IsNull_flag) newEntity.City.Value = this.City.Value;
            if (!this.State.IsNull_flag) newEntity.State.Value = this.State.Value;
            if (!this.Country.IsNull_flag) newEntity.Country.Value = this.Country.Value;
            if (!this.Zip_Postal_Code.IsNull_flag) newEntity.Zip_Postal_Code.Value = this.Zip_Postal_Code.Value;
            if (!this.Phone.IsNull_flag) newEntity.Phone.Value = this.Phone.Value;
            if (!this.Fax.IsNull_flag) newEntity.Fax.Value = this.Fax.Value;
            if (!this.WebsiteUrl.IsNull_flag) newEntity.WebsiteUrl.Value = this.WebsiteUrl.Value;
            if (!this.Email.IsNull_flag) newEntity.Email.Value = this.Email.Value;
            if (!this.Fixed_Payment_ATTN.IsNull_flag) newEntity.Fixed_Payment_ATTN.Value = this.Fixed_Payment_ATTN.Value;
            if (!this.Type.IsNull_flag) newEntity.Type.Value = this.Type.Value;
            if (!this.Depositary.IsNull_flag) newEntity.Depositary.Value = this.Depositary.Value;
            if (!this.RejectEmail.IsNull_flag) newEntity.RejectEmail.Value = this.RejectEmail.Value;
            if (!this.PaymentEmail.IsNull_flag) newEntity.PaymentEmail.Value = this.PaymentEmail.Value;
            if (!this.DocInventoryEmail.IsNull_flag) newEntity.DocInventoryEmail.Value = this.DocInventoryEmail.Value;
            if (!this.SecurityTypeID.IsNull_flag) newEntity.SecurityTypeID.Value = this.SecurityTypeID.Value;
            if (!this.AccountNumber.IsNull_flag) newEntity.AccountNumber.Value = this.AccountNumber.Value;
            if (!this.IssuerCSD.IsNull_flag) newEntity.IssuerCSD.Value = this.IssuerCSD.Value;
            if (!this.ACH_Override.IsNull_flag) newEntity.ACH_Override.Value = this.ACH_Override.Value;
            if (!this.ACH_Bank.IsNull_flag) newEntity.ACH_Bank.Value = this.ACH_Bank.Value;
            if (!this.ACH_ABA.IsNull_flag) newEntity.ACH_ABA.Value = this.ACH_ABA.Value;
            if (!this.ACH_Account.IsNull_flag) newEntity.ACH_Account.Value = this.ACH_Account.Value;
            if (!this.ClearingSystem.IsNull_flag) newEntity.ClearingSystem.Value = this.ClearingSystem.Value;
            if (!this.CustomWireMemo.IsNull_flag) newEntity.CustomWireMemo.Value = this.CustomWireMemo.Value;
            if (!this.ModifiedDateTime.IsNull_flag) newEntity.ModifiedDateTime.Value = this.ModifiedDateTime.Value;
            if (!this.Email_backup.IsNull_flag) newEntity.Email_backup.Value = this.Email_backup.Value;
            if (!this.PaymentEmail_backup.IsNull_flag) newEntity.PaymentEmail_backup.Value = this.PaymentEmail_backup.Value;
            if (!this.RejectEmail_backup.IsNull_flag) newEntity.RejectEmail_backup.Value = this.RejectEmail_backup.Value;
            if (!this.DocInventoryEmail_backup.IsNull_flag) newEntity.DocInventoryEmail_backup.Value = this.DocInventoryEmail_backup.Value;
            return newEntity;
        }

        public string ToXML()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("<DTC_Participants>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<DTC>").Append(this.DTC).Append("</DTC>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<DTC_Number>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.DTC_Number.Value)).Append("</DTC_Number>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Company_Name>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.Company_Name.Value)).Append("</Company_Name>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<ATTN>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.ATTN.Value)).Append("</ATTN>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Address1>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.Address1.Value)).Append("</Address1>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Address2>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.Address2.Value)).Append("</Address2>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<City>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.City.Value)).Append("</City>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<State>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.State.Value)).Append("</State>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Country>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.Country.Value)).Append("</Country>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Zip_Postal_Code>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.Zip_Postal_Code.Value)).Append("</Zip_Postal_Code>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Phone>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.Phone.Value)).Append("</Phone>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Fax>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.Fax.Value)).Append("</Fax>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<WebsiteUrl>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.WebsiteUrl.Value)).Append("</WebsiteUrl>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Email>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.Email.Value)).Append("</Email>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Fixed_Payment_ATTN>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.Fixed_Payment_ATTN.Value)).Append("</Fixed_Payment_ATTN>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Type>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.Type.Value)).Append("</Type>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Depositary>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.Depositary.Value)).Append("</Depositary>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<RejectEmail>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.RejectEmail.Value)).Append("</RejectEmail>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<PaymentEmail>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.PaymentEmail.Value)).Append("</PaymentEmail>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<DocInventoryEmail>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.DocInventoryEmail.Value)).Append("</DocInventoryEmail>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<SecurityTypeID>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.SecurityTypeID.Value)).Append("</SecurityTypeID>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<AccountNumber>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.AccountNumber.Value)).Append("</AccountNumber>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<IssuerCSD>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.IssuerCSD.Value)).Append("</IssuerCSD>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<ACH_Override>").Append(this.ACH_Override.Value).Append("</ACH_Override>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<ACH_Bank>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.ACH_Bank.Value)).Append("</ACH_Bank>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<ACH_ABA>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.ACH_ABA.Value)).Append("</ACH_ABA>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<ACH_Account>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.ACH_Account.Value)).Append("</ACH_Account>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<ClearingSystem>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.ClearingSystem.Value)).Append("</ClearingSystem>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<CustomWireMemo>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.CustomWireMemo.Value)).Append("</CustomWireMemo>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<ModifiedDateTime>").Append(this.ModifiedDateTime.Value).Append("</ModifiedDateTime>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Email_backup>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.Email_backup.Value)).Append("</Email_backup>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<PaymentEmail_backup>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.PaymentEmail_backup.Value)).Append("</PaymentEmail_backup>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<RejectEmail_backup>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.RejectEmail_backup.Value)).Append("</RejectEmail_backup>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<DocInventoryEmail_backup>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.DocInventoryEmail_backup.Value)).Append("</DocInventoryEmail_backup>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("</DTC_Participants>").Append(HssUtility.General.HssStr.WinNextLine);
            return sb.ToString();
        }
        /*^^^^^^^^^^^^^^^^^^^^^^^^^^^^^Hss Entity Framework Auto Generated Code^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^*/
    }
}
