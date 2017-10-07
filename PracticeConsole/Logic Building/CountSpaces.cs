using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsole
{
    class CountSpaces
    {
        static void Mainn (string[] args)
        {
            string s = "    this is a string";
            Console.WriteLine (count (s));
            Console.ReadKey ();
            
        }

        static int count (string s)

        {
            int total = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == ' ')
                    total++;
                else
                    break;
            }
            return total;
        }
    }
}
