using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternExample3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of rows");
            int n = int.Parse(Console.ReadLine());
            for(int i = 1; i <= n; i++)
            {
                for(int k =1;k<=n-i;k++)
                {
                    Console.Write(" ");
                }
                for(int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            Console.Read();
        }
    }
}
//for (i = 0; i < n; i++)
//{
//    for (j = 0; j <= n - i; j++)
//    {
//        Console.Write(" ");
//    }
//    for (k = i; k >= 0; k--)
//    {
//        Console.Write("*");
//    }
//    for (int l = 0; l < i; l++)
//    {
//        Console.Write("*");
//    }

//    Console.WriteLine();
//}