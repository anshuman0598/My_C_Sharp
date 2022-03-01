using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double pi = 3.14;
            Console.WriteLine("Enter the radius of the circle");
            int r= Convert.ToInt32( Console.ReadLine());
            double area = pi * r * r;
            Console.WriteLine("The area is = "+area);

        }
    }
}
