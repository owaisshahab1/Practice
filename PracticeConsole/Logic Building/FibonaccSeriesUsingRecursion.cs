using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsole.Content
{
    class FibonaccSeriesUsingRecursion
    {

        public static void MainM (string[] args)
        {

            Console.Write ("Enter the limit : ");
            int limit = Convert.ToInt32 (Console.ReadLine ());
            Fibonacci (0, 1, 1, limit);
            Console.Read ();
        }
        public static void Fibonacci (int CurrentValue, int PreviousValue, int counter, int limit)
        {
            Console.WriteLine (CurrentValue);
            if (counter < limit)
            Fibonacci (PreviousValue, CurrentValue + PreviousValue, counter + 1, limit);
        }

    }
}
