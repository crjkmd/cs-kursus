using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrugInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            IDbFunktioner[] a = new IDbFunktioner[6];
            a[0] = new Ubåd();
            a[1] = new Hund();
            a[2] = new Ubåd();
            a[3] = new Ubåd();
            a[4] = new Hund();
            a[5] = new Ubåd();

            foreach (var item in a)
            {
                //if (a. > 3 || item < 3)
                //{
                    item.Gem();
                //}
                
            }
            Console.ReadLine();
        }
    }
}
