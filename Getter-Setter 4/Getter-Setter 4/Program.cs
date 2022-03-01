using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Getter_Setter_4
{
    public class Student
    {
        private int studentid;
        private string studentname;

        public string StudentName
        {
            get {
                Console.WriteLine("This is get accessor of Student name.");
                return studentname; }
            set {
                Console.WriteLine("This is set accessor of Student name.");
                studentname = value; }
        }
        public int StudentId
        {
            get
            {
                Console.WriteLine("This is get accessor of Student ID.");
                return studentid;
            }
            set
            {
                Console.WriteLine("This is set accessor of Student ID.");
                studentid = value;
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.StudentName ="Anshuman Das";
            student.StudentId = 23;
            Console.WriteLine(student.StudentName);
            Console.WriteLine(student.StudentId);
            Console.Read();
        }
    }
}
