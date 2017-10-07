using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsole
{
    class BoxingUnboxing
    {
        static void MainMethod()
        { 
        int n = 10;
        object obj;
        obj = n ; // boxing -- converting value type to reference type -- (e.g int value type into object value type)
            Console.WriteLine (obj);
            Console.ReadLine ();

            int m;
            m = (int)obj;
            Console.WriteLine (m);
            Console.ReadLine (); // unboxing --(object into value)-- converting reference type to value type 

        }

    }
}
