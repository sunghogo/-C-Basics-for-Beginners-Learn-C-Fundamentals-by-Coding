using System;

namespace Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Primitive Variable Declaration
            byte number = 2;
            int count = 10;
            float totalPrice = 20.95f;
            char character = 'A';
            string firstName = "Daniel";
            bool isWorking = false;
            
            // Implicit Typing
            var auto = 2;

            Console.WriteLine(number);
            Console.WriteLine(count);
            Console.WriteLine(totalPrice);
            Console.WriteLine(character);
            Console.WriteLine(firstName);
            Console.WriteLine(isWorking);

            // String Formatting, type class min/max values attributes
            Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);
            Console.WriteLine("{0} {1}", float.MinValue, float.MaxValue);

            // Constant Type Declaration
            const float Pi = 3.14f;
            //Pi = 1; // Compiler fails

            // Create exception if overflow
            checked
            {
                byte overflow = 255;
                overflow++;
            }
        }
    }
}
