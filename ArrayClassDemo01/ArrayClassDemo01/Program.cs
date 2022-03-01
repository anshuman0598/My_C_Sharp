using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayClassDemo01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[] {6,4,8,2,9};
            Console.WriteLine("The Single Dimensional Array is ");   
            foreach (int i in a)
            {
                Console.Write(i+" ");
            }
            Console.WriteLine();
            Console.WriteLine("Length of Single Dimension array "+a.Length);
            Console.WriteLine("Rank of Single Dimension array   "+a.Rank);
            Console.WriteLine("\n--------------------------------------------------\n");
            Console.WriteLine("The Double dimensional Array is :");
            int[,] ab = new int[,]{ { 2,3,4},{ 5,6,7} ,{9,8,7 } };
     
            int c = 0;
            foreach (int i in ab)
            {
                c++;
                Console.Write(i + " ");
                if(c == 3)
                {
                    c = 0;
                    Console.WriteLine();
                }
                
            }
            Console.WriteLine("Length of Double Dimension array " + ab.Length);
            Console.WriteLine("Rank of Single Dimension array   " + ab.Rank);
            Console.WriteLine();
            Console.WriteLine();
            Array.Sort(a);
            Console.WriteLine("Array after sorting---> ");
            for(int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i]+" ");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Array after Reversing----->");
            Array.Reverse(a);
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
            int[] b = new int[6];
            b[0] = 1;
            a.CopyTo(b, 1);
            Console.WriteLine("Array B After copying from A");
            for (int i = 0; i < b.Length; i++)
                Console.Write(b[i] + " ");
            Console.WriteLine() ;
            Console.WriteLine();
            Console.WriteLine("---------------------<FOR STRING ARRAY>---------------------");
            Console.WriteLine();

            string[] s = new string[5] {"Anshuman","Saikat","Olivia","Mahesh","Jogesh"};
            foreach(string s2 in s)
            {
                Console.Write(s2+" ");
            }
            Console.WriteLine();
            Array.Sort(s);
            Console.WriteLine("Array after sorting---> ");
            for (int i = 0; i < s.Length; i++)
            {
                Console.Write(s[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Array after Reversing----->");
            Array.Reverse(s);
            for (int i = 0; i < s.Length; i++)
            {
                Console.Write(s[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
            string[] s1 = new string[6];
            s1[0] = "Kamlesh";
            s.CopyTo(s1, 1);
            Console.WriteLine();
            
            Console.WriteLine("Array s1 After copying from s------->");
            for (int i = 0; i < s1.Length; i++)
                Console.Write(s1[i] + " ");
            Console.WriteLine();
            Console.Read();



        }
    }
}
