using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace RegularExpressionDemo
{
    internal class Program
    {
        private static void showMatch(string text, string expr)
        {
            Console.WriteLine("The Expression : " + expr);
            MatchCollection matches = Regex.Matches(text, expr);
            foreach (Match m in matches)
            {
                Console.WriteLine(m);
            }
        }
        static void Main(string[] args)
        {
            string str = "make maze and manag to measure it";
            Console.WriteLine("Matching Words starting with m and ending with e");
            showMatch(str, @"\bm\S*e\b");
            Console.Read();
        }
    }
}
