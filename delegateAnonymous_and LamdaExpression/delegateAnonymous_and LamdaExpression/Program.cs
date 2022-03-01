using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegateAnonymous_and_LamdaExpression
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> l = new List<string>();
            l.Add("PrasaD");
            l.Add("nag");
            l.Add("mohan");
            l.Add("renu");

            Console.WriteLine("Using delegate anonymous method");
            string s = l.Find(delegate (string nam)
            {
                return nam.Equals("nag");
            });
            if (s != null)
                Console.WriteLine(s);
            else
                Console.WriteLine("No Such name found");

            Console.WriteLine("Using Lambda expressions");
            string k = l.Find(n => n.Equals("PrasaD"));
            if (k != null)
                Console.WriteLine(k);
            else
                Console.WriteLine("No Such name found");



        }
    }

}
