using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GtterSetter
{
    class Person
    {
        public String name { get; set; }
        public int age { get; set; }
        public void printData()

        {
            Console.WriteLine("Name : "+name);
            Console.WriteLine("Age  : "+age);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.name = "Anshuman Das";
            person.age = 23;
            person.printData();
            Console.Read();
        }
    }
}
