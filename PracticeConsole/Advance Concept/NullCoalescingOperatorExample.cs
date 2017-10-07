using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsole.Flow_Control
{
    class NullCoalescingOperatorExample
    {
        // Null Coalescing Operator ( ?? )

        static void Mainn (string[] args)
        {
            double? num1 = null;
            double? num2 = 3.14157;
            double num3;
            num3 = num1 ?? 5.34;
            Console.WriteLine (" Value of num3: {0}", num3);
            num3 = num2 ?? 5.34;
            Console.WriteLine (" Value of num3: {0}", num3);
             Console.WriteLine ("\a"); // sound generate
            Console.ReadLine ();
        }

    }
}
