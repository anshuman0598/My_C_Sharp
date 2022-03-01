using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateGeneric
{
    
    internal class Program
    {
        delegate string calculate<t1, t2>(t1 x, t2 y);
        public static string AddInt(int x, int y)
        {
            return (x + y).ToString();
        }
        public static string AddDouble(double x, double y)
        {
            return (x+y).ToString();
        }
        static void Main(string[] args)
        {
            calculate<double, double> add = new calculate<double, double>(AddDouble);
            calculate<int, int> add1 = new calculate<int,int>(AddInt);
            Console.WriteLine(add1.Invoke(4,7));
            Console.WriteLine(add.Invoke(100.7,78.3));
            Console.Read();
        }
    }
}
