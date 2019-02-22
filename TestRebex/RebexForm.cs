using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Rebex.Net;
using System.IO;
using System.Threading.Tasks;

namespace TestRebex
{
    public partial class RebexForm : Form
    {
        public RebexForm()
        {
            InitializeComponent();
        }

        private Ftp ftp = new Ftp();

        private void show_button_Click(object sender, EventArgs e)
        {
            if (!this.ftp.IsConnected)
            {
                MessageBox.Show("Not connected");
                return;
            }

            Task tsk = new Task(this.ShowFiles);
            tsk.Start();
        }

        private void upload_button_Click(object sender, EventArgs e)
        {
            if (!this.ftp.IsConnected)
            {
                MessageBox.Show("Not connected");
                return;
            }

            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string path = this.openFileDialog1.FileName;
                FileInfo fi = new FileInfo(path);
                FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
                this.info_textBox.AppendText("File uploaded: " + fi.Name + "(" + this.ftp.PutFile(fs, fi.Name) + ")");
                fs.Close();

                this.ShowFiles();
            }
        }

        private void conn_button_Click(object sender, EventArgs e)
        {
            if (this.ftp.IsConnected)
            {
                this.info_textBox.AppendText(this.ftp.Disconnect());
                this.conn_button.Text = "Connect";
                return;
            }

            string uri = "ftp://" + this.server_textBox.Text;
            string username = this.user_textBox.Text;
            string password = this.pwd_textBox.Text;

            try
            {
                this.info_textBox.AppendText(this.ftp.Connect(uri));
                this.info_textBox.AppendText(this.ftp.Login(username, password));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return;
            }

            this.conn_button.Text = "Disconnect";
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.ftp.IsConnected) this.ftp.Disconnect();
        }

        private void ShowFiles()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Type");
            dt.Columns.Add("Name");
            dt.Columns.Add("Mod Date");
            dt.Columns.Add("Size", typeof(int));

            FtpItemCollection list = null;

            try { list = this.ftp.GetList(); }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return;
            }
            
            foreach (FtpItem item in list)
            {
                DataRow row = dt.Rows.Add();

                if (item.IsSymlink) row["Type"] = "SysLink";
                else if (item.IsDirectory) row["Type"] = "Dir";
                else row["Type"] = "File";

                row["Name"] = item.Name;
                row["Mod Date"] = item.Modified;
                row["Size"] = item.Length;
            }

            this.main_ultraGrid.DataSource = dt;
        }

        private void main_ultraGrid_InitializeLayout(object sender, Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs e)
        {
            e.Layout.Bands[0].Columns[1].Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Button;
            e.Layout.Bands[0].Columns[1].ButtonDisplayStyle = Infragistics.Win.UltraWinGrid.ButtonDisplayStyle.Always;
        }
    }
}
