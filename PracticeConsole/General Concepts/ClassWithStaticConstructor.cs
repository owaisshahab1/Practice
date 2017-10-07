using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsole
{
    static class ClassWithStaticConstructor
    {
        public static int a = 0;

        static ClassWithStaticConstructor ()
        { Console.WriteLine (" i am in static constructor"); }
        // static constructor of any class can be call only once in any class

       //public ClassWithStaticConstructor ()
     //   { Console.WriteLine ("This is public Instance Constructor"); }
    }

   class different
    {
        static void MainM()
        {
            //  ClassWithStaticConstructor obj1 = new ClassWithStaticConstructor ();
            ClassWithStaticConstructor.a = 2;
            Console.WriteLine ();
            //  ClassWithStaticConstructor obj2 = new ClassWithStaticConstructor ();
            ClassWithStaticConstructor.a = 6;
            Console.WriteLine ();
          //  ClassWithStaticConstructor obj3 = new ClassWithStaticConstructor ();

            Console.ReadLine ();

        }
    }
}
