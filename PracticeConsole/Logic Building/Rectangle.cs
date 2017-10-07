using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsole.Flow_Control
{
    class Rectangle
    {

        //        Write a program which asks for a number, a width and a height and displays a rectangle of that width and that height, using that number for the inner symbol, as in this example: 

        //Enter a number: 4 
        //Enter the desired width: 3 
        //Enter the desired height: 5 

        //444 
        //444 
        //444 
        //444 
        //444 

        public static void Mainm ()
        {
            int n;
            int row, column;

            Console.Write ("Enter a number: ");
            n = Convert.ToInt32 (Console.ReadLine ());

            Console.Write ("Enter the desired: ");
            row = Convert.ToInt32 (Console.ReadLine ());

            Console.Write ("Enter the desired height: ");
            column = Convert.ToInt32 (Console.ReadLine ());

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j< column; j++)
                    Console.Write (n);

                Console.WriteLine ();
            }
            Console.ReadLine ();

        }
    }
}