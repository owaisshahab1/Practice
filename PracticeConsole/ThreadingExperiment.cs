using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PracticeConsole
{
    class ThreadingExperiment
    {
        public static int total = 0;
        static object _lock = new object ();

        public static void AddOneMillion ()
        {
            for (int i = 0; i < 1000000; i++)
            {
                lock (_lock)
                {

                    total++;
                }
            }
        }

        static void Main66 (string[] args)
        {
            Task.Delay (1000000000);
            Stopwatch sw = new Stopwatch ();
            sw.Start ();
            Thread[] threads = new Thread[10];

            Thread t1 = new Thread (AddOneMillion);
            t1.Name = "t1";
            Thread t2 = new Thread (AddOneMillion);
            t2.Name = "t2";
            Thread t3 = new Thread (AddOneMillion);
            t3.Name = "t3";
            Thread t4 = new Thread (AddOneMillion);
            t4.Name = "t4";
            Thread t5 = new Thread (AddOneMillion);
            t5.Name = "t5";
            t1.Start ();
            t2.Start ();
            t3.Start ();
            t4.Start ();
            t5.Start ();



            sw.Stop ();
            Console.WriteLine (sw.ElapsedTicks);
            Console.WriteLine (total);
            Console.ReadLine ();
        }

  
    }
}
