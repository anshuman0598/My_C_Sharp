using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MothodDemo2
{
    class Rectangle
    {
        int length, breadth, area, peri;
        public void Accept()
        {
            Console.WriteLine("Enter the length :");
            length = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the breadth :");
            breadth= int.Parse(Console.ReadLine());
        }
        public void calculate()
        {
            area = length * breadth;
            peri = 2*(length + breadth);
        }
        public void print()
        {
            Console.WriteLine("The area is      : "+area);
            Console.WriteLine("The Perimeter is : "+peri);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle();
            rectangle.Accept();
            rectangle.calculate();
            rectangle.print();
        }
    }
}
