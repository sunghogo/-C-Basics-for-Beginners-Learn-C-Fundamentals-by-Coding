namespace Path
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var path = @"C:\temp\CSharpFundamentals\HelloWorld\HelloWorld.sln";

            // Path static methods
            Console.WriteLine($"Extensions: {System.IO.Path.GetExtension(path)}");
            Console.WriteLine($"File Name: {System.IO.Path.GetFileName(path)}");
            Console.WriteLine(
                $"File Name without Extension: {System.IO.Path.GetFileNameWithoutExtension(path)}"
            );
            Console.WriteLine($"Directory Name: {System.IO.Path.GetDirectoryName(path)}");
        }
    }
}
