﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqDemo_EqualityOperator_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //IList<string> list1 = new List<string>() { "one", "two", "three", "four", "five" };
            //IList<string> list2 = new List<string>() { "one", "two", "three", "four", "five" };
            //bool isEqual = list1.SequenceEqual(list2);
            //Console.WriteLine(isEqual);
          
                Student std = new Student() { StudentId = 1, StudentName = "Bill" };
                IList<Student> studentList1 = new List<Student>() { std };
                IList<Student> studentList2 = new List<Student>() { std };
                bool isStudentEqual = studentList1.SequenceEqual(studentList2);
                Console.WriteLine(isStudentEqual);

                Student std1 = new Student() { StudentId = 1, StudentName = "Saikat" };
                Student std2 = new Student() { StudentId = 1, StudentName = "Bill" };
                IList<Student> studentList3 = new List<Student>() { std1 };
                IList<Student> studentList4 = new List<Student>() { std2 };
                isStudentEqual = studentList3.SequenceEqual(studentList4);
                Console.WriteLine(isStudentEqual);
                Console.ReadLine();
            
        }
        public class Student
        {
            public int StudentId { get; set; }
            public string StudentName { get; set; }
        }

    }
    
   
}
