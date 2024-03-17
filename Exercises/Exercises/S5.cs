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
    }
}
