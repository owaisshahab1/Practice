using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace PracticeConsole
{

    public class customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }

    }


    class Text
    {

        #region Data Members

        public static string str1 = "     owais shahab";
        public static string str2;
        public static bool listContains;
        public static int listCount;
        public static bool dictionaryContainsKey;
        public static bool dictionaryContainsValue;
        public static Dictionary<int, string> dictionaryNames1 = new Dictionary<int, string>(5);
        public static Dictionary<int, string> dictionaryNames2 = new Dictionary<int, string>(5);
        public static Queue<string> queueOfNames = new Queue<string>(5);
        public static Stack<string> stackOfNames = new Stack<string>(5);
        public static List<string> listOfNames = new List<string>(5);
        public static List<string> listOfNames2 = new List<string>(5);
        #endregion

        #region properties
        #endregion

        enum numbers : int
        {
                o,
                w,
                a,
                i,
                s
        }

        


        public static void method1() { }

        static void Main111111(string[] args)
        {
            //string[] str13 = new string[10];
            //string str12 = "e2 e4 b2 b4";
            //str13 = str12.Split(' ');
            //int n = 1;
            //for (int i = 0; i < str13.Length; i++)
            //{
            //    str13[i] = n + "." + str13[i];
            //    n++;
            //}
            Console.WriteLine();

            //string input = "/content/alternate-1.aspx";
            //Match match = Regex.Match(input, @"content/([A-Za-z0-9\-]+)\.aspx$", RegexOptions.IgnoreCase);
            //if (match.Success)
            //{
            //    string key = match.Groups[1].Value;
            //    Console.WriteLine(key);
            //}


            //customer cust = new customer()
            //{
            //    ID = 100,
            //    Name = "Kafeel",
            //    Salary = 120000
            //};

            //customer cust2 = new customer()
            //{
            //    ID = 101,
            //    Name = "Ahad",
            //    Salary = 150000
            //};

            //customer cust3 = new customer()
            //{
            //    ID = 102,
            //    Name = "Jawad",
            //    Salary = 100000
            //};

            //customer cust4 = new customer()
            //{
            //    ID = 103,
            //    Name = "Owais",
            //    Salary = 100000
            //};

            //Dictionary<int, customer> dictionaryCustomer = new Dictionary<int, customer>(3);
            //dictionaryCustomer.Add(cust.ID, cust);
            //dictionaryCustomer.Add(cust2.ID, cust2);
            //dictionaryCustomer.Add(cust3.ID, cust3);
            //dictionaryCustomer.Add(cust4.ID, cust4);
            //Console.WriteLine("Salary = {0}", dictionaryCustomer.Count(item => item.Value.Salary > 100000));
            //customer[] customers = new customer[5];
            //customers[0] = cust;
            //customers[1] = cust2;
            //customers[2] = cust3;
            //customers[3] = cust4;

            //Dictionary<int, customer> dict = customers.ToDictionary(custt => custt.ID, custt => custt);

            //foreach (KeyValuePair<int,customer> item in dict)
            //{
            //    Console.WriteLine("key = {0}",item.Key);
            //    customer custa = item.Value;
            //    Console.WriteLine("Id = {0}, Name = {1}, Salary = {2}",custa.ID,custa.Name,custa.Salary);
            //}



            // ---------lock () ;
            //var s1 = Stopwatch.StartNew();
            //var s2 = Stopwatch.Frequency;
            //var s3 = Stopwatch.GetTimestamp();
            //Console.WriteLine(s2);
            //Console.WriteLine(s3);
            //s1.Reset();
            //s1.Restart();
            //var test = new Dictionary<string, int>();
            //test["bird"] = 10;
            //test["frog"] = 20;
            //test["cat"] = 60;
            //foreach (var item in test)
            //{
            //    Console.WriteLine(item.Key);
            //    Console.WriteLine(item.Value);
            //}
            //Console.WriteLine(s1.IsRunning);
            //s1.Stop();
            //Console.WriteLine(s1.ElapsedTicks);
            //Console.WriteLine(s1.Elapsed.TotalMilliseconds);
            int index = 0;
            bool result;
            //Console.WriteLine(str1.ToUpper());
            //Console.WriteLine(str1.ToLower());

            //Console.WriteLine(str1.Trim());


            //Console.WriteLine(str1.TrimEnd('s'));
            //Console.WriteLine(str1.TrimStart('o'));
            Thread thread;
            //result = str1.Contains('a');
            //Console.WriteLine(result);
            //-------------str1.CopyTo();
            //result = str1.EndsWith("shahab");
            //Console.WriteLine(result);
            //Console.WriteLine(str1.GetEnumerator());
            //Console.WriteLine(str1.GetType());
            //Console.WriteLine(str1.IndexOf('w'));
            //Console.WriteLine(str1.Insert(5, "khan"));
            //Console.WriteLine(str1.IsNormalized());
            //Console.WriteLine(str1.LastIndexOf('b'));
            //Console.WriteLine(str1.Length.ToString());
            //queueOfNames.Enqueue("waqas");
            //queueOfNames.Enqueue("owais");
            //queueOfNames.Enqueue("fahad");
            //queueOfNames.Enqueue("faisal");
            //Console.WriteLine(queueOfNames.Count());
            //Console.WriteLine(queueOfNames.Contains("fahad"));
            //Console.WriteLine(queueOfNames.Peek());
            ////-------------------------queueOfNames.GroupBy<>;
            //Console.WriteLine(queueOfNames.Dequeue());
            //queueOfNames.Clear();
            //Console.WriteLine(queueOfNames.Count);




            //dictionaryNames1.Add(1, "owais");
            //dictionaryNames1.Add(2, "waqas");
            //dictionaryNames2.Add(3, "fahad");
            //dictionaryNames2.Add(4, "faisal");
            //dictionary.Clear();
            //dictionary.Remove(1);
            //dictionary.ToString();
            //-------------dictionary.Comparer();
            //dictionary.Count();
            //dictionaryContainsKey = dictionary.ContainsKey(1);
            //dictionaryContainsValue = dictionary.ContainsValue("owais");
            // --------dictionary.Contains<int, string>(2, "waqas");

            //listOfNames.Add("owais");
            //listOfNames.Add("waqas");
            //listOfNames2.Add("fahad");
            //listOfNames2.Add("faisal");
            //listCount = listOfNames.Count();
            //Console.WriteLine(listCount);
            //string test;
            //dictionaryNames1.TryGetValue(2, out test);
            //Console.WriteLine(test);
            //listContains = listOfNames.Contains("owais");
            //Console.WriteLine(listContains);
            Delegate delegate1;
            string str = string.Empty;
            //string text = File.ReadAllText(@"e:\WriteText.txt");
            //string[] lines = File.ReadAllLines(@"e:\WriteText.txt");
            //Console.WriteLine("Contents of WriteLines2.txt = ");
            //foreach (string line in lines)
            //{
            //    Console.WriteLine("\t" + line);
            //}
            foreach (string names in listOfNames)
            {
                Console.WriteLine("\t" + names);
            }
            method1();

            foreach (KeyValuePair<int,string> value in dictionaryNames1)
            {
                Console.WriteLine(value);
            }

            for (int i = 0; i < 6; i++)
            {

            }

            //switch (switch_on)
            {
                //default:
            }

            try
            {

            }
            catch (Exception)
            {

                throw;
            }

            
    }


    }
}
