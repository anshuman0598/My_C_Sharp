using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sealed_Class_Demo
{
    sealed class rect
    {
        int l, b;
        public void get(int x, int y)
        {
            l = x;
            b = y;
        }
        public void put()
        {
            Console.WriteLine("Rectangle "+ (l+b));
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            rect r = new rect();
            r.get(4,5);
            r.put();
            Console.Read();

        }
    }
}
