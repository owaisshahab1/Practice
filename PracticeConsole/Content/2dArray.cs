using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsole
{
    class _2dArray
    {
        static void MainMethod()
        {
            //Declaring two dimension array
            int[,] array;
            int row, column;

            Console.WriteLine("enter the row value");
            row = int.Parse(Console.ReadLine());

            Console.WriteLine("enter the column value");
            column = int.Parse(Console.ReadLine());

            array = new int[row, column];

            // initializing the two dimension array
            Console.WriteLine("\n enter the element of 2d array");

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    array[i, j] = int.Parse(Console.ReadLine());
                }
            }

            // Accessing the elements of two dimension array
            Console.WriteLine("\n the element of 2d array are: ");

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
