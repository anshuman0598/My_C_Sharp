using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace FileDemo7_CreateFile_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string loc = "D:\\Demo3";
                FileInfo file = new FileInfo(loc);
                file.Create();
                Console.WriteLine("File Created Successfully");
            }
            catch (IOException ex)
            {
                Console.WriteLine("Kichu Akta Bhul Hoeche: "+ex.Message);
            }
            Console.ReadLine();

        }
            
    }
}
