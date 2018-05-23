using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverLoad_af_funktion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Beregn(1,2));
            Console.WriteLine(Beregn(1, 2, 4));
            Console.WriteLine(Beregn(1, 2,4, 6));
            Console.ReadLine();

            int res = LægSammen(5, 2);
            Console.WriteLine(res);
            Console.ReadLine();

            double res2 = BeregnAreal(5);
            Console.WriteLine(res2);
            Console.ReadLine();

            Udskriv();
            Udskriv("Dette er en test");
            Console.ReadLine();

            double res4 = BeregnMoms(100.35,0.25);
            Console.WriteLine(res4);
            Console.ReadLine();

            int[] løn = { 10000, 5000, 30000 };
            double gns = Gennemsnit(løn);
            Console.WriteLine(gns);
            Console.ReadLine();

        }
        static int Beregn(int a, int b)
        {
            return a + b;
        }

        static int Beregn(int a, int b, int c)
        {
            return Beregn(a ,b) + c;
        }

        static int Beregn(int a, int b, int c, int d)
        {
            return Beregn(a, b, c) + d;
        }
        static int LægSammen(int a, int b)
        {
            return a + b;
        }
        static double BeregnAreal(int a)
        {
            return a * a * System.Math.PI;
        }
        static void Udskriv(string a ="Hej")
        {
            Console.WriteLine(a);
        }
        static double BeregnMoms(double tal, double momsPct = 0.25)
        {
            return tal * momsPct;
        }

        static double Gennemsnit(int[] månedsløn)
        {
            double sum = 0;
            for (int i = 0; i < månedsløn.Length; i++)
            {
                sum += månedsløn[i];
            }
            return sum / månedsløn.Length;
        }

    }
}
