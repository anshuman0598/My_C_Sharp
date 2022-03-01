using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace MultiThreadingExample
{
    class Threading
    {
        public void thread1()
        {
            lock (this)
            {
                for (int i = 1; i < 11; i++)
                {
                    Console.WriteLine(i);
                    Thread.Sleep(500);
                }
            }
        }
        
    }
    internal class Program
    {
        [Obsolete]
        static void Main(string[] args)
        {
            Threading mt = new Threading();
            Thread t1 = new Thread(new ThreadStart(mt.thread1));
            Thread t2 = new Thread(new ThreadStart(mt.thread1));
            Console.WriteLine("Thread 1 Started");
            t1.Start();
            Thread.Sleep(1500);
            t1.Suspend();
            Console.WriteLine("Thread 1 Suspended Thread 2 Started");
            t2.Start();
            Thread.Sleep(1000);
            t2.Suspend();
            Console.WriteLine("Thread 2 Suspended Thread 1 ReStarted");
            t1.Resume();
            Thread.Sleep(1500);
            t1.Suspend();
            Console.WriteLine("Thread 1 Suspended Thread 2 ReStarted");
            t2.Resume();
            Thread.Sleep(1000);
            t2.Suspend();
            Console.WriteLine("Thread 2 Suspended Thread 1 ReStarted");
            t1.Resume();
            t1.Join();
            Console.WriteLine("Thread 1 Complete Thread 2 ReStarted");
            t2.Resume();
            Console.Read();

        }
    }
}

//Console.WriteLine("Thread 1 State " + t1.ThreadState);
//Console.WriteLine("Thread 2 State " + t2.ThreadState);
//t1.Start();
//t2.Start();
//Console.WriteLine("Thread 1 State " + t1.ThreadState);
//Console.WriteLine("Thread 2 State " + t2.ThreadState);
//t1.Suspend();
//t2.Suspend();
//Console.WriteLine("Thread 1 State " + t1.ThreadState);
//Console.WriteLine("Thread 2 State " + t2.ThreadState);
//t1.Resume();
//t1.Join();
//Console.WriteLine("Thread 1 State " + t1.ThreadState);
//Console.WriteLine("Thread 2 State " + t2.ThreadState);
//t2.Resume();

////t1.Abort();
////t2.Abort();
////Console.WriteLine("Thread 1 State " + t1.ThreadState);
////Console.WriteLine("Thread 2 State " + t2.ThreadState);
//Console.Read();
