using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArithmaticalDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the two numbers ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("The Sum is         :",(a+b));
            Console.WriteLine("The difference is  :"+(a-b));
            Console.WriteLine("The product is     :" + (a * b));
            Console.WriteLine("The quotient is    :" + (a / b));
            Console.WriteLine("The remainder is   :"+ (a % b));
        }
    }
}
