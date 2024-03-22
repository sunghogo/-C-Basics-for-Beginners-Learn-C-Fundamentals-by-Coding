using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    internal class S9
    {
        public static void Q1(
            string filePath =
                @"C:\Users\leina\Desktop\Udemy\C# Basics for Beginners\Exercises\Exercises\S9.txt"
        )
        {
            string words = File.ReadAllText(filePath);
            Console.WriteLine($"Text file has {words.Split(' ').Length} words");
        }

        public static void Q2(
            string filePath =
                @"C:\Users\leina\Desktop\Udemy\C# Basics for Beginners\Exercises\Exercises\S9.txt"
        )
        {
            string words = File.ReadAllText(filePath);

            string longestWord = "";
            foreach (var word in words.Split(' '))
            {
                if (word.Length > longestWord.Length)
                {
                    longestWord = word;
                }
            }
            Console.WriteLine($"Longest word in text file is {longestWord}");
        }
    }
}
