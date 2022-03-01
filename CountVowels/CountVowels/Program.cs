using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountVowels
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the String");
            string s= Console.ReadLine();
            int count = 0;
            foreach (char c in s)
            {
                if (c =='a' || c =='e'|| c =='i'|| c =='o' || c=='u' ||
                    c == 'A' || c == 'E' || c == 'I' || c == 'O' || c == 'U')
                {
                    count++;
                }
            }
            Console.WriteLine("There are "+count+" vowels in the string "+s);
        }
    }
}
