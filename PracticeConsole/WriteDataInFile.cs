using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsole
{
    class WriteDataInFile
    {
        static void Main1123 ()
        {


            string[] lines = { "First line", "Second line", "Third line" };

            //System.IO.File.WriteAllLines (@"D:\WriteLines.txt", lines);



            //string text = "A class is the most powerful data type in C#. Like a structure, " +
            //               "a class defines the data and behavior of the data type. ";
            //// WriteAllText creates a file, writes the specified string to the file,
            //// and then closes the file.    You do NOT need to call Flush() or Close().
            //System.IO.File.WriteAllText (@"C:\Users\Public\TestFolder\WriteText.txt", text);


            using (System.IO.StreamWriter file =
                new System.IO.StreamWriter (@"E:\WriteLines.txt"))
            {
                foreach (string line in lines)
                {
                    // If the line doesn't contain the word 'Second', write the line to the file.
                    if (!line.Contains ("Second"))
                    {
                        file.WriteLine (line);
                    }
                }
            }

            // Example #4: Append new text to an existing file.
            // The using statement automatically flushes AND CLOSES the stream and calls 
            // IDisposable.Dispose on the stream object.
            //using (System.IO.StreamWriter file = 
            //    new System.IO.StreamWriter (@"C:\Users\Public\TestFolder\WriteLines2.txt", true))
            //{
            //    file.WriteLine ("Fourth line");
            //}
        }
    }
}