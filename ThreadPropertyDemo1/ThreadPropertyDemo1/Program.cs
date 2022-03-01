using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace ThreadPropertyDemo1
{
    public class MyThread
    {
        public static void Thread1()
        {
            for(int i = 0; i < 10; i++)
                Console.WriteLine(i);
        }
        //public static void Thread2()
        //{
        //    for (char i = 'a'; i < 'k'; i++)
        //        Console.WriteLine(i);
        //}
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Thread t = Thread.CurrentThread;
            //t.Name = "Main Thread";
            //Console.WriteLine(t.Name);
            Thread t1= new Thread(new ThreadStart(MyThread.Thread1));
            Thread t2 = new Thread(new ThreadStart(MyThread.Thread1));

            t1.Start();
            t2.Start();
            Console.Read();
        }
    }
}
