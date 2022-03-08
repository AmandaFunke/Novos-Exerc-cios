using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercício_19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Write a program and ask the user to enter an English word.
             * Count the number of vowels (a, e, o, u, i) in the word.
             * So, if the user enters "inadequate", the program should display 6 on the console. */

            Console.WriteLine("Enter a word and we count it's vowels");

            var vowels = new char[] { 'a', 'e', 'i', 'o', 'u' };

            var count = Console
                .ReadLine()
                .ToCharArray()
                .Where(character => vowels.Contains(character))
                .Count();
                        
            //var count = 0;

            //foreach (var letter in answerLetters)
            //{
            //    if (vowels.Contains(letter))
            //        count++;
            //}

            //var count = answerLetters

            Console.WriteLine(count);
        }
    }
}
