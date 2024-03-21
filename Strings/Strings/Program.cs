namespace Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Strings are immutable
            // .Trim(), .ToUpper(), .ToLower*()
            string fullName = "Mosh Hamedani ";
            Console.WriteLine($"Trim: {fullName.Trim()}");
            Console.WriteLine($"ToUpper: {fullName.ToUpper()}");
            Console.WriteLine($"ToLower: {fullName.ToLower()}");

            // .IndexOf(), .Substring()
            var index = fullName.IndexOf(' ');
            var firstName = fullName.Substring(0, index);
            var lastName = fullName.Substring(index + 1);

            Console.WriteLine($"FirstName: {firstName}");
            Console.WriteLine($"LastName: {lastName}");

            // .Split()
            var names = fullName.Split(' ');
            Console.WriteLine($"FirstName: {names[0]}");
            Console.WriteLine($"LastName: {names[1]}");

            // .Replace()
            Console.WriteLine(fullName.Replace("Mosh", "Moshfegh"));
            Console.WriteLine(fullName.Replace('o', 'O'));
            Console.WriteLine(fullName.Replace(" ", ""));

            // String.IsNullOrEmpty() static method
            if (String.IsNullOrEmpty(null))
            {
                Console.WriteLine("Invalid");
            }
            if (String.IsNullOrEmpty(""))
            {
                Console.WriteLine("Invalid");
            }
            if (String.IsNullOrEmpty(" "))
            {
                Console.WriteLine("Invalid");
            }
            if (String.IsNullOrWhiteSpace(" "))
            {
                Console.WriteLine("Invalid");
            }

            // String conversion to int
            var str = "25";
            var age = Convert.ToByte(str);
            Console.WriteLine(age);

            // Conversion to String
            float price = 29.95f;
            Console.WriteLine(price.ToString("C0"));
        }
    }
}
