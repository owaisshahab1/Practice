using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PracticeConsole
{
    class RegexClass
    {
        public static string str = "/content/alternate-1.aspx";

        //static void Main (string[] args)


        //{
        //    if (Regex.IsMatch (str, @"content/([A-Za-z0-9\-]+)\.aspx$"))
        //    {

        //    }
        //}


        public static int number = 1;
        public static string str1 = @"Q.*\," + number + ".*U" ;
        // @"Q.*1.*U"

        static bool IsValid (string value)
        {
            return Regex.IsMatch (value, @"[0-9]*$", RegexOptions.IgnoreCase);
            // @"A.*y"
            // @"^[a-zA-Z0-9].\U$"
            //@"Q.*\,1.*U"
        }

        //static void Main 8678787()
        //{
        //    // Test the strings with the IsValid method.
        //    //Console.WriteLine (IsValid ("dotne0123tperls"));
        //    //Console.WriteLine (IsValid ("QVdfsdfsfsdfsdf1U"));
        //    // Console.WriteLine (IsValid (":-)"));
        //    //Match m = Regex.Match ("Dot Net 100 Perls", @"\d+");
        //    //if (!string.IsNullOrEmpty(m.Value))
        //    //{
        //    //    Console.WriteLine ("=================");
        //    // }
        //    // Console.WriteLine(IsValid(null)); // Throws an exception



        //    }
            




        }












    }


