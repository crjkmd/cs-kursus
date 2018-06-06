using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            p1.Fornavn = "Christian";
            p1.Efternavn = "Jepsen";
            p1.Fødselsår = 1968;
            Console.WriteLine(p1.Fornavn);
            Console.ReadLine();
            Console.WriteLine(p1.Alder());
            Console.ReadLine();
            Console.WriteLine(p1.Fornavn, p1.Efternavn, p1.Fødselsår);
            Console.ReadLine();

            Person p2 = new Person();
            p2.Fornavn = "Mikkel";
            p2.Efternavn = "Cronberg";
            p2.Fødselsår = 1968;
            Console.WriteLine(p2.Fuldnavn());
            Console.ReadLine();

            Person p3 = new Person("Christian","Jepsen",1968);
            Console.WriteLine(p3.Fuldnavn());
            Console.ReadLine();


        }
    }
}

public class Person
{
    // Definere medlemmer
    public string Fornavn;
    public string Efternavn;
    public int Fødselsår;
    public int Alder()
    {
        int aar = DateTime.Now.Year;
        return aar - this.Fødselsår;
    }

    public string Fuldnavn()
    {
        return $"{Fornavn} {Efternavn}";
    }
    public Person()
    {
        this.Fornavn = "";
        this.Efternavn = "";
    }
    public Person(string efternavn, string fornavn, int fødselsår)
    {
        this.Fødselsår = fødselsår;
        this.Fornavn = fornavn.ToLower();
        this.Efternavn = efternavn.ToLower();
    }
}
