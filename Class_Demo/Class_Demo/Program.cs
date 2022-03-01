using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Demo
{
    class Person
    {
        public int age;
        public String name;
        public void Display()
        {
            Console.WriteLine("The Name is : " + name);
            Console.WriteLine("The age is  : "+age);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            Console.WriteLine("Enter your name:");
            p.name = Console.ReadLine();
            Console.WriteLine("Enter your age:");
            p.age= int.Parse(Console.ReadLine());
            p.Display();
            Console.Read();
        }
    }
}
