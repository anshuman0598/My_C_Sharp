using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqDemo_Joining_With_Standard_Method_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IList<Student> studentList = new List<Student>()
            {
                new Student(){StudentId = 1, StudentName= "John", StandardId=1},
                new Student(){StudentId = 2, StudentName="Moin", StandardId =1},
                new Student(){StudentId = 3, StudentName="Bill",StandardId=2},
                new Student(){StudentId = 4, StudentName="Ram",StandardId=2},
                new Student(){StudentId=5, StudentName="Ron"}
              
            };

            IList<Standard> standardList = new List<Standard>()
            {
                new Standard(){StandardId=1,StandardName="StandardId 1"},
                new Standard(){StandardId=2,StandardName="StandardId 2"},
                new Standard(){StandardId=3,StandardName="StandardId 3"}

            };
            // USING STANDARD METHOD
            //var innerjoin = studentList.Join(//outer join
            //                                 standardList,//inner sequence
            //                                              Student => Student.StandardId,
            //                                              Standard => Standard.StandardId,
            //                                              (Student, Standard) => new
            //                                              {
            //                                                  StudentName = Student.StudentName,
            //                                                  StandardName = Standard.StandardName,
            //                                              }
            //                                              );
            // USING SQL COMMIAND
            var innerjoin = from s in studentList
                            join st in standardList on s.StandardId equals st.StandardId
                            select new
                            {
                                StudentName = s.StudentName,
                                StandardName = st.StandardName,
                            };
            foreach (var s in innerjoin)
            {
                Console.WriteLine(s.StudentName+" - "+s.StandardName);
            }
            Console.Read();
        }
    }
    public class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public int StandardId { get; set; }
    }
    public class Standard
    {
        public int StandardId { get; set; }
        public string StandardName { get; set; }

    }

}
