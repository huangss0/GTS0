using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HssDARWIN.Models.Custodians
{
    public class Custodian
    {
        /*-----------------------------Hss Entity Framework Auto Generated Code-------------------------------*/
        private static HssUtility.SQLserver.CmdTemplate DBcmd_TP = null;
        public static HssUtility.SQLserver.CmdTemplate Get_cmdTP()
        {
            if (Custodian.DBcmd_TP != null) return Custodian.DBcmd_TP;

            Custodian.DBcmd_TP = new HssUtility.SQLserver.CmdTemplate();
            Custodian.DBcmd_TP.tableName = "Custodians";
            Custodian.DBcmd_TP.schema = "dbo";

            Custodian.DBcmd_TP.AddColumn("Custodian_Number");
            Custodian.DBcmd_TP.AddColumn("Custodian_ShortName");
            Custodian.DBcmd_TP.AddColumn("Custodian_FullName");
            Custodian.DBcmd_TP.AddColumn("Account_Number");/*Optional 4*/
            Custodian.DBcmd_TP.AddColumn("Safekeeping_Number");/*Optional 5*/
            Custodian.DBcmd_TP.AddColumn("Language");/*Optional 6*/
            Custodian.DBcmd_TP.AddColumn("Country_Code");/*Optional 7*/
            Custodian.DBcmd_TP.AddColumn("Title");/*Optional 8*/
            Custodian.DBcmd_TP.AddColumn("From_FirstName");/*Optional 9*/
            Custodian.DBcmd_TP.AddColumn("From_LastName");/*Optional 10*/
            Custodian.DBcmd_TP.AddColumn("From_Company");/*Optional 11*/
            Custodian.DBcmd_TP.AddColumn("From_Address1");/*Optional 12*/
            Custodian.DBcmd_TP.AddColumn("From_Address2");/*Optional 13*/
            Custodian.DBcmd_TP.AddColumn("From_Address3");/*Optional 14*/
            Custodian.DBcmd_TP.AddColumn("From_Address4");/*Optional 15*/
            Custodian.DBcmd_TP.AddColumn("From_Address5");/*Optional 16*/
            Custodian.DBcmd_TP.AddColumn("Telephone");/*Optional 17*/
            Custodian.DBcmd_TP.AddColumn("Fax");/*Optional 18*/
            Custodian.DBcmd_TP.AddColumn("DefaultCustodianType");/*Optional 19*/
            Custodian.DBcmd_TP.AddColumn("PrimaryAllowed");/*Optional 20*/
            Custodian.DBcmd_TP.AddColumn("Tax_Authority");/*Optional 21*/
            Custodian.DBcmd_TP.AddColumn("TA_ATTN");/*Optional 22*/
            Custodian.DBcmd_TP.AddColumn("TA_Address1");/*Optional 23*/
            Custodian.DBcmd_TP.AddColumn("TA_Address2");/*Optional 24*/
            Custodian.DBcmd_TP.AddColumn("Custodian_Alias");/*Optional 25*/
            Custodian.DBcmd_TP.AddColumn("TA_Phone");/*Optional 26*/
            Custodian.DBcmd_TP.AddColumn("TA_FAX");/*Optional 27*/
            Custodian.DBcmd_TP.AddColumn("Custodian_Ref_Number");/*Optional 28*/
            Custodian.DBcmd_TP.AddColumn("JPM_Custodian_Ref_Num");/*Optional 29*/

            return Custodian.DBcmd_TP;
        }

        public Custodian() { }
        public Custodian(int id) { this.pk_ID = id; }

        private int pk_ID = -1; //primary key
        public int Custodian_Number { get { return this.pk_ID; } }

        public readonly HssUtility.General.Attributes.String_attr Custodian_ShortName = new HssUtility.General.Attributes.String_attr();
        public readonly HssUtility.General.Attributes.String_attr Custodian_FullName = new HssUtility.General.Attributes.String_attr();
        public readonly HssUtility.General.Attributes.String_attr Account_Number = new HssUtility.General.Attributes.String_attr();/*Optional 4*/
        public readonly HssUtility.General.Attributes.String_attr Safekeeping_Number = new HssUtility.General.Attributes.String_attr();/*Optional 5*/
        public readonly HssUtility.General.Attributes.String_attr Language = new HssUtility.General.Attributes.String_attr();/*Optional 6*/
        public readonly HssUtility.General.Attributes.String_attr Country_Code = new HssUtility.General.Attributes.String_attr();/*Optional 7*/
        public readonly HssUtility.General.Attributes.String_attr Title = new HssUtility.General.Attributes.String_attr();/*Optional 8*/
        public readonly HssUtility.General.Attributes.String_attr From_FirstName = new HssUtility.General.Attributes.String_attr();/*Optional 9*/
        public readonly HssUtility.General.Attributes.String_attr From_LastName = new HssUtility.General.Attributes.String_attr();/*Optional 10*/
        public readonly HssUtility.General.Attributes.String_attr From_Company = new HssUtility.General.Attributes.String_attr();/*Optional 11*/
        public readonly HssUtility.General.Attributes.String_attr From_Address1 = new HssUtility.General.Attributes.String_attr();/*Optional 12*/
        public readonly HssUtility.General.Attributes.String_attr From_Address2 = new HssUtility.General.Attributes.String_attr();/*Optional 13*/
        public readonly HssUtility.General.Attributes.String_attr From_Address3 = new HssUtility.General.Attributes.String_attr();/*Optional 14*/
        public readonly HssUtility.General.Attributes.String_attr From_Address4 = new HssUtility.General.Attributes.String_attr();/*Optional 15*/
        public readonly HssUtility.General.Attributes.String_attr From_Address5 = new HssUtility.General.Attributes.String_attr();/*Optional 16*/
        public readonly HssUtility.General.Attributes.String_attr Telephone = new HssUtility.General.Attributes.String_attr();/*Optional 17*/
        public readonly HssUtility.General.Attributes.String_attr Fax = new HssUtility.General.Attributes.String_attr();/*Optional 18*/
        public readonly HssUtility.General.Attributes.String_attr DefaultCustodianType = new HssUtility.General.Attributes.String_attr();/*Optional 19*/
        public readonly HssUtility.General.Attributes.Bool_attr PrimaryAllowed = new HssUtility.General.Attributes.Bool_attr();/*Optional 20*/
        public readonly HssUtility.General.Attributes.String_attr Tax_Authority = new HssUtility.General.Attributes.String_attr();/*Optional 21*/
        public readonly HssUtility.General.Attributes.String_attr TA_ATTN = new HssUtility.General.Attributes.String_attr();/*Optional 22*/
        public readonly HssUtility.General.Attributes.String_attr TA_Address1 = new HssUtility.General.Attributes.String_attr();/*Optional 23*/
        public readonly HssUtility.General.Attributes.String_attr TA_Address2 = new HssUtility.General.Attributes.String_attr();/*Optional 24*/
        public readonly HssUtility.General.Attributes.String_attr Custodian_Alias = new HssUtility.General.Attributes.String_attr();/*Optional 25*/
        public readonly HssUtility.General.Attributes.String_attr TA_Phone = new HssUtility.General.Attributes.String_attr();/*Optional 26*/
        public readonly HssUtility.General.Attributes.String_attr TA_FAX = new HssUtility.General.Attributes.String_attr();/*Optional 27*/
        public readonly HssUtility.General.Attributes.String_attr Custodian_Ref_Number = new HssUtility.General.Attributes.String_attr();/*Optional 28*/
        public readonly HssUtility.General.Attributes.String_attr JPM_Custodian_Ref_Num = new HssUtility.General.Attributes.String_attr();/*Optional 29*/

        private Dictionary<string, HssUtility.General.Attributes.I_modelAttr> attr_dic = null;

        internal void Init_from_reader(HssUtility.SQLserver.DB_reader reader)
        {
            if (reader == null || reader.IsClosed) return;

            this.pk_ID = reader.GetInt("Custodian_Number");
            reader.GetString("Custodian_ShortName", this.Custodian_ShortName);
            reader.GetString("Custodian_FullName", this.Custodian_FullName);
            reader.GetString("Account_Number", this.Account_Number);/*Optional 4*/
            reader.GetString("Safekeeping_Number", this.Safekeeping_Number);/*Optional 5*/
            reader.GetString("Language", this.Language);/*Optional 6*/
            reader.GetString("Country_Code", this.Country_Code);/*Optional 7*/
            reader.GetString("Title", this.Title);/*Optional 8*/
            reader.GetString("From_FirstName", this.From_FirstName);/*Optional 9*/
            reader.GetString("From_LastName", this.From_LastName);/*Optional 10*/
            reader.GetString("From_Company", this.From_Company);/*Optional 11*/
            reader.GetString("From_Address1", this.From_Address1);/*Optional 12*/
            reader.GetString("From_Address2", this.From_Address2);/*Optional 13*/
            reader.GetString("From_Address3", this.From_Address3);/*Optional 14*/
            reader.GetString("From_Address4", this.From_Address4);/*Optional 15*/
            reader.GetString("From_Address5", this.From_Address5);/*Optional 16*/
            reader.GetString("Telephone", this.Telephone);/*Optional 17*/
            reader.GetString("Fax", this.Fax);/*Optional 18*/
            reader.GetString("DefaultCustodianType", this.DefaultCustodianType);/*Optional 19*/
            reader.GetBool("PrimaryAllowed", this.PrimaryAllowed);/*Optional 20*/
            reader.GetString("Tax_Authority", this.Tax_Authority);/*Optional 21*/
            reader.GetString("TA_ATTN", this.TA_ATTN);/*Optional 22*/
            reader.GetString("TA_Address1", this.TA_Address1);/*Optional 23*/
            reader.GetString("TA_Address2", this.TA_Address2);/*Optional 24*/
            reader.GetString("Custodian_Alias", this.Custodian_Alias);/*Optional 25*/
            reader.GetString("TA_Phone", this.TA_Phone);/*Optional 26*/
            reader.GetString("TA_FAX", this.TA_FAX);/*Optional 27*/
            reader.GetString("Custodian_Ref_Number", this.Custodian_Ref_Number);/*Optional 28*/
            reader.GetString("JPM_Custodian_Ref_Num", this.JPM_Custodian_Ref_Num);/*Optional 29*/

            this.SyncWithDB();
        }

        /// <summary>
        /// Initialize object from DB
        /// </summary>
        public bool Init_from_DB()
        {
            if (this.Custodian_Number < 0) return false;

            HssUtility.SQLserver.DB_select db_sel = new HssUtility.SQLserver.DB_select(Custodian.Get_cmdTP());
            db_sel.tableName = "Custodians";
            HssUtility.SQLserver.SQL_relation rela = new HssUtility.SQLserver.SQL_relation("Custodian_Number", HssUtility.General.RelationalOperator.Equals, this.Custodian_Number);
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
            this.attr_dic.Add("Custodian_ShortName", this.Custodian_ShortName);
            this.attr_dic.Add("Custodian_FullName", this.Custodian_FullName);
            this.attr_dic.Add("Account_Number", this.Account_Number);/*Optional 4*/
            this.attr_dic.Add("Safekeeping_Number", this.Safekeeping_Number);/*Optional 5*/
            this.attr_dic.Add("Language", this.Language);/*Optional 6*/
            this.attr_dic.Add("Country_Code", this.Country_Code);/*Optional 7*/
            this.attr_dic.Add("Title", this.Title);/*Optional 8*/
            this.attr_dic.Add("From_FirstName", this.From_FirstName);/*Optional 9*/
            this.attr_dic.Add("From_LastName", this.From_LastName);/*Optional 10*/
            this.attr_dic.Add("From_Company", this.From_Company);/*Optional 11*/
            this.attr_dic.Add("From_Address1", this.From_Address1);/*Optional 12*/
            this.attr_dic.Add("From_Address2", this.From_Address2);/*Optional 13*/
            this.attr_dic.Add("From_Address3", this.From_Address3);/*Optional 14*/
            this.attr_dic.Add("From_Address4", this.From_Address4);/*Optional 15*/
            this.attr_dic.Add("From_Address5", this.From_Address5);/*Optional 16*/
            this.attr_dic.Add("Telephone", this.Telephone);/*Optional 17*/
            this.attr_dic.Add("Fax", this.Fax);/*Optional 18*/
            this.attr_dic.Add("DefaultCustodianType", this.DefaultCustodianType);/*Optional 19*/
            this.attr_dic.Add("PrimaryAllowed", this.PrimaryAllowed);/*Optional 20*/
            this.attr_dic.Add("Tax_Authority", this.Tax_Authority);/*Optional 21*/
            this.attr_dic.Add("TA_ATTN", this.TA_ATTN);/*Optional 22*/
            this.attr_dic.Add("TA_Address1", this.TA_Address1);/*Optional 23*/
            this.attr_dic.Add("TA_Address2", this.TA_Address2);/*Optional 24*/
            this.attr_dic.Add("Custodian_Alias", this.Custodian_Alias);/*Optional 25*/
            this.attr_dic.Add("TA_Phone", this.TA_Phone);/*Optional 26*/
            this.attr_dic.Add("TA_FAX", this.TA_FAX);/*Optional 27*/
            this.attr_dic.Add("Custodian_Ref_Number", this.Custodian_Ref_Number);/*Optional 28*/
            this.attr_dic.Add("JPM_Custodian_Ref_Num", this.JPM_Custodian_Ref_Num);/*Optional 29*/
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
            HssUtility.SQLserver.DB_insert dbIns = new HssUtility.SQLserver.DB_insert(Custodian.Get_cmdTP());

            dbIns.AddValue("Custodian_ShortName", this.Custodian_ShortName);
            dbIns.AddValue("Custodian_FullName", this.Custodian_FullName);
            dbIns.AddValue("Account_Number", this.Account_Number);/*Optional 4*/
            dbIns.AddValue("Safekeeping_Number", this.Safekeeping_Number);/*Optional 5*/
            dbIns.AddValue("Language", this.Language);/*Optional 6*/
            dbIns.AddValue("Country_Code", this.Country_Code);/*Optional 7*/
            dbIns.AddValue("Title", this.Title);/*Optional 8*/
            dbIns.AddValue("From_FirstName", this.From_FirstName);/*Optional 9*/
            dbIns.AddValue("From_LastName", this.From_LastName);/*Optional 10*/
            dbIns.AddValue("From_Company", this.From_Company);/*Optional 11*/
            dbIns.AddValue("From_Address1", this.From_Address1);/*Optional 12*/
            dbIns.AddValue("From_Address2", this.From_Address2);/*Optional 13*/
            dbIns.AddValue("From_Address3", this.From_Address3);/*Optional 14*/
            dbIns.AddValue("From_Address4", this.From_Address4);/*Optional 15*/
            dbIns.AddValue("From_Address5", this.From_Address5);/*Optional 16*/
            dbIns.AddValue("Telephone", this.Telephone);/*Optional 17*/
            dbIns.AddValue("Fax", this.Fax);/*Optional 18*/
            dbIns.AddValue("DefaultCustodianType", this.DefaultCustodianType);/*Optional 19*/
            dbIns.AddValue("PrimaryAllowed", this.PrimaryAllowed);/*Optional 20*/
            dbIns.AddValue("Tax_Authority", this.Tax_Authority);/*Optional 21*/
            dbIns.AddValue("TA_ATTN", this.TA_ATTN);/*Optional 22*/
            dbIns.AddValue("TA_Address1", this.TA_Address1);/*Optional 23*/
            dbIns.AddValue("TA_Address2", this.TA_Address2);/*Optional 24*/
            dbIns.AddValue("Custodian_Alias", this.Custodian_Alias);/*Optional 25*/
            dbIns.AddValue("TA_Phone", this.TA_Phone);/*Optional 26*/
            dbIns.AddValue("TA_FAX", this.TA_FAX);/*Optional 27*/
            dbIns.AddValue("Custodian_Ref_Number", this.Custodian_Ref_Number);/*Optional 28*/
            dbIns.AddValue("JPM_Custodian_Ref_Num", this.JPM_Custodian_Ref_Num);/*Optional 29*/

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

            HssUtility.SQLserver.DB_update upd = new HssUtility.SQLserver.DB_update(Custodian.Get_cmdTP());
            if (this.Custodian_ShortName.ValueChanged) upd.AddValue("Custodian_ShortName", this.Custodian_ShortName);
            if (this.Custodian_FullName.ValueChanged) upd.AddValue("Custodian_FullName", this.Custodian_FullName);
            if (this.Account_Number.ValueChanged) upd.AddValue("Account_Number", this.Account_Number);/*Optional 4*/
            if (this.Safekeeping_Number.ValueChanged) upd.AddValue("Safekeeping_Number", this.Safekeeping_Number);/*Optional 5*/
            if (this.Language.ValueChanged) upd.AddValue("Language", this.Language);/*Optional 6*/
            if (this.Country_Code.ValueChanged) upd.AddValue("Country_Code", this.Country_Code);/*Optional 7*/
            if (this.Title.ValueChanged) upd.AddValue("Title", this.Title);/*Optional 8*/
            if (this.From_FirstName.ValueChanged) upd.AddValue("From_FirstName", this.From_FirstName);/*Optional 9*/
            if (this.From_LastName.ValueChanged) upd.AddValue("From_LastName", this.From_LastName);/*Optional 10*/
            if (this.From_Company.ValueChanged) upd.AddValue("From_Company", this.From_Company);/*Optional 11*/
            if (this.From_Address1.ValueChanged) upd.AddValue("From_Address1", this.From_Address1);/*Optional 12*/
            if (this.From_Address2.ValueChanged) upd.AddValue("From_Address2", this.From_Address2);/*Optional 13*/
            if (this.From_Address3.ValueChanged) upd.AddValue("From_Address3", this.From_Address3);/*Optional 14*/
            if (this.From_Address4.ValueChanged) upd.AddValue("From_Address4", this.From_Address4);/*Optional 15*/
            if (this.From_Address5.ValueChanged) upd.AddValue("From_Address5", this.From_Address5);/*Optional 16*/
            if (this.Telephone.ValueChanged) upd.AddValue("Telephone", this.Telephone);/*Optional 17*/
            if (this.Fax.ValueChanged) upd.AddValue("Fax", this.Fax);/*Optional 18*/
            if (this.DefaultCustodianType.ValueChanged) upd.AddValue("DefaultCustodianType", this.DefaultCustodianType);/*Optional 19*/
            if (this.PrimaryAllowed.ValueChanged) upd.AddValue("PrimaryAllowed", this.PrimaryAllowed);/*Optional 20*/
            if (this.Tax_Authority.ValueChanged) upd.AddValue("Tax_Authority", this.Tax_Authority);/*Optional 21*/
            if (this.TA_ATTN.ValueChanged) upd.AddValue("TA_ATTN", this.TA_ATTN);/*Optional 22*/
            if (this.TA_Address1.ValueChanged) upd.AddValue("TA_Address1", this.TA_Address1);/*Optional 23*/
            if (this.TA_Address2.ValueChanged) upd.AddValue("TA_Address2", this.TA_Address2);/*Optional 24*/
            if (this.Custodian_Alias.ValueChanged) upd.AddValue("Custodian_Alias", this.Custodian_Alias);/*Optional 25*/
            if (this.TA_Phone.ValueChanged) upd.AddValue("TA_Phone", this.TA_Phone);/*Optional 26*/
            if (this.TA_FAX.ValueChanged) upd.AddValue("TA_FAX", this.TA_FAX);/*Optional 27*/
            if (this.Custodian_Ref_Number.ValueChanged) upd.AddValue("Custodian_Ref_Number", this.Custodian_Ref_Number);/*Optional 28*/
            if (this.JPM_Custodian_Ref_Num.ValueChanged) upd.AddValue("JPM_Custodian_Ref_Num", this.JPM_Custodian_Ref_Num);/*Optional 29*/

            HssUtility.SQLserver.SQL_relation rela = new HssUtility.SQLserver.SQL_relation("Custodian_Number", HssUtility.General.RelationalOperator.Equals, this.pk_ID);
            upd.SetCondition(rela);

            return upd;
        }

        public Custodian GetCopy()
        {
            Custodian newEntity = new Custodian();
            if (!this.Custodian_ShortName.IsNull_flag) newEntity.Custodian_ShortName.Value = this.Custodian_ShortName.Value;
            if (!this.Custodian_FullName.IsNull_flag) newEntity.Custodian_FullName.Value = this.Custodian_FullName.Value;
            if (!this.Account_Number.IsNull_flag) newEntity.Account_Number.Value = this.Account_Number.Value;
            if (!this.Safekeeping_Number.IsNull_flag) newEntity.Safekeeping_Number.Value = this.Safekeeping_Number.Value;
            if (!this.Language.IsNull_flag) newEntity.Language.Value = this.Language.Value;
            if (!this.Country_Code.IsNull_flag) newEntity.Country_Code.Value = this.Country_Code.Value;
            if (!this.Title.IsNull_flag) newEntity.Title.Value = this.Title.Value;
            if (!this.From_FirstName.IsNull_flag) newEntity.From_FirstName.Value = this.From_FirstName.Value;
            if (!this.From_LastName.IsNull_flag) newEntity.From_LastName.Value = this.From_LastName.Value;
            if (!this.From_Company.IsNull_flag) newEntity.From_Company.Value = this.From_Company.Value;
            if (!this.From_Address1.IsNull_flag) newEntity.From_Address1.Value = this.From_Address1.Value;
            if (!this.From_Address2.IsNull_flag) newEntity.From_Address2.Value = this.From_Address2.Value;
            if (!this.From_Address3.IsNull_flag) newEntity.From_Address3.Value = this.From_Address3.Value;
            if (!this.From_Address4.IsNull_flag) newEntity.From_Address4.Value = this.From_Address4.Value;
            if (!this.From_Address5.IsNull_flag) newEntity.From_Address5.Value = this.From_Address5.Value;
            if (!this.Telephone.IsNull_flag) newEntity.Telephone.Value = this.Telephone.Value;
            if (!this.Fax.IsNull_flag) newEntity.Fax.Value = this.Fax.Value;
            if (!this.DefaultCustodianType.IsNull_flag) newEntity.DefaultCustodianType.Value = this.DefaultCustodianType.Value;
            if (!this.PrimaryAllowed.IsNull_flag) newEntity.PrimaryAllowed.Value = this.PrimaryAllowed.Value;
            if (!this.Tax_Authority.IsNull_flag) newEntity.Tax_Authority.Value = this.Tax_Authority.Value;
            if (!this.TA_ATTN.IsNull_flag) newEntity.TA_ATTN.Value = this.TA_ATTN.Value;
            if (!this.TA_Address1.IsNull_flag) newEntity.TA_Address1.Value = this.TA_Address1.Value;
            if (!this.TA_Address2.IsNull_flag) newEntity.TA_Address2.Value = this.TA_Address2.Value;
            if (!this.Custodian_Alias.IsNull_flag) newEntity.Custodian_Alias.Value = this.Custodian_Alias.Value;
            if (!this.TA_Phone.IsNull_flag) newEntity.TA_Phone.Value = this.TA_Phone.Value;
            if (!this.TA_FAX.IsNull_flag) newEntity.TA_FAX.Value = this.TA_FAX.Value;
            if (!this.Custodian_Ref_Number.IsNull_flag) newEntity.Custodian_Ref_Number.Value = this.Custodian_Ref_Number.Value;
            if (!this.JPM_Custodian_Ref_Num.IsNull_flag) newEntity.JPM_Custodian_Ref_Num.Value = this.JPM_Custodian_Ref_Num.Value;
            return newEntity;
        }

        public string ToXML()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("<Custodian>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Custodian_Number>").Append(this.Custodian_Number).Append("</Custodian_Number>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Custodian_ShortName>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.Custodian_ShortName.Value)).Append("</Custodian_ShortName>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Custodian_FullName>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.Custodian_FullName.Value)).Append("</Custodian_FullName>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Account_Number>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.Account_Number.Value)).Append("</Account_Number>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Safekeeping_Number>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.Safekeeping_Number.Value)).Append("</Safekeeping_Number>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Language>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.Language.Value)).Append("</Language>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Country_Code>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.Country_Code.Value)).Append("</Country_Code>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Title>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.Title.Value)).Append("</Title>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<From_FirstName>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.From_FirstName.Value)).Append("</From_FirstName>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<From_LastName>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.From_LastName.Value)).Append("</From_LastName>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<From_Company>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.From_Company.Value)).Append("</From_Company>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<From_Address1>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.From_Address1.Value)).Append("</From_Address1>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<From_Address2>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.From_Address2.Value)).Append("</From_Address2>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<From_Address3>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.From_Address3.Value)).Append("</From_Address3>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<From_Address4>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.From_Address4.Value)).Append("</From_Address4>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<From_Address5>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.From_Address5.Value)).Append("</From_Address5>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Telephone>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.Telephone.Value)).Append("</Telephone>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Fax>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.Fax.Value)).Append("</Fax>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<DefaultCustodianType>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.DefaultCustodianType.Value)).Append("</DefaultCustodianType>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<PrimaryAllowed>").Append(this.PrimaryAllowed.Value).Append("</PrimaryAllowed>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Tax_Authority>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.Tax_Authority.Value)).Append("</Tax_Authority>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<TA_ATTN>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.TA_ATTN.Value)).Append("</TA_ATTN>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<TA_Address1>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.TA_Address1.Value)).Append("</TA_Address1>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<TA_Address2>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.TA_Address2.Value)).Append("</TA_Address2>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Custodian_Alias>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.Custodian_Alias.Value)).Append("</Custodian_Alias>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<TA_Phone>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.TA_Phone.Value)).Append("</TA_Phone>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<TA_FAX>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.TA_FAX.Value)).Append("</TA_FAX>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Custodian_Ref_Number>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.Custodian_Ref_Number.Value)).Append("</Custodian_Ref_Number>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<JPM_Custodian_Ref_Num>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.JPM_Custodian_Ref_Num.Value)).Append("</JPM_Custodian_Ref_Num>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("</Custodian>").Append(HssUtility.General.HssStr.WinNextLine);
            return sb.ToString();
        }
        /*^^^^^^^^^^^^^^^^^^^^^^^^^^^^^Hss Entity Framework Auto Generated Code^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^*/
    }
}
