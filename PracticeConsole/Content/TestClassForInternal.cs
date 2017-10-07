using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsole
{
    class TestClassForInternal  : ClassLibrary1.InternalClass
    {
        static void MainMethod ()
        {
            TestClassForInternal obj1 = new TestClassForInternal ();
            obj1.internalFunction (); // checking "protected internal" keyword

            

            ClassLibrary1.InternalClass obj2 = new ClassLibrary1.InternalClass ();
            obj2.internalVariable=0;     // checking " internal " keyword



        }
    }
}
