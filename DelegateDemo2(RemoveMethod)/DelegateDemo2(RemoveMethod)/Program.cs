using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemo2_RemoveMethod_
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
            visi x1;
            abc x = new abc();
            x1 = x.put;
            x1 += abc.put1;
            x1 += x.put;
            x1();
            Console.WriteLine("Removing method from Delegate");
            x1 -= abc.put1;
            x1();
            Console.WriteLine("Removing method from Delegate");
            x1 -= x.put;
            x1();

            Console.Read();
        }
    }
}
