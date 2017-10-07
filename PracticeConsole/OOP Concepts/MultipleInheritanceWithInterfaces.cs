using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsole.Practice
{
    class MultipleInheritanceWithInterfaces
    {
        interface addition
        {
            int add (int a, int b);
        }

        interface subtraction
        {
            int sub (int x, int y);
        }



        class Calculation : addition, subtraction
        {
            public int result1;
            public int add (int a, int b)
            {
                return result1 = a + b;
            }

            public int result2;
            public int sub (int x, int y)
            {
                return result2 = x - y;
            }
            

            static void MainM (string[] args)
            {
                Calculation c = new Calculation ();

                c.add (8, 2);
                c.sub (25, 10);


                Console.WriteLine ("Multiple Inheritance concept Using Interfaces :\n ");

                Console.WriteLine ("Addition : " + c.result1);
                Console.WriteLine ("Subtraction : " + c.result2);


                Console.ReadKey ();
            }
        }
    }
}

