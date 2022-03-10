using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace ThreadingDemo3_Abort_
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
                    Thread.Sleep(1000);
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Start of Main");
            MyThread mt = new MyThread();
            Thread t1 = new Thread(new ThreadStart(mt.Thread1));
            Thread t2 = new Thread(new ThreadStart(mt.Thread1));
            t1.Start();
            t2.Start();
            try
            {
                t1.Abort();
                t2.Abort();

            }
            catch (ThreadAbortException ex)
            {
                Console.WriteLine(ex.ToString());
            }
            Console.WriteLine("End of MAin");
            Console.ReadLine();
        }
    }
}
