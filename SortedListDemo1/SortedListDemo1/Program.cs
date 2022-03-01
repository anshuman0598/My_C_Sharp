using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedListDemo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedList<string,string> list = new SortedList<string,string>();
            list.Add("1", "Suni");
            list.Add("4", " Peter");
            list.Add("5", "James");
            list.Add("3", "Suresh");
            list.Add("2", "Ramesh");
            foreach(KeyValuePair<string,string> kv in list)
            {
                Console.WriteLine(kv.Key+" "+ kv.Value);
            }
            Console.Read();
        }
    }
}
