using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lav_10_tabel
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int ii = 1; ii < 11; ii++)
            {
                for (int yy = 1; yy < 11; yy++)
                {
                    string tal = (ii * yy).ToString();
                    if ((ii * yy) > 50)
                        Console.ForegroundColor = ConsoleColor.Green;
                    else
                        Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.Write(tal.PadLeft(4));
                }
            Console.WriteLine();
            
            }
            Console.ReadLine();

            for (int i = 1; i < 101; i++)
            {
                switch(i)
                {
                    case 10:
                        Console.Write("\n");
                        break;
                    default:
                        Console.Write(i);
                }
            }
            Console.ReadLine();
        }
    }
}
