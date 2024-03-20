namespace TimeSpan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating TimeSpan objects which are immutable
            System.TimeSpan timeSpan = new System.TimeSpan(1, 2, 3);
            System.TimeSpan timeSpan1 = new System.TimeSpan(1, 0, 0);

            System.TimeSpan timeSpan2 = System.TimeSpan.FromHours(1);

            // DateTime Subtraction
            System.DateTime start = System.DateTime.Now;
            System.DateTime end = System.DateTime.Now.AddMinutes(2);
            System.TimeSpan duration = end - start;

            Console.WriteLine($"Duration: {duration}");

            // TimeSpan Properties
            Console.WriteLine($"Minutes: {timeSpan.Minutes}");
            Console.WriteLine($"Total Minutes: {timeSpan.TotalMinutes}");

            // .Add() / .Subtract() Object Methods
            Console.WriteLine($"Add Example: {timeSpan.Add(System.TimeSpan.FromMinutes(8))}");
            Console.WriteLine($"Add Example: {timeSpan.Subtract(System.TimeSpan.FromMinutes(2))}");

            // .ToString() Obj Method
            Console.WriteLine($"ToString: {timeSpan.ToString()}");

            // Parse() Static Method to return TimeSpan obj
            Console.WriteLine($"Parse: {System.TimeSpan.Parse("01:02:03")}");
        }
    }
}
