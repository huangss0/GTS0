using System;
using System.IO;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data;
using System.Threading;

using HssUtility.SQLserver;
using HssUtility.General;
using HssUtility.Text;
using HssUtility.Forms.Attribute;

using HssDARWIN.SubProjects.Daily_Jobs;
using HssDARWIN.Helpers;
using HssDARWIN.Models.Countries;
using HssDARWIN.Models.Custodians;
using HssDARWIN.Models.Dividends;
using HssDARWIN.Models.XBRL.Event;
using HssDARWIN.Models.Securities;
using HssDARWIN.SubProjects.Business_Development;

namespace HssDARWIN.SubProjects.HssResearch
{
    public partial class ResearchForm : Form
    {
        public ResearchForm()
        {
            InitializeComponent();
        }

        private void JobMaster_button_Click(object sender, EventArgs e)
        {
            DailyJobs_form djf = new DailyJobs_form();
            djf.Show();
        }

        private void xml_serializer_button_Click(object sender, EventArgs e)
        {
            Person ps = new Person("hss");
            System.Xml.Serialization.XmlSerializer serializer = new System.Xml.Serialization.XmlSerializer(ps.GetType());
            StringWriter tw = new StringWriter();
            serializer.Serialize(tw, ps);

            MessageBox.Show(tw.ToString());
        }

        private void HssEntityFramework_button_Click(object sender, EventArgs e)
        {
            HssEntityFramework hef = new HssEntityFramework();

            hssDB hDB = null;
            string hDB_funcName = "hDB";
            bool build_in_DB = this.hef_BiD_checkBox.Checked;

            if (this.DB_comboBox.Text.Equals("DRWIN", StringComparison.OrdinalIgnoreCase))
            {
                hDB = Utility.Get_DRWIN_hDB();
                if(build_in_DB) hDB_funcName = "Utility.Get_DRWIN_hDB()";
            }
            else if (this.DB_comboBox.Text.Equals("XBRL", StringComparison.OrdinalIgnoreCase))
            {
                hDB = Utility.Get_XBRL_hDB();
                if (build_in_DB) hDB_funcName = "Utility.Get_XBRL_hDB()";
            }
            else if (this.DB_comboBox.Text.Equals("ESP2", StringComparison.OrdinalIgnoreCase))
            {
                hDB = Utility.Get_ESP2_hDB();
                if (build_in_DB) hDB_funcName = "Utility.Get_ESP2_hDB()";
            }
            else if (this.DB_comboBox.Text.Equals("EDI", StringComparison.OrdinalIgnoreCase))
            {
                hDB = Utility.Get_EDI_hDB();
                if (build_in_DB) hDB_funcName = "Utility.Get_EDI_hDB()";
            }

            hef.SetTable(this.hef_tn_textBox.Text, this.hef_sn_textBox.Text, hDB);
            hef.className = this.hef_cn_textBox.Text;
            hef.hDB_name = hDB_funcName;
            hef.builtInDB_flag = build_in_DB;

            ViewDataForm vdf = new ViewDataForm();
            vdf.Set_notePad_dataSource(hef.Run());
            vdf.Show();
        }

        private void XBRL_button_Click(object sender, EventArgs e)
        {
            int id_savedFile = (int)this.XBRL_numericUpDown.Value;
            XBRL_SavedFile sf = new XBRL_SavedFile(id_savedFile);
            sf.Init_from_DB(false);

            XBRL_event_info xei = new XBRL_event_info(sf.savedfile);
            Security sec = SecurityMaster.XBRL_Create_or_Get_Security(xei, false);
            Dividend dvd = new Dividend();
            dvd.Init_from_XBRL(xei, sec);
            dvd.PrintAllAttributeValues();
        }

        private void ESP2_button_Click(object sender, EventArgs e)
        {
            HashSet<string> hs = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
            hs.Add("Italy");
            hs.Add("France");
            hs.Add("Ireland");

            int count = 0;
            for (int i = 30000; i > 10000; --i)
            {
                HssDARWIN.Models.Dividends.Dividend dvd2 = new Models.Dividends.Dividend(i);
                if (dvd2.Init_from_DB(Models.Dividends.DividendTable_option.Dividend_Control_Approved))
                {
                    if (!hs.Contains(dvd2.Country.Value)) continue;

                    Models.ESP2.Events.Event eve = Models.ESP2.Events.EventMaster.GetEvent_DividendIndex(dvd2.DividendIndex);
                    if (eve != null) continue;//existing ESP2 event

                    int res = dvd2.Publish_to_ESP2();
                    Console.WriteLine("" + dvd2.DividendIndex + " " + res);
                    if (res > 0) ++count;
                }

                if (count >= 250) break;
            }
        }

