using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticDemo
{
    static class Circle
    {
        static double pi = 3.14;
        public static int r;
        public static double getArea()
        {
            return pi*r*r;
        }
        public static void Display()
        {
            Console.WriteLine("Area = " + getArea());
            
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("Enter the radius of the circle");
            Circle.r = int.Parse(Console.ReadLine());
            Circle.Display();

        }
    }
}
