using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsole
{
    class Delegate_Uses
    {
    }

    //class Utility
    //{
    //    public delegate int Transformer(int x);

    //    public static int Transform(int x, Transformer t)
    //    {
    //        return x = t(x);
    //    }
    //}

    public delegate void Transformer(int x);

    class program0
    {
        static void Main5(string[] args)
        {
            Console.WriteLine("enter the number");
            int i = int.Parse(Console.ReadLine());
            #region Code Comment
            //Transformer t;
            //t = Square;
            //int j = t.Invoke(i);
            //Transformer t = Square;
            //int j = t(i);
            //-----------------------------------
            //int j = Utility.Transform(i, Square);
            //int j = Utility.Transform(i, Cube);
            #endregion

            Transformer t;
            t = Square;
            t += Cube;
            t.Invoke(i);

            Notification obj = new Notification();
            obj.transformerEvent += User1.Xhandler; // Subscribe += and Unsubscribe -= ( only two options are available )
            obj.transformerEvent += User2.Yhandler; 
            obj.NotificationMethod(i);

            Console.ReadLine();



            //Console.WriteLine(j);
            //Console.ReadKey();

        }

        //public static int Square(int x)
        //{
        //    return x * x;
        //}
        //public static int Cube(int x)
        //{
        //    return x * x * x;
        //}

        static void Square(int x)
        {
            Console.WriteLine(x * x);
        }
        static void Cube(int x)
        {
            Console.WriteLine(x * x * x);
        }
    }

    class Notification
    {
        public event Transformer transformerEvent;

        public void NotificationMethod(int x)
        {
            if (transformerEvent != null)
            {
                transformerEvent(x);
            }
        }
    }


    class User1
    {
        public static void Xhandler(int x)
        {
            Console.WriteLine("Event Received User1");
        }
    }

    class User2
    {
        public static void Yhandler(int x)
        {
            Console.WriteLine("Event Received User2");
        }
    }

}