using Common;
using System;

namespace Exercício_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Write a program and ask the user to enter a few numbers separated by a hyphen.
             * If the user simply presses Enter, without supplying an input, exit immediately; otherwise, check to see if there are duplicates.
             * If so, display "Duplicate" on the console. */

            Console.WriteLine("Write numbers separated by hyphen!");

            var answer = Console.ReadLine();

            bool hasAnswer = answer != null;

            if (hasAnswer)
            {
                var numericAnswers = answer.Split('-').ToInteger();

                numericAnswers.Sort();

                for (int i = 0; i < numericAnswers.Count - 1; i++)
                {
                    bool isDuplicate = numericAnswers[i] == numericAnswers[i + 1];

                    if (isDuplicate)
                    {
                        Console.WriteLine("Duplicate!");
                        break;
                    }
                }
            }
        }
    }
}
