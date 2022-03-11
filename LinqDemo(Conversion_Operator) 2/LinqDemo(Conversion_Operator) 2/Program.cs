using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqDemo_Conversion_Operator__2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IList<Student> studentList = new List<Student>()
            {
                new Student(){StudentID = 1, StudentName = "John", Age = 18},
                new Student(){StudentID = 2, StudentName = "Steve", Age = 21},
                new Student(){StudentID = 3, StudentName = "Bill", Age = 18},
                new Student(){StudentID = 4, StudentName = "Ram", Age = 20},
                new Student(){StudentID = 5, StudentName = "Ron", Age = 21}

            };
            IDictionary<int, Student> studentDictionary = studentList.ToDictionary<Student,int>(s => s.StudentID);
            // Or it can also be written as
            // IDictionary<int, Student> studentDictionary = studentList.ToDictionary(s => s.StudentID);

            foreach (var key in studentDictionary.Keys)
            {
                Console.WriteLine("Key: "+key+ " value "+ (studentDictionary[key] as Student).StudentName);
            }

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
