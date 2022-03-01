using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Copy_Constructor_Demo
{
    class Rectangle
    {
        int area;
        public Rectangle(int height, int width)
        {
            area = height * width;
        }
        public void show()
        {
            Console.WriteLine("Area of the Rectangle = "+area);    
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle obj1 = new Rectangle(5,6);
            obj1.show();
            //passing obj1 in obj2
            Rectangle obj2 = obj1;
            obj2.show();

            Console.Read();
        }
    }
}
