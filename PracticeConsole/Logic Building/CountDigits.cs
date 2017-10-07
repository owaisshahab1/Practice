using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsole.Flow_Control
{
    class CountDigits
    {
        //        Objetive:
        //Create a program to calculate how many digits has a positive integer 
        //(hint: it can be done by dividing by 10 several times). 
        //If the user enters a negative integer, the program must show a warning message, and proceed with the equivalent positive number.
        //For example: 
        //Number? 32 
        //2 digits
        //Number? -4000 
        //(Warning: it is a negative number) 4 digits

        public static void Mainm ()
        {
            int number;
            
      
                int digit = 0;
                Console.Write ("Number ? ");
                number = Convert.ToInt32 (Console.ReadLine ());

                if (number < 0)
                {
                    Console.WriteLine ("(Warning: it is a negative number)");
                    number = -number;
                }


                do
                {
                    number = number / 10;
                    digit++;
                }
                while (number > 0);


                if (digit == 0)
                { digit = 1; }

                Console.WriteLine ("{0} digits", digit);
                Console.ReadLine ();

     
          


           
        }

    }
}
