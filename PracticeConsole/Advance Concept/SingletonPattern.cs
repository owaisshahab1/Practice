using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsole
{
    class SingletonPattern
    {
        private SingletonPattern()
        { Console.WriteLine ("Private Constructor"); }

        static void Main65 (string[] args)
        {
            SingletonPattern sp = new SingletonPattern ();
            Console.WriteLine (sp);
            Console.WriteLine (sp);
            Console.WriteLine (sp);
            Console.ReadLine ();
        }
    }
    class owais
    {
        static void MainMethod ()
        {
           
            //SingletonPattern obj = new SingletonPattern ();
            
        }
    }
 
}
