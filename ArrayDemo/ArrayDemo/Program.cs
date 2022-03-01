using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[5];
            a[0] = 20;
            a[1] = 30;
            a[2] = 35;
            a[3] = 42;
            a[4] = 43;
            int Sum = 0;
            for (int i = 0; i < 5; i++)
            {
                Sum=Sum+a[i];
            }
            Console.WriteLine("Sum of elements is : "+Sum);
           
            Console.Read();
        }
    }
}
