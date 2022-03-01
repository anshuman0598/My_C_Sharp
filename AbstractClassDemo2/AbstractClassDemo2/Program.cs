using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassDemo2
{
    abstract class Area
    {
        public abstract void RectangleArea();
        

        public void SqureArea()
        {
            Console.WriteLine("Enter the side of Square");
            int s = int.Parse(Console.ReadLine());
            
            Console.WriteLine("The Area is = " + (s * s));
        }
        public void TriangleArea()
        {
            Console.WriteLine("Enter the base and height of Triangle");
            int b = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());
            Console.WriteLine("The Area is = " + (0.5f * b * h));

        }
        public void CircleArea()
        {
            float pi = 3.14f;
            Console.WriteLine("Enter the Radius of the Circle");
            int r = int.Parse(Console.ReadLine());

            Console.WriteLine("The Area is = " + (pi * r * r));

        }
    }
    class Shape : Area
    {
        public override void RectangleArea()
        {
            Console.WriteLine("Enter the length and breadth of Rectangle");
            int l = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("The Area is = "+(l * b));
        }
        
            static void Main(string[] args)
            {
                Shape s = new Shape();
                s.RectangleArea();
                s.CircleArea();
                s.TriangleArea();
                s.SqureArea();
        }

    }

    
}
