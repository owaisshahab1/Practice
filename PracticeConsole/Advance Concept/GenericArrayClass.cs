using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsole
{
    // by using this array we don't need to define separate array for character and integer values

    class GenericArrayClass<T>
    {
        private T[] array;
        public GenericArrayClass (int size)
        {
            array = new T[size + 1];
        }

        public T getItem (int index)
        {
            return array[index];
        }

        public void setItem (int index, T value)
        {
            array[index] = value;
        }
    }

        class Tester
        {
            static void Mainm (string[] args)
            {

                //declaring an int array
                GenericArrayClass<int> intArray = new GenericArrayClass<int> (5);

                //setting values
                for (int c = 0; c < 5; c++)
                {
                    intArray.setItem (c, c * 5);
                }

                //retrieving the values
                for (int c = 0; c < 5; c++)
                {
                    Console.Write (intArray.getItem (c) + " ");
                }

                Console.WriteLine ();



                //declaring a character array
                GenericArrayClass<char> charArray = new GenericArrayClass<char> (5);

                //setting values
                for (int c = 0; c < 5; c++)
                {
                    charArray.setItem (c, (char)(c + 97));
                }

                //retrieving the values
                for (int c = 0; c < 5; c++)
                {
                    Console.Write (charArray.getItem (c) + " ");
                }
                Console.WriteLine ();

                Console.ReadKey ();
            }



        }
    }

