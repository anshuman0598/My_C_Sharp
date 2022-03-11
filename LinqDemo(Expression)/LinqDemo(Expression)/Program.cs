using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace LinqDemo_Expression_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Expression<Func<Student, bool>> isTeenAgerExpr = s => s.Age > 12 && s.Age < 20;
            // Compile Expression using Compile Method to Invoke it as Delegate

            Func<Student, bool> isTeenAger = isTeenAgerExpr.Compile();

            // Invoke

            bool result = isTeenAger(new Student() { StudentID=1, StudentName="John", Age = 15});
            Console.WriteLine(result);
        }
    }
    public class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }
    }
}
