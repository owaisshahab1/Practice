using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsole
{
    class DiamondShape
    {
        static void Main999(string[] args)
        {
            int length = 50;
            for (int i = 1; i <= length; i++)
            {
                for (int j = i; j < length; j++)
                {
                    Console.Write(" ");
                }

                for (int k = length-i; k < length; k++)
                {
                    Console.Write("*");
                }

                for (int l = length-i+1; l < length; l++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
            for (int i = 1; i < length; i++)
            {
                for (int m = length-i; m < length; m++)
                {
                    Console.Write(" ");
                }
                for (int n = i; n < length; n++)
                {
                    Console.Write("*");
                }
                for (int o = 1; o < length-i; o++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
