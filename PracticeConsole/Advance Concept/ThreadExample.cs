using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsole.Flow_Control
{
    class ThreadExample
    {
        class ThreadCreationProgram
        {
            public static void CallToChildThread ()
            {
                try
                {
                    Console.WriteLine ("Child thread starts");

                    // do some work, like counting 0 to 10
                    for (int counter = 1; counter <= 10; counter++)
                    {
                        // less value work fast
                        Thread.Sleep (1000);
                        Console.WriteLine (counter);
                    }

                    Console.WriteLine ("Child Thread Completed");
                }

                catch (ThreadAbortException e)
                {
                    Console.WriteLine ("Thread Abort Exception");
                }
                finally
                {
                    Console.WriteLine ("Couldn't catch the Thread Exception");
                }
            }

            static void Mainm (string[] args)
            {
                ThreadStart childref = new ThreadStart (CallToChildThread);
                Console.WriteLine ("In Main: Creating the Child thread");
                Thread childThread = new Thread (childref);
                childThread.Start ();

                //stop the main thread for some time
                Thread.Sleep (10000); // 4 digit number use for seconds
                                    // 10,000 milliseconds
                                    // 10 seconds

                //now abort the child
                Console.WriteLine ("In Main: Aborting the Child thread");

                childThread.Abort ();
                Console.ReadKey ();
            }

        }
    }
}
