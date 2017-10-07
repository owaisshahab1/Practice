using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsole.Flow_Control
{
    class HollowSquare
    {
        //        Objetive:
        //Write a program which asks for a symbol, a width and displays
        //hollow square of that width, using that number for the outer symbol, as in this example: 

        //Enter a symbol: 4 
        //Enter the desired width: 3 

        //444 
        //4 4 
        //444 
        public static void MainM ()
        {
            int n;
            int i, j;

            Console.Write ("Enter a symbol: ");
            n = Convert.ToInt32 (Console.ReadLine ());

            Console.Write ("Enter the desired width: ");
            int width = Convert.ToInt32 (Console.ReadLine ());

            for (i = 0; i< width; i++)
                Console.Write (n);

            Console.WriteLine ();

            for (i = 0;i < (width - 2); i++)
            {
                Console.Write (n);

                for (j = 0;  j < width - 2; j++)
                    Console.Write (" ");

                Console.WriteLine (n);
            }

            for (i = 0; i < width; i++)
                Console.Write (n);

            Console.WriteLine ();
            Console.ReadLine ();
        }
    }
}
