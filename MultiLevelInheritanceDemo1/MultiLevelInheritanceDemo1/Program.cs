using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiLevelInheritanceDemo1
{
    class Rectangle
    {
        public void rectangle_area()
        {
            int height = 24,
            width = 46, ar;
            ar = height * width;
            Console.WriteLine("Rectangle Area=" + ar);
        }
    }
    class Square : Rectangle
    {
        public void square_area()
        {
            int side = 20, ar;
            ar = side * side;
            Console.WriteLine("Square Area=" + ar);
        }
    }
    class Triangle : Square
    {
        public void triangle_area()
        {
            float Height = 27, Base = 23, ar;
            ar = 0.5f * Height * Base;
            Console.WriteLine("Triangle Area=" + ar);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Triangle obj=new Triangle();
            obj.rectangle_area();
            obj.square_area();
            obj.triangle_area();
            Console.ReadKey();
               
        }
    }
}
