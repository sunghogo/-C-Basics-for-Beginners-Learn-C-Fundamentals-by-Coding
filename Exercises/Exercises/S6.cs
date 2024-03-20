using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    internal class S6
    {
        public static void Q1()
        {
            List<string?> names = new();

            Console.WriteLine("Write names or press enter to exit: ");
            string? input = null;
            while (true)
            {
                input = Console.ReadLine();
                if (input == "")
                {
                    break;
                }
                names.Add(input);
            }

            switch (names.Count)
            {
                case 0:
                    break;
                case 1:
                    Console.WriteLine($"{names.ElementAt(0)} likes your post");
                    break;
                case 2:
                    Console.WriteLine(
                        $"{names.ElementAt(0)} and {names.ElementAt(1)} likes your post"
                    );
                    break;
                default:
                    Console.WriteLine(
                        $"{names.ElementAt(0)}, {names.ElementAt(1)}, and {names.Count - 2} others likes your post"
                    );
                    break;
            }
        }

        public static void Q2()
        {
            Console.WriteLine("Please enter your name: ");
            string? name = Console.ReadLine();

            char[] nameArray = name.ToCharArray();
            Array.Reverse(nameArray);

            string reversedString = new string(nameArray);
            Console.WriteLine($"Your reversed name is: {reversedString}");
        }

        public static void Q3()
        {
            int?[] numbers = new int?[5];

            Console.WriteLine("Please enter 5 numbers: ");
            int? input = Convert.ToInt32(Console.ReadLine());
            numbers[0] = input;

            for (var i = 1; i < numbers.Length; i++)
            {
                input = Convert.ToInt32(Console.ReadLine());

                while (Array.IndexOf(numbers, input) != -1)
                {
                    Console.WriteLine("Number is in array. Please enter another:");
                    input = Convert.ToInt32(Console.ReadLine());
                }

                numbers[i] = input;
            }
            Array.Sort(numbers);

            Console.WriteLine("The sorted numbers are: ");
            foreach (var n in numbers)
            {
                Console.Write($"{n} ");
            }
            Console.WriteLine();
        }

        public static void Q4()
        {
            List<int> numbers = new();

            Console.WriteLine(@"Please enter numbers or ""Quit"" to exit: ");
            string? input = Console.ReadLine();

            while (input != "Quit")
            {
                int intInput = Convert.ToInt32(input);

                if (numbers.IndexOf(intInput) == -1)
                {
                    numbers.Add(intInput);
                }

                input = Console.ReadLine();
            }

            Console.WriteLine("The unique numbers are: ");
            foreach (var n in numbers)
            {
                Console.Write($"{n} ");
            }
            Console.WriteLine();
        }

        public static void Q5()
        {
            Console.WriteLine("Please enter a list of numbers separated by a comma: ");
            string? input = Console.ReadLine();
            string?[] inputArray = input.Split(',');

            while (inputArray.Length < 5)
            {
                Console.WriteLine("Invalid List. Please enter again: ");
                input = Console.ReadLine();
                inputArray = input.Split(',');
            }

            List<int> numbers = new(Array.ConvertAll(inputArray, int.Parse));
            numbers.Sort();

            Console.WriteLine(
                $"The 3 smallest numbers are: {numbers.ElementAt(0)}, {numbers.ElementAt(1)}, {numbers.ElementAt(2)},"
            );
        }
    }
}
