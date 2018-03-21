using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PracticeConsole
{
    class Class4
    {
        
       
        public static int count = 0;
        public static int length = 1000000;
        static void Main111(string[] args)
        {

            Stopwatch sp = new Stopwatch();
            sp.Start();
            ThreadStart childref = new ThreadStart(OneMillion);
            Console.WriteLine("In Main: Creating the Child thread");
            Thread childThread = new Thread(childref);
            childThread.Start();
            childThread.Join();
            Console.WriteLine(count);
            sp.Stop();
            Console.WriteLine("Finished");
            Console.WriteLine(sp.Elapsed);
            Console.ReadKey();

        }

        public static void OneMillion()
        {
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < 1000; j++)
                {
                    ++count;
                }
                
            }
        }
    }
}
