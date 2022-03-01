using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternMatchingDemo1
{
    class Student
    {
        public string Name { get; set; } = "Rahul Kumar";
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            if(student is Student)
            {
                Console.WriteLine(student.Name);
            }
            Console.Read();
        }
    }
}
