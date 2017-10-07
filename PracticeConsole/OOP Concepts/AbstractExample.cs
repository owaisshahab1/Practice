using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsole.Practice
{
    public abstract class Shape
    {
        public abstract void draw ();
    }

    class Rectangle : Shape
    {
        public override void draw ()
        {
            Console.WriteLine ("Draw Rectangle");
        }
    }

    class Triangle : Shape
    {
        public override void draw ()
        {
            Console.WriteLine ("Draw Triangle");
        }
    }
    class AbstractExample
    {

        public static void MainM ()
        {
            Shape s1 = new Rectangle ();

            s1.draw ();
            s1 = new Triangle ();
            s1.draw ();

            Console.ReadKey ();
        }
    }
}
