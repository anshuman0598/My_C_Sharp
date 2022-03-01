using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_Demo2
{
    class Student
    {
        private int stdid;
        private string name;
        public Student()
        {
            stdid = 0;
            name = "Unknown";
        }
        public Student(Student s)
        {
            stdid = s.stdid;
            name = s.name;
        }
        public Student (int id, string s)
        {
            stdid = id;
            name = s;
        }
        ~Student()
        {
            Console.WriteLine("-------------END OF PROGRAM--------------");
        }
        public void show()
        {
            Console.WriteLine("The Student Id is "+stdid);
            Console.WriteLine("The Student name is "+name);
        }
        
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Student obj1 = new Student();
            Student obj2 = new Student(10,"Anshuman");
            Student obj3 = new Student(obj2);
            Console.WriteLine("For Object 1 with no parameters");
            obj1.show();
            Console.WriteLine("For Object 2 with  parameters");
            obj2.show();
            Console.WriteLine("For Object 3 Copy Constructor");
            obj3.show();
            Console.Read();
        }
    }
}
