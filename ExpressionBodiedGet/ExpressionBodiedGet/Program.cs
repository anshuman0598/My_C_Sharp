using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressionBodiedGet
{
    class Student
    {
        // Expression Bodied Get Property
        public static string Name { get => "Anshuman Das";  }

        
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine(Student.Name);
            Console.Read();
        }
    }
}
