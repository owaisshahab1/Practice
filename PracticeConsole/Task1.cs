using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsole
{
    class Task1
    {
        public static string str = "This is @a random@text @to perform@the task@@@@@@@@@@@@@@@";
        public static  string[] fk;

        string abc;

        static void Main541 (string[] args)
        { fk = new string[120];

            //    str = str.Replace ("@@@", "");
            //   str = str.Replace ("#", "");
            //   str = str.Substring (3, str.Length-4);
            fk = str.Split ("@".ToCharArray(),StringSplitOptions.RemoveEmptyEntries);
          

                
            //fk[]

        }
    }
}
