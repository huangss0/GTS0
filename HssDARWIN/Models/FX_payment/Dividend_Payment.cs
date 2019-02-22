using System;
using System.Text;
using System.Collections.Generic;

using HssUtility.Forms.Attribute;
using HssDARWIN.Models.Tasks;

namespace HssDARWIN.Models.FX_payment
{
    public class Dividend_Payment
    {
        /*-----------------------------Hss Entity Framework Auto Generated Code-------------------------------*/
        private static HssUtility.SQLserver.CmdTemplate DBcmd_TP = null;
        public static HssUtility.SQLserver.CmdTemplate Get_cmdTP()
        {
            if (Dividend_Payment.DBcmd_TP != null) return Dividend_Payment.DBcmd_TP;

            Dividend_Payment.DBcmd_TP = new HssUtility.SQLserver.CmdTemplate();
            Dividend_Payment.DBcmd_TP.tableName = "Dividend_Payment";
            Dividend_Payment.DBcmd_TP.schema = "dbo";

            Dividend_Payment.DBcmd_TP.AddColumn("Dividend_PayID");
            Dividend_Payment.DBcmd_TP.AddColumn("DividendIndex");
            Dividend_Payment.DBcmd_TP.AddColumn("PaymentReferenceDate");/*Optional 3*/
            Dividend_Payment.DBcmd_TP.AddColumn("Depositary");/*Optional 4*/
            Dividend_Payment.DBcmd_TP.AddColumn("FXValueDate");/*Optional 5*/
            Dividend_Payment.DBcmd_TP.AddColumn("DivFXRate");/*Optional 6*/
            Dividend_Payment.DBcmd_TP.AddColumn("LastModifiedBy");/*Optional 7*/
            Dividend_Payment.DBcmd_TP.AddColumn("ModifiedDateTime");/*Optional 8*/
            Dividend_Payment.DBcmd_TP.AddColumn("Paid_And_Locked");/*Optional 9*/
            Dividend_Payment.DBcmd_TP.AddColumn("Paid_And_Locked_Date");/*Optional 10*/
            Dividend_Payment.DBcmd_TP.AddColumn("Billed_Date");/*Optional 11*/
            Dividend_Payment.DBcmd_TP.AddColumn("Paid_Date_Actual");/*Optional 12*/
            Dividend_Payment.DBcmd_TP.AddColumn("WriteOff");/*Optional 13*/
            Dividend_Payment.DBcmd_TP.AddColumn("FX_InputID");/*Optional 14*/
            Dividend_Payment.DBcmd_TP.AddColumn("CustodianID");/*Optional 15*/

            return Dividend_Payment.DBcmd_TP;
        }

        public Dividend_Payment() { }
        public Dividend_Payment(int id) { this.pk_ID = id; }

        private int pk_ID = -1; //primary key
        public int Dividend_PayID { get { return this.pk_ID; } }

        public readonly HssUtility.General.Attributes.Int_attr DividendIndex = new HssUtility.General.Attributes.Int_attr();
        public readonly HssUtility.General.Attributes.DateTime_attr PaymentReferenceDate = new HssUtility.General.Attributes.DateTime_attr();/*Optional 3*/
        public readonly HssUtility.General.Attributes.String_attr Depositary = new HssUtility.General.Attributes.String_attr();/*Optional 4*/
        public readonly HssUtility.General.Attributes.DateTime_attr FXValueDate = new HssUtility.General.Attributes.DateTime_attr();/*Optional 5*/
        public readonly HssUtility.General.Attributes.Decimal_attr DivFXRate = new HssUtility.General.Attributes.Decimal_attr();/*Optional 6*/
        public readonly HssUtility.General.Attributes.String_attr LastModifiedBy = new HssUtility.General.Attributes.String_attr(Utility.CurrentUser);/*Optional 7*/
        public readonly HssUtility.General.Attributes.DateTime_attr ModifiedDateTime = new HssUtility.General.Attributes.DateTime_attr(DateTime.Now);/*Optional 8*/
        public readonly HssUtility.General.Attributes.Bool_attr Paid_And_Locked = new HssUtility.General.Attributes.Bool_attr();/*Optional 9*/
        public readonly HssUtility.General.Attributes.DateTime_attr Paid_And_Locked_Date = new HssUtility.General.Attributes.DateTime_attr();/*Optional 10*/
        public readonly HssUtility.General.Attributes.DateTime_attr Billed_Date = new HssUtility.General.Attributes.DateTime_attr();/*Optional 11*/
        public readonly HssUtility.General.Attributes.DateTime_attr Paid_Date_Actual = new HssUtility.General.Attributes.DateTime_attr();/*Optional 12*/
        public readonly HssUtility.General.Attributes.String_attr WriteOff = new HssUtility.General.Attributes.String_attr();/*Optional 13*/
        public readonly HssUtility.General.Attributes.Int_attr FX_InputID = new HssUtility.General.Attributes.Int_attr();/*Optional 14*/
        public readonly HssUtility.General.Attributes.Int_attr CustodianID = new HssUtility.General.Attributes.Int_attr();/*Optional 15*/

