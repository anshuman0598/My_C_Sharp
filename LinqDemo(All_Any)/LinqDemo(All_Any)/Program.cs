using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqDemo_All_Any_
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
			IList<int> intList = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
			bool areAllStudentsTeen = studentList.All(s => s.Age > 12 && s.Age < 20);
			bool areAnyStudentsTeen = studentList.Any(s => s.Age > 12 && s.Age < 20);

			Console.WriteLine("Are ALL Teeangers "+areAllStudentsTeen);
			Console.WriteLine("Are ANY Teeangers " + areAnyStudentsTeen);
			//-----------------------------------------------CONSTAINS

			bool result = intList.Contains(4);
			bool result2=intList.Contains(11);
			Console.WriteLine("Does the list contains 4 " + result);
			Console.WriteLine("Does the list contains 11 " + result2);

			Console.Read();


		}
	}

	public class Student
	{

		public int StudentID { get; set; }
		public string StudentName { get; set; }
		public int Age { get; set; }
	}
}
//
