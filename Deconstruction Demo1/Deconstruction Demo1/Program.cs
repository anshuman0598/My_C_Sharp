using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deconstruction_Demo1
{
    public class Student
    {
        private string Name;
        private string Email;
        public Student(string name, string email)
        {
            Name = name;
            Email = email;
        }
        //creating deconstructor
        public void Deconstruct(out string name, out string email)
        {
            name = Name;
            email = Email;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var student = new Student("Ram", "ram@gmail.com");
            var (name, email) = student;
            Console.WriteLine(name+" "+email);
            Console.ReadLine();
        }
    }
}
