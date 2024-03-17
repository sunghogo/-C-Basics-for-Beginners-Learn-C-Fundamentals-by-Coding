namespace Iterations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Increment for Loop
            for (int i = 1; i <= 10; i++)
            {
                if (i%2 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            // Decrement for Loop
            for (int i = 10; i >= 1; i--)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            // String Iteration
            string name = "John Smith";
            for (int i = 0; i < name.Length; i++)
            {
                Console.WriteLine(name[i]);
            }

            // foreach Range-based Iteration
            foreach (var character in name)
            {
                Console.WriteLine(character);
            }

            int[] numbers = new int[] { 1, 2, 3, 4 };
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            // while Loop
            var j = 0;
            while (j <= 10)
            {
                if (j%2 == 0)
                {
                    Console.WriteLine(j);
                }
                j++;
            }

            // break and continue
            while(true)
            {
                Console.WriteLine("Type your name: ");
                string? input = Console.ReadLine();

                if (!String.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine($"@echo: {input}");
                    continue;
                }
                break;
            }
        }
    }
}
