using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace This_Demo
{
    class Rectangle
    {
        int height = 5, width = 6, ar;
        public void area()
        {
            int height = 10, width = 20;

            //using local variable
            ar = height * width;
            Console.WriteLine("Area 1 = " + ar);
            // using class level variable
            ar = this.height * this.width;
            Console.WriteLine("Area 2 = " + ar);
        }
    }
        internal class Program
        {
            static void Main(string[] args)
            {
                Rectangle rect = new Rectangle();
                rect.area();
                Console.Read();
            }
        }
    
}
