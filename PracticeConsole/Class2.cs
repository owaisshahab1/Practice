using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text;

namespace PracticeConsole
{
    class Class2
    {
        /*   // write a program that reads from the console a series of 
             // integers and prints the smallest and largest number.
       
         
          static void Main ()
         {
             int smallest = 0, largest = 0 , length = 0;
             List<int> listOfNumbers = new List<int> (100);
             Console.WriteLine ("How many numbers you want to Enter");
             length = Convert.ToInt32(Console.ReadLine ());
             for (int i = 0; i < length; i++)
             {
                 Console.WriteLine ("Enter Number {0} : ",i);
                 listOfNumbers.Add(Convert.ToInt32 (Console.ReadLine()));
             }

             largest = listOfNumbers.Max ();
             smallest = listOfNumbers.Min ();

             Console.WriteLine ("largest : {0} , smallest : {1} ",largest,smallest);

             Console.ReadKey ();
         } */

        /*     // write a program that prints on the console the numbers from 1 to N which are not 
                   // divisible by 3 and 7 simultaneously. the number N should be read from the 
                   // standard input.
               static void Main (string[] args)
               {
                   List<int> list = new List<int> ();
                   Console.WriteLine ("Enter Value of N ");
                   int N = Convert.ToInt32 (Console.ReadLine ());
                   for (int i = 0; i < N; i++)
                   {
                       if(i%3 == 0 && i%7 == 0)
                       {
                           continue;
                       }
                       Console.WriteLine (i);
                   }
                   Console.ReadLine ();
               } */


        /*      // write a program that prints on the console the numbers from 1 to N. The numbers N should be read from the standard input.
          static void Main (string[] args)
          {


              Console.WriteLine ("Enter Value of N");
              int N = Convert.ToInt32(Console.ReadLine());

              for (int i = 1; i <= N; i++)
              {
                  Console.Write(i + " ");
              }

              Console.ReadLine ();
          } */

        /*  // write a program that prints al;l possible cards from a standard deck of cards, without jokers (there are 52 cards: 4 suits of 13 cards).

          static void Main (string[] args)
          {
              Console.OutputEncoding = Encoding.UTF8;
              char club = '\u2663';
              char spade = '\u2660';
              char diamond = '\u2666';
              char heart = '\u2665';
              string card = null;

              Console.WriteLine ("All possible cards");

              for (int j = 1; j <= 4; j++)
              {
                  Console.WriteLine ();


                  for (int i = 2; i <= 14; i++)
                  {
                      card = i.ToString ();


                      switch (i)
                      {
                          case 11:
                              card = "J";
                              break;
                          case 12:
                              card = "Q";
                              break;
                          case 13:
                              card = "K";
                              break;
                          case 14:
                              card = "A";
                              break;

                      }

                      if (j == 1)
                      {
                          Console.WriteLine (card + " " + club);
                      }
                      if (j == 2)
                      {
                          Console.WriteLine (card + " " + spade);
                      }
                      if (j == 3)
                      {
                          Console.WriteLine (card + " " + diamond);
                      }
                      if (j == 4)
                      {
                          Console.WriteLine (card + " " +heart);
                      }
                  }
              }
              Console.ReadLine ();
          }
          */


        /*    // pattern 1
        static void Main (string[] args)
        {
            
            int length = 8;
            int[] array = new int[200];
            int num = 0;

            for (int i = 0; i < 100; i++)
            {
                array[i+1] = ++num;
            }


            for (int i = 1; i <= length; i++)
            {
                for (int j = i; j < length; j++)
                {
                    Console.Write (" ");
                }
                int number = 0;
                for (int k = 1; k <= i; k++)
                {
                    Console.Write (++number);
                }



                for (int l = 1; l < i; l++)
                {
                    Console.Write (--array[i]);
                }
            

                Console.WriteLine ();
            }

            Console.ReadLine ();
        }

        */

        /*    // pattern 2
        static void Main (string[] args)
        {
            int length = 5;
            for (int i = 1; i <= length; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write (i);
                }
                Console.WriteLine ();
            }
            Console.ReadLine ();
        }
        */

        /*   // pattern 3
        static void Main (string[] args)
        {
            int length = 5;

            for (int i = 1; i <= length; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write (j);
                }

                Console.WriteLine ();  
            }

            for (int i = 1; i <= length; i++)
            {
                for (int k = 1; k <=(length-i); k++)
                {
                    Console.Write (k);
                }
                Console.WriteLine ();
            }
            Console.ReadKey ();
        }

        */

        /*  // pattern 5
        static void Main (string[] args)
        {
            int length = 5;
            int num = 1;
            int[] array = new int[100];

            for (int i = 0; i < 100; i++)
            {
                array[i] = i % 2;
            }

            for (int i = 1; i <= length; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write (array[num++]);
                }

                Console.WriteLine ();
            }

            Console.ReadKey ();
        }

        */

        /*     // pattern 7
        static void Main (string[] args)
        {
            int length = 5;
            for (int i = 1; i <= length; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }

                Console.WriteLine ();
            }

            for (int i = 1; i <= length; i++)
            {
                for (int k = 1; k <= length - i; k++)
                {
                    Console.Write (k);
                }

                Console.WriteLine ();
            }

            Console.ReadKey ();
        }

        */

        /*  // pattern 6

        static void Main (string[] args)
        {
            int length = 4;

            int number = 0;


            for (int i = 1; i <= length; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write (++number + " ");
                }

                Console.WriteLine ();
            }

            Console.ReadKey ();
        }

        */

        /*   // Pattern 10

        static void Main (string[] args)
        {
            int length = 7;

            for (int i = 1; i <= length; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write (j);
                }

                for (int k = 1; k <= length - i; k++)
                {
                    Console.Write ("*");
                }

                Console.WriteLine ();
            }




            Console.ReadKey ();
        }

    */

        /*  // Pattern 4

        static void Main (string[] args)
        {
            int length = 5;
            

            for (int i = 1; i <= length; i++)
            {
                int number = 0;
                for (int j = i; j <= length; j++)
                {
                    Console.Write (++number);
                }
                Console.WriteLine ();
            }

            for (int i = 1; i <= length; i++)
            {
                int number = 0;
                for (int j = 1; j <= i; j++)
                {
                    Console.Write (++number);
                }
                Console.WriteLine ();
            }

            Console.ReadKey ();
        }
        */

        /*    // Pattern 9

        static void Main (string[] args)
        {
            int length = 5;

            for (int i = 1; i <= length; i++)
            {
                int number = length;
                for (int j = 1; j <= i; j++)
                {
                    Console.Write (number--);
                }
                Console.WriteLine ();
            }
            Console.ReadKey ();
        }
        */
    }
}