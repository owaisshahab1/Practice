using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsole
{
    class Class1
    {
        static void MainMethod()
        {

            Console.WriteLine ("Enter Number");
            int num = int.Parse( Console.ReadLine ());

            int[,] spiral = new int[num, num] ;

            int increment = 1;
            for (int i = 0; i < num; i++)
            {
                for (int j = i; j < num; j++)
                {
                    spiral[i, j] = increment;
                    increment++;
                }

                for (int k = i+1; k < (num-1); k++)
                {
                    spiral[k, num - 1] = increment;
                    increment++;
                    
                }
                break;
            }


            for (int x = 0; x < num; x++)
            {
                for (int y = 0; y < num; y++)
                {
                    Console.Write (spiral[x,y] +" \t");
                }
                Console.ReadLine ();
            }
            
        }

    }
}

        