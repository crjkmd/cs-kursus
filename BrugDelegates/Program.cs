using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrugDelegates
{
    
    class Program
    {
       // public delegate int BeregnDelegate(int a, int b);
        //public delegate void LogDelegate(string txt);

        static void Main(string[] args)
        {
            // BeregnDelegate s = new BeregnDelegate(Plus);
            // int res = Beregner(1, 1, s);
            // Console.WriteLine(res);

            // BeregnDelegate s1 = Minus;
            // int res2 = Beregner(1, 1, Minus);
            // Console.WriteLine(res2);

            int res1 = 0;
            res1 = Beregner(3, 4, FindTilfældigFunktion());
            Console.WriteLine(res1);
            Console.ReadLine();

            res1 = Beregner(3, 4, FindTilfældigFunktion());
            Console.WriteLine(res1);
            Console.ReadLine();

            int res = 0;
            res = Beregner(1, 1, Plus);
            Console.WriteLine(res);
            res = Beregner(1, 1, Minus);
            Console.WriteLine(res);
            Console.ReadLine();

            Console.WriteLine("***");

            int res3 = Beregner(1, 1, Gange);
            Console.WriteLine(res3);
            Console.ReadLine();

            Maskine m = new Maskine();
            m.Log = Console.WriteLine;
            m.Start();
            m.Stop();
            m.Log += AppendLog;
            m.Start();
            m.Stop();
            Console.ReadLine();
        }

        public static Func<int,int,int> FindTilfældigFunktion()
        {
            if (System.DateTime.Now.Millisecond <= 250)
                return Plus;
            if (System.DateTime.Now.Millisecond <= 500)
                return Minus;
            if (System.DateTime.Now.Millisecond <= 750)
                return Gange;
            return Divider;
        }
    

        public static void AppendLog(string txt)
        {
            System.IO.File.AppendAllText(@"c:\temp\log.txt", txt + "\r\n");
        }
        public static int Beregner(int a, int b, Func<int, int, int> funktion)
            //public static int Beregner(int a, int b, BeregnDelegate funktion)
        {
            return funktion(a, b);
        }
        public static int Plus(int a, int b)
        {
            return a + b;
        }
        public static int Minus(int a, int b)
        {
            return a - b;
        }
        public static int Divider(int a, int b)
        {
            return a / b;
        }
        public static int Gange(int a, int b)
        {
            return a * b;
        }

    }

}
