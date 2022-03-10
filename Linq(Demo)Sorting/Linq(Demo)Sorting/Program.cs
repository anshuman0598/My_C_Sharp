using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Demo_Sorting
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
                new Student() { Id = 5, Name ="Ron", Age=19}

            };
            //var orderbyresult = from s in list
            //                     orderby s.Name select s;
            //var orderbydescendingresult = from s in list orderby s.Name descending select s;

            //------------------------USing Excension method

            var orderbyresult = list.OrderBy(x => x.Name);

            var orderbydescendingresult = list.OrderByDescending(x => x.Name);

            Console.WriteLine("Ascending Order:");
            foreach(var str in orderbyresult)
            {
                Console.WriteLine(str.Name);
            }
            Console.WriteLine("Descending Order:");
            foreach(var str in orderbydescendingresult)
                Console.WriteLine(str.Name);
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
