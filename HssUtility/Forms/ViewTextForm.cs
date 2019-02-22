using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.IO;
using System.Windows.Forms;

using HssUtility.General;

namespace HssUtility.Forms
{
    public partial class ViewTextForm : Form
    {
        public ViewTextForm()
        {
            this.InitializeComponent();
        }

        private string oriText_str = "", currText_str = "";
        private bool textDiff_flag = false;

        private List<int> findText_list = null;
        private int currFind_index = 0;

        public void NotePad_SetData(string str)
        {
            this.oriText_str = str;
            this.currText_str = str;
            this.main_richTextBox.Text = str;
        }

        public void GridView_SetData(DataTable dt)
        {
            this.main_ultraGrid.DataSource = dt;
        }

        public bool TextChanged_flag { get { return this.textDiff_flag; } }
        public string NewText_str { get { return this.currText_str; } }

        /*---------------------------------------------------------------------------------------------------------*/

        private void commit_button_Click(object sender, EventArgs e)
        {
            this.currText_str = this.main_richTextBox.Text;
            this.textDiff_flag = this.oriText_str.Equals(this.currText_str);
            this.Close();
        }

        private void find_textBox_TextChanged(object sender, EventArgs e)
        {
            this.findText_list = null;
            this.currFind_index = 0;
        }

        private void saveAs_button_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Text|*.txt|XML|*.xml";
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
    }
}
