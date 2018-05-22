using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkrivTilFil
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "afdsjkfdsaj a fdsf";
            File.WriteAllText("c:\\temp\\data.txt", text);
            Console.WriteLine("Følgende data indsættes i file data.txt ..." + text);
            Console.WriteLine("Tryk Enter tasten ...");
            Console.ReadLine();
        }
    }
}
