using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
delegate T NumberChanger<T> (T n);
namespace PracticeConsole
{
    class GenericDelegatesClass
    {

        static int num = 10;

        public static int AddNum (int p)
        {
            num += p;
            return num;
        }

        public static int MultNum (int q)
        {
            num *= q;
            return num;
        }

        public static int getNum ()
        {
            return num;
        }

        static void Mainm (string[] args)
        {
            //create delegate instances
            NumberChanger<int> nc1 = new NumberChanger<int> (AddNum);  // passing method as a paramater
            NumberChanger<int> nc2 = new NumberChanger<int> (MultNum); // passing method as a paramater

            // here we can also use char , string and any other data type but first define method with its data type in above class
            // after that create object with that data type and call that object.

            // and we can also define above generic method for all data types

            //calling the methods using the delegate objects
            nc1 (25); // this delegate object has method reference
            Console.WriteLine ("Value of Num: {0}", getNum ());



            nc2 (5);  // this delegate object has method reference
            Console.WriteLine ("Value of Num: {0}", getNum ());

            Console.ReadKey ();
            
        }


    }
}
