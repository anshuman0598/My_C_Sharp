using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringInterpolationDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var name = "Peter"; 
            var age = 30; 
            // Composit format string
            Console.WriteLine("Name = {0}, age = {1}", name, age); 
            // String Interpolation
            var s1 = $"{name} is {age} years old.";
            Console.WriteLine(s1);
            Console.Read();

        }
    }
}
