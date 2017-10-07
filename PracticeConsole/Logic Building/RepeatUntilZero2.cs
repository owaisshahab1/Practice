using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsole.Practice
{
    class RepeatUntilZero2
    {

        public static void MainM ()
        {
            int number;

            do
            {
                Console.Write ("Enter a number: ");
                number = Convert.ToInt32 (Console.ReadLine ());

                Console.WriteLine (number * 10);
            }
            while (number != 0);
        }

    }
}