        private void custMapping_button_Click(object sender, EventArgs e)
        {//DRWIN-467
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string path = ofd.FileName;
                DataSet ds = HssExcel.Excel_to_DS(path);
                DataTable dt = ds.Tables["Export Worksheet"];

                Bulk_DBcmd bk = new Bulk_DBcmd();
                foreach (DataRow row in dt.Rows)
                {
                    int cNum = -1;
                    if (int.TryParse(row["Custodian #"].ToString(), out cNum))
                    {
                        Custodian cust = CustodianMaster.GetCustodian_num(cNum);
                        if (cust == null)
                        {
                            Console.WriteLine("cNum " + cNum + " not found");
                            continue;
                        }

                        string str = row["Custodian"].ToString();

                        if (string.IsNullOrEmpty(cust.Custodian_Alias.Value)) cust.Custodian_Alias.Value = row["Custodian"].ToString();
                        else if (cust.Custodian_Alias.Value.ToUpper().Contains(str.ToUpper())) continue;
                        else cust.Custodian_Alias.Value = cust.Custodian_Alias.Value + "," + row["Custodian"].ToString();

                        bk.Add_DBcmd(cust.Get_DBupdate());
                    }
                    else
                    {
                        string custName = row["Custodian"].ToString();
                        if (string.IsNullOrEmpty(custName)) continue;

                        string ctyName = row["Country"].ToString();
                        Country cty = CountryMaster.GetCountry_name(ctyName);
                        Custodian cust = CustodianMaster.GetCustodian_name(custName);

                        if (cust == null) cust = new Custodian();

                        cust.Custodian_ShortName.Value = custName;
                        cust.Custodian_FullName.Value = custName;
                        if (cty != null) cust.Country_Code.Value = cty.cntry_cd.Value;
                        else cust.Country_Code.Value = "000";

                        if (cust.Custodian_Number > 0) bk.Add_DBcmd(cust.Get_DBupdate());
                        else bk.Add_DBcmd(cust.Get_DBinsert());
                    }
                }
                MessageBox.Show("" + bk.SaveToDB(Utility.Get_DRWIN_hDB()));
                CustodianMaster.Reset();
            }
        }

        private void JPM_refNum_button_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string path = ofd.FileName;
                DataSet ds = HssExcel.Excel_to_DS(path);
                DataTable dt = ds.Tables["JPM"];

                Bulk_DBcmd bk = new Bulk_DBcmd();
                foreach (DataRow row in dt.Rows)
                {
                    string JPM_refNum = row["JPM CUSTODIAN REF NUMBER"].ToString();
                    if (string.IsNullOrEmpty(JPM_refNum)) continue;

                    string shortName = row["Short\nName"].ToString();
                    Custodian cust = CustodianMaster.GetCustodian_name(shortName);
                    if (cust == null) continue;

                    cust.JPM_Custodian_Ref_Num.Value = JPM_refNum;
                    bk.Add_DBcmd(cust.Get_DBupdate());
                }

