using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Hund[] h = new Hund[3];
            h[0] = new Hund() { Alder = 10, Navn ="King" };
            h[1] = new Hund() { Alder = 8, Navn ="Tjuggi" };
            h[2] = new Hund() { Alder = 8, Navn = "Fnuggi" };
            Array.Sort(h);
            foreach (var item in h)
            {
                Console.WriteLine(item.Navn);
            }
            Console.ReadLine();
        }
    }
}
