using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> a = new List<int>() { 5, 1, 51, 7, 1, 56, 36, 5 };

            // -- Action
            a.ForEach(Skriv);
            Console.ReadLine();
            a.ForEach((int x) => { Console.WriteLine(": " + x); });
            Console.ReadLine();

            // -- Find værdien 51
            a.ForEach((int y) =>
            {
                if (y == 51)
                    Console.WriteLine("Der var en y = "+y);
                else
                    Console.WriteLine("Dett var ikke en y=51 men = " +y);
            });
            
            Console.ReadLine();

        }

        static void ListVærdi(int i)
        {
            Console.WriteLine(i);
        }
        static void Skriv(int i)
        {
            Console.WriteLine("= "+i);
        }
    }
}
