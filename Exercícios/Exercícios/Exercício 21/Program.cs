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

                var wordsLength = new List<int>();

                foreach (var word in splitedContent)
                    wordsLength.Add(word.Length);

                wordsLength.Sort();
                
                var IndexOfLongestWord = wordsLength.Count();
                var longestWord = wordsLength[IndexOfLongestWord];

                foreach (var word in splitedContent)
                {
                    if (word.Length == longestWord)
                        Console.WriteLine(word);
                }

            }

            Console.ReadLine();
        }
    }
}
