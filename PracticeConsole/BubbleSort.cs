using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsole
{
    class BubbleSort
    {
        static void MainMethod(string[] args)
        { 
            int[] array = { 3, 2, 5, 4, 1 }; 
            int temp; 
            for (int i = 0; i <= array.Length-2 ; i++)
            {
                for (int j = 0; j <= array.Length -2; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        temp = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = temp;
                    }
} 
            }
            
            Console.WriteLine("The Sorted array");
            foreach (int aa in array)                     
                Console.Write(aa + " "); 
            Console.Read();
        }
    }
}