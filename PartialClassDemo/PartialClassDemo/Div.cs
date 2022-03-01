using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClassDemo
{
    partial class Calc
    {
        public void div(int a, int b)
        {
            Console.WriteLine("The quotient is : " + (a / b));
        }
    }
}
