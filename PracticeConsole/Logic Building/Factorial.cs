using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsole
{
    class Factorial
    {
        static void MainMethod(string[] args)
        {
            int i, number, fact;
            System.Console.Write("Enter the Number : ");
            number = int.Parse(System.Console.ReadLine());
            fact = number;
            for (i = number - 1; i >= 1; i--)
            {
                fact = fact * i;
            }
            System.Console.WriteLine("\nFactorial of Given Number is: " + fact);
            System.Console.ReadLine();

        }
    }
}
