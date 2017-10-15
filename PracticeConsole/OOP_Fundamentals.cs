using PracticeConsole;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsole
{
    class OOP_Fundamentals
    {

    }

    static class Home { }

  public class A
    {      
        #region
        #endregion

        #region Fields
        public static string public_Static_Str_A = "public_Static_Str_A";
        public string public_Str_A = "public_Str_A";

        protected static string protected_Static_Str_A = "protected_Static_Str_A";
        protected string protected_Str_A = "protected_Str_A";
        
        private static string private_Static_Str_A = "private_Static_Str_A";
        private string private_Str_A = "private_Str_A ";
        #endregion

        #region Properties
        public static string Public_Static_Str_A
        {
            get
            {
                return public_Static_Str_A;
            }
            set
            {
                public_Static_Str_A = value;
            }
        }
        public string Public_Str_A
        {
            get
            {
                return public_Str_A;
            }
            set
            {
                public_Str_A = value;
            }
        }

        protected static string Protected_Static_Str_A
        {
            get
            {
                return protected_Static_Str_A;
            }
            set
            {
                protected_Static_Str_A = value;
            }
        }
        protected string Protected_Str_A
        {
            get
            {
                return protected_Str_A;
            }
            set
            {
                protected_Str_A = value;
            }
        }

        private static string Private_Static_Str_A
        {
            get
            {
                return private_Static_Str_A;
            }
            set
            {
                private_Static_Str_A = value;
            }
        }
        private string Private_Str_A
        {
            get
            {
                return private_Str_A;
            }
            set
            {
                private_Str_A = value;
            }
        }



        #endregion

        #region Constructor

        // Static Constructor calls only one time when object Creation 
        //static A()
        //{ Console.WriteLine("Static Constructor A"); }
        public A()
        { Console.WriteLine("Public Constructor A"); }
        protected A(string str)        // can not create constructor with same parameter
        { Console.WriteLine("Protected Constructor A"); }
        private A( int a)              // can not create constructor with same parameter
        { Console.WriteLine("Private Constructor A"); }
        #endregion

        #region Methods

        public static void public_static_functionA() { }
        protected static void protected_static_functionA() { }
        private static void private_static_functionA() { }

        public void public_functionA()
        {
            public_Str_A = "owais";
            protected_Str_A = "khan";
        }
        protected void protected_functionA() { }
        private void private_functionA() { }


        #region Override Methods

        public virtual void public_ClassName()
        {
            Console.WriteLine("public_ClassName_A()");
        }

        /* // Abstract Method
        // Partial / Abstract / Extern keywords use for only declare method and not define it's body 
        // Abstract method has only declaration and not implementation in abstract class

        // public abstract void public_ClassName_A();
        */

        #endregion

        static void Main6(string[] args)
        {
            
        }

    }
    #endregion

    public class B : A
    {
        #region Fields
        public static string public_Static_Str_B = "public_Static_Str_B";
        public string public_Str_B = "public_Str_B";

        protected static string protected_Static_Str_B = "protected_Static_Str_B";
        protected string protected_Str_B = "protected_Str_B";

        private static string private_Static_Str_B = "private_Static_Str_B";
        private string private_Str_B = "private_Str_B";
        #endregion

        #region Properties
        public static string Public_Static_Str_B
        {
            get
            {
                return public_Static_Str_B;
            }
            set
            {
                public_Static_Str_B = value;
            }
        }
        public string Public_Str_B
        {
            get
            {
                return public_Str_B;
            }
            set
            {
                public_Str_B = value;
            }
        }

        protected static string Protected_Static_Str_B
        {
            get
            {
                return protected_Static_Str_B;
            }
            set
            {
                protected_Static_Str_B = value;
            }
        }
        protected string Protected_Str_B
        {
            get
            {
                return protected_Str_B;
            }
            set
            {
                protected_Str_B = value;
            }
        }

        private static string Private_Static_Str_B
        {
            get
            {
                return private_Static_Str_B;
            }
            set
            {
                private_Static_Str_B = value;
            }
        }
        private string Private_Str_B
        {
            get
            {
                return private_Str_B;
            }
            set
            {
                private_Str_B = value;
            }
        }



        #endregion

        #region Constructor

        //static B()
        //{ Console.WriteLine("Static Constructor B"); }

        public B()
        { Console.WriteLine("Public Constructor B"); }

        protected B(string str)     
        { Console.WriteLine("Protected Constructor B"); }

        private B(int a)          
        { Console.WriteLine("Private Constructor B"); }

        #endregion

        #region Methods

        public static void public_static_functionB() { }
        protected static void protected_static_functionB() { }
        private static void private_static_functionB() { }

        public void public_functionB() { }
        protected void protected_functionB() { }
        private void private_functionB() { }

        #region Override Methods

        public override void public_ClassName()
        {
            Console.WriteLine("public_ClassName_B()");
        }

        #endregion

        #endregion

    }

    public class C : B
    {
        #region Fields

        public static string public_Static_Str_C = "public_Static_Str_C";
        public string public_Str_C = "public_Str_C";

        protected static string protected_Static_Str_C = "protected_Static_Str_C";
        protected string protected_Str_C = "protected_Str_C";

        private static string private_Static_Str_C = "private_Static_Str_C";
        private string private_Str_C = "private_Str_C";
        
        #endregion

        #region Properties

        public static string Public_Static_Str_C
        {
            get
            {
                return public_Static_Str_C;
            }
            set
            {
                public_Static_Str_C = value;
            }
        }
        public string Public_Str_C
        {
            get
            {
                return public_Str_C;
            }
            set
            {
                public_Str_C = value;
            }
        }

        protected static string Protected_Static_Str_C
        {
            get
            {
                return protected_Static_Str_C;
            }
            set
            {
                protected_Static_Str_C = value;
            }
        }
        protected string Protected_Str_C
        {
            get
            {
                return protected_Str_C;
            }
            set
            {
                protected_Str_C = value;
            }
        }

        private static string Private_Static_Str_C
        {
            get
            {
                return private_Static_Str_C;
            }
            set
            {
                private_Static_Str_C = value;
            }
        }
        private string Private_Str_C
        {
            get
            {
                return private_Str_C;
            }
            set
            {
                private_Str_C = value;
            }
        }



        #endregion

        #region Constructor

        //static C()
        //{ Console.WriteLine("Static Constructor C"); }

        public C()
        { Console.WriteLine("Public Constructor C"); }

        protected C(string str)
        { Console.WriteLine("Protected Constructor C"); }

        private C(int a)
        { Console.WriteLine("Private Constructor C"); }

        #endregion

        #region Methods

        public static void public_static_functionC()
        {
            
        }
        protected static void protected_static_functionC() { }
        private static void private_static_functionC() { }

        public void public_functionC() { }
        protected void protected_functionC() { }
        private void private_functionC() { }

        #region Override Methods

        public override void public_ClassName()
        {
            Console.WriteLine("public_ClassName_C()");
        }

        #endregion

        #endregion

        static void Main2(string[] args)
        {
          //  A aa = new A();
          //  B bb = new B();
           // C cc = new C();


            //bb = (B)aa;  // Casting // alternate way [ aa as B ]

            


            Console.WriteLine(" program finished");
            Console.ReadLine();
        
        }

    }

    public class D : C
    {
        #region Fields

        private C myVar;

        public static string public_Static_Str_D = "public_Static_Str_D";
        public string public_Str_D = "public_Str_D";
        
        protected static string protected_Static_Str_D = "protected_Static_Str_D";
        protected string protected_Str_D = "protected_Str_D";

        private static string private_Static_Str_D = "private_Static_Str_D";
        private string private_Str_D = "private_Str_D";
        #endregion

        #region Properties

        public C MyVar
        {
            get { return myVar; }
            set { myVar = value; }
        }

        public static string Public_Static_Str_D
        {
            get
            {
                return public_Static_Str_D;
            }
            set
            {
                public_Static_Str_D = value;
            }
        }
        public string Public_Str_D
        {
            get
            {
                return public_Str_D;
            }
            set
            {
                public_Str_D = value;
            }
        }

        protected static string Protected_Static_Str_D
        {
            get
            {
                return protected_Static_Str_D;
            }
            set
            {
                protected_Static_Str_D = value;
            }
        }
        protected string Protected_Str_D
        {
            get
            {
                return protected_Str_D;
            }
            set
            {
                protected_Str_D = value;
            }
        }

        private static string Private_Static_Str_D
        {
            get
            {
                return private_Static_Str_D;
            }
            set
            {
                private_Static_Str_D = value;
            }
        }
        private string Private_Str_D
        {
            get
            {
                return private_Str_D;
            }
            set
            {
                private_Str_D = value;
            }
        }



        #endregion

        #region Constructor

        //static D()
        //{ Console.WriteLine("Static Constructor D"); }

        public D()
        {
            Console.WriteLine("Public Constructor D");
            //myVar = new C();
        }

        protected D(string str)
        { Console.WriteLine("Protected Constructor D");  }

        private D(int a)
        { Console.WriteLine("Private Constructor D"); }

        #endregion

        #region Methods

        public static void public_static_functionD() { }
        protected static void protected_static_functionD() { }
        private static void private_static_functionD() { }

        public void public_functionD()
        {
            //this.protected_Str_A = "owais";
            //this.myVar.public_functionA();

            this.myVar.public_Str_A = "pakistan";
            this.myVar.public_Str_B = "Australia";
            
            
        }
        protected void protected_functionD() { }
        private void private_functionD() { }

        #region Override Methods

        public override void public_ClassName()
        {
            Console.WriteLine("public_ClassName_D()");
        }

        #endregion

        #endregion

        static void Main123(string[] args)
        {


          //  dd = new D(7);


            //dd.public_functionD();

            //dd.public_ClassName();
            Console.ReadLine();
            

            

            
            
        }

    }
}

// -----------------------
//C cc = new C();

//Static Constructor C
//Static Constructor B
//Static Constructor A
//Public Constructor A
//Public Constructor B
//Public Constructor C
// program finished
// ------------------------
