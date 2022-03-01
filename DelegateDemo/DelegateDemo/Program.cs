using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemo
{
    delegate void visi();
    class abc
    {
        public void put()
        {
            Console.WriteLine("This is put Method");
        }
        public static void put1()
        {
            Console.WriteLine("this is put 1 method");
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            visi x1, x2,x3;
            abc x = new abc();
            x1 = x.put;
            x2 = abc.put1;
            x3= x1 + x2;
            x3();

            Console.Read();
        }
    }
}
