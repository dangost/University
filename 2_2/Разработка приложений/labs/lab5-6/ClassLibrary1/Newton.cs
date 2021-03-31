using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace ClassLibrary1
{
    public class Newton : Unit
    {
        public override int PrintIter()
        {
            return Iter;
        }

        public Newton(double start, double end, double step) : base(start, end, step)
        {
        }

        public override double Computation()
        {
            double x = (start + end) / 2, df;
            df = (Function(x + accuracy) - Function(x)) / accuracy;
            while (Math.Abs(Function(x)) > accuracy && Iter < 20000)
            {
                x -= Function(x) / df;
                Iter++;
            }
            return x;
        }

        public override void Drow(Chart chart, int time)
        {
            double x = (start + end) / 2, df;
            df = (Function(x + accuracy) - Function(x)) / accuracy;
            chart.Series[1].ChartType = SeriesChartType.Line;

            timer.Interval = time;
            timer.Tick += (sender, args) =>
            {
                double i = Math.Abs(Function(x));
                if (Math.Abs(Function(x)) < accuracy && Iter < 20000)
                {
                    timer.Stop();
                }
                chart.Series[1].Points.AddXY(x, 0);
                chart.Series[1].Points.AddXY(x, Function(x));
                x -= Function(x) / df;
                Iter++;
            };
            timer.Start();
        }
    }
}
