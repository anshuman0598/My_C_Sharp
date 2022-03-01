using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MulWithoutUsingOperator
{
    class Calculate
    {
        public static int mul(int a,int b)
        {
            
            if (b == 0 || a==0)
            {
                return 0;
            }
            else
                return (a + mul(a, b - 1));

        }
        static int c = 0;
        public static int div(int a, int b)
        {
            if (b == 0 )
                return -1;
            if (b>a)
            {
                return c;
            }
            else
            {
                c++;
                return div(a-b, b);

            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter two numbers to Multiply");
            int x= int.Parse(Console.ReadLine());
            int y= int.Parse(Console.ReadLine());
            Console.WriteLine("...............With Recursion Method............");
            int mul=Calculate.mul(x, y);
            Console.WriteLine($"The Product of {x} and {y} is " + mul);
            Console.WriteLine("............Without Recursion Method............");
            int c = y, m = 0;

            while (c != 0)
            {
                m = m + x;
                c--;
            }
            Console.WriteLine($"The Product of {x} and {y} is " + m);

            
            Console.WriteLine("Enter two numbers to Divide");
            int a= int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("...............With Recursion Method............");
            int div = Calculate.div(a, b);

            if (div == -1)
                Console.WriteLine("Cannot divide by zero");
            else
                Console.WriteLine($"The Quotient of {a} and {b} is " + div);

            Console.WriteLine("............Without Recursion Method............");
            
            int d = 0;
            int a1 = a;
            if(b==0)
            {
                Console.WriteLine("Cannot divide by Zero");
            }
            else
            {
                while (a1 >= b)
                {
                    d++;
                    a1 = a1 - b;
                }
                Console.WriteLine($"The Quotient of {a} and {b} is " + d);
            }
            
            Console.Read();
        }
    }
}
