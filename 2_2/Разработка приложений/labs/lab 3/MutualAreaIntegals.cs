using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace lab_3
{
    public class MutualAreaIntegals : Integral
    {
        public MutualAreaIntegals(Chart chart, string nameOfsereies, double f1bottom, double f1top,
            double f2bottom, double f2top, double step) : base(ref chart, nameOfsereies)
        {
            if (f1bottom > f2bottom)
            {
                Bottom = f1bottom;
            }
            else
            {
                Bottom = f2bottom;
            }

            if (f1top < f2top)
            {
                Top = f1top;
            }
            else
            {
                Top = f2top;
            }

            Step = step;
        }

        public override double Function(double x) => Math.Sin(x);

    }
}
