using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsole
{
    class OutKeyword
    {
        static int Method(int i, int j, out string s1, out string s2)
        {
            int k = i * j; // here integer value calculated
            s1 = "I've been returned"; // here we define two strings
            s2 = null;
            return k;
        }
        static void MainMethod()
        {
            int a = 5, b = 3;
            string str1, str2; // we just declare string here but we define string in function
            int t = Method(a, b, out str1, out str2); // here two string and one integer value is return 
            Console.WriteLine(t);
            Console.WriteLine(str1);
            Console.WriteLine(str2);
            Console.ReadLine();
            // value is now 15 ??
            // str1 is now "I've been returned"
            // str2 is (still) null;
        }
    }
}