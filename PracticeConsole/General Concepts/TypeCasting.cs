using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsole
{
    class TypeCasting
    {
        static void MainMethod(string[] args)
        {
            object o = "somestring";       // object to object casting using "AS" keyword
            String str = o as string; 

            object a = 123;
            String b = a as string;


            object owais = new Program();

            if (o is bool) // "is" use for checking data type 
            {
                Console.WriteLine("hello ");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("you are fool");
                Console.ReadLine();
            }
        }
    }
}
