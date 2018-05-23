using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ref_Opgave
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mitIntArray; // En dimensionel array
            int[] mitIntArray1; // En dimensionel array

            int[,] mitIntArray2; // To dimensionel array

            mitIntArray = new int[5]; // Lav et array med 5 elementer som er int=0 som default

            for (int i = 0; i < mitIntArray.Length; i++)
            {
                Console.WriteLine("Array "+i+" Værdi er "+mitIntArray[i]);
            }
            Console.WriteLine("Press enter ...");
            Console.ReadLine();

            int[] månedsløn = { 10000, 20000, 15000, 20000, 30000, 15000 };

            double sum = 0;

            System.Diagnostics.Stopwatch s = new System.Diagnostics.Stopwatch();
            s.Start();
            foreach (int item in månedsløn)
            {
                Console.WriteLine(item);
                sum += item;
            }
            s.Stop();
            Console.WriteLine($"Tid = {s.ElapsedMilliseconds}");
            Console.WriteLine("Press enter ...");
            Console.ReadLine();

            // Brug stringBuilder

            for (int ii = 0; ii < månedsløn.Length; ii++)
            {
                //sum += månedsløn[ii];
            }
            double gennemsnit = sum / månedsløn.Length;
            Console.WriteLine("Gennemsnit er : " +gennemsnit.ToString("N2"));
            Console.ReadLine();

            // Strenge returnere nye strenge
            //char t = 'A';
            //string navn = "Christian";
            //navn = navn.ToUpper();
            //navn.Replace;
            // Escape karaktere : \\ eller ignorer @ \t=tab \n=newline \r=carrige-return

            // csv assembly
            /*string csv = "123;32323;2343;4323";
            string[] aa = csv.Split(';');
            Console.WriteLine(aa);
            Console.ReadLine(); */
        }
    }
}
