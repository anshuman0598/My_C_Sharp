using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expression_Constructor_Demo
{
    class Student
    {
        public string Name { get; set; }
        //Expression Constructor

        public Student(string name) => Name= name;
        //Expression Bodied Destructor
        ~Student() => Console.WriteLine("Finalizer Executing");


    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student st = new Student("Rahul");
            Console.WriteLine("Hello " + st.Name);
            Console.Read();
        }
    }
}
