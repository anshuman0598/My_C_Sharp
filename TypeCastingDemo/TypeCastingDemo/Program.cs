using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeCastingDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n1 = 20.6894;
            int new1 = (int)n1; //Explicit type conversion
            Console.WriteLine("The value After Explicit Type casting is: " + new1);
            int n2 = 100;
            double new2 = n2;
            Console.WriteLine("The value After Implicit type casting is: " + new2);
            Console.ReadLine();
        }
    }
}
