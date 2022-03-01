using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClassDemo
{
    public static class MyMath
    {
        public static float PI = 3.14f;
        public static int cube(int x)
        {
            return (x * x * x);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The value od PI is  " + MyMath.PI);
            Console.WriteLine("Volume of the cube with side 8 is " + MyMath.cube(8));
            Console.Read();
        }
    }
}
