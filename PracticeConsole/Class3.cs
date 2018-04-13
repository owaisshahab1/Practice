using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CreatingAndUsingObjects;

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

        /*   //  Write a  program that  reads a  text file  and prints  its odd  lines on  the console.
        static void Main (string[] args)
        {
            string text = System.IO.File.ReadAllText (@"E:\numbers.txt");
            string[] strArray = new string[100];
            strArray = text.Split ('\r');
            for (int i = 0; i < strArray.Length; i++)
            {
                if (strArray[i] != null)
                {
                    strArray[i] = strArray[i].Contains("\n") ? strArray[i].Replace ("\n", "") : strArray[i];
                    Console.Write(strArray[i]);
                }
                i++;
            }

            Console.ReadKey ();
        }
        */

        /*  //Write a  program that  joins two  text files  and records  the results  in  a third file.

        static void Main (string[] args)
        {
            string data = System.IO.Path.GetDirectoryName (Application.StartupPath);
            data = data.Replace ("bin", "");
            string str1 = System.IO.File.ReadAllText (data + "Resources\\numbers.txt");
            string str2 = System.IO.File.ReadAllText (data + "Resources\\numbers2.txt");
            string[] strArray1 = new string[100];
            string[] strArray2 = new string[100];
            strArray1 = str1.Split ('\r');
            strArray2 = str2.Split ('\r');
            var list = new List <string>();
            list.AddRange (strArray1);
            list.AddRange (strArray2);
            string[] strArray3 = list.ToArray ();

            foreach (var item in strArray3)
            {
                string item1 = item.Contains ('\n') ? item.Replace ("\n", "") : item;
                Console.Write(item1);
            }

            Console.ReadKey ();
        }
        */

        /*   //Write  a  program  that  reads  the  contents  of  a  text  file  and  inserts  the line numbers  at the  beginning of  each line, then  rewrites the  file contents.

         static void Main (string[] args)
         {
             string data = System.IO.Path.GetDirectoryName (Application.StartupPath);
             data = data.Replace ("bin", "");
             string str = System.IO.File.ReadAllText (data + "Resources\\words.txt");
             string[] strArray = new string[100];
             strArray = str.Split ('\r');

             for (int i = 0; i < strArray.Length; i++)
             {
                 strArray[i] = strArray[i].Contains ('\n') ? strArray[i].Replace ("\n", "") : strArray[i];
                 Console.WriteLine ("{0}- {1}", i + 1, strArray[i]);
             }
             Console.ReadKey ();
         }
         */

        /*  //   Write a program that compares two text files with the same number of rows  line by  line and  prints the  number of  equal and  the number  of different lines.

        static void Main (string[] args)
        {
            string data = System.IO.Path.GetDirectoryName (Application.StartupPath);
            data = data.Replace ("bin", "");
            string str1 = System.IO.File.ReadAllText (data + "Resources\\Compare1.txt");
            string str2 = System.IO.File.ReadAllText (data + "Resources\\Compare2.txt");
            string[] strArray1 = new string[100];
            string[] strArray2 = new string[100];
            strArray1 = str1.Split ('\r');
            strArray2 = str2.Split ('\r');
            int diff = Math.Abs (strArray1.Length - strArray2.Length);
            if (strArray1.Length == strArray2.Length)
            {
                Console.WriteLine ("Rows are Equal - Difference {0} ",diff);
            }
            else
            {
                Console.WriteLine ("Rows are UnEqual - Difference {0} ", diff);
            }
            Console.ReadKey ();
        }
        */

        /*   //Write a  program that  reads a  list of  names from  a text  file,  arranges them  in  alphabetical order, and  writes them  to another  file.The lines are written one per row.

         static void Main (string[] args)
         {
             string data = System.IO.Path.GetDirectoryName (Application.StartupPath);
             data = data.Replace ("bin", string.Empty);
             string str = System.IO.File.ReadAllText (data + @"Resources\Names.txt");
             string[] strArray = new string[100];
             strArray = str.Split (',');
             List<string> list = new List<string> ();
             list = strArray.ToList ();
             list.Sort ();
             foreach (var item in list)
             {
                 Console.WriteLine (item);
             }
             Console.ReadKey ();
         }*/

        /*  //Write a  program that  reads from  the console  a sequence  of positive integer numbers.The  sequence ends  when empty  line  is  entered. Calculate and  print the  sum and  the average  of the  sequence.Keep the sequence in List<int>.

         static void Main (string[] args)
         {
             string str = string.Empty;
             List<int> listInt = new List<int> ();
             List<string> listString = new List<string> ();
             int[] intArray = new int[100];
             string[] stringArray = new string[100];
             int i = 0;
             do
             {
                 str = Console.ReadLine ();
                 listString.Add (str); 
                     i++; 

             } while (str != " ");

             listString.Remove (" ");

             for (int j = 0; j < listString.Count ; j++)
             {
                 listInt.Add(Convert.ToInt32(listString[j]));
             }

             double avg = listInt.Average ();
             double sum = listInt.Sum ();

             Console.WriteLine ("Average" + avg);
             Console.WriteLine ("Sum" +sum);
             Console.ReadKey ();

         }
         */
        /*  // Write a  program,  which reads  from the  console N  integers and  prints them in reversed order.Use the Stack<int> class.

        static void Main (string[] args)
        {
            List<string> listString = new List<string> ();
            Stack<int> stack = new Stack<int> ();
            int N = Convert.ToInt32 (Console.ReadLine ());

            for (int i = 0; i < N; i++)
            {
                int a = Convert.ToInt32 (Console.ReadLine ());
                stack.Push (a);
            }
            Console.WriteLine ("==========================");
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine (stack.Pop ());
            }
            Console.ReadKey ();
        }*/

        /* //Write a  program that  reads from  the console  a sequence  of positive integer numbers.The sequence ends when an empty line is entered. Print the sequence sorted in ascending order.

        static void Main (string[] args)
        {
            List<int> listInt = new List<int> ();

            List<string> listString = new List<string> ();
            listString.Add ("6");
            listString.Add ("2");
            listString.Add ("4");
            listString.Add ("1");
            listString.Add ("3");
            listString.Add ("7");
            listString.Add (" ");
            listString.Remove (" ");
            for (int i = 0; i < listString.Count; i++)
            {
                listInt.Add (Convert.ToInt32(listString[i]));
            }

            listInt.Sort ();

            foreach (var item in listInt)
            {
                Console.WriteLine (item);
            }
            Console.ReadKey ();
        }*/
        /*  //Write a  program,  which removes  all negative  numbers from sequence. Example: array = {19, -10, 12, -6, -3, 34, -2, 5}  {19, 12, 34, 5} 

         static void Main (string[] args)
         {
             int[] arrayInt = new int[] { 19, -10, 12, -6, -3, 34, -2, 5 };
             List<int> listInt = new List<int> ();
             listInt = arrayInt.ToList ();
             for (int i = 0; i < listInt.Count; i++)
             {
                 if (listInt[i] > 0)
                 {
                     Console.Write(listInt[i] + ", ");
                 } 
             }
         }*/

        /* //Write a  program that  finds  in  a given  array of  integers (in  the range [0…1000]) how many times each of them occurs. Example: array = {3, 4, 4, 2, 3, 3, 4, 3, 2}

        //  2 -> 2 times 
        //  3 -> 4 times 
        //  4 -> 3 times

        static void Main (string[] args)
        {
            int[] arrayInt = new int[] { 3, 4, 4, 2, 3, 3, 4, 3, 2 };
            int[] count = new int[10];
            for (int i = 0; i < arrayInt.Length; i++)
            {
                switch (arrayInt[i])
                {
                    case 1:
                        ++count[1];
                        break;
                    case 2:
                        ++count[2];
                        break;
                    case 3:
                        ++count[3];
                        break;
                    case 4:
                        ++count[4];
                        break;
                    case 5:
                        ++count[5];
                        break;
                    case 6:
                        ++count[6];
                        break;
                    case 7:
                        ++count[7];
                        break;
                    case 8:
                        ++count[8];
                        break;
                    case 9:
                        ++count[9];
                        break;
                    case 0:
                        ++count[0];
                        break;
                }
            }

            for (int i = 0; i < arrayInt.Length; i++)
            {
                if (count[i] > 0)
                {
                    Console.WriteLine ("{0} -> {1}", i, count[i]);
                }
            }

            Console.ReadKey ();
        }*/
        /*  //The majorant  of an  array of  size N  is  a value  that occurs  in  it at  least N/2 + 1 times.Write a program that finds the majorant of given array and prints it.If it does not exist, print "The majorant does not exist!".  Example: {2, 2, 3, 3, 2, 3, 4, 3, 3} -> 3 

          static void Main (string[] args)
          {
              int[] arrayInt = new int[] { 2, 2, 3, 3, 2, 3, 4,1,1,5,5,7};
              int[] count = new int[10];
              List<int> listInt = new List<int> ();

              for (int i = 0; i < arrayInt.Length; i++)
              {
                  switch (arrayInt[i])
                  {
                      case 0:
                          ++count[0];
                          break;
                      case 1:
                          ++count[1];
                          break;
                      case 2:
                          ++count[2];
                          break;
                      case 3:
                          ++count[3];
                          break;
                      case 4:
                          ++count[4];
                          break;
                      case 5:
                          ++count[5];
                          break;
                      case 6:
                          ++count[6];
                          break;
                      case 7:
                          ++count[7];
                          break;
                      case 8:
                          ++count[8];
                          break;
                      case 9:
                          ++count[9];
                          break;
                  }
              }

              int a = count.Max ();
              int index1 = Array.IndexOf (count, a);
              Console.WriteLine (index1);
              Console.ReadKey ();
          }*/
