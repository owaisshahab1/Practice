using System;

using System.Linq;

namespace PracticeConsole
{
    class FindLEN_LONAraay
    {
        static void MainM()
        {
            int?[] Numbers = {  1,3,5,8 }; // if  NO even or odd number present in array 
                                         // then LINQ max or min function will give us array
                                         //  so we not make use null array  

            int? largestEvenNumber = Numbers.Where (x => x % 2 == 0).Max ();
            int? smallestOddNumber = Numbers.Where (x => x % 2 != 0).Min ();

            // we can use this for each loop when not using LINQ 
            //foreach(int i in Numbers)
            //{
            //    if (i % 2 == 0)
            //    {
            //        if (!largestEvenNumber.HasValue || i > largestEvenNumber)
            //        {
            //            largestEvenNumber = i;

            //        }
            //    }
            //    else
            //    {
            //        if (!smallestOddNumber.HasValue || i < largestEvenNumber)
            //        {
            //            smallestOddNumber = i;

            //        }
            //    }
            //}
            if (largestEvenNumber == null)
            {
                Console.WriteLine ("array does not contain any even number");
            }
            else
            {
                Console.WriteLine ("largest Even Number = " + largestEvenNumber);
            }
            if (smallestOddNumber == null)
            {
                Console.WriteLine ("array dost not contain any odd number");

            }
            else
            {
                Console.WriteLine ("smallest odd number ="+ smallestOddNumber);
            }
            if (largestEvenNumber != null && smallestOddNumber != null)
            {
                Console.WriteLine ("{0} - {1} = {2}", largestEvenNumber,
                    smallestOddNumber, (largestEvenNumber - smallestOddNumber));
            }
            Console.ReadLine ();
        }
        
    }
    
}
