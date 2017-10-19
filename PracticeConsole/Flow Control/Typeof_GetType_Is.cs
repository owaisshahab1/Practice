using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// "typeof" takes a type name(which you specify at compile-time).
// "GetType" gets the type of an instance at run-time.
// "is" returns true if an instance is in the inheritance tree.

namespace PracticeConsole.Flow_Control
{
    class Typeof_GetType_Is
    {
        class Animal { }

        class Dog : Animal { }

        // in arguments we always pass reference class not object class
        static void PrintTypes (Animal animal_obj) // animal_object is just a name actually dog object is passing
        {
            Console.WriteLine (animal_obj.GetType () == typeof (Animal)); // false

            Console.WriteLine (animal_obj is Animal); // belongs to     // true 

            Console.WriteLine (animal_obj.GetType () == typeof (Dog));    // true
        }
        static void Main100 (string[] args)
        {
            Animal dog_obj = new Dog ();
            PrintTypes (dog_obj);
            Console.ReadKey ();
        }




    }
}
