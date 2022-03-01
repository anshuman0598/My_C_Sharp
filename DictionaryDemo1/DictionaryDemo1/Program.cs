using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryDemo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> dic = new Dictionary<int, string>()
            {
                [1] = "Ram",
                [2] = "Sita",
                [3] = "Laxman"

            };
            foreach(KeyValuePair<int, string> kv in dic)
            {
                Console.WriteLine($"Key is {kv.Key} Value = {kv.Value}");
            }
            Console.Read();
        }
    }
}
