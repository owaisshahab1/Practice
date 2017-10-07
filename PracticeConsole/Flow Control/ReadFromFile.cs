using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsole.Flow_Control
{
    class ReadFromFile
    {
        static void Main87 ()
        {
         

    
            string text = System.IO.File.ReadAllText (@"E:\Data.txt");

       
            System.Console.WriteLine ("Contents of WriteText.txt = {0}", text);

           
            string[] lines = System.IO.File.ReadAllLines (@"E:\Data.txt");

            
            
            foreach (string line in lines)
            {
                
                Console.WriteLine ("\t" + line);
            }

            
           
            System.Console.ReadKey ();
        }
    }
}
