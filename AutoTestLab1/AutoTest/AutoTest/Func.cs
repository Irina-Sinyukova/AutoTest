using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoTest
{
    public class Func
    {
        public double Fun(double a, double b, double x)
        {
            double D = Math.Round(Math.Cos(b * x / a), 2);
            return D;
        }
    }
}
