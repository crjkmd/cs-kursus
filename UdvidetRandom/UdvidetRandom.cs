using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdvidetRandom
{
    class UdvidetRandom : System.Random
    {
        private int værdi;
        private int tal;
        public bool NextBool()
        {
            tal = this.Next(1, 1002);
            //værdi = tal;
            return tal < 500;
            //this.værdi = value;
        }

        //public void Skriv()
        //{
   //         private string tallet;
   //         tallet = ToString(værdi);
            //return ToString(værdi);
       // }

    }
}
