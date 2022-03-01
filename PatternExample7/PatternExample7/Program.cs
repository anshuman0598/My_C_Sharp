using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternExample7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the range");
            int n = int.Parse(Console.ReadLine());
            for(int i = 1; i <= n; i++)
            {
                
                for(int j = 1; j <= i; j++)
                {
                    Console.Write((i % 2) + " ");
                }
                Console.WriteLine();

            }
            Console.Read();
        }
    }
}
