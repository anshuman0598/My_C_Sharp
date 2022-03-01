using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor__Destructor_Demo_1
{
    class Rectangle
    {
        int height, width, area;
        public Rectangle(int height, int width)
        {
            this.height = height;
            this.width = width;
            area = height * width;
            Console.WriteLine("Area of Rectangle = "+area);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the height and width of the Rectangle:");
            int h=int.Parse(Console.ReadLine());
            int w=int.Parse(Console.ReadLine());    
            Rectangle rect = new Rectangle(h,w);
            Console.Read();
        }
    }
}
