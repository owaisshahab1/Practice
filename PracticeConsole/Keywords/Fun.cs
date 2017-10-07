using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsole.Keywords
{
    class Fun
    {
        static void Mainbc(string[] args)
        {
            string boss = "";
            string teamLead = "";
            string projectManager = "";

            Console.WriteLine("enter your boss feeling than project manager than team lead");
            boss = Console.ReadLine();
            projectManager = Console.ReadLine();
            teamLead = Console.ReadLine();

            if (boss.Contains("happy"))
            {
                if (projectManager.Contains("happy"))
                {
                    if (teamLead.Contains("happy"))
                    {
                        Console.WriteLine("you are on safe side");
                    }
                }
                
            }
            else
            {
                Console.Write("you are fired so kindly find another job");
            }
            Console.ReadKey();
        }
    }
}
