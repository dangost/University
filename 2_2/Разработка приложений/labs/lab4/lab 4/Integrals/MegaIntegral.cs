using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace lab_4.Integrals
{
    public class MegaIntegral : Integral
    {

        /// Тип функция по которой считается интеграл.

        public delegate double Func(double x);

        /// Функция по которой рисуется интеграл.
        public Func Function { get; set; }

        public MegaIntegral(ref Chart chartRef) : base(ref chartRef)
        {

        }

        public MegaIntegral(ref Chart chartRef, string nameOfSeries,
            Func Function, double bottom, double top, double step) : base
            (ref chartRef, nameOfSeries, bottom, top, step)
        {
            this.Function = Function;
        }

        public override double StaticFunction(double x) => Function(x);
    }
}
