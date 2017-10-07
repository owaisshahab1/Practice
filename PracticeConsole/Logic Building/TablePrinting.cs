using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsole
{
    class TablePrinting
    {
        public static void MainM ()
        {
            int num, multiplier = 1;

            Console.Write ("Insert a number to multiply: ");
            num = Convert.ToInt32 (Console.ReadLine ());

            while (multiplier <= 10)
            {
                Console.WriteLine ("{0} x {1} = {2}",
                    num, multiplier, num * multiplier);
                multiplier++;
            }
            Console.ReadLine ();
        }


        public static void Mainma ()
        {
            int num, multiplier;

            num = 2;

            do
            {

                multiplier = 1;
                do
                {
                    Console.WriteLine ("{0} x {1} = {2}",
                        num, multiplier, num * multiplier);
                    multiplier++;
                }
                while (multiplier <= 10);

                Console.WriteLine ();
                num++;

            } while (num <= 20);
            Console.ReadLine ();
        }


    }
}
