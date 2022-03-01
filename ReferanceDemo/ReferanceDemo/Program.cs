using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferanceDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] students = { "Rahul", "John", "Mayank", "Raj" };
            //Calling a method that returns a referance
            ref string student = ref FindStudent(students, "John");
            Console.WriteLine(student+" Found");
                Console.Read();
        }

        static ref string FindStudent(string[] students, string student)
        {
            int i;
            for (i = 0; i < students.Length; i++)
            {
                if (students[i] == student)
                {
                    return ref students[i];
                }
            }
            
            throw new Exception("Student not Found");
           
            
        }
    }
}