        private List<HssUtility.General.Attributes.I_modelAttr> attrList = null;

        internal void Init_from_reader(HssUtility.SQLserver.DB_reader reader)
        {
            if (reader == null || reader.IsClosed) return;

            this.pk_ID = reader.GetInt("Dividend_PayID");
            reader.GetInt("DividendIndex", this.DividendIndex);
            reader.GetDateTime("PaymentReferenceDate", this.PaymentReferenceDate);/*Optional 3*/
            reader.GetString("Depositary", this.Depositary);/*Optional 4*/
            reader.GetDateTime("FXValueDate", this.FXValueDate);/*Optional 5*/
            reader.GetDecimal("DivFXRate", this.DivFXRate);/*Optional 6*/
            reader.GetString("LastModifiedBy", this.LastModifiedBy);/*Optional 7*/
            reader.GetDateTime("ModifiedDateTime", this.ModifiedDateTime);/*Optional 8*/
            reader.GetBool("Paid_And_Locked", this.Paid_And_Locked);/*Optional 9*/
            reader.GetDateTime("Paid_And_Locked_Date", this.Paid_And_Locked_Date);/*Optional 10*/
            reader.GetDateTime("Billed_Date", this.Billed_Date);/*Optional 11*/
            reader.GetDateTime("Paid_Date_Actual", this.Paid_Date_Actual);/*Optional 12*/
            reader.GetString("WriteOff", this.WriteOff);/*Optional 13*/
            reader.GetInt("FX_InputID", this.FX_InputID);/*Optional 14*/
            reader.GetInt("CustodianID", this.CustodianID);/*Optional 15*/

            this.SyncWithDB();
        }

