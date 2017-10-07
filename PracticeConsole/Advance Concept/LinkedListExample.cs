using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsole.Flow_Control
{
    class LinkedListExample
    {
        static void Mainn ()
        {
            //
            // Create a new linked list.
            //
            LinkedList<string> linked1 = new LinkedList<string> ();
            //
            // First add three elements to the linked list.
            //
            linked1.AddLast ("cat");
            linked1.AddLast ("dog");
            linked1.AddLast ("man");
            linked1.AddFirst ("first");
            //
            // Insert a node before the second node (after the first node)
            //
            LinkedListNode<string> node = linked1.Find ("dog");
            linked1.AddAfter (node, "New value inserted");
            //
            // Loop through the linked list.
            //
            foreach (var value in linked1)
            {
                Console.WriteLine (value);
            }
            Console.ReadLine ();

        }
    }
}
