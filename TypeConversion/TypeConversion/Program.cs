namespace TypeConversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Implicit Type Conversion (Promotion)
            byte b = 1;
            int i = b;
            Console.WriteLine(i);

            // Explicit Type Covnersion (Demotion) using Casting
            // Larger values will result in bits being lost
            int i2 = 1000;
            byte b2 = (byte) i2;
            Console.WriteLine(b2);

            // Explicit Type Conversion using Convert
            var number = "1234";
            int i3 = Convert.ToInt32(number);
            Console.WriteLine(i3);

            // Overflow will cause Exception
            // try/catch statements to handle exception
            try 
            { 
                byte b3 = Convert.ToByte(number);
            } 
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            try
            {
                string str = "true";
                bool boo = Convert.ToBoolean(str);
                Console.WriteLine(boo);
            }
            catch (Exception)
            {
                Console.WriteLine("The string could not be converted to bool");
            }

        }
    }
}
