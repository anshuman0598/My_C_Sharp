using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementation_using_Partial
{
    partial interface calculation
    {
        int add(int x, int y);
    }
    partial interface calculation
    {
        int subtraction(int x, int y);
    }
    class Interface1 : calculation
    {
        public int add(int x, int y)
        {
            return x + y;
        }
        public int subtraction(int x, int y)
        {
            return x - y;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Interface1 i = new Interface1();
            Console.WriteLine("the Sum is = " + i.add(5, 6));
            Console.WriteLine("The difference is = " + i.subtraction(8, 3));
        }
    }
}
