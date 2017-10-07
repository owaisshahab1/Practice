using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsole.Logic_Building
{
    class FibonacciSeries
    {

        public static void MainM ()
        {
            int limit;
            int CurrentValue = 0;
            int PreviousValue = 1;

            Console.Write ("Enter the limit : ");
            limit = int.Parse (Console.ReadLine ());

            for (int i = 0; i < limit; i++)
            {
                Console.WriteLine (CurrentValue);
                int temp = CurrentValue;
                CurrentValue = PreviousValue;
                PreviousValue = temp + PreviousValue;
            }

            Console.Read ();
        }
    }
}
