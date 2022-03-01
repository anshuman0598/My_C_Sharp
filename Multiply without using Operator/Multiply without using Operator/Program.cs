using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiply_without_using_Operator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two numbers to multiply: ");
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine("Multiplication is " + Multiply(x,y));
            Console.Read();

        }
        static int Multiply(int num1,int num2)
        {
            int i;
            int mul = 0;
            if(num2<0)
            {
                num2 = -num2;
                num1 = -num1;
            }
            for(i = 1; i <= num2; i++)
            {
                mul = mul + num1;
            }
            return mul;
        }
    }
}
