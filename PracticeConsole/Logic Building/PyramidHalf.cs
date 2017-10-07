using System;

namespace PracticeConsole
{
    class PyramidHalf
    {

        // top left fill and bottom left is one
        //   *****
        //   ****
        //   ***
        //   **
        //   *
        //static void Main()
        //{
        //    int length = 5;
        //    for (int i = 0; i < length; i++)
        //    {
        //        for (int j = length-i; j >= 1; j--)
        //        {
        //            Console.Write("*");
        //        }
        //        Console.WriteLine();
        //    }
        //   // Console.WriteLine("");
        //    Console.ReadLine();
        //}
        //    }
        //}
        // top left is one and  left bottom is fill
        //    *
        //    **
        //    ***
        //    ****
        //    *****

        //        static void Main()
        //        {
        //            int length = 5;
        //            for (int i = 0; i < length; i++)
        //            {
        //                for (int j = (length - i); j <= length; j++)
        //                {
        //                    Console.Write("*");
        //                }
        //                Console.WriteLine();
        //            }
        //            Console.ReadLine();
        //        }
        //    }
        //}

        // top right is one and bottom right is fill

        //       *
        //      **
        //     ***
        //    ****
        //   *****
        //        static void Main()
        //        {
        //            int length = 5;
        //            for (int i = 0; i < length; i++)
        //            {
        //                for (int j = (length-1)-i; j >= 0; j--)
        //                {
        //                    Console.Write(" ");
        //                }

        //                for (int k = (length - i); k <= length; k++)
        //                {
        //                    Console.Write("*");
        //                }
        //                Console.WriteLine();
        //            }
        //            Console.ReadLine();
        //        }
        //    }
        //}


        // top right is fill and bottom right is one

        //   *****
        //    ****
        //     ***
        //      **
        //       *
        static void MainMethod()
        {
            int length = 5;
            for (int i = 0; i < length; i++)
            {
                for (int j = i; j < i+i ; j++)
                {
                    Console.Write(" ");
                }
                for (int k = length - i; k >= 1; k--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            // Console.WriteLine("");
            Console.ReadLine();
        }
    }
}