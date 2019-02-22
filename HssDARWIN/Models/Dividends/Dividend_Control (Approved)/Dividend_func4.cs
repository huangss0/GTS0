using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Windows.Forms;

using HssDARWIN.Models.DTC_Position;
using HssDARWIN.SubProjects.SPR_Report;
using HssDARWIN.Models.DTC_Participant;
using HssDARWIN.Models.DTC_Model;
using HssUtility.SQLserver;
using HssUtility.General;

namespace HssDARWIN.Models.Dividends
{
    public partial class Dividend
    {
        public DTCPositionModelNumber_Mapping Get_DTCpos_model()
        {
            DTCPositionModelNumber_Mapping posMod = DTC_model_master.GetMapping_modelNum(this.DTCPosition_ModelNumber.Value);
            if (posMod != null) posMod.Create_headers();
            return posMod;
        }

        /// <summary>
        /// Insert DTC Position using dataSet read from DES document
        /// </summary>
        public void Insert_DTC_position(DataSet ds, bool createNew_flag = true)
        {
            if (ds == null || ds.Tables.Count < 1) return;
            if (createNew_flag) this.Delete_DTC_position();

            DataTable dt = ds.Tables[0];

            HashSet<string> colName_hs = new HashSet<string>();
            foreach (DataColumn col in dt.Columns) colName_hs.Add(col.ColumnName);

            DTCPositionModelNumber_Mapping posMod = this.Get_DTCpos_model();
            if (posMod == null) return;
            Dictionary<int, List<string>> mapping = posMod.Get_colHeader_mapping(colName_hs);

            Bulk_DBcmd buk_ins = new Bulk_DBcmd();
            foreach (DataRow row in dt.Rows)
            {
                Position dtcPos = new Position();
                dtcPos.DividendIndex = this.DividendIndex;

                dtcPos.DTC_Number = row["DTC Participant No."].ToString();
                if (string.IsNullOrEmpty(dtcPos.DTC_Number)) continue;

                dtcPos.Company_Name = row["DTC Participant Name"].ToString();

                decimal tempDecimal = -1;
                if (decimal.TryParse(row["R/D Position"].ToString(), out tempDecimal)) dtcPos.Total_RecDate_Position = tempDecimal;

                foreach (KeyValuePair<int, List<string>> pair in mapping)
                {
                    List<string> lst = pair.Value;
                    if (lst.Count > 0) dtcPos.RatePositions.Set_rateValue(pair.Key, row[lst[0]].ToString());
                    if (lst.Count > 1) dtcPos.Rate_Chargebacks.Set_rateValue(pair.Key, row[lst[1]].ToString());
                }

                buk_ins.Add_DBcmd(dtcPos.Get_DBinsert());
            }

            int count = buk_ins.SaveToDB(Utility.Get_DRWIN_hDB());
        }

        public void Delete_DTC_position()
        {
            if (this.DividendIndex < 0) return;

            DB_delete del = new DB_delete();
            del.tableName = "Dividend_DTC_Position";
            SQL_relation rela = new SQL_relation("DividendIndex", RelationalOperator.Equals, this.DividendIndex);
            del.SetCondition(rela);

            int count = del.SaveToDB(Utility.Get_DRWIN_hDB());
        }

        public List<Dividend_DTC_Position> Get_DTCposition_list()
        {
            List<Dividend_DTC_Position> lst = new List<Dividend_DTC_Position>();
            
            DB_select selt = new DB_select(Dividend_DTC_Position.Get_cmdTP());
            SQL_relation rela = new SQL_relation("DividendIndex", RelationalOperator.Equals, this.DividendIndex);
            selt.SetCondition(rela);

            DB_reader reader = new DB_reader(selt, Utility.Get_DRWIN_hDB());
            while (reader.Read())
            {
                Dividend_DTC_Position pos = new Dividend_DTC_Position();
                pos.Init_from_reader(reader);
                lst.Add(pos);
            }
            reader.Close();

            return lst;
        }

        /// <summary>
        /// Insert DTC Position using SPR file from DTCC
        /// </summary>
        /// <param name="sf">SPR file</param>
        /// <param name="createNew_flag">append or create new</param>
        public bool Insert_DTC_position(SPR_file sf, bool createNew_flag = true)
        {
            if (sf == null || sf.FileBinary == null)
            {
                MessageBox.Show("Dividend_func4 error 0: No SPR data");
                return false;
            }

            MemoryStream ms = new MemoryStream(sf.FileBinary);
            StreamReader sr = new StreamReader(ms);

            if (createNew_flag) this.Delete_DTC_position();

            List<Position> posList = new List<Position>();
            string str = null;
            while ((str = sr.ReadLine()) != null)
            {
                if (str.Length <= 37) continue;

                char recordType_char = str[SPR_fileControl.RecordTypeChar_index];
                if (recordType_char != '2') continue; //'2' stands for detail records

                if (str.StartsWith("HDR", StringComparison.OrdinalIgnoreCase)) continue;
                if (str.StartsWith("TRL", StringComparison.OrdinalIgnoreCase)) break;

                Position dtcPos = new Position();
                dtcPos.DividendIndex = this.DividendIndex;

                dtcPos.DTC_Number = str.Substring(19, 8).TrimStart('0');
                dtcPos.Company_Name = str.Substring(27, 10).Trim();

                string totalPos_str = str.Substring(37).Trim();
                decimal tempDecimal = -1;
                if (decimal.TryParse(totalPos_str, out tempDecimal)) dtcPos.Total_RecDate_Position = tempDecimal;

                posList.Add(dtcPos);
            }

            ParticipantMaster pcMaster = new ParticipantMaster();
            pcMaster.Init_from_dtcPosList(posList);

            Bulk_DBcmd buk_ins = new Bulk_DBcmd();
            List<DTC_Participants> missing_DCTpart_list = new List<DTC_Participants>();

            foreach (Position pos in posList)
            {
                Participant pt = pcMaster.GetParticipant(pos.DTC_Number);
                if (pt == null)
                {
                    DTC_Participants dtcPart = new DTC_Participants();

                    int tempInt = -1;
                    if (!int.TryParse(pos.DTC_Number, out tempInt)) continue;
                    dtcPart.DTC = tempInt;

                    dtcPart.DTC_Number.Value = pos.DTC_Number;
                    dtcPart.Company_Name.Value = pos.Company_Name;

                    missing_DCTpart_list.Add(dtcPart);
                }
                else pos.Company_Name = pt.Company_Name;//if exist, change the name to what we have in [DTC_Participants]

                buk_ins.Add_DBcmd(pos.Get_DBinsert());
            }

            int count0 = buk_ins.SaveToDB(Utility.Get_DRWIN_hDB());
            int count1 = DTC_Participants_master.Insert_DTC_Participants(missing_DCTpart_list);

            return true;
        }
    }
}
