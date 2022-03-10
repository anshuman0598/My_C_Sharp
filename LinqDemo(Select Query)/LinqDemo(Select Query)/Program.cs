﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqDemo_Select_Query_
{
	public class Program
	{
		public static void Main()
		{
			IList<Student> studentList = new List<Student>() {
			new Student() { StudentID = 1, StudentName = "John", Age = 13 } ,
			new Student() { StudentID = 2, StudentName = "Moin",  Age = 21 } ,
			new Student() { StudentID = 3, StudentName = "Bill",  Age = 18 } ,
			new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 } ,
			new Student() { StudentID = 5, StudentName = "Ron" , Age = 15 }
		};
			//------------------- Query Syntax
			// returns collection of anonymous objects with Name and Age property
			//var selectResult = from s in studentList
			//				   select new { Name = "Mr. " + s.StudentName, Age = s.Age };
			//-------------------- Method Syntax
			var selectResult = studentList.Select(s => new { Name = "Mr." + s.StudentName, Age = s.Age });

			// iterate selectResult
			foreach (var item in selectResult)
				Console.WriteLine("Student Name: {0}, Age: {1}", item.Name, item.Age);
		}
	}

	public class Student
	{

		public int StudentID { get; set; }
		public string StudentName { get; set; }
		public int Age { get; set; }
	}

}
