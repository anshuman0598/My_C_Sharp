using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqExample_GroupBy_
{
	public class Program
	{
		public static void Main()
		{
			// Student collection
			IList<Student> studentList = new List<Student>() {
			new Student() { StudentID = 1, StudentName = "John", Age = 18, StandardID = 1 } ,
				new Student() { StudentID = 2, StudentName = "Steve",  Age = 21, StandardID = 1 } ,
				new Student() { StudentID = 3, StudentName = "Bill",  Age = 18, StandardID = 2 } ,
				new Student() { StudentID = 4, StudentName = "Ram" , Age = 20, StandardID = 2 } ,
				new Student() { StudentID = 5, StudentName = "Ron" , Age = 21 }
		};

			var studentsGroupByStandard = from s in studentList
										  where s.StandardID > 0
										  group s by s.StandardID into sg
										  orderby sg.Key
										  select new { sg.Key, sg };


			foreach (var group in studentsGroupByStandard)
			{
				Console.WriteLine("StandardID {0}:", group.Key);

				group.sg.ToList().ForEach(st => Console.WriteLine(st.StudentName));
			}
		}
	}
	public class Student
	{
		public int StudentID { get; set; }
		public string StudentName { get; set; }
		public int Age { get; set; }
		public int StandardID { get; set; }



	}
}


