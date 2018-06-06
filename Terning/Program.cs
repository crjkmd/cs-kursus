using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Terning
{
    class Program
    {
        static void Main(string[] args)
        {
            Terning t1 = new Terning();
            t1.Skriv();
            Console.ReadLine();
            t1.Ryst();
            Console.ReadLine();
            t1.Skriv();
            Console.ReadLine();

            Terning t2 = new Terning();
            t2.Skriv();
            Console.ReadLine();
            t2.Ryst();
            Console.ReadLine();
            t2.Skriv();
            Console.ReadLine();

        }
    }
}
