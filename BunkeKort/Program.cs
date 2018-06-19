using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BunkeKort
{
    class Program
    {
        static void Main(string[] args)
        {
            Bunke b = new Bunke();
            b.TilføjKort(new Kort() { Kulør = "Spar", Værdi = 2 });
            b.TilføjKort(new Kort() { Kulør = "Hjerter", Værdi = 14 });
            b.TilføjKort(new Kort() { Kulør = "Ruder", Værdi = 3 });

            b.Vis();

            Console.ReadLine();

            var k = b.Fjernkort();
            Console.WriteLine();
            Console.WriteLine(k);
            Console.WriteLine();

            b.Vis();
            Console.ReadLine();

            var y = b.Fjernkort();
            Console.WriteLine("Det fjernede kort er");
            Console.WriteLine(y);
            Console.WriteLine("Tilbage på ArrayList er");
            b.Vis();
            Console.ReadLine();
        }
    }
}
