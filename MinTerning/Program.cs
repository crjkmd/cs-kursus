using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinTerning
{
    class Program
    {
        static void Main(string[] args)
        {
            MinTerning t1 = new MinTerning();
            t1.Skriv();
            Console.ReadLine();
            t1.Ryst();
            t1.Skriv();
            Console.ReadLine();
            t1.Værdi = 7;
            t1.Skriv();
            Console.ReadLine();
            t1 = new MinTerning(6);
            t1.Skriv();
            Console.ReadLine();
        }
    }
}
