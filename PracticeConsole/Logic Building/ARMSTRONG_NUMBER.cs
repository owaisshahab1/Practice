using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsole.Logic_Building
{
    class ARMSTRONG_NUMBER
    {

        static void MainM (string[] args)
        {
            Console.WriteLine ("Enter the maximum limit for searching");
            int max = Convert.ToInt32 (Console.ReadLine ());
            
            for (int i = 1; i <= max; i++)
            {
                if (isArmstrong (i))
                    Console.WriteLine (i);
            }
            Console.ReadLine ();
        }

        static bool isArmstrong (int x)
        {
            int sum = 0;
            
            for (int i = x; i > 0; i = i / 10)
            {
              
                sum = sum + (int)Math.Pow (i % 10, 4.0); // here is the problem only work for 4 digit number
            }

            if (x == sum)
                return true;
            else
                return false;
        }
    }
}