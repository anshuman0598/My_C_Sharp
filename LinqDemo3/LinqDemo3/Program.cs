using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqDemo3_Filtering_Example_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IList<Student> Studentlist = new List<Student>()
            {
                new Student(){ StudentId = 1, StudentName ="John",Age=13},
                new Student(){ StudentId = 2, StudentName ="Moin",Age =21},
                new Student(){ StudentId = 3, StudentName ="Bill",Age = 18},
                new Student(){ StudentId = 4, StudentName ="Ram",Age = 20},
                new Student(){ StudentId = 5, StudentName ="Ron", Age = 15}
            };
            var teenAgerStudent = from s in Studentlist where s.Age >= 12 && s.Age < 20 select s;
            Console.WriteLine("Teenage Students Are:");
            foreach (var str in teenAgerStudent)
                Console.WriteLine(str.StudentName);
            Console.ReadLine();
        }
    }
    class Student 
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }

        public int Age { get; set; }
    }
}
