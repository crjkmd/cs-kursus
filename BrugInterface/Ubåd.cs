using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrugInterface
{
    class Ubåd : IDbFunktioner
    {
        public int Nummer { get; set; }
        public double Tubine { get; set; }
        
        public void Gem()
        {
            Console.WriteLine("Gemmer ubåd");
        }
        public void Besked()
        {
            Console.WriteLine("Ubåd besked");
        }
    }
}

