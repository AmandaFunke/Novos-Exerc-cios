using Common;
using System;
using System.Linq;

namespace Exercício_17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Write a program and ask the user to enter a time value in the 24-hour time format (e.g. 19:00).
             * A valid time should be between 00:00 and 23:59.
             * If the time is valid, display "Ok"; otherwise, display "Invalid Time".
             * If the user doesn't provide any values, consider it as invalid time. */

            bool keepGoing = true;

            while (keepGoing)
            {
                Console.WriteLine("Enter a time value in the 24-hour time format! To close type x");

                var answerSplited = Console.ReadLine().Split(':').ToInteger();

                if (answerSplited.Count == 2)
                {
                    var hour = answerSplited[0];
                    var minute = answerSplited[1];

                    bool validHour = hour >= 0 && hour < 24;
                    bool validMinute = minute >= 0 && minute < 60;

                    if (validHour && validMinute)
                    {
                        Console.WriteLine("Ok");
                    }
                    else
                    {
                        Console.WriteLine("Invalid Time");
                    }
                }
                else
                { 
                    Console.WriteLine("Invalid Time");
                }                
            }
        }
    }
}
