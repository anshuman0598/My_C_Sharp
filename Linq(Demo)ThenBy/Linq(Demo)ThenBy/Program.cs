using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Demo_ThenBy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IList<Student> list = new List<Student>()
            {
                new Student() { Id = 1, Name = "John", Age = 18 },
                new Student() { Id = 2, Name = "Steve", Age = 15 },
                new Student() { Id = 3, Name = "Bill", Age = 25 },
                new Student() { Id = 4, Name = "Ram", Age = 20},
                new Student() { Id = 5, Name ="Ron", Age=19},
                new Student() { Id = 4, Name = "Ram", Age = 23},
                new Student() { Id = 6, Name ="Bill", Age= 20}


            };
            var thenByResult = list.OrderBy(x => x.Age).ThenBy(x => x.Name);
            var thenByDecResult = list.OrderBy(x => x.Name).ThenByDescending(x => x.Age);
            Console.WriteLine("Then By :");
            foreach (var str in thenByResult)
            {
                Console.WriteLine("Name: " + str.Name + " Age: " + str.Age);
            }
            Console.WriteLine("Then By Descending:");
            foreach (var str in thenByDecResult)
            {
                Console.WriteLine("Name: " + str.Name + " Age: " + str.Age);
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
