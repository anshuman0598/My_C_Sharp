using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqDemo_ElementOperator_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IList<int>  intList = new List<int>() { 10,20,30,45,50,87 };
            IList<string> stringList = new List<string>() { "One", "two", null, "four", "five" };

            Console.WriteLine("1st Element in intList " + intList.ElementAt(0));
            Console.WriteLine("1st Element in stringList " + stringList.ElementAt(0));
            Console.WriteLine("2nd Element in intList " + intList.ElementAt(1));
            Console.WriteLine("2nd Element in stringList " + stringList.ElementAt(1));
            Console.WriteLine("3rd Element in intList " + intList.ElementAtOrDefault(2));
            Console.WriteLine("3rd Element in stringList " + stringList.ElementAtOrDefault(2));
            Console.WriteLine("10th Element in intList " + intList.ElementAtOrDefault(9));
            Console.WriteLine("10th Element in stringList " + stringList.ElementAtOrDefault(9));

            Console.WriteLine("intList.ElementAtOrDefault(9) throws an exception : Index out of range");

            Console.WriteLine(intList.ElementAt(9));
        }
    }
}
