using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using HssUtility.Text.FixLength;
using System.IO;

namespace DTCC
{
    class DTC_request_file
    {
        private string ftp_UID = "M0475201", data_pwd = "95EC3K";
        public FTPserverType ftpServerTP = FTPserverType.Production;
        public DTCfunction DTCfunc = DTCfunction.OSOLPR;
        public FTPrequestType up_down_ReqTP = FTPrequestType.Input;
        public FTPheaderType headerTP = FTPheaderType.HDR;
        public GroupUserSelCirteria GU_selCir = GroupUserSelCirteria.ALL;
        public string GroupUserParticipantNum = "01234";

        public readonly string seqNum_str = null;

        public DTC_request_file()
        {
            this.seqNum_str = DTC_request_file.GetNext_seqNum(DTC_request_file.SequenceNum);
        }

        public string SignOn
        {
            get { return this.ftp_UID; }
            set
            {
                if (value == null) return;
                if (value.Length == 8) this.ftp_UID = value;
            }
        }

        public string Get_FTP_fileName()
        {
            Line li = new Line();
            li.Add("FTX", 3);
            li.Add(this.ftp_UID.Substring(0, 5), 5);
            li.Add('.');
            if (this.ftpServerTP == FTPserverType.Production) li.Add('P');
            else if (this.ftpServerTP == FTPserverType.Testing) li.Add('U');
            li.Add(this.ftp_UID.Substring(5), 3);
            li.Add('.');
            if (this.up_down_ReqTP == FTPrequestType.Input) li.Add('$');
            li.Add("FTXPBI1");//significant
            li.Add('.');
            if (this.up_down_ReqTP == FTPrequestType.Input) li.Add('$');
            li.Add(this.DTCfunc);
            li.Add('.');
            if (this.up_down_ReqTP == FTPrequestType.Input) li.Add('$');
            li.Add(this.seqNum_str);
            li.Add('.');
            if (this.up_down_ReqTP == FTPrequestType.Input) li.Add('I');
            else if (this.up_down_ReqTP == FTPrequestType.Output) li.Add('O');

            return li.GetStr();
        }

        public string Get_FTP_fileContent_inStr()
        {
            Sheet sheet = new Sheet();

            Line l1 = new Line();
            l1.Add(" ");
            if (this.ftpServerTP == FTPserverType.Production) l1.Add('P');
            else if (this.ftpServerTP == FTPserverType.Testing) l1.Add('T');
            l1.Add("PASSWD");
            l1.Add("01");
            l1.Add("02");
            l1.Add(new string(' ', 6));
            l1.Add(new string(' ', 8));
            l1.Add(this.ftp_UID.Substring(0, 5), 5);
            l1.Add('-');
            l1.Add(this.ftp_UID.Substring(5), 3);
            l1.Add(this.data_pwd, 8, leftJustified: true);
            l1.Add(this.DTCfunc, 6);
            l1.Add(++DTC_request_file.transNum % 10000, 4);
            Cell recordLen_cell = l1.Add(120, 5);//need change in the future

            Line l2 = new Line();
            l2.Add("TD");//request type
            l2.Add(this.DTCfunc, 6);
            l2.Add("01");
            l2.Add(this.headerTP, 3);
            if (this.GU_selCir == GroupUserSelCirteria.ALL) l2.Add("All", 3);
            else if (this.GU_selCir == GroupUserSelCirteria.Single)
            {
                l2.Add("001", 3);
                l2.Add(this.GroupUserParticipantNum, 5);
            }

            sheet.Add(l1);
            sheet.Add(l2);

            recordLen_cell.SetOriVal(sheet.Length);

            return sheet.GetContent();
        }

        public byte[] Get_FTP_fileContent_inBytes()
        {
            string tempStr = this.Get_FTP_fileContent_inStr();
            return Encoding.UTF8.GetBytes(tempStr);
        }

        public Stream Get_FTP_fileContent_inStream()
        {
            MemoryStream ms = new MemoryStream();
            byte[] data = this.Get_FTP_fileContent_inBytes();
            ms.Write(data, 0, data.Length);
            ms.Seek(0, SeekOrigin.Begin);

            return ms;
        }

        /***********************************Static Attributes and Functions***********************************************************/
        public static ulong SequenceNum
        {
            get
            {
                TimeSpan ts = DateTime.Now - new DateTime(2018, 6, 11);
                return (ulong)ts.TotalSeconds;
            }
        }
        private static int transNum = 16;

        public static string GetNext_seqNum(ulong curr)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < 7; i++)
            {
                char c = (char)('A' + curr % 26);
                sb.Insert(0, c);
                curr /= 26;
            }

            return sb.ToString();
        }
    }
}
