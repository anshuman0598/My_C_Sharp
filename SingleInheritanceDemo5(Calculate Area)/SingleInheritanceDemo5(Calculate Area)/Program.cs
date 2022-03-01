using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleInheritanceDemo5_Calculate_Area_
{
    class Rectangle
    {
        protected int length;
        protected int breadth;
       /* public Rectangle(int length, int breadth)
        {
            this.length = length;
            this.breadth = breadth;
        }*/
    }
    class Area : Rectangle
    {
     
        /*public Area(int length, int breadth)
        {
            this.length=length;
            this.breadth=breadth;
        }*/
        public int calculateArea(int length,int breadth)
        {
            this.length=length;
            this.breadth=breadth;
            return length * breadth;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Length and Breadth of the Rectangle");
            int l = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Area ar = new Area();
            Console.WriteLine("The Area os the rectangle is : "+ ar.calculateArea(l,b));
            Console.Read();
        }
    }
}
