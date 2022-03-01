using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Default_Value_GetterOnly_Demo
{
    class Student
    {
        public string Name { get; } = "Anshuman Das";
        public string Email { get; } = "dasanshuman@gmail.com";
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            Console.WriteLine(student.Name);
            Console.WriteLine(student.Email);
            Console.Read();
        }
    }
}
