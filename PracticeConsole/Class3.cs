using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsole
{
    class Class3
    {
        /*  // write a program which creates an array of 20 elements of type integer and initialize each of the elements with a value equals to the index of the element multiplied by 5 and print the elements to the console.

        static void Main(string[] args)
        {
            int length = 20;

            int[] array = new int[length];

            for (int i = 0; i < length; i++)
            {
                array[i] = i * 5;
            }

            for (int i = 0; i < length; i++)
            {
                Console.Write("{0} -> {1} ,  ",i,array[i]);
            }

            Console.ReadKey();
        }
        */      /* // write a program which reads two arrays from the console and checks whether thay are equal (two arrays are equal when they are of equal length and all of their elements, which have the same index are equal).

        static void Main(string[] args)
        {
            int[] arraySame = new int[5] { 1, 2, 3, 4, 5 };
            int[] arraySame2 = new int[5] { 1, 2, 3,  5,4 };

            if (arraySame.Length == arraySame2.Length)
            {
                for (int i = 0; i < arraySame.Length; i++)
                {
                        if (arraySame[i] == arraySame2[i])
                        {
                            Console.WriteLine("Element {0} are equal ",i);
                        }
                    else
                    {
                        Console.WriteLine(" Arrays are UnEqual ");
                        break;
                    }
                }

                
            }
            else
            {
                Console.WriteLine(" Arrays Length are Un-Equal ");
            }

            Console.ReadKey();

        }
        */
                /*       // Write  a  program,  which  finds  the  maximal  sequence  of  consecutive 
                                       // equal elements in an array.E.g.: { 1, 1, 2, 3, 2, 2, 2, 1}  {2, 2, 2}.

                               static void Main(string[] args)
                               {
                                   int count = 1;
                                   int lastSequenceValue = 0;
                                   int newSequenceValue = 0;
                                   int countFinal = 0;

                                   int[] array = new int[8] {1,2,2,3,3,3,3,4 };

                                   for (int i = 1; i < array.Length; i++)
                                   {
                                       if (array[i] == array[i - 1])
                                       {
                                           lastSequenceValue = ++count;

                                           if (countFinal < count)
                                           {
                                               countFinal = count;
                                           }


                                       }
                                       else
                                       {
                                           count = 1;
                                           if (countFinal < lastSequenceValue)
                                           {
                                               countFinal = lastSequenceValue;
                                           }

                                       }
                                   }

                                   Console.WriteLine(countFinal);

                                   Console.ReadKey();
                               }
                               */

        /*   // Write  a  program,  which  finds  the  maximal  sequence  of  consecutively 
           // placed increasing integers.Example: {3, 2, 3, 4, 2, 2, 4}  {2, 3, 4}.

           static void Main(string[] args)
           {
               int count = 1, countFinal = 1,lastSequence = 0;

               int[] array = new int[] { 3, 2, 3,4, 5,6,7,8, 2, 3, 4,5,6 };

               for (int i = 1; i < array.Length; i++)
               {
                   if (array[i] > array[i-1] && (array[i] - array[i - 1]) == 1  )
                   {
                       lastSequence = ++count;
                       if (countFinal < count)
                       {
                           countFinal = count;
                       }
                   }
                   else
                   {
                       count = 1;
                       if (countFinal < lastSequence)
                       {
                           countFinal = lastSequence;
                       }
                   }

               }

               Console.WriteLine(countFinal);
               Console.ReadLine();

           }
           */

        /*  // Sorting  an  array  means  to  arrange  its  elements  in  an  increasing  (or 
        // decreasing)  order.Write a  program,  which sorts  an array  using  the 
        // algorithm "selection sort". 

        static void Main(string[] args)
        {
            int min = 0;
            int unSorted = 0;
            int index = 0;

            int[] array = new int[] { 5, 2, 1, 3, 4 };

            
            for (int j = 0; j < array.Length-1; j++)
            {
                unSorted = array[j];

                for (int i = j; i < array.Length - 1; i++)
                {
                    
                    if (array[i] > array[i+1] && unSorted > array[i+1])
                    {
                        min = array[i + 1];
                        index = i + 1;

                        //array[i + 1] = array[i];
                        //array[i] = min;
                    }
                    
                }
                if (array[j] > array[j+1])
                {
                    array[j] = array[index];
                    array[index] = unSorted;
                }
               
            }

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(" " + array[i]);
            }

            Console.ReadKey();

        }
        */

        /*  // Write a program, which finds the most frequently occurring element in 
        // an array.Example: { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3}  4 (5 times). 

        static void Main(string[] args)
        {
            int[] count = new int[100];

            int digit = 0;
            int highestCount = 0;


            int[] array = new int[] { 4, 1, 1,1,1,1,1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 };

            for (int i = 0; i < array.Length; i++)
            {
                digit = array[i];
                for (int j = 1; j < array.Length; j++)
                {
                    if (digit == array[j - 1])
                    {
                        ++count[i];
                    }
                }
                if (count[i] > highestCount)
                {
                    highestCount = count[i];
                }
            }

            Console.WriteLine(highestCount);
            Console.ReadLine();
        }
        */
        /*  //Question 12 // figure A
        static void Main(string[] args)
        {
            int count = 0;
            int[,] array = new int[100,100];
            int length = 4;
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    array[j, i] = ++count;
                }
            }

            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    Console.Write("  " + array[i,j]);
                }

                Console.WriteLine();
            }
            Console.ReadKey();
        }
        */

        /* //Question 12 // figure B

        static void Main(string[] args)
        {
            
            int count = 0;
            int length = 5;
            int countCheck = length * length;
            int[,] array = new int[100, 100];
            bool trigger = true;

            for (int i = 0; i < length; i++)
            {
                if (count == countCheck)
                {
                    break;
                }
                if (trigger)
                {
                    for (int j = 0; j < length; j++)
                    {
                        array[j, i] = ++count;
                    }
                    trigger = false;
                }
                else
                {
                    for (int k = length-1; k >= 0; k--)
                    {
                        array[k,i] = ++count;
                    }
                    trigger = true;
                }
            }

            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    Console.Write("     " + array[i,j]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
        */

        /*  //Question 12 // figure C
        static void Main(string[] args)
        {
            int count = 0; 
            int length = 5;
            int[,] array = new int[length, length];
            int counter = -1;
            int lengthCounter = length-2;
            int secondCounter = 0;


            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    array[++lengthCounter, j] = ++count;
                }
                lengthCounter = length - 2;
                lengthCounter = lengthCounter - 1 - i;
            }

            for (int i = 0; i < length-1; i++)
            {
                secondCounter = i;
                for (int j = (length - 1) -i; j > 0; j--)
                {
                    array[++counter,++secondCounter] = ++count;
                }
                counter = -1;
            }


            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    Console.Write("     " + array[i,j]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
        */


        /* //Use  counting  of  the  brackets:  For  an  opening  bracket  increase  the 
        // counter by 1 and for closing bracket decrease it by 1. Watch the counter
        // not to become a negative number and always ends with 0.

         static void Main(string[] args)
         {
             int count = 0;
             string str = "((((()))))";
             string[] strArray = new string[100];
             strArray = str.Split('(');
             foreach (var item in strArray)
             {
                 if (item == "")
                 {
                     ++count;
                 }
             }

             strArray = str.Split(')');

             foreach (var item in strArray)
             {
                 if (item == "")
                 {
                     --count;
                 }
             }

             Console.WriteLine(count);
             Console.ReadKey();
         }
         */

        /*   //Write  a  program  that  reads  a  string,  reverse  it  and  prints  it  to  the 
       // console.For example: "introduction"  "noitcudortni".

        static void Main(string[] args)
        {
            string str = "introduction";

            char[] charArray = new char[100];

            charArray = str.ToCharArray();

            Array.Reverse(charArray);

            foreach (var item in charArray)
            {
                Console.Write(item);
            }

            Console.ReadKey();
        }
        */

        /*   //  Write  a  program  that  checks  whether  the  parentheses  are  placed 
        /// correctly  in  an arithmetic  expression.Example of  expression with
        //correctly placed  brackets:  ((a+b)/5-d).  Example of  an incorrect
        //expression: )(a+b)).

        static void Main(string[] args)
        {
            string str = "((a + b) / 5 - d)";
            //"((a + b) / 5 - d)";
            //string incorrect = ")(a+b))";

            int openBracketCounter = 0;

            char[] charArray = new char[100];

            charArray = str.ToCharArray();

            for (int i = 0; i < charArray.Length; i++)
            {
                if (charArray[i] == '(')
                {
                    ++openBracketCounter;
                }
                else if (charArray[i] == ')')
                {
                    --openBracketCounter;
                }
            }

            Console.WriteLine(openBracketCounter == 0 ? "all brackets are properly closed" : "any brackets are not properly closed");
            Console.ReadKey();

        }
        */

        /*   //  Write a program that detects how many times a substring is contained in 
        //  the text.For example, let’s look for the substring "in" in the text: 
        static void Main(string[] args)
        {
            string str = "We are living in a yellow submarine.We don't have anything else. Inside the submarine is very tight.So we are drinking all the day.We will move out of it in 5 days.";
            int count = 0;
            char[] charArray = new char[1000];

            charArray = str.ToCharArray();

            for (int i = 0; i < charArray.Length-1; i++)
            {
                //if ( (charArray[i] == ('i') || charArray[i] == ('I')) && (charArray[i+1] == ('n') || charArray[i+1] == ('N')))
                if ((charArray[i] == ('w') || charArray[i] == ('W')) && (charArray[i + 1] == ('e') || charArray[i + 1] == ('E')))
                {
                    ++count;
                }
            }

            Console.WriteLine(count);
            Console.ReadKey();

        }
        */

        /*   //        A text is given. Write a program that  modifies the casing of letters to 
        //        uppercase at  all places  in  the text  surrounded by<upcase>  and
        //        </upcase> tags. Tags cannot be nested. 
        //   Example: 
        //   We are living in a<upcase> yellow submarine</upcase>.We
        //   don't have <upcase>anything</upcase> else. 
        //   Result: 
        //   We are living in a YELLOW SUBMARINE.We don't have ANYTHING else. 

        static void Main(string[] args)
        {
            int length = 2000;
            string str = "We are living in a<upcase> yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";
            char[] chrArray = new char[2000];
            string[] strArray = new string[str.Length];
            chrArray = str.ToCharArray();
            for (int i = 0; i < chrArray.Length; i++)
            {
                strArray[i] = chrArray[i].ToString();
            }
            int lastIndex = str.IndexOf('>');
            for (int i = 0; i < strArray.Length; i++)
            {
                if(strArray[i] == ("<") && strArray[i+1] == ("u") && strArray[i+2] == ("p") && strArray[i+3] == ("c") && strArray[i+4] == ("a") && strArray[i+5] == ("s") && strArray[i+6] == ("e") && strArray[i+7] == (">") )
                {
                    strArray[i] = strArray[i].Replace("<", "");
                    strArray[i + 1] = strArray[i + 1].Replace("u", "");
                    strArray[i + 2] = strArray[i + 2].Replace("p", "");
                    strArray[i + 3] = strArray[i + 3].Replace("c", "");
                    strArray[i + 4] = strArray[i + 4].Replace("a", "");
                    strArray[i + 5] = strArray[i + 5].Replace("s", "");
                    strArray[i + 6] = strArray[i + 6].Replace("e", "");
                    strArray[i + 7] = strArray[i + 7].Replace(">", "");

                    for (int j = i+8; j < strArray.Length-5; j++)
                    {
                        strArray[j] = strArray[j].ToString().ToUpper();
                        if (strArray[j] == ("<") && strArray[j + 1] == ("/") )
                        {
                            strArray[j] = strArray[j].Replace("<", "");
                            strArray[j + 1] = strArray[j+1].Replace("/", "");
                            strArray[j + 2] = strArray[j+2].Replace("u", "");
                            strArray[j + 3] = strArray[j+3].Replace("p", "");
                            strArray[j + 4] = strArray[j+4].Replace("c", "");
                            strArray[j + 5] =  strArray[j+5].Replace("a", "");
                            strArray[j + 6] = strArray[j+6].Replace("s", "");
                            strArray[j + 7] = strArray[j+7].Replace("e", "");
                            strArray[j + 8] = strArray[j + 7].Replace(">", "");
                            break;
                        }
                    }
                } 
            }

            foreach (var item in strArray)
            {
                Console.Write(item);
            }
            Console.ReadKey();
        }
        */
    }
}
