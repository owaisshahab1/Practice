using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace PracticeConsole
{
    //    class ArrayListExample
    //    {
    //        static void Main()
    //        {
    //            //
    //            // Create an ArrayList and add two ints.
    //            //
    //            ArrayList al = new ArrayList();
    //            al.Add(5);
    //            al.Add(7);
    //            //
    //            // Use ArrayList with method.
    //            //
    //            Example(al);
    //        }

    //        static void Example(ArrayList al)
    //        {
    //            foreach (int i in al)
    //            {
    //                Console.WriteLine(i);
    //            }
    //            Console.ReadLine();
    //        }
    //    }
    //}



    class Program1
    {
        static void MainM()
        {
            //
            // Create an ArrayList with two values.
            //
            ArrayList list = new ArrayList();
            list.Add(5);
            list.Add(7);
            //
            // Second ArrayList.
            //
            ArrayList list2 = new ArrayList();
            list2.Add(10);
            list2.Add(13);
            //
            // Add second ArrayList to first.
            //
            list.AddRange(list2);
            //
            // Display the values.
            //
            foreach (int i in list)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}

