using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsole
{
    class Multiples3and5
    {
        public static void MainM ()
        {
            int i = 1;

            while (i <= 500)
            {
                if ((i % 3 == 0) && (i % 5 == 0))
                    Console.Write ("{0} ", i);
                i++;
            }

            Console.WriteLine ();
            Console.WriteLine ();

            // different logic
            for (i = 1; i <= 500; i++)
            {
                if ((i % 3 == 0) && (i % 5 == 0))
                    Console.Write ("{0} ", i);
            }

            Console.WriteLine ();
            Console.WriteLine ();

            // different logic
            for ( i = 15; i <= 500; i += 15)
                Console.Write ("{0} ", i);
                Console.ReadLine ();
        }
    }
}

