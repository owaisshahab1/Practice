using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PracticeConsole
{
    class Class4
    {


        //public static int count = 0;
        // public static int length = 1000000;
        /* static void Main111(string[] args)
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
         }*/

        static void Main (string[] args)
        {
            string[] strArray = new string[10];
            char[] chrArray = new char[100];
            
                string fileName = @"C: \Users\owais.shahab\Documents\Practice\PracticeConsole\Resources\mails.txt";


            // Read a text file using StreamReader

            using (System.IO.StreamReader sr = new System.IO.StreamReader (fileName))

            {
                String line;
                while ((line = sr.ReadLine ()) != null)
                {
                    string str = line.Split(' ')[2];
                    //chrArray = str.ToCharArray ();
                    if (str.Contains('@'))
                    {
                        bool checkpoint = true;

                        if (str.Contains('!') || str.Contains('"') || str.Contains ('#') || str.Contains ('$') || str.Contains ('%') || str.Contains ('&') || str.Contains ('\'') || str.Contains ('(') || str.Contains (')') || str.Contains ('*') || str.Contains ('+') || str.Contains (',') || str.Contains ('-') || str.Contains ('/') || str.Contains (':') || str.Contains (';') || str.Contains ('<') || str.Contains ('=') || str.Contains ('>') || str.Contains ('?') || str.Contains ('[') || str.Contains ('\\') || str.Contains (']') || str.Contains ('^') || str.Contains ('`') || str.Contains ('{') || str.Contains ('|') || str.Contains ('}') || str.Contains ('~'))
                        {
                            checkpoint = false;
                        }
                        if (checkpoint)
                        {
                            Console.WriteLine (line);
                        }

                    }

                }
                Console.ReadKey ();

            }
        }

    }
}
