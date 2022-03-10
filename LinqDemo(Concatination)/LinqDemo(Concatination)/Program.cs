using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqDemo_Concatination_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IList<string> list = new List<string>() {"one", "two", "three" };
            IList<string> list2 = new List<string>() { "four", "five", };
            var concatList = list.Concat(list2);
            foreach(var item in concatList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("/------------------------------------------/");
            IList<int> list3 = new List<int>() { 1, 2, 3 };
            IList<int> list4 = new List<int>() { 4, 5, 6 };
            var concatList1 = list3.Concat(list4);
            foreach (var item in concatList1)
            {
                Console.WriteLine(item);
            }

            Console.Read();
        }
    }
}
