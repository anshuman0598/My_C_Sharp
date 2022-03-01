using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anonymous_Method_demo
{
    internal class Program
    {
        public delegate void function();
         static void Main(string[] args)
         {
            function f = delegate ()
            {
                Console.WriteLine("This is a anonymous function");
            };
            f();
          
            Console.Read();
         }
    }
}
