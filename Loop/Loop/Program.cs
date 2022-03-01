using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i;
            /* Console.WriteLine("The First eight even numbers in reverse order are:");
             for(i=2;i<=16;i+=2)
             {
                 Console.WriteLine(i);
             }
             Console.Read();
             /*while(i<=10)
             {
                 Console.WriteLine(i);
                 i++;
             }
             do
             {
                 Console.WriteLine(i);
                 i++;
             }while(i<=10);*/
            Console.WriteLine("The First five multiple of 3 are:");
            Console.WriteLine("Even    Odd");
            for(i = 0; i <= 10; i++)
            {
                if (i % 2 == 0)
                    Console.Write(i + "      ");
                else
                    Console.WriteLine(i);
               
            }
            Console.Read();

        }
    }
}
