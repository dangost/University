using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    class EquationDaughter2 : Equation
    {
        public EquationDaughter2(double a, double b, double h, Label label) : base(a, b, h, label) { }


        public EquationDaughter2(double h, Label label) : base(h, label)
        {
        }

        public override double f(double x, double y) { return 3 * x - 2 * y + 5; }

    }
}
