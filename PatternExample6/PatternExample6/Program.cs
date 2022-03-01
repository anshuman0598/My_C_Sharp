using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternExample6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Range of the Triangle");
            int n = int.Parse(Console.ReadLine());
            int a = 1;
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < 5; j++)
                {
                    Console.Write(a+" ");
                    a = a + 2;
                }
                Console.WriteLine();
            }
            Console.Read();
        }
    }
}
