using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hierarchical_Inheritance
{
    class Shape
    {
        public  void displayShape()
        {
            Console.WriteLine("Two Dimentional Shape");
        }

    }
    class Rectangle : Shape
    {
        public void displayRectangle()
        {
            Console.WriteLine("This is Rectangle ");
        }
    }
    class Circle: Shape
    {
        public void displayCircle()
        {
            Console.WriteLine("This is Circle");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle();
            Circle c = new Circle();
            r.displayShape();
            r.displayRectangle();
            Console.WriteLine("----------------------------");
            c.displayShape();
            c.displayCircle();
            Console.Read();
        }
    }
}
