using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arv
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person() { Efternavn = "x", Fornavn = "x" };
            Elev e = new Elev() { Efternavn = "z", Fornavn = "z" ,KlasseLokale = "Z"};
            Instruktør i = new Instruktør() { Efternavn = "y", Fornavn = "y", NøgleId = 1 };

            p.Skriv();
            e.Skriv();
            i.Skriv();

        /*    Person[] lst = new Person();
            lst[0] = p;
            lst[1] = e;
            lst[2] = i;

            foreach (var item in lst)
                item.Skriv();
                */
            //Console.WriteLine(p.FuldtNavn()) ;
            //Console.WriteLine(e.FuldtNavn());
            //Console.WriteLine(i.FuldtNavn());
            Console.ReadLine();
        }
    }
}
