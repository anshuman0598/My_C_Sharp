using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiltilevelInheritanceDemo2
{
    public class Base
    {
        public void Say()
        {
            Console.WriteLine("Base Hello");
        }
    }
    public class Derived : Base
    {
        public void DerivedSay()
        {
            Say();
            Console.WriteLine("Derived Hello");
        }
    }
    public class B : Derived
    {
        public void Speak()
        {
            DerivedSay();
            Console.WriteLine("B class Hello");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            B b = new B();
            b.Speak();
            Console.ReadLine();
        }

    }
}
