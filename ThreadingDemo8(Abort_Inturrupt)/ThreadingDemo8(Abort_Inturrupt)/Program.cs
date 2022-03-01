using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace ThreadingDemo8_Abort_Inturrupt_
{
    class Program 
    { 
        static void Main(string[] args) 
        { 
            Thread thr = new Thread(Fun); 
            thr.Start(); 
            Thread.Sleep(300); 
            thr.Interrupt(); 
            thr.Abort(); 
            Console.WriteLine("Thread thr interrupted by main thread."); 
            Console.ReadLine();
        } 
        static void Fun() 
        { 
            Console.WriteLine("Thread thr is working."); 
            for (int i = 0; ; i++) 
            { 
                try 
                { 
                    Console.WriteLine(i); 
                    Thread.Sleep(50); 
                } 
                catch 
                { 
                } 
            } 

        } 
    }
}


