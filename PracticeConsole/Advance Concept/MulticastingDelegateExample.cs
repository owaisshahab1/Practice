using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

delegate int NumberChanger2 (int n);
namespace PracticeConsole.Flow_Control
{
    class MulticastingDelegateExample
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
            NumberChanger2 nc;
            NumberChanger2 nc1 = new NumberChanger2 (AddNum);
            NumberChanger2 nc2 = new NumberChanger2 (MultNum);
            nc = nc1;
            nc += nc2;

            //calling multicast
            nc (5);
            Console.WriteLine ("Value of Num: {0}", getNum ());
            Console.ReadKey ();
        }

    }
}
