using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsole.Content
{
    class RepeatUntilZero
    {
        public static void MainM ()
        {
            int number;

            Console.Write ("Enter a number: ");
            number = Convert.ToInt32 (Console.ReadLine ());

            while (number != 0)
            {
                Console.WriteLine (number * 10);

                Console.Write ("Enter a number: ");
                number = Convert.ToInt32 (Console.ReadLine ());
            }
        }

    }
}
