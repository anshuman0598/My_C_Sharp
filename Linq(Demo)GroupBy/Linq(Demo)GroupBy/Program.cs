using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Demo_GroupBy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IList<Student> list = new List<Student>()
            {
                new Student() { Id = 1, Name = "John", Age = 18 },
                new Student() { Id = 2, Name = "Steve", Age = 25 },
                new Student() { Id = 3, Name = "Bill", Age = 25 },
                new Student() { Id = 4, Name = "Ram", Age = 20},
                new Student() { Id = 5, Name ="Ron", Age=20},
                new Student() { Id = 4, Name = "Ram", Age = 23},
                new Student() { Id = 6, Name ="Bill", Age= 23}


            };
            //var groupdResult = from s in list group s by s.Age;
            //-----------EXTENSION METHOD------------------
            var groupdResult = list.GroupBy(s => s.Age);
            foreach (var agegr in groupdResult)
            {
                Console.WriteLine("Age Group: " +agegr.Key);
                foreach(Student s in agegr)
                {
                    Console.WriteLine("Student Name: " + s.Name);
                }
            }
            //-------------LOOKUP
            var LookupResult = list.ToLookup(s => s.Age);
            Console.WriteLine();
            foreach (var agegr in LookupResult)
            {
                Console.WriteLine("Age Group: " + agegr.Key);
                foreach (Student s in agegr)
                {
                    Console.WriteLine("Student Name: " + s.Name);
                }
            }
            Console.Read();
        }
    }
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

    }
}
