using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using HssDARWIN.Models.Countries;

namespace HssDARWIN.Models.Tasks
{
    public class ADR_TaskOwner
    {
        /*-----------------------------Hss Entity Framework Auto Generated Code-------------------------------*/
        private static HssUtility.SQLserver.CmdTemplate DBcmd_TP = null;
        public static HssUtility.SQLserver.CmdTemplate Get_cmdTP()
        {
            if (ADR_TaskOwner.DBcmd_TP != null) return ADR_TaskOwner.DBcmd_TP;

            ADR_TaskOwner.DBcmd_TP = new HssUtility.SQLserver.CmdTemplate();
            ADR_TaskOwner.DBcmd_TP.tableName = "ADR_TaskOwner";
            ADR_TaskOwner.DBcmd_TP.schema = "dbo";

            ADR_TaskOwner.DBcmd_TP.AddColumn("OwnerID");
            ADR_TaskOwner.DBcmd_TP.AddColumn("OwnerSID");
            ADR_TaskOwner.DBcmd_TP.AddColumn("OwnerName");
            ADR_TaskOwner.DBcmd_TP.AddColumn("Owner_LastName");/*Optional 4*/
            ADR_TaskOwner.DBcmd_TP.AddColumn("Owner_FirstName");/*Optional 5*/
            //ADR_TaskOwner.DBcmd_TP.AddColumn("AllProperties");/*Optional 6*/
            ADR_TaskOwner.DBcmd_TP.AddColumn("Telephone");/*Optional 7*/
            ADR_TaskOwner.DBcmd_TP.AddColumn("Email");/*Optional 8*/
            ADR_TaskOwner.DBcmd_TP.AddColumn("Department");/*Optional 9*/
            ADR_TaskOwner.DBcmd_TP.AddColumn("Title");/*Optional 10*/
            //ADR_TaskOwner.DBcmd_TP.AddColumn("Signature");/*Optional 11*/

            return ADR_TaskOwner.DBcmd_TP;
        }

        public ADR_TaskOwner() { }
        public ADR_TaskOwner(int id) { this.pk_ID = id; }

        private int pk_ID = -1; //primary key
        public int OwnerID { get { return this.pk_ID; } }

        public readonly HssUtility.General.Attributes.String_attr OwnerSID = new HssUtility.General.Attributes.String_attr();
        public readonly HssUtility.General.Attributes.String_attr OwnerName = new HssUtility.General.Attributes.String_attr();
        public readonly HssUtility.General.Attributes.String_attr Owner_LastName = new HssUtility.General.Attributes.String_attr();/*Optional 4*/
        public readonly HssUtility.General.Attributes.String_attr Owner_FirstName = new HssUtility.General.Attributes.String_attr();/*Optional 5*/
        public readonly HssUtility.General.Attributes.String_attr Telephone = new HssUtility.General.Attributes.String_attr();/*Optional 7*/
        public readonly HssUtility.General.Attributes.String_attr Email = new HssUtility.General.Attributes.String_attr();/*Optional 8*/
        public readonly HssUtility.General.Attributes.String_attr Department = new HssUtility.General.Attributes.String_attr();/*Optional 9*/
        public readonly HssUtility.General.Attributes.String_attr Title = new HssUtility.General.Attributes.String_attr();/*Optional 10*/

        private List<HssUtility.General.Attributes.I_modelAttr> attrList = null;

        internal void Init_from_reader(HssUtility.SQLserver.DB_reader reader)
        {
            if (reader == null || reader.IsClosed) return;

            this.pk_ID = reader.GetInt("OwnerID");
            reader.GetString("OwnerSID", this.OwnerSID);
            reader.GetString("OwnerName", this.OwnerName);
            reader.GetString("Owner_LastName", this.Owner_LastName);/*Optional 4*/
            reader.GetString("Owner_FirstName", this.Owner_FirstName);/*Optional 5*/
            reader.GetString("Telephone", this.Telephone);/*Optional 7*/
            reader.GetString("Email", this.Email);/*Optional 8*/
            reader.GetString("Department", this.Department);/*Optional 9*/
            reader.GetString("Title", this.Title);/*Optional 10*/

            this.SyncWithDB();
        }

