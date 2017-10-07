using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsole.Flow_Control
{
    class Password
    {
        public static void Mainm ()
        {
            int user, pass;

            do
            {
                Console.Write ("Enter a user:  ");
                user = Convert.ToInt32 (Console.ReadLine ());

                Console.Write ("Enter a password:  ");
                pass = Convert.ToInt32 (Console.ReadLine ());

                if ((user != 12) || (pass != 1234))
                    Console.WriteLine ("Login Error");

            }
            while ((user != 12) || (pass != 1234));

            Console.WriteLine ("Login successful");
        }
    }
}
