using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsole
{
    class StringReverse

    {
        /// <summary>
        /// Receives string and returns the string with its letters reversed.
        /// </summary>
        public static string ReverseString (string s)
        {
            char[] arr = s.ToCharArray ();
            Array.Reverse (arr);
            return new string (arr);
        }
    }

    class Program
    {
        static void MainMethod ()
        {
            Console.WriteLine (StringReverse.ReverseString ("framework"));
            Console.WriteLine (StringReverse.ReverseString ("samuel"));
            Console.WriteLine (StringReverse.ReverseString ("example string"));
            Console.ReadLine ();
        }

        
    }
   
}