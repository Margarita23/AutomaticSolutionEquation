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
            this.c = Convert.ToDouble(c) - Convert.ToDouble(d);
            this.d = Convert.ToDouble(d);
        }

        public double?[] Solve()
        {

            double discriminant = (b * b) - (4 * a * c);
            double?[] res = new double?[2] { null, null};

            if (discriminant > 0)
            {
                res[0] = (-b + Math.Sqrt(discriminant)) / (2 * a);
                res[1] = (-b - Math.Sqrt(discriminant)) / (2 * a);
            }else if(discriminant == 0)
            {
                res[0] = -b / (2 * a);
                res[1] = res[0];
            } else if(discriminant < 0) { }
            return res;
        }
    }
}
