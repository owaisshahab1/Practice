using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    class PyramidDesing3
    {
        // madiha logic

        static void MainMethod ()
        {
            int i, j, k;

            for (i = 1; i <= 5; i++)
            {

                for (j = 1; j < i; j++)
                {
                    Console.Write (" ");
                }
                Console.Write ("*");
                for (k = 5 - i; k > 0; k--)
                {
                    Console.Write (k);
                }
                Console.WriteLine ();
            }

            Console.Read ();
        }
    }
}
