using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatiskEgenskab
{
    class Test
    {
        public string Fornavn { get; set; }
        /* public string Efternavn { get; set; } */

        private string efternavn;

        public string Efternavn
        {
            get { return efternavn; }
            set
            {
                if (value.Length < 3)
                { efternavn = "";
                    Console.WriteLine("Efternavn er kun ", value);
                }
                else
                { efternavn = value; }
            }
        }

        public string Fuldtnavn()
        {
            return Fornavn + " " + Efternavn;
        }
    }
}
