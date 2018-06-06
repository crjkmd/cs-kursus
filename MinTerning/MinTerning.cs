using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinTerning
{
    public class MinTerning
    {
        private static System.Random rnd = new System.Random();
        private int værdi;

        public int Værdi
        {
            get
            {
                Console.WriteLine("Terning aflæses som " + this.værdi);
                return this.værdi;
            }
            set
            {
                if (value < 0 || value > 6)
                    value = 1;
                Console.WriteLine("Terning tildeles " + value);
                this.værdi = value;
            }
        }

        public void Skriv()
        {
            Console.WriteLine("["+this.Værdi+"]");
        }

        public void Ryst()
        {
            this.Værdi = rnd.Next(1, 7);
        }
        public MinTerning()
        {
            this.Ryst();
        }
        public MinTerning(int værdi)
        {
            this.Værdi = værdi;
        }
    }
}
