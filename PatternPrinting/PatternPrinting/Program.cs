using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternPrinting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, j;
            char c;
            string s = "";
            for (i = 1; i <= 5; i++)
            {
                s = "";
                for (j = 1; j <= 5 - i; j++)
                {
                    s += " ";
                }
                for (c = 'A'; c <= 'Z'; c++)
                {
                    if (j <= 5)
                    {
                        s += c;
                        j++;
                    }
                    else
                        break;
                }
                Console.Write(s);
                string s1 = s.Substring(0, j - 2);
                for (int k = s1.Length - 1; k >= 0; k--)
                {
                    if (s1[k] == ' ')
                        break;
                    Console.Write(s1[k]);
                }
                Console.WriteLine();
                
            }
            Console.Read();

            //--------------------------------------------------------------------
            //int n = 5;
            //char c = 'A';
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 5 - 1; j >= i; j--)
            //    {
            //        Console.Write(" ");

            //    }
            //    for (int k = 0; k <= i; k++)
            //    {
            //        Console.Write(c);
            //        c++;
            //    }
            //    c--;
            //    for (int l = 0; l < i; l++)
            //    {
            //        Console.Write(--c);
            //    }
            //    Console.WriteLine();
            //    c = 'A';
            //}
            //Console.Read();


        }
    }
}
