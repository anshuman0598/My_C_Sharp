using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqDemoUsingDelegate5
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
                new Student(){ StudentId = 5, StudentName ="Ron", Age = 15},
                new Student(){ StudentId = 6, StudentName ="Alia", Age=25},
                new Student(){ StudentId = 7, StudentName ="Salman" ,Age = 25}
            };
             Func<Student, bool> isTeenAger = delegate (Student s)
             {
                 return s.Age > 12 && s.Age < 20;
             };
            //var teenAgerStudent = from s in Studentlist where s.Age >= 12 && s.Age < 20 select s;
            //Console.WriteLine("Teenage Students Are:");
            //var filteredResult = from s in Studentlist where isTeenAger(s) select s; -- FILTERING USING DELEGATE
            //--------------------------------FILTERING BY INDEX
            //var filteredResult = Studentlist.Where((s, i) =>
            //{
            //    if (i % 2 == 0)
            //        return true;
            //    return false;
            //});
            var filteredResult = Studentlist.Where(s=>s.Age>12).Where(s=>s.Age<20);
            foreach (var str in filteredResult)
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
