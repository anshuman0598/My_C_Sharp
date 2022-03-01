using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumofNum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Sum = 0;
            Console.WriteLine("Enter the Range of number to be added");
            int n=int.Parse(Console.ReadLine());
            for(int i=1;i<=n;i++)
            {
                Sum = Sum + i;
            }
            Console.WriteLine("The Sum is "+Sum);
        }
    }
}
