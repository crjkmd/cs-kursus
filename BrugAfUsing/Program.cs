using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrugAfUsing
{
    class Program
    {
        static void Main(string[] args)
        {
            int taeller = 0;
            using (StreamReader stream = System.IO.File.OpenText(@"x:\dyrenavne.txt"))
            {
                while (stream.Peek() != -1)
                {
                    string navn = stream.ReadLine();
                    Console.WriteLine(taeller + " " + navn.ToUpper());
                    using (StreamWriter stream1 = System.IO.File.AppendText(@"x:\crj.txt"))
                    {
                        stream1.WriteLine(taeller + " " + navn.ToUpper());
                    }
                    taeller++;
                }
                //stream.Close();
                //stream = null;
            }
            Console.ReadLine();
        }
    }
}
