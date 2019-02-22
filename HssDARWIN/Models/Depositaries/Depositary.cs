using System.Collections.Generic;

namespace HssDARWIN.Models.Depositaries
{
    public class Depositary
    {
        public const string Unsponsored = "UNSPONSORED";

        /*-----------------------------Hss Entity Framework Auto Generated Code-------------------------------*/
        private static HssUtility.SQLserver.CmdTemplate DBcmd_TP = null;
        public static HssUtility.SQLserver.CmdTemplate Get_cmdTP()
        {
            if (Depositary.DBcmd_TP != null) return Depositary.DBcmd_TP;

            Depositary.DBcmd_TP = new HssUtility.SQLserver.CmdTemplate();
            Depositary.DBcmd_TP.tableName = "Depositaries";
            Depositary.DBcmd_TP.schema = "dbo";

            Depositary.DBcmd_TP.AddColumn("ID");
            Depositary.DBcmd_TP.AddColumn("DepositaryID");
            Depositary.DBcmd_TP.AddColumn("DepositaryName");
            Depositary.DBcmd_TP.AddColumn("DepositaryDisplayName");/*Optional 4*/
            Depositary.DBcmd_TP.AddColumn("DepositaryShortName");/*Optional 5*/
            Depositary.DBcmd_TP.AddColumn("DepositaryIndex");/*Optional 6*/
            Depositary.DBcmd_TP.AddColumn("Depositary_Contact");/*Optional 7*/
            Depositary.DBcmd_TP.AddColumn("Depositary_Phone");/*Optional 8*/
            Depositary.DBcmd_TP.AddColumn("Depositary_Address1");/*Optional 9*/
            Depositary.DBcmd_TP.AddColumn("Depositary_Address2");/*Optional 10*/
            Depositary.DBcmd_TP.AddColumn("Depositary_City");/*Optional 11*/
            Depositary.DBcmd_TP.AddColumn("Depositary_State");/*Optional 12*/
            Depositary.DBcmd_TP.AddColumn("Active");/*Optional 13*/
            Depositary.DBcmd_TP.AddColumn("UniqueDepositaryIndex");/*Optional 14*/
            Depositary.DBcmd_TP.AddColumn("SecurityTypeID");/*Optional 15*/
            Depositary.DBcmd_TP.AddColumn("ESP_DepositaryName");/*Optional 16*/
            Depositary.DBcmd_TP.AddColumn("ESP_DepositaryAddress1");/*Optional 17*/
            Depositary.DBcmd_TP.AddColumn("ESP_DepositaryAddress2");/*Optional 18*/
            Depositary.DBcmd_TP.AddColumn("ESP_Phone");/*Optional 19*/
            Depositary.DBcmd_TP.AddColumn("ESP_Fax");/*Optional 20*/
            Depositary.DBcmd_TP.AddColumn("ESP_InternationalPhone");/*Optional 21*/
            Depositary.DBcmd_TP.AddColumn("ESP_DepositaryFullName");/*Optional 22*/
            Depositary.DBcmd_TP.AddColumn("ESP_Idemnification");/*Optional 23*/
            Depositary.DBcmd_TP.AddColumn("ESP_Idemnification2");/*Optional 24*/
            Depositary.DBcmd_TP.AddColumn("ESP_Idemnification_DI");/*Optional 25*/
            Depositary.DBcmd_TP.AddColumn("ESP_Idemnification2_DI");/*Optional 26*/
            Depositary.DBcmd_TP.AddColumn("ESP_DepositaryAccount");/*Optional 27*/
            Depositary.DBcmd_TP.AddColumn("ESP_DepositaryIBANCode");/*Optional 28*/
            Depositary.DBcmd_TP.AddColumn("ESP_DepositaryBIC");/*Optional 29*/
            Depositary.DBcmd_TP.AddColumn("ESP_DepositaryBank");/*Optional 30*/
            Depositary.DBcmd_TP.AddColumn("Nominee");/*Optional 31*/
            Depositary.DBcmd_TP.AddColumn("Nominee_Address");/*Optional 32*/
            Depositary.DBcmd_TP.AddColumn("ESP_Idemnification_RUSSIA");/*Optional 33*/
            Depositary.DBcmd_TP.AddColumn("ActiveFirstFiler");/*Optional 34*/
            Depositary.DBcmd_TP.AddColumn("PaymentInvoiceCurrency");
            Depositary.DBcmd_TP.AddColumn("ClearingSystem");/*Optional 36*/
            Depositary.DBcmd_TP.AddColumn("ACH_Enabled");/*Optional 37*/
            Depositary.DBcmd_TP.AddColumn("Originated_ACH_Company_ID");/*Optional 38*/
            Depositary.DBcmd_TP.AddColumn("Originated_Account_Number");/*Optional 39*/
            Depositary.DBcmd_TP.AddColumn("ACH_ModifiedBy");/*Optional 40*/
            Depositary.DBcmd_TP.AddColumn("ACH_ModifiedDateTime");/*Optional 41*/
            Depositary.DBcmd_TP.AddColumn("ModifiedDateTime");/*Optional 42*/
            Depositary.DBcmd_TP.AddColumn("Unique_DepositaryName");/*Optional 43*/

            return Depositary.DBcmd_TP;
        }

