using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace This_Demo2
{
    public class Geometry
    {
        public void Rectangle()
        {
            int l = 20, b = 14, ar;
            ar = l * b;
            Console.WriteLine("The area of the Rectangle is "+ar);

        }
        public void Square()
        {
            this.Rectangle();
            int s=8, ar;
            ar = s*s;
            Console.WriteLine("The area of the Square is " + ar);
            Console.Read();

        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Geometry geometry = new Geometry();
            geometry.Square();
        }
    }
}
