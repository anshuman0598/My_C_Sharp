using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqDemo_EqualityOperator_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IList<string> list1 = new List<string>() { "one", "two", "three", "four", "five" };
            IList<string> list2 = new List<string>() { "one", "two", "three", "four", "five" };
            bool isEqual = list1.SequenceEqual(list2);
            Console.WriteLine(isEqual);
            //---My Name is Anshuman
        }
    }
}
