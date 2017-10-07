using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace PracticeConsole.Flow_Control
{
    class SoloLearnPractice
    {

        struct Struct
        {
            public int x;
        }
        static void Main2 ()
        {
            Struct s1 = new Struct ();
            Struct s2 = s1;
            s2.x = 20;
            Console.WriteLine (s1.x + s2.x);
            Console.ReadLine ();
        }




        //    static void Main ()
        //    {


        //        int x = 1;
        //        int[,] m = new[,]
        //        {
        //        {2,1,3 },
        //        {2,5,4 },
        //        {4,3,5 }
        //    };

        //        for (int i = 0; i <= 2; i++)
        //        {
        //            x *= m[i, 2 - i];

        //        }

        //Console.WriteLine(x);
        //        Console.ReadLine();
        //    }


        //static void Main()
        //{

        //    int x = 1;
        //    int[] arr = { 9, 4, 5 };
        //    foreach (int i in arr)
        //    {
        //        if (i % 2 == 0)
        //        {
        //            x /= i;
        //        }
        //        else
        //        {
        //            x *= i;

        //        }
        //    };
        //    Console.WriteLine(x);
        //    Console.ReadLine();
        //}

        //static void Main(string[] args)
        //{
        //    int a = 12;
        //    string b = "12";
        //    if (a != Int32.Parse(b))
        //    {
        //        Console.WriteLine(b);
        //    }
        //    else
        //    {
        //        Console.WriteLine((a % (a - 6)) + 1);
        //    }
        //    Console.ReadKey();
        //}

        //    public static double x = 3;
        //    public void Func(double d)
        //    {
        //        x *= d;

        //    }
        //    public static void Func(float f)
        //    {
        //        x += f;

        //    }
        //    static void Main(string[] args)
        //    {
        //        SoloLearnPractice.Func(1);
        //        SoloLearnPractice o = new SoloLearnPractice();
        //        o.Func(2.0);
        //        Console.Write(SoloLearnPractice.x);
        //        Console.ReadLine();

        //}

        //static void Main(string[] args)
        //{
        //    int n;
        //    string str = "2017";
        //    n = Convert.ToInt32(Console.ReadLine());
        //    Console.Write("The result is " + n);
        //    Console.ReadLine();
        //}
        //static void Main(string[] args)
        //{
        //    string one = "sololearn";
        //    string two = one;
        //    string three = one.Remove(2);
        //    string four = two.Substring(4);
        //    Console.Write(three + four);
        //    Console.ReadLine();
        //}

        //static void Main(string[] args)
        //{
        //    Exception ex = new Exception();
        //    try {   ex; }
        //    catch{ Console.Write("42"); }
        //}

        //static List<int> list;
        //public void Add(int num)
        //{
        //    list = new List<int>();
        //    list.Add(num);

        //}

        //public void DisplaySum()
        //{
        //    Console.Write(list.Sum());
        //}
        //static void Main(string[] args)
        //{
        //    SoloLearnPractice s = new SoloLearnPractice();
        //    //list = new List<int>();
        //    s.Add(3);
        //    s.Add(2);
        //    s.Add(3);
        //    s.DisplaySum();
        //    Console.ReadLine();
        //}

        //static void Main(string[] args)
        //{
        //    double d = 4.49 * 2;
        //    double c = Math.Ceiling(d);
        //    double r = Math.Round(d);
        //    double f = Math.Floor(d);
        //    Console.WriteLine(c+r+f);
        //    Console.ReadLine( );
        //}

        //static void Main(string[] args)
        //{
        //    int x = 5;
        //    int y = 2;
        //    int z = x % y;
        //    y = z / x;
        //    Console.WriteLine(y);
        //    Console.ReadLine();
        //}








        //static void Main(string[] args)
        //{
        //    int myVariable = 0;
        //    if (myVariable > 0)
        //    {
        //        Console.Write(8);
        //    }
        //    else if (myVariable < 0)
        //    {
        //        Console.Write(6);
        //    }
        //    else
        //    {
        //        Console.WriteLine(2);
        //    }
        //    Console.ReadLine();
        //}

        //static void Main(string[] args)
        //{
        //    var a = 2;
        //    var b = "1";
        //    var c = 0;
        //    var d = int.Parse(a + b + c) / 21;
        //    Console.Write(d);
        //    Console.ReadLine();
        //}

        //static int i = 5;
        //static void Func(int i)
        //{ i = 10; }
        //static void Main(string[] args)
        //{
        //    Console.Write(i);
        //    Console.ReadLine();

        //}

        //static void Main(string[] args)
        //{
        //    int a = b++;
        //    int b = 4;
        //    Console.WriteLine(a);
        //    Console.ReadLine();
        //}

        //static void Main(string[] args)
        //{
        //    var a = 5;
        //    int b = 7;
        //    var c = "38";
        //    var d = int.Parse("42");
        //}

        //static void Main(string[] args)
        //{
        //    Console.Write( "0" + "0");
        //    Console.ReadLine();
        //}

        //static void Main(string[] args)
        //{
        //    Console.WriteLine(" \"test\" ");
        //    Console.ReadLine();
        //}



        //static void Main(string[] args)
        //{
        //    int i;
        //    for (i = 0; i <= 5; i++)
        //    {
        //        if (i == 4)
        //        {
        //            break;
        //        }
        //    }
        //    Console.Write(i);
        //    Console.ReadLine();
        //}

        //class Person
        //{
        //    private static int a = b++;
        //    private static int b = ++c;
        //    private static int c = 3;
        //    public Person()
        //    {
        //        Console.Write( a+ ":" +b+ ":" +c);
        //    }
        //}
        //static void Main(string[] args)
        //{
        //    Person p = new Person();
        //    Console.ReadLine();
        //}

        //static void Main(string[] args)
        //{
        //    int x = 0;
        //    int y = 0;
        //    try
        //    {
        //        x++;
        //        x = 1 / y;
        //        y++;
        //    }
        //    catch (Exception)
        //    {
        //        x = 0;

        //    }
        //    finally
        //    {
        //        x += 3;
        //        y *= 4;

        //    }
        //    Console.WriteLine(x + y);
        //    Console.ReadLine();
        //}

        //static void Main(string[] args)
        //{
        //    int i = 3;
        //    int count = 0;
        //    while (i<8)
        //    {
        //        i++;
        //        count++;
        //    }
        //    Console.Write(count%i); // 5 % 8 = 5 result
        //    // if numerator is smaller than denominator than result is numerator

        //    Console.ReadLine();
        //}

        //static void Main (string[] args)
        //{
        //    int x = 10;
        //    int z = x - 5;
        //    swap (ref z, ref x);
        //    double a = (double)(z - x) / (z / x);
        //    Console.Write (a);
        //    Console.ReadLine ();

        //}
        //static void swap (ref int a, ref int b)
        //{
        //    int temp = a;
        //    a = b;
        //    b = temp;

        //}







        //static void Main(string[] args)
        //{
        //    int[] n = new int[5];

        //    for (int j = 0; j < 5; j++)
        //    {
        //        Console.Write(n[j]);

        //    }
        //    Console.ReadLine();
        //}





        //static void Main(string[] args)
        //{

        //    Random rand = new Random();
        //    int r;
        //    for (int i = 0; i < 5; i++)
        //    {
        //        r = rand.Next(1, 2); // max value never selected
        //        Console.Write(r);
        //    }
        //    int x = rand.Next(1, 3);
        //    Console.Write(x);

        //    Console.ReadLine();
        //}


        //static void Main(string[] args)
        //{
        //    int foo = 1;
        //    for (int x = 5; x <= 50; x++)
        //    {
        //        foo *= x;
        //        for (int y = 1; y <= 5; y++)
        //        {
        //            if (x == y)
        //            { goto bar; }
        //            foo *= y;
        //        }
        //    }
        //    bar: Console.Write(foo);
        //    Console.ReadLine();
        //}


        //static void Main(string[] args)
        //{
        //    bool a = true;
        //    bool b = false;
        //    bool c = a || b;
        //    if (!(a && c) && (b || a))
        //    {
        //        Console.Write("right");
        //    }
        //    else
        //    {
        //        Console.Write("wrong");
        //    }
        //    Console.ReadLine();

        //}


        //static void Main(string[] args)
        //{
        //    int sum = 0;
        //    for (int i = 5; i > 0; i--)
        //    {
        //        for (int j = 1; j < i; j++)
        //        {
        //            sum += j;

        //        }
        //    }
        //    Console.Write(sum);
        //    Console.ReadLine();
        //}

        //static void Main(string[] args)
        //{
        //    int index;
        //    int val = 88;
        //    int[] a = new int[5];
        //    try
        //    {
        //        index = Convert.ToInt32(16);
        //        a[index] = val;
        //    }
        //    catch (Exception e)
        //    {
        //        Console.Write("exe");

        //    }
        //    Console.Write("next");
        //    Console.ReadLine();
        //}



        //class Class
        //{
        //    public int x = 12;
        //    public int X
        //    {
        //        get { return ++x; }
        //        set { x = ++value; }
        //    }
        //}


        //static void Main(string[] args)
        //{
        //    Class c = new Class();
        //c.X = c.X;
        //    Console.Write(c.X);
        //    Console.ReadLine();
        //}


        //static void Main(string[] args)
        //{
        //    int x = 4;
        //    x *= 5;
        //    x /= 2;
        //    x %= 3;
        //    Console.Write(x);
        ////    Console.ReadLine();

        //}

        //static int Square(int[] x)
        //{
        //    x[0] *= x[0];
        //    return x[0];
        //}
        //static int Square(ref int x)
        //{
        //    x *= x;
        //    return x;
        //}
        //static void Main(string[] args)
        //{
        //    int[] a = new int[1];
        //    a[0] = 3;
        //    int b = 4;
        //    Square(a);
        //    Square(ref b);
        //    Console.Write(a[0]+b);
        //    Console.ReadLine();
        //}

        //static int sm(ref int a, ref double A)
        //{
        //    --a;
        //    --A;
        //    if (a.GetType() == typeof(int))
        //        return (int)A;
        //    return a;
        //}
        //static void Main(string[] args)
        //{
        //    int A = 5;
        //    double a = -1.4;
        //    A = sm(ref A, ref a);

        //    Console.Write(Math.Abs(Math.Ceiling(A + a)));
        //    Console.ReadLine();
        //}


        //static void Main(string[] args)
        //{
        //    double a = -1.4;
        //    Console.WriteLine(Math.Abs(a)); // it make number positive
        //    Console.WriteLine(Math.Ceiling(a)); // it make number increase if number is in decimal value
        //    Console.ReadLine();         
        //}

        //static void Main(string[] args)
        //{
        //    Func<int, int> badFactorial = null;
        //    badFactorial = n => n 
        //    <= 1 ? 1 : n * badFactorial(--n - 1);
        //    Console.Write(badFactorial(5));
        //    Console.ReadLine();
        //}

        //static void Main(string[] args)
        //{
        //    int result = 0, zero = 0;
        //    try
        //    {
        //        result = 7 / zero;

        //    }
        //    catch (DivideByZeroException e)
        //    {
        //        Console.Write("Div0Error");

        //    }
        //    catch(Exception e)
        //    {
        //        Console.Write("Error");
        //    }
        //    finally
        //    {
        //        Console.Write(result);
        //    }
        //    Console.ReadLine( );  // output : Div0Error0

        //}








        //static void Main(string[] args)
        //{
        //    int x = 5;
        //    int y = x++;
        //    int z = x / 3;
        //    Console.Write(Mult(x, y, z));
        //    Console.ReadKey();
        //}
        //public static int Mult(int num1, int num2, int num3)
        //{
        //    return (num1 * num2 * num3);
        //}



        //class Item

        //{
        //    public int Number { get; set; }
        //    public Item(int x) { Number = x; }

        //    public static Item operator + (Item a, Item b)
        //    {
        //        int c = a.Number - b.Number;
        //        Item res = new Item(c);
        //        return res;
        //    }
        //    static void Main(string[] args)
        //    {
        //        Item n1 = new Item(5);
        //        Item n2 = new Item(4);
        //        Item n3 = n1 + n2;
        //        Console.Write(n3.Number);
        //        Console.ReadLine();
        //    }
        //}









        //class C
        //{
        //    public int x;
        //}
        //static void Main(string[] args)
        //{
        //    C o = new C(); // obj o
        //    o.x = 10; // obj o with var x
        //    C d = o; // obj d = obj o
        //    d.x = 16; // obj d with var x = 16 so value store in variable
        //    Console.Write(o.x); 
        //    Console.ReadKey();
        //}

        //static void Main (string[] args)
        //{
        //    int x = 10;
        //    do
        //    {
        //        x *= 2;
        //    } while (x <= 5);
        //    Console.Write (x);
        //    Console.ReadKey ();
        //}

        //static void Main (string[] args)
        //{
        //    int n = 5;
        //    int m = 7;
        //    int z = 6;
        //    if (++n < m && z == n++)
        //        Console.Write (m);
        //    else
        //        Console.Write (n);

        //    Console.ReadKey ();
        //  }

        //static void Main(string[] args)
        //{
        //    string x = ((1 + 2) == 6) ? "hello!!" : "learnc#";
        //    Console.Write(x);
        //    Console.ReadLine();
        //}



        //static void Main324 (string[] args)
        //{
        //    int color = (24 / 2) % 5;
        //    string s = ((Colors)color).ToString ();
        //    Console.Write (s);
        //    Console.ReadKey ();
        //}

        //static void Main(string[] args)
        //{
        //    int a = 0, b = 0;
        //    Func<int> f = () => a + b;
        //    a = 2;
        //    b = 3;
        //    Console.Write(f());
        //    Console.ReadKey();
        //}


        //static void Func(out int x, out int y)
        //{
        //    x = 4 + 3;
        //    y = x * 2;

        //}
        //static void Main(string[] args)
        //{
        //    int x = 8 - 5;
        //    int y = x + 6;
        //    Func(out x, out y);
        //    Console.Write(x + y);
        //    Console.ReadKey();
        //}

        //static void Main(string[] args)
        //{
        //    if ("abcMondaydef".Contains("monday"))
        //    {
        //        Console.Write("a");
        //    }
        //    else
        //        Console.Write("b");
        //    Console.ReadKey();
        //}




        //static void Main(string[] args)
        //{
        //    int a = 9;
        //    int b = a / 18; // when smaller value divide by bigger value 
        //                    // answer will be Zero always
        //    b++;
        //    Console.Write(b);
        //    Console.ReadKey();
        //}



        //static void Main (string[] args)
        //{
        //    int x = 2;
        //    int y = ++x + x++;
        //    int z = --y - x--;
        //    Console.Write (z);
        //    Console.ReadKey ( );
        //}


        //static void Main (string[] args)
        //{
        //    int a = Console.ReadLine ();
        //    int ab = Convert.ToInt32(Console.ReadLine ());
        //    string b = (1 + 2).ToString ();
        //}


        //static void Mainn343 (string[] args)
        //{
        //    var @a = "a";
        //    //okay
        //    Console.WriteLine (@a);
        //    //also okay, @ isn't part of the name
        //    Console.WriteLine (a);


        //    var @if = "if";
        //    //okay, treated as a name
        //    Console.WriteLine (@if);
        //    //compiler err, if without @ is a keyword
        //    Console.WriteLine (if) ;
        //}


        //static void Main (string[] args)
        //{



        //    //Regular strings use special escape sequences to translate to special characters.
        //    /*
        //    This string contains a newline
        //    and a tab    and an escaped backslash\
        //    */
        //    Console.WriteLine ("This string contains a newline\nand a tab\tand an escaped backslash\\");


        //    //Verbatim strings are interpreted as is, without translating any escape sequences:
        //    /* 
        //    This string displays as is. No newlines\n, tabs\t or backslash-escapes\\.
        //    */
        //    Console.WriteLine (@"This string displays as is. No newlines\n, tabs\t or backslash-escapes\\.");

        //    Console.ReadKey ();

        //}


        //static void Main (string[] args)
        //{
        //    bool a = true;
        //    bool b = false;
        //    bool r = (a && b) || ((a || b) && a);
        //    Console.Write (r);
        //    Console.ReadKey ();
        //}








        //static void Main (string[] args)
        //{
        //    char[] chars = new char[] { 'h', 'i' };
        //    string msg = "h";
        //    foreach (char c in chars)
        //    {
        //        msg += c;

        //    }
        //    Console.Write (msg);
        //    Console.ReadKey ();
        //}



        //static void Main (string[] args)
        //{
        //    int x = 0;
        //    int[][] arr =
        //    {
        //        new int[] {0},
        //        new int[] {1,3,5,7,9},
        //        new int[] {2,4,6,8}
        //    };
        //    x += arr[2][1];
        //    x += arr[2][3] * 10;
        //    x += arr[1][4] * 100;
        //    x += arr[1][0] * 1000;
        //    Console.Write (x);
        //    Console.ReadKey ();
        //}

        //static void Main (string[] args)
        //{
        //    string sentence = "boy soy toy";
        //    string[] words = sentence.Split(' ');
        //    Console.Write (words[1]);
        //    Console.ReadKey ();
        //}










        //static void func(int[] a)
        //{
        //    a[0] = 4;
        //    a = new int[3] { 1, 2, 3 };
        //}
        //static void Main(string[] args)
        //{
        //    int[] x = new int[3] { 5, 6, 7 };
        //    func(x);
        //    Console.Write(x[0]);
        //    Console.ReadKey();
        //}










        //static void Main (string[] args)
        //{
        //    string myStr = "Hi";
        //    myStr[1] = 'a';
        //    Console.Write (myStr);
        //    // indexer can not be assigned its READ only
        //}


        //static void Main (string[] args)
        //{
        //    double a = 3.7;
        //    int b = Convert.ToInt32 (a);
        //    Console.WriteLine (b);
        //    int c = (int)3.7;
        //    Console.WriteLine (c);
        //    Console.ReadLine ();
        //    // A rounds to 4
        //    // B rounds to 3
        //}


        //static void Main (string[] args)
        //{
        //    int total = 0;
        //    for (int i = 1; i < 6; i++)
        //    {
        //        total *= i;
        //    }
        //    Console.Write (total);
        //    Console.ReadKey ();
        //}





        //static void Main (string[] args)
        //{
        //    Exception x = new Exception ();
        //    try { throw x; }
        //    catch { Console.Write ( x); }
        //    Console.ReadKey ();
        //}




        //static void Main (string[] args)
        //{
        //    int myVariable = 0;
        //    if (myVariable > 0)
        //    {
        //        Console.Write (8);
        //    }
        //    else if (myVariable < 0)
        //    {
        //        Console.Write (6);
        //    }
        //    else
        //    {
        //        Console.Write (2);
        //    }
        //    Console.ReadKey ();
        //}



        //static void Main (string[] args)
        //{
        //    int a = b++;
        //    int b = 4;
        //    Console.Write(a);
        //    Console.ReadKey ();
        //    // result : "Error" Can not use local
        //    // variable before its declaration 
        //}



        //class Data<T>
        //{
        //    public Data (T data)
        //    {
        //        return  data = data;
        //    }
        //    T data;
        //}


        //        class dataplus<T>:Data<T>
        //    {
        //    public dataplus(T data) : base (data)
        //    {

        //    }
        //    }



        //static void Main(string[] args)
        //{
        //    string s = "This is a text";
        //    s = s.Replace("This is", "I am");
        //    s = s.Replace("text", "word");
        //    int x = s.IndexOf('o');
        //    Console.Write(x);
        //    Console.ReadKey();
        //}


        //static void Main(string[] args)
        //{
        //    int Array[4];
        //    int[4] Array2;
        //    int[] Array3 = new int[4];
        //    int[] Array4 = { 0, 0, 0, 0 };
        //}




        //class Class
        //{
        //    public int x = 13;
        //    public int y = 16;
        //    public Class()
        //    {
        //        ++x;
        //        y /= 4;
        //    }
        //}
        //static void Main(string[] args)
        //{
        //    Class c = new Class();
        //    ++c.x;
        //    c.y += c.x;
        //    Console.Write(++c.y);
        //    Console.ReadKey();
        //}




        //static void Main(string[] args)
        //{
        //    int sum = 0;
        //    for (int i = 5; i > 0; i--)
        //    {
        //        for (int j = 0; j < i; j++)
        //        {
        //            sum += j;

        //        }
        //    }
        //    Console.Write(sum);
        //    Console.ReadKey();
        //}



        //static void Main (string[] args)
        //{
        //    int x = 0;
        //    int y = 0;
        //    try
        //    {
        //        x++;
        //        x = 1 / y;
        //        y++;
        //    }
        //    catch (Exception)
        //    {
        //        x = 0;
        //    }
        //    finally
        //    {
        //        x += 3;
        //        y *= 4;
        //    }
        //    Console.Write (x+y);
        //    Console.ReadKey ();
        //}




        //static void Main(string[] args)
        //{
        //    int i = 3;
        //    int count = 0;
        //    while (i < 8)
        //    {
        //        i++;
        //        count++;
        //    }
        //    Console.Write(count % i);
        //    Console.ReadLine();
        //}





        //static void Main (string[] args)
        //{


        //    Console.WriteLine (DateTime.UtcNow); // 8/18/2017 7:42:12 AM

        //    Console.WriteLine (DateTime.Now); // 8 / 18 / 2017 12:41:11 PM

        //    Console.WriteLine (DateTimeOffset.Now); // 8 / 18 / 2017 12:43:41 PM + 05:00



        //    Console.ReadKey ();
        //}



        //static void Main(string[] args)
        //{
        //    int x = 19;
        //    int y = x % 3;
        //    while (y<3)
        //    {
        //        x -= y++;

        //    }
        //    Console.Write(x);
        //    Console.ReadLine();
        //}




        //static void Main(string[] args)
        //{
        //    int x = 6, y = 13;
        //    int z = y % x + 5 * 5;
        //    Console.WriteLine(z);
        //    Console.ReadKey();
        //}


        //static void Main(string[] args)
        //{
        //    int n = 5;
        //    int m = 7;
        //    int z = 6;
        //    if (++n < m && z == n++)
        //    {
        //        Console.Write(m);
        //    }
        //    else
        //    {
        //        Console.Write(n);
        //    }
        //    Console.ReadKey();
        //}





        //static void Main(string[] args)
        //{
        //    int x = 10;
        //    do
        //    {
        //        x *= 2;
        //    } while (x <= 5);
        //    Console.Write(x);
        //    Console.ReadLine();
        //}



        //static void Main(string[] args)
        //{
        //    int a = 5;
        //    object b = (object)a;
        //    a = 8;
        //    Console.Write((int)b);
        //    Console.ReadKey();
        //}


        //static int Square(int[] x)
        //{
        //    x[0] *= x[0];
        //    return x[0];
        //}
        //static int Square(ref int x)
        //{
        //    x *= x;
        //    return x;
        //}

        //static void Main(string[] args)
        //{
        //    int[] a = new int[1];
        //    a[0] = 3;
        //    int b = 4;
        //    Square(a);
        //    Square(ref b);
        //    Console.Write(a[0] + b);
        //    Console.ReadKey();
        //}


        //static void Main(string[] args)
        //{
        //    int x = 4;
        //    x *= 5;
        //    x /= 2;
        //    x %= 3;
        //    Console.Write(x);
        //    Console.ReadKey();
        //}



        //struct Point
        //{
        //    public int x, y;
        //    public Point(int x,int y)
        //    {
        //        this.x = x;
        //        this.y = y;

        //    }
        //}
        //static void Main(string[] args)
        //{
        //    Point p1 = new Point(3, 5);
        //    Point p2 = new Point(2, 4);
        //    Console.Write( p1.x + p2.y );
        //    Console.ReadKey();

        //}


        //static void Main(string[] args)
        //{
        //    int a = 3;
        //    int b = 10;
        //    int z = a - (b % --a);
        //    Console.Write(z);
        //    Console.ReadKey();
        //}



        //static void Main(string[] args)
        //{
        //    int x = 0;
        //    int[,] m = new int[,]
        //    {
        //        { 42,21,32 },
        //        {73,65,58 },
        //        {25,53,17 }
        //};
        //    for (int i = 0; i < 2; i++)
        //    {
        //        x += m[2 - i, i];               
        //    }
        //    Console.Write(x);
        //    Console.ReadKey();

        //}


        //static void Main(string[] args)
        //{
        //    string myStr = "Hi";
        //    myStr[1] = 'a'; // indexer can not be assigned its read only
        //    Console.Write(myStr);
        //}


        //class Pet
        //{
        //    public int age { get; set; }
        //}


        //static void Main(string[] args)
        //{
        //    Pet p = new Pet();
        //    p.age = 18;
        //    Console.Write(p.age);
        //    Console.ReadKey();
        //}


        //static void Main(string[] args)
        //{
        //    char[] chars = new char[] { 'h', 'i' };
        //    string msg = "h";
        //    foreach (char c in chars)
        //    {
        //        msg += c;
        //    }
        //    Console.Write(msg);
        //    Console.ReadKey();
        //}




        //static void Main(string[] args)
        //{
        //    try
        //    {
        //        int a;
        //        int b = 15;
        //        a = (int)b + 20;
        //        Console.Write(b);

        //    }
        //    catch (Exception ex)
        //    {
        //        Console.Write(ex);

        //    }
        //    Console.ReadKey();
        //}







        // very spagatic code -- difficult to understand for the first time     
        //static void Print(string s)
        //{
        //    if(s.Length <= 1)
        //    {
        //        Console.Write(s);
        //    }
        //    else
        //    {
        //        for (int i = 0; i < s.Length; i++)
        //        {
        //            string a = s.Substring(i + 1);
        //            string b = s.Substring(0, i);
        //            Print(a + b);
        //        }
        //    }
        //}


        //static void Main(string[] args)
        //{
        //    Print("cat");
        //    Console.ReadKey();
        //}



        //static void Main(string[] args)
        //{
        //    string[] arr = new string[20];
        //    Array.Sort(arr);
        //}




        //static void Main(string[] args)
        //{
        //    Console.WriteLine(5/2 + 2.5);       // 4.5
        //    Console.WriteLine(5.0/2 + 2.5);     //  5
        //    Console.ReadKey();
        //}





        //static void Main(string[] args)
        //{
        //    int x = 1;
        //    switch (x)
        //    {
        //        case 1:
        //        case 2:
        //            x = x + 2;
        //            break;
        //        case 3:
        //            x = x + 3;
        //            break;
        //        case 4:
        //            x = x + 4;
        //            break;
        //    }
        //    Console.Write(x);
        //    Console.ReadKey();
        //}




        //static void Main(string[] args)
        //{
        //    int x = 2;
        //    int y = ++x + x++;
        //    int z = --y - x--;
        //    Console.Write(z);
        //    Console.ReadKey();
        //}



        //static void Main(string[] args)
        //{
        //    int[] Arr = { 7, 4, 3 };
        //    int m = 1;
        //    try
        //    {
        //        m = Arr[3];
        //        m--;
        //    }
        //    catch 
        //    {
        //        m = Arr[m];

        //    }
        //    Console.Write(m);
        //    Console.ReadKey();
        //}


        //static void Main(string[] args)
        //{
        //    int x = 6;
        //    int y = 13;
        //    int z = y % x + 5 * 5;
        //    Console.Write(z);
        //    Console.ReadLine();

        //}


        //static void Main(string[] args)
        //{
        //    int i = 3;
        //    int j = 9;
        //    while (true)
        //    {
        //        i += 3;
        //        j += 2;
        //        if (i == j)
        //        {
        //            break;  
        //        }
        //    }
        //    Console.Write(i);
        //    Console.ReadLine();
        //}



        //static void Main(string[] args)
        //{
        //    List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };
        //    numbers = numbers.Where(n => n % 2 == 0).ToList();
        //    foreach (int num in numbers)
        //        Console.Write(num);
        //    Console.ReadKey();
        //}



        //The => token is called the lambda operator. 
        //It is used in lambda expressions to separate the input 
        //variables on the left side from the lambda body on the 
        //right side.Lambda expressions are inline expressions similar
        //to anonymous methods but more flexible; they are used extensively 
        //in LINQ queries that are expressed in method syntax




        //static string str = "";
        //static void Concat(string s)
        //{
        //    str = str + s;

        //}
        //static void Concat(char c)
        //{
        //    str = c + str;
        //}

        //static void Main(string[] args)
        //{
        //    Concat('u');
        //    Concat("n");
        //    Concat("f");
        //    Console.Write(str);
        //    Console.ReadKey();    
        //}



        //static void Main(string[] args)
        //{
        //    int y = 0;
        //    for (int x = 0; x < 9; x++)
        //    {
        //        y++;
        //        x++;

        //    }
        //    Console.Write(y);
        //    Console.ReadKey( );
        //}


        //static void Main(string[] args)
        //{
        //    int a = 0, b = 0;
        //    while (a < 3)
        //    {
        //        ++a;
        //        a *= a;
        //        b += a;
        //    }
        //    Console.Write(b);
        //    Console.ReadKey();
        //}


        //static int Sum(int x)
        //{

        //    if (x != 0)
        //    {
        //        int y = x + Sum(x - 1); // sum store old value like x = 1 and sum = 0
        //                                // x = 2 and sum = 0 + 1 = 1
        //                                // x = 3 and sum = 2 + 1 = 3 
        //                                // x = 4 and sum = 3 + 3 = 6
        //                                // x = 5 and sum = 4 + 6 = 10
        //                                // x = 6 and sum = 5 + 10 = 15
        //                                // return 6 + 15 = 21
        //        Console.WriteLine(y);
        //        return y;
        //    }

        //    else
        //    {
        //        return x;
        //    }
        //}

        //static void Main(string[] args)
        //{
        //    int x = 6;
        //    x = Sum(x);
        //    Console.Write(++x); // x = 22
        //    Console.ReadKey();
        //}





        //static float Func(float a,float b)
        //{
        //    return a % b;
        //}
        //static float Func(int a, int b)
        //{
        //    return a * b;
        //}
        //static void Main(string[] args)
        //{
        //    Console.Write(Func(Func(2,3),4));
        //    Console.ReadKey();
        //}



        //static void Main(string[] args)
        //{
        //    bool b;
        //    Random rand = new Random();
        //    int r = rand.Next(0, 2);
        //    if (r == 0)
        //    {
        //        b = false;
        //    }
        //    else
        //    {
        //        b = true;
        //    }
        //    int x = 6;
        //    x = (x > 6 && b == false) ? 5 : 7;
        //    Console.Write(x);
        //    Console.ReadKey();
        //}






        //static void Main(string[] args)
        //{
        //    string[] colors = new string[1];
        //    int index = 0;
        //    try
        //    {
        //        colors[index++] = "green";
        //        Console.Write(colors[0]);
        //    }
        //    catch (Exception e)
        //    {
        //        Console.Write("error");

        //    }
        //    Console.ReadKey();

        //}




        //static void Main(string[] args)
        //{
        //    int[] a = new int[] { 1, 2, 3 };

        //    int[,] b = { { 1, 7 }, { 2, 3 } };

        //    int[] c = { 1, 2, 3 };

        //    int[] d = new int[] { 1, 2, 3 };
        //}





        //static void Main(string[] args)
        //{
        //    float a = 3.5F;

        //float b = 3.5;

        //float x = 3.5(float);

        //float x(F) = 3.5;
        //}



        //static void Main(string[] args)
        //{
        //    int[] values = { 1, 2, 3 };
        //    for (int x = 0, y = values.Length - 1;
        //        ((x < values.Length) && (y >= 0));
        //         x++,y--){
        //        Console.Write(values[x]);
        //        Console.Write(values[y]);
        //        Console.WriteLine();
        //    }
        //    Console.ReadKey();
        //}




        //struct F
        //{
        //    public int i;
        //}

        //class Program
        //{
        //    static void Main(string[] args)
        //    {
        //        F x = new F();
        //        x.i = 10;
        //        fun(ref x);
        //        Console.Write(x.i);
        //        Console.ReadKey();
        //    }

        //    public static void fun( ref F y)
        //    {
        //        y.i = 20;
        //        Console.Write(y.i);
        //    }
        //}



        //static void Main(string[] args)
        //{
        //    bool a = true;
        //    bool b = false;
        //    bool r = (a && b) || ((a || b) && a);
        //    Console.Write(r);
        //    Console.ReadKey();
        //}





        //static void Main(string[] args)
        //{
        //    int x = 10;
        //    x = --x % 4;
        //    Console.Write(x);
        //    Console.ReadKey();
        //}





        //class Bar
        //{
        //    public int foo;
        //    public Bar(int foo)
        //    {
        //        this.foo = foo;
        //    }
        //}

        //class Test
        //{
        //    public int Add(int foo,Bar bar)
        //    {
        //        return foo + bar.foo;
        //    }
        //}

        //static void Main(string[] args)
        //{
        //    Bar bar = new Bar(8);
        //    Test test = new Test();
        //    Console.Write(test.Add(7,bar));
        //    Console.ReadKey();
        //}




        //static void Main(string[] args)
        //{
        //    double x = Math.Pow(2, 5);
        //    double y = Math.Pow(3, 3);
        //    double z = Math.Sqrt(x + y + 5);
        //    Console.Write(z);
        //    Console.ReadKey();
        //}



        //static void Main(string[] args)
        //{
        //    List<int> items = new List<int>() { 0, 2, 4, 6 };
        //    Console.Write(items.Single(x => x == 1));  // InvalidOperationException
        //    Console.ReadKey();
        //}




        //static void Main(string[] args)
        //{
        //    int[] a = new int[5];
        //    for( int k = 0; k<5; k+=2)
        //    {
        //        a[k] = k * 2;
        //    }
        //    for (int k = 0; k < 5; k++)
        //    {
        //        Console.Write(a[k]);
        //    }
        //    Console.ReadKey();
        //}





        //class ABC
        //{
        //    public string NameA { set; }

        //    public string NameB { writeonly; }

        //    public string NameC { no read; write; }

        //    public string NameD { noget; set; }
        //}




        //static void Main(string[] args)
        //{
        //    int age = 22;
        //    switch (age)
        //    {
        //        case 16:
        //            Console.Write("y");
        //            break;
        //        default: // "Error" control can not fall out of switch
        //                 // from final case label "default"
        //            Console.Write("o");
        //    }
        //    Console.ReadKey();
        //}





        //static void Main(string[] args)
        //{
        //    string x = "", y = ""; 

        //     int result;

        //     bool a = Int32.TryParse(x,out result); 


        //    int b = interger.ParseInt();

        //    int c = Parse.Int();

        //    int d = Int32.Parse(y);
        //}





        //public interface IExercise
        //{
        //    string GetExerciseType
        //    {
        //        get;
        //    }
        //}

        //public class Run : IExercise
        //{
        //    public string GetExerciseType
        //    {
        //      get { return "Run"; }
        //    }
        //}



        //static void Main(string[] args)
        //{
        //    int n;
        //    n = (7 * 5 > 6 * 6) ? (7 * 9 > 8 * 8)
        //         ? 11 : 12 : (7 * 8 > 9 * 6) ? 13 : 14;
        //    Console.Write(n);
        //    Console.ReadKey();
        //}






        //static void Main(string[] args)
        //{
        //    List < int > list = Enumerable.Range(0, 5).ToList();
        //    list.RemoveAt(list[1]);
        //    list.ForEach(item => Console.Write(item));
        //    Console.ReadKey();
        //}




        //static void Main(string[] args)
        //{
        //    int i;
        //    do
        //    {
        //        i++;  // error " unsigned local variable i " 
        //    } while (i < 0);
        //    Console.Write(i);
        //    Console.ReadKey();
        //}




        //static void Main(string[] args)
        //{
        //    var str = "-Solo--Learn-".Split('-');
        //    Console.Write(str.Length);
        //    Console.ReadKey();
        //}




        //static void Main(string[] args)
        //{
        //    int result = Fibonacci(6);
        //    Console.Write(result);
        //    Console.ReadKey();
        //}

        //static int Fibonacci(int x)
        //{
        //    if (x <= 1)
        //    {

        //        return 1;
        //    }
        //    else
        //    {

        //        return Fibonacci(x - 1) + Fibonacci(x - 2); 

        //    }
        //}














































    }
}

