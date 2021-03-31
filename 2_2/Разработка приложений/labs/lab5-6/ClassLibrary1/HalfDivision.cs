using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace ClassLibrary1
{
    public class HalfDivision : Unit
    {
        public HalfDivision(double start, double end, double step) : base(start, end, step)
        {
        }

        public override double Computation()
        {
            double left = start;
            double rigth = end;
            double c = 0;
            while ((rigth - left) / 2 > accuracy && Iter < 20000)
            {
                c = (left + rigth) / 2;
                if ((Function(left) * Function(c)) > 0) left = c;
                else rigth = c;
                Iter++;
            }
            return c;
        }


        public override void Drow(Chart chart, int time)
        {
            double left = start;
            double rigth = end;
            double x1, x2 = 0;
            double c = 0;
            chart.Series[1].ChartType = SeriesChartType.Column;

            timer.Interval = time;
            timer.Tick += (sender, args) =>
            {
                bool f = Iter < 20000;
                bool b = (rigth - left) / 2 < accuracy;
                if ((rigth - left) / 2 < accuracy && Iter < 20000)
                {
                    timer.Stop();
                }
                c = (left + rigth) / 2;
                x1 = c;
                if ((Function(left) * Function(c)) > 0) left = c;
                else rigth = c;
                chart.Series[1].Points.AddXY(x1, Function(x1));
                Iter++;
                x2 = c;
            };
            timer.Start();
        }
    }
}
