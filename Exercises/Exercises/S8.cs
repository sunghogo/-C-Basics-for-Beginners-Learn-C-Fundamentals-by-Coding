using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    internal class S8
    {
        public static void Q1()
        {
            Console.WriteLine("Please enter a series of numbers separated by '-': ");
            string? input = Console.ReadLine();

            int[] inputArray = Array.ConvertAll(input.Split('-'), int.Parse);

            int? previousNum = null;
            foreach (var num in inputArray)
            {
                if (previousNum != null)
                {
                    if (num != previousNum + 1)
                    {
                        Console.WriteLine("Not Consecutive");
                        return;
                    }
                }
                previousNum = num;
            }
            Console.WriteLine("Conescutive");
        }

        public static void Q2()
        {
            Console.WriteLine(
                "Please enter a series of numbers separated by '-' or press Enter to exit: "
            );

            string? input;
            while (true)
            {
                input = Console.ReadLine();
                if (String.IsNullOrEmpty(input))
                {
                    return;
                }
                else
                {
                    int[] inputArray = Array.ConvertAll(input.Split('-'), int.Parse);
                    Array.Sort(inputArray);

                    int? previousNum = null;
                    bool duplicateFound = false;
                    foreach (var num in inputArray)
                    {
                        if (previousNum != null)
                        {
                            if (num == previousNum)
                            {
                                Console.WriteLine("Duplicate");
                                duplicateFound = true;
                                break;
                            }
                        }
                        previousNum = num;
                    }

                    if (!duplicateFound)
                    {
                        Console.WriteLine("No Duplicates");
                    }
                }
            }
        }

        public static void Q3()
        {
            Console.WriteLine("Please enter a time in the 24-hour format (ex. 19:00): ");
            string? input = Console.ReadLine();

            DateTime dateTimeOut;
            if (
                DateTime.TryParseExact(
                    input,
                    "HH:mm",
                    null,
                    System.Globalization.DateTimeStyles.None,
                    out dateTimeOut
                )
            )
            {
                Console.WriteLine("Ok");
            }
            else
            {
                Console.WriteLine("Invalid Time");
            }
        }

        public static void Q4()
        {
            Console.WriteLine("Please enter words separated with spaces: ");
            string?[] input = Console.ReadLine().Trim().ToLower().Split(' ');

            for (int i = 0; i < input.Length; i++)
            {
                input[i] = input[i].Replace(input[i][0], Char.ToUpper(input[i][0]));
            }

            string? output = String.Join("", input);
            Console.WriteLine(output);
        }

        public static void Q5()
        {
            Console.WriteLine("Please enter an English word: ");
            string? input = Console.ReadLine();

            int numVowels = 0;
            foreach (char c in input)
            {
                if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
                {
                    numVowels++;
                }
            }

            Console.WriteLine($"There are {numVowels} vowels");
        }
    }
}
