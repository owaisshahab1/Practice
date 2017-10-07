using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsole
{
    class PyramidDesign2
    {
        // kafeel logic
        static void MainMethod () { 
        bool star = false;

            for (int i = 9; i > 0; i--)
            {
                star = true;
                for (int j = i; j > 0; j--)
                {
                    if (star)
                    {
                        for (int k = i; k < 9; k++)
                        {
                            Console.Write (" ");
                        }
                        Console.Write ("*");

                        star = false;
                    }
                    Console.Write (j);
                }
                Console.WriteLine ("");
               
            }
            Console.ReadLine ();
        }
    }
}
