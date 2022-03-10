using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqDemo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //String collection
            IList<string> list = new List<string>()
            {
                "C# Tutorials",
                "VB.NET Tutorials",
                "Learn C++",
                "MVC Tutorials",
                "Java"
            };
            // Linq Query Syntax
            var result = from s in list where s.Contains("Tutorials") select s;
            foreach(var str in result)
            {
                Console.WriteLine(str+" ");
            }
            Console.ReadLine();
        }
    }
}
