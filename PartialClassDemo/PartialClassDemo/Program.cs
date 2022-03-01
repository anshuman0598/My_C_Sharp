using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClassDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calc c = new Calc();
            c.sum(45, 23);
            c.mul(6, 8);
            c.div(27, 9);
            c.sub(45, 34);
            Console.Read();
        }
    }
}
