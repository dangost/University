using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

using Timer = System.Windows.Forms.Timer;

namespace ClassLibrary1
{
    public abstract class Unit
    {
        public float GRAPHIC_ACCURACY = 0.1f; //less number -> better accuracy
        public float BORDER_OFFSET = 0.2f;
        protected double start;
        protected double end;
        protected double accuracy;
        protected int iter = 0;
        protected Timer timer = new Timer();

        public abstract double Computation();
        public abstract void Drow(Chart chart, int time);

        public virtual int PrintIter()
        {
            return 0;
        }

        public int Iter { get => iter; set => iter = value; }

        public Unit(double start, double end, double accuracy)
        {
            this.start = start;
            this.end = end;
            this.accuracy = accuracy;
        }

        public double Function(double x)
        {
            return x * x + 7 - (Math.Pow(x, 4) + 3) / (Math.Pow(x, 2) + 4);
        }

        public void BuildLine(Chart chart)
        {
            int count = (int)Math.Ceiling((end + 2 * BORDER_OFFSET - start) / GRAPHIC_ACCURACY) + 1; //точность (плавность) графика

            double[] x = new double[count];
            double[] y = new double[count];

            for (int i = 0; i < count; i++)
            {
                x[i] = Math.Round(start - BORDER_OFFSET + GRAPHIC_ACCURACY * i, 2);
                y[i] = Math.Round(Function(x[i]), 5);
            }
            chart.Series["Function"].Points.DataBindXY(x, y);
            chart.ChartAreas.Clear();
            ChartArea area = new ChartArea();

            area.AxisX.Minimum = start - BORDER_OFFSET;  // Задаём левую и 
            area.AxisX.Maximum = end + BORDER_OFFSET;  // правую границы оси X

            area.AxisX.MajorGrid.Interval = end - start; //шаг сетки
            area.AxisX.MajorGrid.IntervalOffset = BORDER_OFFSET; //шаг сетки

            area.AxisX.LabelStyle.Interval = end - start;
            area.AxisX.LabelStyle.IntervalOffset = BORDER_OFFSET;
            area.AxisX.LabelStyle.Format = "0.00";

            area.AxisY.MajorGrid.LineDashStyle = ChartDashStyle.Dash;
            area.AxisX.MajorGrid.LineDashStyle = ChartDashStyle.Dash;

            chart.ChartAreas.Add(area);
        }
    }
}
