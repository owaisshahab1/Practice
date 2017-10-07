using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsole.Content
{
    class GreatestOfThreeNumbers
    {
        public static void MainM ()
        {
            int number1, number2, number3;

            Console.Write ("Enter the number 1:");
            number1 = Convert.ToInt32 (Console.ReadLine ());

            Console.Write ("Enter the number 2:");
            number2 = Convert.ToInt32 (Console.ReadLine ());

            Console.Write ("Enter the number 3:");
            number3 = Convert.ToInt32 (Console.ReadLine ());

            if (number1 > number2 && number1 > number3)
                Console.WriteLine ("The number 1 is greatest");
            else if (number2 > number1 && number2 > number3)
                Console.WriteLine ("The number 2 is greatest");
            else if (number3 > number1 && number3 > number2)
                Console.WriteLine ("The number 3 is greatest");
            else
                Console.WriteLine ("Numbers equals");
            Console.ReadLine ();
        }
       
    }
}
