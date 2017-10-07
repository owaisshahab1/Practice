using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsole.Flow_Control
{
    class PointerExample
    {
        //static unsafe void Main (string[] args)
        //{
        //    int var = 20;
        //    int *p = &var;
        //    Console.WriteLine ("Data is: {0} ", var);
        //    Console.WriteLine ("Address is: {0}", (int)p);
        //    Console.ReadKey ();
        //}

        // Retrieving the Data Value Using a Pointer
        //public static void Main ()
        //{
        //    unsafe
        //    {
        //        int var = 20;
        //        int* p = &var;
        //        //Console.WriteLine ("Data is: {0} ", var);
        //        Console.WriteLine ("Data is: {0} ", p->ToString ());
        //        Console.WriteLine ("Address is: {0} ", (int)p);
        //    }

        //    Console.ReadKey ();
        //}

        //class TestPointer
        //{
        //    public unsafe void swap (int* p, int* q)
        //    {
        //        int temp = *p;
        //        *p = *q;
        //        *q = temp;
        //    }

        //    public unsafe static void Main ()
        //    {
        //        TestPointer p = new TestPointer ();
        //        int var1 = 10;
        //        int var2 = 20;
        //        int* x = &var1;
        //        int* y = &var2;

        //        Console.WriteLine ("Before Swap: var1:{0}, var2: {1}", var1, var2);


        //        p.swap (x, y); // passing pointer to method for swap their addresses


        //        Console.WriteLine ("After Swap: var1:{0}, var2: {1}", var1, var2);
        //        Console.ReadKey ();
        //    }

        // Accessing Array Elements Using a Pointer

        class TestPointer
        {
            public unsafe static void Mainm ()
            {
                int[] list = { 10, 100, 200 };
                fixed (int* ptr = list)

                /* let us have array address in pointer */
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine ("Address of list[{0}]={1}", i, (int)(ptr + i));
                    Console.WriteLine ("Value of list[{0}]={1}", i, *(ptr + i));
                }

                Console.ReadKey ();
            }

        }
    }
}

