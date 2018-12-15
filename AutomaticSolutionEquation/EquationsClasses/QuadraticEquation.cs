using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomaticSolutionEquation.EquationsClasses
{
    class QuadraticEquation : QuadraticEquations
    {
        private double a, b, c, d;

        public QuadraticEquation(string a, string b, string c, string d)
        {
            this.a = Convert.ToDouble(a);
            this.b = Convert.ToDouble(b);
            this.c = Convert.ToDouble(c);
            this.d = Convert.ToDouble(d);
        }

        public double Solve()
        {
            return (c - b) / a;
        }
    }
}
