using System;
using System.IO;
using System.Data.Common;

namespace Exercício_20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Write a program that reads a text file and displays the number of words. */

            var filePath = @"C:\Users\amand\Documents\Exercícios Programação\README.md";

            if (File.Exists(filePath))
            {
                var splitedContent = File.ReadAllText(filePath).Split(' ');

                Console.WriteLine(splitedContent.Length);
            }

            Console.ReadLine();
        }
    }
}
