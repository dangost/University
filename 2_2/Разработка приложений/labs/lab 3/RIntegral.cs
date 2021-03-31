using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms.DataVisualization.Charting;
using System.Drawing;
using System.Windows.Forms;

namespace lab_3
{
    class RIntegral
    {
        private RIntegral.Mods currentMod = Mods.TRAPEZOID_METHOD;
        private double lowerBound; //нижний предел интегрирования
        private double upperBound; //верхний предел интегрирования
        private double step; //шаг интегрирования
        private Chart chart;
        private string functionSeriesName;
        private string areaSeriesName;
        public enum Mods { LEFT_RECTANGLE_METHOD, MIDDLE_RECTANGLE_METHOD, RIGHT_RECTANGLE_METHOD, TRAPEZOID_METHOD }

        #region Конструкторы

        public RIntegral(double lowerBound, double upperBound, double step, Chart chart, string functionSeriesName, string areaSeriesName)
        {
            this.lowerBound = lowerBound;
            this.upperBound = upperBound;
            this.step = step;
            this.chart = chart;
            this.functionSeriesName = functionSeriesName;
            this.areaSeriesName = areaSeriesName;
            chart.Series[functionSeriesName].Points.Clear();
            chart.Series[areaSeriesName].Points.Clear();
        }


        #endregion

        #region Инкапсуляция

        public double LowerBound { get => lowerBound; set => lowerBound = value; }
        public double UpperBound { get => upperBound; set => upperBound = value; }
        public double Step { get => step;
            set
            {
                if (value > 0)
                {
                    step = value;
                }
                
            }
        }



        #endregion

        #region Area calculation

        public double CalculateArea()
        {
            double result = 0;
            switch (currentMod)
            {
                case Mods.LEFT_RECTANGLE_METHOD:
                    {
                        result = CalcLeftRectanglesSquare();
                        break;
                    }

                case Mods.MIDDLE_RECTANGLE_METHOD:
                    {
                        result = CalcMiddleRectanglesSquare();
                        break;
                    }

                case Mods.RIGHT_RECTANGLE_METHOD:
                    {
                        result = CalcRightRectanglesSquare();
                        break;
                    }

                case Mods.TRAPEZOID_METHOD:
                    {
                        result = CalcTrapezoidSquare();
                        break;
                    }
            }
            return Math.Abs(result);
        }

        private double GetY(double x) => Math.Sin(x);        

        private double CalcLeftRectanglesSquare()
        {
            double area = 0;

            for (double x = LowerBound; x <= UpperBound; x += Step)
            {
                double y = GetY(x);
                area += y * Step;          //левых прямоугольников left rectangle
            }

            return area;
        }

        private double CalcMiddleRectanglesSquare()
        {
            double area = 0;

            for (double x = LowerBound; x <= UpperBound; x += Step)
            {
                double y = GetY(x + Step / 2);

                area += y * Step;   //средних прямоугольников middle rectangle

            }

            return area;
        }

        private double CalcRightRectanglesSquare()
        {
            double area = 0;

            for (double x = LowerBound; x <= UpperBound; x += Step)
            {
                double y = GetY(x + Step);

                area += y * Step;   //правых прямоугольников right rectangle

            }

            return area;
        }

        private double CalcTrapezoidSquare()
        {
            double area = 0;

            for (double x = LowerBound; x <= UpperBound; x += Step)
            {
                double y = GetY(x);

                area += Step * (GetY(x) + GetY(x + Step)) / 2;   //трапеций trapezoid

            }

            return area;
        }

        #endregion

        #region Dots calculation

        public Series CalcFuncDots()
        {
            Series series = new Series();

            for (double x = LowerBound; x <= UpperBound; x += 0.001)
            {
                double y = GetY(x);

                series.Points.AddXY(x, y);
            }

            return series;
        }

        private Series CalcLeftRectanglesDots()
        {
            Series series = new Series();

            for (double x = LowerBound; x <= UpperBound; x += Step)
            {
                double y = GetY(x);

                series.Points.AddXY(x, y);
                if (x + Step <= UpperBound)
                {
                    series.Points.AddXY(x + Step, y);
                }
            }

            return series;
        }

        private Series CalcMiddleRectanglesDots()
        {
            Series series = new Series();

            for (double x = LowerBound; x <= UpperBound; x += Step)
            {
                double y = GetY(x + Step / 2);

                series.Points.AddXY(x, y);
                if (x + Step <= UpperBound)
                {
                    series.Points.AddXY(x + Step, y);
                }
            }

            return series;
        }

        private Series CalcRightRectanglesDots()
        {
            Series series = new Series();

            for (double x = LowerBound; x <= UpperBound; x += Step)
            {
                double y = GetY(x + Step);

                series.Points.AddXY(x, y);
                if (x + Step <= UpperBound)
                {
                    series.Points.AddXY(x + Step, y);
                }
            }

            return series;
        }

        private Series CalcTrapezoidDots()
        {
            Series series = new Series();

            for (double x = LowerBound; x <= UpperBound; x += Step)
            {
                double y = GetY(x);

                series.Points.AddXY(x, y);

            }

            return series;
        }

        #endregion

        #region Drawing

        public void DrawFunction()
        {
            AddSeries(functionSeriesName, CalcFuncDots());
        }

        public void DrawArea()
        {
            switch (currentMod)
            {
                case Mods.LEFT_RECTANGLE_METHOD:
                    {
                        AddSeries(areaSeriesName, CalcLeftRectanglesDots());
                        break;
                    }

                case Mods.MIDDLE_RECTANGLE_METHOD:
                    {
                        AddSeries(areaSeriesName, CalcMiddleRectanglesDots());
                        break;
                    }

                case Mods.RIGHT_RECTANGLE_METHOD:
                    {
                        AddSeries(areaSeriesName, CalcRightRectanglesDots());
                        break;
                    }

                case Mods.TRAPEZOID_METHOD:
                    {
                        AddSeries(areaSeriesName, CalcTrapezoidDots());
                        break;
                    }
            }
        }

        private void AddSeries(string name, Series series)
            {
                for (int i = 0; i < series.Points.Count; i++)
                {
                    chart.Series[name].Points.Add(series.Points[i]);
                }
            }
        #endregion
        
    }
}
