using System;

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

                var answer = Console.ReadLine();

                if (answer.ToLower() == "x")
                {
                    keepGoing = false;
                }
                else
                {
                    var isTime = DateTime.TryParse(answer, out var date);


                    if (isTime)
                    {
                        if (date.Hour >= 0 && date.Hour < 24)
                        {
                            Console.WriteLine("Ok");
                            Console.ReadLine();
                            Console.Clear();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid Time");
                        Console.ReadLine();
                        Console.Clear();
                    }
                }
            }
        }
    }
}
