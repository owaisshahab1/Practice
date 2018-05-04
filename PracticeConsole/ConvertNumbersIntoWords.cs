using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsole
{
    public class ConvertNumbersIntoWords
    {
        //{
        //    //static void Main(string[] args)
        //    //{
        //    //    int number = 1310;
        //    //    int count = 0;
        //    //    string str = number.ToString();
        //    //    string[] arrayString = new string[100];
        //    //    char[] arrayChar = new char[100];
        //    //    arrayChar= str.ToCharArray();

        //    //    do
        //    //    {
        //    //        number = number / 10;
        //    //        count++;
        //    //    } while (number > 9);

        //    //    for (int i = 0; i < arrayChar.Length; i++)
        //    //    {
        //    //        if (i < arrayChar.Length-2)
        //    //        {
        //    //            switch (Convert.ToInt32(arrayChar[i]))
        //    //            {
        //    //                case '1':
        //    //                    Console.Write("One");
        //    //                    break;
        //    //                case '2':
        //    //                    Console.Write("Two");
        //    //                    break;
        //    //                case '3':
        //    //                    Console.Write("Three");
        //    //                    break;
        //    //                case '4':
        //    //                    Console.Write("Four");
        //    //                    break;
        //    //                case '5':
        //    //                    Console.Write("Five");
        //    //                    break;
        //    //                case '6':
        //    //                    Console.Write("Six");
        //    //                    break;
        //    //                case '7':
        //    //                    Console.Write("Seven");
        //    //                    break;
        //    //                case '8':
        //    //                    Console.Write("Eight");
        //    //                    break;
        //    //                case '9':
        //    //                    Console.Write("Nine");
        //    //                    break;
        //    //            }
        //    //        }

        //    //    for (int j = count; j > 0; j--)
        //    //    {
        //    //        switch (j)
        //    //        {
        //    //              //case 4:
        //    //              //      tenfunc()  ;
        //    //              //      break;
        //    //            case 3:
        //    //                Console.Write("thousand");
        //    //                break;
        //    //            case 2:
        //    //                    if (arrayChar[2] != '0')
        //    //                    {
        //    //                        Console.Write("Hundred");
        //    //                    }
        //    //                    break; ;
        //    //                case 1:
        //    //                    Console.Write(tenfunc(arrayChar[2])); ;
        //    //                    break;
        //    //                case 0:
        //    //                    Console.Write("");
        //    //                    break;
        //    //            }
        //    //            count--;
        //    //            break;
        //    //        }
        //    //    }
        //    //    Console.ReadKey();
        //    //}

        //    //private static string tenfunc(char a)
        //    //{
        //    //    string str1 = string.Empty;
        //    //    switch (a)
        //    //    {
        //    //        case '1':
        //    //            str1 = "ten";
        //    //            break;
        //    //        case '2':
        //    //            str1 = "twenty";
        //    //            break;
        //    //        case '3':
        //    //            str1 = "thirty";
        //    //            break;
        //    //        case '4':
        //    //            str1 = "fourty";
        //    //            break;
        //    //        case '5':
        //    //            str1 = "fifty";
        //    //            break;
        //    //        case '6':
        //    //            str1 = "sixty";
        //    //            break;
        //    //        case '7':
        //    //            str1 = "seventy";
        //    //            break;
        //    //        case '8':
        //    //            str1 = "eighty";
        //    //            break;
        //    //        case '9':
        //    //            str1 = "ninty";
        //    //            break;
        //    //        case '0':
        //    //            str1 = "";
        //    //            break;
        //    //    }

        //    //    return str1;
        //    //}

        //    static void Main(string[] args)
        //    {
        //        int Originalnumber = 1510;
        //        int number = Originalnumber;
        //        int count = 0;
        //        string str = number.ToString();
        //        char[] arrayChar = new char[100];
        //        arrayChar = str.ToCharArray();
        //        do
        //        {
        //            number = number / 10;
        //            count++;
        //        } while (number > 99);
        //        for (int i = count; i > 0; i--)
        //        {
        //            Console.Write(oneToNine((int)char.GetNumericValue(arrayChar[0])));
        //            switch (i)
        //            {
        //                case 1:
        //                    Console.Write("Hundred");
        //                    break;
        //                case 2:
        //                    Console.Write("Thousand");
        //                    break;
        //            }
        //            if (count == 1)
        //            {
        //                TwoDigitCheck(Convert.ToInt32((Originalnumber.ToString()).Substring(Originalnumber.ToString().Length - 2)));
        //            }
        //        }

        //        Console.ReadKey();
        //        //oneToNine(number);
        //        //do
        //        //{
        //        //    count = number / 10; 
        //        //} while (true);
        //        //for (int i = 0; i < length; i++)
        //        {

        //        }

        //    }

        //    private static void TwoDigitCheck(int number)
        //    {
        //        if (number < 9)
        //        {
        //            Console.Write(oneToNine(number));
        //        }
        //        else if (number > 10 && number < 20)
        //        {
        //            Console.Write(EleventToNinteen(number));
        //        }
        //        else if (number % 10 == 0)
        //        {
        //            Console.Write(TenToNinty(number));
        //        }
        //        else if (number % 10 > 0)
        //        {
        //            int rem = number % 10;
        //            Console.Write(TenToNinty(number - rem));
        //            Console.Write(oneToNine(rem));

        //        }
        //    }

        //    private static string TenToNinty(int number)
        //    {
        //        string digit = string.Empty;
        //        switch (number)
        //        {
        //            case 10:
        //                digit = "Ten";
        //                break;
        //            case 20:
        //                digit = "Twenty";
        //                break;
        //            case 30:
        //                digit = "Thirty";
        //                break;
        //            case 40:
        //                digit = "Fourty";
        //                break;
        //            case 50:
        //                digit = "Fifty";
        //                break;
        //            case 60:
        //                digit = "Sixty";
        //                break;
        //            case 70:
        //                digit = "Seventy";
        //                break;
        //            case 80:
        //                digit = "Eighty";
        //                break;
        //            case 90:
        //                digit = "Ninty";
        //                break;

        //        }
        //        return digit;
        //    }

        //    private static string EleventToNinteen(int number)
        //    {
        //        string digit = string.Empty;
        //        switch (number)
        //        {
        //            case 11:
        //                digit = "Eleven";
        //                break;
        //            case 12:
        //                digit = "Twelve";
        //                break;
        //            case 13:
        //                digit = "Thirteen";
        //                break;
        //            case 14:
        //                digit = "Fourteen";
        //                break;
        //            case 15:
        //                digit = "Fifteen";
        //                break;
        //            case 16:
        //                digit = "Sixteen";
        //                break;
        //            case 17:
        //                digit = "Seventeen";
        //                break;
        //            case 18:
        //                digit = "Eighteen";
        //                break;
        //            case 19:
        //                digit = "Ninteen";
        //                break;

        //        }
        //        return digit;
        //    }

        //    private static string oneToNine(int number)
        //    {
        //        string digit = string.Empty;
        //        switch (number)
        //        {
        //            case 1:
        //                digit = "One";
        //                break;
        //            case 2:
        //                digit = "Two";
        //                break;
        //            case 3:
        //                digit = "Three";
        //                break;
        //            case 4:
        //                digit = "Four";
        //                break;
        //            case 5:
        //                digit = "Five";
        //                break;
        //            case 6:
        //                digit = "Six";
        //                break;
        //            case 7:
        //                digit = "Seven";
        //                break;
        //            case 8:
        //                digit = "Eight";
        //                break;
        //            case 9:
        //                digit = "Nine";
        //                break;

        //        }
        //        return digit;
        //    }

        public static string NumberToWords(int number)
        {
            if (number == 0)
                return "zero";

            if (number < 0)
                return "minus " + NumberToWords(Math.Abs(number));

            string words = "";

            if ((number / 1000000) > 0)
            {
                words += NumberToWords(number / 1000000) + " million ";
                number %= 1000000;
            }

            if ((number / 1000) > 0)
            {
                words += NumberToWords(number / 1000) + " thousand ";
                number %= 1000;
            }

            if ((number / 100) > 0)
            {
                words += NumberToWords(number / 100) + " hundred ";
                number %= 100;
            }

            if (number > 0)
            {
                if (words != "")
                    words += "and ";

                var unitsMap = new[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
                var tensMap = new[] { "zero", "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };

                if (number < 20)
                    words += unitsMap[number];
                else
                {
                    words += tensMap[number / 10];
                    if ((number % 10) > 0)
                        words += "-" + unitsMap[number % 10];
                }
            }

            return words;
        }
    }
}
