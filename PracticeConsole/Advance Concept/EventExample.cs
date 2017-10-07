using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsole.Flow_Control
{
    class EventExample
    {

        public delegate string MyDel (string str);

        class EventProgram
        {
            event MyDel MyEvent;

            public EventProgram ()
            {
                this.MyEvent += new MyDel (this.WelcomeUser); 
                // here we pass delegate to event and method to delegate
                // so indirectly we are passing method to event 
            }

            public string WelcomeUser (string username)
            {
                return "Welcome " + username;
            }

            static void Mainm (string[] args)
            {
                EventProgram obj1 = new EventProgram ();
                string result = obj1.MyEvent ("Tutorials Point");
                Console.WriteLine (result);
                Console.ReadKey ();
            }
        }
    }
}
