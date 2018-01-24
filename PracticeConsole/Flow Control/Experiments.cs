using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsole.Flow_Control
{
    class Experiments
    {
        static void Main800 (string[] args)
        {
            //string a =null;
            //int b;
            //b = int.Parse (a);

            string math = "100 * 5 - 2 / 2 - 6";
            string value = new DataTable ().Compute (math, null).ToString ();
            var a = new DataTable ();
          
        }
    }
}
