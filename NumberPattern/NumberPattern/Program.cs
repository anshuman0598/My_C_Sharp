using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The Range of the Triangle: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n-i; j++)
                {
                    Console.Write(" ");

                }
                int k;
                for (k = 1; k <= i; k++)
                {
                    Console.Write(k);
                    
                }
                
                for (int l =i-1; l >= 1; l--)
                {
                    Console.Write(l);
                }
                Console.WriteLine();
            }
            Console.Read();

        }
    }
}