        public Depositary() { }
        public Depositary(int id) { this.pk_ID = id; }

        private int pk_ID = -1; //primary key
        public int ID { get { return this.pk_ID; } }

        public readonly HssUtility.General.Attributes.String_attr DepositaryID = new HssUtility.General.Attributes.String_attr("");
        public readonly HssUtility.General.Attributes.String_attr DepositaryName = new HssUtility.General.Attributes.String_attr("");
        public readonly HssUtility.General.Attributes.String_attr DepositaryDisplayName = new HssUtility.General.Attributes.String_attr("");/*Optional 4*/
        public readonly HssUtility.General.Attributes.String_attr DepositaryShortName = new HssUtility.General.Attributes.String_attr("");/*Optional 5*/
        public readonly HssUtility.General.Attributes.Int_attr DepositaryIndex = new HssUtility.General.Attributes.Int_attr(-1);/*Optional 6*/
        public readonly HssUtility.General.Attributes.String_attr Depositary_Contact = new HssUtility.General.Attributes.String_attr("");/*Optional 7*/
        public readonly HssUtility.General.Attributes.String_attr Depositary_Phone = new HssUtility.General.Attributes.String_attr("");/*Optional 8*/
        public readonly HssUtility.General.Attributes.String_attr Depositary_Address1 = new HssUtility.General.Attributes.String_attr("");/*Optional 9*/
        public readonly HssUtility.General.Attributes.String_attr Depositary_Address2 = new HssUtility.General.Attributes.String_attr("");/*Optional 10*/
        public readonly HssUtility.General.Attributes.String_attr Depositary_City = new HssUtility.General.Attributes.String_attr("");/*Optional 11*/
        public readonly HssUtility.General.Attributes.String_attr Depositary_State = new HssUtility.General.Attributes.String_attr("");/*Optional 12*/
        public readonly HssUtility.General.Attributes.Bool_attr Active = new HssUtility.General.Attributes.Bool_attr(false);/*Optional 13*/
        public readonly HssUtility.General.Attributes.String_attr UniqueDepositaryIndex = new HssUtility.General.Attributes.String_attr("");/*Optional 14*/
        public readonly HssUtility.General.Attributes.Int_attr SecurityTypeID = new HssUtility.General.Attributes.Int_attr(-1);/*Optional 15*/
        public readonly HssUtility.General.Attributes.String_attr ESP_DepositaryName = new HssUtility.General.Attributes.String_attr("");/*Optional 16*/
        public readonly HssUtility.General.Attributes.String_attr ESP_DepositaryAddress1 = new HssUtility.General.Attributes.String_attr("");/*Optional 17*/
        public readonly HssUtility.General.Attributes.String_attr ESP_DepositaryAddress2 = new HssUtility.General.Attributes.String_attr("");/*Optional 18*/
        public readonly HssUtility.General.Attributes.String_attr ESP_Phone = new HssUtility.General.Attributes.String_attr("");/*Optional 19*/
        public readonly HssUtility.General.Attributes.String_attr ESP_Fax = new HssUtility.General.Attributes.String_attr("");/*Optional 20*/
        public readonly HssUtility.General.Attributes.String_attr ESP_InternationalPhone = new HssUtility.General.Attributes.String_attr("");/*Optional 21*/
        public readonly HssUtility.General.Attributes.String_attr ESP_DepositaryFullName = new HssUtility.General.Attributes.String_attr("");/*Optional 22*/
        public readonly HssUtility.General.Attributes.String_attr ESP_Idemnification = new HssUtility.General.Attributes.String_attr("");/*Optional 23*/
        public readonly HssUtility.General.Attributes.String_attr ESP_Idemnification2 = new HssUtility.General.Attributes.String_attr("");/*Optional 24*/
        public readonly HssUtility.General.Attributes.String_attr ESP_Idemnification_DI = new HssUtility.General.Attributes.String_attr("");/*Optional 25*/
        public readonly HssUtility.General.Attributes.String_attr ESP_Idemnification2_DI = new HssUtility.General.Attributes.String_attr("");/*Optional 26*/
        public readonly HssUtility.General.Attributes.String_attr ESP_DepositaryAccount = new HssUtility.General.Attributes.String_attr("");/*Optional 27*/
        public readonly HssUtility.General.Attributes.String_attr ESP_DepositaryIBANCode = new HssUtility.General.Attributes.String_attr("");/*Optional 28*/
        public readonly HssUtility.General.Attributes.String_attr ESP_DepositaryBIC = new HssUtility.General.Attributes.String_attr("");/*Optional 29*/
        public readonly HssUtility.General.Attributes.String_attr ESP_DepositaryBank = new HssUtility.General.Attributes.String_attr("");/*Optional 30*/
        public readonly HssUtility.General.Attributes.String_attr Nominee = new HssUtility.General.Attributes.String_attr("");/*Optional 31*/
        public readonly HssUtility.General.Attributes.String_attr Nominee_Address = new HssUtility.General.Attributes.String_attr("");/*Optional 32*/
        public readonly HssUtility.General.Attributes.String_attr ESP_Idemnification_RUSSIA = new HssUtility.General.Attributes.String_attr("");/*Optional 33*/
        public readonly HssUtility.General.Attributes.Bool_attr ActiveFirstFiler = new HssUtility.General.Attributes.Bool_attr(false);/*Optional 34*/
        public readonly HssUtility.General.Attributes.String_attr PaymentInvoiceCurrency = new HssUtility.General.Attributes.String_attr("");
        public readonly HssUtility.General.Attributes.String_attr ClearingSystem = new HssUtility.General.Attributes.String_attr("");/*Optional 36*/
        public readonly HssUtility.General.Attributes.Bool_attr ACH_Enabled = new HssUtility.General.Attributes.Bool_attr(false);/*Optional 37*/
        public readonly HssUtility.General.Attributes.String_attr Originated_ACH_Company_ID = new HssUtility.General.Attributes.String_attr("");/*Optional 38*/
        public readonly HssUtility.General.Attributes.String_attr Originated_Account_Number = new HssUtility.General.Attributes.String_attr("");/*Optional 39*/
        public readonly HssUtility.General.Attributes.String_attr ACH_ModifiedBy = new HssUtility.General.Attributes.String_attr("");/*Optional 40*/
        public readonly HssUtility.General.Attributes.DateTime_attr ACH_ModifiedDateTime = new HssUtility.General.Attributes.DateTime_attr(Utility.MinDate);/*Optional 41*/
        public readonly HssUtility.General.Attributes.DateTime_attr ModifiedDateTime = new HssUtility.General.Attributes.DateTime_attr(Utility.MinDate);/*Optional 42*/
        public readonly HssUtility.General.Attributes.String_attr Unique_DepositaryName = new HssUtility.General.Attributes.String_attr("");/*Optional 43*/

