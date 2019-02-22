using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TryImage
{


    public partial class ControlForm : Form
    {
        public ControlForm()
        {
            InitializeComponent();
        }

        private GrayScale gs = new GrayScale();

        private void gray_button_Click(object sender, EventArgs e)
        {
            this.OpenImg("gray");
        }

        private void gaussian_button_Click(object sender, EventArgs e)
        {
            this.OpenImg("gaussian");
        }

        private void OpenImg(string func)
        {
            if (this.openFileDialog.ShowDialog() == DialogResult.OK)
            {
                this.SetGrayWeights();
                string path = this.openFileDialog.FileName;
                FileInfo fi = new FileInfo(path);
                Bitmap bm = new Bitmap(path);

                ImageForm imFm = new ImageForm();
                imFm.Text = fi.Name;

                if (func.Equals("gray", StringComparison.OrdinalIgnoreCase)) imFm.AddImage(this.gs.Run(bm));
                else if (func.Equals("gaussian", StringComparison.OrdinalIgnoreCase))
                {
                    if (this.gausGray_checkBox.Checked) imFm.AddImage(GausFilter.Run(bm, this.gs));
                    else imFm.AddImage(GausFilter.Run(bm, null));
                }
                else imFm.AddImage(bm);

                imFm.Show();
            }
        }

        private bool SetGrayWeights()
        {
            double redPct = (double)this.red_numericUpDown.Value / 100;
            double greenPct = (double)this.green_numericUpDown.Value / 100;
            double bluePct = (double)this.blue_numericUpDown.Value / 100;

            if (!this.gs.SetWeights(redPct, greenPct, bluePct))
            {
                MessageBox.Show("Error in setting Gray Scale weights");
                return false;
            }
            else return true;
        }

        private void test_button_Click(object sender, EventArgs e)
        {
            string s1 = "d", s2 = "a";
            MessageBox.Show(HssUtility.General.HssStr.WordDistance(s1, s2).ToString());
        }
    }
}
