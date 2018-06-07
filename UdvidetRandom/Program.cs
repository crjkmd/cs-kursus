using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdvidetRandom
{
    class Program
    {
        static void Main(string[] args)
        {
            UdvidetRandom r = new UdvidetRandom();
            Console.WriteLine(r.NextBool()); // true or false
           // Console.WriteLine(r.Skriv());
            Console.ReadLine();
        }
    }
}
