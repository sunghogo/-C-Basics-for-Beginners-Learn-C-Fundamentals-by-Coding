namespace File_FileInfo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var path = @"C:\somefile.jpg";

            // File static methods
            File.Copy(@"C:\temp\myfile.jpg", @"C:\temp\myfile2.jpg", true);
            File.Delete(path);
            if (File.Exists(path))
            {
                Console.WriteLine($"File exists at {path}");
            }
            var content = File.ReadAllText(path);

            // FileInfo instance methods
            var fileInfo = new FileInfo(path);
            fileInfo.CopyTo(@"C:\temp\myfile3.jpg");
            fileInfo.Delete();
            if (fileInfo.Exists)
            {
                Console.WriteLine($"File exists at {path}");
            }
        }
    }
}