<<<<<<< HEAD
          // todo
        //Write a  program,  which reads  the integer  numbers N  and K  from the console and prints all variations of K elements of the numbers in the interval[1…N]. Example: N = 3, K = 2  {1, 1}, {1, 2}, {1, 3}, {2, 1}, {2, 2}, {2, 3}, {3, 1}, {3, 2}, {3, 3}. 
=======
        /*  // Write a program, which generates and prints on the console 10 random numbers in the range[100, 200]. 
>>>>>>> 9c7dc154a928a2d1c61fa658bd002b0b282e433b

        static void Main(string[] args)
        {
<<<<<<< HEAD
            int N = 2, K = 2;
            for (int i = 1; i <= N; i++)
=======
            string str = string.Empty;
            Random r = new Random ();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine (r.Next (100, 200));
            }
        }*/
        /* //  Write a program, which prints, on the console which day of the week is today.

         static void Main (string[] args)
         {
             DateTime now = DateTime.Now;
             Console.WriteLine (now.DayOfWeek);
             Console.ReadKey ();
         }*/
        /*     //Write a program, which prints on the standard output the count of days, hours, and  minutes,  which have  passes since  the computer  is started until  the moment  of the  program execution.For  the implementation use the class Environment. 

             static void Main (string[] args)
             {

             }*/
        /*   //  Write a program, which reads from the console a year and checks if it is a leap year.

           static void Main (string[] args)
           {
              bool a =  DateTime.IsLeapYear (2004);
           }*/
        /*   //Write a  program which  by given  two sides  finds the  hypotenuse of  a right triangle.Implement entering of the lengths of the sides from the standard input, and for the calculation of the hypotenuse use methods of the class Math. 

           static void Main (string[] args)
           {
               double a = 8, b = 12, c = 0;
               c = Math.Round(Math.Sqrt (Math.Pow (a, 2) + Math.Pow (b, 2)),2);
               Console.WriteLine (c);
               Console.ReadKey ();
           }*/

        /*    Define your  own  namespace CreatingAndUsingObjects  and  place  in  it two  classes Cat  and Sequence, which  we used  in  the examples  of the current chapter.Define  one more  namespace and  make  a class,  which calls the classes Cat and Sequence, in it

        //  Cat c = new Cat ();
        //  Sequence s = new Sequence ();
        */
        /*   //Write a  method that  returns the  English name  of the  last digit  of a given number.Example: for 512 prints "two"; for 1024  "four".

        static void Main (string[] args)
        {
            do
            {
            string word = string.Empty;
            Console.WriteLine ("Enter your number");
            string str = Console.ReadLine ();
            string a = str.Substring(str.Length - 1);
            switch (Convert.ToInt32(a))
            {
                case 1:
                    word = "one";
                    break;
                case 2:
                    word = "two";
                    break;
                case 3:
                    word = "three";
                    break;
                case 4:
                    word = "four";
                    break;
                case 5:
                    word = "five";
                    break;
                case 6:
                    word = "six";
                    break;
                case 7:
                    word = "seven";
                    break;
                case 8:
                    word = "eight";
                    break;
                case 9:
                    word = "nine";
                    break;
                case 0:
                        word = "zero";
                        break;

                }
                Console.WriteLine (word);
                Console.WriteLine ();
            } while (true);
        }*/

        /*  // Write a  method that  prints the  digits of  a given  decimal number  in  a reversed order.For example 256, must be printed as 652..

          static void Main (string[] args)
          {
              do
              {
              Console.WriteLine ("Enter Number");
              string str = Console.ReadLine ();
              char[] chr = str.ToCharArray ();
              Array.Reverse (chr);
              Console.WriteLine (chr);
              Console.WriteLine ();
              } while (true);
          }*/

        /* //  Write a  method that  finds the  biggest element  of an  array.Use that method to implement sorting in descending order.

        static void Main (string[] args)
        {
            int[] arrayInt = new int[] {2,5,41,24,100,9,7,13,12,30,70,70,81 };

            for (int i = 0; i < arrayInt.Length-1; i++)
            {
                for (int j = 0; j < arrayInt.Length-1-i; j++)
                {
                    if (arrayInt[j + 1] > arrayInt[j])
                    {
                        int temp = arrayInt[j + 1];
                        arrayInt[j + 1] = arrayInt[j];
                        arrayInt[j] = temp;
                    }
                }
            }

            Console.WriteLine ("highest value in Array " + arrayInt[0]);
            Console.ReadLine (); 

        }*/

        /*  ////  Write a  program to  remove from  a sequence  all the  integers,  which appear odd number of times.For instance, for the sequence {4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2, 6, 6, 6} the output would be {5, 3, 3, 5}. 

        static void Main (string[] args)
        {
            int[] arrayInt = new int[] { 4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2, 6, 6, 6 };

            List<int> listInt = new List<int> ();

            int[] countInt = new int[10];

            for (int i = 0; i < arrayInt.Length; i++)
>>>>>>> 9c7dc154a928a2d1c61fa658bd002b0b282e433b
            {
                for (int j = 1; j <= N; j++)
                {
<<<<<<< HEAD
                    Console.Write("{");
                    Console.Write(" {0},{1} ",i,j);
                    Console.Write("}");
                }
            }
            Console.ReadKey();
        }
=======
                    case 1:
                        ++countInt[1];
                        break;
                    case 2:
                        ++countInt[2];
                        break;
                    case 3:
                        ++countInt[3];
                        break;
                    case 4:
                        ++countInt[4];
                        break;
                    case 5:
                        ++countInt[5];
                        break;
                    case 6:
                        ++countInt[6];
                        break;
                    case 7:
                        ++countInt[7];
                        break;
                    case 8:
                        ++countInt[8];
                        break;
                    case 9:
                        ++countInt[9];
                        break;

                }
            }

            for (int i = 0; i < countInt.Length; i++)
            {
                if (countInt[i] != 0 && countInt[i]%2 == 0)
                {
                    listInt.Add (i);
                }
            }

            for (int i = 0; i < arrayInt.Length; i++)
            {
                if (listInt.Contains(arrayInt[i]))
                {
                    Console.Write ("{0} ", arrayInt[i]);
                }
            }
        }*/

        /*  //Write a program that counts how many times each word from a given text file words.txt appears in it.The result words should be ordered by their number of occurrences in the text. Example:  "This is the TEXT. Text, text, text – THIS TEXT! Is this the text?" Result: is  2, the  2, this  3, text  6.

         static void Main (string[] args)
         {
             char[] arrayChar = new char[200];
             List<string> listString = new List<string> ();
             string[] arrayString = new string[100];
             string[] arrayString2 = new string[100];
             string str = "This is the TEXT. Text, text, text – THIS TEXT! Is this the text?";
             string str2 = string.Empty;
             arrayChar = str.ToCharArray ();
             for (int i = 0; i < str.Length - 1; i++)
             {
                 if (arrayChar[i].ToString ().Contains (','))
                 {
                     arrayString[i] = arrayChar[i].ToString ().Replace (",", "");
                     str2 = str2 + arrayString[i];
                 }
                 else if (arrayChar[i].ToString ().Contains ('!'))
                 {
                     arrayString[i] = arrayChar[i].ToString ().Replace ("!", "");
                     str2 = str2 + arrayString[i];
                 }
                 else if (arrayChar[i].ToString ().Contains ('.'))
                 {
                     arrayString[i] = arrayChar[i].ToString ().Replace (".", "");
                     str2 = str2 + arrayString[i];
                 }
                 else if (arrayChar[i].ToString ().Contains ('?'))
                 {
                     arrayString[i] = arrayChar[i].ToString ().Replace ("?", "");
                     str2 = str2 + arrayString[i];
                 }
                 else if (arrayChar[i].ToString ().Contains ('–'))
                 {
                     arrayString[i] = arrayChar[i].ToString ().Replace ("–", "");
                     str2 = str2 + arrayString[i];
                 }
                 else
                 {
                     arrayString[i] = arrayChar[i].ToString ();
                     str2 = str2 + arrayString[i];
                 }
             }

             str = str2.ToUpper ();
             arrayString = str.Split ();
             foreach (var item in arrayString)
             {
                 if (!listString.Contains(item))
                 { 
                     listString.Add (item);
                 }
             }

             foreach (var item in listString)
             {
                 int count = 0;
                 for (int i = 0; i < arrayString.Length; i++)
                 {
                     if (item == arrayString[i])
                     {
                         ++count;
                     }
                 }
                 if (!string.IsNullOrEmpty(item))
                 {
                     Console.WriteLine ("{0} {1}", item, count);
                 }
             }  
         }*/
//        Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following actions: 
//-  Calculates the sum of the digits (in our example 2+0+1+1 = 4). 
//-  Prints on  the console  the number  in  reversed order:  dcba (in  our example 1102). 
//-  Puts the last digit in the first position: dabc (in our example 1201). 
//-  Exchanges the  second and  the third  digits:  acbd (in  our example 2101).
>>>>>>> 9c7dc154a928a2d1c61fa658bd002b0b282e433b
    }
}

