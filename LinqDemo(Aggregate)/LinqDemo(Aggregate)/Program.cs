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
            //IList<string> list = new List<string>() {"one","two","three","four","five" };
            //var commaSeperatedString =list.Aggregate((s1,s2) => s1 +", "+ s2);
            //Console.WriteLine(commaSeperatedString);
            

            // AVERAGE

            IList<int> intList = new List<int>() { 10, 20, 30 };
            var avg = intList.Average();
            Console.WriteLine(avg);

            //Console.ReadLine();

            Console.Read();
        }
    }
}
