using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Protected_demo
{
    public class Person
    {
        protected string name = "Anshuman Das";
        protected int age = 23;
    }
    class Employee : Person
    {
        
        public int Salary = 400000;
        public void Display()
        {
            Console.WriteLine("The Employee's name is "+name);
            Console.WriteLine("The Employee's age is  "+age);
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.Display();
            Console.WriteLine("The Salary is          "+emp.Salary);
            Console.Read();
        }
    }
}
