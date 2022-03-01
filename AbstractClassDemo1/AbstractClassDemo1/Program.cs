using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassDemo1
{
    //abstract class
    abstract class MyBaseClass
    {
        public abstract void FirstMethod();
        public void SecondMethod()
        {
            Console.WriteLine("This is Non-Abstract MEthod");
        }
    }
    class MyDerivedClass : MyBaseClass
    {
        public override void FirstMethod()
        {
            Console.WriteLine("This is Abstract Method");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MyDerivedClass obj = new MyDerivedClass();
            obj.FirstMethod();
            obj.SecondMethod();
            Console.Read();
        }
    }
}
