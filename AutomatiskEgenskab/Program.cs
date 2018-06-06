using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatiskEgenskab
{
    class Program
    {
        static void Main(string[] args)
        {
            Test p = new Test();
            p.Fornavn = "Christian";
            p.Efternavn = "Je";
            Console.WriteLine(p.Fuldtnavn());
            Console.ReadLine();
        }
    }
}
