namespace DateTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // DateTime objects are immutable
            var dateTime = new System.DateTime(2023, 3, 20);

            // DateTime properties
            var now = System.DateTime.Now;
            var today = System.DateTime.Today;

            Console.WriteLine("Hour: " + now.Hour);
            Console.WriteLine("Hour: " + now.Minute);

            // DateTime methods to traverse exisiting objects
            var tomorrow = now.AddDays(1);
            var yesterday = now.AddDays(-1);

            Console.WriteLine(tomorrow);
            Console.WriteLine(yesterday);
            Console.WriteLine(now);

            // DateTime string formatting
            Console.WriteLine(now.ToLongDateString());
            Console.WriteLine(now.ToShortDateString());
            Console.WriteLine(now.ToLongTimeString());
            Console.WriteLine(now.ToShortTimeString());

            Console.WriteLine(now.ToString("yy-MM-dd HH.mm"));
        }
    }
}
