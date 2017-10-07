using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsole.Flow_Control
{
    class Loop
    {
        public static void Mainm ()
        {
            int number, number2;
            int i;

            Console.Write ("Enter first number: ");
            number = Convert.ToInt32 (Console.ReadLine ());

            Console.Write ("Enter last number: ");
            number2 = Convert.ToInt32 (Console.ReadLine ());

            for (i = number; i <= number2; i++)
                Console.Write ("{0} ", i);

            Console.WriteLine ();

            i = number;
            while (i <= number2)
            {
                Console.Write ("{0} ", i);
                i++;
            }
            Console.WriteLine ();


            i = number;
            do
            {
                Console.Write ("{0} ", i);
                i++;
            }
            while (i <= number2);

            Console.WriteLine ();
            Console.ReadLine ();
        }

    }
}
