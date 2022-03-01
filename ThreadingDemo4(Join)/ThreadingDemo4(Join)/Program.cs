using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace ThreadingDemo4_Join_
{

    internal class Program
    {
        public class MyThread
        {
            public void Thread1()
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine(i);
                    Thread.Sleep(500);
                }
            }
            public void Thread2()
            {
                for (char i = 'a'; i < 'j'; i++)
                {
                    Console.WriteLine(i);
                    Thread.Sleep(1000);
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Start of Main");
            MyThread mt = new MyThread();
            Thread t1 = new Thread(new ThreadStart(mt.Thread2));
            Thread t2 = new Thread(new ThreadStart(mt.Thread1));
            Thread t3 = new Thread(new ThreadStart(mt.Thread1));
            t1.Start();
            t1.Join();
            t2.Start();
            t3.Start();
            Console.ReadLine();
        }
    }
}
