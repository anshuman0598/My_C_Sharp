using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace Linq_Demo_ofType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IList mixedList = new ArrayList();
            mixedList.Add(0);
            mixedList.Add("ONE");
            mixedList.Add(3);
            mixedList.Add(new Student() { StudentId = 1, StudentName = "Bill", Age = 15 });
            mixedList.Add(new Student() { StudentId = 2, StudentName = "Joe", Age=19});
            var stringResult = from s in mixedList.OfType<string>() select s;
            var intResult = from s in mixedList.OfType<int>() select s;
            var stdResult = from s in mixedList.OfType<Student>() select s;
            foreach (var str in stringResult)
                Console.WriteLine(str);
            foreach (var integer in intResult)
                Console.WriteLine(integer);
            foreach (var std in stdResult)
                Console.WriteLine(std.StudentName);


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
