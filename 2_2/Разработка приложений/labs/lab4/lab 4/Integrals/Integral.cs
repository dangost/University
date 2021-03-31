using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace lab_4
{
    public class Integral
    {
        
        // Перечисление доступных режимов работы.
        private enum Mods { USUAL, LEFT_RECTANGLE_METHOD, MIDDLE_RECTANGLE_METHOD, RIGHT_RECTANGLE_METHOD, TRAPEZOID_METHOD }

       
        /// Текущий режим рисованя.
        private Mods Mod = Mods.TRAPEZOID_METHOD;


        #region Выбор режима рисования

      
        /// Устанавливает отображение функции в обычный режим.
        public void SetModUSUAL() => Mod = Mods.USUAL;


        /// Устанавливает отображение функции в режим левых прямоугольников.
        public void SetModLEFT_RECTANGLE_METHOD() => Mod = Mods.LEFT_RECTANGLE_METHOD;

        /// Устанавливает отображение функции в режим средних прямоугольников.
        public void SetModMIDDLE_RECTANGLE_METHOD() => Mod = Mods.MIDDLE_RECTANGLE_METHOD;


        /// Устанавливает отображение функции в режим правых прямоугольников.
        public void SetModRIGHT_RECTANGLE_METHOD() => Mod = Mods.RIGHT_RECTANGLE_METHOD;

        /// Устанавливает отображение функции в трапеций.
        public void SetModTRAPEZOID_METHOD() => Mod = Mods.TRAPEZOID_METHOD;

        #endregion

        #region Поля класса

        /// Поле нижнего предела интеграла.
        private double bottom;

        /// Поле верхнего предела интеграла.
        private double top;


        /// Поле шага интеграла.
        private double step;


        #endregion

        #region Геттеры и сетторы класса

        
        /// Нижний предел интеграла.
        public double Bottom { get => bottom; set => bottom = value; }


        /// Верхний предел интеграла.
        public double Top { get => top; set => top = value; }

        /// Поле шага интеграла.
        public double Step { get => step; set => step = value; }

        /// Указатель на редактируемый chart.
        private Chart chart;
        public Chart Chart { get => chart; set => chart = value; }

        /// Имя серии в chart.
        public string NameOfSeries { get; set; }

        #endregion



        public Integral(ref Chart chartRef)
        {
            chart = chartRef;
        }

        public Integral(ref Chart chartRef, string nameOfSeries,  double bottom, double top, double step)
        {
            chart = chartRef;

            chart.Series[nameOfSeries].Points.Clear();

            NameOfSeries = nameOfSeries;

            this.bottom = bottom;
            this.top = top;
            this.step = step;
      
        }

        public virtual double StaticFunction(double x) => Math.Sin(x);

        #region Вычисление точек


        private List<DataPoint> GetFuncDots()
        {
            List<DataPoint> points = new List<DataPoint>();

            switch (Mod)
            {
                case Mods.LEFT_RECTANGLE_METHOD:
                    {
                        for (double x = bottom; x <= top; x += step)
                        {
                            double y = StaticFunction(x);

                            points.Add(new DataPoint(x, y));
                            if (x + step <= top)
                            {
                                points.Add(new DataPoint(x + step, y));
                            }
                        }
                        break;
                    }

                case Mods.MIDDLE_RECTANGLE_METHOD:
                    {
                        for (double x = bottom; x <= top; x += step)
                        {
                            double y = StaticFunction(x + step / 2);

                            points.Add(new DataPoint(x, y));
                            if (x + step <= top)
                            {
                                points.Add(new DataPoint(x + step, y));
                            }
                        }
                        break;
                    }

                case Mods.RIGHT_RECTANGLE_METHOD:
                    {
                        for (double x = bottom; x <= top; x += step)
                        {
                            double y = StaticFunction(x + step);

                            points.Add(new DataPoint(x, y));
                            if (x + step <= top)
                            {
                                points.Add(new DataPoint(x + step, y));
                            }
                        }

                        break;
                    }

                case Mods.TRAPEZOID_METHOD:
                    {
                        for (double x = bottom; x <= top; x += step)
                        {
                            double y = StaticFunction(x);

                            points.Add(new DataPoint(x, y));

                        }
                        break;
                    }

                default:
                    break;
            }
            return points;
        }
        #endregion

        #region Рисование функции

        /// Отрисовывает Функцию на заданной серии

        public bool DrawFunc()
        {
            if (bottom < top && step != 0)  //защита от зацикливания
            {
                chart.Series[NameOfSeries].Points.Clear();

                List<DataPoint> points = GetFuncDots();

                foreach (DataPoint point in points)
                {
                    chart.Series[NameOfSeries].Points.AddXY(point.XValue, point.YValues[0]);
                }

                return true;
            }
            else
            {
                return false;
            }
        }

        #endregion

        #region Вычисление площади

        public double CalcArea()
        {
            double area = 0;

            switch (Mod)
            {
                case Mods.LEFT_RECTANGLE_METHOD:
                    {

                        for (double x = bottom; x <= top; x += step)
                        {
                            double y = Math.Abs(StaticFunction(x));
                            area += y * step;
                        }

                        break;
                    }

                case Mods.MIDDLE_RECTANGLE_METHOD:
                    {
                        for (double x = bottom; x <= top; x += step)
                        {
                            double y = StaticFunction(x + step / 2);

                            area += y * step;
                        }

                        break;
                    }

                case Mods.RIGHT_RECTANGLE_METHOD:
                    {
                        for (double x = bottom; x <= top; x += step)
                        {
                            double y = StaticFunction(x + step);

                            area += y * step;

                        }

                        break;
                    }

                case Mods.TRAPEZOID_METHOD:
                    {
                        for (double x = bottom; x <= top; x += step)
                        {
                            double y = StaticFunction(x);

                            area += step * (StaticFunction(x) + StaticFunction(x + step)) / 2;

                        }

                        break;
                    }
            }

            return area;
        }
        #endregion
    }
}
