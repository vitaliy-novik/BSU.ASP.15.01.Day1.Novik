using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewtonsMethod
{
    public static class NewtonRoot
    {
        public static double Root(double basis, int degree, double precision)
        {
            if (basis < 0)
                throw new ArgumentException("Basis < 0");
            if (degree == 0)
                return 1;
            double x1 = 1.0;
            double x2 = basis;
            while (Math.Abs(x2 - x1) > precision)
            {
                double temp = x2;
                x2 = ((degree - 1) * x1 + basis / Math.Pow(x1, degree - 1)) / degree;
                x1 = temp;
            }
            return x2;
        }
    }
}
