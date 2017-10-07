using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsole.Content
{
    class NumberParamid
    {

        //   1
        //  121
        // 12321


        //static void Main (string[] args)
        //{
        //    int numberoflayer = 3, Space, Number; // work fine for 1 to 9
        //    Console.WriteLine ("Print paramid");
        //    for (int i = 1; i <= numberoflayer; i++) // Total number of layer for pramid
        //    {
        //        for (Space = 1; Space <= (numberoflayer - i); Space++)  // Loop For Space
        //            Console.Write (" ");
        //        for (Number = 1; Number <= i; Number++) //increase the value
        //            Console.Write (Number);
        //        for (Number = (i - 1); Number >= 1; Number--)  //decrease the value
        //            Console.Write (Number);
        //        Console.WriteLine ();

        //    }
        //    Console.Read ();
        //        }

        //public static void Main ()
        //{
        //    int limit = 3;


        //    for (int i = 1; i <= limit; i++)
        //    {
        //        for (int j = 1; j <= i; j++)
        //        {
        //            Console.Write (i);
        //        }
        //        Console.WriteLine ();
        //    }
        //    Console.ReadKey ();
        //}

            // 1
            // 12
            // 123
            // 12
            // 1

        public static void MainM (string[] args)
        {
            Console.Write ("Enter a number: ");
            int n = Convert.ToInt32 (Console.ReadLine ());

            Console.WriteLine ();

            for (int i = 1; i < n; i++)
            {
                for (int j = 1; j <= i; j++)
                    Console.Write (j.ToString ());
                Console.WriteLine ();
            }
            for (int i = n; i >= 0; i--)
            {
                for (int j = 1; j <= i; j++)
                    Console.Write (j.ToString ());
                Console.WriteLine ();
            }
            Console.WriteLine ();
        }

    }
}
