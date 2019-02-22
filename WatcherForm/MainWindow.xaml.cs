using System;
using System.IO;
using System.Text;
using System.Windows;
using System.Collections.Generic;

using DTCC;
using HssUtility.Debug;
using HssUtility.DataSource;

namespace WatcherForm
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            this.InitializeComponent();
        }

        private I_FileSource remoteSource = new HssUtility.DataSource.FTP.RebexFTP();
        private bool ftpLoggedIn_flag = false;

        private DTC_request_file df = null;

        private void login_btn_Click(object sender, RoutedEventArgs e)
        {
            if (!this.ftpLoggedIn_flag)
            {
                string url = this.url_textBox.Text;
                string uID = this.userName_textBox.Text, pwd = this.pwd_textBox.Text;

                this.remoteSource.SetErrorLog(new HssConsoleDebug());
                this.ftpLoggedIn_flag = this.remoteSource.Login(url, uID, pwd);

                if (this.ftpLoggedIn_flag) this.info_textBox.Text += "Success login: " + url + "\r\n";
                else this.info_textBox.Text += "Fail in login\r\n";
            }
            /*GTShss02/GTShss03/GTShss03*/
        }

        private void upload_button_Click(object sender, RoutedEventArgs e)
        {
            if (!this.ftpLoggedIn_flag)
            {
                MessageBox.Show("Not logged in yet");
                return;
            }
            else if (string.IsNullOrEmpty(this.upFile_textBox.Text))
            {
                MessageBox.Show("No upload file name");
                return;
            }

            Stream sm = this.df.Get_FTP_fileContent_inStream();
            long len = this.remoteSource.UploadFile(this.upFile_textBox.Text, sm);

            if (len >= 0) this.info_textBox.AppendText("Upload success, (size: " + len + ")\r\n");
            else this.info_textBox.AppendText("Upload fail " + len + "\r\n");
        }

        private void download_button_Click(object sender, RoutedEventArgs e)
        {
            if (!this.ftpLoggedIn_flag)
            {
                MessageBox.Show("Not logged in yet");
                return;
            }
            else if (string.IsNullOrEmpty(this.downFile_textBox.Text))
            {
                MessageBox.Show("No download file name");
                return;
            }

            MemoryStream ms = new MemoryStream();
            long len = this.remoteSource.DownloadFile(this.downFile_textBox.Text, ms);

            string tempStr = "Download: " + this.downFile_textBox.Text + " (size " + len + ")\r\n";
            this.info_textBox.AppendText(tempStr);

            if (len < 0) return;
            else ms.Seek(0, SeekOrigin.Begin);

            byte[] buffer = new byte[len];
            ms.Read(buffer, 0, buffer.Length);

            System.Windows.Forms.SaveFileDialog sfd = new System.Windows.Forms.SaveFileDialog();
            sfd.Filter = "Text | *.txt";

            if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                FileStream fs = new FileStream(sfd.FileName, FileMode.Create);
                fs.Write(buffer, 0, buffer.Length);
                fs.Close();
                MessageBox.Show("Saved");
            }
        }

        private void createFile_button_Click(object sender, RoutedEventArgs e)
        {
            this.df = new DTC_request_file();
            this.df.up_down_ReqTP = FTPrequestType.Input;
            this.df.DTCfunc = DTCfunction.OSOLPR;
            this.upFile_textBox.Text = "'" + this.df.Get_FTP_fileName() + "'";

            this.df.up_down_ReqTP = FTPrequestType.Output;
            this.downFile_textBox.Text = "'" + this.df.Get_FTP_fileName() + "'";

            if (this.out_textBox.IsChecked == true)
            {
                FileStream fs = new FileStream(@"C:\Users\SHuang\Desktop\uploaded.txt", FileMode.Create);
                byte[] buffer = df.Get_FTP_fileContent_inBytes();
                fs.Write(buffer, 0, buffer.Length);
                fs.Close();
            }
        }

        private void listFiles_button_Click(object sender, RoutedEventArgs e)
        {
            if (!this.ftpLoggedIn_flag)
            {
                MessageBox.Show("Not logged in yet");
                return;
            }

            List<File_info> infoList = this.remoteSource.GetFilesList(this.dir_textBox.Text);
            this.info_textBox.AppendText("File count: " + infoList.Count + "\r\n");

            FileForm ff = new FileForm();
            ff.Set_rmSource(this.remoteSource);
            ff.Init_fileList(infoList, this.dir_textBox.Text);
            ff.Show();
        }
    }
}
