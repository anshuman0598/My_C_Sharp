using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverrideing3
{
    public class Animal
    {
        public void eat()
        {
            Console.WriteLine("Eating...");
        }
    }
    public class Dog : Animal
    {
        public void bark()
        {
            Console.WriteLine("Barking.....");
        }
    }
    public class BabyDog : Dog
    {
        public void weep()
        {
            Console.WriteLine("Weeping....");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            BabyDog b=new BabyDog();
            b.eat();
            b.bark();
            b.weep();
            Console.Read();
        }
    }
}
