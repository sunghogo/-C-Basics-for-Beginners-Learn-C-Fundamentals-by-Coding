namespace Directory_DirectoryInfo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var path = @"C:\temp\folder1";

            // Directory class methods
            Directory.CreateDirectory(path);

            var files = Directory.GetFiles(path, "*.*", SearchOption.AllDirectories);
            foreach (var file in files)
            {
                Console.WriteLine(file);
            }

            var directories = Directory.GetDirectories(path, "*.*", SearchOption.AllDirectories);
            foreach (var directory in directories)
            {
                Console.Write(directory);
            }

            Directory.Exists(path);

            // DirectoryInfo instance methods
            var directoryInfo = new DirectoryInfo(path);
            directoryInfo.GetFiles();
            directoryInfo.GetDirectories();
        }
    }
}
