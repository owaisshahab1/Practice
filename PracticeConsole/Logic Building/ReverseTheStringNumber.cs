using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsole
{
    class ReverseTheStringNumber
    {

        static void MainMethod (string[] args)
        {
            Console.WriteLine ("Enter a No. to reverse");
            int Number = int.Parse (Console.ReadLine ());
            int Reverse = 0;
            while (Number > 0)
            {
                int remainder = Number % 10;
                Reverse = (Reverse * 10) + remainder;
                Number = Number / 10;
            }
            Console.WriteLine ("Reverse No. is {0}", Reverse);
            Console.ReadLine ();
        }
    }
}