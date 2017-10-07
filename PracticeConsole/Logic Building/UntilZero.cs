using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsole
{
    class UntilZero
    {
        public static void Mainm ()
        {
            int number;
            int sum = 0;

            do
            {
                Console.Write ("Number: ");
                number = Convert.ToInt32 (Console.ReadLine ());

                sum = number + sum;

                if (number != 0)
                    Console.WriteLine ("Total: {0}", sum);
            }
            while (number != 0);

            Console.WriteLine ("Finished");
            Console.ReadLine ();
        }


    }
}
