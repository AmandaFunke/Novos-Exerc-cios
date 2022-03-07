using Common;
using System;

namespace Exercício_15
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /* Write a program and ask the user to enter a few numbers separated by a hyphen. 
             * Work out if the numbers are consecutive. 
             * For example, if the input is "5-6-7-8-9" or "20-19-18-17-16", display a message: "Consecutive"; otherwise, display "Not Consecutive". */

            Console.WriteLine("Write numbers separated by hyphen!");

            var numericAnswers = Console.ReadLine().Split('-').ToInteger();

            bool isConsecutive = false;

            for (int i = 0; i < numericAnswers.Count - 1; i++)
            {
                isConsecutive = numericAnswers[i] + 1 == numericAnswers[i + 1];

                if (!isConsecutive)
                    break;
            }

            Console.WriteLine(isConsecutive ? "Consecutive!" : "Not Consecutive!");
        }
    }
}
