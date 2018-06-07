using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArealBeregninger
{
    static class ArealBeregninger
    {
        public static double BeregnArealFirkant(double h, double b)
        {
            return h * b;
        }
        public static double BeregnArealCirkel(double r)
        {
            return Math.Pow(r, 2) * System.Math.PI;
        }
    }
}
