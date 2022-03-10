using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqDemo_Aggregate_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //--Aggregate Method
            /*IList<string> strList = new List<string>() { "One", "Two", "Three", "Four", "Five" };
            var commaSeperatedString = strList.Aggregate((s1, s2) => s1 + "," + s2);
            Console.WriteLine(commaSeperatedString);
            */

            //--Average Method
            /*IList<int> intList = new List<int>() { 10, 20, 30, 40 };
            var avg = intList.Average();
            Console.WriteLine("Average is " + avg);*/
            /*IList<Student> studentList = new List<Student>() {
            new Student() { StudentID = 1, StudentName = "John", Age = 13 } ,
            new Student() { StudentID = 2, StudentName = "Moin",  Age = 21 } ,
            new Student() { StudentID = 3, StudentName = "Bill",  Age = 18 } ,
            new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 } ,
            new Student() { StudentID = 5, StudentName = "Ron" , Age = 15 }
            };
            var avg = studentList.Average(s => s.Age);
            Console.WriteLine("Average Age is: " + avg);*/

            //--Count Method
            /*IList<int> intList = new List<int>() { 1, 2, 3, 4, 5, 6 };
            var totalElements = intList.Count();
            Console.WriteLine("Total Elements: " + totalElements);
            var evenElements = intList.Count(s => s % 2 == 0);
            Console.WriteLine("Even Elements: " + evenElements);*/
            //----------------
            /*IList<Student> studentList = new List<Student>() {
            new Student() { StudentID = 1, StudentName = "John", Age = 13 } ,
            new Student() { StudentID = 2, StudentName = "Moin",  Age = 21 } ,
            new Student() { StudentID = 3, StudentName = "Bill",  Age = 18 } ,
            new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 } ,
            new Student() { StudentID = 5, StudentName = "Ron" , Age = 15 }
            };
            var totalStudent = studentList.Count();
            Console.WriteLine("Total Stidents: " + totalStudent);
            var ageCondition = studentList.Count(s => s.Age > 18);
            Console.WriteLine("No of Students whose age is greater than 18: " + ageCondition);
            var totalAge = (from s in studentList select s.Age).Count();
            Console.WriteLine(totalAge);

            //--------Max Method
            IList<int> intList = new List<int>() { 9, 2, 10, 5, 4, 12, 8 };
            var maxElement = intList.Max();
            var maxEven = intList.Max(i =>{
                                            if (i % 2 == 0)
                                               return i;
                                            else
                                                return 0;
                                        });         

                    
            Console.WriteLine("The max Element is: " + maxElement);
            Console.WriteLine("Even max Element is: " + maxEven);
            
            //-- SUM

            var maxage=studentList.Max(s=>s.Age);
            Console.WriteLine(maxage); 
            IList<int> intList = new List<int>() { 9, 2, 10, 5, 4, 12, 8 };
            var sum = intList.Sum();
            var sumEven = intList.Sum(s =>
            {
                
                if(s%2==0)
                {
                    return s;
                }
                return 0;
            });
            Console.WriteLine("The sum is " + sum);
            Console.WriteLine("The sum of even is "+sumEven);*/

            IList<Student> studentList = new List<Student>() {
            new Student() { StudentID = 1, StudentName = "John", Age = 13 } ,
            new Student() { StudentID = 2, StudentName = "Moin",  Age = 21 } ,
            new Student() { StudentID = 3, StudentName = "Bill",  Age = 18 } ,
            new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 } ,
            new Student() { StudentID = 5, StudentName = "Ron" , Age = 15 }
            };
            var sumofallAge=studentList.Sum(s => s.Age);
            var sumOfAge = studentList.Sum(s =>
            {
                if(s.Age >=18)
                    return s.Age;
                return 0;
            });
            var noOfAgeG18 = studentList.Count(s => s.Age>=18);
            Console.WriteLine("Sum of ages of all Students = " + sumofallAge);
            Console.WriteLine("Student with age Greater than 18 is = " + sumOfAge);
            Console.WriteLine("Number of Student with age Greater than 18 is = " + noOfAgeG18);

            Console.Read();
        }
        public class Student
        {
            public int StudentID { get; set; }
            public string StudentName { get; set; }
            public int Age { get; set; }

        }
    }
}

