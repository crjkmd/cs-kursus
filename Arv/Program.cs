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
            Person p = new Person() { Efternavn = "Jepsen", Fornavn = "Christian" };
            Elev e = new Elev() { Efternavn = "Sørensen", Fornavn = "Anders" ,KlasseLokale = "Øst 1.07"};
            Instruktør i = new Instruktør() { Efternavn = "Cronberg", Fornavn = "Michell", NøgleId = 1 };

            p.Skriv();
            e.Skriv();
            i.Skriv();

            Console.WriteLine("\n");

            Person[] lst = new Person[3];
            lst[0] = p;
            lst[1] = e;
            lst[2] = i;

            foreach (var item in lst)
                item.Skriv();

            //Console.WriteLine(p.FuldtNavn()) ;
            //Console.WriteLine(e.FuldtNavn());
            //Console.WriteLine(i.FuldtNavn());
            Console.ReadLine();
        }
    }
}