        /// <summary>
        /// Initialize object from DB
        /// </summary>
        public bool Init_from_DB()
        {
            if (this.OwnerID < 0) return false;

            HssUtility.SQLserver.DB_select db_sel = new HssUtility.SQLserver.DB_select(ADR_TaskOwner.Get_cmdTP());
            db_sel.tableName = "ADR_TaskOwner";
            HssUtility.SQLserver.SQL_relation rela = new HssUtility.SQLserver.SQL_relation("OwnerID", HssUtility.General.RelationalOperator.Equals, this.OwnerID);
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
            this.attrList.Add(this.OwnerSID);
            this.attrList.Add(this.OwnerName);
            this.attrList.Add(this.Owner_LastName);/*Optional 4*/
            this.attrList.Add(this.Owner_FirstName);/*Optional 5*/
            //this.attrList.Add(this.AllProperties);/*Optional 6*/
            this.attrList.Add(this.Telephone);/*Optional 7*/
            this.attrList.Add(this.Email);/*Optional 8*/
            this.attrList.Add(this.Department);/*Optional 9*/
            this.attrList.Add(this.Title);/*Optional 10*/
            //this.attrList.Add(this.Signature);/*Optional 11*/
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
            HssUtility.SQLserver.DB_insert dbIns = new HssUtility.SQLserver.DB_insert(ADR_TaskOwner.Get_cmdTP());

            dbIns.AddValue("OwnerSID", this.OwnerSID.Value);
            dbIns.AddValue("OwnerName", this.OwnerName.Value);
            dbIns.AddValue("Owner_LastName", this.Owner_LastName);/*Optional 4*/
            dbIns.AddValue("Owner_FirstName", this.Owner_FirstName);/*Optional 5*/
            //dbIns.AddValue("AllProperties", this.AllProperties);/*Optional 6*/
            dbIns.AddValue("Telephone", this.Telephone);/*Optional 7*/
            dbIns.AddValue("Email", this.Email);/*Optional 8*/
            dbIns.AddValue("Department", this.Department);/*Optional 9*/
            dbIns.AddValue("Title", this.Title);/*Optional 10*/
            //dbIns.AddValue("Signature", this.Signature);/*Optional 11*/

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

            HssUtility.SQLserver.DB_update upd = new HssUtility.SQLserver.DB_update(ADR_TaskOwner.Get_cmdTP());
            if (this.OwnerSID.ValueChanged) upd.AddValue("OwnerSID", this.OwnerSID);
            if (this.OwnerName.ValueChanged) upd.AddValue("OwnerName", this.OwnerName);
            if (this.Owner_LastName.ValueChanged) upd.AddValue("Owner_LastName", this.Owner_LastName);
            if (this.Owner_FirstName.ValueChanged) upd.AddValue("Owner_FirstName", this.Owner_FirstName);
            //if (this.AllProperties.ValueChanged) upd.AddValue("AllProperties", this.AllProperties);
            if (this.Telephone.ValueChanged) upd.AddValue("Telephone", this.Telephone);
            if (this.Email.ValueChanged) upd.AddValue("Email", this.Email);
            if (this.Department.ValueChanged) upd.AddValue("Department", this.Department);
            if (this.Title.ValueChanged) upd.AddValue("Title", this.Title);
            //if (this.Signature.ValueChanged) upd.AddValue("Signature", this.Signature);

            HssUtility.SQLserver.SQL_relation rela = new HssUtility.SQLserver.SQL_relation("OwnerID", HssUtility.General.RelationalOperator.Equals, this.pk_ID);
            upd.SetCondition(rela);

            return upd;
        }

        public ADR_TaskOwner GetCopy()
        {
            ADR_TaskOwner newEntity = new ADR_TaskOwner();
            if (!this.OwnerSID.IsNull_flag) newEntity.OwnerSID.Value = this.OwnerSID.Value;
            if (!this.OwnerName.IsNull_flag) newEntity.OwnerName.Value = this.OwnerName.Value;
            if (!this.Owner_LastName.IsNull_flag) newEntity.Owner_LastName.Value = this.Owner_LastName.Value;
            if (!this.Owner_FirstName.IsNull_flag) newEntity.Owner_FirstName.Value = this.Owner_FirstName.Value;
            //if (!this.AllProperties.IsNull_flag) newEntity.AllProperties.Value = this.AllProperties.Value;
            if (!this.Telephone.IsNull_flag) newEntity.Telephone.Value = this.Telephone.Value;
            if (!this.Email.IsNull_flag) newEntity.Email.Value = this.Email.Value;
            if (!this.Department.IsNull_flag) newEntity.Department.Value = this.Department.Value;
            if (!this.Title.IsNull_flag) newEntity.Title.Value = this.Title.Value;
            //if (!this.Signature.IsNull_flag) newEntity.Signature.Value = this.Signature.Value;
            return newEntity;
        }

        public string ToXML()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("<ADR_TaskOwner>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<OwnerID>").Append(this.OwnerID).Append("</OwnerID>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<OwnerSID>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.OwnerSID.Value)).Append("</OwnerSID>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<OwnerName>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.OwnerName.Value)).Append("</OwnerName>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Owner_LastName>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.Owner_LastName.Value)).Append("</Owner_LastName>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Owner_FirstName>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.Owner_FirstName.Value)).Append("</Owner_FirstName>").Append(HssUtility.General.HssStr.WinNextLine);
            //sb.Append("<AllProperties>").Append(this.AllProperties.Value).Append("</AllProperties>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Telephone>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.Telephone.Value)).Append("</Telephone>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Email>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.Email.Value)).Append("</Email>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Department>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.Department.Value)).Append("</Department>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Title>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.Title.Value)).Append("</Title>").Append(HssUtility.General.HssStr.WinNextLine);
            //sb.Append("<Signature>").Append(this.Signature.Value).Append("</Signature>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("</ADR_TaskOwner>").Append(HssUtility.General.HssStr.WinNextLine);
            return sb.ToString();
        }
        /*^^^^^^^^^^^^^^^^^^^^^^^^^^^^^Hss Entity Framework Auto Generated Code^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^*/

        public List<Country> Country_list
        {
            get
            {
                List<ADR_Member_Country> amc_list = TaskMemberMaster.Get_mcList_SID(this.OwnerSID.Value);
                List<Country> cty_list = new List<Country>();

                foreach (ADR_Member_Country amc in amc_list)
                {
                    Country cty = CountryMaster.GetCountry_name(amc.ISO2CntryCode.Value);
                    if (cty != null) cty_list.Add(cty);
                }

                return cty_list;
            }
        }
    }
}
