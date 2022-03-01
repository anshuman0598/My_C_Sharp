using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class Factorial
    {
        public int fact(int a)
        {
            if(a == 1)
            {
                return 1;
            }
            else
            {
                return (a * fact(a-1));
            }
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Factorial f = new Factorial();
            Console.WriteLine("Enter the number to find factorial");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("The factorial is : "+ f.fact(num));
            Console.Read();
        }
    }
}
