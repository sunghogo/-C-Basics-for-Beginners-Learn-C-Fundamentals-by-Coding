using System.Collections.Generic;

namespace Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>() { 1, 2, 3, 4 };
            numbers.Add(1);
            numbers.AddRange(new int[3] { 5, 6, 7 });

            foreach (var number in numbers)
            {
                Console.Write($"{number} ");
            }
            Console.WriteLine();

            // .IndexOf, .LastIndexOf()
            Console.WriteLine($"Index of 1: {numbers.IndexOf(1)}");
            Console.WriteLine($"Last Index of 1: {numbers.LastIndexOf(1)}");

            // .Count
            Console.WriteLine($"Count: {numbers.Count}");

            // .Remove() (Removes first instance)
            numbers.Remove(1);
            foreach (var number in numbers)
            {
                Console.Write($"{number} ");
            }

            // .RemoveAll() or for iteration
            // Cannot foreach and modify collections in C#
            for (var i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == 1)
                {
                    numbers.Remove(numbers[i]);
                }
            }
            Console.WriteLine();

            // .Clear()
            numbers.Clear();
            Console.WriteLine($"Count: {numbers.Count}");
        }
    }
}
