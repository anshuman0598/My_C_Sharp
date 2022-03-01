using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternMatching_using_Switch_Statement
{
    class Student
    {
        public string Name { get; set; } = "Rahul Kumar";  
    }
    class Teacher
    {
        public string Name { get; set; } = "Rameshwaram Mutthaswami";
        public string Specialization { get; set; } = "Computer Secience";
    }
    class Student2
    {
        public string Name { get; set; } = "Rahul";
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            Teacher teacher = new Teacher();
            Student2 student2 = new Student2();
            PatternInSwitch(student);
            PatternInSwitch(teacher);
            PatternInSwitch(student2);
            Console.Read();
        }
        public static void PatternInSwitch(Object obj)
        {
            switch(obj)
            {
                case Student student:
                    Console.WriteLine("Student Name:      "+student.Name);
                    break;
                case Teacher teacher:
                    Console.WriteLine("Teacher Name:      "+teacher.Name);
                    Console.WriteLine("Specialization in: "+teacher.Specialization);
                    break;
                default:
                    throw new ArgumentException(message:"Object is not Recognized", paramName:nameof(obj));

            }

        }
    }
}
