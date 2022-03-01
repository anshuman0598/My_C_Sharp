using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace ThreadingDemo9
{
    class ThreadingDemo
    {
        private void FirstMethod()
        {
            for (int i = 1; i <= 50; i++)
            {
                Console.Write("i=" + i + " ");
                Thread.Sleep(1000);
            }
        }
        private void SecondMethod()
        {
            for (int j = 1; j <= 50; j++)
            {
                Console.Write("j=" + j + " ");
                Thread.Sleep(1000);
                if (j == 20)
                    th1.Suspend();
                else if (j == 30)
                    th1.Resume();
            }
        }
        Thread th1, th2;
        public void Display()
        {
            th1 = new Thread(FirstMethod);
            th2 = new Thread(SecondMethod);
            th1.Start();
            th2.Start();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ThreadingDemo td = new ThreadingDemo();
            td.Display();
            Console.Read();
        }
    }
}


