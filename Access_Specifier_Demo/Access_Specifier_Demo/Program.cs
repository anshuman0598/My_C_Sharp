using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access_Specifier_Demo
{
    class Rectangle
    {
        private double length;
        private double breadth;
        public void setDetails()
        {
            Console.WriteLine("Enter the length and the breadth of the reacangle:");
            length = double.Parse(Console.ReadLine());
            breadth = double.Parse(Console.ReadLine());
       
        }
        public double GetArea()
        {
            return (length*breadth);
        }
        public void Display()
        {
            Console.WriteLine("Length is " +length) ;
            Console.WriteLine("Breadth is " +breadth);
            Console.WriteLine("The area of the rectangle is : " + GetArea());
        }

    }
    internal class Program
    {

        static void Main(string[] args)
        {
            Rectangle r = new Rectangle();
            
            r.setDetails();
            r.Display();
            Console.Read();
        }
    }
}
