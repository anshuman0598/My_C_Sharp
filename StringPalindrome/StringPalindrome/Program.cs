using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringPalindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the String : ");
            string s1 = Console.ReadLine();
            string s2="";
            
            for(int i = 0;i< s1.Length; i++)
            {
                s2 = s1[i] + s2;
            }
            if(s1.Equals(s2))
            {
                Console.WriteLine("Palindrome String");
            }
            else
            {
                Console.WriteLine("Not Palindrome String");
            }
        }
    }
}