        private List<HssUtility.General.Attributes.I_modelAttr> attrList = null;

        internal void Init_from_reader(HssUtility.SQLserver.DB_reader reader)
        {
            if (reader == null || reader.IsClosed) return;

            this.pk_ID = reader.GetInt("ID");
            this.DepositaryID.Value = reader.GetString("DepositaryID");
            this.DepositaryName.Value = reader.GetString("DepositaryName");
            this.DepositaryDisplayName.Value = reader.GetString("DepositaryDisplayName");/*Optional 4*/
            this.DepositaryShortName.Value = reader.GetString("DepositaryShortName");/*Optional 5*/
            this.DepositaryIndex.Value = reader.GetInt("DepositaryIndex");/*Optional 6*/
            this.Depositary_Contact.Value = reader.GetString("Depositary_Contact");/*Optional 7*/
            this.Depositary_Phone.Value = reader.GetString("Depositary_Phone");/*Optional 8*/
            this.Depositary_Address1.Value = reader.GetString("Depositary_Address1");/*Optional 9*/
            this.Depositary_Address2.Value = reader.GetString("Depositary_Address2");/*Optional 10*/
            this.Depositary_City.Value = reader.GetString("Depositary_City");/*Optional 11*/
            this.Depositary_State.Value = reader.GetString("Depositary_State");/*Optional 12*/
            this.Active.Value = reader.GetBool("Active");/*Optional 13*/
            this.UniqueDepositaryIndex.Value = reader.GetString("UniqueDepositaryIndex");/*Optional 14*/
            this.SecurityTypeID.Value = reader.GetInt("SecurityTypeID");/*Optional 15*/
            this.ESP_DepositaryName.Value = reader.GetString("ESP_DepositaryName");/*Optional 16*/
            this.ESP_DepositaryAddress1.Value = reader.GetString("ESP_DepositaryAddress1");/*Optional 17*/
            this.ESP_DepositaryAddress2.Value = reader.GetString("ESP_DepositaryAddress2");/*Optional 18*/
            this.ESP_Phone.Value = reader.GetString("ESP_Phone");/*Optional 19*/
            this.ESP_Fax.Value = reader.GetString("ESP_Fax");/*Optional 20*/
            this.ESP_InternationalPhone.Value = reader.GetString("ESP_InternationalPhone");/*Optional 21*/
            this.ESP_DepositaryFullName.Value = reader.GetString("ESP_DepositaryFullName");/*Optional 22*/
            this.ESP_Idemnification.Value = reader.GetString("ESP_Idemnification");/*Optional 23*/
            this.ESP_Idemnification2.Value = reader.GetString("ESP_Idemnification2");/*Optional 24*/
            this.ESP_Idemnification_DI.Value = reader.GetString("ESP_Idemnification_DI");/*Optional 25*/
            this.ESP_Idemnification2_DI.Value = reader.GetString("ESP_Idemnification2_DI");/*Optional 26*/
            this.ESP_DepositaryAccount.Value = reader.GetString("ESP_DepositaryAccount");/*Optional 27*/
            this.ESP_DepositaryIBANCode.Value = reader.GetString("ESP_DepositaryIBANCode");/*Optional 28*/
            this.ESP_DepositaryBIC.Value = reader.GetString("ESP_DepositaryBIC");/*Optional 29*/
            this.ESP_DepositaryBank.Value = reader.GetString("ESP_DepositaryBank");/*Optional 30*/
            this.Nominee.Value = reader.GetString("Nominee");/*Optional 31*/
            this.Nominee_Address.Value = reader.GetString("Nominee_Address");/*Optional 32*/
            this.ESP_Idemnification_RUSSIA.Value = reader.GetString("ESP_Idemnification_RUSSIA");/*Optional 33*/
            this.ActiveFirstFiler.Value = reader.GetBool("ActiveFirstFiler");/*Optional 34*/
            this.PaymentInvoiceCurrency.Value = reader.GetString("PaymentInvoiceCurrency");
            this.ClearingSystem.Value = reader.GetString("ClearingSystem");/*Optional 36*/
            this.ACH_Enabled.Value = reader.GetBool("ACH_Enabled");/*Optional 37*/
            this.Originated_ACH_Company_ID.Value = reader.GetString("Originated_ACH_Company_ID");/*Optional 38*/
            this.Originated_Account_Number.Value = reader.GetString("Originated_Account_Number");/*Optional 39*/
            this.ACH_ModifiedBy.Value = reader.GetString("ACH_ModifiedBy");/*Optional 40*/
            this.ACH_ModifiedDateTime.Value = reader.GetDateTime("ACH_ModifiedDateTime", Utility.MinDate);/*Optional 41*/
            this.ModifiedDateTime.Value = reader.GetDateTime("ModifiedDateTime", Utility.MinDate);/*Optional 42*/
            this.Unique_DepositaryName.Value = reader.GetString("Unique_DepositaryName");/*Optional 43*/

            this.SyncWithDB();
        }

