using System;
using System.Collections.Generic;

namespace Exercício_18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Write a program and ask the user to enter a few words separated by a space.
             * Use the words to create a variable name with PascalCase.
             * For example, if the user types: "number of students", display "NumberOfStudents".
             * Make sure that the program is not dependent on the input.
             * So, if the user types "NUMBER OF STUDENTS", the program should still display "NumberOfStudents". */

            Console.WriteLine("Enter a few words separated by a space");

            var answer = Console.ReadLine();

            var words = answer.Split(' ');

            foreach (var word in words)
            {
                var lowerLetters = word.ToLower().ToCharArray();
                var upperLetters = word.ToUpper().ToCharArray();

                Console.Write(upperLetters[0]);

                for (int i = 1; i < lowerLetters.Length; i++)
                {
                    Console.Write(lowerLetters[i]);
                }
            }

            Console.ReadLine();
        }
    }
}
