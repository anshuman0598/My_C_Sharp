using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilderDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            StringBuilder sb = new StringBuilder();
            StringBuilder sb1 = new StringBuilder(20);// 20 is the capacity of string
            StringBuilder sb2 = new StringBuilder("Prasad");
            StringBuilder sb3 = new StringBuilder("prasAD", 2, 3, 10);
            Console.WriteLine(sb);
            Console.WriteLine(sb1);
            Console.WriteLine(sb2);
            Console.WriteLine(sb3);

        }
    }
}
