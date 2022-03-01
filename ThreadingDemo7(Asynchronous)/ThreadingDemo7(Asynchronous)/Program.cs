using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace ThreadingDemo7_Asynchronous_
{
    class Printer
    {
        public void PrintTable()
        {
            lock(this) //Synchronysing
            {
                for (int i = 1; i <= 5; i++)
                {
                    Thread.Sleep(100);
                    Console.WriteLine(i);
                }
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Printer p = new Printer();
            Thread t1 = new Thread(new ThreadStart(p.PrintTable));
            Thread t2 = new Thread(new ThreadStart(p.PrintTable));
            t1.Start();
            t2.Start();
            Console.Read();
        }
    }
}
