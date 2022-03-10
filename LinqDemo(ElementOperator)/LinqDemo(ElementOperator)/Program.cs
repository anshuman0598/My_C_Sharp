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
            //IList<int>  intList = new List<int>() { 10,20,30,45,50,87 };
            //IList<string> stringList = new List<string>() { "One", "two", null, "four", "five" };

            //--ELEMENTAT AND ELEMENTAT_OR_DEFAULT

            //Console.WriteLine("1st Element in intList " + intList.ElementAt(0));
            //Console.WriteLine("1st Element in stringList " + stringList.ElementAt(0));
            //Console.WriteLine("2nd Element in intList " + intList.ElementAt(1));
            //Console.WriteLine("2nd Element in stringList " + stringList.ElementAt(1));
            //Console.WriteLine("3rd Element in intList " + intList.ElementAtOrDefault(2));
            //Console.WriteLine("3rd Element in stringList " + stringList.ElementAtOrDefault(2));
            //Console.WriteLine("10th Element in intList " + intList.ElementAtOrDefault(9));
            //Console.WriteLine("10th Element in stringList " + stringList.ElementAtOrDefault(9));

            //Console.WriteLine("intList.ElementAtOrDefault(9) throws an exception : Index out of range");

            //Console.WriteLine(intList.ElementAt(9));

            //--FIRST

            //IList<int> intList = new List<int>() { 10, 20, 21, 30, 45, 50, 87 };
            //IList<string> stringList = new List<string>() {null, "two", "three", "four", "five" };
            //IList<string> emptyList = new List<string>(); // Empty List
            //Console.WriteLine("1st Element in intList " + intList.First());
            //Console.WriteLine("1st Element in stringList " + stringList.First());

            //Console.WriteLine("1st Element in Empty List " + emptyList.First());

            //var greater = intList.First(s => s > 21);
            //Console.WriteLine("First Number Greater Than 21 is " + intList.First(s => s > 21));

            ////--LAST
            ///
            //IList<int> intList = new List<int>() { 10, 20, 21, 30, 45, 50, 87 };
            //IList<string> stringList = new List<string>() { null, "two", "three", "four", "five" };
            //Console.WriteLine("The Last Element is intList is :"+intList.Last());
            //Console.WriteLine("The Last Element is stringList is :" + stringList.Last());
            //Console.WriteLine("The Last Even Element is intList is :" + intList.Last(s=> s%2==0));

            ////-- LASTORDEFAULT
            //IList<int> intList = new List<int>() { 101, 201, 211, 301, 451, 501, 871 };
            //IList<string> stringList = new List<string>() { null, "two", "three", "four", "five" };
            //IList<string> emptyList = new List<string>(); // Empty List
            //Console.WriteLine("The Last Element is intList is :" + intList.LastOrDefault());
            //Console.WriteLine("The Last Element is stringList is :" + stringList.LastOrDefault());
            //Console.WriteLine("The Last Even Element is intList is :" + intList.LastOrDefault(s => s % 2 == 0));
            //Console.WriteLine("");
            //Console.WriteLine("The Last Element in Empty List is : " + emptyList.LastOrDefault());

            //-- Single

            IList<int> intList = new List<int>() { 101, 201, 211, 301, 451, 501, 871 };
            IList<string> stringList2 = new List<string>() { "Geo" };
            IList<string> emptyList = new List<string>(); // Empty List
            IList<string> stringList = new List<string>() { null, "two", "three", "four", "five" };
            Console.WriteLine(stringList2.Single());
            Console.WriteLine(stringList2.SingleOrDefault());
            Console.WriteLine(intList.Single(s => s == 211));
            Console.WriteLine(intList.SingleOrDefault(s => s == 221));
            Console.WriteLine(emptyList.SingleOrDefault());


            Console.Read();


        }
    }
}
