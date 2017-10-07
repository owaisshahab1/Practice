using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsole
{
    class NumberAmount
    {
        public static void Mainm ()
        {
            int num, amount;
            int i;

            Console.Write ("Enter a number: ");
            num = Convert.ToInt32 (Console.ReadLine ());
            Console.Write ("Enter an amount: ");
            amount = Convert.ToInt32 (Console.ReadLine ());

            for (i = 0; i < amount; i++)
                Console.Write (num);
            Console.WriteLine ();
            Console.WriteLine ();
            Console.WriteLine ();
            Console.WriteLine ();



            // different logic
            i = 0;
            while (i < amount)
            {
                Console.Write (num);
                i++;
            }
            Console.WriteLine ();
            Console.WriteLine ();
            Console.WriteLine ();




            // different logic
            i = 0;
            do
            {
                Console.Write (num);
                i++;
            }
            while (i < amount);
            Console.ReadLine ();
        }


    }
}
