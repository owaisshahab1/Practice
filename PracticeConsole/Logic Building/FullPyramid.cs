using System;

namespace PracticeConsole
{   // top fill bottom one
    // ********
    //  *****
    //   ***
    //    *

    class FullPyramid
    {
        //        static void Main ()
        //        {
        //            int length = 7;
        //            //Console.Write (" ");
        //            for (int i = 0; i < length; i++)
        //            {
        //                //if(i%2 != 0)

        //                if (i % 2 == 0)
        //                {

        //                    for (int j = i; j < length; j++)
        //                    {
        //                        Console.Write ("*");

        //                    }

        //                    Console.WriteLine ();
        //                }
        //            }
        //            Console.ReadLine ();
        //        }
        //    }
        //}

        //      *
        //     ***
        //    *****
        //   *******

// top one bottom fill

        static void MainMethod ()
        {
            int length = 4;
           
            for (int i = 1; i <= length; i++) // Total k of layer for pramid
            {
                for ( int j = 1; j <= (length - i); j++)  // Loop For Space
                    Console.Write (" ");
                for (int k = 1; k <= i; k++) //increase the value
                    Console.Write ('*');
                for (int l = (i - 1); l >= 1; l--)  //decrease the value
                    Console.Write ('*');
                Console.WriteLine ();
                
            }
            Console.ReadLine ();
        }
    }
}