using System;

namespace PracticeConsole
{
    class FindStringOrInteger
    {
        static void MainMethod()
        {
            Console.WriteLine (" please type your input and press enter key ");
            string strInput = Console.ReadLine ();

            int result = 0;

            if(int.TryParse(strInput, out result))
            {
                Console.WriteLine ("you input {0} is a number", result);
                Console.ReadLine ();
            }
            else
            {
                Console.WriteLine ("your input {0} is NOT a number", strInput);
                Console.ReadLine ();
            }
        }
    }
}
