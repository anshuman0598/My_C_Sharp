using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor__Destructor_Demo_1
{
    internal class Program
    {
        class SimpleDemo
        {
            public SimpleDemo()
            {
                Console.WriteLine("This is Constructor........");
            }
            ~SimpleDemo()
            {
                Console.WriteLine("This is a Destructor.......");
            }
        }
     
        static void Main(string[] args)
        {
            SimpleDemo demo = new SimpleDemo();
            Console.Read();
        }
    }
}
