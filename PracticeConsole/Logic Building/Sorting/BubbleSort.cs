using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsole.Content
{
    class BubbleSort
    {

        static void MainM (string[] args)
        {
            
            int[] Container = { 12, 5, 6, 8 };

            int temp = 0;

            for (int write = 0; write < Container.Length; write++) //outer loop iterates n times(n is the length of the array)
            {
                for (int sort = 0; sort < Container.Length - 1; sort++) //inner loop will iterate n-1 times
                {
                    if (Container[sort] > Container[sort + 1]) //logic: if the LHS value is greater than RHS then swap the value
                    {
                        //swap logic
                        temp = Container[sort + 1];
                        Container[sort + 1] = Container[sort];
                        Container[sort] = temp;
                    }
                }
            }

            //print the sorted array on console
            for (int i = 0; i < Container.Length; i++)
                Console.Write (Container[i] + " ");

            //keeps the console open till any key is entered
            Console.ReadKey ();
        }


    }
}
