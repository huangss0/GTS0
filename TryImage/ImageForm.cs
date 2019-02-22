using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TryImage
{
    public partial class ImageForm : Form
    {
        public ImageForm()
        {
            InitializeComponent();
        }

        public void AddImage(Bitmap bm)
        {
            if (bm == null) return;

            int wd = bm.Width + 15, hi = bm.Height + 40;

            if (wd > 1500) this.Width = 1500;
            else if (wd < 100) this.Width = 100;
            else this.Width = wd;

            if (hi > 900) this.Height = 900;
            else if (hi < 100) this.Height = 100;
            else this.Height = hi;

            this.main_pictureBox.Image = bm;
        }
    }
}
