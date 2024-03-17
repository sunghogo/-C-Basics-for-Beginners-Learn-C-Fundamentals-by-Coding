using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using System.Transactions;

namespace Exercises
{
    internal class S5
    {
        public static int ValidateInput(string? input)
        {
            int? validatedInput = null;

            while (validatedInput == null)
                try
                {
                    validatedInput = Convert.ToInt32(input);
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid input. Please enter an integer");
                    input = Console.ReadLine();
                }

            return (int)validatedInput;
        }

        public static void Q1()
        {
            Console.WriteLine("Please enter an integer between 1 and 10: ");
            string? input = Console.ReadLine();
            int validatedInput = ValidateInput(input);

            while (validatedInput < 1 || validatedInput > 10)
            {
                Console.WriteLine("Number is not between 1 and 10. Try Again.");
                input = Console.ReadLine();
                validatedInput = ValidateInput(input);
            }
        }

        public static void Q2()
        {
            Console.WriteLine("Please enter two integers.");
            Console.WriteLine("Enter first integer:");
            string? firstInteger = Console.ReadLine();
            int validatedFirstInteger = ValidateInput(firstInteger);
            Console.WriteLine("Enter second integer:");
            string? secondInteger = Console.ReadLine();
            int validatedSecondInteger = ValidateInput(secondInteger);

            Console.WriteLine($"Maximum of {validatedFirstInteger} and {validatedSecondInteger} is {(validatedFirstInteger >= validatedSecondInteger ? validatedFirstInteger : validatedSecondInteger)}");
        }

        public static void Q3()
        {
            Console.WriteLine("Please enter the width and height of an image (in pixels).");
            Console.WriteLine("Please enter the width: ");
            string? width = Console.ReadLine();
            int validatedWidth = ValidateInput(width);
            Console.WriteLine("Please enter the height: ");
            string? height = Console.ReadLine();
            int validatedHeight = ValidateInput(height);

            if (validatedWidth > validatedHeight)
            {
                Console.WriteLine("The iamge is landscape");
            } else if (validatedWidth < validatedHeight)
            {
                Console.WriteLine("The image is portrait");
            } else
            {
                Console.WriteLine("The image is neither landscape or portrait");
            }
        }

        public static void Q4()
        {
            Console.WriteLine("Please enter the speed limit: ");
            string? speedLimit = Console.ReadLine();
            int validatedSpeedLimit = ValidateInput(speedLimit);

            Console.WriteLine("Please enter the speed of the car: ");
            string? carSpeed = Console.ReadLine();
            int validatedCarSpeed = ValidateInput(carSpeed);

            if (validatedCarSpeed <= validatedSpeedLimit)
            {
                Console.WriteLine("Ok");
            } else
            {
                int demeritPoints = (validatedCarSpeed - validatedSpeedLimit) / 5;
                Console.WriteLine($"{(demeritPoints <= 12 ? $"{demeritPoints} demerit points incurred" : "License suspended")}");
            }
        }

        public static void Q5()
        {
            int count = 0;
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    count++;
                }
            }
            Console.WriteLine($"Total numbers divisiable by 3 between 1 and 100: {count}");
        }

        public static void Q6()
        {
            int sum = 0;
            do
            {
                Console.WriteLine("Please continuously enter integers, or enter 'ok' to exit and sum them up: ");
                string? input = Console.ReadLine();
                if (input == "ok")
                {
                    break;
                }
                int validatedInput = ValidateInput(input);
                sum += validatedInput;
            } while (true);
            Console.WriteLine($"Total Sum: {sum}");
        }

        public static void Q7()
        {
            Console.WriteLine("Please enter an integer to compute its factorial: ");
            string? input = Console.ReadLine();
            int validatedInput = ValidateInput(input);

            int factorial = 1;
            for (int i = validatedInput; i > 0; i--)
            {
                factorial *= i;
            }
            Console.WriteLine($"{validatedInput}! = {factorial}");
        }

        public static void Q8()
        {
            Console.WriteLine("Guess the integer from 1 to 10: ");
            Random random = new Random();
            int randomNumber = random.Next(1, 10);

            for (int tries = 4; tries > 0; tries--)
            {
                string? input = Console.ReadLine();
                int guess = ValidateInput(input);
                if (guess == randomNumber)
                {
                    Console.WriteLine("You won!");
                    return;
                } else
                {
                    Console.WriteLine($"Wrong! You have {tries-1} tries left.");
                }
            }
            Console.WriteLine("You lost!");
        }

        public static void Q9()
        {
            Console.WriteLine("Please enter a series of integers separated by a comma: ");
            string? input = Console.ReadLine();
            
            int[] numbers = Array.ConvertAll(input.Split(','), int.Parse);
            int max = numbers[0];
            foreach (int number in numbers)
            {
                if (number > max)
                {
                    max = number;
                }
            }
            Console.WriteLine($"Maximum value: {max}");
        }
    }
}
