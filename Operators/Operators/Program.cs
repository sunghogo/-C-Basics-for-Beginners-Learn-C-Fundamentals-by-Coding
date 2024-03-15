namespace Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Interger Operations
            var a = 1;
            var b = 2;
            var c = 3;

            Console.WriteLine(a + b);
            Console.WriteLine(a - b);
            Console.WriteLine(a * b);
            Console.WriteLine(a / b);

            // Floating Point Division
            Console.WriteLine((float) a/ (float) b);

            // PENDAS
            Console.WriteLine((a + b) * c);

            // Comparison Operators
            Console.WriteLine(a > b);
            Console.WriteLine(a < b);
            Console.WriteLine(a >= b);
            Console.WriteLine(a <= b);
            Console.WriteLine(a == b);
            Console.WriteLine(a != b);
            Console.WriteLine(!(a != b));

            // Logical Opeartors
            Console.WriteLine(c > b && c > a);
            Console.WriteLine(c > b && c == a);
            Console.WriteLine(c > b ||  c == a);
            Console.WriteLine(!(c > b || c == a));

            // Single Line Comments
            /*
                Multi Line Comments
            */
        }
    }
}
