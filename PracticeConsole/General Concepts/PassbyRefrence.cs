using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsole
{
    class PassbyRefrence
    {
        static void MainMethod ()
        {
            int value = 10;
            function (ref value); // this is call parameters

            Console.WriteLine (value);
            Console.ReadLine ();

        }
        static void function(ref int value) // this is call arguments
                {
                value += 5; // value change globally 
               
            }
        }
    }

