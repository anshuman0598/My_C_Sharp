using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternExample5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Range of the Triangle");
            int n = int.Parse(Console.ReadLine());
            for(int i = 1; i <= n; i++)
            {
                for(int j = 1; j <= n; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
            Console.Read();
        }
    }
}