        /// <summary>
        /// Initialize object from DB
        /// </summary>
        public bool Init_from_DB()
        {
            if (this.Dividend_PayID < 0) return false;

            HssUtility.SQLserver.DB_select db_sel = new HssUtility.SQLserver.DB_select(Dividend_Payment.Get_cmdTP());
            db_sel.tableName = "Dividend_Payment";
            HssUtility.SQLserver.SQL_relation rela = new HssUtility.SQLserver.SQL_relation("Dividend_PayID", HssUtility.General.RelationalOperator.Equals, this.Dividend_PayID);
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
            this.attrList.Add(this.DividendIndex);
            this.attrList.Add(this.PaymentReferenceDate);/*Optional 3*/
            this.attrList.Add(this.Depositary);/*Optional 4*/
            this.attrList.Add(this.FXValueDate);/*Optional 5*/
            this.attrList.Add(this.DivFXRate);/*Optional 6*/
            this.attrList.Add(this.LastModifiedBy);/*Optional 7*/
            this.attrList.Add(this.ModifiedDateTime);/*Optional 8*/
            this.attrList.Add(this.Paid_And_Locked);/*Optional 9*/
            this.attrList.Add(this.Paid_And_Locked_Date);/*Optional 10*/
            this.attrList.Add(this.Billed_Date);/*Optional 11*/
            this.attrList.Add(this.Paid_Date_Actual);/*Optional 12*/
            this.attrList.Add(this.WriteOff);/*Optional 13*/
            this.attrList.Add(this.FX_InputID);/*Optional 14*/
            this.attrList.Add(this.CustodianID);/*Optional 15*/
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
            HssUtility.SQLserver.DB_insert dbIns = new HssUtility.SQLserver.DB_insert(Dividend_Payment.Get_cmdTP());

            dbIns.AddValue("DividendIndex", this.DividendIndex.Value);
            dbIns.AddValue("PaymentReferenceDate", this.PaymentReferenceDate);/*Optional 3*/
            dbIns.AddValue("Depositary", this.Depositary);/*Optional 4*/
            dbIns.AddValue("FXValueDate", this.FXValueDate);/*Optional 5*/
            dbIns.AddValue("DivFXRate", this.DivFXRate);/*Optional 6*/
            dbIns.AddValue("LastModifiedBy", this.LastModifiedBy);/*Optional 7*/
            dbIns.AddValue("ModifiedDateTime", this.ModifiedDateTime);/*Optional 8*/
            dbIns.AddValue("Paid_And_Locked", this.Paid_And_Locked);/*Optional 9*/
            dbIns.AddValue("Paid_And_Locked_Date", this.Paid_And_Locked_Date);/*Optional 10*/
            dbIns.AddValue("Billed_Date", this.Billed_Date);/*Optional 11*/
            dbIns.AddValue("Paid_Date_Actual", this.Paid_Date_Actual);/*Optional 12*/
            dbIns.AddValue("WriteOff", this.WriteOff);/*Optional 13*/
            dbIns.AddValue("FX_InputID", this.FX_InputID);/*Optional 14*/
            dbIns.AddValue("CustodianID", this.CustodianID);/*Optional 15*/

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

            this.LastModifiedBy.Value = Utility.CurrentUser;
            this.ModifiedDateTime.Value = DateTime.Now;

            HssUtility.SQLserver.DB_update upd = new HssUtility.SQLserver.DB_update(Dividend_Payment.Get_cmdTP());
            if (this.DividendIndex.ValueChanged) upd.AddValue("DividendIndex", this.DividendIndex);
            if (this.PaymentReferenceDate.ValueChanged) upd.AddValue("PaymentReferenceDate", this.PaymentReferenceDate);
            if (this.Depositary.ValueChanged) upd.AddValue("Depositary", this.Depositary);
            if (this.FXValueDate.ValueChanged) upd.AddValue("FXValueDate", this.FXValueDate);
            if (this.DivFXRate.ValueChanged) upd.AddValue("DivFXRate", this.DivFXRate);
            if (this.LastModifiedBy.ValueChanged) upd.AddValue("LastModifiedBy", this.LastModifiedBy);
            if (this.ModifiedDateTime.ValueChanged) upd.AddValue("ModifiedDateTime", this.ModifiedDateTime);
            if (this.Paid_And_Locked.ValueChanged) upd.AddValue("Paid_And_Locked", this.Paid_And_Locked);
            if (this.Paid_And_Locked_Date.ValueChanged) upd.AddValue("Paid_And_Locked_Date", this.Paid_And_Locked_Date);
            if (this.Billed_Date.ValueChanged) upd.AddValue("Billed_Date", this.Billed_Date);
            if (this.Paid_Date_Actual.ValueChanged) upd.AddValue("Paid_Date_Actual", this.Paid_Date_Actual);
            if (this.WriteOff.ValueChanged) upd.AddValue("WriteOff", this.WriteOff);
            if (this.FX_InputID.ValueChanged) upd.AddValue("FX_InputID", this.FX_InputID);
            if (this.CustodianID.ValueChanged) upd.AddValue("CustodianID", this.CustodianID);

            HssUtility.SQLserver.SQL_relation rela = new HssUtility.SQLserver.SQL_relation("Dividend_PayID", HssUtility.General.RelationalOperator.Equals, this.pk_ID);
            upd.SetCondition(rela);

            return upd;
        }

        public Dividend_Payment GetCopy()
        {
            Dividend_Payment newEntity = new Dividend_Payment();
            if (!this.DividendIndex.IsNull_flag) newEntity.DividendIndex.Value = this.DividendIndex.Value;
            if (!this.PaymentReferenceDate.IsNull_flag) newEntity.PaymentReferenceDate.Value = this.PaymentReferenceDate.Value;
            if (!this.Depositary.IsNull_flag) newEntity.Depositary.Value = this.Depositary.Value;
            if (!this.FXValueDate.IsNull_flag) newEntity.FXValueDate.Value = this.FXValueDate.Value;
            if (!this.DivFXRate.IsNull_flag) newEntity.DivFXRate.Value = this.DivFXRate.Value;
            if (!this.LastModifiedBy.IsNull_flag) newEntity.LastModifiedBy.Value = this.LastModifiedBy.Value;
            if (!this.ModifiedDateTime.IsNull_flag) newEntity.ModifiedDateTime.Value = this.ModifiedDateTime.Value;
            if (!this.Paid_And_Locked.IsNull_flag) newEntity.Paid_And_Locked.Value = this.Paid_And_Locked.Value;
            if (!this.Paid_And_Locked_Date.IsNull_flag) newEntity.Paid_And_Locked_Date.Value = this.Paid_And_Locked_Date.Value;
            if (!this.Billed_Date.IsNull_flag) newEntity.Billed_Date.Value = this.Billed_Date.Value;
            if (!this.Paid_Date_Actual.IsNull_flag) newEntity.Paid_Date_Actual.Value = this.Paid_Date_Actual.Value;
            if (!this.WriteOff.IsNull_flag) newEntity.WriteOff.Value = this.WriteOff.Value;
            if (!this.FX_InputID.IsNull_flag) newEntity.FX_InputID.Value = this.FX_InputID.Value;
            if (!this.CustodianID.IsNull_flag) newEntity.CustodianID.Value = this.CustodianID.Value;
            return newEntity;
        }

