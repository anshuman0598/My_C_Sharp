using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int n = int.Parse(Console.ReadLine());
            int c = 0;
            for(int i = 1; i <= n/2; i++)
            {
                if (n % i == 0)
                    c++;
            }
            if (c == 1)
                Console.WriteLine("Prime Number");
            else
                Console.WriteLine("Not Prime Number");
        }
    }
}

