using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalReferanceDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] students = { "Raj", "Ram", "Anil", "Jay" };
            Console.WriteLine("Array: [" + string.Join(",", students) + "]");
            //creating local referance
            ref string student = ref students[3];
            student = "peter";//it will change array value at third index
            Console.WriteLine("Updated array: [" + string.Join(",", students) + "]");
            Console.Read();
        }
    }
}
