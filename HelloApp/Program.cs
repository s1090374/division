using System;

namespace HelloApp
{
    internal class Program
    {
        static void Main()
        {

            double num1 = 25;
            double num2 = 8;

            double result = num1 / num2;
            result = Math.Round(result, 2);

                Console.WriteLine(result);
            }
        }
    }