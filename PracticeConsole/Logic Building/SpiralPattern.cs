using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsole
{
    class SpiralPattern
    {
        static void MainMethod (string[] args)
        {
            Console.WriteLine ("Enter Size");
            Console.WriteLine ();
            int num = int.Parse (Console.ReadLine ());
            int[,] spiral = new int[num, num]; // array


            int value = 1, minCol = 0, minRow = 0, maxCol = num - 1, maxRow = num - 1;

            while (value <= num * num)
            {
                for (int i = minCol; i <= maxCol; i++)
                {
                    spiral[minRow, i] = value;
                    value++;
                }

                for (int i = minRow + 1; i <= maxRow; i++)
                {
                    spiral[i, maxCol] = value;
                    value++;
                }

                for (int i = maxCol - 1; i >= minCol; i--)
                {
                    spiral[maxRow, i] = value;
                    value++;
                }

                for (int i = maxRow - 1; i >= minRow + 1; i--)
                {
                    spiral[i, minCol] = value;
                    value++;
                }

                minCol++;
                minRow++;
                maxCol--;
                maxRow--;
            }
            

            for (int i = 0; i < num; i++)
            {
                for (int j = 0; j < num; j++)
                {
                    Console.Write (spiral[i, j] + "\t");
                }
                Console.WriteLine ();
               
            }
            Console.ReadLine ();
        }
        
    }
}