                MessageBox.Show("" + bk.SaveToDB(Utility.Get_DRWIN_hDB()));
                CustodianMaster.Reset();
            }
        }

        private void delDvd_button_Click(object sender, EventArgs e)
        {
            int dvdIndex = (int)this.dvdIndex_numericUpDown.Value;
            if (MessageBox.Show("Delete Dividend " + dvdIndex + "?", "Warning!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                SQL_relation rela = new SQL_relation("DividendIndex", RelationalOperator.Equals, dvdIndex);

                string[] tablesDeleteFrom =
                    { "Dividend_DTC_Position",
                    "Dividend_filing",
                    "Dividend_Payment",
                    "Dividend_Rejection",
                    "Dividend_Schedule_Of_Fees_DSC",
                    "Dividend_Control" };

                int total = 0;
                foreach (string tableName in tablesDeleteFrom)
                {
                    DB_delete del = new DB_delete();
                    del.tableName = tableName;
                    del.SetCondition(rela);

                    int count = del.SaveToDB(Utility.Get_DRWIN_hDB());
                    if (count > 0) total += count;
                }

                if (total > 0) MessageBox.Show("Dividend " + dvdIndex + " Deleted!");
                else MessageBox.Show("Nothing?! (" + dvdIndex + ")");
            }
        }

        private void del_dvdDetail_button_Click(object sender, EventArgs e)
        {
            int detailID = (int)this.del_dvdDetail_numericUpDown.Value;
            if (MessageBox.Show("Delete Detail " + detailID + "?", "Warning!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                SQL_relation rela = new SQL_relation("DetailID", RelationalOperator.Equals, detailID);

                DB_delete del0 = new DB_delete();
                del0.tableName = "Dividend_Detail";
                del0.SetCondition(rela);

                int count0 = del0.SaveToDB(Utility.Get_DRWIN_hDB());

                if (count0 > 0) MessageBox.Show("Detail " + detailID + " Deleted!");
                else MessageBox.Show("Nothing?! (" + detailID + ")");
            }
        }

        private void dcd_button_Click(object sender, EventArgs e)
        {
            int dvdIndex = (int)this.dcd_numericUpDown.Value;
            if (MessageBox.Show("Delete CustodianID on all details for Dividend " + dvdIndex + "?", "Warning!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Dividend dvd = new Dividend(dvdIndex);
                int count = dvd.Delete_CustodianID_dvdDetail("At-Source");
                MessageBox.Show("Count: " + count);
            }
        }

        private void ap_button_Click(object sender, EventArgs e)
        {
            int dvdIndex = (int)this.dcd_numericUpDown.Value;
            if (MessageBox.Show("Auto-Proration for Dividend " + dvdIndex + "?", "Warning!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Dividend dvd = new Dividend(dvdIndex);
                Thread th = new Thread(dvd.Auto_Proration);
                th.Start();
            }
        }

        private void eleFile_button_Click(object sender, EventArgs e)
        {
            ElectionFile.ElectionDocument ed = new ElectionFile.ElectionDocument();
            ed.Calculate((int)this.eleFile_numericUpDown.Value);
            string str = ed.GetXML();
            HssUtility.Forms.ViewTextForm vtf = new HssUtility.Forms.ViewTextForm();
            vtf.NotePad_SetData(str);
            vtf.Show();
        }

        private void createExcel_button_Click(object sender, EventArgs e)
        {
            string xlTemplatePath = @"C:\steven\DrwinMain2017\DRWIN_APP\MAIN-Steven\HssUtility\Ref_DLLs\XML Templates\Excel\";
            DataSet ds = new DataSet();
            DataTable dt = ds.Tables.Add("Security");
            dt.Columns.Add("Security(CUSIP) Exist");
            dt.Columns.Add("Depo/FirstFiler/Ratio");
            dt.Columns.Add("Name/TickerSymbol");
            dt.Columns.Add("Action");

            string[] trueFalse_arr = { "True", "False" };
            string[] comp_arr = { "Same", "Different", "Missing" };

            foreach (string sec in trueFalse_arr)
            {
                foreach (string dfr in comp_arr)
                {
                    foreach (string nt in comp_arr)
                    {
                        DataRow row = dt.Rows.Add();
                        row["Security(CUSIP) Exist"] = sec;
                        row["Depo/FirstFiler/Ratio"] = dfr;
                        row["Name/TickerSymbol"] = nt;
                    }
                }
            }

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel|*.xlsx";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                HssRawExcel hre = new HssRawExcel();
                hre.Create_Excel_fromDS(ds, sfd.FileName, xlTemplatePath);
                MessageBox.Show("Done");
            }
        }

        private void businessDevelop_button_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel|*.xlsx";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                ForThread fs = new ForThread();
                fs.exportPath = sfd.FileName;

                ThreadStatusForm tsf = new ThreadStatusForm();
                tsf.statusInfo = fs.statusInfo;
                tsf.Show();

                Thread th = new Thread(fs.Run);
                th.Start();
            }
        }

        private void rsh_pgp_button_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "CSV|*.csv";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                Models.RSH.SavedFiles_CSV sfc = new Models.RSH.SavedFiles_CSV(2);//fileID here
                sfc.Init_from_DB(true, true);
                //Dim queueMachine = Data.settingProvider.GetSetting("MSMQMachine")
                //Stream sm = DRWIN_JPDOC.WCFServiceHelper.GetDecryptedPGP("dresprunner01", sfc.id_SavedFiles_CSV, sfc.originalFileName.Value, Utility.DRWIN_DBconnString);

                //FileStream fs = new FileStream(sfd.FileName, FileMode.Create);
                //sm.CopyTo(fs);
                //fs.Close();
                //sm.Close();

                //Further info in DRWIN_DBAL\TypedDataSets\DSRSHLog

                MessageBox.Show("Done");
            }
        }
        /*-------------------------------------------------------------------------------------------------------------*/

        /// <summary>
        /// Testing Function
        /// </summary>
        private void Adhoc_button_Click(object sender, EventArgs e)
        {
            TestClass tc = new TestClass(1);
            tc.Init_from_DB();
            MessageBox.Show(tc.ToXML());
        }        
    }
}
