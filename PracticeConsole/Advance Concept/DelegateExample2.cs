using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsole.Flow_Control
{
    class DelegateExample2
    {


        static FileStream fs;
        static StreamWriter sw;

        // delegate declaration
        public delegate void PrintDelegate (string s);

        // this method prints to the console
        public static void WriteToScreen (string str)
        {
            Console.WriteLine ("The String is: {0}", str);
        }

        //this method prints to a file
        public static void WriteToFile (string s)
        {
            fs = new FileStream ("E:\\message.txt",
            FileMode.Append, FileAccess.Write);
            sw = new StreamWriter (fs);
            sw.WriteLine (s);
            sw.Flush ();
            sw.Close ();
            fs.Close ();
        }

        // this method takes the delegate as parameter and uses it to
        // call the methods as required
        public static void sendString (PrintDelegate ps)
        {
            ps ("Hello World 2");
        }
        static void Mainm (string[] args)
        {
            PrintDelegate ps1 = new PrintDelegate (WriteToScreen);
            PrintDelegate ps2 = new PrintDelegate (WriteToFile);
            sendString (ps1);
            sendString (ps2);
            Console.ReadKey ();
        }
    }
}
