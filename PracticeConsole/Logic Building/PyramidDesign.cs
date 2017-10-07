using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsole
{

class PyramidDesign
    {   // my logic
        static void MainMethod()
        {
            bool star = false;
            int num = 4;

            for (int i = num; i >= 1; i--)
            {

                star = true;
                for (int j = (i - 1); j >= 1; j--)
                {
                    if (star)
                    {
                        for (int k = i; k < i; k++)
                        {
                            Console.Write (" ");
                        }
                        Console.Write ("*");
                        star = false;
                    }

                    Console.Write(" " + j);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}