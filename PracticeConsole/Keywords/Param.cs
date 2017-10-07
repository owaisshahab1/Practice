using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsole
{
    class Param
    {


        // Using params allows you to call the function with no arguments.Without params:

        static public int addTwoEach(int[] args)
        {
            int sum = 0;

            foreach (var item in args)
            {
                sum += item + 2;
            }

            return sum;
        }

        // addtwoEach(); // throws an error

  //======================================================================================      
            
            // with param

       //static public int addTwoEach(params int[] args)
       // {
       //     int sum = 0;

       //     foreach (var item in args)
       //     {
       //         sum += item + 2;
       //     }

       //     return sum;
       // }

       //  addtwoEach(); // returns 0

        // you can use params when the number of arguments
        // can vary from 0 to infinity, and use an array when numbers of arguments vary from 1 to infinity.




    }
}
