using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsole
{
    // static struct {} // Error: The modifier 'static' is not valid for this item 

    //    static interface { } // Error: The modifier 'static' is not valid for this item 
       


    public class StaticClass
    {
        static public int length;
        static public void abcd() { }  // static class only contains static members and functions and must declare "Static" keyword
                                       // with every member and function.
                                       // stitic class does not have any constructor because its instance will not create.

        //  StaticClass () { } // Error:  Static classes cannot have instance constructors.   




        static StaticClass () { Console.WriteLine ("i ma in static constructor"); } // this constructor is useless.
        // ~StaticClass (); //  Error   Static classes cannot contain destructors.

        public StaticClass () { Console.WriteLine ("i am in public constructor"); }
    }



    class another
    {
      
        static void MainMethod()
        {
            // StaticClass obj = new StaticClass (); // Error: Cannot create an instance of the static class 'StaticClass'.	

            StaticClass.abcd (); // we can access static class member and functions by using its class name with "Dot".

            StaticClass obj1 = new StaticClass ();
            Console.ReadLine ();

            StaticClass obj2 = new StaticClass ();
            Console.ReadLine ();



        }
    }
}
