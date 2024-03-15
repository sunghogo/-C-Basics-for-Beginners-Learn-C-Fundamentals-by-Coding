using CSharpFundamentals.Math;
using System.Security.Cryptography;

namespace CSharpFundamentals
{
    internal class Program
    {
        // Class Methods
        public static void Increment(int number)
        {
            number += 10;
        }

        public static void MakeOld(Person person)
        {
            person.Age += 10;
        }

        // Struct Declaration is similar to Classes, use only if you need efficient data structures
        public struct RgbColor
        {
            public int Red;
            public int Green;
            public int Blue;
        }

        // Enums are by default ints unless specified to some other number type (ex. public enum Ex : byte)
        public enum ShippingMethod
        {
            // Values default to 0, 1, 2, ...
            RegularAirMail = 1,
            RegisteredAirMail = 2,
            Express = 3
        }

        static void Main(string[] args)
        {
            // Intializing Objects using new keyword
            Person john = new Person();
            john.FirstName = "John";
            john.LastName = "Smith";
            john.Introduce();

            // Using non-static Object method
            Calculator calculator = new Calculator();
            var result = calculator.Add(1, 2);
            Console.WriteLine(result);

            // Using static Class method
            var result2 = Calculator.StaticAdd(3, 4);
            Console.WriteLine(result2);

            // Declare Arrays
            int[] numbers = new int[3];
            numbers[0] = 1;

            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers[2]);

            // Default Initialization of Array values to 0, false, etc...
            bool[] flags = new bool[3];
            Console.WriteLine(flags[0]);
            Console.WriteLine(flags[1]);
            Console.WriteLine(flags[2]);

            // Initialize Arrays
            string[] names = new string[3] {"Jack", "John", "Mary"};

            Console.WriteLine(names[0]);
            Console.WriteLine(names[1]);
            Console.WriteLine(names[2]);

            // String Initialization
            string firstName = "Mosh";
            string LastName = "Hamedani";
            String myName = "Mosh Hamedani";

            // String Catenation
            var fullName = firstName + " " + LastName;
            // String Format
            var myFullName = string.Format("My name is {0} {1}", firstName, LastName);
            // String Interpolation
            var myFullName2 = $"My name is {firstName} {LastName}";

            Console.WriteLine(fullName);
            Console.WriteLine(myFullName);
            Console.WriteLine(myFullName2);

            // String Methods
            var formattedNames = string.Join(",", names);
            Console.WriteLine(formattedNames);

            // Verbatim Strings
            var text = "Hi John\nLook into the following pathes \nC:\\folder1\\folder2\nC:\\folder3\\folder4";
            var verbatimText = @"Hi John
Look into the following paths
C:\folder1\folder2
C:\folder3\folder4
";
            Console.WriteLine(text);
            Console.WriteLine(verbatimText);

            // Enums and Casting
            var method = ShippingMethod.Express;
            Console.WriteLine(method);
            Console.WriteLine((int)method);

            var methodId = 3;
            Console.WriteLine((ShippingMethod)methodId);

            // Default converts enums to string
            Console.WriteLine(method.ToString());

            // Parsing string into enum
            var methodName = "Express";
            var shippingMethod = (ShippingMethod) Enum.Parse(typeof(ShippingMethod), methodName);
            Console.WriteLine(shippingMethod);

            // Primitive/Struct Value Types
            var a = 10;
            var b = a;
            b++;
            Console.WriteLine($"a: {a}, b: {b}");

            // Class Reference Types
            var array1 = new int[3] { 1, 2, 3 };
            var array2 = array1;
            array2[0] = 0;
            Console.WriteLine($"array1[0]: {array1[0]}, array2[0]: {array2[0]}");

            // More Reference Types
            var number = 1;
            Increment(number);
            Console.WriteLine(number);

            var person = new Person() {Age = 20};
            MakeOld(person);
            Console.WriteLine(person);



        }
    }
}
