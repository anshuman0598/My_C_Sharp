using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressionBodiedGetter_and_Setter
{
    class Student
    {
        private string SName;

        public Student(string name)=> SName = name;

        public string Name
        {
            get => SName;
            set => SName = value;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student("Anshuman Das");
            Console.WriteLine(s.Name);
            s.Name = "Peter Parker";
            Console.WriteLine(s.Name);

            Console.Read();

        }
    }
}
