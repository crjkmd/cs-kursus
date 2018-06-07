using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgenException
{
    public class StockItem
    {
        public int Id { get; set; }
        public StockItem(int id)
        {
            if (id<0)
            {
                throw new StockItemException("Wrong id : Must be > 0");
            }
        }
    }
    public class StockItemException : Exception
    {
        public StockItemException(string message) : base(message)
        { }
    }
}
