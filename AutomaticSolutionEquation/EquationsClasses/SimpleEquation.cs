using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomaticSolutionEquation.EquationsClasses
{
    class SimpleEquation : SimpleEquations
    {
        private double a, b, c;

        public SimpleEquation(string a, string b, string c)
        {
            this.a = Convert.ToDouble(a);
            this.b = Convert.ToDouble(b);
            this.c = Convert.ToDouble(c);
        }

        public double Solve()
        {
            return (c - b) / a;
        }
    }
}
