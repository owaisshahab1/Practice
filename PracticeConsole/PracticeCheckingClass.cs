using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsole
{
    class PracticeCheckingClass
    {
        //*
        //**
        //***

        static void Main121(string[] args)
        {
            int length = 3;
            for (int i = 1; i <= length; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
            Console.ReadLine();
        }

        //***
        //**
        //*

        static void Main122(string[] args)
        {
            int length = 3;
            for (int i = 1; i <= length; i++)
            {
                for (int j = i; j <= length; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
            Console.ReadLine();
        }

        //  *
        // ***
        //*****

        static void Main123(string[] args)
        {
            int length = 3;
            for (int i = 1; i <= length; i++)
            {
                for (int j = i; j <= length-1; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= i; k++)
                {
                    Console.Write("*");
                }
                for (int l = 1; l < i; l++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
            Console.ReadKey();
        }


        //*****
        // ***
        //  *

        static void Main124(string[] args)
        {
            int length = 30;
            for (int i = 1; i <= length; i++)
            {
                for (int j = 1; j < i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = i; k <= length; k++)
                {
                    Console.Write("*");
                }
                for (int l = i; l <= length-1; l++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
            Console.ReadKey();
        }
    }
}
