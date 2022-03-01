using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci_Series
{
    internal class Factorial
    {
        static void Main(string[] args)
        {
            int a = 0, b = 1;
            Console.WriteLine("Enter the range of numbers in the series :");
            int range = int.Parse(Console.ReadLine());
            Console.WriteLine("The series is : ");
            Console.Write(a+" "+b);
            for(int i = 2; i < range; i++)
            {
                int sum = a + b;
                Console.Write(" "+sum);
                a = b;
                b = sum;
            }
            Console.WriteLine();
            Console.Read();

        }
    }
}
