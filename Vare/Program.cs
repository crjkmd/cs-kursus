using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vare
{
    class Program
    {
        static void Main(string[] args)
        {
            Vare v1 = new Vare();
            v1.Navn = "vare #1";
            v1.Pris = 100;
            Console.WriteLine(v1.PrisMedMoms());
            Console.ReadLine();
            Vare v2 = new Vare("vare #2", 200);
            Console.WriteLine(v2.PrisMedMoms());
            Console.ReadLine();
        }
    }
}
