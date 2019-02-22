using System;
using System.IO;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

using HssUtility.DataSource;

namespace WatcherForm
{
    public partial class FileForm : Form
    {
        public FileForm()
        {
            this.InitializeComponent();

            this.sourceDT = new DataTable();
            this.sourceDT.Columns.Add("Name");
            this.sourceDT.Columns.Add("Date");
            this.sourceDT.Columns.Add("Size");
            this.sourceDT.Columns.Add("Button");

            this.main_ultraGrid.DataSource = this.sourceDT;
        }

        private DataTable sourceDT = null;
        private I_FileSource remoteSource = null;

        public void Set_rmSource(I_FileSource source)
        {
            this.remoteSource = source;
        }

        public void Init_fileList(List<File_info> fi_list, string dir = "")
        {
            if (fi_list == null) return;
            else this.sourceDT.Clear();

            foreach (File_info fi in fi_list)
            {
                DataRow row = this.sourceDT.Rows.Add();

                if (string.IsNullOrEmpty(dir)) row["Name"] = dir.Trim('\'') + '.' + fi.fileName;
                else row["Name"] = dir.Trim('\'') + '.' + fi.fileName;

                row["Date"] = fi.mod_time;
                row["Size"] = fi.size;

                if (fi.fileName.EndsWith(".O", StringComparison.OrdinalIgnoreCase)) row["Button"] = "Open";
            }
        }

        private void Main_ultraGrid_InitializeLayout(object sender, Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs e)
        {
            e.Layout.Bands[0].Columns["Name"].Width = 300;
            e.Layout.Bands[0].Columns["Date"].Width = 150;

            e.Layout.Bands[0].Columns["Button"].Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Button;
            e.Layout.Bands[0].Columns["Button"].CellAppearance.BackColor = Color.LightGray;

            foreach (Infragistics.Win.UltraWinGrid.UltraGridBand db in e.Layout.Bands)
            {
                foreach (Infragistics.Win.UltraWinGrid.UltraGridColumn cl in db.Columns)
                {
                    cl.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly;
                }
            }
        }

        private void search_button_Click(object sender, EventArgs e)
        {
            DataTable dt = sourceDT.Clone();
            string filter_str = this.search_textBox.Text;

            foreach (DataRow row in this.sourceDT.Rows)
            {
                string name = row["Name"].ToString();
                if (name.ToUpper().Contains(filter_str.ToUpper()))
                {
                    DataRow newRow = dt.Rows.Add();
                    newRow.ItemArray = row.ItemArray;
                }
            }

            this.main_ultraGrid.DataSource = dt;
        }

        private void search_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) this.search_button_Click(null, null);
        }

        private void main_ultraGrid_ClickCellButton(object sender, Infragistics.Win.UltraWinGrid.CellEventArgs e)
        {
            if (e.Cell.Value.ToString().Equals("Open", StringComparison.InvariantCultureIgnoreCase))
            {
                if (this.remoteSource == null) return;
                string fileName = "'" + e.Cell.Row.Cells["Name"].Value.ToString() + "'";

                if (this.svFileDia.ShowDialog() == DialogResult.OK)
                {
                    FileStream fs = new FileStream(this.svFileDia.FileName, FileMode.Create);
                    this.remoteSource.DownloadFile(fileName, fs);
                    fs.Close();
                }
            }
        }
    }
}
