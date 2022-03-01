using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegated_with_Parameters
{
    delegate int Calculate(int x, int y);
    class Calc
    {
        public int Addition(int x, int y)
        {
            return x+y;
        }
        public int Subtraction(int x, int y)
        {
            return x-y;
        }
        public int Multiplictaion(int x, int y)
        {
            return x * y;
        }
        public int Division(int x, int y)
        {
            return (x / y);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculate x1,x2,x3, x4;
            Calc calc = new Calc();
            x1 = calc.Addition; ;
            x2 = calc.Subtraction;
            x3 = calc.Multiplictaion;
            x4 = calc.Division;
            Console.WriteLine("The Sum of 18 and 56 is "+x1.Invoke(18,56));
            Console.WriteLine("The Difference of 45 and 34 is " + x2.Invoke(45, 34));
            Console.WriteLine("The Product of 4 and 5 is " + x3.Invoke(4, 5));
            Console.WriteLine("The Quotient of 36 and 6 is " + x4.Invoke(36, 6));
            Console.Read();

        }
    }
}
