using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace Laba1
{
    public class Integral
    {
        private double a;  
        private double b;  
        private int steps;  
        private double h; 
        public float Accurancy { get; set; } 
        public Func<double, double> Func { get; set; } 

        public Integral(double a, double b, int steps, Func<double, double> function) 
        {
            this.a = a;
            this.b = b;
            this.steps = steps;
            Func = function;
            h = Math.Round((b - a) / steps, 5);
        }
                 
        public double LeftRectangle()
        {
            double sum = 0;
            for (double i = 0; i <= steps - 1; i++)
            {
                double x = a + i * h;
                sum += Func(x);
            }

            double result = h * sum;
            return result;
        }

        public double RightRectangle()
        {
            double sum = 0;
            for (double i = 1; i <= steps; i++)
            {
                double x = a + i * h;
                sum += Func(x);
            }

            double result = h * sum;
            return result;
        }

        public double CentralRectangle()
        {
            double sum = 0;
            double x = a +  h / 2;
            for (double i = 1; i <= steps; i++)
            {
                sum += Func(x);
                x+=h;
            }

            double result = h * sum;
            return result;
        }
        
        public double TrapezeRectangle()
        {
            double sum = 0;
            for (double i = 1; i <= steps - 1; i++)
            {
                double x = a + i * h;
                sum += Func(x);
            }

            double result = h * ((Func(a) + Func(b)) / 2 + sum);
            return result;
        }




        public void DrawFunc(Chart chart)
        {

            for (double i = a; i <= b; i += Accurancy)
            {
                chart.Series[1].Points.AddXY(i, Func(i));
            }
        }

        public void DrawLeftRectangle(Chart chart)
        {
            DataPoint[] dataPoints = new DataPoint[steps*2];

            double x = a;
            int index = 0;
            for (int i = 1; i <= steps; i++)
            {
                dataPoints[index] = new DataPoint(x, Func(x));
                x += h;
                dataPoints[++index] = new DataPoint(x, Func(x-h));
                index++;
            }

            foreach (var point in dataPoints)
            {
                chart.Series[0].Points.Add(point);
            }
        }

        public void DrawRightRectangle(Chart chart)
        {
            DataPoint[] dataPoints = new DataPoint[steps*2];

            int index = 0;
            for (int i = 1; i <= steps; i++)
            {
                double x = a + i * h;

                dataPoints[index] = new DataPoint(x - h, Func(x));
                dataPoints[++index] = new DataPoint(x, Func(x));
                index++;
            }

            foreach (var point in dataPoints)
            {
                chart.Series[0].Points.Add(point);
            }
        }

        public void DrawCentralRectangle(Chart chart)
        {
            DataPoint[] dataPoints = new DataPoint[steps * 2];

            double x = a + h / 2;
            int index = 0;
            for (int i = 0; i < steps; i++)
            {
                dataPoints[index] = new DataPoint(x - h/2, Func(x));
                dataPoints[++index] = new DataPoint(x + h/2, Func(x));
                index++;
                x += h;
            }

            foreach (var point in dataPoints)
            {
                chart.Series[0].Points.Add(point);
            }
        }

        public void DrawTrapezeRectangle(Chart chart)
        {
            DataPoint[] dataPoints = new DataPoint[steps + 1];

            double x = a;
            for (int i = 0; i <= steps; i++)
            {
                dataPoints[i] = new DataPoint(x, Func(x));
                x += h;
            }

            foreach (var point in dataPoints)
            {
                chart.Series[0].Points.Add(point);
            }
        }

    }
}
