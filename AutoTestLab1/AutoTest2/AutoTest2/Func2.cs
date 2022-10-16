using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoTest2
{
    public class Func2
    {
        public double Fun(double a, double b, double x)
        {
            double Y = b * Math.Pow(Math.Tan(x), 2) - a / (Math.Sin(x / b) * Math.Sin(x / b));
            return Y;
        }
    }
}
