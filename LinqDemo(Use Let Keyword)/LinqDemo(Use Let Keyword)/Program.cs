using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqDemo_Use_Let_Keyword_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IList<Student> studentList = new List<Student>()
            {
                new Student(){ StudentID = 1, StudentName = "John",Age =18},
                new Student(){ StudentID = 2, StudentName = "Steve",Age =21},
                new Student(){ StudentID = 3, StudentName = "Bill",Age =18},
                new Student(){ StudentID = 4, StudentName = "Ram",Age =20},
                new Student(){ StudentID = 5, StudentName = "Ron",Age =21},
            };

            var lowerCaseStudentsNames = from s in studentList
                                         let lower = s.StudentName.ToLower()
                                         where lower.StartsWith("r")
                                         select lower;
            foreach (var s in lowerCaseStudentsNames)
                Console.WriteLine("Student Name: " + s);
            Console.Read();
        }

    }
    public class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }
    }

}
