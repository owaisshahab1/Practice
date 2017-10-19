using PracticeConsole;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsole
{
    class OperatorOverloading
    {
        public int number;
        public OperatorOverloading()
        {
            number = 0;
        }
        public OperatorOverloading(int n)
        {
            number = n;
        }
        public static OperatorOverloading operator +(OperatorOverloading d1, OperatorOverloading d2)
        {
            OperatorOverloading d3 = new OperatorOverloading();
            d3.number = d1.number * d2.number; // here we overload +(plus) operator into *(multiply)
            return d3;
        }
        public void display()
        {
            Console.WriteLine("{0}", number);
        }
    }
}

class Program
{
    static void MainMethod(string[] args)
    {
        OperatorOverloading d = new OperatorOverloading(5);
        OperatorOverloading d4 = new OperatorOverloading(4);
        OperatorOverloading d5 = new OperatorOverloading();
        d5 = d + d4; // operator overloading + actually call above function
                     // where we actually * two values
        d.display(); // 5
        d4.display(); // 4
        d5.display(); // 20
        System.Console.Read();
    }
}



