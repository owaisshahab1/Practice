using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsole.OOP_Concepts
{
    class OOP_SoloLearn
    {
        /*
        static void Main(string[] args)
        {
            int length = 10  ;
            for (int i = 1; i <= length; i++)
            {
                for (int j = i; j < length; j++)
                {
                    Console.Write(" ");
                }

                for (int k = length - i; k < length; k++)
                {
                    Console.Write("*");
                }
                for (int l = length - i + 1; l < length; l++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            for (int i = 1; i < length; i++)
            {
                for (int j = length - i; j < length; j++)
                {
                    Console.Write(" ");
                }

                for (int k = i; k < length; k++)
                {
                    Console.Write("*");
                }

                for (int l = 1; l < length - i; l++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
            Console.ReadKey();

        }
        */

        //static void Main(string[] args)
        //{
        //    int num = 12;
        //    Resb(ref num);
        //    Console.Write(num +"#");
        //    Console.ReadLine();
        //}
        //static void Resb(ref int num)
        //{
        //    num *= 10;
        //    Console.Write(num);
        //}

        //static void Main(string[] args)
        //{
        //    Console.Write(5/2 + 2.5 + "\n");
        //    Console.WriteLine(5.0/2 + 2.5);
        //    Console.ReadLine();

        //}


        //static void Main(string[] args)
        //{
        //    string s = "";
        //    char[] arr = new char[] { 'x', 'y', 'z', 'e', 'd' };
        //    foreach (char c in arr)
        //    {
        //        if (c <= 'x')
        //         s += c;
        //    }
        //    Console.Write(s);
        //}




        //static void Main(string[] args)
        //{
        //    int x = 6;
        //    x = sum(x);
        //    Console.WriteLine(x);
        //}
        
        //static int sum(int x)
        //{
        //    if (x != 0)
        //    {
        //        return x + sum(x - 1);
        //    }
        //    else
        //    {
        //        return x;
        //    }
        //}




        //static void Main(string[] args)
        //{
        //    var a ;
        //    a = 1;
        //    Console.Write(a);
        //}


        //static void Main(string[] args)
        //{
        //    int a = default(int);
        //    Console.WriteLine(a);
        //    Console.ReadLine();
        //}


        //static void Main(string[] args)
        //{
        //    int x = 6;
        //    int y = 4;
        //    if (x * x + y * y > 50)
        //    {
        //        x %= y;
        //    }
        //    else
        //    {
        //        x *= y;
        //    }
        //    Console.WriteLine(x);
        //    Console.ReadLine();
        //}



        //static void Main(string[] args)
        //{
        //    double d = 3.5;
        //    int i = Convert.ToInt32(d);
        //    Console.WriteLine(i+d);
        //    Console.ReadLine();
        //}





        //public class test
        //{
        //    public int a = 5;
        //    public test()
        //    {
        //        int a = 3;
        //        a++;
        //    }
        //}

        //static void Main(string[] args)
        //{
        //    test t = new test();
        //    Console.WriteLine(t.a);
        //    Console.ReadLine();
        //}


        //static void Mainqw(string[] args)
        //{
        //    string str = "owais,shahab,khan";
        //    string[] str1 = str.Split(',');
        //    foreach (string item in str1)
        //    {
        //        Console.WriteLine(item);
        //    }
        //    Console.ReadLine();
        //}


        //class Animal {
        //    public int Legs { get; set; }
        //    public Animal() { Legs = 4; }
        //}

        //class Spider : Animal
        //{
        //    public Spider() { Legs += 4; }
        //}

        //static void Main(string[] args)
        //{
        //        Spider s = new Spider();
        //        Console.Write(s.Legs);
        //    Console.ReadKey();
        //}






        //    class Car
        //{
        //    public virtual  void Model()
        //    {
        //        Console.Write("n");
        //    }
        //}
        //class SpeedCar : Car
        //{
        //    public override void Model()
        //    {
        //        Console.Write("s");

        //    }
        //(}
        //static void Main(string[] args)
        //{
        //    Car car = new SpeedCar();
        //    car.Model();
        //    Console.ReadKey();
        //}



        //class PropertyTest
        //{
        //    private double test;
        //    public double proptest
        //    {
        //        get { return test * test; }
        //        set { test = value; }
        //    }
        //}
        //public static void Main()
        //{
        //    PropertyTest pt = new PropertyTest();
        //    pt.proptest = 5;
        //    Console.Write(pt.proptest);
        //    Console.ReadKey();
        //}





        //class alpha
        //{

        //}
        //class beta : alpha
        //{

        //}
        //static void Main(string[] args)
        //{
        //    alpha b = new beta();
        //    Console.Write(b.GetType().Name);
        //    Console.ReadKey();
        //    }



        //class Class
        //{
        //    public int x = 10;
        //    public int y = 11;
        //    public Class()
        //    {
        //        x += 12; y += 13;

        //    }
        //    ~Class ()
        //    {
        //        x += 18; y += 15;
        //    }
        //}
        //static void Main (string[] args)
        //{
        //    Class c = new Class ();
        //    Console.Write (c.x + c.y);
        //    Console.ReadKey ();
        //}





        //struct Struct
        //{
        //    public int x;

        //}
        //static void Main(string[] args)
        //{
        //    Struct s1 = new Struct();
        //    Struct s2 = s1;
        //    s2.x = 20;
        //    Console.WriteLine(s1.x + s2.x);
        //    Console.ReadLine();

        //}


    }
}
