using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqDemo_Set_Operator_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////-- Distinct Method
            //IList<string> list = new List<string>() {"one","Two","Three","Two","Three" };
            //IList<int> list2 = new List<int>() { 1, 2, 3, 4, 3, 2, 5, 6, 1, 2 };
            //var distinctList1 = list.Distinct();
            //var distinctList2 = list2.Distinct();
            //foreach(var item in distinctList1)
            //    Console.WriteLine(item);
            //foreach(var item in distinctList2)
            //    Console.WriteLine(item);
            ////-------------------EXAMPLE------------------------
            IList<Student> studentList = new List<Student>() {
            new Student() { StudentID = 1, StudentName = "John", Age = 13 } ,
            new Student() { StudentID = 2, StudentName = "Moin",  Age = 21 } ,
            new Student() { StudentID = 3, StudentName = "Bill",  Age = 18 } ,
            new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 } ,
            new Student() { StudentID = 5, StudentName = "Ron" , Age = 15 }
            };


            //-- Except Method

            IList<string> list = new List<string>() { "One", "Two", "Three", "Four", "Five", "Six", "Seven" };
            IList<string> list2 = new List<string>() { "One", "Two", "Three", "Eight", "Nine", "Ten" };

            //var result1= list.Except(list2);
            //var result2 = list2.Except(list);

            //Console.WriteLine("list.Except(list2) :");
            //foreach (var item in result1)
            //    Console.WriteLine(item);

            //Console.WriteLine("\nlist2.Except(list) :");
            //foreach (var item in result2)
            //    Console.WriteLine(item);
            ////-- Intersect Method

            //var result3 = list.Intersect(list2);

            //Console.WriteLine("list.Intersect(list2) :");
            //foreach (var item in result3)
            //    Console.WriteLine(item);

            ////-- UNION METHOD

            //var result5 = list.Union(list2);
            //Console.WriteLine("list.Union(list2) :");
            //foreach (var item in result5)
            //    Console.WriteLine(item);

            //-- Skip

            var result6 = list.Skip(2);
            foreach (var item in result6)
                Console.WriteLine(item);
        }
    }
    public class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }

    }
}
