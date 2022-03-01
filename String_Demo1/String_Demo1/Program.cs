using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Demo1
{
    
        class Program
        {
            static void Main(string[] args)
            {
                String k = "Vision";
                String k1 = (String)k.Clone();// explicit conversion is mandatory
                Console.WriteLine(k1);

                if (k.CompareTo(k1) == 0)
                    Console.WriteLine("Both are equal");
                else
                    Console.WriteLine("Not Equal strings");

                char[] a = new char[k1.Length + 1];
                k1.CopyTo(0, a, 0, k1.Length);
                Console.WriteLine(a);

                Console.WriteLine(k1.EndsWith("n"));
                Console.WriteLine(k1.StartsWith("p"));
                if (k1.Equals(k) == true)
                    Console.WriteLine("Both are equal");
                else
                    Console.WriteLine("Not Equal");

                Console.WriteLine(k1.IndexOf("s"));
                Console.WriteLine(k1.LastIndexOf("i"));
                String k2 = k1.Insert(3, "PrasaD");
                Console.WriteLine(k2);
                String p = k.PadLeft(20);
                Console.WriteLine(p);
                String p1 = k.PadLeft(20, '#');
                Console.WriteLine(p1);
                String p2 = k.PadRight(20, '*');
                Console.WriteLine(p2);
                String p3 = k1.Remove(3);
                Console.WriteLine(p3);
                String p4 = k1.Remove(3, 1);
                Console.WriteLine(p4);
                String p5 = k1.Replace('i', 'p');
                Console.WriteLine(p5);
                char[] deli = { '.', ',', ':' };
                String p6 = "Welcome. To vison. Computers, are the : one of the, Important";
                String[] p7 = p6.Split(deli);
                for (int i = 0; i < p7.Length; i++)
                    Console.WriteLine(p7[i]);
                Console.WriteLine(k.Substring(4,2));
                Console.WriteLine(k.Substring(3, 2));
                char[] c1 = k.ToCharArray();
                Console.WriteLine(c1);
                Console.WriteLine(k.ToLower());
                Console.WriteLine(k.ToUpper());

                String p8 = "     Vision    ";
                String p9 = p8.Trim();
                Console.WriteLine(p9);
                Console.WriteLine(String.Compare("Prasad", "Pramad"));
                String p10 = String.Concat("PrasaD", "Vision");
                Console.WriteLine(p10);
                double d = 10.4564;

                String p11 = String.Format("{0:E}", d); // 0:E format sets the scientific notation
                Console.WriteLine(p11);
                String p111 = d.ToString("C"); // preceds $ curency sign
                Console.WriteLine(p111);

                String[] p12 = { "prasaD", "vision", "murali", "Vamsi", "Gautam" };

                // Concatinates the all string seperated by -
                String p13 = String.Join("-", p12);
                Console.WriteLine(p13);
            }
        }
   
}


            
