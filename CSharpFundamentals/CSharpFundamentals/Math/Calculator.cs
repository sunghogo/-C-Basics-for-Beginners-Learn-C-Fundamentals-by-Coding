using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

// Need to update namespace if Class files are nested inside folders
namespace CSharpFundamentals.Math
{
    public class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
        // Add static to make only one instance of it in memory accessible by Class
        public static int StaticAdd(int a, int b)
        {
            return a + b;
        }
    }
}
