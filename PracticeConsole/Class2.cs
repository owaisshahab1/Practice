using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsole
{
    class Class2
    {
        static void Main66 ()
        {
            // This program takes a random integer and then shifts it right.
            // ... Then it shifts it left.
            // ... It displays the bits and also the decimal representation.
            int value1 = new Random ().Next ();
            for (int i = 0; i < 32; i++)
            {
                int shift = value1 >> i;
                Console.WriteLine ("{0} = {1}",
                GetIntBinaryString (shift), shift);
            }
            for (int i = 0; i < 32; i++)
            {
                int shift = value1 << i;
                Console.WriteLine ("{0} = {1}",
                GetIntBinaryString (shift), shift);
            }
        }

        static string GetIntBinaryString (int n)
        {
            char[] b = new char[32];
            int pos = 31;
            int i = 0;

            while (i < 32)
            {
                if ((n & (1 << i)) != 0)
                {
                    b[pos] = '1';
                }
                else
                {
                    b[pos] = '0';
                }
                pos--;
                i++;
            }
            return new string (b);
        }
    }
}