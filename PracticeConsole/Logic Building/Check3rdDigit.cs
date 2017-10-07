using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsole.Logic_Building
{
    class Check3rdDigit
    {
        static void MainM()
        {
            int input = 265;
            if ((input / 100) == 7)
            {
                Console.WriteLine ("yes");
            }
            else
            { Console.WriteLine ("No"); }
            Console.ReadLine ();
        }
    }
}
