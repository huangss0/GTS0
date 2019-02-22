using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ML_Info_Graphic
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            this.InitializeComponent();
            //for (int i = 0; i < this.main_chart.Series.Count; ++i) this.main_chart.Series[i].Points.Clear();
        }

        private void open_button_Click(object sender, EventArgs e)
        {
            //this.Init_chart(this.Get_Data0());
            this.Init_chart(this.Get_Data1());
        }

        private List<ChartValuePoint> Get_Data0()
        {
            List<ChartValuePoint> list = new List<ChartValuePoint>();
            Random rd = new Random();

            for (int i = 0; i < 5000; ++i)
            {
                double r2 = rd.NextDouble() * 2500;
                double r = rd.NextDouble() * 50;
                double w = rd.NextDouble() * Math.PI * 2;
                double x = r * Math.Sin(w), y = r * Math.Cos(w);

                ChartValuePoint cvp = new ChartValuePoint(0, x + 50, y + 50);
                list.Add(cvp);
            }

            return list;
        }

        private List<ChartValuePoint> Get_Data1()
        {
            List<double> val_list = new List<double>();
            for (int i = 0; i < 100; ++i) val_list.Add(0);

            Random rd = new Random();

            for (int i = 0; i < 3000; ++i)
            {
                double r = rd.NextDouble() * 50;
                double w = rd.NextDouble() * Math.PI * 2;
                double x = r * Math.Sin(w) + 50;

                int index = (int)x;

                ++val_list[index];
            }

            List<ChartValuePoint> point_list = new List<ChartValuePoint>();
            for (int i = 0; i < val_list.Count; ++i)
            {
                ChartValuePoint cvp = new ChartValuePoint(1, 1.0 * i, val_list[i]);
                point_list.Add(cvp);
            }

            return point_list;
        }

        private void Init_chart(List<ChartValuePoint> list)
        {
            foreach (ChartValuePoint cvp in list)
            {
                this.main_chart.Series[cvp.series].Points.AddXY(cvp.X, cvp.Y);
            }
        }
    }

    class ChartValuePoint
    {
        public int series = -1;
        public double X = 0, Y = 0;

        public ChartValuePoint(int tp, double x, double y)
        {
            this.series = tp;
            this.X = x;
            this.Y = y;
        }
    }
}
