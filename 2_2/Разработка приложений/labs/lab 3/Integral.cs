using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace lab_3
{
    public class Integral
    {
        #region Поля класса

        
        /// Поле нижнего предела функции.
        public double Bottom { get; set; }

        /// Поле верхнего предела функции.
        public double Top { get; set; }

        /// Поле шага функции.
        public double Step { get; set; }

        private Chart chart; //указатель на редактируемый chart
        private string nameOfSeries; //указатель на редактируемый chart


        #endregion

        private enum Mods { USUAL, LEFT_RECTANGLE_METHOD, MIDDLE_RECTANGLE_METHOD, RIGHT_RECTANGLE_METHOD, TRAPEZOID_METHOD }

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

        #region Конструкторы
        public Integral(ref Chart chartRef, string nameOfSeries)
        {
            chart = chartRef;

            chart.Series[nameOfSeries].Points.Clear();

            this.nameOfSeries = nameOfSeries;
        }

        #endregion

         
        /// Функция по которой рисуется график

        public virtual double Function(double x) => Math.Sin(x);

        #region Вычисление точек

        private List<DataPoint> GetFuncDots()
        {
            List<DataPoint> points = new List<DataPoint>();

            switch (Mod)
            {
                case Mods.USUAL:
                    {
                        for (double x = Bottom; x <= Top; x += Step)
                        {
                            points.Add(new DataPoint(x, Function(x)));
                        }
                        break;
                    }

                case Mods.LEFT_RECTANGLE_METHOD:
                    {
                        for (double x = Bottom; x <= Top; x += Step)
                        {
                            double y = Function(x);

                            points.Add(new DataPoint(x, y));
                            if (x + Step <= Top)
                            {
                                points.Add(new DataPoint(x + Step, y));
                            }
                        }
                        break;
                    }

                case Mods.MIDDLE_RECTANGLE_METHOD:
                    {
                        for (double x = Bottom; x <= Top; x += Step)
                        {
                            double y = Function(x + Step / 2);

                            points.Add(new DataPoint(x, y));
                            if (x + Step <= Top)
                            {
                                points.Add(new DataPoint(x + Step, y));
                            }
                        }
                        break;
                    }

                case Mods.RIGHT_RECTANGLE_METHOD:
                    {
                        for (double x = Bottom; x <= Top; x += Step)
                        {
                            double y = Function(x + Step);

                            points.Add(new DataPoint(x, y));
                            if (x + Step <= Top)
                            {
                                points.Add(new DataPoint(x + Step, y));
                            }
                        }

                        break;
                    }

                case Mods.TRAPEZOID_METHOD:
                    {
                        for (double x = Bottom; x <= Top; x += Step)
                        {
                            double y = Function(x);

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
            if (Bottom < Top && Step != 0)  //защита от зацикливания
            {
                chart.Series[nameOfSeries].Points.Clear();

                List<DataPoint> points = GetFuncDots();

                foreach (DataPoint point in points)
                {
                    chart.Series[nameOfSeries].Points.AddXY(point.XValue, point.YValues[0]);
                }

                return true;
            }
            else
            {
                return false;
            }
        }

        #endregion

        #region Вычисление площади разными методами
        
        /// Вычисляет площадь функции, вычисленную методом левых прямоугольников.
        
        public double CalcLeftRectanglesSquare()
        {
            double area = 0;

            for (double x = Bottom; x <= Top; x += Step)
            {
                double y = Math.Abs(Function(x));
                area += y * Step;     
            }

            return area;
        }

       
        /// Вычисляет площадь функции, вычисленную методом средних прямоугольников.
       
        public double CalcMiddleRectanglesSquare()
        {
            double area = 0;

            for (double x = Bottom; x <= Top; x += Step)
            {
                double y = Function(x + Step / 2);

                area += y * Step;

            }

            return area;
        }

        
        /// Вычисляет площадь функции, вычисленную методом правых прямоугольников.
       
        public double CalcRightRectanglesSquare()
        {
            double area = 0;

            for (double x = Bottom; x <= Top; x += Step)
            {
                double y = Function(x + Step);

                area += y * Step;

            }

            return area;
        }

        /// Вычисляет площадь функции, вычисленную методом трапеций.
        
        public double CalcTrapezoidSquare()
        {
            double area = 0;

            for (double x = Bottom; x <= Top; x += Step)
            {
                double y = Function(x);

                area += Step * (Function(x) + Function(x + Step)) / 2;

            }

            return area;
        }

        #endregion
    }
}