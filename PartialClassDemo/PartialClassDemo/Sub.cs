using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClassDemo
{
    partial class Calc
    {
        public void sub(int a, int b)
        {
            Console.WriteLine("The difference is : " + (a - b));
        }
    }
}
