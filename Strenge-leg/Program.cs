using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strenge_leg
{
    class Program
    {
        static void Main(string[] args)
        {
            string fornavn = "Christian";
            string efternavn = "Jepsen";
            string samletnavn = fornavn + " " + efternavn;
            Console.WriteLine(samletnavn);
            
            string navnstort = samletnavn.ToUpper();
            Console.WriteLine(navnstort);
            string navnlille = samletnavn.ToLower();
            Console.WriteLine(navnlille);
            string del = samletnavn.Substring(7, 4);
            Console.WriteLine(del);
            string[] navne = samletnavn.Split(' ');

            System.Diagnostics.Stopwatch s = new System.Diagnostics.Stopwatch();
            s.Start();

            for (int i = 0; i < navne.Length; i++)
            {
                Console.WriteLine(navne[i]);
            }

            s.Stop();
            Console.WriteLine($"Tid = {s.ElapsedMilliseconds}");

            Console.WriteLine(fornavn + "\r\n\t" + efternavn);

            System.IO.File.WriteAllText(@"c:\temp\test1.txt", samletnavn);

            StringBuilder minbuilder = new StringBuilder(samletnavn);
            Console.WriteLine(minbuilder);
            minbuilder.Replace('C', 'K');
            Console.WriteLine(minbuilder);
            Console.ReadLine();

            // switch og case - for loop, do while ... break = hop ud, continue = forsæt

        }
    }
}
