using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsole
{
    class UpDownCasting
    {
        class Parent
        { }
        class Child : Parent
        { }

    static void MainMethod()
        {
            Child childObj1 = new Child (); // normal case object and reference of same class

            Parent parentObj2 = new Parent (); // normal case object and reference of same class

            Parent childObj2 = new Child (); //Use Base class reference // up Casting // up Casting is implicit
            // making derived class object with base class reference is known as up-casting.

            Child childObj3 = (Child)childObj2; // Down Casting is Explicit
            // True- making derived class object with using derived class object with base class reference is known as Down-Casting

        }

    }

     
}
