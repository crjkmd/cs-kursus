using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgenException
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                StockItem s = new StockItem(-111);
            }
            catch (StockItemException ex)
            {
                //Console.WriteLine("StockItem Error");
                Console.WriteLine(ex.Message + "\n" + ex.StackTrace);
            }
            catch (Exception)
            {
                Console.WriteLine("General Error");
            }
            Console.ReadLine();
        }
    }
}
