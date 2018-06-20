using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace Events
{
    class Program
    {
        static void Main(string[] args)
        {

            //Thread thread = new Thread(new ThreadStart(WorkThread1));
            //thread.Start();

            // -- Binder kode til frameworket
            System.Timers.Timer t = new System.Timers.Timer();
            t.Interval = 500;
            t.Enabled = true;
            //t.Elapsed += Tick;

            System.IO.FileSystemWatcher f = new System.IO.FileSystemWatcher(@"c:\temp");
            f.EnableRaisingEvents = true;
            f.Created += (s, e) => Console.WriteLine("Fil oprettet " + e.FullPath);
            f.Deleted += (w, q) => Console.WriteLine("Fil slettet " + q.FullPath);
            f.Renamed += (a, s) => Console.WriteLine("Fil renamet " + s.FullPath + " Filnavnet var før: " + s.OldName);

            //Thread thread1 = new Thread(new ThreadStart(WorkThread1));
            //thread1.Start();

            //do
            //{

            //} while (true);


        }

        public static void WorkThread1()
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine("Thread ");
            }
        }
        private static void Tick(object sender, System.Timers.ElapsedEventArgs e)
        {
            Console.WriteLine("Tick " + e.SignalTime);
        }
    }
}
