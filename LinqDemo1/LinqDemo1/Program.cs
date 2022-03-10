using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqDemo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Data Source
            string[] names = { "Bill", "Steve", "James", "Mohan" };
            // LINQ Query
            var myLinqQuery = from name in names
                              where name.Contains('a')
                              select name;
            // Query Execution
            foreach (var name in myLinqQuery)
                Console.WriteLine(name+ " ");
            Console.Read();

        }
    }
}
