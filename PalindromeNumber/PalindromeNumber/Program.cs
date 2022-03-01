using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to check Palindrome");
            int  n =int.Parse(Console.ReadLine());
            int m = n;
            int num = 0;
            while(m > 0)
            {
                int r = m % 10;
                num = num*10 + r;
                m /= 10;
            }
            if(num==n)
            {
                Console.WriteLine("It is a Palindorme Number");
            }
            else
            {
                Console.WriteLine("It is not a plaindrome number");
            }
        }
    }
}