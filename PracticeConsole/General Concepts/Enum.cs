using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsole
{
    class Enum
    {
        public enum weekdays : int // int enum
        {
            monday = 6, // intial value and its increment by 1 for every new element
            tuesday,
            wednesday,
            thursday,
            friday,
            saturday,
            sunday = 0
        };


        static void Main105()
        {

            System.Console.WriteLine("enter number");
            int x = Convert.ToInt32(System.Console.ReadLine());
            weekdays wk = (weekdays)x; // unboxing // converting int value into object type


            switch (wk)
            {
                case weekdays.monday:
                    System.Console.WriteLine("monday");
                    break;
                case weekdays.tuesday:
                    System.Console.WriteLine("tuesday");
                    break;
                case weekdays.wednesday:
                    System.Console.WriteLine("wednesday");
                    break;
                case weekdays.thursday:
                    System.Console.WriteLine("thursday");
                    break;
                case weekdays.friday:
                    System.Console.WriteLine("friday");
                    break;
                case weekdays.saturday:
                    System.Console.WriteLine("saturday");
                    break;
                case weekdays.sunday:
                    System.Console.WriteLine("sunday");
                    break;
                default:
                    System.Console.WriteLine("7");
                    break;
            }
            System.Console.ReadLine();
        }
    }
}