        public bool Init_from_DB()
        {
            if (this.ID < 0) return false;

            HssUtility.SQLserver.DB_select db_sel = new HssUtility.SQLserver.DB_select(Depositary.Get_cmdTP());
            db_sel.tableName = "Depositaries";
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
            this.attrList.Add(this.DepositaryID);
            this.attrList.Add(this.DepositaryName);
            this.attrList.Add(this.DepositaryDisplayName);/*Optional 4*/
            this.attrList.Add(this.DepositaryShortName);/*Optional 5*/
            this.attrList.Add(this.DepositaryIndex);/*Optional 6*/
            this.attrList.Add(this.Depositary_Contact);/*Optional 7*/
            this.attrList.Add(this.Depositary_Phone);/*Optional 8*/
            this.attrList.Add(this.Depositary_Address1);/*Optional 9*/
            this.attrList.Add(this.Depositary_Address2);/*Optional 10*/
            this.attrList.Add(this.Depositary_City);/*Optional 11*/
            this.attrList.Add(this.Depositary_State);/*Optional 12*/
            this.attrList.Add(this.Active);/*Optional 13*/
            this.attrList.Add(this.UniqueDepositaryIndex);/*Optional 14*/
            this.attrList.Add(this.SecurityTypeID);/*Optional 15*/
            this.attrList.Add(this.ESP_DepositaryName);/*Optional 16*/
            this.attrList.Add(this.ESP_DepositaryAddress1);/*Optional 17*/
            this.attrList.Add(this.ESP_DepositaryAddress2);/*Optional 18*/
            this.attrList.Add(this.ESP_Phone);/*Optional 19*/
            this.attrList.Add(this.ESP_Fax);/*Optional 20*/
            this.attrList.Add(this.ESP_InternationalPhone);/*Optional 21*/
            this.attrList.Add(this.ESP_DepositaryFullName);/*Optional 22*/
            this.attrList.Add(this.ESP_Idemnification);/*Optional 23*/
            this.attrList.Add(this.ESP_Idemnification2);/*Optional 24*/
            this.attrList.Add(this.ESP_Idemnification_DI);/*Optional 25*/
            this.attrList.Add(this.ESP_Idemnification2_DI);/*Optional 26*/
            this.attrList.Add(this.ESP_DepositaryAccount);/*Optional 27*/
            this.attrList.Add(this.ESP_DepositaryIBANCode);/*Optional 28*/
            this.attrList.Add(this.ESP_DepositaryBIC);/*Optional 29*/
            this.attrList.Add(this.ESP_DepositaryBank);/*Optional 30*/
            this.attrList.Add(this.Nominee);/*Optional 31*/
            this.attrList.Add(this.Nominee_Address);/*Optional 32*/
            this.attrList.Add(this.ESP_Idemnification_RUSSIA);/*Optional 33*/
            this.attrList.Add(this.ActiveFirstFiler);/*Optional 34*/
            this.attrList.Add(this.PaymentInvoiceCurrency);
            this.attrList.Add(this.ClearingSystem);/*Optional 36*/
            this.attrList.Add(this.ACH_Enabled);/*Optional 37*/
            this.attrList.Add(this.Originated_ACH_Company_ID);/*Optional 38*/
            this.attrList.Add(this.Originated_Account_Number);/*Optional 39*/
            this.attrList.Add(this.ACH_ModifiedBy);/*Optional 40*/
            this.attrList.Add(this.ACH_ModifiedDateTime);/*Optional 41*/
            this.attrList.Add(this.ModifiedDateTime);/*Optional 42*/
            this.attrList.Add(this.Unique_DepositaryName);/*Optional 43*/
        }

