using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

using HssUtility.SQLserver;
using HssUtility.General;

namespace HssDARWIN.Models.Details
{
    public class DividendDetail_master
    {
        /// <summary>
        /// Duplicate details for Return of Founds (DRWIN-38)
        /// </summary>
        public static int Add_RoF_claims(HashSet<int> detailID_hs)
        {
            List<Dividend_Detail_full> ddf_list = DividendDetail_master.Get_ddf_list(detailID_hs);

            Bulk_DBcmd bkc = new Bulk_DBcmd();
            foreach (Dividend_Detail_full ddf in ddf_list)
            {
                if (!ddf.Status.Value.StartsWith("Paid", StringComparison.OrdinalIgnoreCase)) continue;

                long newClaimID = DividendDetail_master.GetNewClaimID(ddf.ClaimID.Value, 5);
                ddf.ClaimID.Value = newClaimID;

                ddf.Override_Custodial_Fees.Value = 0;
                ddf.Override_Fees.Value = 0;
                ddf.RecordDatePosition.Value = -ddf.RecordDatePosition.Value;

                ddf.Status.Value = "RECEIVED";
                ddf.Dividend_FilingID.IsNull_flag = true;
                ddf.Dividend_PayID.IsNull_flag = true;
                ddf.AuditStatus.Value = "Return of Funds";

                ddf.LastModifiedBy.Value = Utility.CurrentUser;
                ddf.ModifiedDateTime.Value = DateTime.Now;

                bkc.Add_DBcmd(ddf.Get_DBinsert());
            }
            int count = bkc.SaveToDB(Utility.Get_DRWIN_hDB());

            if (count > 0) MessageBox.Show("Add RoF Finished " + count);
            else MessageBox.Show("RoF: Nothing was added...");

            return count;
        }

        /// <summary>
        /// Duplicate details for Upfront Fees (DRWIN-38)
        /// </summary>
        public static int Add_UfFess_claim(HashSet<int> detailID_hs)
        {
            List<Dividend_Detail_full> ddf_list = DividendDetail_master.Get_ddf_list(detailID_hs);

            Bulk_DBcmd bkc = new Bulk_DBcmd();
            foreach (Dividend_Detail_full ddf in ddf_list)
            {
                if (!ddf.Status.Value.StartsWith("Received", StringComparison.OrdinalIgnoreCase)) continue;

                ddf.LastModifiedBy.Value = Utility.CurrentUser;
                ddf.ModifiedDateTime.Value = DateTime.Now;

                long new_ClaimID = DividendDetail_master.GetNewClaimID(ddf.ClaimID.Value, 6);
                long old_ClaimID = ddf.ClaimID.Value;
                string old_BO_EntityType = ddf.BO_EntityType.Value;

                ddf.ClaimID.Value = new_ClaimID;
                ddf.BO_EntityType.Value = "Pen1";
                bkc.Add_DBcmd(ddf.Get_DBinsert());

                //update old [Dividend_Detail]
                ddf.ClaimID.Value = old_ClaimID;
                ddf.BO_EntityType.Value = old_BO_EntityType;
                ddf.Override_Fees.Value = 0;//set depositary_fee to 0
                ddf.Override_Custodial_Fees.Value = 0;//set custodian_fee to 0
                bkc.Add_DBcmd(ddf.Get_DBupdate());
            }
            int count = bkc.SaveToDB(Utility.Get_DRWIN_hDB());

            if (count > 0) MessageBox.Show("Add UpFees Finished " + count);
            else MessageBox.Show("UpFees: Nothing was added...");

            return count;
        }

        /// <summary>
        /// DRWIN-641
        /// </summary>
        public static void Add_DateTime_RTS(DataTable dt, string pkCol, string dateCol)
        {
            if (dt == null) return;
            if (string.IsNullOrEmpty(pkCol) || string.IsNullOrEmpty(dateCol)) return;
            if (!dt.Columns.Contains(pkCol) || !dt.Columns.Contains(dateCol)) return;

            List<int> detailID_list = new List<int>(dt.Rows.Count);
            foreach (DataRow row in dt.Rows)
            {
                object tempObj = row[pkCol];
                if (!(tempObj is int)) continue;

                int ID = (int)tempObj;
                detailID_list.Add(ID);
            }

            Dictionary<int, DateTime> time_dic = DividendDetail_master.Get_DateTime_values(detailID_list, dateCol);

            foreach (DataRow row in dt.Rows)
            {
                object tempObj = row[pkCol];
                if (!(tempObj is int)) continue;

                int ID = (int)tempObj;
                if (!time_dic.ContainsKey(ID)) continue;

                DateTime dTime = time_dic[ID];
                if (dTime > Utility.MinDate) row[dateCol] = dTime;
            }
        }

        /*--------------------------------------------------------------------------------------------------------------*/

        public const string Detail_PK_colName = "DetailID";
        public const string Detail_tableName = "Dividend_Detail";
        public const string DRWIN_641_colName = "Date_Re_Up_Sent";

