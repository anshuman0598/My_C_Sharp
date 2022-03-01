using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Overloading_Demo2
{
    public class MAX
    {
        public void max(int a, int b, int c)
        {
            int m;
            if (a > b && a > c)
                m = a;
            else if (b > a || b > c)
                m = b;
            else
                m = c;
            Console.WriteLine("The maximum number is " + m);
        }
        public void max(double a, double b, double c)
        {
            double m;
            if (a > b && a > c)
                m = a;
            else if (b > a || b > c)
                m = b;
            else
                m = c;
            Console.WriteLine("The maximum number is " + m);
        }
        public void max(float a, float b, float c)
        {
            float m;
            if (a > b && a > c)
                m = a;
            else if (b > a || b > c)
                m = b;
            else
                m = c;
            Console.WriteLine("The maximum number is " + m);
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MAX m = new MAX();
            m.max(4, 9,7);
            m.max(4.8d, 9.5d, 2.5d);
            m.max(7.3f, 5.4f, 7.1f);

        }
    }
}
