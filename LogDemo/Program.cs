using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            test1(5, 5);
            test2();
            Console.ReadLine();
        }
        static void test1(int i, int x)
        {
            Console.WriteLine("Test1");
            System.Threading.Thread.Sleep(1000);
        }
        static void test2()
        {
            try
            {
                Console.WriteLine("Test2");
                throw new ApplicationException("Fejl");
                }
            catch (Exception ex)
            {
                // Logger.Debug("Fejl: ", exception: ex);
                // mangler log
            }
        }
        
    }
}
