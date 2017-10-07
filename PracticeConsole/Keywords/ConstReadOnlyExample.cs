using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

 

namespace PracticeConsole.Flow_Control
{
    class ConstReadOnlyExample
    {
        readonly int a = 10;
        const int b = 30;
        int c;
        readonly string r;

        public ConstReadOnlyExample () 
        
        {
            r = ConfigurationSettings.AppSettings["DollarPrice"];
            
            Console.WriteLine ("The dollar value is:" + " " + r);
            // we can change read only variable value in constructor at runtime
            Console.WriteLine ();
            c = a + b;
            Console.WriteLine ("The addition of readonly variable and constant is :" 
                                    + Environment.NewLine + c);
            Console.ReadLine ();
        }

        static void Mainn (string[] args)
        {
            ConstReadOnlyExample p = new ConstReadOnlyExample ();
            
            Console.ReadLine ();
        }
    }

}

