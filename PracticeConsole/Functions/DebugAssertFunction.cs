using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PracticeConsole
{
    class DebugAssertFunction
    {
        static void MainMethod()
        {
            string a = "ow";
            Debug.Assert(a == "owais"); // compiler produce error here because condition is false so we can 
                                        // check any value before entering in any loop or function.

            Console.WriteLine("ok");
            System.Console.ReadLine();
        }
    }
}
