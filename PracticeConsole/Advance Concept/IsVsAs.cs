using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsole.Flow_Control
{
    class IsVsAs
    {
        static void Main45 (string[] args)
        {
            StringBuilder object1 = new StringBuilder ();
            if (object1 is StringBuilder)
            {
                Console.Write ("successfully check \"Is\" keyword is working");
            }
            else
            {
                Console.Write ("Sorry wrong object");
            }
            Console.ReadLine ();

        }

        static void Main541 (string[] args)
        {
            List<string> colorsObj = new List<string> ();
            colorsObj.Add ("Red");
            colorsObj.Add ("Blue");
            colorsObj.Add ("Green");

            //The as operator attempts to cast an object to a specific type, and returns null if it fails.

               Object obj1 = colorsObj as Object; // casting
            // converting colorsObj ( list type ) into obj1 ( object type )

            if (obj1 != null)
            {
                Console.Write ("Casting colorsObj into obj1 successful");
            }
            else
            {
                Console.Write ("colorsObj is null ( casting fail )");
            }
            Console.ReadKey ();
        }


    }
}
