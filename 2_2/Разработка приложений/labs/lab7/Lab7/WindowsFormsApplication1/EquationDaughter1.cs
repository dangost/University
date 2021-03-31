using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    class EquationDaughter1 : Equation
    {
        public EquationDaughter1(double a, double b, double h, Label label) : base(a, b, h, label) { }
        


        public override double f(double x, double y) { return (1 - 2 * x) / (y * y); }
    }
}
