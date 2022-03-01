using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClassDemo
{
    partial class Calc
    {
        public void mul(int a, int b)
        {
            Console.WriteLine("The product is : " + (a * b));
        }
    }
}
