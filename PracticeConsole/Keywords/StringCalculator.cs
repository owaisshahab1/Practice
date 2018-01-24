using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsole.Keywords
{
    class StringCalculator
    {
        static void Main500 (string[] args)
        {
            string str = "1+12-13+123-4000";
            string[] strArray = new string[100];
            int lastValue = 0;
            int counter = 0;

            for (int i = 0; i < str.Length; i++)
            {
                switch (str[i])
                {
                    case '+':
                    case '-':
                    case '*':
                    case '/':
                        counter++;
                        strArray[counter] += str[i];
                        counter++;
                        break;
                    default:
                        strArray[counter] += str[i];
                        break;
                }
            }
            for (int i = 0; i < str.Length; i++)
            {
                switch (strArray[i])
                {
                    case "+":
                        lastValue = int.Parse (strArray[i - 1]) + int.Parse (strArray[i + 1]);
                        strArray[i + 1] = lastValue.ToString ();
                        break;
                    case "-":

                        lastValue = int.Parse (strArray[i - 1]) - int.Parse (strArray[i + 1]);
                        strArray[i + 1] = lastValue.ToString ();
                        break;
                    case "*":
                        lastValue = int.Parse (strArray[i - 1]) * int.Parse (strArray[i + 1]);
                        strArray[i + 1] = lastValue.ToString ();
                        break;
                    case "/":
                        lastValue = int.Parse (strArray[i - 1]) / int.Parse (strArray[i + 1]);
                        strArray[i + 1] = lastValue.ToString ();
                        break;
                }
            }
        }
    }
}
