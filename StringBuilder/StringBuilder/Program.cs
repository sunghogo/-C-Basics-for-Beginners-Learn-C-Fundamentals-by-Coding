using System.Text;

namespace StringBuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // StringBuilder object to build strings
            // Lacks string manipulation or searching methods
            // Returns StringBuilder object so that methods can be chained
            var builder = new System.Text.StringBuilder("Hello World");

            builder.Append('-', 10).AppendLine().Append("Header").AppendLine().Append('-', 10);

            builder.Replace('-', '+');

            builder.Remove(0, 10);

            builder.Insert(0, new string('-', 10));

            Console.WriteLine(builder);

            // Accessing characters
            Console.WriteLine("First Char: " + builder[0]);
        }
    }
}
