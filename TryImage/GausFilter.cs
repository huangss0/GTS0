using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;

namespace TryImage
{
    class GausFilter
    {
        public static double[,] GF_v2 =
            { { 2,  4,  5,  4,  2 },
              { 4,  9, 12,  9,  4 },
              { 5, 12, 15, 12,  5 },
              { 4,  9, 12,  9,  4 },
              { 2,  4,  5,  4,  2 } };

        public const double divd = 0.00628930817; // 1.0 / 159;
        public const int edgeSize = 2;
        public const int matrixLen = 5;

        /// <summary>
        /// Apply Gaussian filter on an image
        /// </summary>
        /// <param name="bm">the bit map image to be processed</param>
        /// <param name="gs">gray scale convert, set to null to avoid convert</param>
        /// <returns></returns>
        public static Bitmap Run(Bitmap bm, GrayScale gs)
        {
            if (bm == null) return null;
            Bitmap res = new Bitmap(bm.Width, bm.Height);

            for (int i = GausFilter.edgeSize; i < bm.Width - GausFilter.edgeSize; ++i)
            {
                for (int j = GausFilter.edgeSize; j < bm.Height - GausFilter.edgeSize; ++j)
                {
                    //Calculate for Gaussian filter
                    double red_d = 0, green_d = 0, blue_d = 0;

                    for (int m = 0; m < GausFilter.matrixLen; ++m)
                    {
                        for (int n = 0; n < GausFilter.matrixLen; ++n)
                        {
                            Color old_clr = bm.GetPixel(i - GausFilter.edgeSize + m, j - GausFilter.edgeSize + n);
                            red_d += old_clr.R * GausFilter.GF_v2[m, n];
                            green_d += old_clr.G * GausFilter.GF_v2[m, n];
                            blue_d += old_clr.B * GausFilter.GF_v2[m, n];
                        }
                    }

                    int red_i = (int)(GausFilter.divd * red_d), green_i = (int)(GausFilter.divd * green_d), blue_i = (int)(GausFilter.divd * blue_d);
                    Color new_clr = Color.FromArgb(red_i, green_i, blue_i);
                    if (gs != null) new_clr = gs.GetGrayColor(new_clr);

                    res.SetPixel(i, j, new_clr);
                }
            }

            for (int i = 0; i < bm.Width; ++i)//top and bottom line
            {
                for (int j = 0; j < GausFilter.edgeSize; ++j)
                {
                    Color new_clr = bm.GetPixel(i, j);
                    if (gs != null) new_clr = gs.GetGrayColor(new_clr);
                    res.SetPixel(i, j, new_clr);
                }

                for (int j = bm.Height - GausFilter.edgeSize; j < bm.Height; ++j)
                {
                    Color new_clr = bm.GetPixel(i, j);
                    if (gs != null) new_clr = gs.GetGrayColor(new_clr);
                    res.SetPixel(i, j, new_clr);
                }
            }

            for (int j = GausFilter.edgeSize; j < bm.Height - GausFilter.edgeSize; ++j)//left and right line
            {
                for (int i = 0; i < GausFilter.edgeSize; ++i)
                {
                    Color new_clr = bm.GetPixel(i, j);
                    if (gs != null) new_clr = gs.GetGrayColor(new_clr);
                    res.SetPixel(i, j, new_clr);
                }

                for (int i = bm.Width - GausFilter.edgeSize; i < bm.Width; ++i)
                {
                    Color new_clr = bm.GetPixel(i, j);
                    if (gs != null) new_clr = gs.GetGrayColor(new_clr);
                    res.SetPixel(i, j, new_clr);
                }
            }

            return res;
        }
    }
}
