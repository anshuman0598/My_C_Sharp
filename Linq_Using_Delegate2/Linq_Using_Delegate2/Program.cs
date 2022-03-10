using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Using_Delegate2
{
	public class Program
	{
		delegate bool IsTeenAger(Student stud);

		public static void Main()
		{
			IsTeenAger isTeenAger = s => s.Age > 12 && s.Age < 20;
			Console.WriteLine("Enter the age to check you are teenager or not:");
			int i = int.Parse(Console.ReadLine());
			Student stud = new Student() { Age = i };

			Console.WriteLine(isTeenAger(stud));

			Console.ReadLine();

		}
	}

	public class Student
	{

		public int Id { get; set; }
		public string Name { get; set; }
		public int Age { get; set; }
	}

}
