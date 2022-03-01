using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClassDemo
{
    partial class Calc
    {
        public void sum(int a, int b)
        {
            Console.WriteLine("The sum is : " + (a + b));
        }
    }
}
