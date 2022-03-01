using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Overriding2
{
    class A
    {
        public virtual void Display()
        {
            Console.WriteLine("This is from Class A");
        }
    }
        
    class B : A
    {
        public override void Display()
        {
            //base.Display();
            Console.WriteLine("This is from class B");
        }
    } 
    class C : A
    {
        public override void Display()
        {
            //base.Display();
            Console.WriteLine("This is from class C");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
            B b = new B();
            C c = new C();
            a.Display();
            Console.WriteLine("------------------------------------------------------------------------");
            b.Display();
            Console.WriteLine("------------------------------------------------------------------------");
            c.Display();
            Console.Read();

        }
    }
}
