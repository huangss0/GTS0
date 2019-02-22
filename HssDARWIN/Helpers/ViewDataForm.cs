using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Infragistics.Win.UltraWinGrid;

using HssUtility.General;

namespace HssDARWIN.Helpers
{
    public partial class ViewDataForm : Form
    {
        public ViewDataForm()
        {
            this.InitializeComponent();
            UltraGrid_helper.InitGrid(this.main_ultraGrid, true, false);
        }

        /*----------------------------------------------------------------------------------------------------------------*/
        public int bytes_per_row = 50;
        private List<int> findText_list = null;
        private int currFind_index = 0;
        public string suggestedFileName_forSave = null;

        public void Set_grid_dataSource(DataTable dt)
        {
            this.main_ultraGrid.DataSource = dt;
            UltraGrid_helper.AutoResize(this.main_ultraGrid);
        }

        public void Set_grid_dataSource(DataSet ds)
        {
            this.main_ultraGrid.DataSource = ds;
            UltraGrid_helper.AutoResize(this.main_ultraGrid);
            this.main_ultraGrid.Rows.ExpandAll(true);
        }

        /// <summary>
        /// Set data source for view byte array
        /// </summary>
        /// <param name="option">0 for row by row view, 1 or 2 for raw view</param>
        public void Set_notePad_dataSource(byte[] arr, ViewDataOption option = ViewDataOption.None)
        {
            if (arr == null) return;
            string str = Encoding.UTF8.GetString(arr);
            this.Set_notePad_dataSource(str);
            
            if (option == ViewDataOption.RawView) this.main_ultraGrid.DataSource = this.Arr_to_rawDT(arr);
            else if (option == ViewDataOption.Row_by_Row) this.main_ultraGrid.DataSource = this.Arr_to_lineDT(str);
            else if (option == ViewDataOption.RawView_str || option == ViewDataOption.RawView_strLine)
                this.main_ultraGrid.DataSource = this.Arr_to_strDT(str, option);
        }

        /// <summary>
        /// Set data source for view string
        /// </summary>
        public void Set_notePad_dataSource(string str)
        {
            StringBuilder sb = new StringBuilder(str);
            for (int i = 1; i < sb.Length - 1; ++i)
            {
                char c = sb[i];
                if (c == '\n')
                {
                    if (sb[i - 1] != '\r')
                    {
                        sb.Insert(i, '\r');
                        ++i;
                    }
                }
                else if (c == '\r')
                {
                    if (sb[i + 1] != '\n')
                    {
                        sb.Insert(i + 1, '\n');
                        ++i;
                    }
                }
            }

            this.main_richTextBox.Text = sb.ToString();
            this.main_tabControl.SelectedTab = this.notepad_tabPage;
        }

        /// <summary>
        /// Convert byte array to DataTable in string view
        /// </summary>
        /// <param name="option">2 for show '\r' and '\n'</param>
        private DataTable Arr_to_strDT(string str, ViewDataOption option)
        {
            DataTable dt = new DataTable();
            if (str == null) return dt;

            for (int i = 0; i < this.bytes_per_row; ++i) dt.Columns.Add("" + i);

            DataRow row = null;
            for (int i = 0; i < str.Length; ++i)
            {
                int id = i % this.bytes_per_row;
                if (id == 0) row = dt.Rows.Add();

                if (option == ViewDataOption.RawView_strLine)
                {
                    char c = str[i];
                    if (c == '\n') row[id] = "\\n";
                    else if (c == '\r') row[id] = "\\r";
                    else row[id] = c;
                }
                else row[id] = str[i];
            }
            return dt;
        }

        /// <summary>
        /// Convert byte array to DataTable in raw byte view
        /// </summary>
        private DataTable Arr_to_rawDT(byte[] arr)
        {
            DataTable dt = new DataTable();
            if (arr == null) return dt;

            for (int i = 0; i < this.bytes_per_row; ++i) dt.Columns.Add("" + i);

            DataRow row = null;
            for (int i = 0; i < arr.Length; ++i)
            {
                int id = i % this.bytes_per_row;
                if (id == 0) row = dt.Rows.Add();

                row[id] = arr[i];
            }
            return dt;
        }

        /// <summary>
        /// Convert byte array to DataTable row by row
        /// </summary>
        private DataTable Arr_to_lineDT(string str)
        {
            DataTable dt = new DataTable();
            if (str == null) return dt;

            DataRow row = dt.Rows.Add();

            int currID = 0;
            for (int i = 0; i < str.Length; ++i)
            {
                char c = str[i];
                if (c == '\n' || c == '\r')
                {
                    if (currID > 0)
                    {
                        row = dt.Rows.Add();
                        currID = 0;
                    }
                    continue;
                }

                if (currID >= dt.Columns.Count) dt.Columns.Add("" + currID);

                row[currID] = c;
                ++currID;
            }
            return dt;
        }
        /*^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^*/

        private void main_ultraGrid_InitializeLayout(object sender, InitializeLayoutEventArgs e)
        {
            UltraGrid_helper.AutoResize(this.main_ultraGrid);
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Text|*.txt|XML|*.xml";
            sfd.FileName = this.suggestedFileName_forSave;

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                byte[] buffer = Encoding.UTF8.GetBytes(this.main_richTextBox.Text);
                FileStream fs = new FileStream(sfd.FileName, FileMode.Create);
                fs.Write(buffer, 0, buffer.Length);
                fs.Close();

                MessageBox.Show("Saved");
            }
        }

        private void find_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13 || e.KeyChar == 10)
            {
                string toFind = this.find_textBox.Text;
                if (toFind.Length < 1) return;

                string allText = this.main_richTextBox.Text;
                if (this.findText_list == null) this.findText_list = HssStr.FindAll_substrings(allText, toFind, false);

                if (this.findText_list.Count < 1) MessageBox.Show("No Match");
                else
                {
                    this.main_richTextBox.Select(this.findText_list[this.currFind_index], toFind.Length);
                    if (++this.currFind_index >= this.findText_list.Count) this.currFind_index = 0;
                }
            }
        }

        private void find_textBox_TextChanged(object sender, EventArgs e)
        {
            this.findText_list = null;
            this.currFind_index = 0;
        }
    }

    public enum ViewDataOption
    {
        None = -1,

        Row_by_Row = 0,
        RawView = 1,
        RawView_strLine = 2,
        RawView_str = 3,
    }
}
