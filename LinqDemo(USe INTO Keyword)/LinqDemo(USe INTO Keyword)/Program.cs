using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqDemo_USe_INTO_Keyword_
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
                new Student(){ StudentID = 5, StudentName = "Ron",Age =15},
                new Student(){ StudentID = 6, StudentName = "Raman",Age =17},
                new Student(){ StudentID = 7, StudentName = "Ramesh",Age =20},
                new Student(){ StudentID = 8, StudentName = "Rony",Age =14},
            };

            var teenstud = from s in studentList
                                         where s.Age > 12 && s.Age <20
                                         select s into teenstuds where teenstuds.StudentName.StartsWith("R")
                                            select teenstuds;
            foreach (Student s in teenstud)
                Console.WriteLine("Student Name: " + s.StudentName);
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
