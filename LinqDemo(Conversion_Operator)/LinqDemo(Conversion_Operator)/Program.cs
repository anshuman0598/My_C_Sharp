using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqDemo_Conversion_Operator_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IList<string> list = new List<string>()
            {
                "one",
                "two",
                "three",
                "four",
                "three"
            };
            Console.WriteLine("List Type " + list.GetType().Name);

            string[] strArray = list.ToArray(); // convert List to Array 

            Console.WriteLine("strArray Length: "+strArray.Length);
            Console.WriteLine("strArray Type: "+strArray.GetType().Name);

            IList<string> list2 = strArray.ToList<string>(); // Convert Array to List
            Console.WriteLine("List2 Type " + list2.GetType().Name); 


        }
    }
}
