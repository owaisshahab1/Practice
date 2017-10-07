using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsole.Flow_Control
{
    class GarbageCollector
    {

        private const int maxGarbage = 1000;

        static void Mainn ()
        {
            // Put some objects in memory.
            GarbageCollector.MakeSomeGarbage ();
            Console.WriteLine ("Memory used before collection:       {0:N0}",
                              GC.GetTotalMemory (false));

            // Collect all generations of memory.
            GC.Collect ();
            Console.WriteLine ("Memory used after full collection:   {0:N0}",
                              GC.GetTotalMemory (true));
            Console.ReadLine ();
        }

        static void MakeSomeGarbage ()
        {
            Version vt;

            // Create objects and release them to fill up memory with unused objects.
            for (int i = 0; i < maxGarbage; i++)
            {
                vt = new Version ();
            }
        }
    }
}
