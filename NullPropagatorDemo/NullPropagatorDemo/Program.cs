using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullPropagatorDemo
{
    class Student
    {
        public string Name { get; set; }
        public string Email { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            ////Without Null Propagator
            //    Student student = new Student() {Name= "Rahul Kumar"};
            //    //Checking for Null
            //    if(student.Name!=null)
            //    {
            //        Console.WriteLine(student.Name.ToUpper());
            //    }
            Student student = new Student() { Name="Anshuman Das"};
            Console.WriteLine(student?.Name?.ToUpper() ?? "Name is Empty");
            Console.WriteLine(student?.Email?.ToUpper() ?? "Email is Empty");
            Student student1 = new Student();
            Console.WriteLine(student1?.Name?.ToUpper() ?? "Name is Empty");
            Console.WriteLine(student1?.Email?.ToLower() ?? "Email is Empty");


                Console.Read();
        }
    }
}
