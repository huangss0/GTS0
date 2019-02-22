using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TryImage
{
    class GrayScale
    {
        public Bitmap Run(Bitmap bm)
        {
            if (bm == null) return null;
            Bitmap res = new Bitmap(bm.Width, bm.Height);

            for (int i = 0; i < bm.Width; ++i)
            {
                for (int j = 0; j < bm.Height; ++j)
                {
                    Color old_clr = bm.GetPixel(i, j);
                    res.SetPixel(i, j, this.GetGrayColor(old_clr));
                }
            }

            return res;
        }

        private double rPct = 0.3, gPct = 0.59, bPct = 0.11;

        public double RedWeight { get { return this.rPct; } }
        public double GreenWeight { get { return this.gPct; } }
        public double BlueWeight { get { return this.bPct; } }

        public bool SetWeights(double redPct, double greenPct, double bluePct)
        {
            if (redPct < 0 || greenPct < 0 || bluePct < 0) return false;
            if (redPct + greenPct + bluePct > 1.0) return false;

            this.rPct = redPct;
            this.gPct = greenPct;
            this.bPct = bluePct;

            return true;
        }

        public Color GetGrayColor(Color clr)
        {
            double dval = this.rPct * clr.R + this.gPct * clr.G + this.bPct * clr.B;
            int ival = (int)(dval + 0.5);

            return Color.FromArgb(ival, ival, ival);
        }
    }
}