        public static List<Dividend_Detail_full> Get_ddf_list(HashSet<int> detailID_hs)
        {
            List<Dividend_Detail_full> ddf_list = new List<Dividend_Detail_full>();
            if (detailID_hs == null) return ddf_list;

            DB_select selt = new DB_select(Dividend_Detail_full.Get_cmdTP());
            selt.SetCondition(new SQL_relation("DetailID", true, detailID_hs));

            DB_reader reader = new DB_reader(selt, Utility.Get_DRWIN_hDB());
            while (reader.Read())
            {
                Dividend_Detail_full ddf = new Dividend_Detail_full();
                ddf.Init_from_reader(reader);
                ddf_list.Add(ddf);
            }

            return ddf_list;
        }

        public static long GetNewClaimID(long oriID, long new_firstDigit)
        {
            if (new_firstDigit > 9 || new_firstDigit < 1) return oriID;

            bool negtiveFlag = false;
            if (oriID < 0)
            {
                negtiveFlag = true;
                oriID = -oriID;
            }

            long base10 = 1;
            while ((oriID / base10) >= 10) base10 *= 10;

            long old_firstDigit = oriID / base10;
            long old_remaining = oriID - old_firstDigit * base10;
            long newID = old_remaining + new_firstDigit * base10;

            if (negtiveFlag) return -newID;
            else return newID;
        }

        public static void Delete_details(HashSet<int> detail_hs)
        {
            if (detail_hs == null || detail_hs.Count < 1) return;

            DB_delete del = new DB_delete();
            del.tableName = DividendDetail_master.Detail_tableName;

            SQL_relation rela = new SQL_relation("DetailID", true, detail_hs);
            del.SetCondition(rela);

            int count = del.SaveToDB(Utility.Get_DRWIN_hDB());

            if (count > 0) MessageBox.Show("Detail Deleted! (" + count + ")");
            else MessageBox.Show("Nothing deleted?!");
        }

        public static Dictionary<int, DateTime> Get_DateTime_values(List<int> detailID_list, string colName)
        {
            Dictionary<int, DateTime> dic = new Dictionary<int, DateTime>();
            if (detailID_list == null || detailID_list.Count < 1) return dic;
            if (string.IsNullOrEmpty(colName)) return dic;

            List<List<int>> splited_list = new List<List<int>>();//split detailID_list into small lists
            List<int> tempList = new List<int>();
            foreach (int ID in detailID_list)
            {
                tempList.Add(ID);
                if (tempList.Count >= 100)
                {
                    splited_list.Add(tempList);
                    tempList = new List<int>();
                }
            }
            if (tempList.Count > 0) splited_list.Add(tempList);

            CmdTemplate cmdTp = new CmdTemplate();//create template for DB
            cmdTp.tableName = DividendDetail_master.Detail_tableName;
            cmdTp.AddColumn(DividendDetail_master.Detail_PK_colName);
            cmdTp.AddColumn(colName);

            DB_select selt = new DB_select(cmdTp);
            foreach (List<int> list in splited_list)
            {
                SQL_relation rela = new SQL_relation(DividendDetail_master.Detail_PK_colName, true, list);
                selt.SetCondition(rela);

                DB_reader reader = new DB_reader(selt, Utility.Get_DRWIN_hDB());
                while (reader.Read())
                {
                    int detailID = reader.GetInt(DividendDetail_master.Detail_PK_colName);
                    DateTime dt = reader.GetDateTime(colName);
                    dic[detailID] = dt;
                }
                reader.Close();
            }

            return dic;
        }

        public static int UpdateDetail_singleValue(int detailID, string colName, DateTime dt)
        {
            if (string.IsNullOrEmpty(colName)) return -5;
            if (dt < Utility.MinDate) return -6;

            CmdTemplate cmdTp = new CmdTemplate();//create template for DB
            cmdTp.tableName = DividendDetail_master.Detail_tableName;
            cmdTp.AddColumn(DividendDetail_master.Detail_PK_colName);
            cmdTp.AddColumn(colName);

            DB_update upd = new DB_update(cmdTp);
            upd.AddValue(colName, dt);
            SQL_relation rela = new SQL_relation(DividendDetail_master.Detail_PK_colName, RelationalOperator.Equals, detailID);
            upd.SetCondition(rela);

            if (colName.Contains(" ") || colName.Contains("-"))
            {
                Helper_SQLserver.SetTriger(DividendDetail_master.Detail_tableName, "TR_Dividend_Detail_Audit_History", false, Utility.Get_DRWIN_hDB());
                int count = upd.SaveToDB(Utility.Get_DRWIN_hDB());
                Helper_SQLserver.SetTriger(DividendDetail_master.Detail_tableName, "TR_Dividend_Detail_Audit_History", true, Utility.Get_DRWIN_hDB());

                return count;
            }
            else
            {
                int count = upd.SaveToDB(Utility.Get_DRWIN_hDB());
                return count;
            }
        }
    }
}
