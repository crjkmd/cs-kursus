using System;
using System.Management;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime da = DateTime.Now;
            Console.WriteLine(da.ToString("dd-MM-yyyy"));

            // Timespan
            DateTime d1 = DateTime.Now;
            DateTime d2 = new DateTime(2018, 12, 24);

            TimeSpan ts = d2.Subtract(d1);
            Console.WriteLine(ts.TotalDays.ToString());

            // PC Info
            string Key = "Win32_Processor";
            System.Management.Instrumentation.
            //System.Management.ManagementObjectSearcher searcher = new ManagementObjectSearcher("select * from " + Key);
            Console.WriteLine(searcher.Get());

            // Variables

            int y; // 32 bit heltal
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Tæller "+ i);
            }
            Console.WriteLine("Press enter");
            Console.ReadLine();
        }
    }
}
