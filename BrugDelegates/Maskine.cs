using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrugDelegates
{
    public delegate void LogDelegate(string txt);
    class Maskine
    {
        public LogDelegate Log { get; set; }

        public void Start()
        {
            Log(DateTime.Now.ToLongTimeString() + " Starter");
        }
        public void Stop()
        {
            Log(DateTime.Now.ToLongTimeString() + " Stopper");
        }
    }
}
