using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arv
{
    public class Elev : Person
    {
                public string KlasseLokale { get; set; }

        public override void Skriv()
        {
            Console.WriteLine($"{Fornavn} {Efternavn} {KlasseLokale}");
        }
    }
}
