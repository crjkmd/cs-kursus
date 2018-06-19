using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;


namespace BrugCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> liste1 = new List<Person>();
            liste1.Add(new Person { Id = 1, Navn = "Morten" });
            liste1.Add(new Person { Id = 2, Navn = "Peter" });
            liste1.Add(new Person { Id = 3, Navn = "Søren" });
            liste1.Add(new Person { Id = 4, Navn = "Gert" });
            liste1.Add(new Person { Id = 5, Navn = "Jens" });
            foreach (var item in liste1)
            {
                Console.WriteLine(item.Navn);
            }
            Console.WriteLine("");
            Console.ReadLine();

            Dictionary<int, Person> liste2 = new Dictionary<int, Person>();
            liste2.Add(1,new Person { Id = 1, Navn = "Morten" });
            liste2.Add(2,new Person { Id = 2, Navn = "Peter" });
            liste2.Add(3,new Person { Id = 3, Navn = "Søren" });
            var p = liste2[3];
            Console.WriteLine(p.Navn);

            //foreach (var item in liste2)
            //{
            //    Console.WriteLine(liste2.OrderBy);
            //}
            Console.ReadLine();
        }
    }
}
