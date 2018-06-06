using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trekant
{
    class Program
    {
        static void Main(string[] args)
        {
            Trekant t1 = new Trekant(5,5);
            /* t1.Grundlinje = 10; -- kan ikke lade sig gøre */
            Console.WriteLine(t1.Areal);
            Console.ReadLine();
        }
    }
}
