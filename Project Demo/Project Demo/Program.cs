using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Add a = new Add();
            Sub s = new Sub();
            Mul m = new Mul();
            Console.WriteLine(a.add(8, 9));
            Console.WriteLine(s.sub(18, 11));
            Console.WriteLine(m.mul(10,15));
        }
    }
}
