using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2D array___________________________________
            int c = 0;
            int[,] a = new int[3, 4];
            a[0, 0] = 50; a[0, 1] = 60; a[0, 2] = 40; a[0, 3] = 90;
            a[1, 0] = 39; a[1, 1] = 35; a[1, 2] = 79; a[1, 3] = 32;
            a[2, 0] = 24; a[2, 1] = 80; a[2, 2] = 89; a[2, 3] = 10;
            /*foreach(int i in a)
            {
                Console.Write(i+ " ");
                c++;
                if(c==4)
                {
                    Console.WriteLine();
                    c = 0;
                }

            }*/
            for(int i=0;i<3; i++)
            {
                for(int j=0;j<4;j++)
                {
                    Console.Write(a[i,j]+" ");
                }
                Console.WriteLine();
            }
            //Jaggred Array__________________________________
            /*int[][] a = new int[3][];
            a[0]=new int[3] {1,2,3};
            a[1] = new int[5] { 1, 2, 3, 4, 5 };
            a[2] = new int[2] { 7, 8 };

            foreach(int [] i in a)
            {
                foreach(int j in i)
                {
                    Console.Write(j+" ");
                }
                Console.WriteLine();
            }*/

            Console.Read();
        }
    }
}