        public bool Insert_to_DB()
        {
            HssUtility.SQLserver.DB_insert ins = this.Get_DBinsert();
            int count = ins.SaveToDB(Utility.Get_DRWIN_hDB());
            return count > 0;
        }

        internal HssUtility.SQLserver.DB_insert Get_DBinsert()
        {
            HssUtility.SQLserver.DB_insert dbIns = new HssUtility.SQLserver.DB_insert(Depositary.Get_cmdTP());
            dbIns.AddValue("DepositaryID", this.DepositaryID.Value);
            dbIns.AddValue("DepositaryName", this.DepositaryName.Value);
            dbIns.AddValue("DepositaryDisplayName", this.DepositaryDisplayName.Value);/*Optional 4*/
            dbIns.AddValue("DepositaryShortName", this.DepositaryShortName.Value);/*Optional 5*/
            dbIns.AddValue("DepositaryIndex", this.DepositaryIndex.Value);/*Optional 6*/
            dbIns.AddValue("Depositary_Contact", this.Depositary_Contact.Value);/*Optional 7*/
            dbIns.AddValue("Depositary_Phone", this.Depositary_Phone.Value);/*Optional 8*/
            dbIns.AddValue("Depositary_Address1", this.Depositary_Address1.Value);/*Optional 9*/
            dbIns.AddValue("Depositary_Address2", this.Depositary_Address2.Value);/*Optional 10*/
            dbIns.AddValue("Depositary_City", this.Depositary_City.Value);/*Optional 11*/
            dbIns.AddValue("Depositary_State", this.Depositary_State.Value);/*Optional 12*/
            dbIns.AddValue("Active", this.Active.Value);/*Optional 13*/
            dbIns.AddValue("UniqueDepositaryIndex", this.UniqueDepositaryIndex.Value);/*Optional 14*/
            dbIns.AddValue("SecurityTypeID", this.SecurityTypeID.Value);/*Optional 15*/
            dbIns.AddValue("ESP_DepositaryName", this.ESP_DepositaryName.Value);/*Optional 16*/
            dbIns.AddValue("ESP_DepositaryAddress1", this.ESP_DepositaryAddress1.Value);/*Optional 17*/
            dbIns.AddValue("ESP_DepositaryAddress2", this.ESP_DepositaryAddress2.Value);/*Optional 18*/
            dbIns.AddValue("ESP_Phone", this.ESP_Phone.Value);/*Optional 19*/
            dbIns.AddValue("ESP_Fax", this.ESP_Fax.Value);/*Optional 20*/
            dbIns.AddValue("ESP_InternationalPhone", this.ESP_InternationalPhone.Value);/*Optional 21*/
            dbIns.AddValue("ESP_DepositaryFullName", this.ESP_DepositaryFullName.Value);/*Optional 22*/
            dbIns.AddValue("ESP_Idemnification", this.ESP_Idemnification.Value);/*Optional 23*/
            dbIns.AddValue("ESP_Idemnification2", this.ESP_Idemnification2.Value);/*Optional 24*/
            dbIns.AddValue("ESP_Idemnification_DI", this.ESP_Idemnification_DI.Value);/*Optional 25*/
            dbIns.AddValue("ESP_Idemnification2_DI", this.ESP_Idemnification2_DI.Value);/*Optional 26*/
            dbIns.AddValue("ESP_DepositaryAccount", this.ESP_DepositaryAccount.Value);/*Optional 27*/
            dbIns.AddValue("ESP_DepositaryIBANCode", this.ESP_DepositaryIBANCode.Value);/*Optional 28*/
            dbIns.AddValue("ESP_DepositaryBIC", this.ESP_DepositaryBIC.Value);/*Optional 29*/
            dbIns.AddValue("ESP_DepositaryBank", this.ESP_DepositaryBank.Value);/*Optional 30*/
            dbIns.AddValue("Nominee", this.Nominee.Value);/*Optional 31*/
            dbIns.AddValue("Nominee_Address", this.Nominee_Address.Value);/*Optional 32*/
            dbIns.AddValue("ESP_Idemnification_RUSSIA", this.ESP_Idemnification_RUSSIA.Value);/*Optional 33*/
            dbIns.AddValue("ActiveFirstFiler", this.ActiveFirstFiler.Value);/*Optional 34*/
            dbIns.AddValue("PaymentInvoiceCurrency", this.PaymentInvoiceCurrency.Value);
            dbIns.AddValue("ClearingSystem", this.ClearingSystem.Value);/*Optional 36*/
            dbIns.AddValue("ACH_Enabled", this.ACH_Enabled.Value);/*Optional 37*/
            dbIns.AddValue("Originated_ACH_Company_ID", this.Originated_ACH_Company_ID.Value);/*Optional 38*/
            dbIns.AddValue("Originated_Account_Number", this.Originated_Account_Number.Value);/*Optional 39*/
            dbIns.AddValue("ACH_ModifiedBy", this.ACH_ModifiedBy.Value);/*Optional 40*/
            dbIns.AddValue("ACH_ModifiedDateTime", this.ACH_ModifiedDateTime.Value);/*Optional 41*/
            dbIns.AddValue("ModifiedDateTime", this.ModifiedDateTime.Value);/*Optional 42*/
            dbIns.AddValue("Unique_DepositaryName", this.Unique_DepositaryName.Value);/*Optional 43*/
            return dbIns;
        }

        /*^^^^^^^^^^^^^^^^^^^^^^^^^^^^^Hss Entity Framework Auto Generated Code^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^*/
    }
}
