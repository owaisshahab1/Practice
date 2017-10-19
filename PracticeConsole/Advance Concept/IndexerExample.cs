using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsole.Flow_Control
{
    class IndexerExample
    {
           
     
        static public int size = 10;
        private string[] namelist = new string[size];
        public IndexerExample () // constructor
        {
            for (int i = 0; i < size; i++)
                namelist[i] = "N. A.";
        }

        public string this[int index] // property  
                                      // this keyword which refers to the object instance
        {
            get
            {
                string tmp;

                if (index >= 0 && index <= size - 1)
                {
                    tmp = namelist[index];
                }
                else
                {
                    tmp = "";
                }

                return (tmp);
            }
            set
            {
                if (index >= 0 && index <= size - 1)
                {
                    namelist[index] = value;
                }
            }
        }

        static void Mainm (string[] args)
        {
            IndexerExample names = new IndexerExample ();
            names[0] = "Zara";
            names[1] = "Riz";
            names[2] = "Nuha";
            names[3] = "Asif";
            names[4] = "Davinder";
            names[5] = "Sunil";
            names[6] = "Rubic";
            for (int i = 0; i < IndexerExample.size; i++)
            {
                Console.WriteLine (names[i]);
            }

            Console.ReadKey ();
        }



    }
}
