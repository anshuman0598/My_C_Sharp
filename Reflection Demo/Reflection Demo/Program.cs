using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflection_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int a = 10;
            //Type t = a.GetType();
            //Console.WriteLine(t);
            Type t1=typeof(System.Array);
            //Console.WriteLine(t1.Assembly);
            Console.WriteLine(t1.FullName);
            Console.WriteLine(t1.BaseType);
            Console.WriteLine(t1.IsClass);
            Console.WriteLine(t1.IsEnum);
            Console.WriteLine(t1.IsInterface);
            Console.Read();
        }
    }
}
