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
    }
}
