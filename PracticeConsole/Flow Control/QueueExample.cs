using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsole.Flow_Control
{
    class QueueExample
    {
        static void Mainn ()
        {
            // Add integers to queue.
            Queue<int> queue1 = new Queue<int> ();
            queue1.Enqueue (1);
            queue1.Enqueue (2);
            queue1.Enqueue (3);
            queue1.Enqueue (4);
            queue1.Enqueue (5);
            queue1.Dequeue (); // remove 1 from queue 
            queue1.Dequeue (); // remove 2 from queue

            // Loop through queue.
            foreach (int value in queue1)
            {
                Console.WriteLine (value);
            }
            Console.ReadKey ();
        }
    }
}
