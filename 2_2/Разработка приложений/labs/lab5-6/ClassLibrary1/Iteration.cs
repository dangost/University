using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace ClassLibrary1
{
    public class Iteration : Unit
    {
        public Iteration(double start, double end, double step) : base(start, end, step)
        {
        }

        public override double Computation()
        {
            double x = (start + end) / 2;
            double eps = accuracy, xLast, dx = double.MaxValue;
            while (Math.Abs(dx) > eps && Iter < 20000)
            {
                xLast = x;
                x = 3 / (x + 2);
                dx = x - xLast;
                Iter++;
            }
            return x;
        }

        public override void Drow(Chart chart, int time)
        {
            chart.Series[1].ChartType = SeriesChartType.StepLine;
            double x = (start + end) / 2;
            double xLast = 0, dx = double.MaxValue;

            timer.Interval = time;
            timer.Tick += (sender, args) =>
            {
                if (Math.Abs(dx) < accuracy && Iter < 20000)
                {
                    timer.Stop();
                }
                chart.Series[1].Points.AddXY(x, Function(x));
                xLast = x;
                x = 3 / (x + 2);
                dx = x - xLast;
                Iter++;
            };
            timer.Start();
        }
    }
}
