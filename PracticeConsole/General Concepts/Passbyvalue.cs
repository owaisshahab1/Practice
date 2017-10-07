using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsole
{
    class Passbyvalue
    {
       
        static void function (int value)
        {
            value += 5; // value change inside the function not globally
          
        }

        static void MainMethod()
        {
            int value = 10;
            function (value);
            Console.WriteLine (value);
            Console.ReadLine ();
        }
    }
}
