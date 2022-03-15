using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Exercício_21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Write a program that reads a text file and displays the longest word in the file. */

            var filePath = @"C:\Users\amand\Documents\Exercícios Programação\README.md";
            
            if (File.Exists(filePath))
            {
                var splitedContent = File.ReadAllText(filePath).Split(' ');

                //var wordsLength = new List<int>();

                //foreach (var word in splitedContent)
                //    wordsLength.Add(word.Length);

                //wordsLength.Sort();

                //var longestWordLength = wordsLength[wordsLength.Count() - 1];

                //foreach (var word in splitedContent)
                //{
                //    if (word.Length == longestWordLength)
                //        Console.WriteLine("The longest word is: " + word);
                //}

                var big = splitedContent.FirstOrDefault();

                foreach(var word in splitedContent)
                {
                    if (word.Length > big.Length)
                        big = word;
                }

                Console.WriteLine("The longest word is: " + big);
            }

            Console.ReadLine();
        }
    }
}
