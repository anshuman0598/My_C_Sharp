using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternExample8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the range");
            int n = int.Parse(Console.ReadLine());
            for(int i=n;i>=1;i--)
            {
                int c = 1;
                for(int j=i;c<=i;j++,c++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
            Console.Read();
        }
    }
}
