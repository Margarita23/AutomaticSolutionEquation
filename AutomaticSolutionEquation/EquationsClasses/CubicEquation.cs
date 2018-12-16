using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomaticSolutionEquation.EquationsClasses
{
    class CubicEquation
    {
        private double a, b, c, d;

        public CubicEquation(string a, string b, string c, string d, string f)
        {
            this.a = 1;
            this.b = Convert.ToDouble(b) / Convert.ToDouble(a);
            this.c = Convert.ToDouble(c) / Convert.ToDouble(a);
            this.d = (Convert.ToDouble(d) - Convert.ToDouble(f)) / Convert.ToDouble(a);
        }

        public double?[] Solve()
        {
            double?[] res = new double?[3] { null, null, null};
            double q = (Math.Pow(a, 2) - 3 * b) / 9;
            double r = (2*Math.Pow(a, 3) - 9 * a * b + 27 * c) / 54;

            if(Math.Pow(r,2) < Math.Pow(q, 3))
            {
                double t = Math.Acos(r / Math.Sqrt(Math.Pow(q, 3))) / 3;
                res[0] = 2 * Math.Sqrt(q) * Math.Cos(t) - a / 3;
                res[1] = 2 * Math.Sqrt(q) * Math.Cos(t + (2 * Math.PI / 3)) - a / 3;
                res[2] = 2 * Math.Sqrt(q) * Math.Cos(t - (2 * Math.PI / 3)) - a / 3;
            }
            else
            {
                double aa = -Math.Sign(r) * Math.Pow(Math.Abs(r) + Math.Sqrt(Math.Pow(r, 2) - Math.Pow(q, 3)), 1 / 3);
                double bb = aa!=0 ? q / aa : bb=0;
                res[0] = (aa + bb) - a / 3;
                if(aa == bb)
                {
                    res[1] = -aa - a / 3;
                }
            }
            return res;
        }
    }
}
