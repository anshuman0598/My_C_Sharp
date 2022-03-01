using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle
{
    class rectangle
    {
        private double length,breadth;
        public void setLength(double length)
        {
            this.length = length;
        }
        public void setBreadth(double breadth)
        {
            this.breadth = breadth;
        }
        public double calcArea()
        {
            return length * breadth;
        }
        public void display()
        {
            Console.WriteLine("The length is  : " + length);
            Console.WriteLine("The breadth is : " + breadth);
            Console.WriteLine("The area is    : " + calcArea());
        }


    }
    internal class Program
    {
        static void Main(string[] args)
        {
            rectangle r= new rectangle();
            Console.WriteLine("Enter the length and breadth of the rectangle");
            r.setLength(double.Parse(Console.ReadLine()));
            r.setBreadth(double.Parse(Console.ReadLine()));
            r.display();
            Console.Read();
        }
    }
}
