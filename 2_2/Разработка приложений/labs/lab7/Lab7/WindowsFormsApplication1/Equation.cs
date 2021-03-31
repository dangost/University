using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace WindowsFormsApplication1
{
    class Equation
    {
        protected double a; //нижний предел интегрирования
        protected double b; //верхний предел интегрирования
        protected Label label;
        //private double c = 1;
        protected double h = 0.05;
        protected double x0;
        protected double y0;
        unsafe List<double> xValues = new List<double>();
        unsafe List<double> yValues = new List<double>(); // объявление списков

        public virtual double f(double x, double y) { return Math.Sin(x) * y; }

        public double X0
        {
            get => x0;
            set => x0 = value;
        }
        public double Y0
        {
            get => y0;
            set => y0 = value;
        }
        public double A
        {
            get => a;
            set => a =value;
        }
        public double B
        {
            get => b;
            set => b = value;
        }
        public double H
        {
            get => h;
            set => h = value;
        }
      

        public Equation(double a, double b, double h, Label label)
        {
            this.a = a;
            this.b = b;
            this.h = h;
            this.label = label;
        }

        public Equation(double h, Label label)
        {
            this.h = h;
            this.label = label;
        }

        public void Eiler()
        {
            double x = x0;
            double y = y0;
            int iteration = 0;
            xValues.Clear();
            yValues.Clear();
            xValues.Add(x);
            yValues.Add(y);
            for (double i = a; i <= b; i += h)
            {
                iteration++;
                y = y + h * f(x, y);
                x += h;
                xValues.Add(x); // записывают данные в список x и у
                yValues.Add(y);
            }
        }

        public void usov_Eiler()
        {
            double x = x0;
            double y = y0;
            int iteration = 0;
            xValues.Clear();
            yValues.Clear();
            xValues.Add(x);
            yValues.Add(y);
            for (double i = a; i <= b; i += h)
            {
                iteration++;
                y = y + h * f(x + h / 2, y + h / 2 * f(x, y));
                x += h;
                xValues.Add(x);
                yValues.Add(y);
            }
        }

        public void Runge_Kutta_4()
        {
            double x = x0;
            double y = y0;
            double k1, k2, k3, k4;
            int iteration = 0;
            xValues.Clear();
            yValues.Clear();
            xValues.Add(x);
            yValues.Add(y);
            for (double i = a; i <= b; i += h)
            {
                iteration++;
                k1 = f(x, y);
                k2 = f(x + h / 2, y + k1 / 2);
                k3 = f(x + h / 2, y + k2 / 2);
                k4 = f(x + h, y + k3);
                y = y + h / 6 * (k1 + 2 * k2 + 2 * k3 + k4);
                x += h;
                xValues.Add(x);
                yValues.Add(y);
            }
        }

        public void Runge_Kutta_3()
        {
            double x = x0;
            double y = y0;
            double k1, k2, k3;
            int iteration = 0;
            xValues.Clear();
            yValues.Clear();
            xValues.Add(x);
            yValues.Add(y);
            for (double i = a; i <= b; i += h)
            {
                iteration++;
                k1 = f(x, y);
                k2 = f(x + h / 2, y + k1 / 2);
                k3 = f(x + h, y + 2 * k2 - k1);
                y = y + h / 6 * (k1 + 4 * k2 + k3);
                x += h;
                xValues.Add(x);
                yValues.Add(y);
            }
        }

        public void Eiler_draw(System.Windows.Forms.DataVisualization.Charting.Series series)
        {
            double x = x0;
            double y = y0;
            series.Points.AddXY(x, y);
            for (double i = a; i <= b; i+=h)
            {
                y = y + h * f(x, y);
                x += h;
                series.Points.AddXY(x, y);
            }
        }

        public void usov_Eiler_draw(System.Windows.Forms.DataVisualization.Charting.Series series)
        {
            double x = x0;
            double y = y0;
            series.Points.AddXY(x, y);
            for (double i = a; i <= b; i += h)
            {
                y = y + h*f(x + h/2, y+h/2 * f(x,y));
                x += h;
                series.Points.AddXY(x, y);
            }
        }

        public void Runge_Kutta_4_draw(System.Windows.Forms.DataVisualization.Charting.Series series)
        {
            double x = x0;
            double y = y0;
            series.Points.AddXY(x, y);
            double k1, k2, k3, k4;
            for (double i = a; i <= b; i += h)
            {
                k1 = f(x, y);
                k2 = f(x + h/2, y + k1 / 2);
                k3 = f(x + h/2, y + k2 / 2);
                k4 = f(x + h, y + k3);
                y = y + h/6 * (k1 + 2*k2 + 2*k3 + k4);
                x += h;
                series.Points.AddXY(x, y);
            }
        }

        public void Runge_Kutta_3_draw(System.Windows.Forms.DataVisualization.Charting.Series series)
        {
            double x = x0;
            double y = y0;
            series.Points.AddXY(x, y);
            double k1, k2, k3;
            for (double i = a; i <= b; i += h)
            {
                k1 = f(x, y);
                k2 = f(x + h / 2, y + k1 / 2);
                k3 = f(x + h, y + 2 * k2 - k1);
                y = y + h / 6 * (k1 + 4 * k2 + k3);
                x += h;
                series.Points.AddXY(x, y);
            }
        }


        public void addData(DataGridView grid)
        {
            grid.Columns.Clear();
            grid.Rows.Clear();
            for (int i = 0; i < xValues.Count; i++)
            {
                grid.Columns.Add("n" + i, "n" + i);
            }
            grid.Rows.Add();
            grid.Rows.Add();
            for (int i = 0; i < xValues.Count; i++)
            {
                grid[i, 0].Value = xValues[i];
                grid[i, 1].Value = yValues[i];
            }
        }
    }
}
