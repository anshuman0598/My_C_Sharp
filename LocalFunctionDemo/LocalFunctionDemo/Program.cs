using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalFunctionDemo
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            int result = add(10, 20);
            Console.WriteLine("The Sum of 10 and 20 is "+result);
            int add(int x, int y)
            {
                return x + y;
            }
            Console.Read();
        }
    }
}
