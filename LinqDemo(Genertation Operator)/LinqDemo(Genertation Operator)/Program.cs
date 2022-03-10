using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqDemo_Genertation_Operator_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////---Empty Method
            //var emptyCollection1 = Enumerable.Empty<string>();
            //var emptyCollection2 = Enumerable.Empty<Student>();
            //Console.WriteLine("Type" + emptyCollection1.GetType().Name);
            //Console.WriteLine("Count" + emptyCollection2.Count());

            ////---Range Method
            //var intCollecttion = Enumerable.Range(10, 10);
            //Console.WriteLine("Total count: " + intCollecttion.Count());

            //for (int i = 0; i < intCollecttion.Count(); i++)
            //{
            //    Console.WriteLine("Value at index " + intCollecttion.ElementAt(i));
            //}
            ////---Repeat Method
            var intCollecttion = Enumerable.Repeat(10, 10);
            Console.WriteLine("Total count: " + intCollecttion.Count());

            for (int i = 0; i < intCollecttion.Count(); i++)
            {
                Console.WriteLine("Value at index " + intCollecttion.ElementAt(i));
            }
            Console.Read();

        }
    }
    public class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        
    }
}
