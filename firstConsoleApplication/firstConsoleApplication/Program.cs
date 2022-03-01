using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstConsoleApplication2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Name");
            String s = Console.ReadLine();
            Console.WriteLine("Enter Your age");
            int a = Convert.ToInt32( Console.ReadLine());
            Console.WriteLine("The name is " + s);
            Console.WriteLine("The age is " + a);
            Console.Read();
        }
    }
}