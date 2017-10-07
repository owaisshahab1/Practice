using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
delegate void NumberChanger3 (int n);
namespace PracticeConsole.Flow_Control
{
    class AnonymousMethod
    {     

            static int num = 10;
            public static void AddNum (int p)
            {
                num += p;
                Console.WriteLine ("Named Method: {0}", num);
            }

            public static void MultNum (int q)
            {
                num *= q;
                Console.WriteLine ("Named Method: {0}", num);
            }

            public static int getNum ()
            {
                return num;
            }
            static void Mainm (string[] args)
            {
                //create delegate instances using anonymous method
                NumberChanger3 nc = delegate (int x)
                {
                    Console.WriteLine ("Anonymous Method: {0}", x);
                };

                //calling the delegate using the anonymous method 
                nc (10);

                //instantiating the delegate using the named methods 
                nc = new NumberChanger3 (AddNum);

                //calling the delegate using the named methods 
                nc (5);

                //instantiating the delegate using another named methods 
                nc = new NumberChanger3 (MultNum);

                //calling the delegate using the named methods 
                nc (2);
                Console.ReadKey ();
            }

        }
}
