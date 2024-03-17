namespace Conditionals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // if/else if/ else Statments
            int hour = 10;
            if (hour > 0 && hour < 12)
            {
                Console.WriteLine("It's morning.");
            }
            else if (hour >= 12 && hour > 18)
            {
                Console.WriteLine("It's afternoon.");
            }
            else
            {
                Console.WriteLine("It's evening.");
            }

            // Without Conditional Operator
            bool isGoldCustomer = true;
            float price;
            if (isGoldCustomer)
            {
                price = 19.95f;
            } else
            {
                price = 29.95f;
            }
            Console.WriteLine(price);

            // Conditional opeartor
            float price2 = (isGoldCustomer) ?  19.95f : 29.95f;
            Console.WriteLine(price2);

            var season = Season.Autumn;

            switch (season)
            {
                case Season.Autumn:
                case Season.Summer:
                    Console.WriteLine($"It's {season}, there is a promotion!");
                    break;
                default:
                    Console.WriteLine("I don't understand that aseason!");
                    break;
            }

        }
    }
}
