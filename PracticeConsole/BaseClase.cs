using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsole
{
    class BaseClase
    {
        public virtual void draw ()
        {
            Console.WriteLine ("base class calling");
            
        }
    }
    class drived_1 : BaseClase
    {
        public override void draw ()
        {
            
            Console.WriteLine ("drived_1 class calling");
            
        }
    }
    class drived_2 : drived_1
    {
        public override void draw ()
        {
            Console.WriteLine ("drived_2 class calling");
            
        }

        static void Mainn8 (string[] args)
        {
            BaseClase objbase = new BaseClase ();
            drived_1 objdr1 = new drived_1 ();
            drived_2 objdr2 = new drived_2 ();
            objbase.draw ();
            objdr1.draw ();
            objdr2.draw ();
            Console.ReadKey ();
        }
    }
}
