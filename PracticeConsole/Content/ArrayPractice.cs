using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PracticeConsole
{
    class ArrayPractice
    {
        static void Main232 ()
        {
            int[] numbers;
            int size;
            Console.WriteLine ("enter array size");
            size = int.Parse (Console.ReadLine ());

            numbers = new int[size];

            Console.WriteLine ("enter array element");
            for (int i = 0; i < size; i++)
            {
                numbers[i] = int.Parse (Console.ReadLine ());
            }
            numbers.Reverse ();

            for (int j = size - 1; j <= size; j--)
            {
                Console.WriteLine (numbers[j]);
                if (j == 0)
                {
                    break;
                }

            }

            string alpha = "ABCDEFGHIJKLMNOPQRSTUVQXYZ";
            for (int i = 0; i < 26; ++i)
            {
                //     alpha[i] = Console.ReadLine ();
            }

            foreach (char c in alpha)
            {
                Console.WriteLine (c);
            }
            Console.ReadLine ();
        }

        private static void Main (string[] args)
        {
            char[] letter = new char[26]
            {
                'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J',
                'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U',
                'V', 'W', 'X', 'Y', 'Z'
            };
            int letter_number = 0;

            //array of strings
            string[] diamond = new string[52];
            //get the letter
            Console.WriteLine ("User enters a Letter between A and Z ");
            char user_letter = Console.ReadKey ().KeyChar;
            Console.WriteLine ("");
            //search for letter number in the array letter
            for (int i = 0; i < letter.Length; i++)
            {
                if (letter[i] == user_letter)
                {
                    letter_number = i;
                    break;
                }
            }

            //construct diamond 

            for (int i = 0; i <= letter_number; i++)
            {
                //add initial spaces
                for (int j = 0; j < letter_number - i; j++)
                {
                    diamond[i] += " ";
                }

                //add letter (first time)
                diamond[i] += letter[i];

                //add space between letters
                if (letter[i] != 'A')
                {
                    for (int j = 0; j < 2 * i - 1; j++)
                    {
                        diamond[i] += " ";
                    }
                    //add letter (second time)
                    diamond[i] += letter[i];
                }
                // Draw the first part of the diamond as it's composing.
                Console.WriteLine (diamond[i]);
            }

            for (int i = letter_number - 1; i >= 0; i--)
            {
                // Draw the second part of the diamond
                // Writing the diamondArray in reverse order.
                Console.WriteLine (diamond[i]);
            }

            // Mark a pause
            Console.ReadKey ();
        }
        static void Main565 ()
        {

            Console.WriteLine (" enter size of array");
            int size = int.Parse (Console.ReadLine ());

            int[] numbers = new int[size];

            Console.WriteLine (" enter elements of array");
            for (int i = 0; i < size; i++)
            {
                numbers[i] = int.Parse (Console.ReadLine ());
            }

            Console.WriteLine ("printing array elements");
            foreach (int i in numbers)
            {
                Console.WriteLine (i);
            }
            Console.ReadLine ();
        }

        static void Main345 ()
        {
            int a = 2, b = 3;
            int[,] numbers = new int[a, b];
            for (int i = 0; i < a; i++) // row
            {
                for (int j = 0; j < b; j++) // column
                {
                    numbers[i, j] = int.Parse (Console.ReadLine ());
                }
            }
            // printing array values
            for (int k = 0; k < a; k++)
            {
                for (int l = 0; l < b; l++)
                {
                    Console.WriteLine (numbers[k, l]);
                }
            }
            Console.ReadLine ();
        }
    }
}
