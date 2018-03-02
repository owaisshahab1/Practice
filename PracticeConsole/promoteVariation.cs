using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsole
{
    class promoteVariation
    {
        static void Main55 (string[] args)
        {
            string game = File.ReadAllText (@"e:\game.pgn");
            //string promoteMove = Convert.ToString(Console.ReadLine ());
            string promoteMove = "2. b4";
            string[] moveNumber = promoteMove.Split ('.');

            int moveIndex = game.IndexOf (moveNumber[0].ToString());

            string changeMove = Console.Read ().ToString();

        }
      
    }
}
