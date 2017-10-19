using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsole
{
    class CastingObjects
    {
        class Shape
        {
            //Draw()available to base class Shape and all child classes
            public virtual void Draw ()
            {
                Console.WriteLine ("Draw function call from Parent(Shape) class");
            }
           public void BasedFunction()
            { }
        }

        class Circle : Shape
        {
           
           
            public override void Draw ()
            {
                Console.WriteLine ("Draw function call from drived(Circle) class ");
                
            }

            //Speciallized method available to only Circle class
            public void FillCircle ()
            {
                Console.WriteLine ("Filling a Circle");
            }

            public void DrivedFunction ()
            { }
        }
        static void Main101 (string[] args)
        {

            //Use Base class reference
            Shape DrivedObj = new Circle ();//Up-casting.
            DrivedObj.Draw (); // it call drived class Draw function if Draw function not available there then 
                                // it call base class Draw function

            ////This is called downcasting as assiging it from base to derived object

            Circle NewObject = (Circle)DrivedObj; //Down-casting-casting.
            NewObject.Draw (); // it call only drived class Draw function
                                // ( it can not access base class Draw function )
            NewObject.FillCircle ();
            Console.ReadLine ();

        }
    }
}