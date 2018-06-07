using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dyr
{
    class Program
    {
        static void Main(string[] args)
        {
            Dyr[] dyr = new Dyr[35];
            for (int i = 0; i < 35; i++)
            {
                dyr[i] = Dyr.TilfældigtDyr();
            }
            foreach (var item in dyr)
            {
                item.SigNoget();
                
            }
            Console.ReadLine();
        }
    }
}
