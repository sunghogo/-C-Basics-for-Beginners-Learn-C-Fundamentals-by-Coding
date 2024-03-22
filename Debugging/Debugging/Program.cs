namespace Debugging
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int> { 1, 2, 3, 4, 5, 6 };
            var smallest = GetSmallest(numbers, 3);

            foreach (var number in smallest)
            {
                Console.WriteLine(number);
            }
        }

        public static List<int> GetSmallest(List<int> list, int count)
        {
            if (list == null)
            {
                throw new ArgumentNullException("list");
            }
            if (count > list.Count || count <= 0)
            {
                throw new ArgumentOutOfRangeException(
                    "count",
                    "count should between 1 and the number of elements in the list"
                );
            }
            List<int> buffer = new(list);
            List<int> smallests = new();

            while (smallests.Count < count)
            {
                var min = GetSmallest(buffer);
                smallests.Add(min);
                buffer.Remove(min);
            }

            return smallests;
        }

        public static int GetSmallest(List<int> list)
        {
            // Assume first number is the smallest
            var min = list[0];
            for (var i = 1; i < list.Count; i++)
            {
                if (list[i] < min)
                {
                    min = list[i];
                }
            }
            return min;
        }
    }
}