        public string ToXML()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("<Dividend_Payment>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Dividend_PayID>").Append(this.Dividend_PayID).Append("</Dividend_PayID>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<DividendIndex>").Append(this.DividendIndex.Value).Append("</DividendIndex>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<PaymentReferenceDate>").Append(this.PaymentReferenceDate.Value).Append("</PaymentReferenceDate>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Depositary>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.Depositary.Value)).Append("</Depositary>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<FXValueDate>").Append(this.FXValueDate.Value).Append("</FXValueDate>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<DivFXRate>").Append(this.DivFXRate.Value).Append("</DivFXRate>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<LastModifiedBy>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.LastModifiedBy.Value)).Append("</LastModifiedBy>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<ModifiedDateTime>").Append(this.ModifiedDateTime.Value).Append("</ModifiedDateTime>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Paid_And_Locked>").Append(this.Paid_And_Locked.Value).Append("</Paid_And_Locked>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Paid_And_Locked_Date>").Append(this.Paid_And_Locked_Date.Value).Append("</Paid_And_Locked_Date>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Billed_Date>").Append(this.Billed_Date.Value).Append("</Billed_Date>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<Paid_Date_Actual>").Append(this.Paid_Date_Actual.Value).Append("</Paid_Date_Actual>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<WriteOff>").Append(HssUtility.General.HssStr.ToSafeXML_str(this.WriteOff.Value)).Append("</WriteOff>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<FX_InputID>").Append(this.FX_InputID.Value).Append("</FX_InputID>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("<CustodianID>").Append(this.CustodianID.Value).Append("</CustodianID>").Append(HssUtility.General.HssStr.WinNextLine);
            sb.Append("</Dividend_Payment>").Append(HssUtility.General.HssStr.WinNextLine);
            return sb.ToString();
        }
        /*^^^^^^^^^^^^^^^^^^^^^^^^^^^^^Hss Entity Framework Auto Generated Code^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^*/

        public Models_viewForm GetEditForm()
        {
            Models_viewForm mvf = new Models_viewForm();
            mvf.Text = "Dividend_Payment";
            mvf.Set_pk_label("Dividend_PayID: " + this.Dividend_PayID);

            mvf.Add_Control(new StrAttr_UserControl("DividendIndex", this.DividendIndex, true));
            mvf.Add_Control(new DateTimeAttr_UserControl("PaymentReferenceDate", this.PaymentReferenceDate));
            mvf.Add_Control(new StrAttr_UserControl("Depositary", this.Depositary));
            mvf.Add_Control(new DateTimeAttr_UserControl("FXValueDate", this.FXValueDate));
            mvf.Add_Control(new StrAttr_UserControl("DivFXRate", this.DivFXRate));
            mvf.Add_Control(new StrAttr_UserControl("LastModifiedBy", this.LastModifiedBy, true));
            mvf.Add_Control(new DateTimeAttr_UserControl("ModifiedDateTime", this.ModifiedDateTime, true));
            mvf.Add_Control(new BoolAttr_UserControl("Paid_And_Locked", this.Paid_And_Locked));
            mvf.Add_Control(new DateTimeAttr_UserControl("Paid_And_Locked_Date", this.Paid_And_Locked_Date, true));
            mvf.Add_Control(new DateTimeAttr_UserControl("Billed_Date", this.Billed_Date));
            mvf.Add_Control(new DateTimeAttr_UserControl("Paid_Date_Actual", this.Paid_Date_Actual));
            mvf.Add_Control(new StrAttr_UserControl("WriteOff", this.WriteOff));
            mvf.Add_Control(new StrAttr_UserControl("FX_InputID", this.FX_InputID, true));
            mvf.Add_Control(new StrAttr_UserControl("CustodianID", this.CustodianID, true));

            mvf.SaveModel_func = this.Save_to_DB;
            return mvf;
        }

        public bool Save_to_DB()
        {
            if (this.Paid_And_Locked.ValueChanged && this.Paid_And_Locked.Value) this.Paid_And_Locked_Date.Value = DateTime.Now;

            bool dataSaved_flag = false;
            if (this.pk_ID > 0) dataSaved_flag = this.Update_to_DB();
            else dataSaved_flag = this.Insert_to_DB();

            if (dataSaved_flag)
            {
                FX_Input fxi = FX_Input_master.Get_FXinput_ID(this.FX_InputID.Value);
                if (fxi != null && fxi.RecheckLocked()) TaskDetailMaster.SetTaskCompleteness(20, fxi.FX_InputID.ToString(), "A", true);                
            }

            return dataSaved_flag;
        }
    }
}
