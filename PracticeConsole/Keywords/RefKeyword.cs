using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsole
{
    class RefKeyword
    {
     public static int function(ref int i)
        {
            int j = 15; // here we use ref keyword it change i value from all places new value of i is 15
            i = j;
            return i;
        }
        static void MainMethod(string[] args)
        {
            int i = 2; // this value of "i" is discarded because we use ref keyword new value is set
                       // by calling function which is i = 15
            function(ref i);
            Console.WriteLine(i);
            Console.ReadLine();
        }
    }
}
